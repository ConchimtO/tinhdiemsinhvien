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

namespace tinhdiemsinhvien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnkq_Click(object sender, RoutedEventArgs e)
        {
            int dvan = Convert.ToInt32(txtdiemvan.Text);
            int dtoan = Convert.ToInt32(txtdiemtoan.Text);
            double dtb = 0;
            dtb= (dvan+dtoan)/2;


            
            if (rbtot.IsChecked == true)
            {
                if (dtb >= 8.0)
                {
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Rèn luyện: " );
                }
                else
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Rèn luyện: " );
       
            }

            if (rbkha.IsChecked == true)
            {
                if (dtb >= 7.0)
                {
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Rèn luyện: " );
                }
                else
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Rèn luyện: " );
       
            }

            if (rbyeu.IsChecked == true)
            {
                MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Rèn luyện: ");
       

            }
            
        }
    }
}
