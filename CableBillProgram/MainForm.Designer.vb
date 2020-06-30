<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rdoBuisness = New System.Windows.Forms.RadioButton()
        Me.rdoResident = New System.Windows.Forms.RadioButton()
        Me.LabelConnect = New System.Windows.Forms.Label()
        Me.chklstPremChan = New System.Windows.Forms.CheckedListBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtConnections = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gpbPremChan = New System.Windows.Forms.GroupBox()
        Me.lstPremPrice = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPremChan.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoBuisness
        '
        Me.rdoBuisness.AutoSize = True
        Me.rdoBuisness.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBuisness.Location = New System.Drawing.Point(27, 125)
        Me.rdoBuisness.Name = "rdoBuisness"
        Me.rdoBuisness.Size = New System.Drawing.Size(83, 21)
        Me.rdoBuisness.TabIndex = 0
        Me.rdoBuisness.TabStop = True
        Me.rdoBuisness.Text = "&Buisness"
        Me.rdoBuisness.UseVisualStyleBackColor = True
        '
        'rdoResident
        '
        Me.rdoResident.AutoSize = True
        Me.rdoResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoResident.Location = New System.Drawing.Point(27, 148)
        Me.rdoResident.Name = "rdoResident"
        Me.rdoResident.Size = New System.Drawing.Size(96, 21)
        Me.rdoResident.TabIndex = 1
        Me.rdoResident.TabStop = True
        Me.rdoResident.Text = "&Residential"
        Me.rdoResident.UseVisualStyleBackColor = True
        '
        'LabelConnect
        '
        Me.LabelConnect.AutoSize = True
        Me.LabelConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnect.Location = New System.Drawing.Point(137, 20)
        Me.LabelConnect.Name = "LabelConnect"
        Me.LabelConnect.Size = New System.Drawing.Size(102, 20)
        Me.LabelConnect.TabIndex = 4
        Me.LabelConnect.Text = "&Connections:"
        '
        'chklstPremChan
        '
        Me.chklstPremChan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chklstPremChan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstPremChan.FormattingEnabled = True
        Me.chklstPremChan.Items.AddRange(New Object() {"HBO", "Starz", "Cinemax", "Showtime", "The Movie Channel", "Encore", "Epix"})
        Me.chklstPremChan.Location = New System.Drawing.Point(6, 19)
        Me.chklstPremChan.Name = "chklstPremChan"
        Me.chklstPremChan.Size = New System.Drawing.Size(148, 128)
        Me.chklstPremChan.TabIndex = 0
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(23, 204)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(79, 20)
        Me.LabelTotal.TabIndex = 2
        Me.LabelTotal.Text = "&Total due:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Salmon
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(27, 224)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(210, 217)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(85, 30)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Ca&lculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(304, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtConnections
        '
        Me.txtConnections.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnections.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnections.Location = New System.Drawing.Point(245, 14)
        Me.txtConnections.Name = "txtConnections"
        Me.txtConnections.Size = New System.Drawing.Size(89, 26)
        Me.txtConnections.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CableBillProgram.My.Resources.Resources.Twilight__2_
        Me.PictureBox1.Location = New System.Drawing.Point(27, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'gpbPremChan
        '
        Me.gpbPremChan.Controls.Add(Me.lstPremPrice)
        Me.gpbPremChan.Controls.Add(Me.chklstPremChan)
        Me.gpbPremChan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPremChan.Location = New System.Drawing.Point(141, 46)
        Me.gpbPremChan.Name = "gpbPremChan"
        Me.gpbPremChan.Size = New System.Drawing.Size(238, 155)
        Me.gpbPremChan.TabIndex = 6
        Me.gpbPremChan.TabStop = False
        Me.gpbPremChan.Text = "Premium Channels:"
        '
        'lstPremPrice
        '
        Me.lstPremPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPremPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPremPrice.FormattingEnabled = True
        Me.lstPremPrice.ItemHeight = 18
        Me.lstPremPrice.Location = New System.Drawing.Point(160, 19)
        Me.lstPremPrice.Name = "lstPremPrice"
        Me.lstPremPrice.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstPremPrice.Size = New System.Drawing.Size(69, 128)
        Me.lstPremPrice.TabIndex = 1
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 265)
        Me.Controls.Add(Me.gpbPremChan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtConnections)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelConnect)
        Me.Controls.Add(Me.rdoResident)
        Me.Controls.Add(Me.rdoBuisness)
        Me.Name = "mainForm"
        Me.Text = "Starr Direct Cable"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPremChan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoBuisness As RadioButton
    Friend WithEvents rdoResident As RadioButton
    Friend WithEvents LabelConnect As Label
    Friend WithEvents chklstPremChan As CheckedListBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtConnections As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gpbPremChan As GroupBox
    Friend WithEvents lstPremPrice As ListBox
End Class
