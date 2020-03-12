using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kanban
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        
        public String Headline { get { return kanbanEditControl1.Headline; } }
        public String Milestone { get { return kanbanEditControl1.Milestone; } }
        public String Customer { get { return kanbanEditControl1.Customer; } }
        public String Technican { get { return kanbanEditControl1.Technican; } }
        public DateTime DueDate { get { return kanbanEditControl1.DueDate; } }
        public DateTime EndDate { get { return kanbanEditControl1.EndDate; } }

        public int ID { get { return kanbanEditControl1.ID; } }
        public string Category { get { return kanbanEditControl1.Category; } }




    }
}