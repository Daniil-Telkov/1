namespace MainProject
{
    partial class InputLessonForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btAction = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.tbPair = new System.Windows.Forms.TextBox();
            this.lbPair = new System.Windows.Forms.Label();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(144, 272);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 55);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(12, 272);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(126, 55);
            this.btAction.TabIndex = 2;
            this.btAction.Text = "Добавить";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.BtAction_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Предмет";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbTeacher
            // 
            this.tbTeacher.Location = new System.Drawing.Point(12, 86);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(258, 20);
            this.tbTeacher.TabIndex = 6;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Location = new System.Drawing.Point(9, 70);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(86, 13);
            this.lbTeacher.TabIndex = 5;
            this.lbTeacher.Text = "Преподаватель";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(12, 137);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(258, 20);
            this.tbDay.TabIndex = 8;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(9, 121);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(34, 13);
            this.lbDay.TabIndex = 7;
            this.lbDay.Text = "День";
            // 
            // tbPair
            // 
            this.tbPair.Location = new System.Drawing.Point(12, 190);
            this.tbPair.Name = "tbPair";
            this.tbPair.Size = new System.Drawing.Size(258, 20);
            this.tbPair.TabIndex = 10;
            // 
            // lbPair
            // 
            this.lbPair.AutoSize = true;
            this.lbPair.Location = new System.Drawing.Point(9, 174);
            this.lbPair.Name = "lbPair";
            this.lbPair.Size = new System.Drawing.Size(57, 13);
            this.lbPair.TabIndex = 9;
            this.lbPair.Text = "Пара (1-9)";
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(12, 237);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(258, 20);
            this.tbRoom.TabIndex = 12;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(9, 221);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(60, 13);
            this.lbRoom.TabIndex = 11;
            this.lbRoom.Text = "Аудитория";
            // 
            // InputLessonForm
            // 
            this.AcceptButton = this.btAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 339);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.tbPair);
            this.Controls.Add(this.lbPair);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.btCancel);
            this.Name = "InputLessonForm";
            this.Text = "Фильм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.TextBox tbPair;
        private System.Windows.Forms.Label lbPair;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label lbRoom;
    }
}