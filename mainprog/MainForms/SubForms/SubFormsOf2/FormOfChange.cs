using HumansLib;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainProg.MainForms.SubForms.SubFormsOf2;

public partial class FormOfChange : Form
{
    List<Humans> victims;

    ListBox listBox;

    public FormOfChange(List<Humans> victims, ListBox listBox)
    {
        InitializeComponent();
        this.victims = victims;
        this.listBox = listBox;

        var i = listBox.SelectedIndex;
        name_textBox.Text = victims[i].Name;
        age_textBox.Text = victims[i].Age.ToString();
        adress_textBox.Text = victims[i].Adress;
        descriptions_textBox.Text = victims[i].Descriptions;
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(name_textBox.Text)
                && !string.IsNullOrWhiteSpace(age_textBox.Text)
                && int.TryParse(age_textBox.Text, out int age)
                && !string.IsNullOrWhiteSpace(adress_textBox.Text)
                && !string.IsNullOrWhiteSpace(descriptions_textBox.Text))
        {
            var i = listBox.SelectedIndex;

            victims[i].Name = name_textBox.Text;
            victims[i].Age = age;
            victims[i].Adress = adress_textBox.Text;
            victims[i].Descriptions = descriptions_textBox.Text;
            listBox.Items[i] = name_textBox.Text;
            this.Close();
        }
    }
}
