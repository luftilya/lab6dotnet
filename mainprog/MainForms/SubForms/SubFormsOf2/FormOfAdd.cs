using humans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf2;

public partial class FormOfAdd : Form
{
    List<Humans> humans;

    ListBox listBox;

    public FormOfAdd(List<Humans> humans, ListBox listBox)
    {
        InitializeComponent();
        this.humans = humans;
        this.listBox = listBox;
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(name_textBox.Text)
            && !string.IsNullOrWhiteSpace(age_textBox.Text)
            && int.TryParse(age_textBox.Text, out int age)
            && !string.IsNullOrWhiteSpace(adress_textBox.Text)
            && !string.IsNullOrWhiteSpace(descriptions_textBox.Text))
        {
            humans.Add(new Humans(
                name_textBox.Text,
                age,
                adress_textBox.Text,
                descriptions_textBox.Text
                ));
            listBox.Items.Add(name_textBox.Text);
            this.Close();
        }
    }
}
