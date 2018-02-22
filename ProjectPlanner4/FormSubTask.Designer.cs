namespace ProjectPlanner4
{
    partial class FormSubTask
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
            this.labelSubTaskName = new System.Windows.Forms.Label();
            this.textBoxSubTaskName = new System.Windows.Forms.TextBox();
            this.buttonCreateSubTask = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubTaskName
            // 
            this.labelSubTaskName.AutoSize = true;
            this.labelSubTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTaskName.Location = new System.Drawing.Point(12, 9);
            this.labelSubTaskName.Name = "labelSubTaskName";
            this.labelSubTaskName.Size = new System.Drawing.Size(45, 16);
            this.labelSubTaskName.TabIndex = 0;
            this.labelSubTaskName.Text = "Name";
            // 
            // textBoxSubTaskName
            // 
            this.textBoxSubTaskName.Location = new System.Drawing.Point(63, 8);
            this.textBoxSubTaskName.Name = "textBoxSubTaskName";
            this.textBoxSubTaskName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTaskName.TabIndex = 1;
            // 
            // buttonCreateSubTask
            // 
            this.buttonCreateSubTask.Location = new System.Drawing.Point(12, 38);
            this.buttonCreateSubTask.Name = "buttonCreateSubTask";
            this.buttonCreateSubTask.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSubTask.TabIndex = 2;
            this.buttonCreateSubTask.Text = "Create";
            this.buttonCreateSubTask.UseVisualStyleBackColor = true;
            this.buttonCreateSubTask.Click += new System.EventHandler(this.buttonCreateSubTask_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 38);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 73);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateSubTask);
            this.Controls.Add(this.textBoxSubTaskName);
            this.Controls.Add(this.labelSubTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormSubTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Task";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSubTask_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubTaskName;
        private System.Windows.Forms.TextBox textBoxSubTaskName;
        private System.Windows.Forms.Button buttonCreateSubTask;
        private System.Windows.Forms.Button buttonCancel;
    }
}