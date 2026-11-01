using humans;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf2;

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
        name_textBox.Text = victims[i].GetName();
        age_textBox.Text = victims[i].GetAge().ToString();
        adress_textBox.Text = victims[i].GetAdress();
        descriptions_textBox.Text = victims[i].GetDescriptions();
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

            victims[i].SetName(name_textBox.Text);
            victims[i].SetAge(age);
            victims[i].SetAdress(adress_textBox.Text);
            victims[i].SetDescriptions(descriptions_textBox.Text);
            listBox.Items[i] = name_textBox.Text;
            this.Close();
        }
    }
}
