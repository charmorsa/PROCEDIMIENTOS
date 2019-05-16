Imports System
Imports System.DateTime
Module Program
    Sub Main(args As String())
        hora_actual()
        Console.WriteLine(" LA HORA ES " & OBTENER_HORA())
    End Sub

    Sub hora_actual()
        Console.Write("hoy es: " & Now.Date)
    End Sub

    Function OBTENER_HORA() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
