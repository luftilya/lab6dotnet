using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf3;

public partial class FormOfAdd : Form
{
    Hashtable ht;

    ListBox lB;

    public FormOfAdd(Hashtable ht, ListBox lB)
    {
        InitializeComponent();
        this.ht = ht;
        this.lB = lB;
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nick_textBox.Text) && !string.IsNullOrWhiteSpace(adress_textBox.Text))
        {
            ht[adress_textBox.Text] = nick_textBox.Text;
            lB.Items.Add(adress_textBox.Text);
            this.Close();
        }
    }
}
