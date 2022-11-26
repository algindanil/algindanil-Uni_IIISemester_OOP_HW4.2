using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4._2
{
    public partial class GroceriesInput : Form
    {
        MainForm form;
        GroceryItem currentItem = new GroceryItem();

        private int counter = 0;
        private string[] instructions = { "Enter Name", "Enter Country of Origin", "Enter Price (in numbers)", "Please enter the date of packaging in the following format: \"DD/MM/YYYY\"",
            "Enter Description", "Please enter the due date in the following format: \"DD/MM/YYYY\"", "Enter Quantity", "Enter Unit of Measure" };

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

        public GroceriesInput(MainForm mainForm)
        {
            InitializeComponent();
            this.form = mainForm;
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
                 
                    currentItem.CountryOfOrigin = inputBox.Text;
                    counter++;
                    textLabel.Text = instructions[counter];

                    break;
                case 2:
                    
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
            
                    string[] numbers = inputBox.Text.Split('/');
                    int[] dates = new int[3];
                    bool check = true;
                    if (numbers.Length != 3) { break; }

                    for (int i = 0; i < 3; i++)
                    {
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
                    if (check)
                    {
                        counter++;
                        currentItem.DateOfPackaging = new DateTime(dates[2], dates[1], dates[0]);
                        textLabel.Text = instructions[counter];

                    }
                    break;
                case 4:
              
                    currentItem.Description = inputBox.Text;
                    counter++;
                    textLabel.Text = instructions[counter];
                    break;
                case 5:

                    string[] numbers2 = inputBox.Text.Split('/');
                    int[] dates2 = new int[3];
                    bool check2 = true;
                    if (numbers2.Length != 3) { break; }

                    for (int i = 0; i < 3; i++)
                    {
                        if (ifInteger(numbers2[i]))
                        {
                            dates2[i] = int.Parse(numbers2[i]);
                        }
                        else
                        {
                            textLabel.Text = "Invalid date, please reenter (format DD/MM/YYYY)";
                            check = false;
                            break;
                        }
                    }
                    if (dates2[0] > 31 || dates2[0] <= 0 || dates2[1] <= 0 || dates2[1] > 12 || dates2[2] <= 0)
                    {
                        textLabel.Text = "Invalid date, please reenter (format DD/MM/YYYY)";
                        check = false;
                        break;
                    }
                    if (check2)
                    {
                        counter++;
                        currentItem.DueDate = new DateTime(dates2[2], dates2[1], dates2[0]);
                        textLabel.Text = instructions[counter];

                    }
                    break;
                case 6:
                    if (!ifInteger(inputBox.Text))
                    {
                        textLabel.Text = "Invalid value (price), please enter a real number";
                    }
                    else
                    {
                        currentItem.Quantity = int.Parse(inputBox.Text);
                        counter++;
                        textLabel.Text = instructions[counter];
                    }
                    break;
                case 7:
                    currentItem.Unit = inputBox.Text;
                    form.Groceries.Add(currentItem);
                    this.Close();
                    break;
            }
                

        }
    }
}
