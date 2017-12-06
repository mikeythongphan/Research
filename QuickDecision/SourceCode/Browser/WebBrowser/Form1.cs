using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net;

namespace WebBrowser
{
    public partial class QuickDecision : Form
    {
        public static string url = string.Empty;
        public QuickDecision()
        {
       
            InitializeComponent();
            ErpWeb.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           

        }      
    
        private void QuickDecision_Load(object sender, EventArgs e)
        {
            if (url == string.Empty)
            {
                System.IO.FileStream fsReadXml = new System.IO.FileStream(Application.StartupPath + @"\Setup.xml", System.IO.FileMode.Open);
                DataSet ds = new DataSet();
                ds.ReadXml(fsReadXml);
                fsReadXml.Flush();
                fsReadXml.Dispose();
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        url = ds.Tables[0].Rows[0][0].ToString();
            }
            if (url != string.Empty)
            {
                ErpWeb.Url = new Uri(url+"/index.aspx");
                ErpWeb.Refresh();
            }            
        }        
        private bool Isrun = true;
        private void ErpWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ErpWeb.Show();
            //if (e.Url.AbsolutePath.Equals("blank") && Isrun)
            //{
            //    Isrun = false;
            //    Url = "chinh.html";
            //    ErpWeb.Url = new Uri(Url);
            //    ErpWeb.Refresh();
            //}
        }

        private void ErpWeb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
                        
        }

        private void ErpWeb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsolutePath.ToLower().Contains("index.aspx"))
            if(e.Url.Query.Contains("exit=1"))
                Application.Exit();
                
        }

        private void ErpWeb_FileDownload(object sender, EventArgs e)
        {

        }

        private void ErpWeb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if ((e.Control && e.KeyCode == Keys.N) || (e.KeyCode == Keys.F5 && !e.Control))
                    return;
                else
                    if (e.Control && e.KeyCode == Keys.F5)
                        Cache.ClearCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                
            }
            
                    
        }

        private void QuickDecision_KeyDown(object sender, KeyEventArgs e)
        {
                        
        }
        
    }
}
