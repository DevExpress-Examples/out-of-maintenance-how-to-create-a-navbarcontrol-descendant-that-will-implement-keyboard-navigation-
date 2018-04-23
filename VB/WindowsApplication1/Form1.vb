Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraNavBar

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	''' 

	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private navBarControl1 As MyNavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private button1 As System.Windows.Forms.Button
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
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
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.AllowDrop = True
			Me.navBarControl1.AllowSelectedLink = True
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2})
			Me.navBarControl1.Location = New System.Drawing.Point(64, 56)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.Size = New System.Drawing.Size(200, 384)
			Me.navBarControl1.TabIndex = 6
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2)})
			Me.navBarGroup1.Name = "navBarGroup1"
			Me.navBarGroup1.SelectedLinkIndex = 1
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
			' timer1
			' 
			Me.timer1.Enabled = True
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(344, 168)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 7
			Me.button1.Text = "button1"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(832, 510)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		End Sub

		Private Sub vGridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
		End Sub

		Private Sub schedulerStorage1_FetchAppointments(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.TimeIntervalEventArgs)

		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
			If navBarControl1.SelectedLink IsNot Nothing Then
			Text = navBarControl1.SelectedLink.ToString() & " " & navBarControl1.SelectedLink.ItemName
			End If
		End Sub
	End Class

	Public Class MyNavBarControl
		Inherits NavBarControl

		Private Function NextGroup(ByVal group As NavBarGroup, ByVal forward As Boolean) As NavBarGroup
			If Groups.Count = 0 Then '|| (Groups.Count == 1 && group != null)
				Return Nothing
			End If
			If group Is Nothing Then
				If (forward) Then
					Return Groups(0)
				Else
					Return Groups(Groups.Count - 1)
				End If
			End If

			If forward Then
				If Groups.IndexOf(group) < Groups.Count - 1 Then
					Return Groups(Groups.IndexOf(group) + 1)
				Else
					Return Groups(0)
				End If
			ElseIf Groups.IndexOf(group) > 0 Then
				Return Groups(Groups.IndexOf(group) - 1)
			Else
				Return Groups(Groups.Count - 1)
			End If
		End Function

		Private Function FindNearItemLink(ByVal forward As Boolean) As NavBarItemLink
			Dim link As NavBarItemLink = SelectedLink
			Dim group As NavBarGroup
			If link Is Nothing Then
				group = NextGroup(Nothing, forward)
			Else
				group = link.Group
			End If
			If group Is Nothing Then
				Return Nothing
			End If
			Dim startGroup As NavBarGroup = group
			Dim i As Integer
			If link IsNot Nothing Then
				i = group.ItemLinks.IndexOf(link)
			Else
				If (forward) Then
					i = -1
				Else
					i = group.ItemLinks.Count
				End If
			End If
			Dim repeat As Boolean = False
			Do
				If forward Then
					If i < group.ItemLinks.Count - 1 Then
						Return group.ItemLinks(i+1)
					Else
						group = NextGroup(group, forward)
						repeat = i > 0
						i = -1
					End If
				Else
					If i > 0 AndAlso group.ItemLinks.Count > 0 Then
						Return group.ItemLinks(i-1)
					Else
						group = NextGroup(group, forward)
						repeat = i < group.ItemLinks.Count - 1
						i = group.ItemLinks.Count
					End If
				End If
			Loop While group IsNot startGroup OrElse repeat
			Return Nothing
		End Function

		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			Dim key As Keys = keyData And ((Not Keys.Modifiers))
			Select Case key
				Case Keys.Down
					SelectedLink = FindNearItemLink(True)
				Case Keys.Up
					SelectedLink = FindNearItemLink(False)
				Case Else
					Return MyBase.ProcessDialogKey(keyData)
			End Select
			If SelectedLink IsNot Nothing AndAlso (Not SelectedLink.Group.Expanded) Then
				SelectedLink.Group.Expanded = True
			End If
			Return False
		End Function
	End Class

End Namespace
