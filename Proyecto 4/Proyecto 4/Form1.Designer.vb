<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero 1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(319, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(319, 188)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero 2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 63)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Sumar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 134)
        Me.Label4.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(614, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 63)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Restar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(529, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 63)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Multiplicar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(614, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 63)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Dividir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
