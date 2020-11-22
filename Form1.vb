'Imports System.IO
Imports System.Data.OleDb

Public Class frmModuleGradeCalculator
    'Const provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim filepath As String = Directory.GetCurrentDirectory
    'Dim dataFile As String = filepath & "\student_record.accdb"
    'Dim connString As String = provider & dataFile
    'Dim myConnection As OleDbConnection = New OleDbConnection

    Const provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    Const dataFile As String = "C:\Users\Raymond Chau\Desktop\VB\Module Grade Calculator\student_record.accdb"
    Const connString As String = provider & dataFile
    Dim myConnection As OleDbConnection = New OleDbConnection

    Const Test_percentage As Double = 0.5
    Const Quiz_percentage As Double = 0.2
    Const Project_percentage As Double = 0.3
    Const CA_percentage As Double = 0.4
    Const Exam_percentage As Double = 0.6

    Dim count_A As Integer
    Dim count_F As Integer
    Dim count_student As Integer
    Dim sum_marks As Double

    Dim drag As Boolean 'Mouse down/release
    Dim mousex As Integer 'Mouse position
    Dim mousey As Integer

    Private Sub frmModuleGradeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Actions when the program started
        lblCAComponents.Text = "CA Components: Test:" & Test_percentage * 100 & "%, Quiz:" & Quiz_percentage * 100 & "%, Project:" _
                                & Project_percentage * 100 & "%" 'Display CA components
        grpResult.Text = "Module Result (CA:" & CA_percentage * 100 & "%, Exam:" & Exam_percentage * 100 & "%)" 'Add module components to groupbox
        lblAverage.Text = ""
        lblNumberofStudent.Text = ""
        lblCountA.Text = ""
        lblCountF.Text = ""

        myConnection.ConnectionString = connString 'Connect to Database 
        myConnection.Open()

        Dim query_Name As String = "Select Name FROM student" 'Declare SQL statement
        Dim cmd As OleDbCommand = New OleDbCommand(query_Name, myConnection)
        Dim record As OleDbDataReader

        record = cmd.ExecuteReader
        Do While (record.Read()) 'Read record from database until no record found
            lstRecord.Items.Add(record(0)) 'Display stored record to listbox 
        Loop

        myConnection.Close() 'Disconnect from database
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click 'Actions when click confirm button
        Dim name As String
        Dim test, quiz, project, exam, camark, modulemark As Double
        Dim valid_input As Integer '5 = invalid name 4 = valid 0-3 = invalid numbers

        If (txtName.Text = "") Or IsNumeric(txtName.Text) Then 'Check student name which is cannot be empty and a number
            MessageBox.Show("Please Enter a Valid Student Name", "Invalid Input")
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
            MessageBox.Show("Please Enter Valid Number", "Invalid Input")
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

            count_student += 1 'Accumulate number of student
            sum_marks += modulemark 'Accumulate totel marks
            If txtGrade.Text = "A" Then 'Accumulate count of A/F
                count_A += 1
            ElseIf txtGrade.Text = "F" Then
                count_F += 1
            End If
            lstRecord.Items.Add(name) 'Add student name to listbox

            myConnection.ConnectionString = connString 'Connect to Database
            myConnection.Open()

            Dim Insert_Data As String 'Declare SQL statement
            Insert_Data = "INSERT INTO student([Name],[Test],[Quizzes],[Project],[Exam],[CA_Marks],[Module_Marks],[Grade],[Remarks]) Values (?,?,?,?,?,?,?,?,?)"
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

            cmd.ExecuteNonQuery() 'Use for add, update, delete record
            cmd.Dispose()
            myConnection.Close() 'Disconncet from database

        ElseIf valid_input < 4 Then 'If there are any invalid numbers, display error message 
            MessageBox.Show("Please Enter marks in between 0 - 100", "Invalid Input")
            Clear_Output()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click 'Search Student record
        myConnection.ConnectionString = connString 'Connect to database
        myConnection.Open()

        Dim query_record As String
        query_record = "Select * FROM student WHERE Name = '" & txtFindName.Text & "'" 'Declare SQL statement
        Dim cmd As OleDbCommand = New OleDbCommand(query_record, myConnection)
        Dim record As OleDbDataReader

        record = cmd.ExecuteReader
        record.Read() 'Read record from database

        If record.HasRows Then 'If found record 
            MessageBox.Show("Name: " & record(1) & Environment.NewLine _
                        & "Test: " & record(2) & Environment.NewLine _
                        & "Quizzes: " & record(3) & Environment.NewLine _
                        & "Project: " & record(4) & Environment.NewLine _
                        & "Exam: " & record(5) & Environment.NewLine _
                        & "CA Marks: " & record(6) & Environment.NewLine _
                        & "Module Marks: " & record(7) & Environment.NewLine _
                        & "Grade: " & record(8) & Environment.NewLine _
                        & "Remarks: " & record(9), "Student Record")
        ElseIf txtFindName.Text = "" Or IsNumeric(txtFindName.Text) Then 'Display error message when there is no input
            MessageBox.Show("Please Enter a Student Name", "Invalid Input")
        Else 'Display error meaasge when record not found
            MessageBox.Show(txtFindName.Text & " Not Found", "Error")
        End If

        myConnection.Close() 'Disconnect from database
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim find_name As String = txtFindName.Text 'Store student name to a variable
        Dim found As Boolean = False 'Default record not found

        For i = 0 To lstRecord.Items.Count - 1 Step 1 'Search Student Name in listbox
            If find_name.Trim = lstRecord.Items(i) Then
                found = True
                MessageBox.Show(find_name & " Found on Line " & i + 1, "Student Record")
            End If
        Next

        If txtFindName.Text = "" Or IsNumeric(txtFindName.Text) Then 'Display Error Message while there is no input or no such record
            MessageBox.Show("Please Enter a Student Name", "Invalid Input")
        ElseIf found = False Then
            MessageBox.Show(find_name & " Not Found", "Error")
        End If
    End Sub

    Private Sub btnStatistic_Click(sender As Object, e As EventArgs) Handles btnStatistic.Click
        myConnection.ConnectionString = connString 'Connect to Database
        myConnection.Open()

        Dim query_countA As String = "SELECT COUNT(Grade) FROM student WHERE Grade = 'A'" 'Declare SQL Statement for counting numbers of student that have Grade A
        Dim cmdA As OleDbCommand = New OleDbCommand(query_countA, myConnection)
        Dim countA As OleDbDataReader

        countA = cmdA.ExecuteReader
        countA.Read() 'Read record from database
        lblCountA.Text = countA(0) 'Display record

        Dim query_countF As String = "SELECT COUNT(Grade) FROM student WHERE Grade = 'F'" 'Declare SQL Statement for counting numbers of student that have Grade A
        Dim cmdF As OleDbCommand = New OleDbCommand(query_countF, myConnection)
        Dim countF As OleDbDataReader

        countF = cmdF.ExecuteReader
        countF.Read() 'Read record from database
        lblCountF.Text = countF(0) 'Display record

        Dim query_countStu As String = "SELECT COUNT(ID) FROM student" 'Declare SQL Statement for counting numbers of record(s) each record represent one student
        Dim cmdStu As OleDbCommand = New OleDbCommand(query_countStu, myConnection)
        Dim countStu As OleDbDataReader

        countStu = cmdStu.ExecuteReader
        countStu.Read() 'Read record from database
        lblNumberofStudent.Text = countStu(0) 'Display record

        Dim query_Avg As String = "SELECT AVG(Module_Marks) FROM student"
        Dim cmdAvg As OleDbCommand = New OleDbCommand(query_Avg, myConnection)
        Dim Avg As OleDbDataReader

        Avg = cmdAvg.ExecuteReader
        Avg.Read() 'Read record from database

        Try 'Disconnect from database when there is a Null
            lblAverage.Text = Math.Round(Avg(0), 2) 'Display record and round up to 2 d.p.
            cmdAvg.Dispose()
            myConnection.Close() 'Disconnect from database
        Catch ex As Exception
            lblAverage.Text = "0" 'When the record is null than display 0 as average
        End Try

        myConnection.Close() 'disconnect from database
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
