using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    class ToDatabase
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Portfolio CSharp\Windows Forms App CSharp\DataAnalysisWordsInDatabaseMultithread\DataAnalysisWordsInDatabaseMultithread\Database\DataAnalysisOfText.mdf;Integrated Security=True;Connect Timeout=30";


        /// <summary>
        /// Send data to the Database.
        /// </summary>
        internal void SendToDatabase(string elaspTime, string Most, int Average, string Longest)
        {
            if (Most != null && Longest != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Data (Time, MostUsedWord, AverageLength, LongestWord)" +
                        $"VALUES ('{elaspTime}', '{Most}', {Average}, '{Longest}' )";


                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    command.ExecuteNonQuery();


                    command.Dispose();
                }
            }
            else
            {
                MessageBox.Show("No information to send to the database.");
            }

            MessageBox.Show("Update to Database complete.");
        }
    }
}
