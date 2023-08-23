using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class ComboBoxGUI : Form
    {

        private List<Food> list;
        private List<ComboBoxClass> listClass;
        public ComboBoxGUI()
        {
            InitializeComponent();

            //addBinding();
            //list = new List<Food>()
            //{
            //    new Food() { Name = "Thit heo", Price = 1000 },
            //    new Food() { Name = "Thit bo", Price = 2000 },
            //    new Food() { Name = "Thit ga", Price = 500 }
            //};
            //comboBox1.DataSource = list;
            //comboBox1.DisplayMember = "Name";

            listClass = new List<ComboBoxClass>();
            listClass.Add(new ComboBoxClass()
            {
                ClassName = "A",
                ListStudents = new List<string>() { "Hoang", "Huy", "Nguyen", "Son" }
            });
            listClass.Add(new ComboBoxClass()
            {
                ClassName = "B",
                ListStudents = new List<string>() { "Khoa", "Khang", "Duy", "Quan" }
            });
            listClass.Add(new ComboBoxClass()
            {
                ClassName = "C",
                ListStudents = new List<string>() { "Tri", "Doan", "Man", "Hien" }
            });
            comboClass.DataSource = listClass;
            comboClass.DisplayMember = "ClassName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list = new List<Food>()
            {
                new Food() { Name = "Thit heo", Price = 1000 },
                new Food() { Name = "Thit bo", Price = 2000 },
                new Food() { Name = "Thit ga", Price = 500 }
            };
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Food food = cb.SelectedValue as Food;
                textBox1.Text = food.Price.ToString();
            }
        }

        private void comboClass_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                ComboBoxClass cbl = cb.SelectedValue as ComboBoxClass;
                comboStudent.DataSource = cbl.ListStudents;
            }
        }

        //private void addBinding()
        //{
        //    textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        //}
    }

    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class ComboBoxClass
    {
        public string ClassName { get; set; }
        public List<string> ListStudents { get; set; }
    }
}
