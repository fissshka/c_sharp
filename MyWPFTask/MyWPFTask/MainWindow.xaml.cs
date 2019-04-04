using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MyWPFTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Students = Student.GetStudents();​
            DeleteCommand = new MyCommand() { Collection = Students };
        }

        private void StudentsDG_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)​
        {​
            if (e.AddedCells.Count == 0) return;​
            var currentCell = e.AddedCells[0];​
            if (currentCell.Column ==​
                StudentsDG.Columns[1])​
            {​
                StudentsDG.BeginEdit();​
            }​
        }
    }
}
