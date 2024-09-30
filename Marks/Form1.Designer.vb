<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblGRADINGSCALECALCULATOR = New Label()
        lblentermarks = New Label()
        lblgrade = New Label()
        btnevaluate = New Button()
        txtmarks = New TextBox()
        txtgrade = New TextBox()
        SuspendLayout()
        ' 
        ' lblGRADINGSCALECALCULATOR
        ' 
        lblGRADINGSCALECALCULATOR.AutoSize = True
        lblGRADINGSCALECALCULATOR.BackColor = SystemColors.GradientActiveCaption
        lblGRADINGSCALECALCULATOR.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGRADINGSCALECALCULATOR.ForeColor = SystemColors.InactiveCaptionText
        lblGRADINGSCALECALCULATOR.Location = New Point(297, 33)
        lblGRADINGSCALECALCULATOR.Name = "lblGRADINGSCALECALCULATOR"
        lblGRADINGSCALECALCULATOR.Size = New Size(456, 32)
        lblGRADINGSCALECALCULATOR.TabIndex = 0
        lblGRADINGSCALECALCULATOR.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' lblentermarks
        ' 
        lblentermarks.AutoSize = True
        lblentermarks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblentermarks.Location = New Point(224, 97)
        lblentermarks.Name = "lblentermarks"
        lblentermarks.Size = New Size(125, 28)
        lblentermarks.TabIndex = 1
        lblentermarks.Text = "Enter marks"
        ' 
        ' lblgrade
        ' 
        lblgrade.AutoSize = True
        lblgrade.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgrade.Location = New Point(257, 171)
        lblgrade.Name = "lblgrade"
        lblgrade.Size = New Size(68, 28)
        lblgrade.TabIndex = 2
        lblgrade.Text = "Grade"
        ' 
        ' btnevaluate
        ' 
        btnevaluate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnevaluate.Location = New Point(322, 249)
        btnevaluate.Name = "btnevaluate"
        btnevaluate.Size = New Size(161, 54)
        btnevaluate.TabIndex = 3
        btnevaluate.Text = "Evaluate"
        btnevaluate.UseVisualStyleBackColor = True
        ' 
        ' txtmarks
        ' 
        txtmarks.Location = New Point(383, 97)
        txtmarks.Name = "txtmarks"
        txtmarks.Size = New Size(175, 27)
        txtmarks.TabIndex = 4
        ' 
        ' txtgrade
        ' 
        txtgrade.Location = New Point(383, 164)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(175, 27)
        txtgrade.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtgrade)
        Controls.Add(txtmarks)
        Controls.Add(btnevaluate)
        Controls.Add(lblgrade)
        Controls.Add(lblentermarks)
        Controls.Add(lblGRADINGSCALECALCULATOR)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGRADINGSCALECALCULATOR As Label
    Friend WithEvents lblentermarks As Label
    Friend WithEvents lblgrade As Label
    Friend WithEvents btnevaluate As Button
    Friend WithEvents txtmarks As TextBox
    Friend WithEvents txtgrade As TextBox

End Class
