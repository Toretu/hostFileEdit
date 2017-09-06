using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostfilEdit
{
    public partial class Form1 : Form
    {
        string hostFile;
        string hostfilePath = @"C:\Windows\System32\drivers\etc\hosts";
        string backupPath = @"C:\temp\hostfiles\";
        public Form1()
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(editHostfile.Text))
            {
                LastOgLagre();
            }
        }

        private void loadHostFile_Click(object sender, EventArgs e)
        {

            string contents = System.IO.File.ReadAllText(hostfilePath);
            editHostfile.Text=contents;
        }
        private void LastOgLagre ()
        {
            if(!Directory.Exists(backupPath))
            { 
                Directory.CreateDirectory(backupPath);
            }
            string innhold = System.IO.File.ReadAllText(hostfilePath);
            editHostfile.Text= innhold;
            System.IO.File.WriteAllText(backupPath+"backupHost-oppstart.txt", editHostfile.Text);
            lagretStatus.BackColor = Color.Green;
            lagretStatus.Text = "Lagret!";
        }
        private void BKhost_Click(object sender, EventArgs e)
        {
            string timeStamp = DateTime.Now.ToString("dd.MM.yyyy_HH-mm");
            string path = backupPath+"backupHost";
            System.IO.File.WriteAllText(path+"-"+timeStamp+".txt", editHostfile.Text);
        }

        private void saveThis_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(hostfilePath, editHostfile.Text);
            lagretStatus.BackColor = Color.Green;
            lagretStatus.Text = "Lagret!";
        }

        private void editHostfile_TextChanged(object sender, EventArgs e)
        {
            lagretStatus.BackColor = Color.Red;
            lagretStatus.Text = "Ikke lagret!";

        }

        private void editHostfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
                System.IO.File.WriteAllText(hostfilePath, editHostfile.Text);
            lagretStatus.BackColor = Color.Green;
            lagretStatus.Text = "Lagret!";
        }
        

    }
}
