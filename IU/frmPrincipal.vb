Public Class frmPrincipal

    Dim estado As Boolean = False

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click

        'Dim lista As ListViewItem = New ListViewItem("Comando correcto!")
        'With lista
        '    .SubItems.Add("Comando correcto!")
        '    .SubItems.Add(Me.txtComandos.Text)
        '    .SubItems.Add(DateTime.Now)
        'End With
        'lsvLogs.Items.Add(lista)

        ejecutarComandos()

        If estado = True Then
            'MsgBox("Comando Correcto!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensaje del Sistema")
        Else
            MsgBox("Comando Incorrecto!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Mensaje del Sistema")
        End If

        estado = False
        Me.txtComandos.Clear()
        Me.txtComandos.Focus()
    End Sub

#Region "LLAMADAS"

    Sub llamarAbout()
        estado = True
        frmAbout.ShowDialog()
    End Sub

    Sub llamarMouse()
        estado = True
        Process.Start("main.cpl")
    End Sub

    Sub llamarPanelControl()
        estado = True
        Process.Start("control")
    End Sub

    Sub llamarCmd()
        estado = True
        Process.Start("cmd.exe")
    End Sub

    Sub llamarCalculadora()
        estado = True
        Process.Start("calc.exe")
    End Sub

    Sub llamarReproductor()
        estado = True
        Process.Start("wmplayer.exe")
    End Sub

    Sub llamarWord()
        estado = True
        Process.Start("Winword.exe")
    End Sub
    Sub llamarExcel()
        estado = True
        Process.Start("Excel.exe")
    End Sub
    Sub llamarPowerPoint()
        estado = True
        Process.Start("PowerPnt")
    End Sub
    Sub llamarAccess()
        estado = True
        Process.Start("MsAccess.exe")
    End Sub
    Sub llamarChrome()
        estado = True
        Process.Start("Chrome.exe")
    End Sub

    Sub llamarFacebook()
        estado = True
        System.Diagnostics.Process.Start("https://www.facebook.com")
    End Sub

    Sub llamarWhatsApp()
        estado = True
        System.Diagnostics.Process.Start("https://web.whatsapp.com/")
    End Sub
    Sub llamarGmail()
        estado = True
        System.Diagnostics.Process.Start("https://mail.google.com")
    End Sub

    Sub llamarYoutube()
        estado = True
        System.Diagnostics.Process.Start("https://youtube.com")
    End Sub
    Sub llamarWikipedia()
        estado = True
        System.Diagnostics.Process.Start("https://es.wikipedia.org")
    End Sub

    Sub llamarHotmail()
        estado = True
        System.Diagnostics.Process.Start("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=12&ct=1464752696&rver=6.4.6456.0&wp=MBI_SSL_SHARED&wreply=https:%2F%2Fsnt147.mail.live.com%2Fdefault.aspx%3Frru%3Dinbox&lc=3082&id=64855&mkt=es-es&cbcxt=mai")
    End Sub

    Sub llamarGoogle()
        estado = True
        System.Diagnostics.Process.Start("https://www.google.com")
    End Sub

    Sub llamarRincon()
        estado = True
        System.Diagnostics.Process.Start("http://www.rincondelvago.com/")
    End Sub

    Sub llamarTwitter()
        estado = True
        System.Diagnostics.Process.Start("https://twitter.com/?lang=es")
    End Sub

    Sub llamarNetflix()
        estado = True
        System.Diagnostics.Process.Start("https://www.netflix.com/pe/")
    End Sub

    Sub llamarFirefox()
        estado = True
        Process.Start("Firefox.exe")
    End Sub

    Sub llamarProgramas()
        estado = True
        Process.Start("appwiz.cpl")
    End Sub

    Sub llamarLupa()
        estado = True
        Process.Start("magnify")
    End Sub

    Sub llamarBlockNotas()
        estado = True
        Process.Start("notepad")
    End Sub

    Sub llamarWorpad()
        estado = True
        Process.Start("write")
    End Sub

    Sub llamarConfigCarpeta()
        estado = True
        Process.Start("control folders")
    End Sub

    Sub llamarControlUsuarios()
        estado = True
        Process.Start("control userpasswords2")
    End Sub

    Sub llamarPaint()
        estado = True
        Process.Start("mspaint")
    End Sub

    Sub llamarApagar()
        estado = True
        Process.Start("SHUTDOWN")
    End Sub

    Sub llamarOutlook()
        estado = True
        Process.Start("outlook")
    End Sub

    Sub llamarImpresoras()
        estado = True
        Process.Start("control printers")
    End Sub

    Sub llamarInternetExplorer()
        estado = True
        Process.Start("iexplore")
    End Sub

#End Region

#Region "CONDICIONALES"
    Sub ejecutarComandos()
        Dim comandos As String
        comandos = Me.txtComandos.Text.Trim

        Select Case comandos
            Case "FACEBOOK"
                llamarFacebook()
            Case "WORD"
                llamarWord()
            Case "EXCEL"
                llamarExcel()
            Case "CHROME"
                llamarChrome()
            Case "ACCESS"
                llamarAccess()
            Case "CHROME"
                llamarChrome()
            Case "WHATSAPP"
                llamarWhatsApp()
            Case "GMAIL"
                llamarGmail()
            Case "HOTMAIL"
                llamarHotmail()
            Case "FIREFOX"
                llamarFirefox()
            Case "REPRODUCTOR WINDOWS"
                llamarReproductor()
            Case "CALCULADORA"
                llamarCalculadora()
            Case "CMD"
                llamarCmd()
            Case "PROGRAMAS"
                llamarProgramas()
            Case "MOUSE"
                llamarMouse()
            Case "PANEL DE CONTROL"
                llamarPanelControl()
            Case "LUPA"
                llamarLupa()
            Case "BLOCK DE NOTAS"
                llamarBlockNotas()
            Case "WORDPAD"
                llamarWorpad()
            Case "CARPETAS"
                llamarConfigCarpeta()
            Case "USUARIOS"
                llamarControlUsuarios()
            Case "PAINT"
                llamarPaint()
            Case "YOUTUBE"
                llamarYoutube()
            Case "WIKIPEDIA"
                llamarWikipedia()
            Case "TWITTER"
                llamarTwitter()
            Case "GOOGLE"
                llamarGoogle()
            Case "POWER POINT"
                llamarPowerPoint()
            Case "NETFLIX"
                llamarNetflix()
            Case "APAGAR"
                llamarApagar()
            Case "ACERCA DE"
                llamarAbout()
            Case "ABOUT"
                llamarAbout()
            Case "IMPRESORAS"
                llamarImpresoras()
            Case "INTERNET EXPLORER"
                llamarInternetExplorer()
            Case "RINCON DEL VAGO"
                llamarRincon()
        End Select
    End Sub
#End Region

End Class
