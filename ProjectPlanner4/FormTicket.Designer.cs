namespace ProjectPlanner4
{
    partial class FormTicket
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
            this.richTextTicket = new System.Windows.Forms.RichTextBox();
            this.checkListBoxTicketCategory = new System.Windows.Forms.CheckedListBox();
            this.labelTicketName = new System.Windows.Forms.Label();
            this.textBoxTicketName = new System.Windows.Forms.TextBox();
            this.radioButtonOpenList = new System.Windows.Forms.RadioButton();
            this.radioButtonClosedList = new System.Windows.Forms.RadioButton();
            this.checkListBoxSubTasks = new System.Windows.Forms.CheckedListBox();
            this.buttonCreateSubTask = new System.Windows.Forms.Button();
            this.buttonRemoveSubTask = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelSubTasks = new System.Windows.Forms.Label();
            this.GraphicsLine = new System.Windows.Forms.Label();
            this.buttonTicketCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTicketDelete = new System.Windows.Forms.Button();
            this.labelTicketTimeSpent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextTicket
            // 
            this.richTextTicket.Location = new System.Drawing.Point(177, 39);
            this.richTextTicket.Name = "richTextTicket";
            this.richTextTicket.Size = new System.Drawing.Size(237, 100);
            this.richTextTicket.TabIndex = 0;
            this.richTextTicket.Text = "Ticket Description";
            // 
            // checkListBoxTicketCategory
            // 
            this.checkListBoxTicketCategory.CheckOnClick = true;
            this.checkListBoxTicketCategory.FormattingEnabled = true;
            this.checkListBoxTicketCategory.Location = new System.Drawing.Point(14, 39);
            this.checkListBoxTicketCategory.Name = "checkListBoxTicketCategory";
            this.checkListBoxTicketCategory.Size = new System.Drawing.Size(157, 154);
            this.checkListBoxTicketCategory.TabIndex = 1;
            this.checkListBoxTicketCategory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkListBoxTicketCategory_ItemCheck);
            // 
            // labelTicketName
            // 
            this.labelTicketName.AutoSize = true;
            this.labelTicketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketName.Location = new System.Drawing.Point(175, 14);
            this.labelTicketName.Name = "labelTicketName";
            this.labelTicketName.Size = new System.Drawing.Size(85, 16);
            this.labelTicketName.TabIndex = 2;
            this.labelTicketName.Text = "Ticket Name";
            // 
            // textBoxTicketName
            // 
            this.textBoxTicketName.Location = new System.Drawing.Point(266, 13);
            this.textBoxTicketName.Name = "textBoxTicketName";
            this.textBoxTicketName.Size = new System.Drawing.Size(148, 20);
            this.textBoxTicketName.TabIndex = 3;
            // 
            // radioButtonOpenList
            // 
            this.radioButtonOpenList.AutoSize = true;
            this.radioButtonOpenList.Checked = true;
            this.radioButtonOpenList.Location = new System.Drawing.Point(207, 145);
            this.radioButtonOpenList.Name = "radioButtonOpenList";
            this.radioButtonOpenList.Size = new System.Drawing.Size(84, 17);
            this.radioButtonOpenList.TabIndex = 4;
            this.radioButtonOpenList.TabStop = true;
            this.radioButtonOpenList.Text = "Open Ticket";
            this.radioButtonOpenList.UseVisualStyleBackColor = true;
            this.radioButtonOpenList.CheckedChanged += new System.EventHandler(this.radioButtonOpenList_CheckedChanged);
            // 
            // radioButtonClosedList
            // 
            this.radioButtonClosedList.AutoSize = true;
            this.radioButtonClosedList.Location = new System.Drawing.Point(297, 145);
            this.radioButtonClosedList.Name = "radioButtonClosedList";
            this.radioButtonClosedList.Size = new System.Drawing.Size(90, 17);
            this.radioButtonClosedList.TabIndex = 5;
            this.radioButtonClosedList.TabStop = true;
            this.radioButtonClosedList.Text = "Closed Ticket";
            this.radioButtonClosedList.UseVisualStyleBackColor = true;
            // 
            // checkListBoxSubTasks
            // 
            this.checkListBoxSubTasks.FormattingEnabled = true;
            this.checkListBoxSubTasks.Location = new System.Drawing.Point(420, 39);
            this.checkListBoxSubTasks.Name = "checkListBoxSubTasks";
            this.checkListBoxSubTasks.Size = new System.Drawing.Size(157, 154);
            this.checkListBoxSubTasks.TabIndex = 6;
            // 
            // buttonCreateSubTask
            // 
            this.buttonCreateSubTask.Location = new System.Drawing.Point(420, 199);
            this.buttonCreateSubTask.Name = "buttonCreateSubTask";
            this.buttonCreateSubTask.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSubTask.TabIndex = 7;
            this.buttonCreateSubTask.Text = "Create";
            this.buttonCreateSubTask.UseVisualStyleBackColor = true;
            this.buttonCreateSubTask.Click += new System.EventHandler(this.buttonCreateSubTask_Click);
            // 
            // buttonRemoveSubTask
            // 
            this.buttonRemoveSubTask.Location = new System.Drawing.Point(502, 198);
            this.buttonRemoveSubTask.Name = "buttonRemoveSubTask";
            this.buttonRemoveSubTask.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSubTask.TabIndex = 8;
            this.buttonRemoveSubTask.Text = "Remove";
            this.buttonRemoveSubTask.UseVisualStyleBackColor = true;
            this.buttonRemoveSubTask.Click += new System.EventHandler(this.buttonRemoveSubTask_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(59, 20);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 16);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Category";
            // 
            // labelSubTasks
            // 
            this.labelSubTasks.AutoSize = true;
            this.labelSubTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTasks.Location = new System.Drawing.Point(463, 20);
            this.labelSubTasks.Name = "labelSubTasks";
            this.labelSubTasks.Size = new System.Drawing.Size(73, 16);
            this.labelSubTasks.TabIndex = 10;
            this.labelSubTasks.Text = "Sub Tasks";
            // 
            // GraphicsLine
            // 
            this.GraphicsLine.AutoSize = true;
            this.GraphicsLine.Location = new System.Drawing.Point(-6, 225);
            this.GraphicsLine.Name = "GraphicsLine";
            this.GraphicsLine.Size = new System.Drawing.Size(607, 13);
            this.GraphicsLine.TabIndex = 11;
            this.GraphicsLine.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // buttonTicketCreate
            // 
            this.buttonTicketCreate.Location = new System.Drawing.Point(12, 254);
            this.buttonTicketCreate.Name = "buttonTicketCreate";
            this.buttonTicketCreate.Size = new System.Drawing.Size(100, 25);
            this.buttonTicketCreate.TabIndex = 12;
            this.buttonTicketCreate.Text = "Create Ticket";
            this.buttonTicketCreate.UseVisualStyleBackColor = true;
            this.buttonTicketCreate.Click += new System.EventHandler(this.buttonTicketCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTicketDelete
            // 
            this.buttonTicketDelete.Location = new System.Drawing.Point(240, 254);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(100, 23);
            this.buttonTicketDelete.TabIndex = 14;
            this.buttonTicketDelete.Text = "Delete Ticket";
            this.buttonTicketDelete.UseVisualStyleBackColor = true;
            this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
            // 
            // labelTicketTimeSpent
            // 
            this.labelTicketTimeSpent.AutoSize = true;
            this.labelTicketTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketTimeSpent.Location = new System.Drawing.Point(12, 206);
            this.labelTicketTimeSpent.Name = "labelTicketTimeSpent";
            this.labelTicketTimeSpent.Size = new System.Drawing.Size(83, 16);
            this.labelTicketTimeSpent.TabIndex = 15;
            this.labelTicketTimeSpent.Text = "Time Spent: ";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 289);
            this.ControlBox = false;
            this.Controls.Add(this.labelTicketTimeSpent);
            this.Controls.Add(this.buttonTicketDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonTicketCreate);
            this.Controls.Add(this.GraphicsLine);
            this.Controls.Add(this.labelSubTasks);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonRemoveSubTask);
            this.Controls.Add(this.buttonCreateSubTask);
            this.Controls.Add(this.checkListBoxSubTasks);
            this.Controls.Add(this.radioButtonClosedList);
            this.Controls.Add(this.radioButtonOpenList);
            this.Controls.Add(this.textBoxTicketName);
            this.Controls.Add(this.labelTicketName);
            this.Controls.Add(this.checkListBoxTicketCategory);
            this.Controls.Add(this.richTextTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTicket_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTicket_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextTicket;
        private System.Windows.Forms.CheckedListBox checkListBoxTicketCategory;
        private System.Windows.Forms.Label labelTicketName;
        private System.Windows.Forms.TextBox textBoxTicketName;
        private System.Windows.Forms.RadioButton radioButtonOpenList;
        private System.Windows.Forms.RadioButton radioButtonClosedList;
        private System.Windows.Forms.Button buttonCreateSubTask;
        private System.Windows.Forms.Button buttonRemoveSubTask;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSubTasks;
        private System.Windows.Forms.Label GraphicsLine;
        private System.Windows.Forms.Button buttonTicketCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTicketDelete;
        public System.Windows.Forms.CheckedListBox checkListBoxSubTasks;
        private System.Windows.Forms.Label labelTicketTimeSpent;
    }
}