using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace FormatProgressBarText {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CreateNodes(treeList1);
            repositoryItemProgressBar1.ShowTitle = true;

            columnProgress.AppearanceCell.Font = new Font(treeList1.ViewInfo.PaintAppearance.Row.Font, FontStyle.Bold);
            columnProgress.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
        }

        private void CreateNodes(DevExpress.XtraTreeList.TreeList tl) {
            tl.BeginUnboundLoad();
            for(int i = 0; i < 10; i++)
                tl.AppendNode(new object[] { "Item" + i, i * 10 }, -1, 0, 0, -1);
            tl.EndUnboundLoad();
        }

        private void repositoryItemProgressBar1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e) {
            string val = e.Value.ToString();
            e.DisplayText = "The progress is: " + val;
        }
    }
}