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

namespace ToDoList1
{
    /// <summary>
    /// Логика взаимодействия для TaskEditor.xaml
    /// </summary>
    public partial class TaskEditor : Window
    {

        Dictionary<string, bool> _taskList;
        public TaskEditor(Dictionary<string, bool> value)
        {
            InitializeComponent();
            _taskList = value;
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            _taskList.Add(new TextRange(richTxtBoxTask.Document.ContentStart, richTxtBoxTask.Document.ContentEnd).Text, false);
            this.Close();
            //запихнуть запись в список уже имеющихся дел
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
