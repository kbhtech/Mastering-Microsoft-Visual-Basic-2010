Imports System.Speech.Synthesis
Imports System.Runtime.CompilerServices

Module StringExtensions
    <Extension()> _
Public Sub Speak(ByVal s As String)
        Dim synth As New SpeechSynthesizer
        Dim voices As System.Collections.ObjectModel.ReadOnlyCollection(Of System.Speech.Synthesis.InstalledVoice) =
            synth.GetInstalledVoices()
        synth.SelectVoice(voices(0).VoiceInfo.Name)
        synth.Speak(s)
    End Sub

    <Extension()> _
Public Function FormatCurrency(ByVal d As Decimal) As String

    End Function

    <Extension()>
Public Function Inc(ByVal i As Integer) As Integer
        Return i + 1
    End Function
    <Extension()>
Public Function Dec(ByVal i As Integer) As Integer
        Return i - 1
    End Function

    <Extension()>
Public Sub Increase(ByRef i As Integer, ByVal inc As Integer)
        i += inc
    End Sub
    <Extension()>
Public Sub Decrease(ByRef i As Integer, ByVal dec As Integer)
        i -= dec
    End Sub

    <Extension()>
Public Function DeleteSelected(Of T)(ByVal source As IEnumerable(Of T), ByVal Criteria As Predicate(Of T)
                                      ) As IEnumerable(Of T)

    End Function
End Module
