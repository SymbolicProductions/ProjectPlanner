namespace ProjectPlanner4
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelOpenTickets = new System.Windows.Forms.Label();
            this.labelCurrentTicket = new System.Windows.Forms.Label();
            this.labelClosedTickets = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxCurrentTicketSubtasks = new System.Windows.Forms.CheckedListBox();
            this.richTextCurrentTicket = new System.Windows.Forms.RichTextBox();
            this.buttonStartStopCurrentTicket = new System.Windows.Forms.Button();
            this.buttonCurrentTicketModify = new System.Windows.Forms.Button();
            this.textBoxCurrentTicketName = new System.Windows.Forms.TextBox();
            this.labelCurrentTicketName = new System.Windows.Forms.Label();
            this.labelCurrentTicketTimer = new System.Windows.Forms.Label();
            this.comboBoxOpenList = new System.Windows.Forms.ComboBox();
            this.labelOpenListView = new System.Windows.Forms.Label();
            this.graphicsStrip = new System.Windows.Forms.Label();
            this.labelClosedListView = new System.Windows.Forms.Label();
            this.comboBoxClosedList = new System.Windows.Forms.ComboBox();
            this.labelOpenTicketsAmount = new System.Windows.Forms.Label();
            this.labelClosedTicketsAmount = new System.Windows.Forms.Label();
            this.labelProjectTimeTotal = new System.Windows.Forms.Label();
            this.listBoxOpenTickets = new System.Windows.Forms.ListBox();
            this.listBoxClosedTickets = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonFinishTicket = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOpenTickets
            // 
            this.labelOpenTickets.AutoSize = true;
            this.labelOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenTickets.Location = new System.Drawing.Point(52, 40);
            this.labelOpenTickets.Name = "labelOpenTickets";
            this.labelOpenTickets.Size = new System.Drawing.Size(122, 24);
            this.labelOpenTickets.TabIndex = 0;
            this.labelOpenTickets.Text = "Open Tickets";
            // 
            // labelCurrentTicket
            // 
            this.labelCurrentTicket.AutoSize = true;
            this.labelCurrentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTicket.Location = new System.Drawing.Point(397, 24);
            this.labelCurrentTicket.Name = "labelCurrentTicket";
            this.labelCurrentTicket.Size = new System.Drawing.Size(127, 24);
            this.labelCurrentTicket.TabIndex = 1;
            this.labelCurrentTicket.Text = "Current Ticket";
            // 
            // labelClosedTickets
            // 
            this.labelClosedTickets.AutoSize = true;
            this.labelClosedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosedTickets.Location = new System.Drawing.Point(766, 40);
            this.labelClosedTickets.Name = "labelClosedTickets";
            this.labelClosedTickets.Size = new System.Drawing.Size(133, 24);
            this.labelClosedTickets.TabIndex = 2;
            this.labelClosedTickets.Text = "Closed Tickets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.createToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem1.Text = "New Project";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open Project";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save Project";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDocumentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "View";
            // 
            // viewDocumentationToolStripMenuItem
            // 
            this.viewDocumentationToolStripMenuItem.Name = "viewDocumentationToolStripMenuItem";
            this.viewDocumentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewDocumentationToolStripMenuItem.Text = "Documentation";
            this.viewDocumentationToolStripMenuItem.Click += new System.EventHandler(this.viewDocumentationToolStripMenuItem_Click);
            // 
            // checkedListBoxCurrentTicketSubtasks
            // 
            this.checkedListBoxCurrentTicketSubtasks.FormattingEnabled = true;
            this.checkedListBoxCurrentTicketSubtasks.Location = new System.Drawing.Point(341, 212);
            this.checkedListBoxCurrentTicketSubtasks.Name = "checkedListBoxCurrentTicketSubtasks";
            this.checkedListBoxCurrentTicketSubtasks.Size = new System.Drawing.Size(237, 124);
            this.checkedListBoxCurrentTicketSubtasks.TabIndex = 5;
            // 
            // richTextCurrentTicket
            // 
            this.richTextCurrentTicket.Location = new System.Drawing.Point(341, 89);
            this.richTextCurrentTicket.Name = "richTextCurrentTicket";
            this.richTextCurrentTicket.ReadOnly = true;
            this.richTextCurrentTicket.Size = new System.Drawing.Size(237, 100);
            this.richTextCurrentTicket.TabIndex = 6;
            this.richTextCurrentTicket.Text = "";
            // 
            // buttonStartStopCurrentTicket
            // 
            this.buttonStartStopCurrentTicket.Location = new System.Drawing.Point(341, 342);
            this.buttonStartStopCurrentTicket.Name = "buttonStartStopCurrentTicket";
            this.buttonStartStopCurrentTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStopCurrentTicket.TabIndex = 7;
            this.buttonStartStopCurrentTicket.Text = "Start";
            this.buttonStartStopCurrentTicket.UseVisualStyleBackColor = true;
            this.buttonStartStopCurrentTicket.Click += new System.EventHandler(this.buttonStartStopCurrentTicket_Click);
            // 
            // buttonCurrentTicketModify
            // 
            this.buttonCurrentTicketModify.Location = new System.Drawing.Point(503, 342);
            this.buttonCurrentTicketModify.Name = "buttonCurrentTicketModify";
            this.buttonCurrentTicketModify.Size = new System.Drawing.Size(75, 23);
            this.buttonCurrentTicketModify.TabIndex = 8;
            this.buttonCurrentTicketModify.Text = "Modify";
            this.buttonCurrentTicketModify.UseVisualStyleBackColor = true;
            this.buttonCurrentTicketModify.Click += new System.EventHandler(this.buttonCurrentTicketModify_Click);
            // 
            // textBoxCurrentTicketName
            // 
            this.textBoxCurrentTicketName.Location = new System.Drawing.Point(412, 63);
            this.textBoxCurrentTicketName.Name = "textBoxCurrentTicketName";
            this.textBoxCurrentTicketName.ReadOnly = true;
            this.textBoxCurrentTicketName.Size = new System.Drawing.Size(166, 20);
            this.textBoxCurrentTicketName.TabIndex = 9;
            // 
            // labelCurrentTicketName
            // 
            this.labelCurrentTicketName.AutoSize = true;
            this.labelCurrentTicketName.Location = new System.Drawing.Point(338, 66);
            this.labelCurrentTicketName.Name = "labelCurrentTicketName";
            this.labelCurrentTicketName.Size = new System.Drawing.Size(68, 13);
            this.labelCurrentTicketName.TabIndex = 10;
            this.labelCurrentTicketName.Text = "Ticket Name";
            // 
            // labelCurrentTicketTimer
            // 
            this.labelCurrentTicketTimer.AutoSize = true;
            this.labelCurrentTicketTimer.Location = new System.Drawing.Point(338, 196);
            this.labelCurrentTicketTimer.Name = "labelCurrentTicketTimer";
            this.labelCurrentTicketTimer.Size = new System.Drawing.Size(109, 13);
            this.labelCurrentTicketTimer.TabIndex = 13;
            this.labelCurrentTicketTimer.Text = "Time Spent: 00:00:00";
            // 
            // comboBoxOpenList
            // 
            this.comboBoxOpenList.FormattingEnabled = true;
            this.comboBoxOpenList.Location = new System.Drawing.Point(56, 76);
            this.comboBoxOpenList.Name = "comboBoxOpenList";
            this.comboBoxOpenList.Size = new System.Drawing.Size(157, 21);
            this.comboBoxOpenList.TabIndex = 15;
            this.comboBoxOpenList.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOpenList_SelectionChangeCommitted);
            // 
            // labelOpenListView
            // 
            this.labelOpenListView.AutoSize = true;
            this.labelOpenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenListView.Location = new System.Drawing.Point(13, 77);
            this.labelOpenListView.Name = "labelOpenListView";
            this.labelOpenListView.Size = new System.Drawing.Size(37, 16);
            this.labelOpenListView.TabIndex = 16;
            this.labelOpenListView.Text = "View";
            // 
            // graphicsStrip
            // 
            this.graphicsStrip.AutoSize = true;
            this.graphicsStrip.Location = new System.Drawing.Point(-171, 393);
            this.graphicsStrip.Name = "graphicsStrip";
            this.graphicsStrip.Size = new System.Drawing.Size(1285, 13);
            this.graphicsStrip.TabIndex = 17;
            this.graphicsStrip.Text = resources.GetString("graphicsStrip.Text");
            // 
            // labelClosedListView
            // 
            this.labelClosedListView.AutoSize = true;
            this.labelClosedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosedListView.Location = new System.Drawing.Point(732, 67);
            this.labelClosedListView.Name = "labelClosedListView";
            this.labelClosedListView.Size = new System.Drawing.Size(37, 16);
            this.labelClosedListView.TabIndex = 20;
            this.labelClosedListView.Text = "View";
            // 
            // comboBoxClosedList
            // 
            this.comboBoxClosedList.FormattingEnabled = true;
            this.comboBoxClosedList.Location = new System.Drawing.Point(775, 66);
            this.comboBoxClosedList.Name = "comboBoxClosedList";
            this.comboBoxClosedList.Size = new System.Drawing.Size(157, 21);
            this.comboBoxClosedList.TabIndex = 19;
            this.comboBoxClosedList.SelectionChangeCommitted += new System.EventHandler(this.listBoxClosedTickets_SelectionChangeCommitted);
            // 
            // labelOpenTicketsAmount
            // 
            this.labelOpenTicketsAmount.AutoSize = true;
            this.labelOpenTicketsAmount.Location = new System.Drawing.Point(13, 420);
            this.labelOpenTicketsAmount.Name = "labelOpenTicketsAmount";
            this.labelOpenTicketsAmount.Size = new System.Drawing.Size(83, 13);
            this.labelOpenTicketsAmount.TabIndex = 21;
            this.labelOpenTicketsAmount.Text = "Open Tickets: 0";
            // 
            // labelClosedTicketsAmount
            // 
            this.labelClosedTicketsAmount.AutoSize = true;
            this.labelClosedTicketsAmount.Location = new System.Drawing.Point(790, 420);
            this.labelClosedTicketsAmount.Name = "labelClosedTicketsAmount";
            this.labelClosedTicketsAmount.Size = new System.Drawing.Size(100, 13);
            this.labelClosedTicketsAmount.TabIndex = 22;
            this.labelClosedTicketsAmount.Text = "Closed Tickets: 0/0";
            // 
            // labelProjectTimeTotal
            // 
            this.labelProjectTimeTotal.AutoSize = true;
            this.labelProjectTimeTotal.Location = new System.Drawing.Point(409, 418);
            this.labelProjectTimeTotal.Name = "labelProjectTimeTotal";
            this.labelProjectTimeTotal.Size = new System.Drawing.Size(105, 13);
            this.labelProjectTimeTotal.TabIndex = 23;
            this.labelProjectTimeTotal.Text = "Total Time: 00:00:00";
            // 
            // listBoxOpenTickets
            // 
            this.listBoxOpenTickets.FormattingEnabled = true;
            this.listBoxOpenTickets.Location = new System.Drawing.Point(16, 103);
            this.listBoxOpenTickets.Name = "listBoxOpenTickets";
            this.listBoxOpenTickets.Size = new System.Drawing.Size(200, 277);
            this.listBoxOpenTickets.TabIndex = 24;
            this.listBoxOpenTickets.SelectedIndexChanged += new System.EventHandler(this.listBoxOpenTickets_SelectedIndexChanged);
            // 
            // listBoxClosedTickets
            // 
            this.listBoxClosedTickets.FormattingEnabled = true;
            this.listBoxClosedTickets.Location = new System.Drawing.Point(735, 93);
            this.listBoxClosedTickets.Name = "listBoxClosedTickets";
            this.listBoxClosedTickets.Size = new System.Drawing.Size(200, 277);
            this.listBoxClosedTickets.TabIndex = 25;
            this.listBoxClosedTickets.SelectedIndexChanged += new System.EventHandler(this.listBoxClosedTickets_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonFinishTicket
            // 
            this.buttonFinishTicket.Location = new System.Drawing.Point(422, 342);
            this.buttonFinishTicket.Name = "buttonFinishTicket";
            this.buttonFinishTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonFinishTicket.TabIndex = 26;
            this.buttonFinishTicket.Text = "Finish";
            this.buttonFinishTicket.UseVisualStyleBackColor = true;
            this.buttonFinishTicket.Click += new System.EventHandler(this.buttonFinishTicket_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 440);
            this.Controls.Add(this.buttonFinishTicket);
            this.Controls.Add(this.listBoxClosedTickets);
            this.Controls.Add(this.listBoxOpenTickets);
            this.Controls.Add(this.labelProjectTimeTotal);
            this.Controls.Add(this.labelClosedTicketsAmount);
            this.Controls.Add(this.labelOpenTicketsAmount);
            this.Controls.Add(this.labelClosedListView);
            this.Controls.Add(this.comboBoxClosedList);
            this.Controls.Add(this.graphicsStrip);
            this.Controls.Add(this.labelOpenListView);
            this.Controls.Add(this.comboBoxOpenList);
            this.Controls.Add(this.labelCurrentTicketTimer);
            this.Controls.Add(this.labelCurrentTicketName);
            this.Controls.Add(this.textBoxCurrentTicketName);
            this.Controls.Add(this.buttonCurrentTicketModify);
            this.Controls.Add(this.buttonStartStopCurrentTicket);
            this.Controls.Add(this.richTextCurrentTicket);
            this.Controls.Add(this.checkedListBoxCurrentTicketSubtasks);
            this.Controls.Add(this.labelClosedTickets);
            this.Controls.Add(this.labelCurrentTicket);
            this.Controls.Add(this.labelOpenTickets);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Planner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpenTickets;
        private System.Windows.Forms.Label labelCurrentTicket;
        private System.Windows.Forms.Label labelClosedTickets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckedListBox checkedListBoxCurrentTicketSubtasks;
        private System.Windows.Forms.RichTextBox richTextCurrentTicket;
        private System.Windows.Forms.Button buttonStartStopCurrentTicket;
        private System.Windows.Forms.Button buttonCurrentTicketModify;
        private System.Windows.Forms.TextBox textBoxCurrentTicketName;
        private System.Windows.Forms.Label labelCurrentTicketName;
        private System.Windows.Forms.Label labelCurrentTicketTimer;
        private System.Windows.Forms.ComboBox comboBoxOpenList;
        private System.Windows.Forms.Label labelOpenListView;
        private System.Windows.Forms.Label graphicsStrip;
        private System.Windows.Forms.Label labelClosedListView;
        private System.Windows.Forms.ComboBox comboBoxClosedList;
        private System.Windows.Forms.Label labelOpenTicketsAmount;
        private System.Windows.Forms.Label labelClosedTicketsAmount;
        private System.Windows.Forms.Label labelProjectTimeTotal;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDocumentationToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxOpenTickets;
        private System.Windows.Forms.ListBox listBoxClosedTickets;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonFinishTicket;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

