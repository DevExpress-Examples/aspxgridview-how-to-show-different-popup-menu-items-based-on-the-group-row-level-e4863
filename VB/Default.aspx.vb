Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub ASPxCallback1_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs)

        Dim param() As String = e.Parameter.Split("|"c)
        Dim index As Integer = Convert.ToInt32(param(0))


        'if (gridView.GetRowLevel(index) == 1)
        '    ASPxPopupMenu1.Items.FindByName("Item2").ClientEnabled = false;
        'else
        '    ASPxPopupMenu1.Items.FindByName("Item2").ClientEnabled = true;
        param(0) = gridView.GetRowLevel(index).ToString()

        e.Result = String.Format("{0}|{1}|{2}", param) '[0],param[1],param[2]
    End Sub
End Class