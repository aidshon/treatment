using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace sis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        SqlConnection connection = new SqlConnection("Data Source=AIDANA;Initial Catalog=hospital;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet4.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter2.Fill(this.hospitalDataSet4.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet4.Specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter2.Fill(this.hospitalDataSet4.Specialization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet3.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter1.Fill(this.hospitalDataSet3.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet3.Specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter1.Fill(this.hospitalDataSet3.Specialization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet2.Treat". При необходимости она может быть перемещена или удалена.
            this.treatTableAdapter1.Fill(this.hospitalDataSet2.Treat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet1.Treat". При необходимости она может быть перемещена или удалена.
            this.treatTableAdapter.Fill(this.hospitalDataSet1.Treat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Treatment". При необходимости она может быть перемещена или удалена.
            this.treatmentTableAdapter.Fill(this.hospitalDataSet.Treatment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.hospitalDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter.Fill(this.hospitalDataSet.Specialization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Social_status". При необходимости она может быть перемещена или удалена.
            this.social_statusTableAdapter.Fill(this.hospitalDataSet.Social_status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        private void birth_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                dataGridView2.Sort(dataGridView2.Columns[3], ListSortDirection.Ascending);
            if (radioButton4.Checked)
                dataGridView2.Sort(dataGridView2.Columns[3], ListSortDirection.Descending);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                dataGridView2.Sort(dataGridView2.Columns[4], ListSortDirection.Ascending);
            if (radioButton4.Checked)
                dataGridView2.Sort(dataGridView2.Columns[4], ListSortDirection.Descending);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=hospital; " +
        "Integrated Security=True;"))
            {
                string sql = "";
                 if (comboBox3.Text == "Patient")
                 {
                     sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Patient)='" + textBox1.Text + "'";
                 }
                 else if (comboBox3.Text == "Doctor")
                 {
                     sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Doctor)='" + textBox1.Text + "'";
                 }
                 
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("Patient", textBox1.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=hospital; " +
        "Integrated Security=True;"))
            {
                string sql = "SELECT Patient, Diagnosis, Doctor, start_date, end_date, Current_state FROM Treat";
                using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("Patient", textBox1.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;

                    }
                }
            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {
            /* byte[] images = null;
             FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
             BinaryReader brs = new BinaryReader(Streem);
             images = brs.ReadBytes((int)Streem.Length);
             connection.Open();
             if (dataGridView3.SelectedRows.Count > 0)
             {
                 int exp = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["Experience"].Value.ToString());

                 string sqlQuery = "UPDATE Doctor SET img = @image WHERE experience= @exp";
                 cmd = new SqlCommand(sqlQuery, connection);
                 cmd.Parameters.Add(new SqlParameter("@exp", exp));
                 cmd.Parameters.Add(new SqlParameter("@img", images));

                 cmd.ExecuteNonQuery();
                 connection.Close();
                 MessageBox.Show("updated successfully");
             }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime from = birth_dateDateTimePicker.Value;
            DateTime to = DateTime.Now;
            TimeSpan span = to - from;
            double days = span.TotalDays;
            age.Text = (days / 365).ToString("0");
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void birth_dateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DateTime from = DateTime.Now;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                from = Convert.ToDateTime(row.Cells["birthdateDataGridViewTextBoxColumn1"].Value);
            }
            DateTime to = DateTime.Now;
            TimeSpan span = to - from;
            double days = span.TotalDays;
            textBox3.Text = (days / 365).ToString("0");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Sort(dataGridView3.Columns[1], ListSortDirection.Ascending);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Sort(dataGridView3.Columns[3], ListSortDirection.Ascending);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            connection.Open();
            string sqlQuery = "INSERT INTO Patient (full_name, birth_date, policy_number, address, img) VALUES(@fullName, @birthDate, @policyNumber, @address, @img)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@fullName", full_nameTextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@birthDate", birth_dateDateTimePicker.Value));
            cmd.Parameters.Add(new SqlParameter("@policyNumber", Int32.Parse(policy_numberTextBox.Text)));
            cmd.Parameters.Add(new SqlParameter("@address", addressTextBox.Text));
            //cmd.Parameters.Add(new SqlParameter("@socialStatus", comboBox1.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@img", images));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Inserted successfully");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            connection.Open();
            string sqlQuery = "UPDATE Patient SET  img = @img WHERE policy_number= @policyNumber";
            cmd = new SqlCommand(sqlQuery, connection);
            //cmd.Parameters.Add(new SqlParameter("@fullName", full_nameTextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@policyNumber", Int32.Parse(policy_numberTextBox.Text)));
            //cmd.Parameters.Add(new SqlParameter("@address", addressTextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@img", images));

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);


            if (dataGridView3.SelectedRows.Count > 0)
            {


                images = brs.ReadBytes((int)Streem.Length);
                connection.Open();
                string sqlQuery = "UPDATE Doctor SET img = @image WHERE experience= @exp";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new SqlParameter("@exp", Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["experienceDataGridViewTextBoxColumn"].Value.ToString())));
                cmd.Parameters.Add(new SqlParameter("@img", images));

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("updated successfully");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=hospital; " +
        "Integrated Security=True;"))
            {
                string sql = "";
                if (checkBox1.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Dead'";
                }
                else if (checkBox2.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Undetermined'";
                }
                else if (checkBox3.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Good'";
                }
                else if (checkBox4.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Fair'";
                }
                else if (checkBox5.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Serious'";
                }
                else if (checkBox6.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE CONVERT(NVARCHAR(MAX), Current_state)='Critical'";
                }

                if (checkBox1.Checked && checkBox2.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Undetermined')";
                }

                if (checkBox1.Checked && checkBox3.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Good')";
                }

                if (checkBox1.Checked && checkBox4.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Fair')";
                }

                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Undetermined', 'Good')";
                }

                if (checkBox1.Checked && checkBox5.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Serious')";
                }

                if (checkBox1.Checked && checkBox6.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Critical')";
                }

                if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Dead', 'Undetermined', 'Fair')";
                }

                if (checkBox4.Checked && checkBox6.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Fair', 'Critical')";
                }

                if (checkBox2.Checked && checkBox3.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Undetermined', 'Good')";
                }

                if (checkBox2.Checked && checkBox4.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Undetermined', 'Fair')";
                }

                if (checkBox2.Checked && checkBox6.Checked)
                {
                    sql = "SELECT * FROM Treat WHERE (CONVERT(NVARCHAR(MAX), Current_state)) IN ('Undetermined', 'Critical')";
                }
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("Patient", textBox1.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
        }
    }
}