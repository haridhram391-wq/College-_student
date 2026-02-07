namespace RKD_college
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.textBoxFirst_name = new System.Windows.Forms.TextBox();
            this.textBoxLast_name = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPhone_no = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GET DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(1011, 13);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(223, 22);
            this.textBoxRoll.TabIndex = 2;
            this.textBoxRoll.TextChanged += new System.EventHandler(this.textBoxRoll_TextChanged);
            // 
            // textBoxFirst_name
            // 
            this.textBoxFirst_name.Location = new System.Drawing.Point(1011, 42);
            this.textBoxFirst_name.Name = "textBoxFirst_name";
            this.textBoxFirst_name.Size = new System.Drawing.Size(223, 22);
            this.textBoxFirst_name.TabIndex = 3;
            this.textBoxFirst_name.TextChanged += new System.EventHandler(this.textBoxFirst_name_TextChanged);
            // 
            // textBoxLast_name
            // 
            this.textBoxLast_name.Location = new System.Drawing.Point(1011, 71);
            this.textBoxLast_name.Name = "textBoxLast_name";
            this.textBoxLast_name.Size = new System.Drawing.Size(223, 22);
            this.textBoxLast_name.TabIndex = 4;
            this.textBoxLast_name.TextChanged += new System.EventHandler(this.textBoxLast_name_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(1011, 100);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(223, 22);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // textBoxPhone_no
            // 
            this.textBoxPhone_no.Location = new System.Drawing.Point(1011, 129);
            this.textBoxPhone_no.Name = "textBoxPhone_no";
            this.textBoxPhone_no.Size = new System.Drawing.Size(223, 22);
            this.textBoxPhone_no.TabIndex = 6;
            this.textBoxPhone_no.TextChanged += new System.EventHandler(this.textBoxPhone_no_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1011, 157);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(223, 22);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(1011, 186);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(223, 22);
            this.textBoxCourse.TabIndex = 8;
            this.textBoxCourse.TextChanged += new System.EventHandler(this.textBoxCourse_TextChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1011, 214);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1159, 214);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 525);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone_no);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLast_name);
            this.Controls.Add(this.textBoxFirst_name);
            this.Controls.Add(this.textBoxRoll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TextBox textBoxFirst_name;
        private System.Windows.Forms.TextBox textBoxLast_name;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPhone_no;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

