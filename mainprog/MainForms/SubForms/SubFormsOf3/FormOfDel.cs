using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf3;

public partial class FormOfDel : Form
{
    Hashtable ht;

    ListBox lB;

    Label nl, al;

    public FormOfDel(Hashtable ht, ListBox lB, Label nl, Label al)
    {
        InitializeComponent();
        this.ht = ht;
        this.lB = lB;
        this.nl = nl;
        this.al = al;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ht.Remove(lB.SelectedItem?.ToString());

        nl.Text = "Боже! Куда он делся?!";
        al.Text = "И дома-то нет!!";
        this.Close();
    }

    private void no_button_Click(object sender, EventArgs e)
        => this.Close();
}
