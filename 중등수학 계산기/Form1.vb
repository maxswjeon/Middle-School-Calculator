Public Class Form1
    Dim var(0 To 99) As Double
    Dim j_for_도수분포표 As Byte
    Dim k_for_도수분포표 As Byte
    Dim num As Byte = 1
    Dim a As String
    Dim PrimeNum As Byte = 1
    Dim functions As Functions = New Functions
    Private Sub Index_Click(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles Index.NodeMouseClick
        If (e.Node.Name = "1_1_1_1") Then
        ElseIf (e.Node.Name = "1_1_1_2") Then
            PrimeGroupBox.Hide()
            PrimeNumbersGroupBox.Hide()
            FrequencyGroupBox.Hide()
            LCMGroupBox.Hide()
            GCM_GroupBox.Hide()
            PrimeNumbersGroupBox.Show()
        ElseIf (e.Node.Name = "1_1_1_3") Then
            PrimeGroupBox.Hide()
            PrimeNumbersGroupBox.Hide()
            LCMGroupBox.Hide()
            GCM_GroupBox.Hide()
            FrequencyGroupBox.Hide()
            PrimeGroupBox.Show()
        ElseIf (e.Node.Name = "1_1_2_1") Then
            PrimeGroupBox.Hide()
            PrimeNumbersGroupBox.Hide()
            FrequencyGroupBox.Hide()
            LCMGroupBox.Hide()
            GCM_GroupBox.Hide()
            GCM_GroupBox.Show()
        ElseIf (e.Node.Name = "1_1_2_2") Then
            PrimeGroupBox.Hide()
            PrimeNumbersGroupBox.Hide()
            LCMGroupBox.Hide()
            GCM_GroupBox.Hide()
            FrequencyGroupBox.Hide()
            LCMGroupBox.Show()
        ElseIf (e.Node.Name = "1_2_1_1") Then
        ElseIf (e.Node.Name = "1_2_1_2") Then
        ElseIf (e.Node.Name = "1_2_1_3") Then
        ElseIf (e.Node.Name = "1_2_2_1") Then
        ElseIf (e.Node.Name = "1_2_2_2") Then
        ElseIf (e.Node.Name = "18") Then
            PrimeGroupBox.Hide()
            PrimeNumbersGroupBox.Hide()
            LCMGroupBox.Hide()
            GCM_GroupBox.Hide()
            FrequencyGroupBox.Show()
        End If
    End Sub
    Private Sub PrimeButton_Click(sender As System.Object, e As System.EventArgs) Handles PrimeButton.Click '소인수분해
        functions.소인수분해(PrimeTextBox, PrimeAnswer)
    End Sub
    Private Sub PrimeNumbersButton_Click(sender As System.Object, e As System.EventArgs) Handles PrimeNumbersButton.Click
        If PrimeNumbersTextBox.Text = "" Then
            MsgBox("텍스트박스에 값을 입력하세요", vbInformation, "오류")
            Exit Sub
        End If
        Dim a, b, i As Integer
        a = PrimeNumbersTextBox.Text
        b = 0
        For i = 1 To a
            If a Mod i = 0 Then
                Label1.Text = i
                b = b + 1
            End If
        Next i
        MsgBox(PrimeNumbersTextBox.Text & "의 약수의 개수는 " & b & "개 입니다")
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles LCMButton.Click
        If LCMTextbox2.Text = "" Or LCMTextbox1.Text = "" Then
            MsgBox("텍스트박스에 값을 입력하세요", vbInformation, "오류")
            Exit Sub
        End If
        Dim num1 As Integer
        Dim num2 As Integer
        Dim result As Double
        num1 = LCMTextbox1.Text
        num2 = LCMTextbox2.Text
        result = LCM(num1, num2)
        MsgBox(LCMTextbox1.Text & "와 " & LCMTextbox2.Text & "의 최소공배수는" & result.ToString & "입니다")
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("텍스트박스에 값을 입력하세요", vbInformation, "오류")
            Exit Sub
        End If
        Dim Num1, Num2, GCD As Integer
        Num1 = TextBox5.Text
        Num2 = TextBox6.Text
        For i = 1 To Num1
            If Num1 Mod i = 0 And Num2 Mod i = 0 Then
                GCD = i
            End If
        Next
        MsgBox(TextBox5.Text & "와 " & TextBox6.Text & "의 최대공약수는 " & GCD & "입니다")
    End Sub
    Private Sub AddData_Click(sender As System.Object, e As System.EventArgs) Handles FrequencyAddData.Click, Button4.Click
        var(j_for_도수분포표) = InputBox(j_for_도수분포표 + 1 & "번째 데이터를 입력하십시오", "데이터 입력")
        j_for_도수분포표 = j_for_도수분포표 + 1
        If j_for_도수분포표 > 99 Then
            FrequencyAddData.Enabled = False
        End If
        FrequencyData1.Text = vbNullString
        For Me.k_for_도수분포표 = 1 To j_for_도수분포표
            FrequencyData1.Text = FrequencyData1.Text & var(k_for_도수분포표 - 1) & "       "
        Next
        FrequencyMake.Enabled = True
    End Sub
    Private Sub Reset_Click(sender As System.Object, e As System.EventArgs) Handles FrequencyReset.Click, StemAndLeafReset.Click
        Dim k_for_도수분포표 As Byte
        For i_for_도수분포표 As Byte = 0 To 99
            var(i_for_도수분포표) = 0
            i_for_도수분포표 = i_for_도수분포표 + 1
        Next
        FrequencyData1.Text = vbNullString
        j_for_도수분포표 = 0
        k_for_도수분포표 = 0
        num = 1
        textbox2_1.Hide()
        textbox2_2.Hide()
        Label2_1.Hide()
        Label2_2.Hide()
        Label2_3.Hide()
        answer2.Hide()
        textbox3_1.Hide()
        textbox3_2.Hide()
        Label3_1.Hide()
        Label3_2.Hide()
        Label3_3.Hide()
        answer3.Hide()
        textbox4_1.Hide()
        textbox4_2.Hide()
        Label4_1.Hide()
        Label4_2.Hide()
        Label4_3.Hide()
        answer4.Hide()
        textbox5_1.Hide()
        textbox5_2.Hide()
        Label5_1.Hide()
        Label5_2.Hide()
        Label5_3.Hide()
        answer5.Hide()
        textbox6_1.Hide()
        textbox6_2.Hide()
        Label6_1.Hide()
        Label6_2.Hide()
        Label6_3.Hide()
        answer6.Hide()
        textbox7_1.Hide()
        textbox7_2.Hide()
        Label7_1.Hide()
        Label7_2.Hide()
        Label7_3.Hide()
        answer7.Hide()
        textbox8_1.Hide()
        textbox8_2.Hide()
        Label8_1.Hide()
        Label8_2.Hide()
        Label8_3.Hide()
        answer8.Hide()
        textbox9_1.Hide()
        textbox9_2.Hide()
        Label9_1.Hide()
        Label9_2.Hide()
        Label9_3.Hide()
        answer9.Hide()
        textbox10_1.Hide()
        textbox10_2.Hide()
        Label10_1.Hide()
        Label10_2.Hide()
        Label10_3.Hide()
        answer10.Hide()
        textbox11_1.Hide()
        textbox11_2.Hide()
        Label11_1.Hide()
        Label11_2.Hide()
        Label11_3.Hide()
        answer11.Hide()
        textbox12_1.Hide()
        textbox12_2.Hide()
        Label12_1.Hide()
        Label12_2.Hide()
        Label12_3.Hide()
        answer12.Hide()
        textbox13_1.Hide()
        textbox13_2.Hide()
        Label13_1.Hide()
        Label13_2.Hide()
        Label13_3.Hide()
        answer13.Hide()
        textbox14_1.Hide()
        textbox14_2.Hide()
        Label14_1.Hide()
        Label14_2.Hide()
        Label14_3.Hide()
        answer14.Hide()
        FrequencySettings.Enabled = True
        FrequencyAddData.Enabled = True
        textbox2_1.Text = vbNullString
        textbox2_2.Text = vbNullString
        Label2_1.Text = vbNullString
        Label2_2.Text = vbNullString
        Label2_3.Text = vbNullString
        answer2.Text = vbNullString
        textbox3_1.Text = vbNullString
        textbox3_2.Text = vbNullString
        Label3_1.Text = vbNullString
        Label3_2.Text = vbNullString
        Label3_3.Text = vbNullString
        answer3.Text = vbNullString
        textbox4_1.Text = vbNullString
        textbox4_2.Text = vbNullString
        Label4_1.Text = vbNullString
        Label4_2.Text = vbNullString
        Label4_3.Text = vbNullString
        answer4.Text = vbNullString
        textbox5_1.Text = vbNullString
        textbox5_2.Text = vbNullString
        Label5_1.Text = vbNullString
        Label5_2.Text = vbNullString
        Label5_3.Text = vbNullString
        answer5.Text = vbNullString
        textbox6_1.Text = vbNullString
        textbox6_2.Text = vbNullString
        Label6_1.Text = vbNullString
        Label6_2.Text = vbNullString
        Label6_3.Text = vbNullString
        answer6.Text = vbNullString
        textbox7_1.Text = vbNullString
        textbox7_2.Text = vbNullString
        Label7_1.Text = vbNullString
        Label7_2.Text = vbNullString
        Label7_3.Text = vbNullString
        answer7.Text = vbNullString
        textbox8_1.Text = vbNullString
        textbox8_2.Text = vbNullString
        Label8_1.Text = vbNullString
        Label8_2.Text = vbNullString
        Label8_3.Text = vbNullString
        answer8.Text = vbNullString
        textbox9_1.Text = vbNullString
        textbox9_2.Text = vbNullString
        Label9_1.Text = vbNullString
        Label9_2.Text = vbNullString
        Label9_3.Text = vbNullString
        answer9.Text = vbNullString
        textbox10_1.Text = vbNullString
        textbox10_2.Text = vbNullString
        Label10_1.Text = vbNullString
        Label10_2.Text = vbNullString
        Label10_3.Text = vbNullString
        answer10.Text = vbNullString
        textbox11_1.Text = vbNullString
        textbox11_2.Text = vbNullString
        Label11_1.Text = vbNullString
        Label11_2.Text = vbNullString
        Label11_3.Text = vbNullString
        answer11.Text = vbNullString
        textbox12_1.Text = vbNullString
        textbox12_2.Text = vbNullString
        Label12_1.Text = vbNullString
        Label12_2.Text = vbNullString
        Label12_3.Text = vbNullString
        answer12.Text = vbNullString
        textbox13_1.Text = vbNullString
        textbox13_2.Text = vbNullString
        Label13_1.Text = vbNullString
        Label13_2.Text = vbNullString
        Label13_3.Text = vbNullString
        answer13.Text = vbNullString
        textbox14_1.Text = vbNullString
        textbox14_2.Text = vbNullString
        Label14_1.Text = vbNullString
        Label14_2.Text = vbNullString
        Label14_3.Text = vbNullString
        answer14.Text = vbNullString
    End Sub
    Private Sub Make_Click(sender As System.Object, e As System.EventArgs) Handles FrequencyMake.Click, StemAndLeafMake.Click
        Select Case num
            Case 1
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 2
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 3
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 4
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 5
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 6
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 7
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 8
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 9
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 10
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 11
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 12
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 13
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox13_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox13_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
            Case 14
                If textbox1_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox1_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox2_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox3_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox4_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox5_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox6_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox7_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox8_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox9_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox10_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox11_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox12_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox13_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox13_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox14_1.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                ElseIf textbox14_2.Text = vbNullString Then
                    MsgBox("분류기준에 빈칸이 있습니다", vbExclamation, "오류")
                    Exit Sub
                Else

                End If
        End Select
        Dim i As Byte = 0
        If i = 0 Then
            answer1.Text = 0
            answer2.Text = 0
            answer3.Text = 0
            answer4.Text = 0
            answer5.Text = 0
            answer6.Text = 0
            answer7.Text = 0
            answer8.Text = 0
            answer9.Text = 0
            answer10.Text = 0
            answer11.Text = 0
            answer12.Text = 0
            answer13.Text = 0
            answer14.Text = 0
            i = i + 1
        End If
        For Me.k_for_도수분포표 = 0 To k_for_도수분포표
            Select Case num
                Case 1
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    Else
                    End If
                Case 2
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    Else
                    End If
                Case 3
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    Else
                    End If
                Case 4
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    Else
                    End If
                Case 5
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    Else
                    End If
                Case 6
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    Else
                    End If
                Case 7
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    Else
                    End If
                Case 8
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    Else
                    End If
                Case 9
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    Else
                    End If
                Case 10
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox10_1.Text And var(k_for_도수분포표) < textbox10_2.Text Then
                        answer10.Text = answer10.Text + 1
                    Else
                    End If
                Case 11
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox10_1.Text And var(k_for_도수분포표) < textbox10_2.Text Then
                        answer10.Text = answer10.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox11_1.Text And var(k_for_도수분포표) < textbox11_2.Text Then
                        answer11.Text = answer11.Text + 1
                    Else
                    End If
                Case 12
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox10_1.Text And var(k_for_도수분포표) < textbox10_2.Text Then
                        answer10.Text = answer10.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox11_1.Text And var(k_for_도수분포표) < textbox11_2.Text Then
                        answer11.Text = answer11.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox12_1.Text And var(k_for_도수분포표) < textbox12_2.Text Then
                        answer12.Text = answer12.Text + 1
                    Else
                    End If
                Case 13
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox10_1.Text And var(k_for_도수분포표) < textbox10_2.Text Then
                        answer10.Text = answer10.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox11_1.Text And var(k_for_도수분포표) < textbox11_2.Text Then
                        answer11.Text = answer11.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox12_1.Text And var(k_for_도수분포표) < textbox12_2.Text Then
                        answer12.Text = answer12.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox13_1.Text And var(k_for_도수분포표) < textbox13_2.Text Then
                        answer13.Text = answer13.Text + 1
                    Else
                    End If
                Case 14
                    If var(k_for_도수분포표) >= textbox1_1.Text And var(k_for_도수분포표) < textbox1_2.Text Then
                        answer1.Text = answer1.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox2_1.Text And var(k_for_도수분포표) < textbox2_2.Text Then
                        answer2.Text = answer2.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox3_1.Text And var(k_for_도수분포표) < textbox3_2.Text Then
                        answer3.Text = answer3.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox4_1.Text And var(k_for_도수분포표) < textbox4_2.Text Then
                        answer4.Text = answer4.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox5_1.Text And var(k_for_도수분포표) < textbox5_2.Text Then
                        answer5.Text = answer5.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox6_1.Text And var(k_for_도수분포표) < textbox6_2.Text Then
                        answer6.Text = answer6.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox7_1.Text And var(k_for_도수분포표) < textbox7_2.Text Then
                        answer7.Text = answer7.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox8_1.Text And var(k_for_도수분포표) < textbox8_2.Text Then
                        answer8.Text = answer8.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox9_1.Text And var(k_for_도수분포표) < textbox9_2.Text Then
                        answer9.Text = answer9.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox10_1.Text And var(k_for_도수분포표) < textbox10_2.Text Then
                        answer10.Text = answer10.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox11_1.Text And var(k_for_도수분포표) < textbox11_2.Text Then
                        answer11.Text = answer11.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox12_1.Text And var(k_for_도수분포표) < textbox12_2.Text Then
                        answer12.Text = answer12.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox13_1.Text And var(k_for_도수분포표) < textbox13_2.Text Then
                        answer13.Text = answer13.Text + 1
                    ElseIf var(k_for_도수분포표) >= textbox14_1.Text And var(k_for_도수분포표) < textbox14_2.Text Then
                        answer14.Text = answer14.Text + 1
                    Else
                    End If
            End Select
        Next
        Me.Enabled = False
    End Sub
    Private Sub Settings1_Click(sender As System.Object, e As System.EventArgs) Handles FrequencySettings.Click, StemAndLeafSettings.Click
        Select Case num
            Case 1
                textbox2_1.Show()
                textbox2_2.Show()
                Label2_1.Show()
                Label2_2.Show()
                Label2_3.Show()
                answer2.Show()
                textbox2_1.Text = textbox1_2.Text
            Case 2
                textbox3_1.Show()
                textbox3_2.Show()
                Label3_1.Show()
                Label3_2.Show()
                Label3_3.Show()
                answer3.Show()
                textbox3_1.Text = textbox2_2.Text
            Case 3
                textbox4_1.Show()
                textbox4_2.Show()
                Label4_1.Show()
                Label4_2.Show()
                Label4_3.Show()
                answer4.Show()
                textbox4_1.Text = textbox3_2.Text
            Case 4
                textbox5_1.Show()
                textbox5_2.Show()
                Label5_1.Show()
                Label5_2.Show()
                Label5_3.Show()
                answer5.Show()
                textbox5_1.Text = textbox4_2.Text
            Case 5
                textbox6_1.Show()
                textbox6_2.Show()
                Label6_1.Show()
                Label6_2.Show()
                Label6_3.Show()
                answer6.Show()
                textbox6_1.Text = textbox5_2.Text
            Case 6
                textbox7_1.Show()
                textbox7_2.Show()
                Label7_1.Show()
                Label7_2.Show()
                Label7_3.Show()
                answer7.Show()
                textbox7_1.Text = textbox6_2.Text
            Case 7
                textbox8_1.Show()
                textbox8_2.Show()
                Label8_1.Show()
                Label8_2.Show()
                Label8_3.Show()
                answer8.Show()
                textbox8_1.Text = textbox7_2.Text
            Case 8
                textbox9_1.Show()
                textbox9_2.Show()
                Label9_1.Show()
                Label9_2.Show()
                Label9_3.Show()
                answer9.Show()
                textbox9_1.Text = textbox8_2.Text
            Case 9
                textbox10_1.Show()
                textbox10_2.Show()
                Label10_1.Show()
                Label10_2.Show()
                Label10_3.Show()
                answer10.Show()
                textbox10_1.Text = textbox9_2.Text
            Case 10
                textbox11_1.Show()
                textbox11_2.Show()
                Label11_1.Show()
                Label11_2.Show()
                Label11_3.Show()
                answer11.Show()
                textbox11_1.Text = textbox10_2.Text
            Case 11
                textbox12_1.Show()
                textbox12_2.Show()
                Label12_1.Show()
                Label12_2.Show()
                Label12_3.Show()
                answer12.Show()
                textbox12_1.Text = textbox11_2.Text
            Case 12
                textbox13_1.Show()
                textbox13_2.Show()
                Label13_1.Show()
                Label13_2.Show()
                Label13_3.Show()
                answer13.Show()
                textbox13_1.Text = textbox12_2.Text
            Case 13
                textbox14_1.Show()
                textbox14_2.Show()
                Label14_1.Show()
                Label14_2.Show()
                Label14_3.Show()
                answer14.Show()
                textbox14_1.Text = textbox13_2.Text
                FrequencySettings.Enabled = False
        End Select
        num = num + 1
    End Sub
    Private Sub textbox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PrimeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrimeButton.PerformClick()
        End If
    End Sub
    Private Sub textbox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PrimeNumbersTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrimeButton.PerformClick()
        End If
    End Sub
    Private Sub LCMtextbox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LCMTextbox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            LCMButton.PerformClick()
        End If
    End Sub
    Private Sub LCMtextbox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LCMTextbox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            LCMButton.PerformClick()
        End If
    End Sub
    Private Sub textbox5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrimeButton.PerformClick()
        End If
    End Sub
    Private Sub textbox6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.PerformClick()
        End If
    End Sub
    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If
        If ProgressBar1.Value = 0 Then
            ProgressBar1.Value = 100
        End If
    End Sub
    Private Sub ShowLogs_Click(sender As System.Object, e As System.EventArgs) Handles ShowLogs.Click
        logs.Show()
    End Sub
    Private Sub ShowAbout_Click(sender As System.Object, e As System.EventArgs) Handles ShowAbout.Click
        AboutBox1.Show()
    End Sub
    Private Sub PrimeLogShow_Click(sender As System.Object, e As System.EventArgs) Handles PrimeLogShow.Click
        logs.Show()
        logs.PrimeLogs.Show()
    End Sub
    Private Sub PrimeNumbersLogShow_Click(sender As System.Object, e As System.EventArgs) Handles PrimeNumbersLogShow.Click
        logs.Show()
    End Sub
    Private Sub FrequencyGroupBox_Load(sender As System.Object, e As System.EventArgs) Handles Me.Shown
        FrequencyMake.Enabled = False
        textbox1_1.Text = 0
    End Sub

    Private Sub PrimeTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PrimeTextBox.MouseDown
        PrimeTextBox.Text = vbNullString
    End Sub

End Class
Public Class Functions
    Public Sub 소인수분해(ByRef PrimeTextBox As TextBox, ByRef PrimeAnswer As Label)
        Dim Number As Long 'Number 변수선언
        Try
            Number = CLng(PrimeTextBox.Text) 'textbox 내용을 숫자로 입력받게 함
        Catch ex As Exception
            MsgBox("소인수분해하려는 것이 숫자가 아닙니다")
            Exit Sub
        End Try
        For i As Integer = 2 To Number
            If Number Mod i = 0 Then
                PrimeAnswer.Text = PrimeAnswer.Text & i
                Number = Number / i
                If Number Mod i = 0 Then
                    PrimeAnswer.Text = PrimeAnswer.Text & "×"
                ElseIf Not Number Mod i = 0 Then
                    If Number > i Then
                        PrimeAnswer.Text = PrimeAnswer.Text & "×"
                    End If
                End If
                i = 1
            End If
        Next
        logs.PrimeFactorization.Items.Add(PrimeTextBox.Text)
        logs.PrimeFactorization.Items(0).SubItems.Add(PrimeAnswer.Text)
    End Sub
    Public Sub 약수의_개수_구하기(ByRef PrimeNumbersTextBox As TextBox, ByRef Label1 As Label)
        If PrimeNumbersTextBox.Text = "" Then
            MsgBox("텍스트박스에 값을 입력하세요", vbInformation, "오류")
            Exit Sub
        End If
        Dim a, b, i As Integer
        a = PrimeNumbersTextBox.Text
        b = 0
        For i = 1 To a
            If a Mod i = 0 Then
                Label1.Text = i
                b = b + 1
            End If
        Next i
        MsgBox(PrimeNumbersTextBox.Text & "의 약수의 개수는 " & b & "개 입니다")
    End Sub
End Class
