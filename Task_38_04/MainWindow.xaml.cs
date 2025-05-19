using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;

namespace StudentInfoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string FileName = "students.dat";

        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Валидация ввода
            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(GroupNameTextBox.Text) ||
                BirthDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Создание объекта Student
            Student student = new Student
            {
                LastName = LastNameTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                GroupName = GroupNameTextBox.Text,
                Gender = (GenderType)GenderComboBox.SelectedItem,
                BirthDate = BirthDatePicker.SelectedDate.Value
            };

            // Добавление в список и обновление ListBox
            students.Add(student);
            StudentsListBox.Items.Add(student);

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            GroupNameTextBox.Text = "";
            GenderComboBox.SelectedIndex = -1;
            BirthDatePicker.SelectedDate = null;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveStudents();
        }

        private void LoadStudents()
        {
            if (File.Exists(FileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        students = (List<Student>)formatter.Deserialize(fs);
                        foreach (var student in students)
                        {
                            StudentsListBox.Items.Add(student);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveStudents()
        {
            try
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Инициализация ComboBox с перечислением GenderType
            GenderComboBox.ItemsSource = Enum.GetValues(typeof(GenderType)).Cast<GenderType>();
            GenderComboBox.SelectedIndex = 0; 
        }
    }

    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GroupName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({GroupName})";
        }
    }

    public enum GenderType
    {
        Male,
        Female,
        Other
    }
}