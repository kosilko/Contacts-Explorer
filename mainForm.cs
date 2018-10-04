using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using OfficeOpenXml;
using System.IO;
using System.Media;
using System.Collections.Specialized;
using System.Net;
using System.Threading;

namespace ContactsExplorer {
  public partial class mainForm: Form {
    public mainForm() {
      InitializeComponent();
    }


    private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
      contactPictureBox.Image = null;
      if (mainDataGrid.SelectedRows.Count > 0) {
        var img = mainDataGrid.SelectedRows[0].Cells["image"].Value;
        if (img != null) {
          contactPictureBox.ContextMenuStrip = pictureMenuStrip;
          contactPictureBox.Image = (Image)mainDataGrid.SelectedRows[0].Cells["image"].Value;
        }
        else {
          contactPictureBox.ContextMenuStrip = null;
        }
      }

    }

    private void viberToolStripMenuItem_Click(object sender, EventArgs e) {
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ViberPC";
      openFileDialog.FileName = "config.db";
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        string fn = System.IO.Path.GetFileName(openFileDialog.FileName);
        try {
          if (fn == "config.db") {
            var db = new SQLiteConnection(@"Data Source=" + openFileDialog.FileName + ";Version=3;");
            db.Open();
            var r = (new SQLiteCommand("select * from Accounts;", db)).ExecuteReader();
            var ids = new List<string> { r.GetValues()["ID"] };
            db.Close();
            db.Dispose();
            var dir = System.IO.Directory.GetParent(openFileDialog.FileName).FullName;
            foreach (string id in ids) {
              processViberDB(dir + "\\" + id + "\\viber.db");
            }
          }
          else {
            processViberDB(openFileDialog.FileName);
          }
        }
        catch {
          MessageBox.Show("Can not open database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void processViberDB(string dbFileName) {
      if (!filterViber.Checked && !filterViberAccounts.Checked) {
        filterViber.Checked = true;
      }
      string avatarDirectory = System.IO.Directory.GetParent(dbFileName).FullName + "\\Avatars";
      Bitmap viberIcon = Image.FromHbitmap(Properties.Resources.viber.GetHbitmap());
      Bitmap viberIconGray = Image.FromHbitmap(Properties.Resources.viber_gray.GetHbitmap());
      Bitmap viberIconGreen = Image.FromHbitmap(Properties.Resources.viber_green.GetHbitmap());

      SQLiteConnection db = new SQLiteConnection(@"Data Source=" + dbFileName + ";Version=3;");

      db.Open();
      SQLiteDataReader r = new SQLiteCommand("select * from Contact;", db).ExecuteReader();

      while (r.Read()) {
        NameValueCollection record = r.GetValues();

        int i = mainDataGrid.Rows.Add();

        mainDataGrid.Rows[i].Tag = "viber";
        mainDataGrid.Rows[i].Cells["num"].Value = i + 1;
        mainDataGrid.Rows[i].Cells["type"].Value = (record["ViberContact"] == "1" ? (record["EncryptedNumber"] != "" ? viberIconGreen : viberIcon) : viberIconGray);
        mainDataGrid.Rows[i].Cells["type"].Tag = record["EncryptedNumber"] != "" ? "2" : (record["ViberContact"] == "1" ? "1" : "0");


        if (record["DownloadID"].Length > 0) {
          try {
            mainDataGrid.Rows[i].Cells["image"].Value = Image.FromFile(avatarDirectory + "\\" + record["DownloadID"]);
          }
          catch { }
        }

        mainDataGrid.Rows[i].Cells["name"].Value = record["Name"] + (record["ClientName"] != "" ? " [" + record["ClientName"] + "]" : "");
        mainDataGrid.Rows[i].Cells["phone"].Value = record["Number"];
        SQLiteDataReader r1 = (new SQLiteCommand("select * from Events where ContactID = " + record["ContactID"]  + " order by TimeStamp desc limit 1;", db)).ExecuteReader();
        double.TryParse(r1.GetValues()["TimeStamp"], out double ts);
        if (ts > 0) {
          mainDataGrid.Rows[i].Cells["timestamp"].Value = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds((int)(ts / 1000)).ToString("yyyy.MM.dd, HH:mm:ss");
        }
      }
      mainDataGrid.ClearSelection();
      db.Close();


      // end of work:
      db.Dispose();
      applyFilters();
    }

    private void skypeToolStripMenuItem1_Click(object sender, EventArgs e) {
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Skype";
      openFileDialog.FileName = "main.db";
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        string fn = System.IO.Path.GetFileName(openFileDialog.FileName);
        if (fn == "main.db") {
          try {
            processSkypeDB(openFileDialog.FileName);
          }
          catch {
            MessageBox.Show("Can not open database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void processSkypeDB(string dbFileName) {
      if (!filterSkype.Checked) {
        filterSkype.Checked = true;
      }
      Bitmap skypeIcon = Image.FromHbitmap(Properties.Resources.skype.GetHbitmap());
      
      SQLiteConnection db = new SQLiteConnection(@"Data Source=" + dbFileName + ";Version=3;");

      db.Open();
      var r = (new SQLiteCommand("select * from Contacts where type = 1 and isauthorized;", db)).ExecuteReader();
      while (r.Read()) {
        NameValueCollection record = r.GetValues();
        int i = mainDataGrid.Rows.Add();
        mainDataGrid.Rows[i].Cells["num"].Value = i + 1;
        mainDataGrid.Rows[i].Tag = "skype";
        mainDataGrid.Rows[i].Cells["type"].Value = skypeIcon;
        mainDataGrid.Rows[i].Cells["type"].Tag = "0";

        string ava;
        if ((ava = record["avatar_hiresurl"]).Length > 0 ||
            (ava = record["avatar_hiresurl_new"]).Length > 0 ||
            (ava = record["avatar_url"]).Length > 0 ||
            (ava = record["avatar_url_new"]).Length > 0) {
   
          new Thread((object ava_url) => {
            WebClient client = new WebClient();
            try {
              string _ava = ava_url.ToString().Replace("&size=m", "&size=l");
              _ava = _ava.Replace("&returnDefaultImage=false", "&returnDefaultImage=true");
              var stream = client.OpenRead(_ava);
              var bmp = new Bitmap(stream);
              BeginInvoke((MethodInvoker)(() => {
                mainDataGrid.Rows[i].Cells["image"].Value = bmp;
              }));
            }
            catch { }
            finally {
              client.Dispose();
            }
              
          }).Start(ava);
          
        }

        mainDataGrid.Rows[i].Cells["name"].Value = (record["fullname"].Length > 0 ? record["fullname"] : record["displayname"]) + " [" + record["skypename"] + "]";
        mainDataGrid.Rows[i].Cells["phone"].Value = record["phone_mobile"].Length > 0 ? record["phone_mobile"] : record["phone_home"].Length > 0 ? record["phone_home"] : record["phone_office"];
     
        double.TryParse(record["lastonline_timestamp"], out double ts);
        if (ts > 0) {
          mainDataGrid.Rows[i].Cells["timestamp"].Value = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds((int)(ts)).ToString("yyyy.MM.dd, HH:mm:ss");
        }

      }
      db.Close();
      db.Dispose();
      applyFilters();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("Contacts Explorer v 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void pictureBox1_Click(object sender, EventArgs e) {
      if (contactPictureBox.Image != null) {
        saveFileDialog.FileName = mainDataGrid.SelectedRows[0].Tag + " " + mainDataGrid.SelectedRows[0].Cells["name"].Value + ", " + mainDataGrid.SelectedRows[0].Cells["phone"].Value + ".jpg";
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
          contactPictureBox.Image.Save(saveFileDialog.FileName);
        }
      }
    }

    private void pictureBox1_MouseHover(object sender, EventArgs e) {
      contactPictureBox.Cursor = contactPictureBox.Image != null ? Cursors.Hand : Cursors.Default;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
      pictureBox1_Click(sender, e);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
      if (contactPictureBox.Image != null) {
        Clipboard.SetImage(contactPictureBox.Image);
      }
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
      mainDataGrid.Rows.Clear();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void dataGridView1_Sorted(object sender, EventArgs e) {
      foreach (DataGridViewRow row in mainDataGrid.Rows) {
        row.DefaultCellStyle.BackColor = row.Index%2 == 0 ? Color.FromArgb(255, 255, 230) : Color.FromArgb(255, 230, 255);
      }
    }

    private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
      dataGridView1_Sorted(sender, e);
    }

    private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
      ExcelPackage package = new ExcelPackage();
      ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Contacts");
      foreach (DataGridViewColumn c in mainDataGrid.Columns) {
        worksheet.Column(c.Index + 1).Style.WrapText = false;
        worksheet.Column(c.Index + 1).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
        worksheet.Cells[1, c.Index + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        worksheet.Cells[1, c.Index + 1].Style.Fill.BackgroundColor.SetColor(mainForm.DefaultBackColor);
        worksheet.Cells[1, c.Index + 1].Value = c.HeaderText.Length > 0 ? c.HeaderText : c.Name;
      }
      int idx = 0;
      foreach (DataGridViewRow r in mainDataGrid.Rows) {
        if (r.Visible) {
          idx++;
          foreach (DataGridViewCell c in r.Cells) {
            ExcelRange cell = worksheet.Cells[idx + 1, c.ColumnIndex + 1];
            cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            cell.Style.Fill.BackgroundColor.SetColor(r.DefaultCellStyle.BackColor);
            if (c.Value != null) {
              if (mainDataGrid.Columns[c.ColumnIndex].CellType == typeof(DataGridViewImageCell)) {
                OfficeOpenXml.Drawing.ExcelPicture picture = worksheet.Drawings.AddPicture(idx.ToString() + "." + c.ColumnIndex.ToString(), (Image)(c.Value));
                picture.From.Column = picture.To.Column = c.ColumnIndex;
                picture.From.Row = picture.To.Row = idx;
                picture.SetSize(18, 18);
              }
              else {
                cell.Value = c.Value.ToString().Replace("\n", " ").Replace("  ", " ");
              }
            }
          }
        }
      }
      worksheet.Cells.AutoFitColumns();
      SaveFileDialog saveDialog = new SaveFileDialog {
        Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
        FilterIndex = 1,
        FileName = "Contacts " + DateTime.Now.ToString("yyyy.MM.dd, HH-mm-ss")
      };
      if (saveDialog.ShowDialog() == DialogResult.OK) {
        bool complete = false;
        while (!complete) {
          try {
            package.SaveAs(new FileInfo(saveDialog.FileName));
            SystemSounds.Asterisk.Play();
            complete = true;
            if (MessageBox.Show("Open file " + saveDialog.FileName + "?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
              System.Diagnostics.Process.Start(saveDialog.FileName);
            }
          }
          catch {
            complete = MessageBox.Show("File is locked by another application.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel;
          }
        }
      }
    }

    private void menuStrip1_MenuActivate(object sender, EventArgs e) {
      saveToolStripMenuItem1.Enabled = clearToolStripMenuItem.Enabled = mainDataGrid.Rows.Count > 0;
    }

    private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e) {
      if (e.Column.Name == "type") {
        DataGridViewRow row1 = ((DataGridView)(sender)).Rows[e.RowIndex1];
        DataGridViewRow row2 = ((DataGridView)(sender)).Rows[e.RowIndex2];       
        e.SortResult = string.Compare(row1.Tag.ToString() + ":" + row1.Cells["type"].Tag.ToString(), row2.Tag.ToString() + ":" + row2.Cells["type"].Tag.ToString());
        e.Handled = true;
      }
    }

    private void applyFilters() {
      foreach (DataGridViewRow r in mainDataGrid.Rows) {
        if (r.Tag.ToString() == "skype") {
          r.Visible = filterSkype.Checked;
        }
        else if (filterViberAccounts.Checked) {
          r.Visible = r.Cells["type"].Tag.ToString() != "0";
        }
        else {
          r.Visible = filterViber.Checked;
        }
        if (!r.Visible && r.Selected) {
          r.Selected = false;
        }
      }
    }

    // todo: refactor this logic
    private void filterAll_CheckedChanged(object sender, EventArgs e) {
      if (filterAll.Checked) {
        filterViber.Checked = filterSkype.Checked = true;
        filterViberAccounts.Checked = false;
      }
      else if (filterViber.Checked && filterSkype.Checked) {
        filterAll.Checked = true;
      }
      applyFilters();
    }

    private void filterViber_CheckedChanged(object sender, EventArgs e) {
      if (!filterViber.Checked) {
        filterAll.Checked = false;
        if (!filterSkype.Checked && !filterViberAccounts.Checked) {
          filterSkype.Checked = true;
        }
      }
      else {
        filterViberAccounts.Checked = false;
        if (filterSkype.Checked && !filterAll.Checked) {
          filterAll.Checked = true;
        }
      }
      applyFilters();
    }

    private void filterViberAccounts_CheckedChanged(object sender, EventArgs e) {
      if (filterViberAccounts.Checked) {
        filterViber.Checked = false;
        filterAll.Checked = false;
      }
      else if (!filterViber.Checked && !filterSkype.Checked) {
        filterViber.Checked = true;
      }
      applyFilters();
    }

    private void filterSkype_CheckedChanged(object sender, EventArgs e) {
      if (!filterSkype.Checked) {
        if (!filterViber.Checked && !filterViberAccounts.Checked) {
          filterViber.Checked = true;
        }
        filterAll.Checked = false;
      }
      else if (filterViber.Checked) {
         filterAll.Checked = true;
      }
      applyFilters();
    }

    private void mainForm_Load(object sender, EventArgs e) {
      filterAll.Checked = true;
    }



    private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e) {

      var rows = mainDataGrid.SelectedRows;
      if (rows.Count > 0) {
        Clipboard.SetText(rows[0].Cells["name"].Value + "\t" + rows[0].Cells["phone"].Value);
      }
    }

    private void listMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
      copyToClipboardToolStripMenuItem.Enabled = mainDataGrid.SelectedRows.Count > 0;
    }

    private void mainDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
      mainDataGrid.Rows[e.RowIndex].Selected = true;
    }
  }
}
