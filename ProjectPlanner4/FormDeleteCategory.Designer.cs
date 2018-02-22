namespace ProjectPlanner4
{
    partial class FormDeleteCategory
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
            this.labelCategoryToBeDeleted = new System.Windows.Forms.Label();
            this.textBoxCategoryToDelete = new System.Windows.Forms.TextBox();
            this.checkListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.labelReplaceCategoryItems = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoryToBeDeleted
            // 
            this.labelCategoryToBeDeleted.AutoSize = true;
            this.labelCategoryToBeDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryToBeDeleted.Location = new System.Drawing.Point(45, 8);
            this.labelCategoryToBeDeleted.Name = "labelCategoryToBeDeleted";
            this.labelCategoryToBeDeleted.Size = new System.Drawing.Size(118, 16);
            this.labelCategoryToBeDeleted.TabIndex = 0;
            this.labelCategoryToBeDeleted.Text = "Category to delete";
            // 
            // textBoxCategoryToDelete
            // 
            this.textBoxCategoryToDelete.Location = new System.Drawing.Point(15, 30);
            this.textBoxCategoryToDelete.Name = "textBoxCategoryToDelete";
            this.textBoxCategoryToDelete.ReadOnly = true;
            this.textBoxCategoryToDelete.Size = new System.Drawing.Size(192, 20);
            this.textBoxCategoryToDelete.TabIndex = 1;
            // 
            // checkListBoxCategories
            // 
            this.checkListBoxCategories.FormattingEnabled = true;
            this.checkListBoxCategories.Location = new System.Drawing.Point(15, 69);
            this.checkListBoxCategories.Name = "checkListBoxCategories";
            this.checkListBoxCategories.Size = new System.Drawing.Size(192, 94);
            this.checkListBoxCategories.TabIndex = 2;
            this.checkListBoxCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkListBoxCategories_ItemCheck);
            // 
            // labelReplaceCategoryItems
            // 
            this.labelReplaceCategoryItems.AutoSize = true;
            this.labelReplaceCategoryItems.Location = new System.Drawing.Point(12, 53);
            this.labelReplaceCategoryItems.Name = "labelReplaceCategoryItems";
            this.labelReplaceCategoryItems.Size = new System.Drawing.Size(192, 13);
            this.labelReplaceCategoryItems.TabIndex = 3;
            this.labelReplaceCategoryItems.Text = "Replace Items from deleted category to";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(15, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(132, 169);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 201);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelReplaceCategoryItems);
            this.Controls.Add(this.checkListBoxCategories);
            this.Controls.Add(this.textBoxCategoryToDelete);
            this.Controls.Add(this.labelCategoryToBeDeleted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormDeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete category";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDeleteCategory_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoryToBeDeleted;
        private System.Windows.Forms.TextBox textBoxCategoryToDelete;
        private System.Windows.Forms.CheckedListBox checkListBoxCategories;
        private System.Windows.Forms.Label labelReplaceCategoryItems;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
    }
}