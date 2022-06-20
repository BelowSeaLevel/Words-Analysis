using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace DataAnalysisWordsInDatabaseMultithread
{
    /// <summary>
    /// WHAT I STILL NEED TO DO.
    /// debug errors, think of try/catch  --- 
    /// </summary>
    
    public partial class Form1 : Form
    {
        internal string TextBoxString { get; set; }

        readonly MostUsedWord MostUsedW = new MostUsedWord();
        readonly LongestWord LongestW = new LongestWord();
        readonly AverageLength AverageLength = new AverageLength();
        readonly ToDatabase ToDatabase = new ToDatabase();
        readonly PeekingDatabase PeekDatabase = new PeekingDatabase();
        
        // Delegate and event to make new form.
        public delegate void ShoutOutEventHandler(object source, EventArgs args);
        public event ShoutOutEventHandler PublisherEvent;


        readonly Stopwatch stopW = new Stopwatch();
        internal string elapsedTime;

        

        public Form1()
        {
            InitializeComponent();


            // subscribes the CreateAndShowForm to the event.
            PublisherEvent += PeekDatabase.CreateAndShowForm;

        }

        #region Labels / Buttons / Textboxes
        private void LabelTime_Click(object sender, EventArgs e)
        {
            // See ShowTime Method below.
        }

        private void LabelMostUsedWord_Click(object sender, EventArgs e)
        {
            // See MostUsedWord Method below.
        }

        private void LabelAverageLength_Click(object sender, EventArgs e)
        {
            // See AverageLengthOfWord Method below.
        }

        private void LabelLongestWord_Click(object sender, EventArgs e)
        {
            // See LongestWord Method below.
        }

        private void TextBoxWordsToDatabase_TextChanged(object sender, EventArgs e)
        {
            // Puts the text in a string.
            TextBoxString = TextBoxWordsToDatabase.Text;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            StopWatchStopAndReset();
            CallTasks();
        }

        private void ButtonClearAllData_Click(object sender, EventArgs e)
        {
            TextBoxWordsToDatabase.Clear();
            LabelTime.Text = "Time:";
            LabelMostUsedWord.Text = "Most used word:";
            LabelAverageLength.Text = "Average length of words:";
            LabelLongestWord.Text = "Longest word:";

            LongestW.LongestWordProperty = null;
            StopWatchStopAndReset();
        }

        private void ButtonToDatabase_Click(object sender, EventArgs e)
        {
             ToDatabase.SendToDatabase(elapsedTime, MostUsedW.WordForLabel, AverageLength.AverageLengthWords, LongestW.LongestWordProperty);
        }
      
        internal void ButtonPeekDatabase_Click(object sender, EventArgs e)
        {
            // Checks or there is already a form of type FormShowDatabasePeek
            // If not then fire the event.
            if (Application.OpenForms.OfType<FormShowDatabasePeek>().Count() == 0)
            {
                FireTheEvent();
            }
        }
        


        #endregion


        #region Methods

        async void CallTasks() => await RunTasks();

        /// <summary>
        /// Fires of the event.
        /// </summary>
        public void FireTheEvent()
        {
            PublisherEvent?.Invoke(this, EventArgs.Empty);
        }


        private void StopWatchStopAndReset()
        {
            stopW.Stop();
            stopW.Reset();
        }

        private async Task RunTasks()
        {
            try
            {
                stopW.Start();

                Task Most = MostUsedWord();
                Task Longest = LongestWord();
                Task Average = AverageLengthOfWord();

                await Task.WhenAll(Most, Longest, Average);

                stopW.Stop();
                ShowTime();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No text to process.");
                StopWatchStopAndReset();
            }
            catch(ArgumentOutOfRangeException )
            {
                MessageBox.Show("Trying to access an index thats higher then the list.");
                StopWatchStopAndReset();
            }
            

        }

        private void ShowTime()
        {
            TimeSpan tSpan = stopW.Elapsed;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                tSpan.Hours, tSpan.Minutes, tSpan.Seconds, tSpan.Milliseconds);
            

            LabelTime.Text = "Time: " + elapsedTime;
        }

        private async Task MostUsedWord()
        {
            MostUsedW.LookForMostUsedWord(TextBoxString);

            LabelMostUsedWord.Text = "Most used word:  " + MostUsedW.WordForLabel;
            await Task.FromResult(1);
        }

        private async Task LongestWord()
        {
            LongestW.LookForLongestWord(TextBoxString);

            LabelLongestWord.Text = "Longest word: " + LongestW.LongestWordProperty;
            await Task.FromResult(1);
        }

        private async Task AverageLengthOfWord()
        {
            AverageLength.LookForAverageLength(TextBoxString);

            LabelAverageLength.Text = "Average length of words: " + AverageLength.AverageLengthWords;
            await Task.FromResult(1);
        }

        #endregion
    }
}
