<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("약수의 합")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("약수의 개수 구하기")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("소인수분해")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("소인수분해", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("최대공약수 구하기")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("최소공배수 구하기")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("최대공약수와 최소공배수", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1단원 : 자연수의 성질", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("양수와 음수")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("절댓값")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("수의 대소 비교")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("정수와 유리수", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("유리수의 사칙연산")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("복잡한 식의 계산")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("유리수의 계산", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("수의 분류")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2단원 : 정수와 유리수", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("대입")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("문자와 식", New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3단원 : 방정식", New System.Windows.Forms.TreeNode() {TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4단원 : 함수")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1학기", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode17, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("도수분포표")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5단원 : 통계", New System.Windows.Forms.TreeNode() {TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드1")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드2")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2학기", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26})
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMid1 = New System.Windows.Forms.TabPage()
        Me.SelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.Index = New System.Windows.Forms.TreeView()
        Me.PrimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.PrimeLogShow = New System.Windows.Forms.Button()
        Me.PrimeAnswer = New System.Windows.Forms.Label()
        Me.PrimeTextBox = New System.Windows.Forms.TextBox()
        Me.PrimeButton = New System.Windows.Forms.Button()
        Me.LCMGroupBox = New System.Windows.Forms.GroupBox()
        Me.LCMLogsShow = New System.Windows.Forms.Button()
        Me.LCMTextbox2 = New System.Windows.Forms.TextBox()
        Me.LCMTextbox1 = New System.Windows.Forms.TextBox()
        Me.LCMButton = New System.Windows.Forms.Button()
        Me.FrequencyGroupBox = New System.Windows.Forms.GroupBox()
        Me.FrequencySettings = New System.Windows.Forms.Button()
        Me.Label14_3 = New System.Windows.Forms.Label()
        Me.Label7_3 = New System.Windows.Forms.Label()
        Me.Label13_3 = New System.Windows.Forms.Label()
        Me.Label6_3 = New System.Windows.Forms.Label()
        Me.Label12_3 = New System.Windows.Forms.Label()
        Me.Label5_3 = New System.Windows.Forms.Label()
        Me.Label11_3 = New System.Windows.Forms.Label()
        Me.Label4_3 = New System.Windows.Forms.Label()
        Me.Label10_3 = New System.Windows.Forms.Label()
        Me.Label3_3 = New System.Windows.Forms.Label()
        Me.Label9_3 = New System.Windows.Forms.Label()
        Me.Label2_3 = New System.Windows.Forms.Label()
        Me.answer14 = New System.Windows.Forms.Label()
        Me.answer7 = New System.Windows.Forms.Label()
        Me.Label8_3 = New System.Windows.Forms.Label()
        Me.Label1_3 = New System.Windows.Forms.Label()
        Me.answer13 = New System.Windows.Forms.Label()
        Me.answer6 = New System.Windows.Forms.Label()
        Me.answer12 = New System.Windows.Forms.Label()
        Me.answer5 = New System.Windows.Forms.Label()
        Me.answer11 = New System.Windows.Forms.Label()
        Me.answer4 = New System.Windows.Forms.Label()
        Me.answer10 = New System.Windows.Forms.Label()
        Me.answer3 = New System.Windows.Forms.Label()
        Me.answer9 = New System.Windows.Forms.Label()
        Me.answer2 = New System.Windows.Forms.Label()
        Me.textbox14_2 = New System.Windows.Forms.TextBox()
        Me.textbox7_2 = New System.Windows.Forms.TextBox()
        Me.answer8 = New System.Windows.Forms.Label()
        Me.answer1 = New System.Windows.Forms.Label()
        Me.textbox13_2 = New System.Windows.Forms.TextBox()
        Me.textbox6_2 = New System.Windows.Forms.TextBox()
        Me.textbox12_2 = New System.Windows.Forms.TextBox()
        Me.textbox5_2 = New System.Windows.Forms.TextBox()
        Me.textbox11_2 = New System.Windows.Forms.TextBox()
        Me.textbox4_2 = New System.Windows.Forms.TextBox()
        Me.textbox10_2 = New System.Windows.Forms.TextBox()
        Me.textbox3_2 = New System.Windows.Forms.TextBox()
        Me.textbox9_2 = New System.Windows.Forms.TextBox()
        Me.textbox2_2 = New System.Windows.Forms.TextBox()
        Me.textbox14_1 = New System.Windows.Forms.TextBox()
        Me.textbox7_1 = New System.Windows.Forms.TextBox()
        Me.textbox8_2 = New System.Windows.Forms.TextBox()
        Me.textbox1_2 = New System.Windows.Forms.TextBox()
        Me.textbox13_1 = New System.Windows.Forms.TextBox()
        Me.textbox6_1 = New System.Windows.Forms.TextBox()
        Me.textbox12_1 = New System.Windows.Forms.TextBox()
        Me.textbox5_1 = New System.Windows.Forms.TextBox()
        Me.textbox11_1 = New System.Windows.Forms.TextBox()
        Me.textbox4_1 = New System.Windows.Forms.TextBox()
        Me.textbox10_1 = New System.Windows.Forms.TextBox()
        Me.textbox3_1 = New System.Windows.Forms.TextBox()
        Me.textbox9_1 = New System.Windows.Forms.TextBox()
        Me.textbox2_1 = New System.Windows.Forms.TextBox()
        Me.Label14_1 = New System.Windows.Forms.Label()
        Me.Label7_1 = New System.Windows.Forms.Label()
        Me.textbox8_1 = New System.Windows.Forms.TextBox()
        Me.Label13_1 = New System.Windows.Forms.Label()
        Me.textbox1_1 = New System.Windows.Forms.TextBox()
        Me.Label6_1 = New System.Windows.Forms.Label()
        Me.Label12_1 = New System.Windows.Forms.Label()
        Me.FrequencyMake = New System.Windows.Forms.Button()
        Me.Label11_1 = New System.Windows.Forms.Label()
        Me.Label5_1 = New System.Windows.Forms.Label()
        Me.Label14_2 = New System.Windows.Forms.Label()
        Me.Label4_1 = New System.Windows.Forms.Label()
        Me.Label7_2 = New System.Windows.Forms.Label()
        Me.Label13_2 = New System.Windows.Forms.Label()
        Me.FrequencyReset = New System.Windows.Forms.Button()
        Me.Label10_1 = New System.Windows.Forms.Label()
        Me.Label6_2 = New System.Windows.Forms.Label()
        Me.Label12_2 = New System.Windows.Forms.Label()
        Me.Label3_1 = New System.Windows.Forms.Label()
        Me.Label5_2 = New System.Windows.Forms.Label()
        Me.Label11_2 = New System.Windows.Forms.Label()
        Me.FrequencyAddData = New System.Windows.Forms.Button()
        Me.Label9_1 = New System.Windows.Forms.Label()
        Me.Label4_2 = New System.Windows.Forms.Label()
        Me.Label10_2 = New System.Windows.Forms.Label()
        Me.Label2_1 = New System.Windows.Forms.Label()
        Me.Label3_2 = New System.Windows.Forms.Label()
        Me.Label9_2 = New System.Windows.Forms.Label()
        Me.FrequencyData1 = New System.Windows.Forms.Label()
        Me.Label8_1 = New System.Windows.Forms.Label()
        Me.Label2_2 = New System.Windows.Forms.Label()
        Me.Label8_2 = New System.Windows.Forms.Label()
        Me.Label1_1 = New System.Windows.Forms.Label()
        Me.Label1_2 = New System.Windows.Forms.Label()
        Me.StemAndLeafGroupBox = New System.Windows.Forms.GroupBox()
        Me.StemAndLeafSettings = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.StemAndLeafMake = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.StemAndLeafReset = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.GCM_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PrimeNumbersGroupBox = New System.Windows.Forms.GroupBox()
        Me.PrimeNumbersLogShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrimeNumbersTextBox = New System.Windows.Forms.TextBox()
        Me.PrimeNumbersButton = New System.Windows.Forms.Button()
        Me.TabMid2 = New System.Windows.Forms.TabPage()
        Me.TabMid3 = New System.Windows.Forms.TabPage()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.ShowLogs = New System.Windows.Forms.Button()
        Me.ShowAbout = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1.SuspendLayout()
        Me.TabMid1.SuspendLayout()
        Me.SelectGroupBox.SuspendLayout()
        Me.PrimeGroupBox.SuspendLayout()
        Me.LCMGroupBox.SuspendLayout()
        Me.FrequencyGroupBox.SuspendLayout()
        Me.StemAndLeafGroupBox.SuspendLayout()
        Me.GCM_GroupBox.SuspendLayout()
        Me.PrimeNumbersGroupBox.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMid1)
        Me.TabControl1.Controls.Add(Me.TabMid2)
        Me.TabControl1.Controls.Add(Me.TabMid3)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(733, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabMid1
        '
        Me.TabMid1.Controls.Add(Me.SelectGroupBox)
        Me.TabMid1.Controls.Add(Me.PrimeGroupBox)
        Me.TabMid1.Controls.Add(Me.LCMGroupBox)
        Me.TabMid1.Controls.Add(Me.FrequencyGroupBox)
        Me.TabMid1.Controls.Add(Me.StemAndLeafGroupBox)
        Me.TabMid1.Controls.Add(Me.GCM_GroupBox)
        Me.TabMid1.Controls.Add(Me.PrimeNumbersGroupBox)
        Me.TabMid1.Location = New System.Drawing.Point(4, 22)
        Me.TabMid1.Name = "TabMid1"
        Me.TabMid1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMid1.Size = New System.Drawing.Size(725, 436)
        Me.TabMid1.TabIndex = 0
        Me.TabMid1.Text = "중1"
        Me.TabMid1.UseVisualStyleBackColor = True
        '
        'SelectGroupBox
        '
        Me.SelectGroupBox.Controls.Add(Me.Index)
        Me.SelectGroupBox.Location = New System.Drawing.Point(7, 0)
        Me.SelectGroupBox.Name = "SelectGroupBox"
        Me.SelectGroupBox.Size = New System.Drawing.Size(288, 435)
        Me.SelectGroupBox.TabIndex = 0
        Me.SelectGroupBox.TabStop = False
        '
        'Index
        '
        Me.Index.Location = New System.Drawing.Point(6, 14)
        Me.Index.Name = "Index"
        TreeNode1.Name = "1_1_1_1"
        TreeNode1.Text = "약수의 합"
        TreeNode2.Name = "1_1_1_2"
        TreeNode2.Text = "약수의 개수 구하기"
        TreeNode3.Name = "1_1_1_3"
        TreeNode3.Text = "소인수분해"
        TreeNode4.Name = "1_1_1"
        TreeNode4.Text = "소인수분해"
        TreeNode5.Name = "1_1_2_1"
        TreeNode5.Text = "최대공약수 구하기"
        TreeNode6.Name = "1_1_2_2"
        TreeNode6.Text = "최소공배수 구하기"
        TreeNode7.Name = "1_1_2"
        TreeNode7.Text = "최대공약수와 최소공배수"
        TreeNode8.Name = "1_1"
        TreeNode8.Text = "1단원 : 자연수의 성질"
        TreeNode9.Name = "1_2_1_1"
        TreeNode9.Text = "양수와 음수"
        TreeNode10.Name = "1_2_1_2"
        TreeNode10.Text = "절댓값"
        TreeNode11.Name = "1_2_1_3"
        TreeNode11.Text = "수의 대소 비교"
        TreeNode12.Name = "노드1"
        TreeNode12.Text = "정수와 유리수"
        TreeNode13.Name = "1_2_2_1"
        TreeNode13.Text = "유리수의 사칙연산"
        TreeNode14.Name = "1_2_2_2"
        TreeNode14.Text = "복잡한 식의 계산"
        TreeNode15.Name = "노드1"
        TreeNode15.Text = "유리수의 계산"
        TreeNode16.Name = "1_2_3"
        TreeNode16.Text = "수의 분류"
        TreeNode17.Name = "노드3"
        TreeNode17.Text = "2단원 : 정수와 유리수"
        TreeNode18.Name = "1_3_1_1"
        TreeNode18.Text = "대입"
        TreeNode19.Name = "노드0"
        TreeNode19.Text = "문자와 식"
        TreeNode20.Name = "노드4"
        TreeNode20.Text = "3단원 : 방정식"
        TreeNode21.Name = "노드0"
        TreeNode21.Text = "4단원 : 함수"
        TreeNode22.Checked = True
        TreeNode22.Name = "1"
        TreeNode22.Text = "1학기"
        TreeNode23.Name = "18"
        TreeNode23.Text = "도수분포표"
        TreeNode24.Name = "2_1"
        TreeNode24.Text = "5단원 : 통계"
        TreeNode25.Name = "노드1"
        TreeNode25.Text = "노드1"
        TreeNode26.Name = "노드2"
        TreeNode26.Text = "노드2"
        TreeNode27.Checked = True
        TreeNode27.Name = "2"
        TreeNode27.Text = "2학기"
        Me.Index.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode27})
        Me.Index.Size = New System.Drawing.Size(276, 409)
        Me.Index.TabIndex = 0
        '
        'PrimeGroupBox
        '
        Me.PrimeGroupBox.Controls.Add(Me.PrimeLogShow)
        Me.PrimeGroupBox.Controls.Add(Me.PrimeAnswer)
        Me.PrimeGroupBox.Controls.Add(Me.PrimeTextBox)
        Me.PrimeGroupBox.Controls.Add(Me.PrimeButton)
        Me.PrimeGroupBox.Location = New System.Drawing.Point(307, 13)
        Me.PrimeGroupBox.Name = "PrimeGroupBox"
        Me.PrimeGroupBox.Size = New System.Drawing.Size(410, 410)
        Me.PrimeGroupBox.TabIndex = 1
        Me.PrimeGroupBox.TabStop = False
        Me.PrimeGroupBox.Text = "소인수분해"
        Me.PrimeGroupBox.Visible = False
        '
        'PrimeLogShow
        '
        Me.PrimeLogShow.Location = New System.Drawing.Point(328, 379)
        Me.PrimeLogShow.Name = "PrimeLogShow"
        Me.PrimeLogShow.Size = New System.Drawing.Size(75, 23)
        Me.PrimeLogShow.TabIndex = 3
        Me.PrimeLogShow.Text = "로그 보기"
        Me.PrimeLogShow.UseVisualStyleBackColor = True
        '
        'PrimeAnswer
        '
        Me.PrimeAnswer.Location = New System.Drawing.Point(43, 109)
        Me.PrimeAnswer.Name = "PrimeAnswer"
        Me.PrimeAnswer.Size = New System.Drawing.Size(283, 148)
        Me.PrimeAnswer.TabIndex = 2
        '
        'PrimeTextBox
        '
        Me.PrimeTextBox.Location = New System.Drawing.Point(45, 55)
        Me.PrimeTextBox.Name = "PrimeTextBox"
        Me.PrimeTextBox.Size = New System.Drawing.Size(150, 21)
        Me.PrimeTextBox.TabIndex = 1
        '
        'PrimeButton
        '
        Me.PrimeButton.Location = New System.Drawing.Point(224, 39)
        Me.PrimeButton.Name = "PrimeButton"
        Me.PrimeButton.Size = New System.Drawing.Size(102, 50)
        Me.PrimeButton.TabIndex = 0
        Me.PrimeButton.Text = "구하기!"
        Me.PrimeButton.UseVisualStyleBackColor = True
        '
        'LCMGroupBox
        '
        Me.LCMGroupBox.Controls.Add(Me.LCMLogsShow)
        Me.LCMGroupBox.Controls.Add(Me.LCMTextbox2)
        Me.LCMGroupBox.Controls.Add(Me.LCMTextbox1)
        Me.LCMGroupBox.Controls.Add(Me.LCMButton)
        Me.LCMGroupBox.Location = New System.Drawing.Point(307, 13)
        Me.LCMGroupBox.Name = "LCMGroupBox"
        Me.LCMGroupBox.Size = New System.Drawing.Size(410, 410)
        Me.LCMGroupBox.TabIndex = 1
        Me.LCMGroupBox.TabStop = False
        Me.LCMGroupBox.Text = "최소공배수"
        Me.LCMGroupBox.Visible = False
        '
        'LCMLogsShow
        '
        Me.LCMLogsShow.Location = New System.Drawing.Point(328, 379)
        Me.LCMLogsShow.Name = "LCMLogsShow"
        Me.LCMLogsShow.Size = New System.Drawing.Size(75, 23)
        Me.LCMLogsShow.TabIndex = 4
        Me.LCMLogsShow.Text = "로그 보기"
        Me.LCMLogsShow.UseVisualStyleBackColor = True
        '
        'LCMTextbox2
        '
        Me.LCMTextbox2.Location = New System.Drawing.Point(46, 70)
        Me.LCMTextbox2.Name = "LCMTextbox2"
        Me.LCMTextbox2.Size = New System.Drawing.Size(150, 21)
        Me.LCMTextbox2.TabIndex = 1
        '
        'LCMTextbox1
        '
        Me.LCMTextbox1.Location = New System.Drawing.Point(45, 39)
        Me.LCMTextbox1.Name = "LCMTextbox1"
        Me.LCMTextbox1.Size = New System.Drawing.Size(150, 21)
        Me.LCMTextbox1.TabIndex = 1
        '
        'LCMButton
        '
        Me.LCMButton.Location = New System.Drawing.Point(224, 39)
        Me.LCMButton.Name = "LCMButton"
        Me.LCMButton.Size = New System.Drawing.Size(102, 50)
        Me.LCMButton.TabIndex = 0
        Me.LCMButton.Text = "구하기!"
        Me.LCMButton.UseVisualStyleBackColor = True
        '
        'FrequencyGroupBox
        '
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencySettings)
        Me.FrequencyGroupBox.Controls.Add(Me.Label14_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label7_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label13_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label6_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label12_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label5_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label11_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label4_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label10_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label3_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label9_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label2_3)
        Me.FrequencyGroupBox.Controls.Add(Me.answer14)
        Me.FrequencyGroupBox.Controls.Add(Me.answer7)
        Me.FrequencyGroupBox.Controls.Add(Me.Label8_3)
        Me.FrequencyGroupBox.Controls.Add(Me.Label1_3)
        Me.FrequencyGroupBox.Controls.Add(Me.answer13)
        Me.FrequencyGroupBox.Controls.Add(Me.answer6)
        Me.FrequencyGroupBox.Controls.Add(Me.answer12)
        Me.FrequencyGroupBox.Controls.Add(Me.answer5)
        Me.FrequencyGroupBox.Controls.Add(Me.answer11)
        Me.FrequencyGroupBox.Controls.Add(Me.answer4)
        Me.FrequencyGroupBox.Controls.Add(Me.answer10)
        Me.FrequencyGroupBox.Controls.Add(Me.answer3)
        Me.FrequencyGroupBox.Controls.Add(Me.answer9)
        Me.FrequencyGroupBox.Controls.Add(Me.answer2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox14_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox7_2)
        Me.FrequencyGroupBox.Controls.Add(Me.answer8)
        Me.FrequencyGroupBox.Controls.Add(Me.answer1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox13_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox6_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox12_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox5_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox11_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox4_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox10_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox3_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox9_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox2_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox14_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox7_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox8_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox1_2)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox13_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox6_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox12_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox5_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox11_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox4_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox10_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox3_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox9_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox2_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label14_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label7_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox8_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label13_1)
        Me.FrequencyGroupBox.Controls.Add(Me.textbox1_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label6_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label12_1)
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyMake)
        Me.FrequencyGroupBox.Controls.Add(Me.Label11_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label5_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label14_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label4_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label7_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label13_2)
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyReset)
        Me.FrequencyGroupBox.Controls.Add(Me.Label10_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label6_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label12_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label3_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label5_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label11_2)
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyAddData)
        Me.FrequencyGroupBox.Controls.Add(Me.Label9_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label4_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label10_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label2_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label3_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label9_2)
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyData1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label8_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label2_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label8_2)
        Me.FrequencyGroupBox.Controls.Add(Me.Label1_1)
        Me.FrequencyGroupBox.Controls.Add(Me.Label1_2)
        Me.FrequencyGroupBox.Location = New System.Drawing.Point(307, 13)
        Me.FrequencyGroupBox.Name = "FrequencyGroupBox"
        Me.FrequencyGroupBox.Size = New System.Drawing.Size(410, 410)
        Me.FrequencyGroupBox.TabIndex = 1
        Me.FrequencyGroupBox.TabStop = False
        Me.FrequencyGroupBox.Text = "도수분포표"
        Me.FrequencyGroupBox.Visible = False
        '
        'FrequencySettings
        '
        Me.FrequencySettings.Location = New System.Drawing.Point(30, 164)
        Me.FrequencySettings.Name = "FrequencySettings"
        Me.FrequencySettings.Size = New System.Drawing.Size(89, 25)
        Me.FrequencySettings.TabIndex = 7
        Me.FrequencySettings.Text = "분류기준 추가"
        Me.FrequencySettings.UseVisualStyleBackColor = True
        '
        'Label14_3
        '
        Me.Label14_3.AutoSize = True
        Me.Label14_3.Location = New System.Drawing.Point(386, 380)
        Me.Label14_3.Name = "Label14_3"
        Me.Label14_3.Size = New System.Drawing.Size(17, 12)
        Me.Label14_3.TabIndex = 6
        Me.Label14_3.Text = "개"
        Me.Label14_3.Visible = False
        '
        'Label7_3
        '
        Me.Label7_3.AutoSize = True
        Me.Label7_3.Location = New System.Drawing.Point(182, 380)
        Me.Label7_3.Name = "Label7_3"
        Me.Label7_3.Size = New System.Drawing.Size(17, 12)
        Me.Label7_3.TabIndex = 6
        Me.Label7_3.Text = "개"
        Me.Label7_3.Visible = False
        '
        'Label13_3
        '
        Me.Label13_3.AutoSize = True
        Me.Label13_3.Location = New System.Drawing.Point(386, 353)
        Me.Label13_3.Name = "Label13_3"
        Me.Label13_3.Size = New System.Drawing.Size(17, 12)
        Me.Label13_3.TabIndex = 6
        Me.Label13_3.Text = "개"
        Me.Label13_3.Visible = False
        '
        'Label6_3
        '
        Me.Label6_3.AutoSize = True
        Me.Label6_3.Location = New System.Drawing.Point(182, 353)
        Me.Label6_3.Name = "Label6_3"
        Me.Label6_3.Size = New System.Drawing.Size(17, 12)
        Me.Label6_3.TabIndex = 6
        Me.Label6_3.Text = "개"
        Me.Label6_3.Visible = False
        '
        'Label12_3
        '
        Me.Label12_3.AutoSize = True
        Me.Label12_3.Location = New System.Drawing.Point(386, 326)
        Me.Label12_3.Name = "Label12_3"
        Me.Label12_3.Size = New System.Drawing.Size(17, 12)
        Me.Label12_3.TabIndex = 6
        Me.Label12_3.Text = "개"
        Me.Label12_3.Visible = False
        '
        'Label5_3
        '
        Me.Label5_3.AutoSize = True
        Me.Label5_3.Location = New System.Drawing.Point(182, 326)
        Me.Label5_3.Name = "Label5_3"
        Me.Label5_3.Size = New System.Drawing.Size(17, 12)
        Me.Label5_3.TabIndex = 6
        Me.Label5_3.Text = "개"
        Me.Label5_3.Visible = False
        '
        'Label11_3
        '
        Me.Label11_3.AutoSize = True
        Me.Label11_3.Location = New System.Drawing.Point(386, 299)
        Me.Label11_3.Name = "Label11_3"
        Me.Label11_3.Size = New System.Drawing.Size(17, 12)
        Me.Label11_3.TabIndex = 6
        Me.Label11_3.Text = "개"
        Me.Label11_3.Visible = False
        '
        'Label4_3
        '
        Me.Label4_3.AutoSize = True
        Me.Label4_3.Location = New System.Drawing.Point(182, 299)
        Me.Label4_3.Name = "Label4_3"
        Me.Label4_3.Size = New System.Drawing.Size(17, 12)
        Me.Label4_3.TabIndex = 6
        Me.Label4_3.Text = "개"
        Me.Label4_3.Visible = False
        '
        'Label10_3
        '
        Me.Label10_3.AutoSize = True
        Me.Label10_3.Location = New System.Drawing.Point(386, 272)
        Me.Label10_3.Name = "Label10_3"
        Me.Label10_3.Size = New System.Drawing.Size(17, 12)
        Me.Label10_3.TabIndex = 6
        Me.Label10_3.Text = "개"
        Me.Label10_3.Visible = False
        '
        'Label3_3
        '
        Me.Label3_3.AutoSize = True
        Me.Label3_3.Location = New System.Drawing.Point(182, 272)
        Me.Label3_3.Name = "Label3_3"
        Me.Label3_3.Size = New System.Drawing.Size(17, 12)
        Me.Label3_3.TabIndex = 6
        Me.Label3_3.Text = "개"
        Me.Label3_3.Visible = False
        '
        'Label9_3
        '
        Me.Label9_3.AutoSize = True
        Me.Label9_3.Location = New System.Drawing.Point(386, 245)
        Me.Label9_3.Name = "Label9_3"
        Me.Label9_3.Size = New System.Drawing.Size(17, 12)
        Me.Label9_3.TabIndex = 6
        Me.Label9_3.Text = "개"
        Me.Label9_3.Visible = False
        '
        'Label2_3
        '
        Me.Label2_3.AutoSize = True
        Me.Label2_3.Location = New System.Drawing.Point(182, 245)
        Me.Label2_3.Name = "Label2_3"
        Me.Label2_3.Size = New System.Drawing.Size(17, 12)
        Me.Label2_3.TabIndex = 6
        Me.Label2_3.Text = "개"
        Me.Label2_3.Visible = False
        '
        'answer14
        '
        Me.answer14.Location = New System.Drawing.Point(340, 379)
        Me.answer14.Name = "answer14"
        Me.answer14.Size = New System.Drawing.Size(49, 18)
        Me.answer14.TabIndex = 6
        Me.answer14.Visible = False
        '
        'answer7
        '
        Me.answer7.Location = New System.Drawing.Point(136, 379)
        Me.answer7.Name = "answer7"
        Me.answer7.Size = New System.Drawing.Size(49, 18)
        Me.answer7.TabIndex = 6
        Me.answer7.Visible = False
        '
        'Label8_3
        '
        Me.Label8_3.AutoSize = True
        Me.Label8_3.Location = New System.Drawing.Point(386, 218)
        Me.Label8_3.Name = "Label8_3"
        Me.Label8_3.Size = New System.Drawing.Size(17, 12)
        Me.Label8_3.TabIndex = 6
        Me.Label8_3.Text = "개"
        Me.Label8_3.Visible = False
        '
        'Label1_3
        '
        Me.Label1_3.AutoSize = True
        Me.Label1_3.Location = New System.Drawing.Point(182, 218)
        Me.Label1_3.Name = "Label1_3"
        Me.Label1_3.Size = New System.Drawing.Size(17, 12)
        Me.Label1_3.TabIndex = 6
        Me.Label1_3.Text = "개"
        '
        'answer13
        '
        Me.answer13.Location = New System.Drawing.Point(340, 352)
        Me.answer13.Name = "answer13"
        Me.answer13.Size = New System.Drawing.Size(49, 18)
        Me.answer13.TabIndex = 6
        Me.answer13.Visible = False
        '
        'answer6
        '
        Me.answer6.Location = New System.Drawing.Point(136, 352)
        Me.answer6.Name = "answer6"
        Me.answer6.Size = New System.Drawing.Size(49, 18)
        Me.answer6.TabIndex = 6
        Me.answer6.Visible = False
        '
        'answer12
        '
        Me.answer12.Location = New System.Drawing.Point(340, 326)
        Me.answer12.Name = "answer12"
        Me.answer12.Size = New System.Drawing.Size(49, 18)
        Me.answer12.TabIndex = 6
        Me.answer12.Visible = False
        '
        'answer5
        '
        Me.answer5.Location = New System.Drawing.Point(136, 326)
        Me.answer5.Name = "answer5"
        Me.answer5.Size = New System.Drawing.Size(49, 18)
        Me.answer5.TabIndex = 6
        Me.answer5.Visible = False
        '
        'answer11
        '
        Me.answer11.Location = New System.Drawing.Point(340, 299)
        Me.answer11.Name = "answer11"
        Me.answer11.Size = New System.Drawing.Size(49, 18)
        Me.answer11.TabIndex = 6
        Me.answer11.Visible = False
        '
        'answer4
        '
        Me.answer4.Location = New System.Drawing.Point(136, 299)
        Me.answer4.Name = "answer4"
        Me.answer4.Size = New System.Drawing.Size(49, 18)
        Me.answer4.TabIndex = 6
        Me.answer4.Visible = False
        '
        'answer10
        '
        Me.answer10.Location = New System.Drawing.Point(340, 272)
        Me.answer10.Name = "answer10"
        Me.answer10.Size = New System.Drawing.Size(49, 18)
        Me.answer10.TabIndex = 6
        Me.answer10.Visible = False
        '
        'answer3
        '
        Me.answer3.Location = New System.Drawing.Point(136, 272)
        Me.answer3.Name = "answer3"
        Me.answer3.Size = New System.Drawing.Size(49, 18)
        Me.answer3.TabIndex = 6
        Me.answer3.Visible = False
        '
        'answer9
        '
        Me.answer9.Location = New System.Drawing.Point(340, 245)
        Me.answer9.Name = "answer9"
        Me.answer9.Size = New System.Drawing.Size(49, 18)
        Me.answer9.TabIndex = 6
        Me.answer9.Visible = False
        '
        'answer2
        '
        Me.answer2.Location = New System.Drawing.Point(136, 245)
        Me.answer2.Name = "answer2"
        Me.answer2.Size = New System.Drawing.Size(49, 18)
        Me.answer2.TabIndex = 6
        Me.answer2.Visible = False
        '
        'textbox14_2
        '
        Me.textbox14_2.Location = New System.Drawing.Point(273, 376)
        Me.textbox14_2.Name = "textbox14_2"
        Me.textbox14_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox14_2.TabIndex = 4
        Me.textbox14_2.Visible = False
        '
        'textbox7_2
        '
        Me.textbox7_2.Location = New System.Drawing.Point(69, 376)
        Me.textbox7_2.Name = "textbox7_2"
        Me.textbox7_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox7_2.TabIndex = 4
        Me.textbox7_2.Visible = False
        '
        'answer8
        '
        Me.answer8.Location = New System.Drawing.Point(340, 217)
        Me.answer8.Name = "answer8"
        Me.answer8.Size = New System.Drawing.Size(49, 18)
        Me.answer8.TabIndex = 6
        Me.answer8.Visible = False
        '
        'answer1
        '
        Me.answer1.Location = New System.Drawing.Point(136, 217)
        Me.answer1.Name = "answer1"
        Me.answer1.Size = New System.Drawing.Size(49, 18)
        Me.answer1.TabIndex = 6
        '
        'textbox13_2
        '
        Me.textbox13_2.Location = New System.Drawing.Point(273, 349)
        Me.textbox13_2.Name = "textbox13_2"
        Me.textbox13_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox13_2.TabIndex = 4
        Me.textbox13_2.Visible = False
        '
        'textbox6_2
        '
        Me.textbox6_2.Location = New System.Drawing.Point(69, 349)
        Me.textbox6_2.Name = "textbox6_2"
        Me.textbox6_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox6_2.TabIndex = 4
        Me.textbox6_2.Visible = False
        '
        'textbox12_2
        '
        Me.textbox12_2.Location = New System.Drawing.Point(273, 322)
        Me.textbox12_2.Name = "textbox12_2"
        Me.textbox12_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox12_2.TabIndex = 4
        Me.textbox12_2.Visible = False
        '
        'textbox5_2
        '
        Me.textbox5_2.Location = New System.Drawing.Point(69, 322)
        Me.textbox5_2.Name = "textbox5_2"
        Me.textbox5_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox5_2.TabIndex = 4
        Me.textbox5_2.Visible = False
        '
        'textbox11_2
        '
        Me.textbox11_2.Location = New System.Drawing.Point(273, 295)
        Me.textbox11_2.Name = "textbox11_2"
        Me.textbox11_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox11_2.TabIndex = 4
        Me.textbox11_2.Visible = False
        '
        'textbox4_2
        '
        Me.textbox4_2.Location = New System.Drawing.Point(69, 295)
        Me.textbox4_2.Name = "textbox4_2"
        Me.textbox4_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox4_2.TabIndex = 4
        Me.textbox4_2.Visible = False
        '
        'textbox10_2
        '
        Me.textbox10_2.Location = New System.Drawing.Point(273, 268)
        Me.textbox10_2.Name = "textbox10_2"
        Me.textbox10_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox10_2.TabIndex = 4
        Me.textbox10_2.Visible = False
        '
        'textbox3_2
        '
        Me.textbox3_2.Location = New System.Drawing.Point(69, 268)
        Me.textbox3_2.Name = "textbox3_2"
        Me.textbox3_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox3_2.TabIndex = 4
        Me.textbox3_2.Visible = False
        '
        'textbox9_2
        '
        Me.textbox9_2.Location = New System.Drawing.Point(273, 241)
        Me.textbox9_2.Name = "textbox9_2"
        Me.textbox9_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox9_2.TabIndex = 4
        Me.textbox9_2.Visible = False
        '
        'textbox2_2
        '
        Me.textbox2_2.Location = New System.Drawing.Point(69, 241)
        Me.textbox2_2.Name = "textbox2_2"
        Me.textbox2_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox2_2.TabIndex = 4
        Me.textbox2_2.Visible = False
        '
        'textbox14_1
        '
        Me.textbox14_1.Location = New System.Drawing.Point(211, 376)
        Me.textbox14_1.Name = "textbox14_1"
        Me.textbox14_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox14_1.TabIndex = 4
        Me.textbox14_1.Visible = False
        '
        'textbox7_1
        '
        Me.textbox7_1.Location = New System.Drawing.Point(7, 376)
        Me.textbox7_1.Name = "textbox7_1"
        Me.textbox7_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox7_1.TabIndex = 4
        Me.textbox7_1.Visible = False
        '
        'textbox8_2
        '
        Me.textbox8_2.Location = New System.Drawing.Point(273, 214)
        Me.textbox8_2.Name = "textbox8_2"
        Me.textbox8_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox8_2.TabIndex = 4
        Me.textbox8_2.Visible = False
        '
        'textbox1_2
        '
        Me.textbox1_2.Location = New System.Drawing.Point(69, 214)
        Me.textbox1_2.Name = "textbox1_2"
        Me.textbox1_2.Size = New System.Drawing.Size(34, 21)
        Me.textbox1_2.TabIndex = 4
        '
        'textbox13_1
        '
        Me.textbox13_1.Location = New System.Drawing.Point(211, 349)
        Me.textbox13_1.Name = "textbox13_1"
        Me.textbox13_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox13_1.TabIndex = 4
        Me.textbox13_1.Visible = False
        '
        'textbox6_1
        '
        Me.textbox6_1.Location = New System.Drawing.Point(7, 349)
        Me.textbox6_1.Name = "textbox6_1"
        Me.textbox6_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox6_1.TabIndex = 4
        Me.textbox6_1.Visible = False
        '
        'textbox12_1
        '
        Me.textbox12_1.Location = New System.Drawing.Point(211, 322)
        Me.textbox12_1.Name = "textbox12_1"
        Me.textbox12_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox12_1.TabIndex = 4
        Me.textbox12_1.Visible = False
        '
        'textbox5_1
        '
        Me.textbox5_1.Location = New System.Drawing.Point(7, 322)
        Me.textbox5_1.Name = "textbox5_1"
        Me.textbox5_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox5_1.TabIndex = 4
        Me.textbox5_1.Visible = False
        '
        'textbox11_1
        '
        Me.textbox11_1.Location = New System.Drawing.Point(211, 295)
        Me.textbox11_1.Name = "textbox11_1"
        Me.textbox11_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox11_1.TabIndex = 4
        Me.textbox11_1.Visible = False
        '
        'textbox4_1
        '
        Me.textbox4_1.Location = New System.Drawing.Point(7, 295)
        Me.textbox4_1.Name = "textbox4_1"
        Me.textbox4_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox4_1.TabIndex = 4
        Me.textbox4_1.Visible = False
        '
        'textbox10_1
        '
        Me.textbox10_1.Location = New System.Drawing.Point(211, 268)
        Me.textbox10_1.Name = "textbox10_1"
        Me.textbox10_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox10_1.TabIndex = 4
        Me.textbox10_1.Visible = False
        '
        'textbox3_1
        '
        Me.textbox3_1.Location = New System.Drawing.Point(7, 268)
        Me.textbox3_1.Name = "textbox3_1"
        Me.textbox3_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox3_1.TabIndex = 4
        Me.textbox3_1.Visible = False
        '
        'textbox9_1
        '
        Me.textbox9_1.Location = New System.Drawing.Point(211, 241)
        Me.textbox9_1.Name = "textbox9_1"
        Me.textbox9_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox9_1.TabIndex = 4
        Me.textbox9_1.Visible = False
        '
        'textbox2_1
        '
        Me.textbox2_1.Location = New System.Drawing.Point(7, 241)
        Me.textbox2_1.Name = "textbox2_1"
        Me.textbox2_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox2_1.TabIndex = 4
        Me.textbox2_1.Visible = False
        '
        'Label14_1
        '
        Me.Label14_1.AutoSize = True
        Me.Label14_1.Location = New System.Drawing.Point(244, 380)
        Me.Label14_1.Name = "Label14_1"
        Me.Label14_1.Size = New System.Drawing.Size(29, 12)
        Me.Label14_1.TabIndex = 5
        Me.Label14_1.Text = "이상"
        Me.Label14_1.Visible = False
        '
        'Label7_1
        '
        Me.Label7_1.AutoSize = True
        Me.Label7_1.Location = New System.Drawing.Point(40, 380)
        Me.Label7_1.Name = "Label7_1"
        Me.Label7_1.Size = New System.Drawing.Size(29, 12)
        Me.Label7_1.TabIndex = 5
        Me.Label7_1.Text = "이상"
        Me.Label7_1.Visible = False
        '
        'textbox8_1
        '
        Me.textbox8_1.Location = New System.Drawing.Point(211, 214)
        Me.textbox8_1.Name = "textbox8_1"
        Me.textbox8_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox8_1.TabIndex = 4
        Me.textbox8_1.Visible = False
        '
        'Label13_1
        '
        Me.Label13_1.AutoSize = True
        Me.Label13_1.Location = New System.Drawing.Point(244, 353)
        Me.Label13_1.Name = "Label13_1"
        Me.Label13_1.Size = New System.Drawing.Size(29, 12)
        Me.Label13_1.TabIndex = 5
        Me.Label13_1.Text = "이상"
        Me.Label13_1.Visible = False
        '
        'textbox1_1
        '
        Me.textbox1_1.Location = New System.Drawing.Point(7, 214)
        Me.textbox1_1.Name = "textbox1_1"
        Me.textbox1_1.Size = New System.Drawing.Size(34, 21)
        Me.textbox1_1.TabIndex = 4
        '
        'Label6_1
        '
        Me.Label6_1.AutoSize = True
        Me.Label6_1.Location = New System.Drawing.Point(40, 353)
        Me.Label6_1.Name = "Label6_1"
        Me.Label6_1.Size = New System.Drawing.Size(29, 12)
        Me.Label6_1.TabIndex = 5
        Me.Label6_1.Text = "이상"
        Me.Label6_1.Visible = False
        '
        'Label12_1
        '
        Me.Label12_1.AutoSize = True
        Me.Label12_1.Location = New System.Drawing.Point(244, 326)
        Me.Label12_1.Name = "Label12_1"
        Me.Label12_1.Size = New System.Drawing.Size(29, 12)
        Me.Label12_1.TabIndex = 5
        Me.Label12_1.Text = "이상"
        Me.Label12_1.Visible = False
        '
        'FrequencyMake
        '
        Me.FrequencyMake.Location = New System.Drawing.Point(152, 152)
        Me.FrequencyMake.Name = "FrequencyMake"
        Me.FrequencyMake.Size = New System.Drawing.Size(118, 49)
        Me.FrequencyMake.TabIndex = 3
        Me.FrequencyMake.Text = "만들기!"
        Me.FrequencyMake.UseVisualStyleBackColor = True
        '
        'Label11_1
        '
        Me.Label11_1.AutoSize = True
        Me.Label11_1.Location = New System.Drawing.Point(244, 299)
        Me.Label11_1.Name = "Label11_1"
        Me.Label11_1.Size = New System.Drawing.Size(29, 12)
        Me.Label11_1.TabIndex = 5
        Me.Label11_1.Text = "이상"
        Me.Label11_1.Visible = False
        '
        'Label5_1
        '
        Me.Label5_1.AutoSize = True
        Me.Label5_1.Location = New System.Drawing.Point(40, 326)
        Me.Label5_1.Name = "Label5_1"
        Me.Label5_1.Size = New System.Drawing.Size(29, 12)
        Me.Label5_1.TabIndex = 5
        Me.Label5_1.Text = "이상"
        Me.Label5_1.Visible = False
        '
        'Label14_2
        '
        Me.Label14_2.AutoSize = True
        Me.Label14_2.Location = New System.Drawing.Point(306, 380)
        Me.Label14_2.Name = "Label14_2"
        Me.Label14_2.Size = New System.Drawing.Size(29, 12)
        Me.Label14_2.TabIndex = 5
        Me.Label14_2.Text = "미만"
        Me.Label14_2.Visible = False
        '
        'Label4_1
        '
        Me.Label4_1.AutoSize = True
        Me.Label4_1.Location = New System.Drawing.Point(40, 299)
        Me.Label4_1.Name = "Label4_1"
        Me.Label4_1.Size = New System.Drawing.Size(29, 12)
        Me.Label4_1.TabIndex = 5
        Me.Label4_1.Text = "이상"
        Me.Label4_1.Visible = False
        '
        'Label7_2
        '
        Me.Label7_2.AutoSize = True
        Me.Label7_2.Location = New System.Drawing.Point(102, 380)
        Me.Label7_2.Name = "Label7_2"
        Me.Label7_2.Size = New System.Drawing.Size(29, 12)
        Me.Label7_2.TabIndex = 5
        Me.Label7_2.Text = "미만"
        Me.Label7_2.Visible = False
        '
        'Label13_2
        '
        Me.Label13_2.AutoSize = True
        Me.Label13_2.Location = New System.Drawing.Point(306, 353)
        Me.Label13_2.Name = "Label13_2"
        Me.Label13_2.Size = New System.Drawing.Size(29, 12)
        Me.Label13_2.TabIndex = 5
        Me.Label13_2.Text = "미만"
        Me.Label13_2.Visible = False
        '
        'FrequencyReset
        '
        Me.FrequencyReset.Location = New System.Drawing.Point(305, 152)
        Me.FrequencyReset.Name = "FrequencyReset"
        Me.FrequencyReset.Size = New System.Drawing.Size(83, 23)
        Me.FrequencyReset.TabIndex = 1
        Me.FrequencyReset.Text = "초기화"
        Me.FrequencyReset.UseVisualStyleBackColor = True
        '
        'Label10_1
        '
        Me.Label10_1.AutoSize = True
        Me.Label10_1.Location = New System.Drawing.Point(244, 272)
        Me.Label10_1.Name = "Label10_1"
        Me.Label10_1.Size = New System.Drawing.Size(29, 12)
        Me.Label10_1.TabIndex = 5
        Me.Label10_1.Text = "이상"
        Me.Label10_1.Visible = False
        '
        'Label6_2
        '
        Me.Label6_2.AutoSize = True
        Me.Label6_2.Location = New System.Drawing.Point(102, 353)
        Me.Label6_2.Name = "Label6_2"
        Me.Label6_2.Size = New System.Drawing.Size(29, 12)
        Me.Label6_2.TabIndex = 5
        Me.Label6_2.Text = "미만"
        Me.Label6_2.Visible = False
        '
        'Label12_2
        '
        Me.Label12_2.AutoSize = True
        Me.Label12_2.Location = New System.Drawing.Point(306, 326)
        Me.Label12_2.Name = "Label12_2"
        Me.Label12_2.Size = New System.Drawing.Size(29, 12)
        Me.Label12_2.TabIndex = 5
        Me.Label12_2.Text = "미만"
        Me.Label12_2.Visible = False
        '
        'Label3_1
        '
        Me.Label3_1.AutoSize = True
        Me.Label3_1.Location = New System.Drawing.Point(40, 272)
        Me.Label3_1.Name = "Label3_1"
        Me.Label3_1.Size = New System.Drawing.Size(29, 12)
        Me.Label3_1.TabIndex = 5
        Me.Label3_1.Text = "이상"
        Me.Label3_1.Visible = False
        '
        'Label5_2
        '
        Me.Label5_2.AutoSize = True
        Me.Label5_2.Location = New System.Drawing.Point(102, 326)
        Me.Label5_2.Name = "Label5_2"
        Me.Label5_2.Size = New System.Drawing.Size(29, 12)
        Me.Label5_2.TabIndex = 5
        Me.Label5_2.Text = "미만"
        Me.Label5_2.Visible = False
        '
        'Label11_2
        '
        Me.Label11_2.AutoSize = True
        Me.Label11_2.Location = New System.Drawing.Point(306, 299)
        Me.Label11_2.Name = "Label11_2"
        Me.Label11_2.Size = New System.Drawing.Size(29, 12)
        Me.Label11_2.TabIndex = 5
        Me.Label11_2.Text = "미만"
        Me.Label11_2.Visible = False
        '
        'FrequencyAddData
        '
        Me.FrequencyAddData.Location = New System.Drawing.Point(305, 178)
        Me.FrequencyAddData.Name = "FrequencyAddData"
        Me.FrequencyAddData.Size = New System.Drawing.Size(83, 23)
        Me.FrequencyAddData.TabIndex = 1
        Me.FrequencyAddData.Text = "데이터 추가"
        Me.FrequencyAddData.UseVisualStyleBackColor = True
        '
        'Label9_1
        '
        Me.Label9_1.AutoSize = True
        Me.Label9_1.Location = New System.Drawing.Point(244, 245)
        Me.Label9_1.Name = "Label9_1"
        Me.Label9_1.Size = New System.Drawing.Size(29, 12)
        Me.Label9_1.TabIndex = 5
        Me.Label9_1.Text = "이상"
        Me.Label9_1.Visible = False
        '
        'Label4_2
        '
        Me.Label4_2.AutoSize = True
        Me.Label4_2.Location = New System.Drawing.Point(102, 299)
        Me.Label4_2.Name = "Label4_2"
        Me.Label4_2.Size = New System.Drawing.Size(29, 12)
        Me.Label4_2.TabIndex = 5
        Me.Label4_2.Text = "미만"
        Me.Label4_2.Visible = False
        '
        'Label10_2
        '
        Me.Label10_2.AutoSize = True
        Me.Label10_2.Location = New System.Drawing.Point(306, 272)
        Me.Label10_2.Name = "Label10_2"
        Me.Label10_2.Size = New System.Drawing.Size(29, 12)
        Me.Label10_2.TabIndex = 5
        Me.Label10_2.Text = "미만"
        Me.Label10_2.Visible = False
        '
        'Label2_1
        '
        Me.Label2_1.AutoSize = True
        Me.Label2_1.Location = New System.Drawing.Point(40, 245)
        Me.Label2_1.Name = "Label2_1"
        Me.Label2_1.Size = New System.Drawing.Size(29, 12)
        Me.Label2_1.TabIndex = 5
        Me.Label2_1.Text = "이상"
        Me.Label2_1.Visible = False
        '
        'Label3_2
        '
        Me.Label3_2.AutoSize = True
        Me.Label3_2.Location = New System.Drawing.Point(102, 272)
        Me.Label3_2.Name = "Label3_2"
        Me.Label3_2.Size = New System.Drawing.Size(29, 12)
        Me.Label3_2.TabIndex = 5
        Me.Label3_2.Text = "미만"
        Me.Label3_2.Visible = False
        '
        'Label9_2
        '
        Me.Label9_2.AutoSize = True
        Me.Label9_2.Location = New System.Drawing.Point(306, 245)
        Me.Label9_2.Name = "Label9_2"
        Me.Label9_2.Size = New System.Drawing.Size(29, 12)
        Me.Label9_2.TabIndex = 5
        Me.Label9_2.Text = "미만"
        Me.Label9_2.Visible = False
        '
        'FrequencyData1
        '
        Me.FrequencyData1.Location = New System.Drawing.Point(18, 20)
        Me.FrequencyData1.Name = "FrequencyData1"
        Me.FrequencyData1.Size = New System.Drawing.Size(370, 129)
        Me.FrequencyData1.TabIndex = 0
        Me.FrequencyData1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8_1
        '
        Me.Label8_1.AutoSize = True
        Me.Label8_1.Location = New System.Drawing.Point(244, 218)
        Me.Label8_1.Name = "Label8_1"
        Me.Label8_1.Size = New System.Drawing.Size(29, 12)
        Me.Label8_1.TabIndex = 5
        Me.Label8_1.Text = "이상"
        Me.Label8_1.Visible = False
        '
        'Label2_2
        '
        Me.Label2_2.AutoSize = True
        Me.Label2_2.Location = New System.Drawing.Point(102, 245)
        Me.Label2_2.Name = "Label2_2"
        Me.Label2_2.Size = New System.Drawing.Size(29, 12)
        Me.Label2_2.TabIndex = 5
        Me.Label2_2.Text = "미만"
        Me.Label2_2.Visible = False
        '
        'Label8_2
        '
        Me.Label8_2.AutoSize = True
        Me.Label8_2.Location = New System.Drawing.Point(306, 218)
        Me.Label8_2.Name = "Label8_2"
        Me.Label8_2.Size = New System.Drawing.Size(29, 12)
        Me.Label8_2.TabIndex = 5
        Me.Label8_2.Text = "미만"
        Me.Label8_2.Visible = False
        '
        'Label1_1
        '
        Me.Label1_1.AutoSize = True
        Me.Label1_1.Location = New System.Drawing.Point(40, 218)
        Me.Label1_1.Name = "Label1_1"
        Me.Label1_1.Size = New System.Drawing.Size(29, 12)
        Me.Label1_1.TabIndex = 5
        Me.Label1_1.Text = "이상"
        '
        'Label1_2
        '
        Me.Label1_2.AutoSize = True
        Me.Label1_2.Location = New System.Drawing.Point(102, 218)
        Me.Label1_2.Name = "Label1_2"
        Me.Label1_2.Size = New System.Drawing.Size(29, 12)
        Me.Label1_2.TabIndex = 5
        Me.Label1_2.Text = "미만"
        '
        'StemAndLeafGroupBox
        '
        Me.StemAndLeafGroupBox.Controls.Add(Me.StemAndLeafSettings)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label2)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label3)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label5)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label6)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label7)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label8)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label9)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label10)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label11)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label12)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label13)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label14)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label15)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label16)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label17)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label18)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label19)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label20)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label21)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label22)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label23)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label24)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label25)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label26)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label27)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label28)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox1)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox2)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label29)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label30)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox3)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox4)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox7)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox8)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox9)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox10)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox11)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox12)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox13)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox14)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox15)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox16)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox17)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox18)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox19)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox20)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox21)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox22)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox23)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox24)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox25)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox26)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox27)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox28)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label31)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label32)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox29)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label33)
        Me.StemAndLeafGroupBox.Controls.Add(Me.TextBox30)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label34)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label35)
        Me.StemAndLeafGroupBox.Controls.Add(Me.StemAndLeafMake)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label36)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label37)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label38)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label39)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label40)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label41)
        Me.StemAndLeafGroupBox.Controls.Add(Me.StemAndLeafReset)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label42)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label43)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label44)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label45)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label46)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label47)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Button4)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label48)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label49)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label50)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label51)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label52)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label53)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label54)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label55)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label56)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label57)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label58)
        Me.StemAndLeafGroupBox.Controls.Add(Me.Label59)
        Me.StemAndLeafGroupBox.Location = New System.Drawing.Point(307, 13)
        Me.StemAndLeafGroupBox.Name = "StemAndLeafGroupBox"
        Me.StemAndLeafGroupBox.Size = New System.Drawing.Size(410, 410)
        Me.StemAndLeafGroupBox.TabIndex = 1
        Me.StemAndLeafGroupBox.TabStop = False
        Me.StemAndLeafGroupBox.Text = "도수분포표"
        Me.StemAndLeafGroupBox.Visible = False
        '
        'StemAndLeafSettings
        '
        Me.StemAndLeafSettings.Location = New System.Drawing.Point(30, 164)
        Me.StemAndLeafSettings.Name = "StemAndLeafSettings"
        Me.StemAndLeafSettings.Size = New System.Drawing.Size(89, 25)
        Me.StemAndLeafSettings.TabIndex = 7
        Me.StemAndLeafSettings.Text = "분류기준 추가"
        Me.StemAndLeafSettings.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "개"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "개"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "개"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "개"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "개"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(182, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "개"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "개"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "개"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(386, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 12)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "개"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(182, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 12)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "개"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(386, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 12)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "개"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(182, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 12)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "개"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(340, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(136, 379)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(386, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 12)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "개"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(182, 218)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(17, 12)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "개"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(340, 352)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(136, 352)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 18)
        Me.Label20.TabIndex = 6
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(340, 326)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 18)
        Me.Label21.TabIndex = 6
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(136, 326)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 18)
        Me.Label22.TabIndex = 6
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(340, 299)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 18)
        Me.Label23.TabIndex = 6
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(136, 299)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 18)
        Me.Label24.TabIndex = 6
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(340, 272)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 18)
        Me.Label25.TabIndex = 6
        Me.Label25.Visible = False
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(136, 272)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 18)
        Me.Label26.TabIndex = 6
        Me.Label26.Visible = False
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(340, 245)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 18)
        Me.Label27.TabIndex = 6
        Me.Label27.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(136, 245)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 18)
        Me.Label28.TabIndex = 6
        Me.Label28.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 376)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(69, 376)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(34, 21)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(340, 217)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 18)
        Me.Label29.TabIndex = 6
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(136, 217)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 18)
        Me.Label30.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(273, 349)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(34, 21)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(69, 349)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(34, 21)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(273, 322)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(34, 21)
        Me.TextBox7.TabIndex = 4
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(69, 322)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(34, 21)
        Me.TextBox8.TabIndex = 4
        Me.TextBox8.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(273, 295)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(34, 21)
        Me.TextBox9.TabIndex = 4
        Me.TextBox9.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(69, 295)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(34, 21)
        Me.TextBox10.TabIndex = 4
        Me.TextBox10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(273, 268)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(34, 21)
        Me.TextBox11.TabIndex = 4
        Me.TextBox11.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(69, 268)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(34, 21)
        Me.TextBox12.TabIndex = 4
        Me.TextBox12.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(273, 241)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(34, 21)
        Me.TextBox13.TabIndex = 4
        Me.TextBox13.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(69, 241)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(34, 21)
        Me.TextBox14.TabIndex = 4
        Me.TextBox14.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(211, 376)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(34, 21)
        Me.TextBox15.TabIndex = 4
        Me.TextBox15.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(7, 376)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(34, 21)
        Me.TextBox16.TabIndex = 4
        Me.TextBox16.Visible = False
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(273, 214)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(34, 21)
        Me.TextBox17.TabIndex = 4
        Me.TextBox17.Visible = False
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(69, 214)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(34, 21)
        Me.TextBox18.TabIndex = 4
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(211, 349)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(34, 21)
        Me.TextBox19.TabIndex = 4
        Me.TextBox19.Visible = False
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(7, 349)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(34, 21)
        Me.TextBox20.TabIndex = 4
        Me.TextBox20.Visible = False
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(211, 322)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(34, 21)
        Me.TextBox21.TabIndex = 4
        Me.TextBox21.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(7, 322)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(34, 21)
        Me.TextBox22.TabIndex = 4
        Me.TextBox22.Visible = False
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(211, 295)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(34, 21)
        Me.TextBox23.TabIndex = 4
        Me.TextBox23.Visible = False
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(7, 295)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(34, 21)
        Me.TextBox24.TabIndex = 4
        Me.TextBox24.Visible = False
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(211, 268)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(34, 21)
        Me.TextBox25.TabIndex = 4
        Me.TextBox25.Visible = False
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(7, 268)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(34, 21)
        Me.TextBox26.TabIndex = 4
        Me.TextBox26.Visible = False
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(211, 241)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(34, 21)
        Me.TextBox27.TabIndex = 4
        Me.TextBox27.Visible = False
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(7, 241)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(34, 21)
        Me.TextBox28.TabIndex = 4
        Me.TextBox28.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(244, 380)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(29, 12)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "이상"
        Me.Label31.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(40, 380)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 12)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "이상"
        Me.Label32.Visible = False
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(211, 214)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(34, 21)
        Me.TextBox29.TabIndex = 4
        Me.TextBox29.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(244, 353)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 12)
        Me.Label33.TabIndex = 5
        Me.Label33.Text = "이상"
        Me.Label33.Visible = False
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(7, 214)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(34, 21)
        Me.TextBox30.TabIndex = 4
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(40, 353)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(29, 12)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "이상"
        Me.Label34.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(244, 326)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(29, 12)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "이상"
        Me.Label35.Visible = False
        '
        'StemAndLeafMake
        '
        Me.StemAndLeafMake.Location = New System.Drawing.Point(152, 152)
        Me.StemAndLeafMake.Name = "StemAndLeafMake"
        Me.StemAndLeafMake.Size = New System.Drawing.Size(118, 49)
        Me.StemAndLeafMake.TabIndex = 3
        Me.StemAndLeafMake.Text = "만들기!"
        Me.StemAndLeafMake.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(244, 299)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(29, 12)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "이상"
        Me.Label36.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(40, 326)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 12)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "이상"
        Me.Label37.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(306, 380)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 12)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "미만"
        Me.Label38.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(40, 299)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(29, 12)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "이상"
        Me.Label39.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(102, 380)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(29, 12)
        Me.Label40.TabIndex = 5
        Me.Label40.Text = "미만"
        Me.Label40.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(306, 353)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(29, 12)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "미만"
        Me.Label41.Visible = False
        '
        'StemAndLeafReset
        '
        Me.StemAndLeafReset.Location = New System.Drawing.Point(305, 152)
        Me.StemAndLeafReset.Name = "StemAndLeafReset"
        Me.StemAndLeafReset.Size = New System.Drawing.Size(83, 23)
        Me.StemAndLeafReset.TabIndex = 1
        Me.StemAndLeafReset.Text = "초기화"
        Me.StemAndLeafReset.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(244, 272)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(29, 12)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "이상"
        Me.Label42.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(102, 353)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(29, 12)
        Me.Label43.TabIndex = 5
        Me.Label43.Text = "미만"
        Me.Label43.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(306, 326)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 12)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "미만"
        Me.Label44.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(40, 272)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(29, 12)
        Me.Label45.TabIndex = 5
        Me.Label45.Text = "이상"
        Me.Label45.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(102, 326)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(29, 12)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = "미만"
        Me.Label46.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(306, 299)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(29, 12)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "미만"
        Me.Label47.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(305, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "데이터 추가"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(244, 245)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(29, 12)
        Me.Label48.TabIndex = 5
        Me.Label48.Text = "이상"
        Me.Label48.Visible = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(102, 299)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(29, 12)
        Me.Label49.TabIndex = 5
        Me.Label49.Text = "미만"
        Me.Label49.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(306, 272)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(29, 12)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "미만"
        Me.Label50.Visible = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(40, 245)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(29, 12)
        Me.Label51.TabIndex = 5
        Me.Label51.Text = "이상"
        Me.Label51.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(102, 272)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(29, 12)
        Me.Label52.TabIndex = 5
        Me.Label52.Text = "미만"
        Me.Label52.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(306, 245)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(29, 12)
        Me.Label53.TabIndex = 5
        Me.Label53.Text = "미만"
        Me.Label53.Visible = False
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(18, 20)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(370, 129)
        Me.Label54.TabIndex = 0
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(244, 218)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(29, 12)
        Me.Label55.TabIndex = 5
        Me.Label55.Text = "이상"
        Me.Label55.Visible = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(102, 245)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(29, 12)
        Me.Label56.TabIndex = 5
        Me.Label56.Text = "미만"
        Me.Label56.Visible = False
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(306, 218)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(29, 12)
        Me.Label57.TabIndex = 5
        Me.Label57.Text = "미만"
        Me.Label57.Visible = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(40, 218)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(29, 12)
        Me.Label58.TabIndex = 5
        Me.Label58.Text = "이상"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(102, 218)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(29, 12)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "미만"
        '
        'GCM_GroupBox
        '
        Me.GCM_GroupBox.Controls.Add(Me.Label4)
        Me.GCM_GroupBox.Controls.Add(Me.TextBox6)
        Me.GCM_GroupBox.Controls.Add(Me.TextBox5)
        Me.GCM_GroupBox.Controls.Add(Me.Button5)
        Me.GCM_GroupBox.Location = New System.Drawing.Point(307, 13)
        Me.GCM_GroupBox.Name = "GCM_GroupBox"
        Me.GCM_GroupBox.Size = New System.Drawing.Size(410, 410)
        Me.GCM_GroupBox.TabIndex = 1
        Me.GCM_GroupBox.TabStop = False
        Me.GCM_GroupBox.Text = "최대공약수"
        Me.GCM_GroupBox.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(43, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 148)
        Me.Label4.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(46, 68)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 21)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(45, 39)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 21)
        Me.TextBox5.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(224, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "구하기!"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PrimeNumbersGroupBox
        '
        Me.PrimeNumbersGroupBox.Controls.Add(Me.PrimeNumbersLogShow)
        Me.PrimeNumbersGroupBox.Controls.Add(Me.Label1)
        Me.PrimeNumbersGroupBox.Controls.Add(Me.PrimeNumbersTextBox)
        Me.PrimeNumbersGroupBox.Controls.Add(Me.PrimeNumbersButton)
        Me.PrimeNumbersGroupBox.Location = New System.Drawing.Point(307, 13)
        Me.PrimeNumbersGroupBox.Name = "PrimeNumbersGroupBox"
        Me.PrimeNumbersGroupBox.Size = New System.Drawing.Size(410, 410)
        Me.PrimeNumbersGroupBox.TabIndex = 1
        Me.PrimeNumbersGroupBox.TabStop = False
        Me.PrimeNumbersGroupBox.Text = "약수의 개수 구하기"
        Me.PrimeNumbersGroupBox.Visible = False
        '
        'PrimeNumbersLogShow
        '
        Me.PrimeNumbersLogShow.Location = New System.Drawing.Point(328, 379)
        Me.PrimeNumbersLogShow.Name = "PrimeNumbersLogShow"
        Me.PrimeNumbersLogShow.Size = New System.Drawing.Size(75, 23)
        Me.PrimeNumbersLogShow.TabIndex = 4
        Me.PrimeNumbersLogShow.Text = "로그 보기"
        Me.PrimeNumbersLogShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(245, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 0)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'PrimeNumbersTextBox
        '
        Me.PrimeNumbersTextBox.Location = New System.Drawing.Point(45, 55)
        Me.PrimeNumbersTextBox.Name = "PrimeNumbersTextBox"
        Me.PrimeNumbersTextBox.Size = New System.Drawing.Size(150, 21)
        Me.PrimeNumbersTextBox.TabIndex = 1
        '
        'PrimeNumbersButton
        '
        Me.PrimeNumbersButton.Location = New System.Drawing.Point(224, 39)
        Me.PrimeNumbersButton.Name = "PrimeNumbersButton"
        Me.PrimeNumbersButton.Size = New System.Drawing.Size(102, 50)
        Me.PrimeNumbersButton.TabIndex = 0
        Me.PrimeNumbersButton.Text = "구하기!"
        Me.PrimeNumbersButton.UseVisualStyleBackColor = True
        '
        'TabMid2
        '
        Me.TabMid2.Location = New System.Drawing.Point(4, 22)
        Me.TabMid2.Name = "TabMid2"
        Me.TabMid2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMid2.Size = New System.Drawing.Size(725, 436)
        Me.TabMid2.TabIndex = 1
        Me.TabMid2.Text = "중2"
        Me.TabMid2.UseVisualStyleBackColor = True
        '
        'TabMid3
        '
        Me.TabMid3.Location = New System.Drawing.Point(4, 22)
        Me.TabMid3.Name = "TabMid3"
        Me.TabMid3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMid3.Size = New System.Drawing.Size(725, 436)
        Me.TabMid3.TabIndex = 2
        Me.TabMid3.Text = "중3"
        Me.TabMid3.UseVisualStyleBackColor = True
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.ShowLogs)
        Me.TabSettings.Controls.Add(Me.ShowAbout)
        Me.TabSettings.Controls.Add(Me.ProgressBar1)
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(725, 436)
        Me.TabSettings.TabIndex = 3
        Me.TabSettings.Text = "설정"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'ShowLogs
        '
        Me.ShowLogs.Location = New System.Drawing.Point(553, 399)
        Me.ShowLogs.Name = "ShowLogs"
        Me.ShowLogs.Size = New System.Drawing.Size(79, 34)
        Me.ShowLogs.TabIndex = 1
        Me.ShowLogs.Text = "로그 보기"
        Me.ShowLogs.UseVisualStyleBackColor = True
        '
        'ShowAbout
        '
        Me.ShowAbout.Location = New System.Drawing.Point(638, 399)
        Me.ShowAbout.Name = "ShowAbout"
        Me.ShowAbout.Size = New System.Drawing.Size(79, 34)
        Me.ShowAbout.TabIndex = 1
        Me.ShowAbout.Text = "About"
        Me.ShowAbout.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(50, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(54, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabMid1.ResumeLayout(False)
        Me.SelectGroupBox.ResumeLayout(False)
        Me.PrimeGroupBox.ResumeLayout(False)
        Me.PrimeGroupBox.PerformLayout()
        Me.LCMGroupBox.ResumeLayout(False)
        Me.LCMGroupBox.PerformLayout()
        Me.FrequencyGroupBox.ResumeLayout(False)
        Me.FrequencyGroupBox.PerformLayout()
        Me.StemAndLeafGroupBox.ResumeLayout(False)
        Me.StemAndLeafGroupBox.PerformLayout()
        Me.GCM_GroupBox.ResumeLayout(False)
        Me.GCM_GroupBox.PerformLayout()
        Me.PrimeNumbersGroupBox.ResumeLayout(False)
        Me.PrimeNumbersGroupBox.PerformLayout()
        Me.TabSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabMid1 As System.Windows.Forms.TabPage
    Friend WithEvents TabMid2 As System.Windows.Forms.TabPage
    Friend WithEvents SelectGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Index As System.Windows.Forms.TreeView
    Friend WithEvents TabMid3 As System.Windows.Forms.TabPage
    Friend WithEvents PrimeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PrimeButton As System.Windows.Forms.Button
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents PrimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrimeNumbersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PrimeNumbersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrimeNumbersButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LCMGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LCMTextbox1 As System.Windows.Forms.TextBox
    Friend WithEvents LCMButton As System.Windows.Forms.Button
    Friend WithEvents LCMTextbox2 As System.Windows.Forms.TextBox
    Friend WithEvents PrimeAnswer As System.Windows.Forms.Label
    Friend WithEvents GCM_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents FrequencyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FrequencyAddData As System.Windows.Forms.Button
    Friend WithEvents FrequencyData1 As System.Windows.Forms.Label
    Friend WithEvents FrequencyMake As System.Windows.Forms.Button
    Friend WithEvents FrequencyReset As System.Windows.Forms.Button
    Friend WithEvents FrequencySettings As System.Windows.Forms.Button
    Friend WithEvents Label14_3 As System.Windows.Forms.Label
    Friend WithEvents Label7_3 As System.Windows.Forms.Label
    Friend WithEvents Label13_3 As System.Windows.Forms.Label
    Friend WithEvents Label6_3 As System.Windows.Forms.Label
    Friend WithEvents Label12_3 As System.Windows.Forms.Label
    Friend WithEvents Label5_3 As System.Windows.Forms.Label
    Friend WithEvents Label11_3 As System.Windows.Forms.Label
    Friend WithEvents Label4_3 As System.Windows.Forms.Label
    Friend WithEvents Label10_3 As System.Windows.Forms.Label
    Friend WithEvents Label3_3 As System.Windows.Forms.Label
    Friend WithEvents Label9_3 As System.Windows.Forms.Label
    Friend WithEvents Label2_3 As System.Windows.Forms.Label
    Friend WithEvents answer14 As System.Windows.Forms.Label
    Friend WithEvents answer7 As System.Windows.Forms.Label
    Friend WithEvents Label8_3 As System.Windows.Forms.Label
    Friend WithEvents Label1_3 As System.Windows.Forms.Label
    Friend WithEvents answer13 As System.Windows.Forms.Label
    Friend WithEvents answer6 As System.Windows.Forms.Label
    Friend WithEvents answer12 As System.Windows.Forms.Label
    Friend WithEvents answer5 As System.Windows.Forms.Label
    Friend WithEvents answer11 As System.Windows.Forms.Label
    Friend WithEvents answer4 As System.Windows.Forms.Label
    Friend WithEvents answer10 As System.Windows.Forms.Label
    Friend WithEvents answer3 As System.Windows.Forms.Label
    Friend WithEvents answer9 As System.Windows.Forms.Label
    Friend WithEvents answer2 As System.Windows.Forms.Label
    Friend WithEvents textbox14_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox7_2 As System.Windows.Forms.TextBox
    Friend WithEvents answer8 As System.Windows.Forms.Label
    Friend WithEvents answer1 As System.Windows.Forms.Label
    Friend WithEvents textbox13_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox6_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox12_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox5_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox11_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox4_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox10_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox3_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox9_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox2_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox14_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox7_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox8_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox1_2 As System.Windows.Forms.TextBox
    Friend WithEvents textbox13_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox6_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox12_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox5_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox11_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox4_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox10_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox3_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox9_1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox2_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14_1 As System.Windows.Forms.Label
    Friend WithEvents Label7_1 As System.Windows.Forms.Label
    Friend WithEvents textbox8_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13_1 As System.Windows.Forms.Label
    Friend WithEvents textbox1_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6_1 As System.Windows.Forms.Label
    Friend WithEvents Label12_1 As System.Windows.Forms.Label
    Friend WithEvents Label11_1 As System.Windows.Forms.Label
    Friend WithEvents Label5_1 As System.Windows.Forms.Label
    Friend WithEvents Label14_2 As System.Windows.Forms.Label
    Friend WithEvents Label4_1 As System.Windows.Forms.Label
    Friend WithEvents Label7_2 As System.Windows.Forms.Label
    Friend WithEvents Label13_2 As System.Windows.Forms.Label
    Friend WithEvents Label10_1 As System.Windows.Forms.Label
    Friend WithEvents Label6_2 As System.Windows.Forms.Label
    Friend WithEvents Label12_2 As System.Windows.Forms.Label
    Friend WithEvents Label3_1 As System.Windows.Forms.Label
    Friend WithEvents Label5_2 As System.Windows.Forms.Label
    Friend WithEvents Label11_2 As System.Windows.Forms.Label
    Friend WithEvents Label9_1 As System.Windows.Forms.Label
    Friend WithEvents Label4_2 As System.Windows.Forms.Label
    Friend WithEvents Label10_2 As System.Windows.Forms.Label
    Friend WithEvents Label2_1 As System.Windows.Forms.Label
    Friend WithEvents Label3_2 As System.Windows.Forms.Label
    Friend WithEvents Label9_2 As System.Windows.Forms.Label
    Friend WithEvents Label8_1 As System.Windows.Forms.Label
    Friend WithEvents Label2_2 As System.Windows.Forms.Label
    Friend WithEvents Label8_2 As System.Windows.Forms.Label
    Friend WithEvents Label1_1 As System.Windows.Forms.Label
    Friend WithEvents Label1_2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ShowLogs As System.Windows.Forms.Button
    Friend WithEvents ShowAbout As System.Windows.Forms.Button
    Friend WithEvents PrimeLogShow As System.Windows.Forms.Button
    Friend WithEvents PrimeNumbersLogShow As System.Windows.Forms.Button
    Friend WithEvents LCMLogsShow As System.Windows.Forms.Button
    Friend WithEvents StemAndLeafGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents StemAndLeafSettings As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents StemAndLeafMake As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents StemAndLeafReset As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label

End Class
