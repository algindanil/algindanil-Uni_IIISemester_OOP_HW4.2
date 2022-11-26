using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HW4._2
{
    public partial class ItemInput : Form
    {
        MainForm form;
        Item currentItem = new Item();

        private int counter = 0;
        private string[] instructions = { "Enter Name", "Enter Country of Origin", "Enter Price (in numbers)", "Please enter the date of packaging in the following format: \"DD/MM/YYYY\"", "Enter Description" };

        private static bool ifDouble(string valueToTest)
        {
            if (double.TryParse(valueToTest, out double d) && !Double.IsNaN(d) && !Double.IsInfinity(d))
            {
                return true;
            }

            return false;
        }

        private static bool ifInteger(string valueToTest)
        {
            return int.TryParse(valueToTest, out int n);
        }

        public ItemInput(MainForm mainForm)
        {
            InitializeComponent();
            this.form = mainForm;
        }

        private void SecondaryForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            switch (counter)
            {
                case 0:
                    currentItem.Name = inputBox.Text;
                    counter++;
                    textLabel.Text = instructions[counter];
                    break;
                case 1:
                    //textLabel.Text = instructions[counter];
                    currentItem.CountryOfOrigin = inputBox.Text;
                    counter++;
                    textLabel.Text = instructions[counter];

                    break;
                case 2:
                    //textLabel.Text = instructions[counter];
                    if (!ifDouble(inputBox.Text))
                    {
                        textLabel.Text = "Invalid value (price), please enter a real number";
                    }
                    else
                    {
                        currentItem.Price = double.Parse(inputBox.Text);
                        counter++;
                        textLabel.Text = instructions[counter];

                    }

                    break;
                case 3:
                    //textLabel.Text = instructions[counter];
                    string[] numbers = inputBox.Text.Split('/');
                    int[] dates = new int[3];
                    bool check = true;
                    if (numbers.Length != 3) { break; }

                    for (int i = 0; i < 3; i++) {
                        if (ifInteger(numbers[i]))
                        {
                            dates[i] = int.Parse(numbers[i]);
                        }
                        else
                        {
                            textLabel.Text = "Invalid date, please reenter (format DD/MM/YYYY)";
                            check = false;
                            break;
                        }
                    }
                    if (dates[0] > 31 || dates[0] <= 0 || dates[1] <= 0 || dates[1] > 12 || dates[2] <= 0)
                    {
                        textLabel.Text = "Invalid date, please reenter (format DD/MM/YYYY)";
                        check = false;
                        break;
                    }
                    if (check) { 
                        counter++;
                        currentItem.DateOfPackaging = new DateTime(dates[2], dates[1], dates[0]);
                        textLabel.Text = instructions[counter];

                    }
                    break;
                case 4:
                    //textLabel.Text = instructions[counter];
                    currentItem.Description = inputBox.Text;
                    form.Items.Add(currentItem);
                    this.Close();
                    break;

            }
        }

        /*public void InputItem()
        {
            Item item = new Item();
            
            textLabel.Text = "Enter Name";
            item.Name = inputBox.Text;
            
            textLabel.Text = "Enter Country of Origin";
            item.CountryOfOrigin = inputBox.Text;
            
            textLabel.Text = "Enter price (in numbers)";
            while (!ifDouble(inputBox.Text))
            {
                textLabel.Text = "Invalid Value, Plase Reenter";
            }
            item.Price = double.Parse(inputBox.Text);

            
        }
        */
    }
}
