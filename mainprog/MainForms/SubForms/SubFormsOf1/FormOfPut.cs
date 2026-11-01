using buckets_with_apples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf1;

public partial class FormOfPut : Form
{
    List<BucketWithApples> buckets;

    ListBox listBox;

    Label info_label;

    public FormOfPut(List<BucketWithApples> buckets, ListBox listBox, Label info_label)
    {
        InitializeComponent();
        this.buckets = buckets;
        this.listBox = listBox;
        this.info_label = info_label;
    }

    private void button_Click(object sender, EventArgs e)
    {
        var index = listBox.SelectedIndex;

        if (!string.IsNullOrWhiteSpace(textBox.Text) 
            && int.TryParse(textBox.Text, out int n))
        {
            buckets[index].AddApples(n);
            info_label.Text = buckets[index].GetApplesCount().ToString();
        }
        this.Close();
    }
}
