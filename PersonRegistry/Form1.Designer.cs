
namespace PersonRegistry
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
            this.personsListbox = new System.Windows.Forms.ListBox();
            this.FrstNameLbl = new System.Windows.Forms.Label();
            this.LstNameLbl = new System.Windows.Forms.Label();
            this.NewPersonGroupBox = new System.Windows.Forms.GroupBox();
            this.MergeBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.LstNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPersonBtn = new System.Windows.Forms.Button();
            this.FrstNameTextBox = new System.Windows.Forms.TextBox();
            this.PersonGroubBox = new System.Windows.Forms.GroupBox();
            this.NewPersonGroupBox.SuspendLayout();
            this.PersonGroubBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personsListbox
            // 
            this.personsListbox.FormattingEnabled = true;
            this.personsListbox.ItemHeight = 15;
            this.personsListbox.Location = new System.Drawing.Point(6, 22);
            this.personsListbox.Name = "personsListbox";
            this.personsListbox.Size = new System.Drawing.Size(311, 214);
            this.personsListbox.TabIndex = 0;
            this.personsListbox.SelectedIndexChanged += new System.EventHandler(this.personsListbox_SelectedIndexChanged);
            // 
            // FrstNameLbl
            // 
            this.FrstNameLbl.AutoSize = true;
            this.FrstNameLbl.Location = new System.Drawing.Point(6, 29);
            this.FrstNameLbl.Name = "FrstNameLbl";
            this.FrstNameLbl.Size = new System.Drawing.Size(65, 15);
            this.FrstNameLbl.TabIndex = 1;
            this.FrstNameLbl.Text = "First name:";
            // 
            // LstNameLbl
            // 
            this.LstNameLbl.AutoSize = true;
            this.LstNameLbl.Location = new System.Drawing.Point(5, 58);
            this.LstNameLbl.Name = "LstNameLbl";
            this.LstNameLbl.Size = new System.Drawing.Size(64, 15);
            this.LstNameLbl.TabIndex = 1;
            this.LstNameLbl.Text = "Last name:";
            // 
            // NewPersonGroupBox
            // 
            this.NewPersonGroupBox.Controls.Add(this.MergeBtn);
            this.NewPersonGroupBox.Controls.Add(this.RemoveBtn);
            this.NewPersonGroupBox.Controls.Add(this.FemaleRadioBtn);
            this.NewPersonGroupBox.Controls.Add(this.MaleRadioBtn);
            this.NewPersonGroupBox.Controls.Add(this.LstNameTextBox);
            this.NewPersonGroupBox.Controls.Add(this.AddPersonBtn);
            this.NewPersonGroupBox.Controls.Add(this.FrstNameTextBox);
            this.NewPersonGroupBox.Controls.Add(this.LstNameLbl);
            this.NewPersonGroupBox.Controls.Add(this.FrstNameLbl);
            this.NewPersonGroupBox.Location = new System.Drawing.Point(12, 12);
            this.NewPersonGroupBox.Name = "NewPersonGroupBox";
            this.NewPersonGroupBox.Size = new System.Drawing.Size(323, 166);
            this.NewPersonGroupBox.TabIndex = 2;
            this.NewPersonGroupBox.TabStop = false;
            this.NewPersonGroupBox.Text = "New person";
            // 
            // MergeBtn
            // 
            this.MergeBtn.Location = new System.Drawing.Point(214, 87);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(80, 26);
            this.MergeBtn.TabIndex = 1;
            this.MergeBtn.Text = "Merge";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(214, 55);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(80, 26);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(6, 119);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(63, 19);
            this.FemaleRadioBtn.TabIndex = 3;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(6, 94);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(51, 19);
            this.MaleRadioBtn.TabIndex = 3;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LstNameTextBox
            // 
            this.LstNameTextBox.Location = new System.Drawing.Point(81, 55);
            this.LstNameTextBox.Name = "LstNameTextBox";
            this.LstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.LstNameTextBox.TabIndex = 2;
            this.LstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrstNameTextBox_KeyPress);
            // 
            // AddPersonBtn
            // 
            this.AddPersonBtn.Location = new System.Drawing.Point(214, 23);
            this.AddPersonBtn.Name = "AddPersonBtn";
            this.AddPersonBtn.Size = new System.Drawing.Size(80, 26);
            this.AddPersonBtn.TabIndex = 1;
            this.AddPersonBtn.Text = "Add";
            this.AddPersonBtn.UseVisualStyleBackColor = true;
            this.AddPersonBtn.Click += new System.EventHandler(this.AddPersonBtn_Click);
            // 
            // FrstNameTextBox
            // 
            this.FrstNameTextBox.Location = new System.Drawing.Point(81, 26);
            this.FrstNameTextBox.Name = "FrstNameTextBox";
            this.FrstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.FrstNameTextBox.TabIndex = 2;
            this.FrstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrstNameTextBox_KeyPress);
            // 
            // PersonGroubBox
            // 
            this.PersonGroubBox.Controls.Add(this.personsListbox);
            this.PersonGroubBox.Location = new System.Drawing.Point(12, 185);
            this.PersonGroubBox.Name = "PersonGroubBox";
            this.PersonGroubBox.Size = new System.Drawing.Size(323, 244);
            this.PersonGroubBox.TabIndex = 3;
            this.PersonGroubBox.TabStop = false;
            this.PersonGroubBox.Text = "People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.PersonGroubBox);
            this.Controls.Add(this.NewPersonGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.NewPersonGroupBox.ResumeLayout(false);
            this.NewPersonGroupBox.PerformLayout();
            this.PersonGroubBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personsListbox;
        private System.Windows.Forms.Label FrstNameLbl;
        private System.Windows.Forms.Label LstNameLbl;
        private System.Windows.Forms.GroupBox NewPersonGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.TextBox LstNameTextBox;
        private System.Windows.Forms.Button AddPersonBtn;
        private System.Windows.Forms.TextBox FrstNameTextBox;
        private System.Windows.Forms.GroupBox PersonGroubBox;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button MergeBtn;
    }
}

