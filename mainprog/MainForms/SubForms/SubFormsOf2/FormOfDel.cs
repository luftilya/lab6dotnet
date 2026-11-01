using humans;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog.MainForms.SubForms.SubFormsOf2;

public partial class FormOfDel : Form
{
    List<Humans> victims;

    ListBox listBox;

    Label name_label, 
        age_label, 
        adress_label, 
        descriptions_label;

    public FormOfDel(
        List<Humans> victims, 
        ListBox listBox,
        Label name_label,
        Label age_label,
        Label adress_label,
        Label descriptions_label)
    {
        InitializeComponent();

        this.victims = victims;
        this.listBox = listBox;

        this.name_label = name_label;
        this.age_label = age_label;
        this.adress_label = adress_label;
        this.descriptions_label = descriptions_label;
    }

    private void yes_button_Click(object sender, EventArgs e)
    {
        victims.RemoveAt(listBox.SelectedIndex);
        listBox.Items.RemoveAt(listBox.SelectedIndex);
        listBox.SelectedIndex = ListBox.NoMatches;

        name_label.Text = "ФИО";
        age_label.Text = "ВОЗРАСТ";
        adress_label.Text = "МЕСТО РОЖДЕНИЯ";
        descriptions_label.Text = "ПОДРОБНОСТИ САНКЦИИ";
        this.Close();
    }

    private void no_button_Click(object sender, EventArgs e) => this.Close();
}
