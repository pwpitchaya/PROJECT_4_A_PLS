using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalOOP
{
    public partial class drink : Form
    {
        public drink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = comboBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxprice.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxcode.Text;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string classdrinkRAW = readAllLine[i];
                    string[] classdrinkSplited = classdrinkRAW.Split(',');
                    Classdrink Classdrink = new Classdrink(classdrinkSplited[0], classdrinkSplited[1], classdrinkSplited[2], classdrinkSplited[3]);
                    addDataToGridView("ชื่อ", "จำนวน", "ราคา");
                }
            }
        }

        void addDataToGridView(string name, string amount, string pirce)
        {
            this.dataGridView1.Rows.Add(new string[] { name, amount, pirce });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ชาไทย")
            {
                textBoxprice.Text = "55";
            }
            else if (comboBox1.Text == "อเมริกาโน")
            {
                textBoxprice.Text = "60";
            }
            else if (comboBox1.Text == "ชาเขียว")
            {
                textBoxprice.Text = "55";
            }
            else if (comboBox1.Text == "สตรอเบอรี่โซดา")
            {
                textBoxprice.Text = "40";
            }
            else if (comboBox1.Text == "แอปเปิ้ลโซดา")
            {
                textBoxprice.Text = "40";
            }
            else if (comboBox1.Text == "บลูเลม่อนโซดา")
            {
                textBoxprice.Text = "40 ";
            }
        }

        private void textBoxcode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxcode.Text == "ABC")
            {
                textBoxcode.Text = "ได้รับโค้ดส่วนลด";
            }
        }
    }
}
