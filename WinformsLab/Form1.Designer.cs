
namespace WinformsLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueueType = new System.Windows.Forms.RadioButton();
            this.DequeType = new System.Windows.Forms.RadioButton();
            this.StackType = new System.Windows.Forms.RadioButton();
            this.AddButt = new System.Windows.Forms.Button();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.textRemove = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.textChange = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.ReadDataButt = new System.Windows.Forms.Button();
            this.SearchGetLabel = new System.Windows.Forms.Label();
            this.QueueLabel = new System.Windows.Forms.Label();
            this.DequeLabel = new System.Windows.Forms.Label();
            this.StackLabel = new System.Windows.Forms.Label();
            this.ChangeTemp = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Last = new System.Windows.Forms.RadioButton();
            this.First = new System.Windows.Forms.RadioButton();
            this.labelQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogsView = new System.Windows.Forms.DataGridView();
            this.LogsButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsView)).BeginInit();
            this.SuspendLayout();
            // 
            // QueueType
            // 
            this.QueueType.AutoSize = true;
            this.QueueType.Location = new System.Drawing.Point(6, 19);
            this.QueueType.Name = "QueueType";
            this.QueueType.Size = new System.Drawing.Size(57, 17);
            this.QueueType.TabIndex = 1;
            this.QueueType.TabStop = true;
            this.QueueType.Text = "Queue";
            this.QueueType.UseVisualStyleBackColor = true;

            // 
            // DequeType
            // 
            this.DequeType.AutoSize = true;
            this.DequeType.Location = new System.Drawing.Point(77, 19);
            this.DequeType.Name = "DequeType";
            this.DequeType.Size = new System.Drawing.Size(57, 17);
            this.DequeType.TabIndex = 2;
            this.DequeType.TabStop = true;
            this.DequeType.Text = "Deque";
            this.DequeType.UseVisualStyleBackColor = true;

            // 
            // StackType
            // 
            this.StackType.AutoSize = true;
            this.StackType.Location = new System.Drawing.Point(150, 19);
            this.StackType.Name = "StackType";
            this.StackType.Size = new System.Drawing.Size(53, 17);
            this.StackType.TabIndex = 3;
            this.StackType.TabStop = true;
            this.StackType.Text = "Stack";
            this.StackType.UseVisualStyleBackColor = true;

            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(12, 104);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(75, 23);
            this.AddButt.TabIndex = 4;
            this.AddButt.Text = "Add";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemoveButt
            // 
            this.RemoveButt.Location = new System.Drawing.Point(117, 104);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(75, 23);
            this.RemoveButt.TabIndex = 5;
            this.RemoveButt.Text = "Remove";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textRemove
            // 
            this.textRemove.Location = new System.Drawing.Point(106, 151);
            this.textRemove.Name = "textRemove";
            this.textRemove.Size = new System.Drawing.Size(100, 20);
            this.textRemove.TabIndex = 6;

            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 149);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // textChange
            // 
            this.textChange.Location = new System.Drawing.Point(106, 191);
            this.textChange.Name = "textChange";
            this.textChange.Size = new System.Drawing.Size(36, 20);
            this.textChange.TabIndex = 8;

            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(12, 188);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 9;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.Change_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 227);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(106, 230);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(36, 20);
            this.textSearch.TabIndex = 10;

            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(12, 265);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.Filter_Click);
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(106, 268);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(100, 20);
            this.textFilter.TabIndex = 12;

            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(12, 333);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(194, 23);
            this.SortButton.TabIndex = 14;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ReadDataButt
            // 
            this.ReadDataButt.Location = new System.Drawing.Point(12, 372);
            this.ReadDataButt.Name = "ReadDataButt";
            this.ReadDataButt.Size = new System.Drawing.Size(194, 23);
            this.ReadDataButt.TabIndex = 15;
            this.ReadDataButt.Text = "Read Data";
            this.ReadDataButt.UseVisualStyleBackColor = true;
            this.ReadDataButt.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // SearchGetLabel
            // 
            this.SearchGetLabel.AutoSize = true;
            this.SearchGetLabel.Location = new System.Drawing.Point(185, 233);
            this.SearchGetLabel.Name = "SearchGetLabel";
            this.SearchGetLabel.Size = new System.Drawing.Size(0, 13);
            this.SearchGetLabel.TabIndex = 16;

            // 
            // QueueLabel
            // 
            this.QueueLabel.AutoSize = true;
            this.QueueLabel.Location = new System.Drawing.Point(359, 52);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.Size = new System.Drawing.Size(0, 13);
            this.QueueLabel.TabIndex = 17;

            // 
            // DequeLabel
            // 
            this.DequeLabel.AutoSize = true;
            this.DequeLabel.Location = new System.Drawing.Point(359, 125);
            this.DequeLabel.Name = "DequeLabel";
            this.DequeLabel.Size = new System.Drawing.Size(0, 13);
            this.DequeLabel.TabIndex = 19;

            // 
            // StackLabel
            // 
            this.StackLabel.AutoSize = true;
            this.StackLabel.Location = new System.Drawing.Point(363, 202);
            this.StackLabel.Name = "StackLabel";
            this.StackLabel.Size = new System.Drawing.Size(0, 13);
            this.StackLabel.TabIndex = 20;

            // 
            // ChangeTemp
            // 
            this.ChangeTemp.Location = new System.Drawing.Point(170, 191);
            this.ChangeTemp.Name = "ChangeTemp";
            this.ChangeTemp.Size = new System.Drawing.Size(36, 20);
            this.ChangeTemp.TabIndex = 21;

            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StackType);
            this.groupBox1.Controls.Add(this.DequeType);
            this.groupBox1.Controls.Add(this.QueueType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 43);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Last);
            this.groupBox2.Controls.Add(this.First);
            this.groupBox2.Location = new System.Drawing.Point(18, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 37);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // Last
            // 
            this.Last.AutoSize = true;
            this.Last.Location = new System.Drawing.Point(112, 14);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(45, 17);
            this.Last.TabIndex = 1;
            this.Last.TabStop = true;
            this.Last.Text = "Last";
            this.Last.UseVisualStyleBackColor = true;

            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Location = new System.Drawing.Point(7, 14);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(44, 17);
            this.First.TabIndex = 0;
            this.First.TabStop = true;
            this.First.Text = "First";
            this.First.UseVisualStyleBackColor = true;

            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(362, 31);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(42, 13);
            this.labelQ.TabIndex = 24;
            this.labelQ.Text = "Queue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Deque: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Stack: ";
            // 
            // LogsView
            // 
            this.LogsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsView.Location = new System.Drawing.Point(270, 230);
            this.LogsView.Name = "LogsView";
            this.LogsView.Size = new System.Drawing.Size(784, 419);
            this.LogsView.TabIndex = 28;

            // 
            // LogsButt
            // 
            this.LogsButt.Location = new System.Drawing.Point(71, 422);
            this.LogsButt.Name = "LogsButt";
            this.LogsButt.Size = new System.Drawing.Size(75, 23);
            this.LogsButt.TabIndex = 29;
            this.LogsButt.Text = "Check Logs";
            this.LogsButt.UseVisualStyleBackColor = true;
            this.LogsButt.Click += new System.EventHandler(this.LogsButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 681);
            this.Controls.Add(this.LogsButt);
            this.Controls.Add(this.LogsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeTemp);
            this.Controls.Add(this.StackLabel);
            this.Controls.Add(this.DequeLabel);
            this.Controls.Add(this.QueueLabel);
            this.Controls.Add(this.SearchGetLabel);
            this.Controls.Add(this.ReadDataButt);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.textChange);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.textRemove);
            this.Controls.Add(this.RemoveButt);
            this.Controls.Add(this.AddButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton QueueType;
        private System.Windows.Forms.RadioButton DequeType;
        private System.Windows.Forms.RadioButton StackType;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button RemoveButt;
        private System.Windows.Forms.TextBox textRemove;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox textChange;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button ReadDataButt;
        private System.Windows.Forms.Label SearchGetLabel;
        private System.Windows.Forms.Label QueueLabel;
        private System.Windows.Forms.Label DequeLabel;
        private System.Windows.Forms.Label StackLabel;
        private System.Windows.Forms.TextBox ChangeTemp;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Last;
        private System.Windows.Forms.RadioButton First;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogsButt;
        private System.Windows.Forms.DataGridView LogsView;
    }
}

