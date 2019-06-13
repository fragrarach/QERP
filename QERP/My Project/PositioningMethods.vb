Module PositioningMethods
    Public Function CenterToCenter(ByRef ChildForm As Form, ByRef ParentForm As Form)
        Dim X As Int16 = ParentForm.Location.X + (ParentForm.Width - ChildForm.Width) / 2
        Dim Y As Int16 = ParentForm.Location.Y + (ParentForm.Height - ChildForm.Height) / 2
        Dim ChildLocation As New Point(X, Y)
        Return ChildLocation
    End Function
    Public Function MdiCenter(ByRef ChildForm As Form, ByRef ParentForm As Form)
        Dim X As Int16 = (ParentForm.Width - ChildForm.Width) / 2
        Dim Y As Int16 = (ParentForm.Height - ChildForm.Height) / 2
        Dim ChildLocation As New Point(X, Y)
        Return ChildLocation
    End Function
End Module
