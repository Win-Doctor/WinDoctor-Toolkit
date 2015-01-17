Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

#Region "Fix Registro"
#Region "Costanti"
    Private Const HKU As String = "HKEY_USER\"
    Private Const HKCU As String = "HKEY_CURRENT_USER\"
    Private Const HKLM As String = "HKEY_LOCAL_MACHINE\"
#End Region
#Region "Abilita Gestione Attività"
    Private Const TASKMGR_ENABLE As String = TASKMGR_KEY + " /v " + TASKMGR_VALUE + " /t REG_DWORD /d 0 /f"
    Private Const TASKMGR_KEY As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
    Private Const TASKMGR_VALUE As String = "DisableTaskMgr"

    Private Sub Ripristina_TaskManager_Click(sender As Object, e As EventArgs) Handles Ripristina_TaskManager.Click
        Process.Start("reg", "add " & HKCU & TASKMGR_ENABLE)
        Process.Start("reg", "add " & HKLM & TASKMGR_ENABLE)

    End Sub

#End Region
#End Region


    Private Sub BtnEseguiManualmente_Click(sender As Object, e As EventArgs) Handles BtnEseguiManualmente.Click
        Dim a
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Verranno Eseguite le seguenti azioni:" & vbCrLf & TextBox1.Text & vbCrLf & "Continuare?"
        style = MsgBoxStyle.YesNo
        title = "Conferma"
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            a = Split(TextBox1.Text, vbCrLf)
            For Each s As String In a
                ListaScript.Items.Add(s)
            Next

            ListaScript.SelectedIndex = 0
            For i = 1 To ListaScript.Items.Count Step 1


                If ListaScript.SelectedItem.ToString = "File::" Then
                    ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    While (Not (ListaScript.SelectedItem.ToString.Contains("::")))
                        If Not (ListaScript.SelectedItem.ToString = "") Then
                            ListaFile.Items.Add(ListaScript.SelectedItem.ToString)
                        End If
                        ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    End While
                End If

                If ListaScript.SelectedItem.ToString = "Folder::" Then
                    ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    While (Not (ListaScript.SelectedItem.ToString.Contains("::")))
                        If Not (ListaScript.SelectedItem.ToString = "") Then
                            ListaFolder.Items.Add(ListaScript.SelectedItem.ToString)
                        End If
                        ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    End While
                End If

                If ListaScript.SelectedItem.ToString = "Termina::" Then
                    ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    While (Not (ListaScript.SelectedItem.ToString.Contains("::")))
                        If Not (ListaScript.SelectedItem.ToString = "") Then
                            ListaTermina.Items.Add(ListaScript.SelectedItem.ToString)
                        End If
                        ListaScript.SelectedIndex = ListaScript.SelectedIndex + 1
                    End While
                End If
            Next

            'Elimina i File
            For i = 0 To ListaFile.Items.Count - 1 Step 1
                ListaFile.SelectedIndex = i
                IO.File.Delete(ListaFile.SelectedItem.ToString)
            Next
            'Elimina Cartelle
            For i = 0 To ListaFolder.Items.Count - 1 Step 1
                ListaFolder.SelectedIndex = i
                IO.Directory.Delete(ListaFolder.SelectedItem.ToString)
            Next
            'Termina Processi
            For i = 0 To ListaTermina.Items.Count - 1 Step 1
                ListaTermina.SelectedIndex = i
                For Each p As Process In Process.GetProcesses
                    If p.ProcessName = ListaTermina.SelectedItem.ToString Then
                        p.Kill()
                    End If
                Next
                BtnAggiornaProcessi.PerformClick()
            Next
        Else

        End If
        TxtPastebin.Text = ""
    End Sub

    Private Sub BtnEsegui_Click(sender As Object, e As EventArgs) Handles BtnEsegui.Click
        Dim webClient As New System.Net.WebClient
        Dim Script As String = webClient.DownloadString("http://pastebin.com/raw.php?i=" & TxtPastebin.Text)
        TextBox1.Text = Script
        BtnEseguiManualmente.PerformClick()
    End Sub
#Region "Ripristina Rete"
    Private Sub Ripristina_Rete_Click(sender As Object, e As EventArgs) Handles Ripristina_Rete.Click
        Shell("netsh winsock reset catalog")
        Threading.Thread.Sleep(500)
        Shell("netsh int ip reset resetlog.txt")
        Threading.Thread.Sleep(500)
        Shell("net start dnscache")
        Threading.Thread.Sleep(500)
        Shell("ipconfig /flushdns")
        Threading.Thread.Sleep(500)
        Shell("netsh winhttp reset proxy")
    End Sub
#End Region
#Region "Ripristina Firewall"
    Private Sub Ripristina_Firewall_Click(sender As Object, e As EventArgs) Handles Ripristina_Firewall.Click
        Shell("netsh advfirewall reset")
    End Sub
#End Region
#Region "Ripristina Windows Update"
    Private Sub Ripristina_Update_Click(sender As Object, e As EventArgs) Handles Ripristina_Update.Click
        Shell("netsh reset winsock")
        Threading.Thread.Sleep(1000)
        Shell("net stop wuauserv")
        Threading.Thread.Sleep(1000)
        Shell("net stop bits")
        Threading.Thread.Sleep(1000)
        Shell("ren %systemroot%\SoftwareDistribution\Download %systemroot%\SoftwareDistribution\Download.old")
        Threading.Thread.Sleep(1000)
        Shell("net start wuauserv")
        Threading.Thread.Sleep(1000)
        Shell("net start bits ")
        Threading.Thread.Sleep(1000)
        MsgBox("Riavviare Il PC per completare L'operazione")
    End Sub
#End Region
#Region "Ripristina File Hosts"
    Private Sub Ripristina_Hosts_Click(sender As Object, e As EventArgs) Handles Ripristina_Hosts.Click
        Shell("COPY data\fix\hosts C:\Windows\System32\drivers\etc\hosts /Y")
    End Sub
#End Region

    Private Sub BtnTermina_Click(sender As Object, e As EventArgs) Handles BtnTermina.Click

        For Each p As Process In Process.GetProcesses

            If p.ProcessName = ListaProcessi.SelectedItem Then
                p.Kill()
            End If
        Next
        BtnAggiornaProcessi.PerformClick()

    End Sub

    Private Sub BtnAggiornaProcessi_Click(sender As Object, e As EventArgs) Handles BtnAggiornaProcessi.Click
        ListaProcessi.Items.Clear()
        For Each p As Process In Process.GetProcesses
            ListaProcessi.Items.Add(p.ProcessName.ToString)
        Next
    End Sub
End Class

