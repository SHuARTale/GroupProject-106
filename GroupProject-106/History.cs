using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    
    public partial class History : Form
    {
        public List<string> inputs;
        public int k = -1;
        //public TextBox textBox1;
        public History()
        {
            InitializeComponent();
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            //dataGridView1.DataError += DataGridView1OnDataError;
            /*List<string> result = new List<string>();
            result.Add("jkl;");
            result.Add("jklkk;");
            for (int i = 0; i < result.Count; i++)
            {
                listBox3.Items.Add(result[i]);
            }*/
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public string Expression { get; set; }
        
        private void History_Load(object sender, EventArgs e)
        {
            //List<string> result = new List<string>();
            //result.Add("jkl;");
            //result.Add("jklkk;");
            listBox3.Items.Add("");
            for (int i = 0; i < inputs.Count; i++) {
                //listBox3.Items.Add(result[i]);
                listBox3.Items.Add(inputs[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Show();
        }*/

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Show();
        }
        //public string text;
        private void button1_Click(object sender, EventArgs e)
        {
            //var frm1;
            
            if (listBox3.SelectedItem != null)
            {
                string name = listBox3.SelectedItem.ToString(); // получаем имя из текстового поля
                var frm1 = new Form1(name);
                frm1.ShowDialog();

                //frm1.Hide();
                Hide();
                //Form1.k = k;
                //k = listBox3.SelectedItem.ToString();
            }
            //frm1.k = k;
            //else k = "0";
            Hide();
        }


        


        //private BindingList<Inputs>? _inputs;


        /*public History(List<string> inputs)
        {
            Inputs = inputs;
        }*/

        /*private History(BindingList<Inputs> inputs)
        {
            InitializeComponent();
            _inputs = inputs;
            dataGridView1.DataSource = _inputs;

            //dataGridView1.DataError += DataGridView1OnDataError;
        }*/

        /*private void DataGridView1OnDataError(object? sender, DataGridViewDataError) {
            MessageBox.Show("Error");
        }*/


    }
}


/*
 * public List<string> inputs;
        //private BindingList<Inputs>? _inputs;


        /*public History(List<string> inputs)
        {
            Inputs = inputs;
        }

/*private History(BindingList<Inputs> inputs)
{
    InitializeComponent();
    _inputs = inputs;
    dataGridView1.DataSource = _inputs;

    //dataGridView1.DataError += DataGridView1OnDataError;
}
DataTable table = new DataTable();
//DataTable.Clear();
/*if(Inputs != 0){

    }*/
/*table.Rows.Add(textBox1.Text);
    dataGridView1.DataSource = table;
//public List<string> Inputs { get; }
private void History_Load(object sender, EventArgs e)
{
    table.Columns.Add("456", typeof(string));
    if (inputs.Count != 0)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            table.Rows.Add(inputs[i]);
        }
    }
    dataGridView1.DataSource = table;
    dataGridView1.Show();
}
public void TableFilling(List<string> inputs)
{

    if (inputs.Count != 0)
    {
        for (int i = 0; i < inputs.Count; i++)
        {
            table.Rows.Add(inputs[i]);
        }
    }
    dataGridView1.DataSource = table;
    dataGridView1.Show();
}
/*private void DataGridView1OnDataError(object? sender, DataGridViewDataError) {
    MessageBox.Show("Error");
}

}*/
