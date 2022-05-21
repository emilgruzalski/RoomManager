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

namespace RoomManagerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        public void LoadDataGrid() 
        {
            RoomGrid roomGrid = new RoomGrid();
            AssignmentGrid assignmentGrid = new AssignmentGrid();
            EmployeeGrid employeeGrid = new EmployeeGrid();
            RoomDataGrid.ItemsSource = roomGrid.RoomList;
            AssignmentDataGrid.ItemsSource = assignmentGrid.AssignmentList;
            EmployeeDataGrid.ItemsSource = employeeGrid.EmployeeList;
        }
        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
        private void dataGrid_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
