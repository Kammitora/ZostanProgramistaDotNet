using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T6Ll3PracaDomowa
{
    public partial class ImageFrame : Form
    {
        public string ImagePath 
        {
            get
            {
                return Properties.Settings.Default.ImagePath;
            }
            set
            {
                Properties.Settings.Default.ImagePath = value;
            }
        }
        public ImageFrame()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(ImagePath))
            {
                ptrbxMain.Image = new Bitmap(ImagePath);
                btnDelete.Visible = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                ptrbxMain.Image = new Bitmap(open.FileName);
                ImagePath = open.FileName;
                Properties.Settings.Default.Save();
                btnDelete.Visible = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zdjęcie z ramki?", "Usunięcie zdjęcia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ptrbxMain.Image = null;
                ImagePath = null;
                Properties.Settings.Default.Save();
                btnDelete.Visible = false;
                btnAdd.Enabled = true;

            }
        }
    }
}
