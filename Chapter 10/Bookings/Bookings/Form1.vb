Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim htlBooking As New HotelBooking
        htlBooking.BookingName = "Joe Taveller"
        htlBooking.BookingNumber = "PRN01202148"
        htlBooking.BookingRequestDate = Now
        htlBooking.checkInDate = #5/19/2010#
        htlBooking.checkOutDate = #5/22/2010#
        htlBooking.DestinationCountry = "Spain"
        htlBooking.DestinationCity = "Barcelona"
        htlBooking.HotelName = "Tower Hotel"
        htlBooking.Price = 680.99
        htlBooking.CreateBooking()

        Dim fltBooking As New FlightBooking
        fltBooking.DepartureDate = #5/19/2010 7:30:00 AM#
        fltBooking.ArrivalDate = #5/19/2010 9:45:00 AM#
        fltBooking.DestinationCode = "BCN"
        fltBooking.OriginCode = "JFK"
        fltBooking.BookingName = "Jow Traveller"
        fltBooking.BookingNumber = "PRN01202149"
        fltBooking.ConfirmationNumber = "008-9823118 CA11"
        fltBooking.Price = 1099.0
        fltBooking.CreateBooking()

        Dim totalPrice As Decimal = 0
        For Each bk In Booking.GetAllBookings
            totalPrice += bk.Price
        Next

        For Each bk In HotelBooking.GetAllBookings
            TextBox1.AppendText(bk.ToString & vbCrLf)
            TextBox1.AppendText("Reservation # " & bk.BookingNumber & "    " & bk.HotelName & vbCrLf)
        Next

        Dim selectedHotelBooking = HotelBooking.GetBookingByID("PRN01202148")
        TextBox1.AppendText(selectedHotelBooking.HotelName & vbCrLf)

        Dim selectedFlightBooking = Booking.GetBookingByID("008-9823118 CA11")
        If selectedFlightBooking IsNot Nothing Then
            TextBox1.AppendText(selectedFlightBooking.GetType.ToString & " " & selectedHotelBooking.BookingNumber & vbCrLf)
        Else
            TextBox1.AppendText("Booking 008-9823118 CA11 was not found in list of bookings" & vbCrLf)
        End If

        selectedFlightBooking = Booking.GetBookingByID("PRN01202149")
        If selectedFlightBooking IsNot Nothing Then
            TextBox1.AppendText(selectedFlightBooking.GetType.ToString & " " & selectedFlightBooking.BookingNumber & vbCrLf)
        Else
            Debug.WriteLine("Booking PRN01202149 was not found in list of bookings" & vbCrLf)
        End If
    End Sub
End Class
