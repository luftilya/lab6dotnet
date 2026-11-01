using mainprog.MainForms.SubForms.SubFormsOf3;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf3 : Form
{
    Hashtable hashtable = new Hashtable();

    public FormOf3()
    {
        InitializeComponent();
        listBox.ContextMenuStrip = contextMenuStrip;
    }

    private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        => new FormOfAdd(hashtable, listBox).ShowDialog();

    private void change_ToolStripMenuItem_Click(object sender, EventArgs e)
        => new FormOfChange(hashtable, nick_label, adress_label, listBox).ShowDialog();
    private void delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        => new FormOfDel(hashtable, listBox, nick_label, adress_label).ShowDialog();

    private void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        adress_label.Text = listBox.SelectedItem?.ToString();
        nick_label.Text = hashtable[listBox.SelectedItem?.ToString()].ToString();
    }
}
