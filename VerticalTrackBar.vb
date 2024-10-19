Imports System.Drawing
Imports System.Windows.Forms

Public Class VerticalTrackBar
    Inherits Control

    Private _value As Integer
    Private _minimum As Integer = 0
    Private _maximum As Integer = 100
    Private _tickFrequency As Integer = 10

    Public Property Value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            If value < _minimum Then value = _minimum
            If value > _maximum Then value = _maximum
            _value = value
            Invalidate() ' Redibuja el control
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return _minimum
        End Get
        Set(value As Integer)
            _minimum = value
            If _value < _minimum Then _value = _minimum
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return _maximum
        End Get
        Set(value As Integer)
            _maximum = value
            If _value > _maximum Then _value = _maximum
            Invalidate()
        End Set
    End Property

    Public Property TickFrequency As Integer
        Get
            Return _tickFrequency
        End Get
        Set(value As Integer)
            _tickFrequency = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        Dim trackBarHeight As Integer = Height - 20
        Dim trackBarWidth As Integer = 10

        ' Draw TrackBar background
        g.FillRectangle(Brushes.LightGray, 0, 10, trackBarWidth, trackBarHeight)

        ' Draw the slider
        Dim sliderY As Integer = trackBarHeight - ((Value - Minimum) / (Maximum - Minimum) * trackBarHeight)
        g.FillRectangle(Brushes.Blue, 0, sliderY + 10, trackBarWidth, 10)

        ' Draw ticks
        For i As Integer = Minimum To Maximum Step TickFrequency
            Dim tickY As Integer = trackBarHeight - ((i - Minimum) / (Maximum - Minimum) * trackBarHeight)
            g.DrawLine(Pens.Black, 0, tickY + 10, trackBarWidth, tickY + 10)
        Next

        ' Draw value
        g.DrawString(Value.ToString(), Font, Brushes.Black, 0, 0)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        UpdateValueFromMouse(e.Y)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If e.Button = MouseButtons.Left Then
            UpdateValueFromMouse(e.Y)
        End If
    End Sub

    Private Sub UpdateValueFromMouse(mouseY As Integer)
        Dim trackBarHeight As Integer = Height - 20
        Dim newValue As Integer = Maximum - ((mouseY - 10) / trackBarHeight * (Maximum - Minimum))
        Value = newValue
    End Sub
End Class
