﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCConfigurator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Загрузка страницы авторизации по умолчанию
            FrameForLogin.Navigate(new LoginPage());
        }

        // Обработчик для кнопки "Регистрация"
        private void newUser_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу регистрации
            FrameForLogin.Navigate(new RegisterPage());
        }

        // Обработчик для кнопки "Авторизация"
        private void autoUser_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу авторизации
            FrameForLogin.Navigate(new LoginPage());
        }
    }
}