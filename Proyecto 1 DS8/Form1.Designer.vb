<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnFillTank1 = New System.Windows.Forms.Button()
        Me.opcTubCerrada = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opcTubAbierta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResetTank1 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnResetTank2 = New System.Windows.Forms.Button()
        Me.btnFillTank2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStop2 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnFillBoth = New System.Windows.Forms.Button()
        Me.Tanque2 = New Proyecto_1_DS8.MyVerticalProgressBar()
        Me.Tanque1 = New Proyecto_1_DS8.MyVerticalProgressBar()
        Me.Tuberia = New Proyecto_1_DS8.MyVerticalProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFillTank1
        '
        Me.btnFillTank1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillTank1.Location = New System.Drawing.Point(11, 132)
        Me.btnFillTank1.Name = "btnFillTank1"
        Me.btnFillTank1.Size = New System.Drawing.Size(84, 33)
        Me.btnFillTank1.TabIndex = 4
        Me.btnFillTank1.Text = "LLenar"
        Me.btnFillTank1.UseVisualStyleBackColor = True
        '
        'opcTubCerrada
        '
        Me.opcTubCerrada.AutoSize = True
        Me.opcTubCerrada.Location = New System.Drawing.Point(21, 43)
        Me.opcTubCerrada.Name = "opcTubCerrada"
        Me.opcTubCerrada.Size = New System.Drawing.Size(62, 17)
        Me.opcTubCerrada.TabIndex = 6
        Me.opcTubCerrada.Text = "Cerrada"
        Me.opcTubCerrada.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opcTubAbierta)
        Me.GroupBox1.Controls.Add(Me.opcTubCerrada)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tuberia"
        '
        'opcTubAbierta
        '
        Me.opcTubAbierta.AutoSize = True
        Me.opcTubAbierta.Checked = True
        Me.opcTubAbierta.Location = New System.Drawing.Point(21, 20)
        Me.opcTubAbierta.Name = "opcTubAbierta"
        Me.opcTubAbierta.Size = New System.Drawing.Size(58, 17)
        Me.opcTubAbierta.TabIndex = 5
        Me.opcTubAbierta.TabStop = True
        Me.opcTubAbierta.Text = "Abierta"
        Me.opcTubAbierta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tanque 1"
        '
        'btnResetTank1
        '
        Me.btnResetTank1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTank1.Location = New System.Drawing.Point(11, 171)
        Me.btnResetTank1.Name = "btnResetTank1"
        Me.btnResetTank1.Size = New System.Drawing.Size(75, 33)
        Me.btnResetTank1.TabIndex = 13
        Me.btnResetTank1.Text = "Reset"
        Me.btnResetTank1.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(40, 28)
        Me.HScrollBar1.Maximum = 109
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(147, 24)
        Me.HScrollBar1.TabIndex = 1
        Me.HScrollBar1.Value = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 42)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Litros"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 42)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HScrollBar1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(117, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 71)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Velocidad de LLenado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(227, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Tuberia: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = " "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(383, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 18)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(303, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 20)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Label17"
        Me.Label17.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tanque 2"
        '
        'btnResetTank2
        '
        Me.btnResetTank2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTank2.Location = New System.Drawing.Point(566, 171)
        Me.btnResetTank2.Name = "btnResetTank2"
        Me.btnResetTank2.Size = New System.Drawing.Size(75, 33)
        Me.btnResetTank2.TabIndex = 29
        Me.btnResetTank2.Text = "Reset"
        Me.btnResetTank2.UseVisualStyleBackColor = True
        '
        'btnFillTank2
        '
        Me.btnFillTank2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillTank2.Location = New System.Drawing.Point(557, 132)
        Me.btnFillTank2.Name = "btnFillTank2"
        Me.btnFillTank2.Size = New System.Drawing.Size(84, 33)
        Me.btnFillTank2.TabIndex = 28
        Me.btnFillTank2.Text = "LLenar"
        Me.btnFillTank2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(11, 211)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 30)
        Me.btnStop.TabIndex = 30
        Me.btnStop.Text = "Detener"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStop2
        '
        Me.btnStop2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop2.Location = New System.Drawing.Point(557, 216)
        Me.btnStop2.Name = "btnStop2"
        Me.btnStop2.Size = New System.Drawing.Size(84, 30)
        Me.btnStop2.TabIndex = 31
        Me.btnStop2.Text = "Detener"
        Me.btnStop2.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'btnFillBoth
        '
        Me.btnFillBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillBoth.Location = New System.Drawing.Point(386, 379)
        Me.btnFillBoth.Name = "btnFillBoth"
        Me.btnFillBoth.Size = New System.Drawing.Size(151, 39)
        Me.btnFillBoth.TabIndex = 32
        Me.btnFillBoth.Text = "LLenar Ambas"
        Me.btnFillBoth.UseVisualStyleBackColor = True
        '
        'Tanque2
        '
        Me.Tanque2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Tanque2.Location = New System.Drawing.Point(437, 107)
        Me.Tanque2.Maximum = 5000
        Me.Tanque2.Name = "Tanque2"
        Me.Tanque2.Size = New System.Drawing.Size(100, 252)
        Me.Tanque2.TabIndex = 3
        '
        'Tanque1
        '
        Me.Tanque1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tanque1.ForeColor = System.Drawing.Color.Blue
        Me.Tanque1.Location = New System.Drawing.Point(117, 63)
        Me.Tanque1.Maximum = 5000
        Me.Tanque1.Name = "Tanque1"
        Me.Tanque1.Size = New System.Drawing.Size(100, 252)
        Me.Tanque1.TabIndex = 1
        Me.Tanque1.UseWaitCursor = True
        '
        'Tuberia
        '
        Me.Tuberia.Location = New System.Drawing.Point(206, 200)
        Me.Tuberia.Name = "Tuberia"
        Me.Tuberia.Size = New System.Drawing.Size(241, 12)
        Me.Tuberia.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 438)
        Me.Controls.Add(Me.btnFillBoth)
        Me.Controls.Add(Me.btnStop2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnResetTank2)
        Me.Controls.Add(Me.btnFillTank2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnResetTank1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFillTank1)
        Me.Controls.Add(Me.Tanque2)
        Me.Controls.Add(Me.Tanque1)
        Me.Controls.Add(Me.Tuberia)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tanque1 As MyVerticalProgressBar
    Friend WithEvents Tanque2 As MyVerticalProgressBar
    Friend WithEvents btnFillTank1 As Button
    Friend WithEvents opcTubCerrada As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tuberia As MyVerticalProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResetTank1 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnResetTank2 As Button
    Friend WithEvents btnFillTank2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents opcTubAbierta As RadioButton
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStop2 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnFillBoth As Button
End Class
