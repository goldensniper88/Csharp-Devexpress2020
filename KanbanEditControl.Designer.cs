namespace Kanban
{
    partial class KanbanEditControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateDue = new DevExpress.XtraEditors.DateEdit();
            this.spinID = new DevExpress.XtraEditors.SpinEdit();
            this.cmbCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTechnican = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.txtMilestone = new DevExpress.XtraEditors.TextEdit();
            this.txtHeadline = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnican.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMilestone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeadline.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.SetBoundPropertyName(this.layoutControl1, "");
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.dateDue);
            this.layoutControl1.Controls.Add(this.spinID);
            this.layoutControl1.Controls.Add(this.cmbCategory);
            this.layoutControl1.Controls.Add(this.txtTechnican);
            this.layoutControl1.Controls.Add(this.txtCustomer);
            this.layoutControl1.Controls.Add(this.txtMilestone);
            this.layoutControl1.Controls.Add(this.txtHeadline);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(617, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(460, 279);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateEnd
            // 
            this.SetBoundFieldName(this.dateEnd, "EndDate");
            this.SetBoundPropertyName(this.dateEnd, "EditValue");
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(287, 202);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Size = new System.Drawing.Size(161, 20);
            this.dateEnd.StyleController = this.layoutControl1;
            this.dateEnd.TabIndex = 11;
            // 
            // dateDue
            // 
            this.SetBoundFieldName(this.dateDue, "DueDate");
            this.SetBoundPropertyName(this.dateDue, "EditValue");
            this.dateDue.EditValue = null;
            this.dateDue.Location = new System.Drawing.Point(67, 202);
            this.dateDue.Name = "dateDue";
            this.dateDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDue.Properties.ReadOnly = true;
            this.dateDue.Size = new System.Drawing.Size(161, 20);
            this.dateDue.StyleController = this.layoutControl1;
            this.dateDue.TabIndex = 10;
            // 
            // spinID
            // 
            this.SetBoundFieldName(this.spinID, "ID");
            this.SetBoundPropertyName(this.spinID, "EditValue");
            this.spinID.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinID.Location = new System.Drawing.Point(287, 238);
            this.spinID.Name = "spinID";
            this.spinID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinID.Size = new System.Drawing.Size(161, 20);
            this.spinID.StyleController = this.layoutControl1;
            this.spinID.TabIndex = 9;
            // 
            // cmbCategory
            // 
            this.SetBoundFieldName(this.cmbCategory, "Category");
            this.SetBoundPropertyName(this.cmbCategory, "EditValue");
            this.cmbCategory.Location = new System.Drawing.Point(67, 238);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Size = new System.Drawing.Size(161, 20);
            this.cmbCategory.StyleController = this.layoutControl1;
            this.cmbCategory.TabIndex = 8;
            // 
            // txtTechnican
            // 
            this.SetBoundFieldName(this.txtTechnican, "Technican");
            this.SetBoundPropertyName(this.txtTechnican, "EditValue");
            this.txtTechnican.Location = new System.Drawing.Point(12, 166);
            this.txtTechnican.Name = "txtTechnican";
            this.txtTechnican.Size = new System.Drawing.Size(436, 20);
            this.txtTechnican.StyleController = this.layoutControl1;
            this.txtTechnican.TabIndex = 7;
            // 
            // txtCustomer
            // 
            this.SetBoundFieldName(this.txtCustomer, "Customer");
            this.SetBoundPropertyName(this.txtCustomer, "EditValue");
            this.txtCustomer.Location = new System.Drawing.Point(12, 120);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(436, 20);
            this.txtCustomer.StyleController = this.layoutControl1;
            this.txtCustomer.TabIndex = 6;
            // 
            // txtMilestone
            // 
            this.SetBoundFieldName(this.txtMilestone, "Milestone");
            this.SetBoundPropertyName(this.txtMilestone, "EditValue");
            this.txtMilestone.Location = new System.Drawing.Point(12, 74);
            this.txtMilestone.Name = "txtMilestone";
            this.txtMilestone.Size = new System.Drawing.Size(436, 20);
            this.txtMilestone.StyleController = this.layoutControl1;
            this.txtMilestone.TabIndex = 5;
            // 
            // txtHeadline
            // 
            this.SetBoundFieldName(this.txtHeadline, "Headline");
            this.SetBoundPropertyName(this.txtHeadline, "EditValue");
            this.txtHeadline.Location = new System.Drawing.Point(12, 28);
            this.txtHeadline.Name = "txtHeadline";
            this.txtHeadline.Size = new System.Drawing.Size(436, 20);
            this.txtHeadline.StyleController = this.layoutControl1;
            this.txtHeadline.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(460, 279);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtHeadline;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(440, 46);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem1.Text = "Headline:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMilestone;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(440, 46);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem2.Text = "Milestone:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCustomer;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(440, 46);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem3.Text = "Customer:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTechnican;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(440, 46);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem4.Text = "Technican:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spinID;
            this.layoutControlItem6.Location = new System.Drawing.Point(220, 220);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(220, 39);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 6);
            this.layoutControlItem6.Text = "ID:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dateDue;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(220, 36);
            this.layoutControlItem7.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 6);
            this.layoutControlItem7.Text = "Due Date:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.dateEnd;
            this.layoutControlItem8.Location = new System.Drawing.Point(220, 184);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(220, 36);
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 6);
            this.layoutControlItem8.Text = "End Date:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbCategory;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 220);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 39);
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 6);
            this.layoutControlItem5.Text = "Category:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 13);
            // 
            // KanbanEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "KanbanEditControl";
            this.Size = new System.Drawing.Size(460, 279);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnican.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMilestone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeadline.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtHeadline;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtMilestone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtTechnican;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateDue;
        private DevExpress.XtraEditors.SpinEdit spinID;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
