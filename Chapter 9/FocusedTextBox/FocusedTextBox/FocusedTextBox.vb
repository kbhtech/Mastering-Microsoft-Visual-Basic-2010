Imports System.ComponentModel
<DefaultProperty("Mandatory")> Public Class FocusedTextBox

    Dim _mandatory As Boolean
    Dim _enterFocusColor, _leaveFocusColor As Color
    Dim _mandatoryColor As Color
    Private _backColor As Color

    <Category("Appearance")> Property Mandatory() As Boolean
        Get
            Mandatory = _mandatory
        End Get
        Set(ByVal value As Boolean)
            _mandatory = value
        End Set
    End Property

    <Description("The control's background color when it has the focus")>
        <Category("Appearance")>
        Property EnterFocusColor() As System.Drawing.Color
        Get
            Return _enterFocusColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _enterFocusColor = value
        End Set
    End Property

    <Description("Indicates whether the control can be left blank")>
        <Category("Appearance"), DefaultValue(False)>
        Property MandatoryColor() As System.Drawing.Color
        Get
            Return _mandatoryColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _mandatoryColor = value
        End Set
    End Property

    Private Sub FocusedTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        _backColor = Me.BackColor
        Me.BackColor = _enterFocusColor
    End Sub

    Private Sub FocusedTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        If Trim(Me.Text).Length = 0 And _mandatory Then
            Me.BackColor = _mandatoryColor
        Else
            Me.BackColor = _backColor
        End If
    End Sub
End Class
