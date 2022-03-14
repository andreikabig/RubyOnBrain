namespace RubyOnBrain.TestUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tbCourseNameAdd = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.rbPython = new System.Windows.Forms.RadioButton();
            this.gbLang = new System.Windows.Forms.GroupBox();
            this.rbCsharp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTopicName = new System.Windows.Forms.TextBox();
            this.gbEntryType = new System.Windows.Forms.GroupBox();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.checkCourse = new System.Windows.Forms.CheckedListBox();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.rtbEntry = new System.Windows.Forms.RichTextBox();
            this.btnAddEntrie = new System.Windows.Forms.Button();
            this.checkCourseForAdd = new System.Windows.Forms.ListBox();
            this.checkTopicForAdd = new System.Windows.Forms.ListBox();
            this.tbEntryTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbLang.SuspendLayout();
            this.gbEntryType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.83019F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление курса";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(119, 173);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(83, 25);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Добавить";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // tbCourseNameAdd
            // 
            this.tbCourseNameAdd.Location = new System.Drawing.Point(92, 57);
            this.tbCourseNameAdd.Name = "tbCourseNameAdd";
            this.tbCourseNameAdd.Size = new System.Drawing.Size(110, 25);
            this.tbCourseNameAdd.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(18, 60);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 17);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Название:";
            // 
            // rbPython
            // 
            this.rbPython.AutoSize = true;
            this.rbPython.Location = new System.Drawing.Point(9, 24);
            this.rbPython.Name = "rbPython";
            this.rbPython.Size = new System.Drawing.Size(65, 21);
            this.rbPython.TabIndex = 6;
            this.rbPython.TabStop = true;
            this.rbPython.Text = "Python";
            this.rbPython.UseVisualStyleBackColor = true;
            // 
            // gbLang
            // 
            this.gbLang.Controls.Add(this.rbCsharp);
            this.gbLang.Controls.Add(this.rbPython);
            this.gbLang.Location = new System.Drawing.Point(18, 88);
            this.gbLang.Name = "gbLang";
            this.gbLang.Size = new System.Drawing.Size(184, 79);
            this.gbLang.TabIndex = 7;
            this.gbLang.TabStop = false;
            this.gbLang.Text = "Язык программирования";
            // 
            // rbCsharp
            // 
            this.rbCsharp.AutoSize = true;
            this.rbCsharp.Location = new System.Drawing.Point(9, 51);
            this.rbCsharp.Name = "rbCsharp";
            this.rbCsharp.Size = new System.Drawing.Size(42, 21);
            this.rbCsharp.TabIndex = 7;
            this.rbCsharp.TabStop = true;
            this.rbCsharp.Text = "C#";
            this.rbCsharp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.83019F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавление материала (абзаца)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.83019F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавление раздела";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название:";
            // 
            // tbTopicName
            // 
            this.tbTopicName.Location = new System.Drawing.Point(433, 57);
            this.tbTopicName.Name = "tbTopicName";
            this.tbTopicName.Size = new System.Drawing.Size(229, 25);
            this.tbTopicName.TabIndex = 10;
            // 
            // gbEntryType
            // 
            this.gbEntryType.Controls.Add(this.rbCode);
            this.gbEntryType.Controls.Add(this.rbText);
            this.gbEntryType.Location = new System.Drawing.Point(18, 302);
            this.gbEntryType.Name = "gbEntryType";
            this.gbEntryType.Size = new System.Drawing.Size(184, 79);
            this.gbEntryType.TabIndex = 8;
            this.gbEntryType.TabStop = false;
            this.gbEntryType.Text = "Содержание";
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Location = new System.Drawing.Point(9, 51);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(55, 21);
            this.rbCode.TabIndex = 7;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "code";
            this.rbCode.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(9, 24);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(47, 21);
            this.rbText.TabIndex = 6;
            this.rbText.TabStop = true;
            this.rbText.Text = "text";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // checkCourse
            // 
            this.checkCourse.FormattingEnabled = true;
            this.checkCourse.Location = new System.Drawing.Point(359, 88);
            this.checkCourse.Name = "checkCourse";
            this.checkCourse.Size = new System.Drawing.Size(303, 104);
            this.checkCourse.TabIndex = 12;
            this.checkCourse.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.Location = new System.Drawing.Point(579, 198);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(83, 25);
            this.btnAddTopic.TabIndex = 13;
            this.btnAddTopic.Text = "Добавить";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // rtbEntry
            // 
            this.rtbEntry.Location = new System.Drawing.Point(222, 333);
            this.rtbEntry.Name = "rtbEntry";
            this.rtbEntry.Size = new System.Drawing.Size(440, 277);
            this.rtbEntry.TabIndex = 14;
            this.rtbEntry.Text = "";
            // 
            // btnAddEntrie
            // 
            this.btnAddEntrie.Location = new System.Drawing.Point(579, 616);
            this.btnAddEntrie.Name = "btnAddEntrie";
            this.btnAddEntrie.Size = new System.Drawing.Size(83, 25);
            this.btnAddEntrie.TabIndex = 17;
            this.btnAddEntrie.Text = "Добавить";
            this.btnAddEntrie.UseVisualStyleBackColor = true;
            this.btnAddEntrie.Click += new System.EventHandler(this.btnAddEntrie_Click);
            // 
            // checkCourseForAdd
            // 
            this.checkCourseForAdd.FormattingEnabled = true;
            this.checkCourseForAdd.ItemHeight = 17;
            this.checkCourseForAdd.Location = new System.Drawing.Point(18, 387);
            this.checkCourseForAdd.Name = "checkCourseForAdd";
            this.checkCourseForAdd.Size = new System.Drawing.Size(184, 72);
            this.checkCourseForAdd.TabIndex = 18;
            this.checkCourseForAdd.SelectedIndexChanged += new System.EventHandler(this.checkCourseForAdd_SelectedIndexChanged);
            // 
            // checkTopicForAdd
            // 
            this.checkTopicForAdd.FormattingEnabled = true;
            this.checkTopicForAdd.ItemHeight = 17;
            this.checkTopicForAdd.Location = new System.Drawing.Point(18, 465);
            this.checkTopicForAdd.Name = "checkTopicForAdd";
            this.checkTopicForAdd.Size = new System.Drawing.Size(184, 140);
            this.checkTopicForAdd.TabIndex = 19;
            // 
            // tbEntryTitle
            // 
            this.tbEntryTitle.Location = new System.Drawing.Point(296, 302);
            this.tbEntryTitle.Name = "tbEntryTitle";
            this.tbEntryTitle.Size = new System.Drawing.Size(366, 25);
            this.tbEntryTitle.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Название:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEntryTitle);
            this.Controls.Add(this.checkTopicForAdd);
            this.Controls.Add(this.checkCourseForAdd);
            this.Controls.Add(this.btnAddEntrie);
            this.Controls.Add(this.rtbEntry);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.checkCourse);
            this.Controls.Add(this.gbEntryType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTopicName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbLang);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbCourseNameAdd);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLang.ResumeLayout(false);
            this.gbLang.PerformLayout();
            this.gbEntryType.ResumeLayout(false);
            this.gbEntryType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAddCourse;
        private TextBox tbCourseNameAdd;
        private Label lbl;
        private RadioButton rbPython;
        private GroupBox gbLang;
        private RadioButton rbCsharp;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTopicName;
        private GroupBox gbEntryType;
        private RadioButton rbCode;
        private RadioButton rbText;
        private CheckedListBox checkCourse;
        private Button btnAddTopic;
        private RichTextBox rtbEntry;
        private Button btnAddEntrie;
        private ListBox checkCourseForAdd;
        private ListBox checkTopicForAdd;
        private TextBox tbEntryTitle;
        private Label label5;
    }
}