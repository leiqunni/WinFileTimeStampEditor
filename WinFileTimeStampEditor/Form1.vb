Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Get_DateTime(CType(e.Data.GetData(DataFormats.FileDrop, False), String())(0))
    End Sub

    Private Sub Form1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        'コントロール内にドラッグされたとき実行される
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Get_DateTime(ByVal path As String)
        If IO.File.Exists(path) = False Then
            MsgBox("File not found.")
            Return
        End If

        Dim dt As DateTime

        txtPath.Text = path

        dt = IO.File.GetCreationTime(path)
        lblCreatedDateTime.Text = dt.ToString("yyyy/MM/dd HH:mm:ss")
        dtpCreated.Value = dt

        dt = IO.File.GetLastWriteTime(path)
        lblModifiedDateTime.Text = dt.ToString("yyyy/MM/dd HH:mm:ss")
        dtpModified.Value = dt

        dt = IO.File.GetLastAccessTime(path)
        lblLastAccessedDateTime.Text = dt.ToString("yyyy/MM/dd HH:mm:ss")
        dtpLastAccessed.Value = dt

        Dim fi = New IO.FileInfo(path)
        Dim len = fi.Length
        lblSizeF.Text = String.Format("{0:#,0} Bytes", len)
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Get_DateTime(txtPath.Text)
    End Sub

    Private Sub txtPath_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPath.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Get_DateTime(txtPath.Text)
        End Select
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Set_DateTime(txtPath.Text)
        Get_DateTime(txtPath.Text)
    End Sub

    Private Sub Set_DateTime(ByVal path As String)
        If IO.File.Exists(path) = False Then
            MsgBox("File not found.")
            Return
        End If

        Dim dt As DateTime

        dt = dtpCreated.Value
        IO.File.SetCreationTime(path, dt)

        dt = dtpModified.Value
        IO.File.SetLastWriteTime(path, dt)

        dt = dtpLastAccessed.Value
        IO.File.SetLastAccessTime(path, dt)
    End Sub

End Class
