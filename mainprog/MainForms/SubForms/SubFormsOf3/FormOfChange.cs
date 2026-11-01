using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf3;

public partial class FormOfChange : Form
{
    Hashtable ht;

    Label nl, al;

    ListBox lB;

    public FormOfChange(Hashtable ht, Label nl, Label al, ListBox lB)
    {
        InitializeComponent();

        this.ht = ht;
        this.lB = lB;
        this.nl = nl;
        this.al = al;

        nick_label.Text = ht[lB.SelectedItem?.ToString()]?.ToString() ?? "";
        adress_label.Text = lB.SelectedItem?.ToString() ?? "";
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text))
        {
            ht[lB.SelectedItem?.ToString()] = textBox.Text;

            nl.Text = textBox.Text;
            al.Text = lB.SelectedItem?.ToString();
            this.Close();
        }
    }
}
