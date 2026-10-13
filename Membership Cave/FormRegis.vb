Public Class FormRegis
    Public Sub ClearForm()
        txtNama.Clear()
        txtNoHp.Clear()
        rbLanang.Checked = False
        rbBetina.Checked = False
        dtpTanggalLahir.Value = DateTime.Now
        chkKartuFisik.Checked = False
        chkKartuDigital.Checked = False
        cmbJenisMembership.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialogHasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mengosongkan form?", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogHasil = DialogResult.Yes Then
            ClearForm()
        End If
    End Sub

    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtNoHp.Text) Then
            MessageBox.Show("Nama Lengkap dan No. HP wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not rbLanang.Checked AndAlso Not rbBetina.Checked Then
            MessageBox.Show("Silakan pilih Jenis Kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbJenisMembership.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Jenis Membership!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nama As String = txtNama.Text
        Dim noHp As String = txtNoHp.Text
        Dim tglLahir As String = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")

        Dim jenisKelamin As String = ""
        If rbLanang.Checked Then
            jenisKelamin = "Lanang"
        ElseIf rbBetina.Checked Then
            jenisKelamin = "Betina"
        End If

        Dim jenisMembership As String = cmbJenisMembership.SelectedItem.ToString()

        Dim jenisKartu As String = ""
        If chkKartuFisik.Checked Then jenisKartu &= "Kartu Fisik "
        If chkKartuDigital.Checked Then jenisKartu &= "Kartu Digital "

        If String.IsNullOrEmpty(jenisKartu) Then
            jenisKartu = "Tanpa Kartu"
        End If

        Dim pesan As String = $"Nama Lengkap    : {nama}" & vbCrLf &
                               $"No. HP          : {noHp}" & vbCrLf &
                               $"Tanggal Lahir   : {tglLahir}" & vbCrLf &
                               $"Jenis Kelamin   : {jenisKelamin}" & vbCrLf &
                               $"Jenis Membership: {jenisMembership}" & vbCrLf &
                               $"Jenis Kartu     : {jenisKartu}"


        MessageBox.Show(pesan, "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
