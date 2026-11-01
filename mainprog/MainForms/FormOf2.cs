using humans;
using mainprog.MainForms.SubForms.SubFormsOf2;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf2 : Form
{
    List<Humans> victims = new List<Humans>();

    public FormOf2()
    {
        InitializeComponent();
        listBox.ContextMenuStrip = contextMenuStrip;

        victims.Add(new Humans(
            "Зеленев Илья Николаевич",
            18,
            "Политехнический пер., 4",
            "ст. 58-10"
            ));
        listBox.Items.Add(victims[0].GetName());
    }

    private void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var i = listBox.SelectedIndex;

        if (i is ListBox.NoMatches)
            return;

        name_label.Text = victims[i].GetName();
        age_label.Text = victims[i].GetAge().ToString();
        adress_label.Text = victims[i].GetAdress();
        descriptions_label.Text = victims[i].GetDescriptions();
    }

    private void listBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            var index = listBox.IndexFromPoint(e.Location);

            if (index is not ListBox.NoMatches)
                listBox.SelectedIndex = index;
        }
    }

    private void add_victim_Click(object sender, EventArgs e)
        => new FormOfAdd(victims, listBox).ShowDialog();

    private void change_victim_Click(object sender, EventArgs e)
        => new FormOfChange(victims, listBox).ShowDialog();

    private void del_victim_Click(object sender, EventArgs e)
        => new FormOfDel(victims, listBox, 
            name_label, 
            age_label, 
            adress_label, 
            descriptions_label
            ).ShowDialog();
}
