namespace CybersecurityChatbotGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatHistoryBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.labelTaskDesc = new System.Windows.Forms.Label();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.textBoxTaskDesc = new System.Windows.Forms.TextBox();
            this.textBoxTaskTitle = new System.Windows.Forms.TextBox();
            this.checkBoxReminder = new System.Windows.Forms.CheckBox();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.buttonCompleteTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.labelQuizFeedback = new System.Windows.Forms.Label();
            this.labelQuizQuestion = new System.Windows.Forms.Label();
            this.buttonSubmitQuiz = new System.Windows.Forms.Button();
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.radioOption1 = new System.Windows.Forms.RadioButton();
            this.radioOption2 = new System.Windows.Forms.RadioButton();
            this.radioOption4 = new System.Windows.Forms.RadioButton();
            this.radioOption3 = new System.Windows.Forms.RadioButton();
            this.buttonViewLog = new System.Windows.Forms.Button();
            this.buttonExportLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatHistoryBox
            // 
            this.chatHistoryBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatHistoryBox.Location = new System.Drawing.Point(0, 0);
            this.chatHistoryBox.Name = "chatHistoryBox";
            this.chatHistoryBox.ReadOnly = true;
            this.chatHistoryBox.Size = new System.Drawing.Size(800, 201);
            this.chatHistoryBox.TabIndex = 0;
            this.chatHistoryBox.Text = "";
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(7, 207);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(213, 20);
            this.inputBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(236, 207);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // labelTaskDesc
            // 
            this.labelTaskDesc.AutoSize = true;
            this.labelTaskDesc.Location = new System.Drawing.Point(701, 219);
            this.labelTaskDesc.Name = "labelTaskDesc";
            this.labelTaskDesc.Size = new System.Drawing.Size(87, 13);
            this.labelTaskDesc.TabIndex = 3;
            this.labelTaskDesc.Text = "Task Description";
            // 
            // labelTaskTitle
            // 
            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.Location = new System.Drawing.Point(568, 219);
            this.labelTaskTitle.Name = "labelTaskTitle";
            this.labelTaskTitle.Size = new System.Drawing.Size(54, 13);
            this.labelTaskTitle.TabIndex = 4;
            this.labelTaskTitle.Text = "Task Title";
            // 
            // textBoxTaskDesc
            // 
            this.textBoxTaskDesc.Location = new System.Drawing.Point(688, 241);
            this.textBoxTaskDesc.Multiline = true;
            this.textBoxTaskDesc.Name = "textBoxTaskDesc";
            this.textBoxTaskDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaskDesc.TabIndex = 5;
            // 
            // textBoxTaskTitle
            // 
            this.textBoxTaskTitle.Location = new System.Drawing.Point(543, 241);
            this.textBoxTaskTitle.Name = "textBoxTaskTitle";
            this.textBoxTaskTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaskTitle.TabIndex = 6;
            // 
            // checkBoxReminder
            // 
            this.checkBoxReminder.AutoSize = true;
            this.checkBoxReminder.Location = new System.Drawing.Point(674, 423);
            this.checkBoxReminder.Name = "checkBoxReminder";
            this.checkBoxReminder.Size = new System.Drawing.Size(90, 17);
            this.checkBoxReminder.TabIndex = 7;
            this.checkBoxReminder.Text = "Set Reminder";
            this.checkBoxReminder.UseVisualStyleBackColor = true;
            this.checkBoxReminder.CheckedChanged += new System.EventHandler(this.checkBoxReminder_CheckedChanged);
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.Enabled = false;
            this.dateTimePickerReminder.Location = new System.Drawing.Point(571, 277);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReminder.TabIndex = 8;
            // 
            // buttonCompleteTask
            // 
            this.buttonCompleteTask.Location = new System.Drawing.Point(543, 365);
            this.buttonCompleteTask.Name = "buttonCompleteTask";
            this.buttonCompleteTask.Size = new System.Drawing.Size(103, 23);
            this.buttonCompleteTask.TabIndex = 9;
            this.buttonCompleteTask.Text = "Mark as Complete";
            this.buttonCompleteTask.UseVisualStyleBackColor = true;
            this.buttonCompleteTask.Click += new System.EventHandler(this.buttonCompleteTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Location = new System.Drawing.Point(543, 417);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(103, 23);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.Text = "Delete Task";
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(543, 314);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(103, 23);
            this.buttonAddTask.TabIndex = 11;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(668, 314);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(120, 95);
            this.listBoxTasks.TabIndex = 12;
            // 
            // labelQuizFeedback
            // 
            this.labelQuizFeedback.AutoSize = true;
            this.labelQuizFeedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelQuizFeedback.Location = new System.Drawing.Point(15, 424);
            this.labelQuizFeedback.Name = "labelQuizFeedback";
            this.labelQuizFeedback.Size = new System.Drawing.Size(88, 13);
            this.labelQuizFeedback.TabIndex = 13;
            this.labelQuizFeedback.Text = "                           ";
            // 
            // labelQuizQuestion
            // 
            this.labelQuizQuestion.AutoSize = true;
            this.labelQuizQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelQuizQuestion.Location = new System.Drawing.Point(15, 241);
            this.labelQuizQuestion.Name = "labelQuizQuestion";
            this.labelQuizQuestion.Size = new System.Drawing.Size(88, 13);
            this.labelQuizQuestion.TabIndex = 14;
            this.labelQuizQuestion.Text = "                           ";
            // 
            // buttonSubmitQuiz
            // 
            this.buttonSubmitQuiz.Enabled = false;
            this.buttonSubmitQuiz.Location = new System.Drawing.Point(118, 394);
            this.buttonSubmitQuiz.Name = "buttonSubmitQuiz";
            this.buttonSubmitQuiz.Size = new System.Drawing.Size(88, 23);
            this.buttonSubmitQuiz.TabIndex = 15;
            this.buttonSubmitQuiz.Text = "Submit Answer";
            this.buttonSubmitQuiz.UseVisualStyleBackColor = true;
            this.buttonSubmitQuiz.Click += new System.EventHandler(this.buttonSubmitQuiz_Click);
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Location = new System.Drawing.Point(15, 394);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(88, 23);
            this.buttonStartQuiz.TabIndex = 16;
            this.buttonStartQuiz.Text = "Start Quiz";
            this.buttonStartQuiz.UseVisualStyleBackColor = true;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // radioOption1
            // 
            this.radioOption1.AutoSize = true;
            this.radioOption1.Enabled = false;
            this.radioOption1.Location = new System.Drawing.Point(33, 266);
            this.radioOption1.Name = "radioOption1";
            this.radioOption1.Size = new System.Drawing.Size(66, 17);
            this.radioOption1.TabIndex = 17;
            this.radioOption1.TabStop = true;
            this.radioOption1.Text = "Option A";
            this.radioOption1.UseVisualStyleBackColor = true;
            // 
            // radioOption2
            // 
            this.radioOption2.AutoSize = true;
            this.radioOption2.Enabled = false;
            this.radioOption2.Location = new System.Drawing.Point(33, 299);
            this.radioOption2.Name = "radioOption2";
            this.radioOption2.Size = new System.Drawing.Size(66, 17);
            this.radioOption2.TabIndex = 18;
            this.radioOption2.TabStop = true;
            this.radioOption2.Text = "Option B";
            this.radioOption2.UseVisualStyleBackColor = true;
            // 
            // radioOption4
            // 
            this.radioOption4.AutoSize = true;
            this.radioOption4.Enabled = false;
            this.radioOption4.Location = new System.Drawing.Point(33, 361);
            this.radioOption4.Name = "radioOption4";
            this.radioOption4.Size = new System.Drawing.Size(67, 17);
            this.radioOption4.TabIndex = 19;
            this.radioOption4.TabStop = true;
            this.radioOption4.Text = "Option D";
            this.radioOption4.UseVisualStyleBackColor = true;
            // 
            // radioOption3
            // 
            this.radioOption3.AutoSize = true;
            this.radioOption3.Enabled = false;
            this.radioOption3.Location = new System.Drawing.Point(33, 329);
            this.radioOption3.Name = "radioOption3";
            this.radioOption3.Size = new System.Drawing.Size(66, 17);
            this.radioOption3.TabIndex = 20;
            this.radioOption3.TabStop = true;
            this.radioOption3.Text = "Option C";
            this.radioOption3.UseVisualStyleBackColor = true;
            // 
            // buttonViewLog
            // 
            this.buttonViewLog.Location = new System.Drawing.Point(415, 265);
            this.buttonViewLog.Name = "buttonViewLog";
            this.buttonViewLog.Size = new System.Drawing.Size(112, 43);
            this.buttonViewLog.TabIndex = 21;
            this.buttonViewLog.Text = "View Activity Log";
            this.buttonViewLog.UseVisualStyleBackColor = true;
            this.buttonViewLog.Click += new System.EventHandler(this.buttonViewLog_Click);
            // 
            // buttonExportLog
            // 
            this.buttonExportLog.Location = new System.Drawing.Point(415, 314);
            this.buttonExportLog.Name = "buttonExportLog";
            this.buttonExportLog.Size = new System.Drawing.Size(112, 43);
            this.buttonExportLog.TabIndex = 22;
            this.buttonExportLog.Text = "Export Log";
            this.buttonExportLog.UseVisualStyleBackColor = true;
            this.buttonExportLog.Click += new System.EventHandler(this.buttonExportLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExportLog);
            this.Controls.Add(this.buttonViewLog);
            this.Controls.Add(this.radioOption3);
            this.Controls.Add(this.radioOption4);
            this.Controls.Add(this.radioOption2);
            this.Controls.Add(this.radioOption1);
            this.Controls.Add(this.buttonStartQuiz);
            this.Controls.Add(this.buttonSubmitQuiz);
            this.Controls.Add(this.labelQuizQuestion);
            this.Controls.Add(this.labelQuizFeedback);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonCompleteTask);
            this.Controls.Add(this.dateTimePickerReminder);
            this.Controls.Add(this.checkBoxReminder);
            this.Controls.Add(this.textBoxTaskTitle);
            this.Controls.Add(this.textBoxTaskDesc);
            this.Controls.Add(this.labelTaskTitle);
            this.Controls.Add(this.labelTaskDesc);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.chatHistoryBox);
            this.Name = "Form1";
            this.Text = "Cybersecurity Chatbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatHistoryBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label labelTaskDesc;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.TextBox textBoxTaskDesc;
        private System.Windows.Forms.TextBox textBoxTaskTitle;
        private System.Windows.Forms.CheckBox checkBoxReminder;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.Button buttonCompleteTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label labelQuizFeedback;
        private System.Windows.Forms.Label labelQuizQuestion;
        private System.Windows.Forms.Button buttonSubmitQuiz;
        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.RadioButton radioOption1;
        private System.Windows.Forms.RadioButton radioOption2;
        private System.Windows.Forms.RadioButton radioOption4;
        private System.Windows.Forms.RadioButton radioOption3;
        private System.Windows.Forms.Button buttonViewLog;
        private System.Windows.Forms.Button buttonExportLog;
    }
}

