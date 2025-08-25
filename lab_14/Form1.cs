using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab_14
{
    public partial class Form1 : Form
    {
        private DogCollection dogCollection = new DogCollection();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dogsDataGridView.ColumnCount = 5;
            dogsDataGridView.Columns[0].Name = "ID";
            dogsDataGridView.Columns[1].Name = "Порода";
            dogsDataGridView.Columns[2].Name = "Стать";
            dogsDataGridView.Columns[3].Name = "Ціна";
            dogsDataGridView.Columns[4].Name = "Вік";
            dogsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dogsDataGridView.ReadOnly = true;
            dogsDataGridView.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Оновлює таблицю даними зі списку.
        /// </summary>
        private void UpdateGrid(List<Dog> dogs)
        {
            dogsDataGridView.Rows.Clear();
            if (dogs == null) return;

            foreach (var dog in dogs)
            {
                dogsDataGridView.Rows.Add(dog.Id, dog.Breed, dog.Sex, dog.Price.ToString("C"), dog.Age);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            dogCollection.GenerateRandomDogs(15);
            ApplyFilter(); 
        }

        private void increasePriceButton_Click(object sender, EventArgs e)
        {
            dogCollection.IncreasePriceForTwoYearOldFemales();
            ApplyFilter();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            dogCollection.SortById();
            ApplyFilter();
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e) => ApplyFilter();
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e) => ApplyFilter();
        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e) => ApplyFilter();

        /// <summary>
        /// Застосовує вибраний фільтр і оновлює таблицю.
        /// </summary>
        private void ApplyFilter()
        {
            if (dogCollection.Dogs == null) return;

            if (maleRadioButton.Checked)
            {
                UpdateGrid(dogCollection.GetDogsBySex(Sex.Male));
            }
            else if (femaleRadioButton.Checked)
            {
                UpdateGrid(dogCollection.GetDogsBySex(Sex.Female));
            }
            else // allRadioButton
            {
                UpdateGrid(dogCollection.Dogs);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Data Files (*.dat)|*.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dogCollection.SaveToFile(saveFileDialog.FileName);
                    MessageBox.Show("Колекцію успішно збережено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Data Files (*.dat)|*.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dogCollection = DogCollection.LoadFromFile(openFileDialog.FileName);
                    ApplyFilter(); 
                    MessageBox.Show("Колекцію успішно завантажено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при завантаженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}