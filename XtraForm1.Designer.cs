namespace Kanban
{
    partial class XtraForm1
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
            this.kanbanEditControl1 = new Kanban.KanbanEditControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kanbanEditControl1
            // 
            this.kanbanEditControl1.Location = new System.Drawing.Point(70, 31);
            this.kanbanEditControl1.Name = "kanbanEditControl1";
            this.kanbanEditControl1.Size = new System.Drawing.Size(460, 279);
            this.kanbanEditControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.kanbanEditControl1.SetBoundPropertyName(this.button1, "");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(100, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Input Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.kanbanEditControl1.SetBoundPropertyName(this, "");
            this.ClientSize = new System.Drawing.Size(604, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kanbanEditControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        public KanbanEditControl kanbanEditControl1;
        private System.Windows.Forms.Button button1;
    }
}