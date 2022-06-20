using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisWordsInDatabaseMultithread
{
    public partial class FormShowDatabasePeek : Form
    {
        internal List<string> listToGrid = new List<string>();



        public FormShowDatabasePeek()
        {
            InitializeComponent();
            
        }

        private void DataGridViewDatabasePeek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Shows all data to the DataGridView.
        /// </summary>
        public void ShowDataInGrid()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("Id");
            dt.Columns.Add("Time");
            dt.Columns.Add("MostUsedWord");
            dt.Columns.Add("AverageLength");
            dt.Columns.Add("LongestWord");


            for (int i = 0; i < listToGrid.Count; i+=5)
            {// the [0],[1] etc has to increase aswell for as much as there is in the list.
                dt.Rows.Add(new object[] {listToGrid[i].ToString(), listToGrid[i + 1].ToString(),
                listToGrid[i + 2].ToString(), listToGrid[i + 3].ToString(), listToGrid[i + 4].ToString()});
            }


            


            DataGridViewDatabasePeek.DataSource = dt;
        }

        

    }
}
