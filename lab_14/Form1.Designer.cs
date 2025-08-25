namespace lab_14
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dogsDataGridView = new System.Windows.Forms.DataGridView();
            this.generateButton = new System.Windows.Forms.Button();
            this.increasePriceButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.saveButton);
            this.splitContainer1.Panel1.Controls.Add(this.loadButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.sortButton);
            this.splitContainer1.Panel1.Controls.Add(this.increasePriceButton);
            this.splitContainer1.Panel1.Controls.Add(this.generateButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dogsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // dogsDataGridView
            // 
            this.dogsDataGridView.AllowUserToAddRows = false;
            this.dogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dogsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dogsDataGridView.Name = "dogsDataGridView";
            this.dogsDataGridView.ReadOnly = true;
            this.dogsDataGridView.RowHeadersWidth = 51;
            this.dogsDataGridView.RowTemplate.Height = 24;
            this.dogsDataGridView.Size = new System.Drawing.Size(526, 446);
            this.dogsDataGridView.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(0, 0);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(262, 49);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Згенерувати список";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // increasePriceButton
            // 
            this.increasePriceButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.increasePriceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.increasePriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increasePriceButton.Location = new System.Drawing.Point(0, 49);
            this.increasePriceButton.Name = "increasePriceButton";
            this.increasePriceButton.Size = new System.Drawing.Size(262, 48);
            this.increasePriceButton.TabIndex = 1;
            this.increasePriceButton.Text = "Підняти ціну самкам 2 р.";
            this.increasePriceButton.UseVisualStyleBackColor = false;
            this.increasePriceButton.Click += new System.EventHandler(this.increasePriceButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortButton.Location = new System.Drawing.Point(0, 97);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(262, 53);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортувати за ID";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(this.allRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр за статтю";
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(11, 24);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(53, 22);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Всі";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(11, 53);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(75, 22);
            this.maleRadioButton.TabIndex = 1;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Самці";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(11, 82);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(80, 22);
            this.femaleRadioButton.TabIndex = 2;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Самки";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(0, 393);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(262, 53);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Завантажити з файлу";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(0, 337);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(262, 56);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Зберегти у файл";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dogsDataGridView;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button increasePriceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

