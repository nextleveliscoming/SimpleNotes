using System.Collections.ObjectModel;
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

namespace SimpleNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

       

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {

            Note note = new Note()
            {
                Text = NewNote.Text
            };

            Notes.Add(note);
        }

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {
            string selectedText = "";
            
            foreach (Note note in Notes)
            {
                if (note.Text == selectedText)
                {
                    Notes.Remove(note);
                }
            }
        }
    }
}