using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatexDraw
{
    public partial class LatexDraw : Form
    {
        private string _path;
        private string _name;
        private string _title;

        private string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                PathBox.Text = _path;
            }
        }

        public LatexDraw()
        {
            InitializeComponent();
            TitleBox.Text = "Title";
            StatusLbl.Text = "Enter path, title and filename.";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            bool isPathInvalid = Path == "" || Path == null;
            bool isNameInvalid = _name == "" || _name == null;
            if (isNameInvalid && isPathInvalid)
                StatusLbl.Text = "Enter path and filename.";
            else if (isPathInvalid)
                StatusLbl.Text = "Enter path.";
            else if (isNameInvalid)
                StatusLbl.Text = "Enter filename";
            else
            {
                try
                {
                    Logic.Create(Path, _name, _title);
                    StatusLbl.Text = "Files created successfully.";
                }
                catch (Exception ex)
                {
                    StatusLbl.Text = ex.Message;
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _BrowseDialog = new FolderBrowserDialog();
            _BrowseDialog.ShowDialog();
            Path = _BrowseDialog.SelectedPath;
            _BrowseDialog.Dispose();
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            Path = PathBox.Text;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _name = NameBox.Text;
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            _title = TitleBox.Text;
        }

        private void LatexDraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                StatusLbl.Text = "Return pressed";
                CreateBtn_Click(sender, e as EventArgs);
            }

        }
    }
}
