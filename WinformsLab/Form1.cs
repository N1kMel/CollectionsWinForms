using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using NLog;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectionsLabLib;
using System.IO;

namespace WinformsLab
{
    public partial class Form1 : Form
    {


        Deque1<string> deque = new Deque1<string>();
        Stack1<string> stack = new Stack1<string>();
        Queue1<string> queue = new Queue1<string>();

        DataTable table = new DataTable();

        DateTime today = DateTime.Today;

        DataList list = new DataList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, EventArgs e) //change
        {
            list.Change(textChange.Text, ChangeTemp.Text);
            logger.Info("list:" + string.Join(" ", list) + " | list value changed " + textChange.Text + " to " + ChangeTemp.Text);
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, string.Join(" ", list), "list value changed " + textChange.Text + " to " + ChangeTemp.Text);
            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + "list value changed " + textChange.Text + " to " + ChangeTemp.Text + '\n');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Object", typeof(string));
            table.Columns.Add("Current value", typeof(string));
            table.Columns.Add("Event description", typeof(string));
            

        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            list.ReadData("input.txt");
            logger.Info("Data list:" + string.Join(" ", list) + " | " + "The data is written to the data list");
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, string.Join(" ", list), "The data is written to the data list");
            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + "The data is written to the data list" + '\n');
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (list.Count() > 0)
            {
                string first = list.First();
                if (QueueType.Checked) { 
                    queue.Enqueue(first); 
                    QueueLabel.Text += first + " ";
                    logger.Info("queue:" + QueueLabel.Text + " | " + first + " added to the queue ");
                   // table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, QueueLabel.Text, first + " added to the queue ");
                    File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + QueueLabel.Text + " | " + first + " added to the queue " + '\n' );
                }

                if (StackType.Checked) { 
                    stack.Push(first);
                    StackLabel.Text += " " + first;
                    logger.Info("stack:" + StackLabel.Text + " | " + first + " added to the stack ");
                    File.AppendAllText("logs.txt", today + " | " +  System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + StackLabel.Text + " | " + first + " added to the stack " + '\n' );
                   // table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, StackLabel.Text, first + " added to the stack ");
                }

                if (DequeType.Checked) { 
                     if (First.Checked) { 
                        deque.AddFirst(first);
                        DequeLabel.Text = first + " " + DequeLabel.Text;
                        logger.Info("Deque:" + DequeLabel.Text + " | " + first + " added to the deque ");
                       // table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, DequeLabel.Text, first + " added to the deque ");
                        File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + DequeLabel.Text + " | " + first + " added to the deque " + '\n');
                    } 
                     if (Last.Checked) { 
                        deque.AddLast(first); 
                        DequeLabel.Text += first + " ";
                       // table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, DequeLabel.Text, first + " added to the deque ");
                        logger.Info("Deque:" + DequeLabel.Text + " | " + first + " added to the deque ");
                        File.AppendAllText("logs.txt", today + " | " +  System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + DequeLabel.Text + " | " + first + " added to the deque " + '\n');
                    } 
                }

                list.Remove(first);
            }
            else throw new InvalidOperationException("Список пуст");
        }

        private void Remove_Click(object sender, EventArgs e) //remove
        {
            
            if (QueueType.Checked) {
                queue.Dequeue();
                string QueueBefore = QueueLabel.Text;  
                QueueLabel.Text = QueueLabel.Text.Substring(QueueLabel.Text.IndexOf(" ") + 1);
                logger.Info("queue: " + QueueLabel.Text + " | " + QueueBefore.Substring(0, QueueBefore.IndexOf(" ")) + " removed from the queue");
                //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, QueueLabel.Text, QueueBefore.Substring(0, QueueBefore.IndexOf(" ")) + " removed from the queue");

                File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + QueueLabel.Text + " | " + QueueBefore.Substring(0, QueueBefore.IndexOf(" ")) + " removed from the queue" + '\n');

            }

            if (StackType.Checked) {
                string StackBefore = StackLabel.Text;
                stack.Peek();
                
                StackLabel.Text = StackLabel.Text.Substring(0, StackLabel.Text.LastIndexOf(" "));
                logger.Info("stack: " + StackLabel.Text + " | " + StackBefore.Substring(StackBefore.LastIndexOf(" ")) + " removed from the stack");
                //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, StackLabel.Text, StackBefore.Substring(StackBefore.LastIndexOf(" ")) + " removed from the stack");
                File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + StackLabel.Text + " | " + StackBefore.Substring(StackBefore.LastIndexOf(" ")) + " removed from the stack" + '\n');
            }

            if (DequeType.Checked)
            {
                string DequeBefore = DequeLabel.Text;
                if (First.Checked) 
                { 
                    deque.RemoveFirst(); 
                    DequeLabel.Text = DequeLabel.Text.Substring(DequeLabel.Text.IndexOf(" ") + 1);
                    logger.Info("Deque: " + DequeLabel.Text + " | " + DequeBefore.Substring(0, DequeBefore.IndexOf(" ")) + " removed from the deque");
                    //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, DequeLabel.Text, DequeBefore.Substring(0, DequeBefore.IndexOf(" ")) + " removed from the deque");
                    File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + DequeLabel.Text + " | " + DequeBefore.Substring(0, DequeBefore.IndexOf(" ")) + " removed from the deque" + '\n');
                }
                if (Last.Checked) 
                {
                    DequeBefore = DequeBefore.Substring(0, DequeLabel.Text.LastIndexOf(" "));
                    deque.RemoveLast(); 
                    DequeLabel.Text = DequeLabel.Text.Substring(0, DequeLabel.Text.LastIndexOf(" ")); 
                    DequeLabel.Text = DequeLabel.Text.Substring(0, DequeLabel.Text.LastIndexOf(" ") + 1);

                    logger.Info("Deque: " + DequeLabel.Text + " | " + DequeBefore.Substring(DequeBefore.LastIndexOf(" ")) + " removed from the deque");

                    //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, DequeLabel.Text, DequeBefore.Substring(DequeBefore.LastIndexOf(" ")) + " removed from the deque");

                    File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + DequeLabel.Text + " | " + DequeBefore.Substring(0, DequeBefore.IndexOf(" ")) + " removed from the deque" + '\n');
                }
            }

        }

        private void Filter_Click(object sender, EventArgs e) //filter
        {
            list.Filter(textFilter.Text);
            logger.Info("list:" + string.Join(" ", list) + " | " + " list filtered");
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, string.Join(" ", list), " list filtered");
            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + " list filtered" + '\n');
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            list.Remove(textRemove.Text);
            logger.Info(textRemove.Text + " removed from the list");
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, textRemove.Text, " removed from the list");

            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + textRemove.Text + " removed from the list" + '\n');
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchGetLabel.Text = list.Find(textSearch.Text).ToString();
            logger.Info(textSearch.Text + " found on " + SearchGetLabel.Text + " position");
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, textSearch.Text, " found on " + SearchGetLabel.Text + " position");

            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + " found on " + SearchGetLabel.Text + " position" + '\n');
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            list.Sort();
            logger.Info(string.Join(",", list) + " list sorted");
            //table.Rows.Add(today, System.Reflection.MethodBase.GetCurrentMethod().Name, string.Join(",", list), " list sorted");

            File.AppendAllText("logs.txt", today + " | " + System.Reflection.MethodBase.GetCurrentMethod().Name + " | " + string.Join(" ", list) + " | " + " list sorted" + '\n');
        }

        private void LogsButt_Click(object sender, EventArgs e)
        {


            StreamReader sr = new StreamReader("logs.txt");

            List<string> l = new List<string>();

            while (!sr.EndOfStream)
            {
                l.Add(sr.ReadLine());
            }
            string[] logAr = l.ToArray();

            for (int i = 0; i < l.Count; i++)
            {
                table.Rows.Add(logAr[i].Split('|'));
                
            }
            sr.Close();

            LogsView.DataSource = table;

            DataGridViewColumn column = LogsView.Columns[0];
            column.Width = 100;
            
            DataGridViewColumn column1 = LogsView.Columns[1];
            column1.Width = 160;

            DataGridViewColumn column2 = LogsView.Columns[2];
            column2.Width = 250;

            DataGridViewColumn column3 = LogsView.Columns[3];
            column3.Width = 200;
        }

        private static Logger logger = LogManager.GetCurrentClassLogger();
    }
}
