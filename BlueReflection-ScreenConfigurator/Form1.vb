Imports System.IO

Public Class Form1
    'Global Stuff
    Dim BR_Game As String = ""
    Dim ARHexValue As UInt32 = 0

    Private Sub btnLoadEXE_Click(sender As Object, e As EventArgs) Handles btnLoadEXE.Click
        Dim BREXE = ""
        If ofdBREXE.ShowDialog = DialogResult.OK Then
            BREXE = ofdBREXE.FileName
            txtLoadedEXE.Text = BREXE
        End If

        'Check If Unpacked
        If CheckifSteamless() <> 0 Then
            MessageBox.Show("EXE is not unpacked.. Please use STEAMLESS DRM Remover to unpack then try again.")
            txtLoadedEXE.Clear()
            Exit Sub
        End If

        'Get Game
        If Path.GetFileNameWithoutExtension(BREXE).ToLower.Contains("second light") Then
            BR_Game = "BR2"
        Else
            BR_Game = "BR"
        End If

        'Get INI Config
        Get_INI_Config()
    End Sub

    'Get/Check Functions
    Public Function CheckifSteamless()
        Using br As BinaryReader = New BinaryReader(File.Open(txtLoadedEXE.Text, FileMode.Open))
            br.BaseStream.Seek(&H40, SeekOrigin.Begin)
            Dim checkbytes = br.ReadUInt32
            Return checkbytes
        End Using
    End Function
    Public Function Get_INI_Config()
        Dim BRINILocation = Environment.GetEnvironmentVariable("USERPROFILE") & "\Documents\KoeiTecmo\BLUE REFLECTION\BRsetting.ini"
        Dim BR2INILocation = Environment.GetEnvironmentVariable("USERPROFILE") & "\Documents\KoeiTecmo\BLUE REFLECTION Second Light\Setting.ini"

        'Check If Onedrive Folder
        If File.Exists(BRINILocation) = False Then
            If File.Exists(BR2INILocation) = False Then
                BRINILocation = Environment.GetEnvironmentVariable("OneDriveConsumer") & "\Documents\KoeiTecmo\BLUE REFLECTION\BRsetting.ini"
                BR2INILocation = Environment.GetEnvironmentVariable("OneDriveConsumer") & "\Documents\KoeiTecmo\BLUE REFLECTION Second Light\Setting.ini"
            End If
        End If

        Select Case BR_Game
            Case "BR"
                If File.Exists(BRINILocation) = False Then
                    MessageBox.Show("Cannot locate Blue Reflection Settings INI (BRsettings.ini)")
                    Exit Function
                End If

                Dim BRFilesLines = File.ReadAllLines(BRINILocation)
                Dim ScreenWidth = BRFilesLines(1).Split("=")(1)
                Dim ScreenHeight = BRFilesLines(2).Split("=")(1)
                Dim AntiQuality = BRFilesLines(3).Split("=")(1)
                Dim DepthofField = BRFilesLines(4).Split("=")(1)
                Dim FullScreen = BRFilesLines(6).Split("=")(1)

                txtScreenHeight.Text = ScreenHeight
                txtScreenWidth.Text = ScreenWidth
                If FullScreen = 0 Then
                    chkbxFullscreen.Checked = False
                Else
                    chkbxFullscreen.Checked = True
                End If

                If DepthofField = 0 Then
                    chkbxDepthofField.Checked = False
                Else
                    chkbxDepthofField.Checked = True
                End If
            Case "BR2"
                If File.Exists(BR2INILocation) = False Then
                    MessageBox.Show("Cannot locate Blue Reflection 2 Settings INI (BRsettings.ini)")
                    Exit Function
                End If
        End Select
    End Function
    Private Sub cbxPreset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPreset.SelectedIndexChanged
        txtScreenWidth.Clear()
        txtScreenHeight.Clear()
        cbxPreset.Text = ""
        Select Case cbxPreset.SelectedIndex
            Case 0
                txtScreenWidth.Text = "1280"
                txtScreenHeight.Text = "720"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 1
                txtScreenWidth.Text = "1366"
                txtScreenHeight.Text = "768"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 2
                txtScreenWidth.Text = "1600"
                txtScreenHeight.Text = "900"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 3
                txtScreenWidth.Text = "1920"
                txtScreenHeight.Text = "1080"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 4
                txtScreenWidth.Text = "2560"
                txtScreenHeight.Text = "1440"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 5
                txtScreenWidth.Text = "3840"
                txtScreenHeight.Text = "2160"
                cbxAspectRatio.SelectedIndex = 3
                ARHexValue = 1071877689
            Case 6
                txtScreenWidth.Text = "2560"
                txtScreenHeight.Text = "1080"
                cbxAspectRatio.SelectedIndex = 5
                ARHexValue = 1075295270
            Case 7
                txtScreenWidth.Text = "3440"
                txtScreenHeight.Text = "1440"
                cbxAspectRatio.SelectedIndex = 5
                ARHexValue = 1075372942
            Case 8
                txtScreenWidth.Text = "3840"
                txtScreenHeight.Text = "1600"
                cbxAspectRatio.SelectedIndex = 5
                ARHexValue = 1075419546
            Case 9
                txtScreenWidth.Text = "5120"
                txtScreenHeight.Text = "2160"
                cbxAspectRatio.SelectedIndex = 5
                ARHexValue = 1075295270
            Case 10
                txtScreenWidth.Text = "3840"
                txtScreenHeight.Text = "1080"
                cbxAspectRatio.SelectedIndex = 6
                ARHexValue = 1080266297
            Case 11
                txtScreenWidth.Text = "5120"
                txtScreenHeight.Text = "1440"
                cbxAspectRatio.SelectedIndex = 6
                ARHexValue = 1080266297
            Case 12
                txtScreenWidth.Text = "7680"
                txtScreenHeight.Text = "2160"
                cbxAspectRatio.SelectedIndex = 6
                ARHexValue = 1080266297

        End Select
    End Sub
    Private Sub cbxAspectRatio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAspectRatio.SelectedIndexChanged
        Select Case cbxAspectRatio.SelectedIndex
            Case 0
                ARHexValue = 1067450368
            Case 1
                ARHexValue = 1068149419
            Case 2
                ARHexValue = 1069547520
            Case 3
                ARHexValue = 1071877689
            Case 4
                ARHexValue = 1070386381
            Case 5
                ARHexValue = 1075372942
            Case 6
                ARHexValue = 1080266297
        End Select
    End Sub

    'Write Functions
    Public Function WriteNewAspectRatio()
        Dim StartofARHexPOS
        Dim FoundARPOS = False
        Dim ARIntList As New List(Of Integer)
        ARIntList.Add(1067450368)
        ARIntList.Add(1068149419)
        ARIntList.Add(1069547520)
        ARIntList.Add(1071877689)
        ARIntList.Add(1070386381)
        ARIntList.Add(1075372942)
        ARIntList.Add(1080266297)

        If BR_Game = "BR" Then
            'Find the Start of Aspect Ratio
            Using br As BinaryReader = New BinaryReader(File.Open(txtLoadedEXE.Text, FileMode.Open))
                'First lets see if we know this spot already
                StartofARHexPOS = &H13CF010
                br.BaseStream.Seek(&H13CF010, SeekOrigin.Begin)
                br.BaseStream.Seek(16, SeekOrigin.Current)
                Dim checkbytes3 = br.ReadUInt32
                If checkbytes3 = 1380010051 Then
                    FoundARPOS = True
                End If

                'If we cant find the easy way we will try it manually.
                If FoundARPOS = False Then
                    While True
                        Dim CheckBytes = br.ReadUInt32
                        For Each AR In ARIntList
                            If CheckBytes = AR Then
                                Dim lastpos = br.BaseStream.Position
                                br.BaseStream.Seek(12, SeekOrigin.Current)
                                Dim checkbytes2 = br.ReadUInt32
                                If checkbytes2 = 1380010051 Then
                                    StartofARHexPOS = br.BaseStream.Position - 16
                                    Exit While
                                Else
                                    br.BaseStream.Seek(lastpos, SeekOrigin.Begin)
                                End If
                            End If
                        Next
                    End While
                End If
            End Using

            Using bw As BinaryWriter = New BinaryWriter(File.Open(txtLoadedEXE.Text, FileMode.Open))
                bw.BaseStream.Seek(StartofARHexPOS, SeekOrigin.Begin)
                bw.Write(ARHexValue)
            End Using
        ElseIf BR_Game = "BR2" Then

        End If

    End Function
    Public Function WriteNewResolution()
        Dim BRINILocation = Environment.GetEnvironmentVariable("USERPROFILE") & "\Documents\KoeiTecmo\BLUE REFLECTION\BRsetting.ini"
        Dim BR2INILocation = Environment.GetEnvironmentVariable("USERPROFILE") & "\Documents\KoeiTecmo\BLUE REFLECTION Second Light\Setting.ini"

        'Check If Onedrive Folder
        If File.Exists(BRINILocation) = False Then
            If File.Exists(BR2INILocation) = False Then
                BRINILocation = Environment.GetEnvironmentVariable("OneDriveConsumer") & "\Documents\KoeiTecmo\BLUE REFLECTION\BRsetting.ini"
                BR2INILocation = Environment.GetEnvironmentVariable("OneDriveConsumer") & "\Documents\KoeiTecmo\BLUE REFLECTION Second Light\Setting.ini"
            End If
        End If

        Select Case BR_Game
            Case "BR"
                If File.Exists(BRINILocation) = False Then
                    MessageBox.Show("Cannot locate Blue Reflection Settings INI (BRsettings.ini)")
                    Exit Function
                End If

                Dim BRFilesLines = File.ReadAllLines(BRINILocation)
                BRFilesLines(1) = "ScreenWidth=" & txtScreenWidth.Text
                BRFilesLines(2) = "ScreenHeight=" & txtScreenHeight.Text
                If chkbxFullscreen.Checked = True Then
                    BRFilesLines(6) = "FullScreen=1"
                Else
                    BRFilesLines(6) = "FullScreen=0"
                End If
                If chkbxDepthofField.Checked = True Then
                    BRFilesLines(4) = "DepthOfField=1"
                Else
                    BRFilesLines(4) = "DepthOfField=0"
                End If

                File.WriteAllLines(BRINILocation, BRFilesLines)

            Case "BR2"
                If File.Exists(BR2INILocation) = False Then
                    MessageBox.Show("Cannot locate Blue Reflection 2 Settings INI (BRsettings.ini)")
                    Exit Function
                End If
        End Select

    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If txtLoadedEXE.Text = "" Or txtScreenWidth.Text = "" Or txtScreenHeight.Text = "" Or cbxAspectRatio.Text = "" Then
            Exit Sub
        End If

        'Write New Aspect Ratio First
        WriteNewAspectRatio()

        'Write New ScreenWidth/Height
        WriteNewResolution()

        MessageBox.Show("Saved Changes!")
    End Sub
End Class
