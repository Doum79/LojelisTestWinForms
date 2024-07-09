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
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            FormSampleCalculation.CalculateSample(out string aquitaineRuleText, out string classicRuleText);
            richTextBoxAquitaineRule.Text = aquitaineRuleText;
            richTextBoxClassicRule.Text = classicRuleText;
        }
    }
}
