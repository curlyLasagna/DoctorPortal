Public Class MainMenu

    Private Sub AboutMe_Click(sender As Object, e As EventArgs) Handles AboutMe_Button.Click
        ' Thanks to https://www.youtube.com/watch?v=sIoa6PLUsAY&t=343s for sharing this method of 
        ' adding a drop down
        Timer1.Start()
        ' Set AboutMeSubMenu panel to 0 to hide the 
        ' expanded contents
        If Not AboutMeSubMenu.Height = 0 Then
            AboutMeSubMenu.Height = 0
            ' Clicking 'About me' again will hide the
            ' expanded menu
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' When 'About me' button is clicked, this sets the
        ' AboutMeSubMenu to this height to show it
        AboutMeSubMenu.Height = 143
        Timer1.Stop()
    End Sub

    ' Exit button
    Private Sub closeApp(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub home_monitoring_click(sender As Object, e As EventArgs) Handles homeMonitoring_btn.Click
        Home_Monitoring.Show()
        Me.Close()
    End Sub

    Private Sub pharmacy_click(sender As Object, e As EventArgs) Handles prescription_btn.Click
        MedicationRefilling.Show()
        Me.Close()
    End Sub

    ' Open pharmacy form when clicked
    Private Sub show_phar_label(sender As Object, e As EventArgs) Handles phar_info.Click
        pharm_main.Show()
        Me.Close()
    End Sub

    Private Sub show_medical_history_label(sender As Object, e As EventArgs) Handles med_history_label.Click
        MedHx.Show()
        Me.Close()
    End Sub

    Private Sub bill_show_click(sender As Object, e As EventArgs) Handles billing_btn.Click
        bill_info.Show()
        Me.Hide()
    End Sub

    Private Sub show_med_record_click(sender As Object, e As EventArgs) Handles med_record.Click
        MedRecordRequest.Show()
        Me.Close()
    End Sub

    Private Sub insurance_info_click(sender As Object, e As EventArgs) Handles ins_info.Click
        ins_main.Show()
        Me.Close()
    End Sub

    Private Sub client_info_click(sender As Object, e As EventArgs) Handles client_info.Click
        AccountInfo.Show()
        Me.Close()
    End Sub

End Class
