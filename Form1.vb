Imports System.Data.OleDb
Public Class frmModuleGradeCalculator
    Const Test_percentage As Double = 0.5
    Const Quiz_percentage As Double = 0.2
    Const Project_percentage As Double = 0.3
    Const CA_percentage As Double = 0.4
    Const Exam_percentage As Double = 0.6

    Dim count_A As Integer
    Dim count_F As Integer
    Dim count_student As Integer
    Dim sum_marks As Double

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub frmModuleGradeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Actions when the program started
        lblCAComponents.Text = "CA Components: Test:" & Test_percentage * 100 & "%, Quiz:" & Quiz_percentage * 100 & "%, Project:" _
                                & Project_percentage * 100 & "%" 'Display CA components
        grpResult.Text = "Module Result (CA:" & CA_percentage * 100 & "%, Exam:" & Exam_percentage * 100 & "%)" 'Add module components to groupbox
        lblAverage.Text = ""
        lblNumberofStudent.Text = ""
        lblCountA.Text = ""
        lblCountF.Text = ""
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click 'Actions when click confirm button
        Dim name As String
        Dim test, quiz, project, exam, camark, modulemark As Double
        Dim valid_input As Integer '5 = invalid name 4 = valid 0-3 = invalid numbers

        If (txtName.Text = "") Or IsNumeric(txtName.Text) Then 'Check student name which is cannot be empty and a number
            MessageBox.Show("Please Enter Student Name", "Invalid Input")
            valid_input = 5
        ElseIf (IsNumeric(txtTest.Text)) And (IsNumeric(txtQuizzes.Text)) And (IsNumeric(txtProject.Text)) And (IsNumeric(txtExam.Text)) Then 'Check marks input  
            name = txtName.Text 'Input Name
            test = CDbl(txtTest.Text)
            valid_input = Validate_marks(test) 'Count numbers of valid marks input
            quiz = CDbl(txtQuizzes.Text) 'Input Quizzes mark
            valid_input = valid_input + Validate_marks(quiz)
            project = CDbl(txtProject.Text) 'Input Project mark
            valid_input = valid_input + Validate_marks(project)
            exam = CDbl(txtExam.Text) 'Input Exam mark
            valid_input = valid_input + Validate_marks(exam)
        Else
            MessageBox.Show("Please Enter a number", "Invalid Input")
            valid_input = 5 'to prevent error message display wrongly
            Clear_Output()
        End If

        If valid_input = 4 Then 'If there are 4 valid input, calculate the result
            camark = test * Test_percentage + quiz * Quiz_percentage + project * Project_percentage 'Calculate CA Result
            modulemark = camark * CA_percentage + exam * Exam_percentage 'Calculate Module Result
            txtCA.Text = CStr(camark) 'Output CA Result
            txtModule.Text = CStr(modulemark) 'Output Module Result
            txtGrade.Text = Determine_Grade(camark, exam, modulemark) 'Output Grade
            txtRemarks.Text = Determine_Remarks(txtGrade.Text, modulemark) 'Output Remarks
            count_student += 1
            sum_marks += modulemark
            If txtGrade.Text = "A" Then
                count_A += 1
            ElseIf txtGrade.Text = "F" Then
                count_F += 1
            End If
            lstRecord.Items.Add(name)

            Dim provider As String
            Dim dataFile As String
            Dim connString As String
            Dim myConnection As OleDbConnection = New OleDbConnection

            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            dataFile = "C:\Users\200153308\source\repos\raychau271\Module-Grade-Calculator\student_record.accdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim Insert_Data As String
            Insert_Data = "Insert into student([Name],[Test],[Quizzes],[Project],[Exam],[CA_Marks],[Module_Marks],[Grade],[Remarks]) Values (?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(Insert_Data, myConnection)
            cmd.Parameters.Add(New OleDbParameter("Name", CType(name, String)))
            cmd.Parameters.Add(New OleDbParameter("Test", CType(test, Double)))
            cmd.Parameters.Add(New OleDbParameter("Quizzes", CType(quiz, Double)))
            cmd.Parameters.Add(New OleDbParameter("Project", CType(project, Double)))
            cmd.Parameters.Add(New OleDbParameter("Exam", CType(exam, Double)))
            cmd.Parameters.Add(New OleDbParameter("CA_Marks", CType(camark, Double)))
            cmd.Parameters.Add(New OleDbParameter("Module_Marks", CType(modulemark, Double)))
            cmd.Parameters.Add(New OleDbParameter("Grade", CType(txtGrade.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Remarks", CType(txtRemarks.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
            Catch ex As Exception

            End Try

        ElseIf valid_input < 4 Then 'If there are any invalid numbers, display error message 
            MessageBox.Show("Please Enter marks in between 0 - 100", "Invalid Input")
            Clear_Output()
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim find_name As String = txtFindName.Text
        Dim found As Boolean = False

        For i = 0 To lstRecord.Items.Count - 1 Step 1
            If find_name = lstRecord.Items(i) Then
                found = True
                MessageBox.Show(find_name & " found on line " & i + 1, "Student Search")
            End If
        Next
        If found = False Then
            MessageBox.Show(find_name & " not found")
        End If
    End Sub

    Private Sub btnStatistic_Click(sender As Object, e As EventArgs) Handles btnStatistic.Click
        If count_student = 0 Then
            MessageBox.Show("No student records", "Error")
            Return
        End If
        lblNumberofStudent.Text = CStr(count_student)
        lblAverage.Text = CStr(sum_marks / count_student)
        lblCountA.Text = CStr(count_A)
        lblCountF.Text = CStr(count_F)
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

    Function Validate_marks(ByVal mark As Double) As Integer 'validate marks input
        If mark >= 0 And mark <= 100 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Function Determine_Grade(ByVal camark As Double, ByVal exam As Double, ByVal modulemark As Double) As String 'Determine Grade
        Dim grade As String

        If ((camark < 40) Or (exam < 40)) Then
            grade = "F"
        ElseIf modulemark < 65 Then
            grade = "C"
        ElseIf modulemark < 75 Then
            grade = "B"
        Else
            grade = "A"
        End If
        Return grade
    End Function

    Function Determine_Remarks(ByVal grade As String, ByVal ModuleMarks As Double) As String 'Determine Remarks
        Dim remarks As String

        If grade = "F" And ModuleMarks < 30 Then
            remarks = "Restudy"
        ElseIf grade = "F" And ModuleMarks >= 30 Then
            remarks = "Resit Exam"
        Else
            remarks = "Pass"
        End If
        Return remarks
    End Function

End Class
