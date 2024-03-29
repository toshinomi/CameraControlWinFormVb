﻿Imports AForge.Video
Imports AForge.Video.DirectShow

''' <summary>
''' MainFormのロジック
''' </summary>
Public Class FromMain
    Private m_mousePoint As Point
    Private m_isDeviceExist As Boolean = False
    Private m_videoDevices As FilterInfoCollection
    Private m_videoSource As VideoCaptureDevice = Nothing

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler lblTitle.MouseDown, AddressOf OnMouseDownLblTitle
        AddHandler lblTitle.MouseMove, AddressOf OnMouseMoveLblTitle

        GetCameraInfo()

    End Sub

    ''' <summary>
    ''' タイトルバーマウスダウンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnMouseDownLblTitle(sender As Object, e As MouseEventArgs)
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            m_mousePoint = New Point(e.X, e.Y)
        End If

        Return
    End Sub

    ''' <summary>
    ''' タイトルバーマウスムーブのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnMouseMoveLblTitle(sender As Object, e As MouseEventArgs)
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            Me.Left += e.X - m_mousePoint.X
            Me.Top += e.Y - m_mousePoint.Y
        End If

        Return
    End Sub

    ''' <summary>
    ''' 閉じるボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnClose(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (result = DialogResult.OK) Then
            OnClickBtnStop(Nothing, Nothing)
            Me.Close()
        End If

        Return
    End Sub

    ''' <summary>
    ''' 最小化ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnMinimizedIcon(sender As Object, e As EventArgs) Handles btnMinimizedIcon.Click
        Me.WindowState = FormWindowState.Minimized

        Return
    End Sub

    ''' <summary>
    ''' カメラ情報取得のクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnGetCameraInfo(sender As Object, e As EventArgs) Handles btnGetCameraInfo.Click
        GetCameraInfo()

        Return
    End Sub

    ''' <summary>
    ''' カメラ情報取得
    ''' </summary>
    Private Sub GetCameraInfo()
        Try
            m_videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            cmbCamera.Items.Clear()

            If (m_videoDevices.Count <= 0) Then
                Throw New ApplicationException()
            End If

            For Each device As FilterInfo In m_videoDevices
                cmbCamera.Items.Add(device.Name)
                cmbCamera.SelectedIndex = 0
                m_isDeviceExist = True
            Next
        Catch ex As ApplicationException
            cmbCamera.Items.Add("Device does not exist")
            m_isDeviceExist = False
        End Try

        Return
    End Sub

    ''' <summary>
    ''' スタートボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnStart(sender As Object, e As EventArgs) Handles btnStart.Click
        If (m_isDeviceExist) Then
            m_videoSource = New VideoCaptureDevice(m_videoDevices(cmbCamera.SelectedIndex).MonikerString)
            AddHandler m_videoSource.NewFrame, AddressOf VideoRendering
            CloseVideoSource()

            m_videoSource.Start()
        End If

        Return
    End Sub

    ''' <summary>
    ''' ストップボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnStop(sender As Object, e As EventArgs) Handles btnStop.Click
        If (m_videoSource IsNot Nothing) Then
            If (m_videoSource.IsRunning) Then
                CloseVideoSource()
            End If
        End If

        Return
    End Sub

    ''' <summary>
    ''' ビデオ描画
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="eventArgs">NewFrameEventのデータ</param>
    Private Sub VideoRendering(sender As Object, eventArgs As NewFrameEventArgs)
        Dim bitmap As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
        pictureBox.Image = bitmap

        Return
    End Sub

    ''' <summary>
    ''' ビデオリソースの終了
    ''' </summary>
    Private Sub CloseVideoSource()
        If (m_videoSource IsNot Nothing) Then
            If (m_videoSource.IsRunning) Then
                m_videoSource.SignalToStop()
                m_videoSource = Nothing
            End If
        End If

        Return
        End Sub
End Class
