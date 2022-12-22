namespace Kanban.UI.Forms
{
    partial class TaskAdd
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
            this.tbWhoDo = new System.Windows.Forms.TextBox();
            this.rtbDescp = new System.Windows.Forms.RichTextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who does the task belong to?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is the task description?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "What is the status of the task?";
            // 
            // tbWhoDo
            // 
            this.tbWhoDo.Location = new System.Drawing.Point(53, 47);
            this.tbWhoDo.Name = "tbWhoDo";
            this.tbWhoDo.Size = new System.Drawing.Size(260, 22);
            this.tbWhoDo.TabIndex = 4;
            // 
            // rtbDescp
            // 
            this.rtbDescp.Location = new System.Drawing.Point(53, 93);
            this.rtbDescp.Name = "rtbDescp";
            this.rtbDescp.Size = new System.Drawing.Size(261, 96);
            this.rtbDescp.TabIndex = 6;
            this.rtbDescp.Text = "";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(58, 211);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(256, 24);
            this.cbState.TabIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(58, 270);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(89, 32);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(180, 270);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 32);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // TaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(386, 351);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.rtbDescp);
            this.Controls.Add(this.tbWhoDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(404, 398);
            this.MinimumSize = new System.Drawing.Size(404, 398);
            this.Name = "TaskAdd";
            this.Text = "TaskAdd";
            this.Load += new System.EventHandler(this.TaskAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWhoDo;
        private System.Windows.Forms.RichTextBox rtbDescp;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnReturn;
    }
}