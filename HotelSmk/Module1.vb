Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Ds As DataSet
    Public Cmd As SqlCommand
    Public Mydb As String = "data source=DESKTOP-2DSHPCD;initial catalog=hotels;integrated security=true;"


    Public Class PrivMeth
        Public Shared Iduser, id As String
    End Class
    Public Sub Koneksi()
        Conn = New SqlConnection(Mydb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Function dialog(txt As String)
        Dim Dialogresl As DialogResult = MessageBox.Show(txt, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Dialogresl = DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function
    Function closeForm()
        End
    End Function
    Public Sub tampil(frm As Form)
        frm.TopLevel = False
        FrmMainOffice.Panel3.Controls.Add(frm)
        frm.Show()
    End Sub

    Public Sub sembunyi()
        FrmMasterRoomType.Close()
        FrmOfficeDashboard.Close()
        FrmOfficeDashboardRoom.Close()
        FrmEditorRoomType.Close()
        FrmMasterRoom.Close()
        FrmEditorRoom.Close()
        FrmTestChart.Close()
    End Sub

    Public Sub onlynumber(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Module
