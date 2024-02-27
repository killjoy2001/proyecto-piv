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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RegistrarBtn = New System.Windows.Forms.Button()
        Me.EditarBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InicioBtn = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Red
        Me.SplitContainer1.Panel1.Controls.Add(Me.EditarBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RegistrarBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InicioBtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 460)
        Me.SplitContainer1.SplitterDistance = 229
        Me.SplitContainer1.TabIndex = 0
        '
        'RegistrarBtn
        '
        Me.RegistrarBtn.BackColor = System.Drawing.Color.White
        Me.RegistrarBtn.Location = New System.Drawing.Point(62, 195)
        Me.RegistrarBtn.Name = "RegistrarBtn"
        Me.RegistrarBtn.Size = New System.Drawing.Size(111, 40)
        Me.RegistrarBtn.TabIndex = 1
        Me.RegistrarBtn.Text = "Registrar"
        Me.RegistrarBtn.UseVisualStyleBackColor = False
        '
        'EditarBtn
        '
        Me.EditarBtn.Location = New System.Drawing.Point(62, 268)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(106, 40)
        Me.EditarBtn.TabIndex = 2
        Me.EditarBtn.Text = "Editar usuario"
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(475, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'InicioBtn
        '
        Me.InicioBtn.Location = New System.Drawing.Point(51, 108)
        Me.InicioBtn.Name = "InicioBtn"
        Me.InicioBtn.Size = New System.Drawing.Size(131, 49)
        Me.InicioBtn.TabIndex = 0
        Me.InicioBtn.Text = "Inicio"
        Me.InicioBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 456)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Inicio"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EditarBtn As Button
    Friend WithEvents RegistrarBtn As Button
    Friend WithEvents InicioBtn As Button
    Friend WithEvents Label1 As Label
End Class
