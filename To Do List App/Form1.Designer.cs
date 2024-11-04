namespace To_Do_List_App
{
    partial class ToDoList
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
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            titleLabel = new Label();
            descriptionLabel = new Label();
            newButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(1342, 80);
            label1.TabIndex = 0;
            label1.Text = "C# To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(53, 159);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1280, 39);
            titleTextBox.TabIndex = 2;
            titleTextBox.TextChanged += textBox2_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(53, 267);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1280, 39);
            descriptionTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(53, 120);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1280, 36);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(53, 228);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(1280, 36);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // newButton
            // 
            newButton.Location = new Point(53, 358);
            newButton.Name = "newButton";
            newButton.Size = new Size(300, 100);
            newButton.TabIndex = 6;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(377, 358);
            editButton.Name = "editButton";
            editButton.Size = new Size(300, 100);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1026, 358);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(300, 100);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(700, 358);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(300, 100);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.Window;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(53, 506);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 82;
            toDoListView.Size = new Size(1273, 414);
            toDoListView.TabIndex = 10;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1398, 972);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List";
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label titleLabel;
        private Label descriptionLabel;
        private Button newButton;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private DataGridView toDoListView;
    }
}
