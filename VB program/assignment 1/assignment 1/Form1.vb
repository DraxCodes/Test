'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
'x          Programmed by: Joel Parkinson              x
'x           Last Updated: 11th April 2015             x
'x           Program Name: BTEC Grading Calculator     x
'x    Purpose: BTEC lvl 3: Programming Assignment      x
'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

Public Class form1
    Dim info As String = "This is the BTEC Level 3 Grading Calculator Version 6.0. Created by Joel Parkinson"
    Dim checker As Int32 = 0                'Varibale is used for cleanup, DO NOT EDIT OR REMOVE!


    'Public variables (Can be edited if desired)
#Region "Public Editable Variables"
    '                     !!Editable section!!
    'This section is where you can set each variable for the program.
    'Each one can be set to an integer(number) that corisponds to the years value for each.
    'Example: If you set unitValue to 20 instead of 10, that would mean the value per unit used in the calculation would also be 20.
    'This same rule applies for all other variables in this section.
    Dim unitValue As Int32 = 10             '< -- Variable for unit value
    Dim pass As Int32 = 7                   '< -- Variable for pass value
    Dim merit As Int32 = 8                  '< -- Variable for merit value
    Dim dist As Int32 = 9                   '< -- Variable for distinction value
    Dim numUnits As Int32 = 18              '< -- Variable for number of units required to be entered

    'This section is to set the minimum and maximum points for each grade.
    'Example: If the required points for Pass Pass Pass changes from anything between 1260 and 1299 (Current default) then you would set the minPPP to the current 
    'required minimum points for PPP and the maxPP to the maximum cap for PPP.
#Region "Min/Max points required per grade"
    'PPP
    Dim minPPP As Int32 = 1260
    Dim maxPPP As Int32 = 1299
    'MPP
    Dim minMPP As Int32 = 1300
    Dim maxMPP As Int32 = 1339
    'MMP
    Dim minMMP As Int32 = 1340
    Dim maxMMP As Int32 = 1379
    'MMM
    Dim minMMM As Int32 = 1380
    Dim maxMMM As Int32 = 1419
    'DMM
    Dim minDMM As Int32 = 1420
    Dim maxDMM As Int32 = 1459
    'DDM
    Dim minDDM As Int32 = 1460
    Dim maxDDM As Int32 = 1499
    'DDD
    Dim minDDD As Int32 = 1500
    Dim maxDDD As Int32 = 1529
    'D*DD
    Dim minDsDD As Int32 = 1530
    Dim maxDsDD As Int32 = 1559
    'D*D*D
    Dim minDsDsD As Int32 = 1560
    Dim maxDsDsD As Int32 = 1589
    'D*D*D*
    Dim DsDsDs As Int32 = 1590
#End Region

    '                    !!End of editable section!!
#End Region



    'Please don't edit below this line if you don't know what you're doing.

    'Calculate button region
#Region "Button - Calculate"
    'On click event (Do not edit this!)
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        check()
    End Sub
#End Region

    'Check function region
