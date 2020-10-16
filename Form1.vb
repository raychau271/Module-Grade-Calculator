Public Class frmModuleGradeCalculator

    Const Test_percentage As Double = 0.5
    Const Quiz_percentage As Double = 0.2
    Const Project_percentage As Double = 0.3
    Const CA_percentage As Double = 0.4
    Const Exam_percentage As Double = 0.6

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub frmModuleGradeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Actions when the program started
        lblCAComponents.Text = "CA Components: Test:" & Test_percentage * 100 & "%, Quiz:" & Quiz_percentage * 100 & ", Project:" _
                                & Project_percentage * 100 'Display CA components
        grpResult.Text = "Module Result (CA:" & CA_percentage * 100 & "%, Exam:" & Exam_percentage * 100 & "%)" 'Add module components to groupbox
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click 'Actions when click confirm button

        Dim name As String
        Dim test, quiz, project, exam, camrak, modulemark As Double
        Dim valid_input_count As Integer

        'test = CDbl(txtTest.Text)
        'quiz = CDbl(txtQuizzes.Text)
        'project = CDbl(txtProject.Text)
        'exam = CDbl(txtExam.Text)

        'if (txttest.text = "" or test < 0 or test > 100 or not (isnumeric(txttest.text))) then
        '    if txttest.text = "" then
        '        valid = 1
        '    elseif not (isnumeric(txttest.text)) then
        '        valid = 2
        '    else
        '        valid = 3
        '    end if
        'elseif (txtquizzes.text = "" or test < 0 or test > 100 or not (isnumeric(txtquizzes.text))) then
        '    if txtquizzes.text = "" then
        '        valid = 1
        '    elseif not (isnumeric(txtquizzes.text)) then
        '        valid = 2
        '    else
        '        valid = 3
        '    end if
        'elseif (txtproject.text = "" or test < 0 or test > 100 or not (isnumeric(txtproject.text))) then
        '    if txtproject.text = "" then
        '        valid = 1
        '    elseif not (isnumeric(txtproject.text)) then
        '        valid = 2
        '    else
        '        valid = 3
        '    end if
        'elseif (txtexam.text = "" or test < 0 or test > 100 or not (isnumeric(txtexam.text))) then
        '    if txtexam.text = "" then
        '        valid = 1
        '    elseif not (isnumeric(txtexam.text)) then
        '        valid = 2
        '    else
        '        valid = 3
        '    end if
        'end if

        'If valid = 1 Then
        '    MessageBox.Show("Input cannot be empty")
        'ElseIf valid = 2 Then
        '    MessageBox.Show("Please Enter a Number")
        'ElseIf valid = 3 Then
        '    MessageBox.Show("Please Enter marks in between 0 - 100")
        'End If

        If (IsNumeric(txtTest.Text)) And (IsNumeric(txtQuizzes.Text)) And (IsNumeric(txtProject.Text)) And (IsNumeric(txtExam.Text)) Then
            name = txtName.Text 'Input Name
            test = CDbl(txtTest.Text)
            valid_input_count = Validate_marks(test)
            quiz = CDbl(txtQuizzes.Text) 'Input Quizzes mark
            valid_input_count = valid_input_count + Validate_marks(quiz)
            project = CDbl(txtProject.Text) 'Input Project mark
            valid_input_count = valid_input_count + Validate_marks(project)
            exam = CDbl(txtExam.Text) 'Input Exam mark
            valid_input_count = valid_input_count + Validate_marks(exam)
        Else
            MessageBox.Show("Please Enter a number", "Invalid Input")
            Clear_Output()
        End If

        If valid_input_count = 4 Then
            camrak = test * Test_percentage + quiz * Quiz_percentage + project * Project_percentage
            modulemark = camrak * CA_percentage + exam * Exam_percentage
            txtCA.Text = CStr(camrak)
            txtModule.Text = CStr(modulemark)
        Else
            MessageBox.Show("Please Enter marks in between 0 - 100", "Invalid Input")
            Clear_Output()
        End If

        If (valid_input_count = 4) Then
            If ((camrak < 40) Or (exam < 40)) Then 'Determine Grade
                txtGrade.Text = "F"
            ElseIf modulemark < 65 Then
                txtGrade.Text = "C"
            ElseIf modulemark < 75 Then
                txtGrade.Text = "B"
            Else
                txtGrade.Text = "A"
            End If
        Else
            Clear_Output()
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click 'Clear everything in Marks and Grade for Individual Student groupbox
        Clear_Input()
        Clear_Output()
    End Sub

    Private Sub pnlToolBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolBar.MouseDown 'Drag toolbar
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub pnlToolBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolBar.MouseMove 'move toolbar
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub pnlToolBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolBar.MouseUp 'release left click
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click 'window close button in toolbar
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click 'window minimize button in toolbar
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub Clear_Input() 'Clear All Input
        txtName.Text = ""
        txtTest.Text = ""
        txtQuizzes.Text = ""
        txtProject.Text = ""
        txtExam.Text = ""
    End Sub

    Sub Clear_Output() 'Clear All Output
        txtCA.Text = ""
        txtModule.Text = ""
        txtGrade.Text = ""
        txtRemarks.Text = ""
    End Sub

    'Function Check_empty(ByVal input As String) As String
    '    If input = "" Then
    '        MessageBox.Show("Input Cannot Be Empty", "Error")
    '    End If
    '    Return input
    'End Function

    Function Validate_marks(ByVal mark As Double) As Integer
        If mark >= 0 And mark <= 100 Then
            Return 1
        Else
            Return 0
        End If
    End Function



End Class
