using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraNavBar;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 

	public class Form1 : System.Windows.Forms.Form
	{
        private MyNavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.navBarControl1 = new WindowsApplication1.MyNavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.AllowDrop = true;
            this.navBarControl1.AllowSelectedLink = true;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
                                                                                            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
                                                                                          this.navBarItem1,
                                                                                          this.navBarItem2});
            this.navBarControl1.Location = new System.Drawing.Point(64, 56);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(200, 384);
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
                                                                                                new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
                                                                                                new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SelectedLinkIndex = 1;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 168);
            this.button1.Name = "button1";
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(832, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void Form1_Load(object sender, System.EventArgs e) {
        }

        private void vGridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
        }

        private void schedulerStorage1_FetchAppointments(object sender, DevExpress.XtraScheduler.TimeIntervalEventArgs e) {
        
        }

        private void timer1_Tick(object sender, System.EventArgs e) {
            if (navBarControl1.SelectedLink != null) {
            Text = navBarControl1.SelectedLink.ToString() + " " + navBarControl1.SelectedLink.ItemName;
            }
        }
	}

    public class MyNavBarControl :  NavBarControl {
        
        private NavBarGroup NextGroup(NavBarGroup group, bool forward) {
            if (Groups.Count == 0) //|| (Groups.Count == 1 && group != null)
                return null;
            if (group == null)
                return (forward)?Groups[0]:Groups[Groups.Count - 1];
            
            if (forward) {
                if (Groups.IndexOf(group) < Groups.Count - 1)
                    return Groups[Groups.IndexOf(group) + 1];
                else
                    return Groups[0];
            }
            else if (Groups.IndexOf(group) > 0)
                return Groups[Groups.IndexOf(group) - 1];
            else
                return Groups[Groups.Count - 1];
        }

        private NavBarItemLink FindNearItemLink(bool forward) {
            NavBarItemLink link = SelectedLink;
            NavBarGroup group;
            if (link == null) 
                group = NextGroup(null, forward);
            else
                group = link.Group;
            if (group == null)
                return null;
            NavBarGroup startGroup = group;
            int i;
            if (link != null)
                i = group.ItemLinks.IndexOf(link);
            else
                i = (forward)?-1:group.ItemLinks.Count; 
            bool repeat = false;
            do {
                if (forward) {
                    if (i < group.ItemLinks.Count - 1)
                        return group.ItemLinks[i+1];
                    else {
                        group = NextGroup(group, forward);
                        repeat = i > 0;
                        i = -1;
                    }
                }
                else {
                    if (i > 0 && group.ItemLinks.Count > 0)
                        return group.ItemLinks[i-1];
                    else {
                        group = NextGroup(group, forward);
                        repeat = i < group.ItemLinks.Count - 1;
                        i = group.ItemLinks.Count;
                    }
                }
            }
            while (group != startGroup || repeat);
            return null;
        }

        protected override bool ProcessDialogKey(Keys keyData) {
            Keys key = keyData & (~Keys.Modifiers); 
            switch (key) {
                case Keys.Down:
                    SelectedLink = FindNearItemLink(true);
                    break;
                case Keys.Up:
                    SelectedLink = FindNearItemLink(false);
                    break;
                default:
                    return base.ProcessDialogKey(keyData);
            }
            if (SelectedLink != null && !SelectedLink.Group.Expanded)
                SelectedLink.Group.Expanded = true;
            return false;
        }
    }

}
