Public Class Form1

    Private airports() As String = {"MIA", "JFK", "LAX", "DFW"}
    Private utcOffsets() As Integer = {-5, -5, -10, -8, -6}
    Private travelTimes(,) As Double =
        {{0, 3, 12, 8, 2.5},
        {3, 0, 14, 8.5, 3.5},
        {12, 12, 0, 4.5, 8.5},
        {8, 8.5, 4.5, 0, 3.5},
        {2.5, 3.4, 8.5, 3.5, 0}}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDepartureDate.Value = Today

        For Each airport As String In airports
            cboDepartureAirport.Items.Add(airport)
            cboArrivalAirport.Items.Add(airport)
        Next
    End Sub
End Class
