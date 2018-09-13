using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Emergency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_AddPatient.Enabled = false;
            button_CallPatient.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = textBox_PatientsName.Text;
            int condition;
            Int32.TryParse(textBox_Priority.Text, out condition);
            Patient newPatient = new Patient(name, condition);

            Program.pq.Enqueue(newPatient);
            List<string> patients = Program.pq.Print();
            foreach (string item in patients)
            {
                listBox1.Items.Add(item);
            }
            button_CallPatient.Enabled = true;
            textBox_PatientsName.Text = "";
            textBox_Priority.Text = "";
        }

        private void button_CallPatient_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();
            Patient patient = new Patient();
            Program.pq.Dequeue(patient);
            textBox_nextPatient.Text = patient.Name.ToString();
            List<string> patients = Program.pq.Print();
            if (!Program.pq.IsEmpty())
                foreach (string item in patients)
                    listBox1.Items.Add(item);
            else
                button_CallPatient.Enabled = false;






        }

        public void ValidateAddPatient()
        {
            button_AddPatient.Enabled = (textBox_PatientsName.Text.Length != 0 &&
                                         textBox_Priority.Text.Length != 0);
        }

        private void textBox_PatientName_Validating(object sender, KeyEventArgs e)
        {
            ValidateAddPatient();
        }

        private void textBox_Priority_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
