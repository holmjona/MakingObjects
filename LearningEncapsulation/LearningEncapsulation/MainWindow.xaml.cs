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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningEncapsulation {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Person p = new Person();
            p.FirstName = "Bob";
            p.Personality = Person.Personalities.Euphoric;
            MessageBox.Show(p.FirstName);

        }

        private void BtnOfMagic_Click(object sender, RoutedEventArgs e) {

        }

        /// <summary>
        /// Makes stuff
        /// </summary>
        /// <remarks>
        ///  This method was copied from Prof. Holmes Deliver 4 solution.
        /// </remarks>
        private void fillStuff() {

            // Image logic that was way beyond me.
            // used this code as a reference: https://stackoverflow.com/questions/47776996/wpf-add-images-dynamically-programmatically-to-control
            
        }

    }
}
