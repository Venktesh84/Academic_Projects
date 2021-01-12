<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKSDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASERETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALESRETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUPPLIERDETAILSToolStripMenuItem, Me.CUSTOMERDETAILSToolStripMenuItem, Me.PURCHASEDETAILSToolStripMenuItem, Me.STOCKSDETAILSToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.MasterToolStripMenuItem.Text = "DETAILS"
        '
        'SUPPLIERDETAILSToolStripMenuItem
        '
        Me.SUPPLIERDETAILSToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUPPLIERDETAILSToolStripMenuItem.Name = "SUPPLIERDETAILSToolStripMenuItem"
        Me.SUPPLIERDETAILSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.SUPPLIERDETAILSToolStripMenuItem.Text = "SUPPLIER DETAILS"
        '
        'CUSTOMERDETAILSToolStripMenuItem
        '
        Me.CUSTOMERDETAILSToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMERDETAILSToolStripMenuItem.Name = "CUSTOMERDETAILSToolStripMenuItem"
        Me.CUSTOMERDETAILSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CUSTOMERDETAILSToolStripMenuItem.Text = "CUSTOMER DETAILS"
        '
        'PURCHASEDETAILSToolStripMenuItem
        '
        Me.PURCHASEDETAILSToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PURCHASEDETAILSToolStripMenuItem.Name = "PURCHASEDETAILSToolStripMenuItem"
        Me.PURCHASEDETAILSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PURCHASEDETAILSToolStripMenuItem.Text = "PURCHASE DETAILS"
        '
        'STOCKSDETAILSToolStripMenuItem
        '
        Me.STOCKSDETAILSToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STOCKSDETAILSToolStripMenuItem.Name = "STOCKSDETAILSToolStripMenuItem"
        Me.STOCKSDETAILSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.STOCKSDETAILSToolStripMenuItem.Text = "STOCKS DETAILS"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALESToolStripMenuItem, Me.PURCHASERETURNToolStripMenuItem, Me.SALESRETURNToolStripMenuItem, Me.BILLToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SALESToolStripMenuItem
        '
        Me.SALESToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALESToolStripMenuItem.Name = "SALESToolStripMenuItem"
        Me.SALESToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SALESToolStripMenuItem.Text = "SALES"
        '
        'PURCHASERETURNToolStripMenuItem
        '
        Me.PURCHASERETURNToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PURCHASERETURNToolStripMenuItem.Name = "PURCHASERETURNToolStripMenuItem"
        Me.PURCHASERETURNToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.PURCHASERETURNToolStripMenuItem.Text = "PURCHASE RETURN"
        '
        'SALESRETURNToolStripMenuItem
        '
        Me.SALESRETURNToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALESRETURNToolStripMenuItem.Name = "SALESRETURNToolStripMenuItem"
        Me.SALESRETURNToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SALESRETURNToolStripMenuItem.Text = "SALES RETURN"
        '
        'BILLToolStripMenuItem
        '
        Me.BILLToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BILLToolStripMenuItem.Name = "BILLToolStripMenuItem"
        Me.BILLToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.BILLToolStripMenuItem.Text = "BILL"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(499, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(532, 454)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASEDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STOCKSDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASERETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALESRETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BILLToolStripMenuItem As ToolStripMenuItem
End Class
