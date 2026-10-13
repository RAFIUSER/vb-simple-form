<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        rbBetina = New RadioButton()
        rbLanang = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtNoHp = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        chkKartuDigital = New CheckBox()
        chkKartuFisik = New CheckBox()
        cmbJenisMembership = New ComboBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 31)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRASI MEMBERSHIP CAVE"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbBetina)
        GroupBox1.Controls.Add(rbLanang)
        GroupBox1.Controls.Add(dtpTanggalLahir)
        GroupBox1.Controls.Add(txtNoHp)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 95)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 225)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informasi Customer"
        ' 
        ' rbBetina
        ' 
        rbBetina.AutoSize = True
        rbBetina.Location = New Point(212, 175)
        rbBetina.Name = "rbBetina"
        rbBetina.Size = New Size(72, 24)
        rbBetina.TabIndex = 4
        rbBetina.TabStop = True
        rbBetina.Text = "Betina"
        rbBetina.UseVisualStyleBackColor = True
        ' 
        ' rbLanang
        ' 
        rbLanang.AutoSize = True
        rbLanang.Location = New Point(128, 173)
        rbLanang.Name = "rbLanang"
        rbLanang.Size = New Size(78, 24)
        rbLanang.TabIndex = 4
        rbLanang.TabStop = True
        rbLanang.Text = "Lanang"
        rbLanang.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(117, 124)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(317, 27)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' txtNoHp
        ' 
        txtNoHp.Location = New Point(76, 78)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.Size = New Size(358, 27)
        txtNoHp.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 0
        Label4.Text = "Jenis Kelamin :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 129)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 0
        Label6.Text = "Tanggal Lahir :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(128, 35)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(306, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 0
        Label3.Text = "No. Hp :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama Lengkap :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chkKartuDigital)
        GroupBox2.Controls.Add(chkKartuFisik)
        GroupBox2.Controls.Add(cmbJenisMembership)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(12, 349)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(457, 146)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Detail Membership"
        ' 
        ' chkKartuDigital
        ' 
        chkKartuDigital.AutoSize = True
        chkKartuDigital.Location = New Point(212, 81)
        chkKartuDigital.Name = "chkKartuDigital"
        chkKartuDigital.Size = New Size(115, 24)
        chkKartuDigital.TabIndex = 6
        chkKartuDigital.Text = "Kartu Digital"
        chkKartuDigital.UseVisualStyleBackColor = True
        ' 
        ' chkKartuFisik
        ' 
        chkKartuFisik.AutoSize = True
        chkKartuFisik.Location = New Point(99, 81)
        chkKartuFisik.Name = "chkKartuFisik"
        chkKartuFisik.Size = New Size(98, 24)
        chkKartuFisik.TabIndex = 6
        chkKartuFisik.Text = "Kartu Fisik"
        chkKartuFisik.UseVisualStyleBackColor = True
        ' 
        ' cmbJenisMembership
        ' 
        cmbJenisMembership.FormattingEnabled = True
        cmbJenisMembership.Items.AddRange(New Object() {"VIP Bronze", "VVIP Silver", "XVIP Diamond"})
        cmbJenisMembership.Location = New Point(146, 38)
        cmbJenisMembership.Name = "cmbJenisMembership"
        cmbJenisMembership.Size = New Size(288, 28)
        cmbJenisMembership.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 0
        Label8.Text = "Jenis Kartu"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(134, 20)
        Label9.TabIndex = 0
        Label9.Text = "Jenis Membership :"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 538)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(457, 69)
        Panel1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(189, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 29)
        Button2.TabIndex = 0
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(302, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 29)
        Button1.TabIndex = 0
        Button1.Text = "Konfirmasi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormRegis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 619)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "FormRegis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbLanang As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents rbBetina As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbJenisMembership As ComboBox
    Friend WithEvents chkKartuDigital As CheckBox
    Friend WithEvents chkKartuFisik As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
