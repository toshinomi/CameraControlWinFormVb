<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.btnGetCameraInfo = New System.Windows.Forms.Button()
        Me.lblCameraList = New System.Windows.Forms.Label()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.btnMinimizedIcon = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(713, 65)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 37)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(632, 65)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 37)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pictureBox
        '
        Me.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox.Location = New System.Drawing.Point(12, 113)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(776, 476)
        Me.pictureBox.TabIndex = 15
        Me.pictureBox.TabStop = False
        '
        'btnGetCameraInfo
        '
        Me.btnGetCameraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetCameraInfo.Location = New System.Drawing.Point(332, 65)
        Me.btnGetCameraInfo.Name = "btnGetCameraInfo"
        Me.btnGetCameraInfo.Size = New System.Drawing.Size(72, 37)
        Me.btnGetCameraInfo.TabIndex = 13
        Me.btnGetCameraInfo.Text = "Get"
        Me.btnGetCameraInfo.UseVisualStyleBackColor = True
        '
        'lblCameraList
        '
        Me.lblCameraList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCameraList.Location = New System.Drawing.Point(12, 40)
        Me.lblCameraList.Name = "lblCameraList"
        Me.lblCameraList.Size = New System.Drawing.Size(174, 27)
        Me.lblCameraList.TabIndex = 14
        Me.lblCameraList.Text = "Camera List"
        '
        'cmbCamera
        '
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCamera.FormattingEnabled = True
        Me.cmbCamera.Location = New System.Drawing.Point(12, 70)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(314, 28)
        Me.cmbCamera.TabIndex = 12
        '
        'btnMinimizedIcon
        '
        Me.btnMinimizedIcon.BackColor = System.Drawing.Color.Black
        Me.btnMinimizedIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizedIcon.ForeColor = System.Drawing.Color.White
        Me.btnMinimizedIcon.Location = New System.Drawing.Point(739, 1)
        Me.btnMinimizedIcon.Name = "btnMinimizedIcon"
        Me.btnMinimizedIcon.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizedIcon.TabIndex = 11
        Me.btnMinimizedIcon.TabStop = False
        Me.btnMinimizedIcon.Text = "-"
        Me.btnMinimizedIcon.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(770, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "×"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(0, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(800, 30)
        Me.lblTitle.TabIndex = 7
        '
        'FromMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.btnGetCameraInfo)
        Me.Controls.Add(Me.lblCameraList)
        Me.Controls.Add(Me.cmbCamera)
        Me.Controls.Add(Me.btnMinimizedIcon)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FromMain"
        Me.Text = "Form1"
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Private WithEvents pictureBox As PictureBox
    Private WithEvents btnGetCameraInfo As Button
    Private WithEvents lblCameraList As Label
    Private WithEvents cmbCamera As ComboBox
    Private WithEvents btnMinimizedIcon As Button
    Private WithEvents btnClose As Button
    Private WithEvents lblTitle As Label
End Class
