using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonRegistry
{
    public partial class Form1 : Form
    {
        List<Person> personList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(FrstNameTextBox.Text) || string.IsNullOrWhiteSpace(LstNameTextBox.Text))
            {
                MessageBox.Show("Input first and lastname for person");
            }
            else if (MaleRadioBtn.Checked == false && FemaleRadioBtn.Checked == false)
            {
                MessageBox.Show("Select gender to add person");
            }
            if (MaleRadioBtn.Checked == true && !string.IsNullOrWhiteSpace(FrstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LstNameTextBox.Text))
            {
                Male m = new Male(FrstNameTextBox.Text, LstNameTextBox.Text);                
                personList.Add(m);
                ResetTextBox();

            }
            else if (FemaleRadioBtn.Checked == true && !string.IsNullOrWhiteSpace(FrstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LstNameTextBox.Text))
            {                
                Female f = new Female(FrstNameTextBox.Text, LstNameTextBox.Text);
                personList.Add(f);
                ResetTextBox();

            }
            RefreshListbox();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            personList.Remove((Person)personsListbox.SelectedItem);
            RefreshListbox();
        }

        private void personsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personsListbox.SelectionMode = SelectionMode.MultiExtended;
            
            
        }

        private void FrstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }        

        private void MergeBtn_Click(object sender, EventArgs e)
        {            
            if (personsListbox.SelectedItems.Count == 2)
            {
                Person p1 = (Person)personsListbox.SelectedItems[0];                
                Person p2 = (Person)personsListbox.SelectedItems[1];                
                if (!(p1.GetStatus() == p2.GetStatus() || p1.GetStatus() == "Child\t" || p1.GetStatus() == "Child\t"))
                {
                    Child c = p1 + p2;
                    personList.Add(c);
                }
                else
                {
                    MessageBox.Show("Can only merge Mr and Miss together");
                }
            }
            else
            {
                MessageBox.Show("Select only 2 People");
            }

            RefreshListbox();

        }

        private void ResetTextBox()
        {
            FrstNameTextBox.Text = "";
            LstNameTextBox.Text = "";
        }

        private void RefreshListbox()
        {
            personsListbox.DataSource = null;
            personList.Sort();
            personsListbox.DataSource = personList;
            personsListbox.DisplayMember = "FullName";
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
