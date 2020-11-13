using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void clearbox()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
            textBox11.Text = String.Empty;
            textBox12.Text = String.Empty;
            textBox13.Text = String.Empty;
            textBox14.Text = String.Empty;
            textBox15.Text = String.Empty;
            textBox16.Text = String.Empty;
            textBox17.Text = String.Empty;
            textBox18.Text = String.Empty;
            textBox19.Text = String.Empty;
            textBox20.Text = String.Empty;
        }
                 
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\BIYOVENT_DB\\BIYOVENT.mdb;Persist Security Info=False;");
        private void showlimits()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From TOLERANCE_CALCULATION"; // tablonu seç
            OleDbDataReader oku = komut.ExecuteReader(); // parametreleri oku
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Parameter"].ToString());
                ekle.SubItems.Add(oku["Tolerance_Value"].ToString());
                ekle.SubItems.Add(oku["Tolerance_Percentage"].ToString());

                listView1.Items.Add(ekle);


            }
            baglantı.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            showlimits();

        }
        private void Button2_Click(object sender, EventArgs e)
        {

            OleDbCommand komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            //"', Tolerance_Percentage = '" + textBox2.Text +

            Environment.GetCommandLineArgs();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox1.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox2.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox3.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox4.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox5.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox6.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox7.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox8.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox9.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox9.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox10.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox10.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox11.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox12.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox13.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox14.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox14.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox15.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox16.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox16.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox17.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox17.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox18.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox18.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox19.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox19.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            if (!string.IsNullOrEmpty(textBox20.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox20.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }

            /*komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox3.Text + "', Tolerance_Percentage = '" + textBox4.Text + "'where Parameter = 'Peep' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox5.Text + "', Tolerance_Percentage = '" + textBox6.Text + "'where Parameter = 'Pressure' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox7.Text + "', Tolerance_Percentage = '" + textBox8.Text + "'where Parameter = 'VInspTidal' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox9.Text + "', Tolerance_Percentage = '" + textBox10.Text + "'where Parameter = 'VEkspTidal' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox11.Text + "', Tolerance_Percentage = '" + textBox12.Text + "'where Parameter = 'F' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox13.Text + "', Tolerance_Percentage = '" + textBox14.Text + "'where Parameter = 'Ti' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox15.Text + "', Tolerance_Percentage = '" + textBox16.Text + "'where Parameter = 'Flow' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox17.Text + "', Tolerance_Percentage = '" + textBox18.Text + "'where Parameter = 'Peak' ";
            komut.ExecuteNonQuery();
            komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox19.Text + "', Tolerance_Percentage = '" + textBox20.Text + "'where Parameter = 'Pdiff' ";
            komut.ExecuteNonQuery(); */

            // komut.CommandText = "update BIYOVENT set Vtidal_LOW='" + textBox1.Text + "',Vtidal_HIGH='" + textBox2.Text + "',Ti_LOW='" + textBox3.Text + "',Ti_HIGH='" + textBox4.Text + "',F_SOLUK_LOW='" + textBox5.Text + "',F_SOLUK_HIGH='" + textBox6.Text + "',PEEP_LOW='" + textBox7.Text + "',PEEP_HIGH='" + textBox8.Text + "'where ID='" +textBox0.Text + "'";

            baglantı.Close();
            showlimits();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox0_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(2000, 1200);
            flowPanelMenu.Hide();
            panel2.Hide();


        }

        private void EXITButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox1.Text, out result))

                if (result > 20)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   OKSIJEN limitleri 0-20 arasında olmalıdır.   ");
                }
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox7.Text, out result))

                if (result > 500)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   Vinsp TIDAL limitleri 0-500 arasında olmalıdır.   ");
                }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox5.Text, out result))

                if (result > 10)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   PRESSURE limitleri 0-20 arasında olmalıdır.   ");
                }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox3.Text, out result))

                if (result > 10)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   PEEP limitleri 0-20 arasında olmalıdır.   ");
                }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox15.Text, out result))

                if (result > 20)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   FLOW limitleri 0-20 arasında olmalıdır.   ");
                }
        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8)&& (e.KeyChar != 45))
            {

                e.Handled = true;
            }
        }


        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            
            int result = 0;
            if (int.TryParse(textBox11.Text, out result))

                if (result > 1)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n    Vinsp TIDAL limitleri 0-10 arasında olmalıdır.   ");
                }
        }

        private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;

            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 8)&& (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process x = new Process();

            x.StartInfo.FileName = ("D:\\BIYOVENT LIMIT\\sendemail.exe");
            string mail_list = textBox23.Text + " " + textBox24.Text;
            x.StartInfo.Arguments = (mail_list);
            x.StartInfo.CreateNoWindow = true;
            x.Start();
        }

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox17.Text, out result))

                if (result > 10)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   PEAK limitleri 0-10 arasında olmalıdır.   ");
                }
        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged_1(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox9.Text, out result))

                if (result > 10)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   Veksp TIDAL limitleri 0-20 arasında olmalıdır.   ");
                }
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox11.Text, out result))

                if (result > 10)
                {
                    MessageBox.Show("\t\tUYARI !!!     \n\n   F_SOLUK limitleri 0-10 arasında olmalıdır.   ");
                }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {



        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            

            OleDbCommand komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            //"', Tolerance_Percentage = '" + textBox2.Text +

            Environment.GetCommandLineArgs();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox1.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox1.Text = String.Empty;
                textBox1.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox2.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox2.Text = String.Empty;
                textBox2.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox3.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox3.Text = String.Empty;
                textBox3.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox4.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox4.Text = String.Empty;
                textBox4.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox5.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox5.Text = String.Empty;
                textBox5.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox6.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox6.Text = String.Empty;
                textBox6.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox7.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox7.Text = String.Empty;
                textBox7.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox8.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox8.Text = String.Empty;
                textBox8.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox9.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox9.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox9.Text = String.Empty;
                textBox9.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox10.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox10.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox10.Text = String.Empty;
                textBox10.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox11.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox11.Text = String.Empty;
                textBox11.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox12.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox12.Text = String.Empty;
                textBox12.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox13.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox13.Text = String.Empty;
                textBox13.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox14.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox14.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox14.Text = String.Empty;
                textBox14.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox15.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox15.Text = String.Empty;
                textBox15.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox16.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox16.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox16.Text = String.Empty;
                textBox16.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox17.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox17.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox17.Text = String.Empty;
                textBox17.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox18.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox18.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox18.Text = String.Empty;
                textBox18.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox19.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox19.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox19.Text = String.Empty;
                textBox19.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox20.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox20.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox20.Text = String.Empty;
                textBox20.Text = "-";
            }
            baglantı.Close();
            showlimits();
            Process x = new Process();

            x.StartInfo.FileName = ("D:\\BIYOVENT LIMIT\\sendemail.exe");
            string arg_list = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text
                + " " + textBox7.Text + " " + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " " + textBox12.Text + " " + textBox13.Text
                + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text + " " + textBox20.Text;
            x.StartInfo.Arguments = (arg_list);
            x.StartInfo.CreateNoWindow = true;
            x.Start();
            clearbox();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            if (flowPanelMenu.Visible)
            {
                flowPanelMenu.Hide();
            }
            else
            {
                flowPanelMenu.Show();
            }
            Console.WriteLine("yeni spekler : {0}", textBox1);
        }

        private void TextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click_2(object sender, EventArgs e)
        {
            if (flowPanelMenu.Visible)
            {
                flowPanelMenu.Hide();
            }
            else
            {
                flowPanelMenu.Show();
            }
        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            OleDbCommand komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            //"', Tolerance_Percentage = '" + textBox2.Text +

            Environment.GetCommandLineArgs();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox1.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox1.Text = String.Empty;
                textBox1.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox2.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox2.Text = String.Empty;
                textBox2.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox3.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox3.Text = String.Empty;
                textBox3.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox4.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox4.Text = String.Empty;
                textBox4.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox5.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox5.Text = String.Empty;
                textBox5.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox6.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox6.Text = String.Empty;
                textBox6.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox7.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox7.Text = String.Empty;
                textBox7.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox8.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox8.Text = String.Empty;
                textBox8.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox9.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox9.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox9.Text = String.Empty;
                textBox9.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox10.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox10.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox10.Text = String.Empty;
                textBox10.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox11.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox11.Text = String.Empty;
                textBox11.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox12.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox12.Text = String.Empty;
                textBox12.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox13.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox13.Text = String.Empty;
                textBox13.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox14.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox14.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox14.Text = String.Empty;
                textBox14.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox15.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox15.Text = String.Empty;
                textBox15.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox16.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox16.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox16.Text = String.Empty;
                textBox16.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox17.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox17.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox17.Text = String.Empty;
                textBox17.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox18.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox18.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox18.Text = String.Empty;
                textBox18.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox19.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox19.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox19.Text = String.Empty;
                textBox19.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox20.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox20.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox20.Text = String.Empty;
                textBox20.Text = "-";
            }
            baglantı.Close();
            showlimits();
            Process x = new Process();

            x.StartInfo.FileName = ("D:\\BIYOVENT LIMIT\\sendemail.exe");
            string arg_list = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text
                + " " + textBox7.Text + " " + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " " + textBox12.Text + " " + textBox13.Text
                + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text + " " + textBox20.Text;
            x.StartInfo.Arguments = (arg_list);
            x.StartInfo.CreateNoWindow = true;
            x.Start();
            clearbox();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SHOWLIMITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            showlimits();
        }

        private void UPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            

            OleDbCommand komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            //"', Tolerance_Percentage = '" + textBox2.Text +

            Environment.GetCommandLineArgs();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox1.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox1.Text = String.Empty;
                textBox1.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox2.Text + "'where Parameter = 'FiO2' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox2.Text = String.Empty;
                textBox2.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox3.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox3.Text = String.Empty;
                textBox3.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox4.Text + "'where Parameter = 'Peep' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox4.Text = String.Empty;
                textBox4.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox5.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox5.Text = String.Empty;
                textBox5.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox6.Text + "'where Parameter = 'Pressure' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox6.Text = String.Empty;
                textBox6.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox7.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox7.Text = String.Empty;
                textBox7.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox8.Text + "'where Parameter = 'VInspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox8.Text = String.Empty;
                textBox8.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox9.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox9.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox9.Text = String.Empty;
                textBox9.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox10.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox10.Text + "'where Parameter = 'VEkspTidal' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox10.Text = String.Empty;
                textBox10.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox11.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox11.Text = String.Empty;
                textBox11.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox12.Text + "'where Parameter = 'F' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox12.Text = String.Empty;
                textBox12.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox13.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox13.Text = String.Empty;
                textBox13.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox14.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox14.Text + "'where Parameter = 'Ti' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox14.Text = String.Empty;
                textBox14.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox15.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox15.Text = String.Empty;
                textBox15.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox16.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox16.Text + "'where Parameter = 'Flow' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox16.Text = String.Empty;
                textBox16.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox17.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox17.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox17.Text = String.Empty;
                textBox17.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox18.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox18.Text + "'where Parameter = 'Peak' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox18.Text = String.Empty;
                textBox18.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox19.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Value = '" + textBox19.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox19.Text = String.Empty;
                textBox19.Text = "-";
            }
            if (!string.IsNullOrEmpty(textBox20.Text))
            {
                komut.CommandText = "update TOLERANCE_CALCULATION set Tolerance_Percentage = '" + textBox20.Text + "'where Parameter = 'Pdiff' ";
                komut.ExecuteNonQuery();
            }
            else
            {
                textBox20.Text = String.Empty;
                textBox20.Text = "-";
            }


            baglantı.Close();
            showlimits();
            Process x = new Process();

            x.StartInfo.FileName = ("D:\\BIYOVENT LIMIT\\sendemail.exe");
            string arg_list = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text
                + " " + textBox7.Text + " " + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " " + textBox12.Text + " " + textBox13.Text
                + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text + " " + textBox20.Text;
            x.StartInfo.Arguments = (arg_list);
            x.StartInfo.CreateNoWindow = true;
            x.Start();
            clearbox();
        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Hide();
            }
            else
            {
                panel2.Show();
            }
        }

        private void Button2_Click_3(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\26045442.AR-ARCELIK.000\Desktop\Database8.mdb
//new OleDbCommand("Insert into BIYOVENT (Vtidal_LOW,Vtidal_HIGH,Ti_LOW,Ti_HIGH,F_SOLUK_LOW,F_SOLUK_HIGH,PEEP_LOW,PEEP_HIGH) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')'", baglantı);

/* komut.CommandText = "Select *From BIYOVENT"; // tablonu seç
OleDbDataReader oku = komut.ExecuteReader(); // parametreleri oku
        while (oku.Read()) 
        {
            ListViewItem ekle = new ListViewItem();
ekle.Text = oku["ID"].ToString();
ekle.SubItems.Add(oku["Vtidal_LOW"].ToString());
            ekle.SubItems.Add(oku["Vtidal_HIGH"].ToString());
            ekle.SubItems.Add(oku["Ti_LOW"].ToString());
            ekle.SubItems.Add(oku["Ti_HIGH"].ToString());
            ekle.SubItems.Add(oku["F_SOLUK_LOW"].ToString());
            ekle.SubItems.Add(oku["F_SOLUK_HIGH"].ToString());
            ekle.SubItems.Add(oku["PEEP_LOW"].ToString());
            ekle.SubItems.Add(oku["PEEP_HIGH"].ToString()); */
