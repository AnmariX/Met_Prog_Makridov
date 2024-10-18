using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FrmHelp : Form
    {
        private System.Windows.Forms.Label txtHelp;

        public FrmHelp()
        {
            this.KeyDown += new KeyEventHandler(Frm_KeyDown);
            this.KeyPreview = true;

            this.txtHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtHelp
            //
            this.txtHelp.Location = new System.Drawing.Point(0, 0);
            this.txtHelp.Size = new System.Drawing.Size(700, 350);
            this.txtHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHelp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // 
            // frmHelp
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.txtHelp);
            this.Name = "FrmHelp";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.ResumeLayout(false);
            this.KeyPreview = true;
        }
        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.H) //При нажатии Ctrl + H
            {
                txtHelp.Text = null;
            }
        }
        private void FrmHelp_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("..\\..\\Help.txt");
            txtHelp.Text = sr.ReadToEnd();
            sr.Close();
            this.Resize += FrmHelp_Resize;
        }

        private void FrmHelp_Resize(object sender, EventArgs e)
        {
            this.txtHelp.Size = this.ClientSize;
        }
    }
}