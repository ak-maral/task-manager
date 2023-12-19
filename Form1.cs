using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable taskList = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            taskList.Columns.Add("Title");
            taskList.Columns.Add("Description");
            taskList.Columns.Add(new DataColumn("Done", typeof(bool)));
            listView.DataSource = taskList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTbox.Text = "";
            descriptionTbox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing= true;
            titleTbox.Text = taskList.Rows[listView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTbox.Text = taskList.Rows[listView.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                taskList.Rows[listView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                taskList.Rows[listView.CurrentCell.RowIndex]["Title"] = titleTbox.Text;
                taskList.Rows[listView.CurrentCell.RowIndex]["Description"] = descriptionTbox.Text;
            }
            else
            {
                taskList.Rows.Add(titleTbox.Text, descriptionTbox.Text);

            }
            titleTbox.Text = "";
            descriptionTbox.Text = "";
            isEditing = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
