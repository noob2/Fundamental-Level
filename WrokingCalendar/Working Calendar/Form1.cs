using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = addWorker;
        }

        private void AddFirstName()
        {
            TextBox firstName = new TextBox();
            firstName.Name = "firstName" + i.ToString();
            firstName.AutoSize = true;
            firstName.Text = firstName0.Text.ToString();
            firstName.Enabled = false;
            firstNamePanel.Controls.Add(firstName);
            firstName0.Text = string.Empty;
        }

        private void AddLastName()
        {
            TextBox lastName = new TextBox();
            lastName.Name = "lastName" + i.ToString();
            lastName.AutoSize = true;
            lastName.Text = lastName0.Text.ToString();
            lastName.Enabled = false;
            lastNamePanel.Controls.Add(lastName);
            lastName0.Text = string.Empty;
            
        }

        private void AddSalary()
        {
            TextBox salary = new TextBox();
            salary.Name = "salary" + i.ToString();
            salary.AutoSize = true;
            salary.Text = salary0.Text.ToString();
            salary.Enabled = false;
            salaryPanel.Controls.Add(salary);
            salary0.Text = string.Empty;
        }

        private void AddCheckbox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "checkBox" + i.ToString();
            checkBox.AutoSize = true;
            checkBox.Text = "Enable Edditing";
            editPanel.Controls.Add(checkBox);
            
        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            AddFirstName();
            AddLastName();
            AddSalary();
            AddCheckbox();

            firstName0_Leave(firstName0, new EventArgs());
            lastName0_Leave(lastName0, new EventArgs());
            salary0_Leave(salary0, new EventArgs());
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        private void firstName0_Enter(object sender, EventArgs e)
        {
            if (firstName0.Text == "First Name")
            {
                firstName0.Text = "";
                firstName0.ForeColor = Color.Black;
            }

        }

        private void firstName0_Leave(object sender, EventArgs e)
        {
            if (firstName0.Text == "")
            {
                firstName0.Text = "First Name";
                firstName0.ForeColor = Color.Gray;
            }
        }

        private void lastName0_Enter(object sender, EventArgs e)
        {
            if (lastName0.Text == "Last Name")
            {
                lastName0.Text = "";
                lastName0.ForeColor = Color.Black;
            }
        }

        private void lastName0_Leave(object sender, EventArgs e)
        {
            if (lastName0.Text == "")
            {
                lastName0.Text = "Last Name";
                lastName0.ForeColor = Color.Gray;
            }
        }

        private void salary0_Enter(object sender, EventArgs e)
        {
            if (salary0.Text == "Salary")
            {
                salary0.Text = "";
                salary0.ForeColor = Color.Black;
            }
        }

        private void salary0_Leave(object sender, EventArgs e)
        {
            if (salary0.Text == "")
            {
                salary0.Text = "Salary";
                salary0.ForeColor = Color.Gray;
            }
        }
    }
}
