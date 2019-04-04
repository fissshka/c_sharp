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

namespace CSharp_Net_module2_1_2_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 15) Declare objects DataSet, DataAdapter and others
        public MainWindow()
        {
           
            InitializeComponent();

            // 9) Set Background for button; use Brushes
            

            // 16) Set DataAdapter and DataSet
            // Note: Don't forget to use connection string

            // 17) Add datacontext of datagrid with code:
            // dataGridView.DataContext = da.Tables[“MyTable"];
            // Where 
            // dataGridView – name (object) of used datagrind
            // da – object of DataSet
            // “MyTable” – table name

        }

        // 11) Add event handler on button click (for colored button)

        // 12) Add new window to project
        // In new window add XAML to show backgroud image

        // 13) invoke method ShowDialig() for new window


        // 18) Add event handler on button click (for 2nd button)

        // 19) invoke method Update() of DataAdapter to update data

    }
}
