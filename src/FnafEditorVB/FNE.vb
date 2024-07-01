Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO

Public Class FNE
    Dim ininininininini As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MMFApplications", "freddy")
    Dim MyDickIsSmol As String = "freddy"
    Dim btn2 As Boolean = False
    Dim btn3 As Boolean = False
    Dim btn4 As Boolean = False

    Private Sub FNE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim keyName As String = "level"
        Dim value As String = ReadIniValue(ininininininini, MyDickIsSmol, keyName)
        NumericUpDown1.Value = Convert.ToDecimal(value)
        Dim keyName2 As String = "beatgame"
        Dim value2 As String = ReadIniValue(ininininininini, MyDickIsSmol, keyName2)

        If value2 = "1" Then
            Button2.Text = "Yes"
            btn2 = True
        End If

        Dim keyName3 As String = "beat6"
        Dim value3 As String = ReadIniValue(ininininininini, MyDickIsSmol, keyName3)

        If value3 = "1" Then
            Button3.Text = "Yes"
            btn3 = True
        End If

        Dim keyName4 As String = "beat7"
        Dim value4 As String = ReadIniValue(ininininininini, MyDickIsSmol, keyName4)

        If value4 = "1" Then
            Button4.Text = "Yes"
            btn4 = True
        End If
    End Sub

    Private Shared Function ReadIniValue(ByVal filePath As String, ByVal section As String, ByVal key As String) As String
        Try
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim currentSection As String = Nothing

            For Each line As String In lines
                Dim trimmedLine As String = line.Trim()
                If String.IsNullOrEmpty(trimmedLine) OrElse trimmedLine.StartsWith(";"c) Then Continue For

                If trimmedLine.StartsWith("["c) AndAlso trimmedLine.EndsWith("]"c) Then
                    currentSection = trimmedLine.Substring(1, trimmedLine.Length - 2)
                Else
                    Dim parts As String() = trimmedLine.Split("="c)

                    If parts.Length = 2 Then
                        Dim keyInFile As String = parts(0).Trim()
                        Dim valueInFile As String = parts(1).Trim()

                        If currentSection = section AndAlso keyInFile = key Then
                            Return valueInFile
                        End If
                    End If
                End If
            Next

            Return Nothing
        Catch ex As Exception
            MessageBox.Show("You don't even have FNAF installed! XD", "Error")
            FNE.Close()
            Return Nothing
        End Try
    End Function

    Private Shared Sub ModifyIniValue(ByVal filePath As String, ByVal section As String, ByVal key As String, ByVal newValue As String)
        Try
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim currentSection As String = Nothing

            For i As Integer = 0 To lines.Length - 1
                Dim line As String = lines(i).Trim()
                If String.IsNullOrEmpty(line) OrElse line.StartsWith(";"c) Then Continue For

                If line.StartsWith("["c) AndAlso line.EndsWith("]"c) Then
                    currentSection = line.Substring(1, line.Length - 2)
                Else
                    Dim parts As String() = line.Split("="c)

                    If parts.Length = 2 Then
                        Dim keyInFile As String = parts(0).Trim()

                        If currentSection = section AndAlso keyInFile = key Then
                            lines(i) = $"{key}={newValue}"
                        End If
                    End If
                End If
            Next

            File.WriteAllLines(filePath, lines)
        Catch ex As Exception
            Console.WriteLine($"Error modifying value: {ex.Message}")
        End Try
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        ModifyIniValue(ininininininini, MyDickIsSmol, "level", NumericUpDown1.Value.ToString())
        If btn2 Then
            ModifyIniValue(ininininininini, MyDickIsSmol, "beatgame", 1)
        Else
            ModifyIniValue(ininininininini, MyDickIsSmol, "beatgame", 0)
        End If
        If btn3 Then
            ModifyIniValue(ininininininini, MyDickIsSmol, "beat6", 1)
        Else
            ModifyIniValue(ininininininini, MyDickIsSmol, "beat6", 0)
        End If
        If btn4 Then
            ModifyIniValue(ininininininini, MyDickIsSmol, "beat7", 1)
        Else
            ModifyIniValue(ininininininini, MyDickIsSmol, "beat7", 0)
        End If
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text Is "Yes" Then
            Button2.Text = "No"
            btn2 = False
        Else
            Button2.Text = "Yes"
            btn2 = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text Is "Yes" Then
            Button3.Text = "No"
            btn3 = False
        Else
            Button3.Text = "Yes"
            btn3 = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text Is "Yes" Then
            Button4.Text = "No"
            btn4 = False
        Else
            Button4.Text = "Yes"
            btn4 = True
        End If
    End Sub
End Class