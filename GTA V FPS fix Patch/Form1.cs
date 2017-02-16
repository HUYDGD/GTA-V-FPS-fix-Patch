﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_V_FPS_fix_Patch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string orgFile = "settings.xml";
                string repFile = GTA_V_FPS_fix_Patch.Resource1.settings;
                orgFile = System.IO.Path.Combine(path, orgFile);
                File.Delete(orgFile);
                var fileStream = File.Create(orgFile);
                fileStream.Close();
                File.AppendAllText(orgFile, repFile); 
            }
            catch (Exception k)
            {
                MessageBox.Show(k.ToString());
            }
        }
    }
}
