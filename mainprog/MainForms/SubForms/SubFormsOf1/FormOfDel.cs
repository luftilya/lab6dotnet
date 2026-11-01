using buckets_with_apples;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf1;

public partial class FormOfDel : Form
{
    List<BucketWithApples> buckets;

    ListBox listBox;

    Label info_label;

    public FormOfDel(List<BucketWithApples> buckets, ListBox listBox, Label label)
    {
        InitializeComponent();
        this.buckets = buckets;
        this.info_label = label;
        this.listBox = listBox;
    }

    private void yes_button_Click(object sender, EventArgs e)
    {
        var index = listBox.SelectedIndex;

        buckets.RemoveAt(index);
        listBox.Items.RemoveAt(index);
        listBox.SelectedIndex = -1;

        for (int i = 0; i < listBox.Items.Count; i++)
            listBox.Items[i] = "Кор. №" + (i + 1);
        info_label.Text = "Корзинка\nпропала!..";

        this.Close();
    }

    private void no_button_Click(object sender, EventArgs e)
       => this.Close();
}
