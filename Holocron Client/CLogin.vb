Public Class CLogin

    Dim orchconnected As Boolean = False
    Dim orchpointer As String
    Dim user As String
    Dim pass As String


    Private Sub CLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Ensure that all variables have their respective values assigned
        orchpointer = txtOrch.Text()
        user = txtUser.Text()
        pass = txtPass.Text()

        'Have dev debug credentials been specified?
        If user = "holodebug" And pass = "HolocronDebuger" Then
            MessageBox.Show("Debug Credentials have been provided")
            Exit Sub
        End If

        'Check to make sure all feilds have a value. Handle error collection.
        If orchpointer Is Nothing Then
            MessageBox.Show("An Orchestrator must be specified. Please enter either the IP address or the hostname of the Orchestrator.", "Login failed")
        ElseIf orchconnected! = True Or False Then
            MessageBox.Show("Unfortunately, something went wrong, and Holocron cannot process the operation. If this problem persists, please contact support. Error Details: orchconnected does not contain a value when it should", "Something went wrong")
        ElseIf orchconnected = False Then
            MessageBox.Show("An Orchestrator connection is required to login. Please confirm connection to an Orchestrator is established before trying to log in again.", "Login failed")
        ElseIf user = "" And pass = "" And chkWinCred.Checked = False Then
            MessageBox.Show("No username or password was specified. Please enter login credentials or check the 'Login using Windows Credentials' box to continue with Windows Credentials.", "Login failed")
        ElseIf user = "" And pass = "" And chkWinCred.Checked = True Then
            MessageBox.Show("Unfortunately, something went wrong, and Holocron cannot process the operation. If this problem persists, please contact support. Error Details: Windows reported empty login credentials to Holocron", "Something went wrong")
        ElseIf user = "" Or pass = "" And chkWinCred.Checked = False Then
            MessageBox.Show("Both username and password are required. Please ensure both have been specified or check the 'Login using Windows Credentials' box to continue with Windows Credentials.", "Login failed")
        ElseIf user IsNot "" And pass = "" And chkWinCred.Checked = True Then
            MessageBox.Show("Unfortunately, something went wrong, and Holocron cannot process the operation. If this problem persists, please contact support. Error Details: Windows reported empty password value to Holocron", "Something went wrong")
        ElseIf user = "" And pass IsNot "" And chkWinCred.Checked = True Then
            MessageBox.Show("Unfortunately, something went wrong, and Holocron cannot process the operation. If this problem persists, please contact support. Error Details: Windows reported empty username value to Holocron", "Something went wrong")
        End If



    End Sub
End Class
