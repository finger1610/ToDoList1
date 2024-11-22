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

namespace ToDoList1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, bool> _TaskList;

        public MainWindow()
        {

            InitializeComponent();

            _TaskList = new Dictionary<string, bool>();
            InitializeComponent();

            foreach (var task in _TaskList)
            {
                lstBoxTasks.Items.Add(task.Key);
            }

        }


        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TaskEditor taskEditor = new TaskEditor(_TaskList);
            taskEditor.ShowDialog();
            lstBoxTasks.Items.Add(_TaskList.Last().Key);
        }

    }
}