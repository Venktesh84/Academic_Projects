Public Class Main
    Private Sub SUPPLIERDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPPLIERDETAILSToolStripMenuItem.Click
        Supplier.Show()
        Me.Hide()
    End Sub

    Private Sub CUSTOMERDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERDETAILSToolStripMenuItem.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub PURCHASEDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PURCHASEDETAILSToolStripMenuItem.Click
        Purchase.Show()
        Me.Hide()
    End Sub

    Private Sub STOCKSDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOCKSDETAILSToolStripMenuItem.Click
        Stocks.Show()
        Me.Hide()
    End Sub

    Private Sub SALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESToolStripMenuItem.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub PURCHASERETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PURCHASERETURNToolStripMenuItem.Click
        Purchasereturn.Show()
        Me.Hide()
    End Sub

    Private Sub SALESRETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESRETURNToolStripMenuItem.Click
        Salesreturn.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub BILLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BILLToolStripMenuItem.Click
        Bill.Show()
        Me.Hide()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub
End Class