using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SetUpdateUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fsReadXml = new System.IO.FileStream(Application.StartupPath+ @"\Setup.xml", System.IO.FileMode.Open);
            DataSet ds = new DataSet();
            ds.ReadXml(fsReadXml);
            if (ds.Tables.Count > 0)
                ds.Tables[0].Rows[0][0] = txtUrl.Text.Trim();
            fsReadXml.Flush();
            fsReadXml.Dispose();
            File.Delete("Setup.xml");
            using (System.IO.FileStream stream = System.IO.File.Create(Application.StartupPath + @"\Setup.xml", 1024))
                  ds.WriteXml(stream);
            
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.FileStream fsReadXml = new System.IO.FileStream(Application.StartupPath + @"\Setup.xml", System.IO.FileMode.Open);
            DataSet ds = new DataSet();
            ds.ReadXml(fsReadXml);
            fsReadXml.Flush();
            fsReadXml.Dispose();
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                    txtUrl.Text = ds.Tables[0].Rows[0][0].ToString();

        }
    }
}
