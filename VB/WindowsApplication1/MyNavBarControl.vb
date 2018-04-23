Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraNavBar

Namespace WindowsApplication1
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
						Return group.ItemLinks(i + 1)
					Else
						group = NextGroup(group, forward)
						repeat = i > 0
						i = -1
					End If
				Else
					If i > 0 AndAlso group.ItemLinks.Count > 0 Then
						Return group.ItemLinks(i - 1)
					Else
						group = NextGroup(group, forward)
						repeat = i < group.ItemLinks.Count - 1
						i = group.ItemLinks.Count
					End If
				End If
			Loop While group IsNot startGroup OrElse repeat
			Return Nothing
		End Function

		Public Sub SelectNextLink(ByVal forward As Boolean)
			SelectedLink = FindNearItemLink(forward)
			If SelectedLink IsNot Nothing AndAlso (Not SelectedLink.Group.Expanded) Then
				SelectedLink.Group.Expanded = True
			End If
			ViewInfo.MakeLinkVisible(SelectedLink)
		End Sub

		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			Dim key As Keys = keyData And ((Not Keys.Modifiers))
			Select Case key
				Case Keys.Down
					SelectNextLink(True)
				Case Keys.Up
					SelectNextLink(False)
				Case Else
					Return MyBase.ProcessDialogKey(keyData)
			End Select
			Return False
		End Function
	End Class
End Namespace
