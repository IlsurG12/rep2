using System;
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
using System.Windows.Shapes;

namespace _4338Project
{
	/// <summary>
	/// Логика взаимодействия для BayazovaDi.xaml
	/// </summary>
	public partial class BayazovaDi : Window
	{
		public BayazovaDi()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Дианчик одуванчик",
	 "Мур мур мяу мяу");
		}
	}
}
