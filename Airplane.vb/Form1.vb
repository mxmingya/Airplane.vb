Public Class FrmAirplane
    ' global variables declared here
    Dim Seat(9, 3) As String
    Dim order As String = "ABCD"
    Dim waitList As New List(Of String)()
    'waitList contains the names of passengers who are waiting for a seat
    Dim map As New System.Collections.Generic.Dictionary(Of String, String)
    ' map is a collection maps the passengers' names to their desire seats 


    'EVENT SUBROUTINES
    Private Sub FrmAirplane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySeatingChart()
    End Sub

    Private Sub AddPassengerButton_Click(sender As Object, e As EventArgs) Handles AddPassengerButton.Click
        Dim name As String = NameBox.Text
        Dim location As String = LocationBox.Text
        Dim parsedLocation = parseLocation(location)
        Dim row As String = parsedLocation(0)
        Dim col As String = parsedLocation(1)

        'detect invalid input
        If row > 9 Or row < 0 Or col > 3 Or col < 0 Or name = "" Then
            MsgBox("invalid input, please choose a valid seat or type a valid name")
        Else
            addPassenger(location, name)
            DisplaySeatingChart()
        End If

        NameBox.Text = ""
        LocationBox.Text = ""

    End Sub

    Private Sub DeletePassengerButton_Click(sender As Object, e As EventArgs) Handles DeletePassengerButton.Click
        If (NameBox.Text = "") Then
            MsgBox("Please type a valid name")
        Else
            removePassenger(NameBox.Text)
        End If
        DisplaySeatingChart()
    End Sub

    'UTILITY FUNCTIONS AND SUBROUTINES
    Private Sub DisplaySeatingChart()
        SeatListBox.Items.Clear()
        For row As Integer = 0 To 9
            Dim rowStr As String = ""
            For col As Integer = 0 To 3
                If Seat(row, col) = "" Then
                    rowStr &= ". "
                Else
                    rowStr &= "X "
                End If

                If col = 1 Then
                    rowStr &= " "
                End If
            Next
            SeatListBox.Items.Add(rowStr)
        Next
    End Sub

    Private Function parseLocation(Location As String)
        Dim row As Integer
        Dim col As Integer
        If (Location.Length = 3) Then
            ' handle cases like 10A
            row = CInt(Location.Substring(0, 2)) - 1
            Dim s As String = Location.Substring(2, 1)
            col = order.IndexOf(s)
        Else
            row = CInt(Location.Substring(0, 1)) - 1
            Dim s As String = Location.Substring(1, 1)
            col = order.IndexOf(s)
        End If
        Return {row, col}
    End Function

    Private Sub addPassenger(location As String, name As String)
        'Dim strs As String = location.ToCharArray
        Dim locations() As Integer = parseLocation(location)
        Dim row = locations(0)
        Dim col = locations(1)

        'if the requested seat is currently available
        If Seat(row, col) = "" Then

            If map.ContainsKey(name) Then
                Dim preLocation = parseLocation(map.Item(name))
                Dim preRow As Integer = preLocation(0)
                Dim preCol As Integer = preLocation(1)
                map.Remove(name)
                Seat(preRow, preCol) = ""
            End If
            map.Add(name, location)
            Seat(row, col) = name

            'selected seat was took but there are other seats available
        ElseIf spotAvailable() Then
            MsgBox("Selected Seat is occupied, please choose a difference one")

            'waitlist is not full and there aint seats available
        ElseIf Not spotAvailable() And waitList.Count < 9 Then
            waitList.Add(name)
            displayWaitList()

            'no seats available and the waitlist is full
        Else
            MsgBox("Sorry we have all seats sold out and wait list is full. Please check later for available seats")
        End If
    End Sub

    Private Function spotAvailable()
        ' check if there are any seats available in the flight, if so, return True, otherwise return False
        For row As Integer = 0 To 9
            For col As Integer = 0 To 3
                If Seat(row, col) = "" Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub removePassenger(name As String)
        'delete the passenger from seat
        If map.ContainsKey(name) Then
            Dim location = map(name)
            Dim parsedLocation = parseLocation(location)
            Dim row As Integer = parsedLocation(0)
            Dim col As Integer = parsedLocation(1)
            map.Remove(name)

            'if there are people in the wait list, give the new available seat to the waiting passenger
            'otherwise mark the seat as avaiable
            If (waitList.Count > 0) Then
                Dim firstPassenger As String = waitList.First
                waitList.Remove(firstPassenger)
                map.Add(firstPassenger, location)
            Else
                Seat(row, col) = ""
            End If
            DisplaySeatingChart()

            'delete the passenger from the wait list
        ElseIf waitList.Contains(name) Then
            waitList.Remove(name)
            displayWaitList()
        Else
            MsgBox("Cannot find passenger " & name & " to remove, please check again")
        End If

    End Sub

    Private Sub displayWaitList()
        For Each n As String In waitList
            WaitListBox.Items.Add(n)
        Next
    End Sub
End Class
