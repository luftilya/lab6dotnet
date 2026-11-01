using buckets_with_apples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mainprog.MainForms.SubForms.SubFormsOf1
{
    public partial class FormOfPull : Form
    {
        List<BucketWithApples> buckets;

        ListBox listBox;

        Label info_label;

        public FormOfPull(List<BucketWithApples> buckets, ListBox listBox, Label label)
        {
            InitializeComponent();
            this.buckets = buckets;
            this.listBox = listBox;
            this.info_label = label;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var index = listBox.SelectedIndex;

            if (!string.IsNullOrWhiteSpace(textBox.Text)
                && int.TryParse(textBox.Text, out int n)
                && n > 0 && n <= buckets[index].GetApplesCount())
            {
                buckets[index].RemoveApples(n);
                info_label.Text = buckets[index].GetApplesCount().ToString();
            }
            this.Close();
        }
    }
}
