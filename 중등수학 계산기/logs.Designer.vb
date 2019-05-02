<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logs
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
        Me.PrimeLogs = New System.Windows.Forms.GroupBox()
        Me.PrimeFactorization = New System.Windows.Forms.ListView()
        Me.Num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Answer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrimeLogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrimeLogs
        '
        Me.PrimeLogs.Controls.Add(Me.PrimeFactorization)
        Me.PrimeLogs.Location = New System.Drawing.Point(2, 0)
        Me.PrimeLogs.Name = "PrimeLogs"
        Me.PrimeLogs.Size = New System.Drawing.Size(730, 460)
        Me.PrimeLogs.TabIndex = 2
        Me.PrimeLogs.TabStop = False
        Me.PrimeLogs.Text = "소인수분해"
        Me.PrimeLogs.Visible = False
        '
        'PrimeFactorization
        '
        Me.PrimeFactorization.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Num, Me.Answer, Me.Time})
        Me.PrimeFactorization.Location = New System.Drawing.Point(6, 20)
        Me.PrimeFactorization.Name = "PrimeFactorization"
        Me.PrimeFactorization.Size = New System.Drawing.Size(714, 430)
        Me.PrimeFactorization.TabIndex = 2
        Me.PrimeFactorization.UseCompatibleStateImageBehavior = False
        Me.PrimeFactorization.View = System.Windows.Forms.View.Details
        '
        'Num
        '
        Me.Num.Text = "값"
        Me.Num.Width = 70
        '
        'Answer
        '
        Me.Answer.Text = "답"
        Me.Answer.Width = 579
        '
        'Time
        '
        Me.Time.Text = "시간"
        '
        'logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.PrimeLogs)
        Me.Name = "logs"
        Me.Text = "logs"
        Me.PrimeLogs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrimeLogs As System.Windows.Forms.GroupBox
    Friend WithEvents PrimeFactorization As System.Windows.Forms.ListView
    Friend WithEvents Num As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
End Class
