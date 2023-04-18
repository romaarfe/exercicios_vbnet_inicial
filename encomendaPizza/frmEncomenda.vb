Public Class frmEncomenda
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valorInicial As Double
        Dim valorFinal As Double
        Dim precoPizza As Double
        Dim quantidade As Double

        quantidade = CInt(txtQuantidade.Text)

        If cbxPizza.SelectedIndex = 0 Then
            precoPizza = 6
        End If

        If cbxPizza.SelectedIndex = 1 Then
            precoPizza = 7
        End If

        If cbxPizza.SelectedIndex = 2 Then
            precoPizza = 8
        End If

        If chkAzeitona.Checked Then
            precoPizza += 1
        End If

        If chkQueijo.Checked Then
            precoPizza += 1
        End If

        If chkPimentos.Checked Then
            precoPizza += 2
        End If

        valorInicial = precoPizza * quantidade

        If rdbSim.Checked Then
            valorInicial -= valorInicial * 0.1
        End If

        valorFinal = valorInicial

        txtValor.Text = CStr(valorFinal)

    End Sub
End Class
