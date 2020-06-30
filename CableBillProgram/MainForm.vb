Option Explicit On

Public Class mainForm
    Dim isResidential As Boolean = False
    Dim isBuisness As Boolean = False
    Dim premChannels(6) As Double

    Private Sub TxtConnections_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConnections.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub overLimit_TextChange(sender As Object, e As EventArgs) Handles txtConnections.TextChanged
        Dim result As DialogResult
        Dim input As Integer

        Integer.TryParse(txtConnections.Text, input)

        If (input > 10) AndAlso rdoResident.Checked = True Then
            result = MessageBox.Show("Residential may not have more than 10 connections." & Chr(10) & "If you wish to have 11 or more, you must become a Buisness Account." & Chr(10) & "Would you like to become a Buisness Account?", "WARNING: Accounts Exceeded", MessageBoxButtons.YesNo)
        End If

        Select Case result
            Case vbYes
                rdoResident.Checked = False
                rdoBuisness.Checked = True
            Case vbNo
                txtConnections.Clear()
                txtConnections.Focus()
        End Select
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If rdoResident.Checked Then
            calcResidential(premChannels)
        ElseIf rdoBuisness.Checked Then
            calcBuisness(premChannels)
        Else
            MessageBox.Show("No radio button selected!", "ALERT!", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub calcResidential(ByRef premChannels)
        Dim connections As Integer = 0
        Dim total As Double = 0.00

        Integer.TryParse(txtConnections.Text, connections)

        For i As Integer = 0 To Me.chklstPremChan.Items.Count - 1
            If Me.chklstPremChan.GetItemChecked(i) Then
                total += premChannels(i)
            End If
        Next i

        total += 34.5

        lblTotal.Text = "$" + total.ToString("N2")

        txtConnections.SelectAll()
        txtConnections.Focus()
    End Sub

    Private Sub calcBuisness(ByRef premChannels)
        Dim connections As Integer = 0
        Dim total As Double = 0.00

        Integer.TryParse(txtConnections.Text, connections)

        For i As Integer = 0 To Me.chklstPremChan.Items.Count - 1
            If Me.chklstPremChan.GetItemChecked(i) Then
                total += premChannels(i)
            End If
        Next i

        If connections <= 10 Then
            total += 96.5
        Else
            total += (96.5 + ((connections - 10) * 4.0))
        End If

        lblTotal.Text = "$" + total.ToString("N2")

        txtConnections.SelectAll()
        txtConnections.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub RdoBuisness_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBuisness.CheckedChanged
        lstPremPrice.Items.Clear()

        premChannels(0) = 100.0
        premChannels(1) = 100.0
        premChannels(2) = 100.0
        premChannels(3) = 100.0
        premChannels(4) = 50.0
        premChannels(5) = 25.0
        premChannels(6) = 15.0

        For i As Integer = 0 To premChannels.Count - 1
            lstPremPrice.Items.Add("$" + premChannels(i).ToString("N2"))
        Next

        lblTotal.Text = ""
        txtConnections.Clear()
        txtConnections.Focus()
    End Sub

    Private Sub RdoResident_CheckedChanged(sender As Object, e As EventArgs) Handles rdoResident.CheckedChanged
        lstPremPrice.Items.Clear()

        premChannels(0) = 10.0
        premChannels(1) = 10.0
        premChannels(2) = 10.0
        premChannels(3) = 10.0
        premChannels(4) = 7.0
        premChannels(5) = 5.0
        premChannels(6) = 3.0

        For i As Integer = 0 To premChannels.Count - 1
            lstPremPrice.Items.Add("$" + premChannels(i).ToString("N2"))
        Next

        lblTotal.Text = ""
        txtConnections.Clear()
        txtConnections.Focus()
    End Sub


End Class
