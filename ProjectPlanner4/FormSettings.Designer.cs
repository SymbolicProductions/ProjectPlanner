namespace ProjectPlanner4
{
    partial class FormSettings
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
            this.listBoxExistingCategories = new System.Windows.Forms.ListBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelNewCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryNewName = new System.Windows.Forms.TextBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonCategoryCreateNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeaderCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxExistingCategories
            // 
            this.listBoxExistingCategories.FormattingEnabled = true;
            this.listBoxExistingCategories.Location = new System.Drawing.Point(9, 59);
            this.listBoxExistingCategories.Name = "listBoxExistingCategories";
            this.listBoxExistingCategories.Size = new System.Drawing.Size(151, 160);
            this.listBoxExistingCategories.TabIndex = 0;
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(11, 40);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(123, 16);
            this.labelCategories.TabIndex = 1;
            this.labelCategories.Text = "Existing Categories";
            // 
            // labelNewCategoryName
            // 
            this.labelNewCategoryName.AutoSize = true;
            this.labelNewCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCategoryName.Location = new System.Drawing.Point(165, 40);
            this.labelNewCategoryName.Name = "labelNewCategoryName";
            this.labelNewCategoryName.Size = new System.Drawing.Size(133, 16);
            this.labelNewCategoryName.TabIndex = 2;
            this.labelNewCategoryName.Text = "New Category Name";
            // 
            // textBoxCategoryNewName
            // 
            this.textBoxCategoryNewName.Location = new System.Drawing.Point(165, 59);
            this.textBoxCategoryNewName.MaxLength = 32;
            this.textBoxCategoryNewName.Name = "textBoxCategoryNewName";
            this.textBoxCategoryNewName.Size = new System.Drawing.Size(133, 20);
            this.textBoxCategoryNewName.TabIndex = 3;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(165, 114);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(132, 23);
            this.buttonDeleteCategory.TabIndex = 4;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonCategoryCreateNew
            // 
            this.buttonCategoryCreateNew.Location = new System.Drawing.Point(165, 85);
            this.buttonCategoryCreateNew.Name = "buttonCategoryCreateNew";
            this.buttonCategoryCreateNew.Size = new System.Drawing.Size(132, 23);
            this.buttonCategoryCreateNew.TabIndex = 5;
            this.buttonCategoryCreateNew.Text = "Create Category";
            this.buttonCategoryCreateNew.UseVisualStyleBackColor = true;
            this.buttonCategoryCreateNew.Click += new System.EventHandler(this.buttonCategoryCreateNew_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(165, 196);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(132, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelHeaderCategories
            // 
            this.labelHeaderCategories.AutoSize = true;
            this.labelHeaderCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderCategories.Location = new System.Drawing.Point(106, 10);
            this.labelHeaderCategories.Name = "labelHeaderCategories";
            this.labelHeaderCategories.Size = new System.Drawing.Size(86, 20);
            this.labelHeaderCategories.TabIndex = 9;
            this.labelHeaderCategories.Text = "Categories";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 234);
            this.ControlBox = false;
            this.Controls.Add(this.labelHeaderCategories);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCategoryCreateNew);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.textBoxCategoryNewName);
            this.Controls.Add(this.labelNewCategoryName);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.listBoxExistingCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCategory_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExistingCategories;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelNewCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryNewName;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonCategoryCreateNew;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHeaderCategories;
    }
}