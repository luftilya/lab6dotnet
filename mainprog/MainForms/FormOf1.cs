using buckets_with_apples;
using mainprog.MainForms.SubForms.SubFormsOf1;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf1 : Form
{
    List<BucketWithApples> buckets = new List<BucketWithApples>();

    public FormOf1()
    {
        InitializeComponent();
        buckets_listBox.ContextMenuStrip = contextMenuStrip;
    }

    private void add_bucket_button_Click(object sender, EventArgs e)
    {
        buckets.Add(new BucketWithApples());
        buckets_listBox.Items.Add("Кор. №" + buckets.Count);
    }

    private void buckets_listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = buckets_listBox.SelectedIndex;

        if (index is not ListBox.NoMatches)
            info_label.Text = buckets[index].GetApplesCount().ToString();
    }

    private void listBox_MouseDown(object sender, MouseEventArgs mouse)
    {
        if (mouse.Button == MouseButtons.Right)
        {
            var index = buckets_listBox.IndexFromPoint(mouse.Location);

            if (index is not ListBox.NoMatches)
                buckets_listBox.SelectedIndex = index;
        }
    }

    private void put_apples_click(object sender, EventArgs e)
    {
        if (buckets_listBox.SelectedIndex is not ListBox.NoMatches)
            new FormOfPut(buckets, buckets_listBox, info_label).ShowDialog();
    }

    private void pull_apples_click(object sender, EventArgs e)
    {
        if (buckets_listBox.SelectedIndex is not ListBox.NoMatches)
            new FormOfPull(buckets, buckets_listBox, info_label).ShowDialog();
    }

    private void kick_out_bucket_click(object sender, EventArgs e)
    {
        if (buckets_listBox.SelectedIndex is not ListBox.NoMatches)
            new FormOfDel(buckets, buckets_listBox, info_label).ShowDialog();
    }
}
