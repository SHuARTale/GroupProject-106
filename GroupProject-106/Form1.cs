using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;
        //public int k;
        List<string> inputs = new List<string>();
        //BindingList<Inputs> input = new BindingList<Inputs>();
        //BindingList<Const> constants = new BindingList<Const>();
        BindingList<ConstantValues> constants = new();
        bool flag = true;
        //inputs[0] = "0";
        //var History = new History(inputs);
        public Form1(string expression)
        {
            InitializeComponent();
            textBox1.Text += expression;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2.BackColor = Color.Highlight;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel3.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button One = (Button)sender;
            textBox1.Text = textBox1.Text + One.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button Two = (Button)sender;
            textBox1.Text = textBox1.Text + Two.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(-";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string[] arr = textBox1.Lines.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Remove(arr.Length, 1);
            }
            textBox1.Lines = arr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            //char[] selectedState = new char[10];
            //selectedState = selectedItem.ToString();
            switch (selectedItem.ToString())
            {
                case "cos()":
                    textBox1.Text = textBox1.Text + "cos(";
                    break;
                case "sin()":
                    textBox1.Text = textBox1.Text + "sin(";
                    break;
                case "tg()":
                    textBox1.Text = textBox1.Text + "tg(";
                    break;
                case "ctg()":
                    textBox1.Text = textBox1.Text + "ctg(";
                    break;
                case "ln()":
                    textBox1.Text = textBox1.Text + "ln(";
                    break;
                case "log(x,y)":
                    textBox1.Text = textBox1.Text + "log(";
                    break;
                case "pi":
                    textBox1.Text = textBox1.Text + "pi";
                    break;
                case "e":
                    textBox1.Text = textBox1.Text + "e";
                    break;
                case "const":
                    textBox1.Text = textBox1.Text + "const";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button Three = (Button)sender;
            textBox1.Text = textBox1.Text + Three.Text;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(numericUpDown4.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(numericUpDown2.Value);
        }

        /*private void button22_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Lines != null)
            {
                inputs.Add(textBox1.Text);
                //i++;
            }
            textBox1.Clear();
            if (flag == false) {

                var frm2 = new Const(constants);
                ListBox listbox10 = new ListBox();
                frm2.ShowDialog();
                listbox10.Items.Clear();
                foreach (var constantValue in constants)
                {
                    listbox10.Items.Add(constantValue.ToString()); //связывание данных
                }
            }
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (flag == false) richTextBox1.Visible = false;
            //else if (flag == true) richTextBox1.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //inputs.Add(new());
            //inputs.Add(new() {Value = ""});
            var History = new History();
            History.inputs = inputs;
            //int m = History.k;
            //History.textBox1 = textBox1;
            /*DataTable table = new DataTable();
            table.Rows.Add(textBox1.Text);
            dataGridView1.DataSource = table;*/
            //inputs.Add(textBox1.Text);
            //History.ShowDialog();
            /*ListBox listBox3 = new ListBox();
            listBox3.Items.Clear();
            foreach (var a in inputs) {
                listBox3.Items.Add(a); //связывание данных
            }
            textBox1.Text = k;*/
            /*if (k > 0)
            {
                textBox1.Text = inputs[k];
            }*/
            History.Show();
            Hide();
            //Form1.Close();
            //History.Visible
            /*int j = 0;
            if (j % 2 == 0) richTextBox1.Visible = true;
            else richTextBox1.Visible = false;*/
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var frm2 = new Const(constants);
            ListBox listbox10 = new ListBox();
            frm2.ShowDialog();
            listbox10.Items.Clear();
            foreach (var constantValue in constants)
            {
                listbox10.Items.Add(constantValue.ToString()); //связывание данных
            }
            //Const.Show();
        }
    }
}
//при создании константы вводится буква с клавиатуры, должна вылезти новая форма для введения константы
//вставляем кнопку,по нажантию которой вылезет новая форма
//проект->добавить новвую форму
//по {кнопка2_клик}
/*
 * constants.CleaR(0
constants.Add(new() {Name ="X", Value = 0.0});
constants.Add(new() {Name ="Constant", Value = 0.0});
constants.Add(new() {Name ="v", Value = 0.0});
inputs.Add(new() {Value = ""});
var frm2 = new Form2(constants);

//Binding list заполняем выражениями

frm2.ShowDialog();
для неограниченных констант ввести table(flow0layoutpalnel
получим табличку
в одной ячейке названия константы
во второй значения
определяем колчисевт остолбцов и ячекк динамически
чтобы это сделать - при создании формы передаем информацию о колве значений и 
то что выше не надо
!!!DATAGridVIEW
НОВЫЙ dвспомогательный класс constant values
[DisplayName("const names")]
public string Name{get;set;]
[DisplayName("values")]
public double Value{get; set;]
public override striing TOstring(0{
    return $"{Name]={Value]";

]


вверзду форм.сс
BindingList<ConstantValues> constants = new(0);


public class Form2 : form
{
    private Bindinglist<ConstantValues>.
..см фото... = _constats;
...
datraGridView.DataSource=
}

добавляем listbox после frm2 в баттон2клик
показываем что пользователь ввел
frm2.ShowDiealog
listbox1.Items.Clear(0;
foreach(var constantValue int constants0 {
 listbox1.Items.Add(constantValue.ToString(00; //связывание данных

]

$"error in {e.RowIndex}"

запретить добавлять блоьше констант чем выдает строчек программа
фддщцгыукещф
allowusertoaddrows////свойства панели
*/