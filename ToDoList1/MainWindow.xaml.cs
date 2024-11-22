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

            _TaskList = new Dictionary<string, bool>();
            InitializeComponent();

            foreach (var task in _TaskList)
                funcAddTask(task.Key,task.Value);
           

        }
  

        void funcAddTask(string text, bool value = false)
        {
            _TaskList.Add(text, value);

            //создаем панельку, чекбос, текст блок, кнопку удаления задачки
            StackPanel addTask = new StackPanel { Orientation = Orientation.Horizontal };


            CheckBox addCheckBoxTask = new CheckBox { IsChecked = _TaskList.Values.Last() };
            TextBlock addTextBlockTask = new TextBlock { Text = _TaskList.Keys.Last() };
            Button btnDelTask = new Button { Content = "Удалить", Visibility = Visibility.Hidden };



            //вешаем теги на элементы (связываем между сосбой)
            addTextBlockTask.Tag = btnDelTask;
            btnDelTask.Tag = addTextBlockTask;
            addCheckBoxTask.Tag = addTextBlockTask;


            // Подписываемся на события Checked и Unchecked
            addCheckBoxTask.Checked += CheckBoxTask_Checked;
            addCheckBoxTask.Unchecked += CheckBoxTask_Checked;
            btnDelTask.Click += BtnDelTask_Click;


            //закидываем элементы в панельку
            addTask.Children.Add(addTextBlockTask);
            addTask.Children.Add(addCheckBoxTask);
            addTask.Children.Add(btnDelTask);


            //связываем чекбокс  итекст блок
            //addCheckBoxTask.Tag = addTextBlockTask;

            //добавляем панельку в листбокс
            lstBoxTasks.Items.Add(addTask);
        }


        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TaskEditor taskEditor = new TaskEditor(_TaskList);
            taskEditor.ShowDialog();
            if (taskEditor.textTask != null)
                funcAddTask(taskEditor.textTask);
            

        }

        private void CheckBoxTask_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.Tag is TextBlock textBlock && textBlock.Tag is Button button)
            {
                textBlock.TextDecorations = checkBox.IsChecked == true ? TextDecorations.Strikethrough : null;
                if (checkBox.IsChecked.Value)
                {
                    Task.Delay(200);
                    button.Visibility = Visibility.Visible;
                }
                else
                    button.Visibility = Visibility.Hidden;
            }
        }

        private void BtnDelTask_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btnDel && btnDel.Tag is TextBlock textBlock)
                {
                    lstBoxTasks.Items.Remove(textBlock.Parent);
                    _TaskList.Remove(textBlock.Text);
                }
            }
            // throw new NotImplementedException();
        }

      

      
    
}