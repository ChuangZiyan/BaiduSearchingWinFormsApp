<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Webview2Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainWebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWebView2
        '
        Me.MainWebView2.AllowExternalDrop = True
        Me.MainWebView2.CreationProperties = Nothing
        Me.MainWebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.MainWebView2.Location = New System.Drawing.Point(12, 12)
        Me.MainWebView2.Name = "MainWebView2"
        Me.MainWebView2.Size = New System.Drawing.Size(776, 426)
        Me.MainWebView2.Source = New System.Uri("https://www.google.com/", System.UriKind.Absolute)
        Me.MainWebView2.TabIndex = 0
        Me.MainWebView2.ZoomFactor = 1.0R
        '
        'Webview2Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainWebView2)
        Me.Name = "Webview2Form"
        Me.Text = "Webview2Form"
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWebView2 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
