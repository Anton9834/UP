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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace WpfApp12
{
    /// <summary>  
    /// Interaction logic for MainWindow.xaml  
    /// </summary>   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationData.AppConnect.fastFoodEntities1 = new ApplicationData.FastFoodEntities1();
        }
        Registration registration = new Registration();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var employeeObj = ApplicationData.AppConnect.fastFoodEntities1.Employee.FirstOrDefault(x => x.Phone == textBoxPhone.Text && x.Password == passwordBox1.Password);
                if (employeeObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Здравствуйте " + employeeObj.Surname + " " + employeeObj.Name + " " + employeeObj.Patronymic + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    } 
}