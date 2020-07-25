Public Class Form1
    Dim series As String = Nothing
    Function Sum(ByVal First_Term As Double, ByVal Term_Number As Double, ByVal CommonDifference_Ration As Double, Optional ByVal Arithmetic As Boolean = True, Optional ByVal Inverse As Boolean = False)
        Dim i As Double = 0
        Dim s As Double = 0
        Select Case Inverse
            Case True
                s = First_Term
                For i = First_Term To Term_Number
                    s = s + (1 / i + CommonDifference_Ration)
                Next
                series = First_Term & " + " & (1 / (First_Term + CommonDifference_Ration)) & " + " & (1 / (First_Term + 2 * CommonDifference_Ration)) & " + " & (1 / (First_Term + 3 * CommonDifference_Ration)) & " + ...... + " & (1 / (Term_Number + CommonDifference_Ration))
            Case False
                If Arithmetic = True Then
                    s = (Term_Number / 2) * (2 * First_Term + (Term_Number - 1) * CommonDifference_Ration)
                    series = First_Term & " + " & (First_Term + CommonDifference_Ration) & " + " & (First_Term + 2 * CommonDifference_Ration) & " + " & (First_Term + 3 * CommonDifference_Ration) & " + ...... + " & (First_Term + (Term_Number - 1) * CommonDifference_Ration)
                ElseIf Arithmetic = False Then
                    If CommonDifference_Ration > 1 Then
                        s = First_Term * ((CommonDifference_Ration ^ Term_Number - 1) / (CommonDifference_Ration - 1))
                        series = First_Term & " + " & (First_Term * CommonDifference_Ration) & " + " & (First_Term * CommonDifference_Ration ^ 2) & " + " & (First_Term * CommonDifference_Ration ^ 3) & " + ...... + " & (First_Term * CommonDifference_Ration ^ (Term_Number - 1))
                    ElseIf CommonDifference_Ration < 1 Then
                        If Not Term_Number = Nothing Then
                            s = First_Term * ((1 - CommonDifference_Ration ^ Term_Number) / (1 - CommonDifference_Ration))
                            series = First_Term & " + " & (First_Term * CommonDifference_Ration) & " + " & (First_Term * CommonDifference_Ration ^ 2) & " + " & (First_Term * CommonDifference_Ration ^ 3) & " + ...... + " & (First_Term * CommonDifference_Ration ^ (Term_Number - 1))
                        Else
                            s = First_Term * (1 / (1 - CommonDifference_Ration))
                            series = First_Term & " + " & (First_Term * CommonDifference_Ration) & " + " & (First_Term * CommonDifference_Ration ^ 2) & " + " & (First_Term * CommonDifference_Ration ^ 3) & " + ...... + ∞ "
                        End If
                    End If
                End If
        End Select
        Return s
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSeries.Text = Nothing
        cmbLN.SelectedIndex = 0
    End Sub

    Private Sub chkInverse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInverse.CheckedChanged
        If chkInverse.Checked = True Then
            radGS.Enabled = False
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Dim ft = Val(txtFT.Text)
        Dim lt = Val(txtLN.Text)
        Dim cdr = Val(txtC.Text)
        Dim tn = Nothing
        Dim artc As Boolean
        Dim inv As Boolean
        If radAS.Checked = True Then
            artc = True
        ElseIf radGS.Checked = True Then
            artc = False
        End If
        If chkInverse.Checked = True Then
            inv = True
        ElseIf chkInverse.Checked = False Then
            inv = False
        End If
        Select Case inv
            Case True
                If cmbLN.SelectedIndex = 0 Then
                    tn = lt - cdr
                ElseIf cmbLN.SelectedIndex = 1 Then
                    tn = ft + cdr * (lt - 2)
                End If
            Case False
                If artc = True Then
                    If cmbLN.SelectedIndex = 0 Then
                        tn = ((lt - ft) / cdr) + 1
                    ElseIf cmbLN.SelectedIndex = 1 Then
                        tn = lt
                    End If
                ElseIf artc = False Then
                    If cmbLN.SelectedIndex = 0 Then
                        tn = ((Math.Log(lt / ft)) / (Math.Log(cdr))) + 1
                    ElseIf cmbLN.SelectedIndex = 1 Then
                        tn = lt
                    End If
                End If
        End Select
        Try
            lblResult.Text = Sum(ft, tn, cdr, artc, inv)
            lblSeries.Text = series & "  = "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
End Class
