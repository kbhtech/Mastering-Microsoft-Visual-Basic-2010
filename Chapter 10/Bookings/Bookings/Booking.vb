
Public Enum ReservationType
    HotelReservation
    CarReservation
    FlightReservation
End Enum

Public MustInherit Class Booking

    Protected Shared Bookings As New List(Of Booking)

    Protected Property Type As ReservationType
    Public ReadOnly Property BookingType As ReservationType
        Get
            Return Type
        End Get
    End Property
    Public Property BookingRequestDate As Date
    Protected Property BookingStartDate As Date
    Protected Property BookingEndDate As Date
    Public Property BookingName As String
    Public Property BookingNumber As String
    Public Property ProviderName As String
    Public Property Price As Decimal

    Public Overrides Function ToString() As String
        Return BookingNumber & "/" & BookingName
    End Function

    Public Shared Function GetAllBookings() As List(Of Booking)
        Return Bookings
    End Function

    Public Shared Function GetBookingByID(ByVal bookingID As String) As Booking
        Dim selectedBooking = (From bk In Bookings
                              Where bk.BookingNumber = bookingID
                              Select bk).FirstOrDefault
        Return selectedBooking
    End Function

End Class

Public Class HotelBooking
    Inherits Booking

    Public Property DestinationCountry As String
    Public Property DestinationCity As String
    Public Property HotelName As String
    Public Property checkInDate As Date
        Get
            Return MyBase.BookingStartDate
        End Get
        Set(ByVal value As Date)
            MyBase.BookingStartDate = value
        End Set
    End Property

    Public Property checkOutDate As Date
        Get
            Return MyBase.BookingEndDate
        End Get
        Set(ByVal value As Date)
            MyBase.BookingEndDate = value
        End Set
    End Property

    Public Sub New()
        Type = ReservationType.HotelReservation
    End Sub

    Public Overrides Function ToString() As String
        Return "HOTEL BOOKING: " & MyBase.BookingNumber & "/" & MyBase.BookingName
    End Function

    Public Sub CreateBooking()
        Bookings.Add(Me)
    End Sub

    Public Overloads Shared Function GetBookingByID(ByVal bookingID As String) As HotelBooking
        Dim selectedBooking = (From bk In Bookings
                              Where bk.BookingNumber = bookingID And bk.BookingType = ReservationType.HotelReservation
                              Select bk).FirstOrDefault
        Return selectedBooking
    End Function

    Public Sub GetBookingsByName()

    End Sub

    Public Overloads Shared Function GetAllBookings() As List(Of HotelBooking)
        Dim hotelBookings As New List(Of HotelBooking)
        For Each bk In Bookings
            If bk.BookingType = ReservationType.HotelReservation Then
                hotelBookings.Add(bk)
            End If
        Next
        Return hotelBookings
    End Function
End Class

Public Class FlightBooking
    Inherits Booking

    Public Property OriginCode As String
    Public Property DestinationCode As String
    Public Property DepartureDate As DateTime
    Public Property ArrivalDate As DateTime
    Public Property ConfirmationNumber As String

    Public Sub New()
        Type = ReservationType.FlightReservation
    End Sub

    Public Overrides Function ToString() As String
        Return "FLIGHT BOOKING: " & MyBase.BookingNumber & "/" & MyBase.BookingName
    End Function

    Public Sub CreateBooking()
        Bookings.Add(Me)
    End Sub

    Public Overloads Shared Function GetBookingByID(ByVal bookingID As String) As FlightBooking
        Dim selectedBooking = (From bk In Bookings
                              Where bk.BookingNumber = bookingID And bk.BookingType = ReservationType.FlightReservation
                              Select bk).FirstOrDefault
        Return selectedBooking
    End Function

    Public Sub GetBookingsByName()

    End Sub

    Public Overloads Shared Function GetAllBookings() As List(Of FlightBooking)
        Dim flightBookings As New List(Of FlightBooking)
        For Each bk In Bookings
            If bk.BookingType = ReservationType.FlightReservation Then
                flightBookings.Add(bk)
            End If
        Next
        Return flightBookings
    End Function
End Class

Public Class CarBooking
    Inherits Booking

    Public Property PickupLocation As String
    Public Property DropoffLocation As String
    Public Property CarType As String
    Public Property PickupDate As Date
        Get
            Return MyBase.BookingStartDate
        End Get
        Set(ByVal value As Date)
            MyBase.BookingStartDate = value
        End Set
    End Property

    Public Property DropoffDate As Date
        Get
            Return MyBase.BookingEndDate
        End Get
        Set(ByVal value As Date)
            MyBase.BookingEndDate = value
        End Set
    End Property

    Public Sub New()
        Type = ReservationType.CarReservation
    End Sub

    Public Overrides Function tostring() As String
        Return "car booking: " & MyBase.BookingNumber & "/" & MyBase.BookingName
    End Function

    Public Sub CreateBooking()
        Bookings.Add(Me)
    End Sub

    Public Overloads Shared Function GetBookingByID(ByVal bookingID As String) As CarBooking
        Dim selectedBooking = (From bk In Bookings
                              Where bk.BookingNumber = bookingID And bk.BookingType = ReservationType.CarReservation
                              Select bk).FirstOrDefault
        Return selectedBooking
    End Function

    Public Sub GetBookingsByName()

    End Sub

    Public Overloads Shared Function GetAllBookings() As List(Of CarBooking)
        Dim carBookings As New List(Of CarBooking)
        For Each bk In Bookings
            If bk.BookingType = ReservationType.CarReservation Then
                carBookings.Add(bk)
            End If
        Next
        Return carBookings
    End Function
End Class
