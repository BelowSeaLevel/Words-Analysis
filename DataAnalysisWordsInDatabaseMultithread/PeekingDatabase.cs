using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    class PeekingDatabase
    {
        
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Finished Applications\Windows Forms App CSharp\DataAnalysisWordsInDatabaseMultithread\DataAnalysisWordsInDatabaseMultithread\Database\DataAnalysisOfText.mdf;Integrated Security=True;Connect Timeout=30";
        public  List<string> li = new List<string>();

        

        /// <summary>
        /// Reads what in the database.
        /// </summary>
        internal void PeekIntoDatabase()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Data";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                command.ExecuteNonQuery();

                SqlDataReader dReader = command.ExecuteReader();

                // Bool, do we have rows? yes.
                if(dReader.HasRows)
                {

                    // Will go to the next record.
                    while (dReader.Read())
                    {
                        li.Add(dReader["Id"].ToString());
                        li.Add(dReader["Time"].ToString());
                        li.Add(dReader["MostUsedWord"].ToString());
                        li.Add(dReader["AverageLength"].ToString());
                        li.Add(dReader["LongestWord"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Data in the Database to show.");
                }


                command.Dispose();
            }
            
        }


        /// <summary>
        /// The Subscribed Method that will first call the PeekIntoDatabase method.
        /// Then will create a new Form that will show the data.
        /// </summary>s
        public void CreateAndShowForm(object source, EventArgs e)
        {
            PeekIntoDatabase();

            FormShowDatabasePeek formDatabase = new FormShowDatabasePeek();


            // Sends the list (li) to the formDatabase list called listToGrid.
            // Then shows the form.
            // Then calls the method ShowDataInGrid.
            formDatabase.listToGrid = li;
            formDatabase.Show();
            formDatabase.ShowDataInGrid();


            // Clears the list,
            // this makes sure the same data wont repeat in the Datatable from FormShowDatabasePeek.
            li.Clear();
        }

    }


}
