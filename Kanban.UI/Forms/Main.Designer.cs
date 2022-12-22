namespace Kanban.UI.Froms
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgwToDo = new System.Windows.Forms.DataGridView();
            this.dgwDoing = new System.Windows.Forms.DataGridView();
            this.dgwDone = new System.Windows.Forms.DataGridView();
            this.btnDoing = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(339, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanban Board";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(403, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(655, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Done";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kanban.UI.Properties.Resources.Flower_Divider_PNG_Image_File;
            this.pictureBox2.Location = new System.Drawing.Point(223, -60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(397, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dgwToDo
            // 
            this.dgwToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwToDo.Location = new System.Drawing.Point(35, 188);
            this.dgwToDo.Name = "dgwToDo";
            this.dgwToDo.RowHeadersWidth = 51;
            this.dgwToDo.RowTemplate.Height = 24;
            this.dgwToDo.Size = new System.Drawing.Size(240, 474);
            this.dgwToDo.TabIndex = 9;
            this.dgwToDo.SelectionChanged += new System.EventHandler(this.dgwToDo_SelectionChanged);
            // 
            // dgwDoing
            // 
            this.dgwDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoing.Location = new System.Drawing.Point(316, 188);
            this.dgwDoing.Name = "dgwDoing";
            this.dgwDoing.RowHeadersWidth = 51;
            this.dgwDoing.RowTemplate.Height = 24;
            this.dgwDoing.Size = new System.Drawing.Size(240, 474);
            this.dgwDoing.TabIndex = 10;
            this.dgwDoing.SelectionChanged += new System.EventHandler(this.dgwDoing_SelectionChanged);
            // 
            // dgwDone
            // 
            this.dgwDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDone.Location = new System.Drawing.Point(590, 188);
            this.dgwDone.Name = "dgwDone";
            this.dgwDone.RowHeadersWidth = 51;
            this.dgwDone.RowTemplate.Height = 24;
            this.dgwDone.Size = new System.Drawing.Size(240, 474);
            this.dgwDone.TabIndex = 11;
            // 
            // btnDoing
            // 
            this.btnDoing.Location = new System.Drawing.Point(316, 682);
            this.btnDoing.Name = "btnDoing";
            this.btnDoing.Size = new System.Drawing.Size(94, 35);
            this.btnDoing.TabIndex = 12;
            this.btnDoing.Text = "Doing";
            this.btnDoing.UseVisualStyleBackColor = true;
            this.btnDoing.Click += new System.EventHandler(this.btnDoing_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(466, 682);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(90, 35);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 682);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(877, 741);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDoing);
            this.Controls.Add(this.dgwDone);
            this.Controls.Add(this.dgwDoing);
            this.Controls.Add(this.dgwToDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(895, 788);
            this.MinimumSize = new System.Drawing.Size(895, 788);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgwToDo;
        private System.Windows.Forms.DataGridView dgwDoing;
        private System.Windows.Forms.DataGridView dgwDone;
        private System.Windows.Forms.Button btnDoing;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAdd;
    }
}