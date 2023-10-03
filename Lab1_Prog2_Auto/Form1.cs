using System;
using System.ComponentModel;
using System.Windows.Forms;
using Automobile_Class;
using Fine_Class;
using Microsoft.VisualBasic;

namespace Lab1_Prog2_Auto
{
    public partial class Lab1 : Form
    {
        BindingList<Automobile> automobiles;
        BindingList<Fine> fines;

        public Lab1()
        {
            InitializeComponent();
            automobiles = new BindingList<Automobile>();
            fines = new BindingList<Fine>();
            dataGridViewCars.DataSource = automobiles;
            dataGridViewFines.DataSource = fines;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text;
            if (brand == "")
            {
                MessageBox.Show("Заполните все данные об авто!");
                return;
            }
            string model = textBoxModel.Text;
            if (model == "")
            {
                MessageBox.Show("Заполните все данные об авто!");
                return;
            }
            string owner = textBoxOwner.Text;
            if (owner == "")
            {
                MessageBox.Show("Заполните все данные об авто!");
                return;
            }
                
            int diagnosticYear;
            if (!int.TryParse(textBoxDiagnosticYear.Text, out diagnosticYear))
            {
                MessageBox.Show("Год прохождения ТО введен неверно!");
                return;
            }

            int releaseYear;
            if (!int.TryParse(textBoxReleaseYear.Text, out releaseYear))
            {
                MessageBox.Show("Год выпуска авто введен неверно!");
                return;
            }
               
            Automobile car = new Automobile(brand, model, releaseYear, diagnosticYear, owner);

            automobiles.Add(car);

            ClearTextBoxes();

        }

        private void ClearTextBoxes()
        {
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxDiagnosticYear.Clear();
            textBoxReleaseYear.Clear();
            textBoxOwner.Clear();
            textBoxFineSum.Clear();
            textBoxNewOwner.Clear();
        }

        private void buttonIssueFine_Click(object sender, EventArgs e)
        {
            try
            {
                int fineSum;
                if (!int.TryParse(textBoxFineSum.Text, out fineSum))
                {
                    MessageBox.Show("Введите сумму штрафа!");
                    return;
                }

                int carID = dataGridViewCars.SelectedCells[0].RowIndex;

                Automobile car = automobiles[carID];

                Fine fine = new Fine(car, fineSum);

                fines.Add(fine);

                ClearTextBoxes();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Заполните данные об автомобиле!");
                return;
            }
            
        }

        private void buttonPayFine_Click(object sender, EventArgs e)
        {
            try
            {
                int intruderID = dataGridViewFines.SelectedCells[0].RowIndex;
                fines[intruderID].ChangeStatus();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Нет штрафов на это авто!");
                return;
            }

        }
        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                string newOwner = textBoxNewOwner.Text;
                int carID = dataGridViewCars.SelectedCells[0].RowIndex;

                if (textBoxNewOwner.Text == "")
                {
                    MessageBox.Show("Введите ФИО нового владельца!");
                }
                else if (textBoxNewOwner.Text != "-1")
                {
                    automobiles[carID].Owner = newOwner;
                }
                else
                {
                    dataGridViewCars.Rows.RemoveAt(carID);
                    dataGridViewCars.Refresh();
                }
                ClearTextBoxes();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Заполните данные об автомобиле!");
                return;
            }
        
        }

        private void buttonDiagnostic_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = dataGridViewCars.SelectedCells[0].RowIndex;
                string message = "Введите год прохождения ТО!";
                string title = "Прохождение техосмотра";               
  
                if (automobiles[carID].DiagnosticYear != -1)
                {
                    automobiles[carID].DiagnosticYear += 1;
                }
                else
                {
                    object userAnswer = Interaction.InputBox(message, title);
                    automobiles[carID].DiagnosticYear = Convert.ToInt32(userAnswer);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Заполните данные об автомобиле!");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите год прохождения ТО!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введите год прохождения ТО!");
            }
        }
    }
}