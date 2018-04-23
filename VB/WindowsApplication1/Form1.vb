Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	''' 

	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents navBarControl1 As MyNavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As NavBarItem
		Private navBarGroup2 As NavBarGroup
		Private navBarItem6 As NavBarItem
		Private navBarItem5 As NavBarItem
		Private navBarGroup3 As NavBarGroup
		Private navBarGroup4 As NavBarGroup
		Private navBarItem9 As NavBarItem
		Private navBarItem7 As NavBarItem
		Private navBarGroup5 As NavBarGroup
		Private navBarItem11 As NavBarItem
		Private navBarItem8 As NavBarItem
		Private navBarGroup6 As NavBarGroup
		Private navBarItem14 As NavBarItem
		Private navBarItem12 As NavBarItem
		Private navBarItem13 As NavBarItem
		Private navBarItem15 As NavBarItem
		Private navBarItem17 As NavBarItem
		Private navBarItem16 As NavBarItem
		Private navBarItem10 As NavBarItem
		Private navBarGroup7 As NavBarGroup
		Private navBarGroup8 As NavBarGroup
		Private navBarGroup9 As NavBarGroup
		Private navBarItem19 As NavBarItem
		Private navBarItem18 As NavBarItem
		Private navBarItem3 As NavBarItem
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.navBarControl1 = New WindowsApplication1.MyNavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem14 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem12 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem13 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem15 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem17 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem16 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup9 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem19 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem18 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.AllowSelectedLink = True
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3, Me.navBarGroup4, Me.navBarGroup5, Me.navBarGroup6, Me.navBarGroup7, Me.navBarGroup8, Me.navBarGroup9})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7, Me.navBarItem8, Me.navBarItem9, Me.navBarItem10, Me.navBarItem11, Me.navBarItem12, Me.navBarItem13, Me.navBarItem14, Me.navBarItem15, Me.navBarItem16, Me.navBarItem17, Me.navBarItem18, Me.navBarItem19})
			Me.navBarControl1.Location = New System.Drawing.Point(64, 56)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 200
			Me.navBarControl1.Size = New System.Drawing.Size(200, 384)
			Me.navBarControl1.TabIndex = 6
			Me.navBarControl1.Text = "navBarControl1"
'			Me.navBarControl1.CustomDrawLink += New DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(Me.navBarControl1_CustomDrawLink);
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "navBarItem4"
			Me.navBarItem4.Name = "navBarItem4"
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "navBarItem1"
			Me.navBarItem1.Name = "navBarItem1"
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "navBarItem2"
			Me.navBarItem2.Name = "navBarItem2"
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "navBarGroup2"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "navBarItem6"
			Me.navBarItem6.Name = "navBarItem6"
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "navBarItem5"
			Me.navBarItem5.Name = "navBarItem5"
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "navBarGroup3"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6)})
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' navBarGroup4
			' 
			Me.navBarGroup4.Caption = "navBarGroup4"
			Me.navBarGroup4.Expanded = True
			Me.navBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem9), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
			Me.navBarGroup4.Name = "navBarGroup4"
			' 
			' navBarItem9
			' 
			Me.navBarItem9.Caption = "navBarItem9"
			Me.navBarItem9.Name = "navBarItem9"
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "navBarItem7"
			Me.navBarItem7.Name = "navBarItem7"
			' 
			' navBarGroup5
			' 
			Me.navBarGroup5.Caption = "navBarGroup5"
			Me.navBarGroup5.Expanded = True
			Me.navBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem11), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem8)})
			Me.navBarGroup5.Name = "navBarGroup5"
			' 
			' navBarItem11
			' 
			Me.navBarItem11.Caption = "navBarItem11"
			Me.navBarItem11.Name = "navBarItem11"
			' 
			' navBarItem8
			' 
			Me.navBarItem8.Caption = "navBarItem8"
			Me.navBarItem8.Name = "navBarItem8"
			' 
			' navBarGroup6
			' 
			Me.navBarGroup6.Caption = "navBarGroup6"
			Me.navBarGroup6.Expanded = True
			Me.navBarGroup6.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem14), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem12), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem13), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem15), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem15), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem17), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem15), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem17), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem15), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem13), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem10)})
			Me.navBarGroup6.Name = "navBarGroup6"
			Me.navBarGroup6.SelectedLinkIndex = 0
			' 
			' navBarItem14
			' 
			Me.navBarItem14.Caption = "navBarItem14"
			Me.navBarItem14.Name = "navBarItem14"
			' 
			' navBarItem12
			' 
			Me.navBarItem12.Caption = "navBarItem12"
			Me.navBarItem12.Name = "navBarItem12"
			' 
			' navBarItem13
			' 
			Me.navBarItem13.Caption = "navBarItem13"
			Me.navBarItem13.Name = "navBarItem13"
			' 
			' navBarItem15
			' 
			Me.navBarItem15.Caption = "navBarItem15"
			Me.navBarItem15.Name = "navBarItem15"
			' 
			' navBarItem17
			' 
			Me.navBarItem17.Caption = "navBarItem17"
			Me.navBarItem17.Name = "navBarItem17"
			' 
			' navBarItem16
			' 
			Me.navBarItem16.Caption = "navBarItem16"
			Me.navBarItem16.Name = "navBarItem16"
			' 
			' navBarItem10
			' 
			Me.navBarItem10.Caption = "navBarItem10"
			Me.navBarItem10.Name = "navBarItem10"
			' 
			' navBarGroup7
			' 
			Me.navBarGroup7.Caption = "navBarGroup7"
			Me.navBarGroup7.Expanded = True
			Me.navBarGroup7.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem13)})
			Me.navBarGroup7.Name = "navBarGroup7"
			' 
			' navBarGroup8
			' 
			Me.navBarGroup8.Caption = "navBarGroup8"
			Me.navBarGroup8.Expanded = True
			Me.navBarGroup8.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem17), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16)})
			Me.navBarGroup8.Name = "navBarGroup8"
			' 
			' navBarGroup9
			' 
			Me.navBarGroup9.Caption = "navBarGroup9"
			Me.navBarGroup9.Expanded = True
			Me.navBarGroup9.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem19), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem18), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem17)})
			Me.navBarGroup9.Name = "navBarGroup9"
			' 
			' navBarItem19
			' 
			Me.navBarItem19.Caption = "navBarItem19"
			Me.navBarItem19.Name = "navBarItem19"
			' 
			' navBarItem18
			' 
			Me.navBarItem18.Caption = "navBarItem18"
			Me.navBarItem18.Name = "navBarItem18"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "navBarItem3"
			Me.navBarItem3.Name = "navBarItem3"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(832, 510)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub


		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
			If navBarControl1.SelectedLink IsNot Nothing Then
				Text = String.Format("{0} {1}", navBarControl1.SelectedLink, navBarControl1.SelectedLink.ItemName)
			End If
		End Sub

		Private Sub navBarControl1_CustomDrawLink(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs) Handles navBarControl1.CustomDrawLink
			Dim args As NavLinkInfoArgs = TryCast(e.ObjectInfo, NavLinkInfoArgs)
			If args.Link Is navBarControl1.SelectedLink Then
				e.Graphics.FillRectangle(Brushes.Red, e.RealBounds)
			End If
		End Sub
	End Class

End Namespace