#Region "Function - check"
    'This is where all the magic happens
    'Sub that Calculates results and checks if the amount of units entered entered is above, below or equal to the required 18 units.
    Private Sub check()

        Dim result, remaining As Int32
        remaining = Val(txtbPass.Text) + Val(txtbMerit.Text) + Val(txtbDist.Text)                       '< -- Variables for amount of units entered
        'Calculates result using the calc function
        result = calc(Val(txtbPass.Text), Val(txtbMerit.Text), Val(txtbDist.Text), unitValue)
        'If statement checks if units entered are below 18
        If remaining = numUnits Then
            lblRemainingtxt.Visible = False
            Select Case result                  '< -- Select case statement checks the result calculation against what grade a person should get
                Case minPPP To maxPPP
                    checker = 1
                    lblResult.Text = "PPP"
                    PictureBox1.Image = imgList.Images.Item(0)
                Case minMPP To maxMPP
                    checker = 1
                    lblResult.Text = "MPP"
                    PictureBox1.Image = imgList.Images.Item(1)
                Case minMMP To maxMMP
                    checker = 1
                    lblResult.Text = "MMP"
                    PictureBox1.Image = imgList.Images.Item(1)
                Case minMMM To maxMMM
                    checker = 1
                    lblResult.Text = "MMM"
                    PictureBox1.Image = imgList.Images.Item(1)
                Case minDMM To maxDMM
                    checker = 1
                    lblResult.Text = "DMM"
                    PictureBox1.Image = imgList.Images.Item(2)
                Case minDDM To maxDDM
                    checker = 1
                    lblResult.Text = "DDM"
                    PictureBox1.Image = imgList.Images.Item(2)
                Case minDDD To maxDDD
                    checker = 1
                    lblResult.Text = "DDD"
                    PictureBox1.Image = imgList.Images.Item(2)
                Case minDsDD To maxDsDD
                    checker = 1
                    lblResult.Text = "D* DD"
                    PictureBox1.Image = imgList.Images.Item(2)
                Case minDsDsD To maxDsDsD
                    checker = 1
                    lblResult.Text = "D* D* D"
                    PictureBox1.Image = imgList.Images.Item(3)
                Case Is >= DsDsDs
                    checker = 1
                    lblResult.Text = "D* D* D*"
                    PictureBox1.Image = imgList.Images.Item(3)
            End Select
        ElseIf remaining > numUnits Then                                        '<-- This triggers if the ammount of units entered is more than the required amount.
            lblRemaining.Visible = False
            lblRemainingtxt.Visible = True
            lblRemainingtxt.Text = "Too many entered"
            checker = 2
        ElseIf remaining < numUnits Then                                        '<-- This triggers if the ammount of units entered is less than the required amount.
            lblRemainingtxt.Visible = True
            lblRemaining.Visible = True
            lblRemainingtxt.Text = "Not enough entered. Remaining: "
            lblRemaining.Text = Convert.ToString(numUnits - remaining)
            checker = 4
        End If
        clear()

    End Sub
#End Region


    'Quits application when quit is clicked (Do not edit this!)
#Region "Quit"
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region


    'Resets form (Do not edit this!)
#Region "Reset"
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        checker = 3
        clear()
    End Sub
#End Region

    'Information button, open messagebox to display program information (Do not edit this!)
#Region "Information"
    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        MessageBox.Show(info)
    End Sub
#End Region

    'Shows a help dialog when the help button is pressed.
#Region "Help"
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim msg_help = "To use this program you simply enter the number of passes, merits, distinctions the student or yourself atained into the defined text boxes. Was this helpful?"
        Dim msg_yes = "I am glad I could help! - Joel Parkinson"
        Dim msg_no = "If you need more help please contact joelparkinson@live.co.uk or seek help from a colegue/teacher"
        Dim title = "Help Dialog"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information
        Dim response = MsgBox(msg_help, style, title)
        If response = MsgBoxResult.Yes Then
            MsgBox(msg_yes, , title)
        Else
            MsgBox(msg_no, , title)
        End If
    End Sub
#End Region

    'This is where my functions are stored for the program to run correctly.
#Region "Functions"

    'Funtion to calculate amount of points awarded to pupil (Do not edit! Values are set at the top in the variable section!!)
    Function calc(ByVal p As Int32, ByVal m As Int32, ByVal d As Int32, ByVal value As Int32) As Int32
        Return (pass * p * value) + (merit * m * value) + (dist * d * value)
    End Function

    'Sub to clear text boxes based on which needs to be cleared (Do not edit unless more clear functions need adding!)
    Private Sub clear()
        Select Case checker
            Case 1                                      '<-- Clears unused items when the program is reused without resetting (sort of a debug feature).
                lblRemaining.Visible = False
                checker = 0
            Case 2                                      '<-- Clear function to clear unused items when the number of units entered is more than what is required.
                PictureBox1.Image = Nothing
                lblResult.Text = "Not Entered"
                checker = 0
            Case 3                                      '<-- Clear function when reset is clicked
                txtbPass.Text = ""
                txtbMerit.Text = ""
                txtbDist.Text = ""
                PictureBox1.Image = Nothing
                lblRemainingtxt.Visible = False
                lblRemaining.Visible = False
                lblResult.Text = "Not Entered"
                checker = 0
            Case 4                                      '<-- Clear function to clear unused items when the number of units entered is less than what is required.
                PictureBox1.Image = Nothing
                lblResult.Text = "Not Entered"
                checker = 0
        End Select
    End Sub

#End Region


End Class
