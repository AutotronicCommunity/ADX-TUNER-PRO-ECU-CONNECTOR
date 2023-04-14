Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim array As Byte() = New Byte(3) {}
        array = New Byte() {254, 4, 114, 140}
        Dim array2 As Byte() = New Byte(4) {}
        array2 = New Byte() {114, 5, 0, 240, 153}
        If Not SerialPort1.IsOpen Then
            SerialPort1.Open()
        End If
        SerialPort1.BaudRate = 10400
        SerialPort1.BreakState = False
        Thread.Sleep(100)
        SerialPort1.BreakState = True
        Thread.Sleep(70)
        SerialPort1.BreakState = False
        Thread.Sleep(5)
        Thread.Sleep(145)
        SerialPort1.Write(array, 0, array.Length)
        Thread.Sleep(30)
        SerialPort1.Write(array2, 0, array2.Length)
        Thread.Sleep(30)
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Close()
        Thread.Sleep(1000)
    End Sub
End Class
