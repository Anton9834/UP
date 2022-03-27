using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using WpfApp12.ApplicationData;

namespace WpfApp12
{
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();
           AppConnect.fastFoodEntities1 = new FastFoodEntities1();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxPhone.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPatronymic.Text = "";
            passwordBox1.Password = "";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (AppConnect.fastFoodEntities1.Employee.Count(x => x.Phone == textBoxPhone.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким телефоном уже есть!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                Employee employeeObj = new Employee()
                {
                    Phone = textBoxPhone.Text,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Patronymic = textBoxPatronymic.Text,
                    Password = passwordBox1.Password
                };
            AppConnect.fastFoodEntities1.Employee.Add(employeeObj);
            AppConnect.fastFoodEntities1.SaveChanges();
            MessageBox.Show("Данные успешно добавлены!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
        }
             catch
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
    }
}        
        
   