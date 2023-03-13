using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Const : Form
    {

        public List<string> data = new List<string>();
        private BindingList<ConstantValues>? _constants;
        public Const(BindingList<ConstantValues> constants)
        {
            InitializeComponent();
            _constants = constants;
            constants.Add(new() { Name = "a", Value = 0.0 });
            constants.Add(new() { Name = "b", Value = 0.0 });
            constants.Add(new() { Name = "c", Value = 0.0 });
            dataGridView1.DataSource = _constants;
            dataGridView1.DataError += dataGridView1_DataError;
            
            /*DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells["col1"].Value = "a";
            row.Cells["col2"].Value = 0.0;
            dataGridView1.Rows.Add(row);*/
            //DataGrid.Items.Add(new DataItem());
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error");
        }

        DataTable dt = new DataTable();
        private void Const_Load(object sender, EventArgs e)
        {
            /*dt.Rows.Add("A", 0.0);

            dataGridView1.DataSource = dt;*/
            //dataGridView1.Items.Add(new DataItem());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*for (int rows = 0; rows < 2; rows++)
            {
                for (int col = 0; col < 2; col++)
                {
                    data[rows] = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                }
            }*/
            
            Close();
        }
    }
}
