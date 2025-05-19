using System.Text;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.IO;

namespace Task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> shoppingList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            ShoppingListBox.ItemsSource = shoppingList; // Привязываем ListBox к ObservableCollection
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string newItem = ItemTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                shoppingList.Add(newItem);
                ItemTextBox.Text = ""; // Очищаем поле ввода
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить список покупок";

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string item in shoppingList)
                        {
                            writer.WriteLine(item);
                        }
                    }
                    System.Windows.MessageBox.Show("Список покупок сохранен.", "Сохранено", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Загрузить список покупок";

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    shoppingList.Clear(); // Очищаем текущий список

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            shoppingList.Add(line);
                        }
                    }
                    System.Windows.MessageBox.Show("Список покупок загружен.", "Загружено", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            shoppingList.Clear();
        }
    }
}