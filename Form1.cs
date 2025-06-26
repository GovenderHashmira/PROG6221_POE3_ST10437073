using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{
    public partial class Form1: Form
    {
        string userName = "Guest";
        string favouriteTopic = "";
        string lastTopic = "";
        Random rand = new Random();
        List<string> activityLog = new List<string>();  // for logging actions
        List<TaskItem> taskList = new List<TaskItem>();
        int currentQuestionIndex = 0;
        int score = 0;

        List<QuizQuestion> quizQuestions = new List<QuizQuestion>
{
    new QuizQuestion
    {
        Question = "What is the most secure way to store your passwords?",
        Options = new[] { "Use same password everywhere", "Write them down", "Use a password manager", "Remember them all" },
        CorrectOptionIndex = 2
    },
    new QuizQuestion
    {
        Question = "Which of these is a phishing attempt?",
        Options = new[] { "An email from your boss", "A message asking for credentials urgently", "A newsletter you subscribed to", "A WhatsApp from a friend" },
        CorrectOptionIndex = 1
    },
    new QuizQuestion
    {
        Question = "What does HTTPS signify?",
        Options = new[] { "Safe connection", "High traffic", "Speed test", "Hacking tool" },
        CorrectOptionIndex = 0
    },
    new QuizQuestion
    {
       Question = "What is two-factor authentication (2FA)?",
       Options = new[] {
        "Using two passwords",
        "Logging in from two devices",
        "Using a password and another form of verification",
        "Having two user accounts"
    },
    CorrectOptionIndex = 2
    },
    new QuizQuestion
    {
       Question = "What should you do when receiving an email with an unknown attachment?",
       Options = new[] {
        "Open it to see what's inside",
        "Forward it to your friends",
        "Delete it or scan with antivirus",
        "Reply asking what it is"
    },
    CorrectOptionIndex = 2
    },
    new QuizQuestion
    {
    Question = "Which password is the strongest?",
    Options = new[] {
        "123456",
        "ilovecats",
        "MyBirthDate1990",
        "Gf$7@l!Qp#2"
    },
    CorrectOptionIndex = 3
    },
    new QuizQuestion
    {
    Question = "What does a firewall do?",
    Options = new[] {
        "Physically protects your computer",
        "Speeds up your internet",
        "Blocks unauthorized access",
        "Cools down hardware"
    },
    CorrectOptionIndex = 2
},
new QuizQuestion
{
    Question = "Why should you avoid public Wi-Fi for sensitive tasks?",
    Options = new[] {
        "It’s too slow",
        "Other people can monitor your activity",
        "It doesn’t support mobile data",
        "It uses too much battery"
    },
    CorrectOptionIndex = 1
},
new QuizQuestion
{
    Question = "Which of these helps protect your online accounts?",
    Options = new[] {
        "Reusing the same password",
        "Sharing passwords with friends",
        "Using 2FA and unique passwords",
        "Writing passwords in a notebook"
    },
    CorrectOptionIndex = 2
},
new QuizQuestion
{
    Question = "What’s the main goal of a phishing attack?",
    Options = new[] {
        "To improve your security",
        "To gain access to your sensitive data",
        "To protect your device",
        "To fix software bugs"
    },
    CorrectOptionIndex = 1
},

};

        public class QuizQuestion
        {
            public string Question { get; set; }
            public string[] Options { get; set; }
            public int CorrectOptionIndex { get; set; }
        }


        Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>()
{
    { "password", new List<string> {
        "Use strong, unique passwords for each account.",
        "Avoid using personal info and consider using a password manager.",
        "Change your passwords regularly to reduce risks."
    }},
    { "scam", new List<string> {
        "Watch out for scams! Never share your credentials.",
        "Be cautious with offers that seem too good to be true.",
        "Scammers often impersonate legitimate sources. Always double-check."
    }},
    { "phishing", new List<string> {
        "Phishing tricks you into giving up personal info.",
        "Always verify email sources and never click unknown links.",
        "Be cautious of urgent emails demanding quick action."
    }},
    { "privacy", new List<string> {
        "Limit personal info shared online and review app permissions.",
        "Privacy settings are important. Review them regularly.",
        "Use privacy-focused browsers or extensions to enhance your security."
    }},
    { "ransomware", new List<string> {
        "Backup regularly and avoid suspicious downloads.",
        "Do not pay the ransom. Seek expert help if infected.",
        "Update your software to patch known vulnerabilities."
    }},
    { "firewall", new List<string> {
        "Firewalls block unauthorized access to your systems.",
        "They are your first line of defense against intrusions.",
        "Ensure your firewall is enabled and properly configured."
    }},
    { "safe browsing", new List<string> {
        "Use secure websites (https) and avoid sketchy sources.",
        "Enable antivirus tools for extra protection.",
        "Be mindful of downloads and links even from known sites."
    }}
};

        public Form1()
        {
            InitializeComponent();
            AskUserNameAndFavouriteTopic();
        }

        private void AskUserNameAndFavouriteTopic()
        {
            userName = Prompt.ShowDialog("What is your name?", "User Name");
            if (string.IsNullOrWhiteSpace(userName))
                userName = "Guest";

            favouriteTopic = Prompt.ShowDialog("What is your favourite cybersecurity topic (password, scam, privacy, etc.)?", "Favourite Topic")?.ToLower();

            if (!string.IsNullOrEmpty(favouriteTopic) && keywordResponses.ContainsKey(favouriteTopic))
            {
                AppendBotText($"Great! I'll remember that you're interested in {favouriteTopic}.");
            }
            else
            {
                AppendBotText("Thanks! I will try to remember that, but make sure to also ask about topics I know.");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string userInput = inputBox.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
                return;

            AppendUserText(userInput);
            ProcessUserInput(userInput.ToLower());
            inputBox.Clear();
        }

        private void AppendUserText(string text)
        {
            chatHistoryBox.AppendText($"You: {text}{Environment.NewLine}");
        }

        private void AppendBotText(string text)
        {
            chatHistoryBox.AppendText($"Bot: {text}{Environment.NewLine}");
        }

        private void ProcessUserInput(string input)
        {
            DetectSentiment(input);

            if ((input.Contains("confused") || input.Contains("detail")) && !string.IsNullOrEmpty(lastTopic) && keywordResponses.ContainsKey(lastTopic))
            {
                AppendBotText("No problem! Here's another detail that might help:");
                string extra = keywordResponses[lastTopic][rand.Next(keywordResponses[lastTopic].Count)];
                AppendBotText(extra);
                return;
            }

            bool keywordFound = false;

            foreach (var keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    string response = keywordResponses[keyword][rand.Next(keywordResponses[keyword].Count)];
                    AppendBotText(response);
                    keywordFound = true;
                    lastTopic = keyword;

                    if (keyword != favouriteTopic && keywordResponses.ContainsKey(favouriteTopic))
                    {
                        string extraResponse = keywordResponses[favouriteTopic][rand.Next(keywordResponses[favouriteTopic].Count)];
                        AppendBotText($"Since you're interested in {favouriteTopic}, here's a related tip: {extraResponse}");
                    }
                    break;
                }
            }

            if (!keywordFound)
            {
                AppendBotText($"I'm not sure I understand. Can you try rephrasing that, {userName}?");
            }
        }


        private void DetectSentiment(string input)
        {
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
            {
                AppendBotText("It's completely understandable to feel that way. Cyber threats can be scary, but you're not alone.");
            }
            else if (input.Contains("curious") || input.Contains("interested"))
            {
                AppendBotText("Curiosity is great! I'm here to help you learn more about cybersecurity.");
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
                Button confirmation = new Button() { Text = "Ok", Left = 280, Width = 90, Top = 80, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void checkBoxReminder_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerReminder.Enabled = checkBoxReminder.Checked;
        }

        public class TaskItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime? ReminderDate { get; set; }
            public bool IsCompleted { get; set; }

            public override string ToString()
            {
                string status = IsCompleted ? "[✔]" : "[ ]";
                string reminder = ReminderDate.HasValue ? $" (Reminder: {ReminderDate.Value.ToShortDateString()})" : "";
                return $"{status} {Title}{reminder}";
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string title = textBoxTaskTitle.Text.Trim();
            string desc = textBoxTaskDesc.Text.Trim();
            DateTime? reminder = checkBoxReminder.Checked ? dateTimePickerReminder.Value.Date : (DateTime?)null;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            TaskItem newTask = new TaskItem
            {
                Title = title,
                Description = desc,
                ReminderDate = reminder,
                IsCompleted = false
            };

            taskList.Add(newTask);
            listBoxTasks.Items.Add(newTask);
            activityLog.Add($"Task added: '{title}'{(reminder.HasValue ? $" (Reminder set for {reminder.Value.ToShortDateString()})" : "")}");

            textBoxTaskTitle.Clear();
            textBoxTaskDesc.Clear();
            checkBoxReminder.Checked = false;
        }

        private void buttonCompleteTask_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index >= 0)
            {
                TaskItem selectedTask = taskList[index];
                selectedTask.IsCompleted = true;
                listBoxTasks.Items[index] = selectedTask; // Update list
                activityLog.Add($"Task marked as completed: '{selectedTask.Title}'");
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.");
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index >= 0)
            {
                string deletedTitle = taskList[index].Title;
                taskList.RemoveAt(index);
                listBoxTasks.Items.RemoveAt(index);
                activityLog.Add($"Task deleted: '{deletedTitle}'");
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;
            ShowQuizQuestion();
            EnableQuizControls(true);
            labelQuizFeedback.Text = "";
        }

        private void ShowQuizQuestion()
        {
            if (currentQuestionIndex >= quizQuestions.Count)
            {
                labelQuizQuestion.Text = $"Quiz complete! Your score: {score}/{quizQuestions.Count}";
                EnableQuizControls(false);
                labelQuizFeedback.Text = "";
                return;
            }

            var q = quizQuestions[currentQuestionIndex];
            labelQuizQuestion.Text = q.Question;
            radioOption1.Text = q.Options[0];
            radioOption2.Text = q.Options[1];
            radioOption3.Text = q.Options[2];
            radioOption4.Text = q.Options[3];

            radioOption1.Checked = radioOption2.Checked = radioOption3.Checked = radioOption4.Checked = false;
        }

        private void buttonSubmitQuiz_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (radioOption1.Checked) selectedIndex = 0;
            if (radioOption2.Checked) selectedIndex = 1;
            if (radioOption3.Checked) selectedIndex = 2;
            if (radioOption4.Checked) selectedIndex = 3;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an option.");
                return;
            }

            if (selectedIndex == quizQuestions[currentQuestionIndex].CorrectOptionIndex)
            {
                score++;
                labelQuizFeedback.Text = "Correct!";
            }
            else
            {
                labelQuizFeedback.Text = $"Incorrect. Correct answer: {quizQuestions[currentQuestionIndex].Options[quizQuestions[currentQuestionIndex].CorrectOptionIndex]}";
            }

            currentQuestionIndex++;
            ShowQuizQuestion();
        }

        private void EnableQuizControls(bool enabled)
        {
            radioOption1.Enabled = enabled;
            radioOption2.Enabled = enabled;
            radioOption3.Enabled = enabled;
            radioOption4.Enabled = enabled;
            buttonSubmitQuiz.Enabled = enabled;
        }

        private void buttonViewLog_Click(object sender, EventArgs e)
        {
            string logText = string.Join(Environment.NewLine, activityLog);
            MessageBox.Show(logText, "Activity Log");
        }

        private void buttonExportLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Activity Log";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllLines(saveFileDialog.FileName, activityLog);
                        MessageBox.Show("Log exported successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving log: " + ex.Message);
                    }
                }
            }
        }

    }
}
