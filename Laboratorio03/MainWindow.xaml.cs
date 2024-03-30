using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Laboratorio03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dvPrueba.ItemsSource = GetStudents().DefaultView;
        }

        public DataTable GetStudents()
        {
            string connectionString = "Data Source=LAB1504-03\\SQLEXPRESS;Initial Catalog=BDMario ;User Id=Mario;" + "Password=1234";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}