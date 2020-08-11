using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поиск_максимума_и_минимума_в_таблице
{
    public partial class Form1 : Form
    {
        const int n = 5;
        const int m = 5;
        int i, j,k,l;


        public Form1()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Width = 320;
            dataGridView1.Height = 160;
            dataGridView1.Font = new Font("Arial", 14); 
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            Random r = new Random();
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    dataGridView1.Rows[i].Cells[j].Value = (r.Next(200) - 100).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int max = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
           for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) > max)
                    {
                        max = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                        k = i;
                        l = j;
                    }
            if (checkBox1.Checked)
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.LightPink;
            else dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.White;
           
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
           for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) < min)
                    {
                        min = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                        k = i;
                        l = j;
                    }
            if (checkBox2.Checked)
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.LightBlue;
            else dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.White;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хоитети выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }    

}
