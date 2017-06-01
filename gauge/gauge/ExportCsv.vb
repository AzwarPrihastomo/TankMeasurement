Public Class ExportCsv

    Private Sub ChkTodayLevel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkToday.CheckedChanged
        If ChkToday.Checked Then
            datepicker.Enabled = False
            DtStart.Value = Now
            DtEnd.Value = Now
        Else
            datepicker.Enabled = True
        End If
    End Sub

    Private Sub ExportCsv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtStart.Value = Now
        DtEnd.Value = Now
        fieldSelect.Select()
    End Sub

    Private Sub btExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExport.Click
        'If fieldSelect.Text = "" Then
        'MessageBox.Show("please select field first", "Field not select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ' Else
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class