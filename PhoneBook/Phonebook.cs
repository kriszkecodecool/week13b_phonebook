using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PhoneBook.Person;

namespace PhoneBook
{
    public partial class Phonebook : Form
    {
        List<Person> myList = new List<Person>();
        public Phonebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "Mobile")
            {
                Person human = new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Person.Type.Mobile);
                myList.Add(human);
            }
            else if (comboBox1.SelectedText == "Home")
            {
                Person human = new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Person.Type.Home);
                myList.Add(human);
            }
            else if (comboBox1.SelectedText == "Workplace")
            {
                Person human = new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Person.Type.Workplace);
                myList.Add(human);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Person person in myList)
            {
                MessageBox.Show("name:" + person.name + ", address:" + person.address + ", age: " + person.age + ", mobile:" + person.mobile);
            }
        }
    }
}
