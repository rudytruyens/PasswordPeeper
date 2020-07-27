
Public Class PasswordPeeper
    Private Declare Function WindowFromPoint Lib "user32" (ByVal p As Point) As IntPtr
    Private Declare Function SendMessageByString Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_GETTEXT As Integer = &HD
    Private Const WM_GETTEXTLENGTH As Integer = &HE
    Dim textlength As Integer
    Private Buffer As String
    Private currwinhandle As Integer = 0
    Private prevwinhandle As Integer = 0
    Private p As System.Drawing.Point
    Private Sub tmrCheckMouse_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCheckMouse.Tick
        lbl_mouse.Text = "Position: " + System.Windows.Forms.Control.MousePosition().ToString()
        p = New System.Drawing.Point(System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y)
        currwinhandle = WindowFromPoint(p)
        lbl_handle.Text = "Window handle: " + currwinhandle.ToString
        If currwinhandle <> prevwinhandle Then
            textlength = SendMessage(currwinhandle, WM_GETTEXTLENGTH, 0, 0) + 1
            Buffer = New String(" "c, textlength)
            SendMessageByString(currwinhandle, WM_GETTEXT, textlength, Buffer)
            lbl_text.Text = "Control text: " + Buffer
            prevwinhandle = currwinhandle
        End If

    End Sub
End Class
