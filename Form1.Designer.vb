<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleGradeCalculator
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
        Me.pnlToolBar = New System.Windows.Forms.Panel()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlOutput = New System.Windows.Forms.Panel()
        Me.grpStatistics = New System.Windows.Forms.GroupBox()
        Me.lblGradeF = New System.Windows.Forms.Label()
        Me.btnStatistic = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblNumberofStudent = New System.Windows.Forms.Label()
        Me.lblShowAverage = New System.Windows.Forms.Label()
        Me.lblShowNumberofStudent = New System.Windows.Forms.Label()
        Me.lblCountF = New System.Windows.Forms.Label()
        Me.lblCountA = New System.Windows.Forms.Label()
        Me.lblGradeA = New System.Windows.Forms.Label()
        Me.grpStudentGrade = New System.Windows.Forms.GroupBox()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtModule = New System.Windows.Forms.TextBox()
        Me.lblModule = New System.Windows.Forms.Label()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.lblCA = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblCAComponents = New System.Windows.Forms.Label()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.lblExam = New System.Windows.Forms.Label()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.txtQuizzes = New System.Windows.Forms.TextBox()
        Me.lblQuizzes = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpRecord = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtFindName = New System.Windows.Forms.TextBox()
        Me.lstRecord = New System.Windows.Forms.ListBox()
        Me.pnlToolBar.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOutput.SuspendLayout()
        Me.grpStatistics.SuspendLayout()
        Me.grpStudentGrade.SuspendLayout()
        Me.grpResult.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolBar
        '
        Me.pnlToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnlToolBar.Controls.Add(Me.picIcon)
        Me.pnlToolBar.Controls.Add(Me.lblTitle)
        Me.pnlToolBar.Controls.Add(Me.btnMinimize)
        Me.pnlToolBar.Controls.Add(Me.btnClose)
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(801, 35)
        Me.pnlToolBar.TabIndex = 1
        '
        'picIcon
        '
        Me.picIcon.Image = Global.Module_Grade_Calculator.My.Resources.Resources.exam
        Me.picIcon.Location = New System.Drawing.Point(0, 0)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(35, 35)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 2
        Me.picIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(41, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 15)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Calculation of Module Grade"
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(734, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(766, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlOutput
        '
        Me.pnlOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.pnlOutput.Controls.Add(Me.grpStatistics)
        Me.pnlOutput.Location = New System.Drawing.Point(0, 376)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(801, 223)
        Me.pnlOutput.TabIndex = 2
        '
        'grpStatistics
        '
        Me.grpStatistics.Controls.Add(Me.lblGradeF)
        Me.grpStatistics.Controls.Add(Me.btnStatistic)
        Me.grpStatistics.Controls.Add(Me.lblAverage)
        Me.grpStatistics.Controls.Add(Me.lblNumberofStudent)
        Me.grpStatistics.Controls.Add(Me.lblShowAverage)
        Me.grpStatistics.Controls.Add(Me.lblShowNumberofStudent)
        Me.grpStatistics.Controls.Add(Me.lblCountF)
        Me.grpStatistics.Controls.Add(Me.lblCountA)
        Me.grpStatistics.Controls.Add(Me.lblGradeA)
        Me.grpStatistics.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatistics.ForeColor = System.Drawing.Color.Gold
        Me.grpStatistics.Location = New System.Drawing.Point(12, 3)
        Me.grpStatistics.Name = "grpStatistics"
        Me.grpStatistics.Size = New System.Drawing.Size(776, 208)
        Me.grpStatistics.TabIndex = 0
        Me.grpStatistics.TabStop = False
        Me.grpStatistics.Text = "Module Statistics"
        '
        'lblGradeF
        '
        Me.lblGradeF.AutoSize = True
        Me.lblGradeF.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeF.Location = New System.Drawing.Point(156, 21)
        Me.lblGradeF.Name = "lblGradeF"
        Me.lblGradeF.Size = New System.Drawing.Size(128, 32)
        Me.lblGradeF.TabIndex = 32
        Me.lblGradeF.Text = "Count of F"
        '
        'btnStatistic
        '
        Me.btnStatistic.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnStatistic.FlatAppearance.BorderSize = 0
        Me.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistic.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistic.Location = New System.Drawing.Point(623, 170)
        Me.btnStatistic.Name = "btnStatistic"
        Me.btnStatistic.Size = New System.Drawing.Size(147, 32)
        Me.btnStatistic.TabIndex = 31
        Me.btnStatistic.Text = "Show Statistics"
        Me.btnStatistic.UseVisualStyleBackColor = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(587, 84)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(80, 65)
        Me.lblAverage.TabIndex = 30
        Me.lblAverage.Text = "99"
        '
        'lblNumberofStudent
        '
        Me.lblNumberofStudent.AutoSize = True
        Me.lblNumberofStudent.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofStudent.Location = New System.Drawing.Point(361, 84)
        Me.lblNumberofStudent.Name = "lblNumberofStudent"
        Me.lblNumberofStudent.Size = New System.Drawing.Size(80, 65)
        Me.lblNumberofStudent.TabIndex = 29
        Me.lblNumberofStudent.Text = "99"
        '
        'lblShowAverage
        '
        Me.lblShowAverage.AutoSize = True
        Me.lblShowAverage.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowAverage.Location = New System.Drawing.Point(528, 21)
        Me.lblShowAverage.Name = "lblShowAverage"
        Me.lblShowAverage.Size = New System.Drawing.Size(192, 32)
        Me.lblShowAverage.TabIndex = 28
        Me.lblShowAverage.Text = "Module Average"
        '
        'lblShowNumberofStudent
        '
        Me.lblShowNumberofStudent.AutoSize = True
        Me.lblShowNumberofStudent.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowNumberofStudent.Location = New System.Drawing.Point(290, 21)
        Me.lblShowNumberofStudent.Name = "lblShowNumberofStudent"
        Me.lblShowNumberofStudent.Size = New System.Drawing.Size(232, 32)
        Me.lblShowNumberofStudent.TabIndex = 27
        Me.lblShowNumberofStudent.Text = "Number of Students"
        '
        'lblCountF
        '
        Me.lblCountF.AutoSize = True
        Me.lblCountF.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountF.Location = New System.Drawing.Point(195, 84)
        Me.lblCountF.Name = "lblCountF"
        Me.lblCountF.Size = New System.Drawing.Size(51, 65)
        Me.lblCountF.TabIndex = 26
        Me.lblCountF.Text = "F"
        '
        'lblCountA
        '
        Me.lblCountA.AutoSize = True
        Me.lblCountA.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountA.Location = New System.Drawing.Point(53, 84)
        Me.lblCountA.Name = "lblCountA"
        Me.lblCountA.Size = New System.Drawing.Size(59, 65)
        Me.lblCountA.TabIndex = 25
        Me.lblCountA.Text = "A"
        '
        'lblGradeA
        '
        Me.lblGradeA.AutoSize = True
        Me.lblGradeA.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeA.Location = New System.Drawing.Point(14, 21)
        Me.lblGradeA.Name = "lblGradeA"
        Me.lblGradeA.Size = New System.Drawing.Size(131, 32)
        Me.lblGradeA.TabIndex = 19
        Me.lblGradeA.Text = "Count of A"
        '
        'grpStudentGrade
        '
        Me.grpStudentGrade.Controls.Add(Me.btnClearAll)
        Me.grpStudentGrade.Controls.Add(Me.grpResult)
        Me.grpStudentGrade.Controls.Add(Me.grpInput)
        Me.grpStudentGrade.Controls.Add(Me.txtName)
        Me.grpStudentGrade.Controls.Add(Me.lblName)
        Me.grpStudentGrade.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudentGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.grpStudentGrade.Location = New System.Drawing.Point(12, 41)
        Me.grpStudentGrade.Name = "grpStudentGrade"
        Me.grpStudentGrade.Size = New System.Drawing.Size(498, 329)
        Me.grpStudentGrade.TabIndex = 3
        Me.grpStudentGrade.TabStop = False
        Me.grpStudentGrade.Text = "Marks and Grade for Individual Student"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(408, 21)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(78, 29)
        Me.btnClearAll.TabIndex = 11
        Me.btnClearAll.Text = "Clear &All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.txtRemarks)
        Me.grpResult.Controls.Add(Me.lblRemarks)
        Me.grpResult.Controls.Add(Me.txtGrade)
        Me.grpResult.Controls.Add(Me.lblGrade)
        Me.grpResult.Controls.Add(Me.txtModule)
        Me.grpResult.Controls.Add(Me.lblModule)
        Me.grpResult.Controls.Add(Me.txtCA)
        Me.grpResult.Controls.Add(Me.lblCA)
        Me.grpResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.grpResult.Location = New System.Drawing.Point(6, 187)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(486, 135)
        Me.grpResult.TabIndex = 4
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Module Result"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(310, 89)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(100, 25)
        Me.txtRemarks.TabIndex = 18
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(211, 92)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(58, 17)
        Me.lblRemarks.TabIndex = 17
        Me.lblRemarks.Text = "Remarks"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(105, 89)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(100, 25)
        Me.txtGrade.TabIndex = 16
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(6, 92)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(93, 17)
        Me.lblGrade.TabIndex = 15
        Me.lblGrade.Text = "Module Grade"
        '
        'txtModule
        '
        Me.txtModule.Location = New System.Drawing.Point(310, 37)
        Me.txtModule.Name = "txtModule"
        Me.txtModule.ReadOnly = True
        Me.txtModule.Size = New System.Drawing.Size(100, 25)
        Me.txtModule.TabIndex = 14
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Location = New System.Drawing.Point(211, 40)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(93, 17)
        Me.lblModule.TabIndex = 13
        Me.lblModule.Text = "Module Marks"
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(105, 37)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.ReadOnly = True
        Me.txtCA.Size = New System.Drawing.Size(100, 25)
        Me.txtCA.TabIndex = 12
        '
        'lblCA
        '
        Me.lblCA.AutoSize = True
        Me.lblCA.Location = New System.Drawing.Point(6, 40)
        Me.lblCA.Name = "lblCA"
        Me.lblCA.Size = New System.Drawing.Size(64, 17)
        Me.lblCA.TabIndex = 11
        Me.lblCA.Text = "CA Marks"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblCAComponents)
        Me.grpInput.Controls.Add(Me.txtExam)
        Me.grpInput.Controls.Add(Me.lblExam)
        Me.grpInput.Controls.Add(Me.txtProject)
        Me.grpInput.Controls.Add(Me.lblProject)
        Me.grpInput.Controls.Add(Me.txtQuizzes)
        Me.grpInput.Controls.Add(Me.lblQuizzes)
        Me.grpInput.Controls.Add(Me.txtTest)
        Me.grpInput.Controls.Add(Me.lblTest)
        Me.grpInput.Controls.Add(Me.btnConfirm)
        Me.grpInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.grpInput.Location = New System.Drawing.Point(6, 56)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(486, 125)
        Me.grpInput.TabIndex = 3
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input CA and Exam Marks"
        '
        'lblCAComponents
        '
        Me.lblCAComponents.AutoSize = True
        Me.lblCAComponents.Location = New System.Drawing.Point(11, 21)
        Me.lblCAComponents.Name = "lblCAComponents"
        Me.lblCAComponents.Size = New System.Drawing.Size(105, 17)
        Me.lblCAComponents.TabIndex = 11
        Me.lblCAComponents.Text = "CA Components:"
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(257, 90)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(100, 25)
        Me.txtExam.TabIndex = 10
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.Location = New System.Drawing.Point(184, 93)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(42, 17)
        Me.lblExam.TabIndex = 9
        Me.lblExam.Text = "Exam:"
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(73, 90)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(100, 25)
        Me.txtProject.TabIndex = 8
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(6, 93)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(51, 17)
        Me.lblProject.TabIndex = 7
        Me.lblProject.Text = "Project:"
        '
        'txtQuizzes
        '
        Me.txtQuizzes.Location = New System.Drawing.Point(257, 45)
        Me.txtQuizzes.Name = "txtQuizzes"
        Me.txtQuizzes.Size = New System.Drawing.Size(100, 25)
        Me.txtQuizzes.TabIndex = 6
        '
        'lblQuizzes
        '
        Me.lblQuizzes.AutoSize = True
        Me.lblQuizzes.Location = New System.Drawing.Point(184, 48)
        Me.lblQuizzes.Name = "lblQuizzes"
        Me.lblQuizzes.Size = New System.Drawing.Size(56, 17)
        Me.lblQuizzes.TabIndex = 5
        Me.lblQuizzes.Text = "Quizzes:"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(73, 45)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 25)
        Me.txtTest.TabIndex = 4
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(6, 48)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(34, 17)
        Me.lblTest.TabIndex = 3
        Me.lblTest.Text = "Test:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(402, 87)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(78, 29)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(64, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(299, 25)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 27)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'grpRecord
        '
        Me.grpRecord.Controls.Add(Me.btnSearch)
        Me.grpRecord.Controls.Add(Me.btnFind)
        Me.grpRecord.Controls.Add(Me.txtFindName)
        Me.grpRecord.Controls.Add(Me.lstRecord)
        Me.grpRecord.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.grpRecord.Location = New System.Drawing.Point(516, 41)
        Me.grpRecord.Name = "grpRecord"
        Me.grpRecord.Size = New System.Drawing.Size(272, 329)
        Me.grpRecord.TabIndex = 4
        Me.grpRecord.TabStop = False
        Me.grpRecord.Text = "Student Record"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(6, 286)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(260, 36)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search Record"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(222, 254)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(44, 26)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtFindName
        '
        Me.txtFindName.Location = New System.Drawing.Point(6, 255)
        Me.txtFindName.Name = "txtFindName"
        Me.txtFindName.Size = New System.Drawing.Size(210, 25)
        Me.txtFindName.TabIndex = 1
        '
        'lstRecord
        '
        Me.lstRecord.FormattingEnabled = True
        Me.lstRecord.ItemHeight = 17
        Me.lstRecord.Location = New System.Drawing.Point(6, 24)
        Me.lstRecord.Name = "lstRecord"
        Me.lstRecord.Size = New System.Drawing.Size(260, 225)
        Me.lstRecord.TabIndex = 0
        '
        'frmModuleGradeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.grpRecord)
        Me.Controls.Add(Me.grpStudentGrade)
        Me.Controls.Add(Me.pnlOutput)
        Me.Controls.Add(Me.pnlToolBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModuleGradeCalculator"
        Me.Text = "Module Grade Calculator"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOutput.ResumeLayout(False)
        Me.grpStatistics.ResumeLayout(False)
        Me.grpStatistics.PerformLayout()
        Me.grpStudentGrade.ResumeLayout(False)
        Me.grpStudentGrade.PerformLayout()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpRecord.ResumeLayout(False)
        Me.grpRecord.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlToolBar As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents pnlOutput As Panel
    Friend WithEvents grpStudentGrade As GroupBox
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents lblTest As Label
    Friend WithEvents txtExam As TextBox
    Friend WithEvents lblExam As Label
    Friend WithEvents txtProject As TextBox
    Friend WithEvents lblProject As Label
    Friend WithEvents txtQuizzes As TextBox
    Friend WithEvents lblQuizzes As Label
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtModule As TextBox
    Friend WithEvents lblModule As Label
    Friend WithEvents txtCA As TextBox
    Friend WithEvents lblCA As Label
    Friend WithEvents grpStatistics As GroupBox
    Friend WithEvents grpRecord As GroupBox
    Friend WithEvents btnFind As Button
    Friend WithEvents txtFindName As TextBox
    Friend WithEvents lstRecord As ListBox
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lblCAComponents As Label
    Friend WithEvents lblCountA As Label
    Friend WithEvents lblGradeA As Label
    Friend WithEvents lblCountF As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblNumberofStudent As Label
    Friend WithEvents lblShowAverage As Label
    Friend WithEvents lblShowNumberofStudent As Label
    Friend WithEvents btnStatistic As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblGradeF As Label
End Class
