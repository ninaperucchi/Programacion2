Imports Entidades

Public Class Pelicula
    Implements Entidad
    Private _nombre As String
    Private _personajes As List(Of Personaje)

    Sub New()
        _nombre = ""
        _personajes = New List(Of Personaje)
    End Sub



    Public Property Nombre As String Implements Entidad.nombre
        Get
            Return _nombre
        End Get
        Set(value As String)

            If Len(value) > 5 Then
                _nombre = value
            Else
                Throw New ArgumentException("nombre muy corto")
            End If

        End Set
    End Property


    Public Sub AddPersonaje(personaje As Personaje)

        _personajes.Add(personaje)

    End Sub

    Public Function Creditos() As List(Of String)

        Dim lista As New List(Of String)
        For Each personajes As Personaje In _personajes
            lista.Add("actor:" & personajes.Actor.Nombre & "({0})" & personajes.Nombre)

        Next
        lista.Sort()
        Return lista
    End Function

    Public Function SumarSueldos() As Decimal
        Dim sumas As Decimal
        For Each personaje As Personaje In _personajes
            sumas = sumas + personaje.Sueldo

        Next
        Return sumas
    End Function

    Public Function TopSueldos() As List(Of String)
        For top As Integer = 1 To 3
            For Each personaje As Personaje In _personajes
                TopSueldos().Add("({0})" & personaje.Sueldo & "actor:" & personaje.Actor.Nombre)
            Next
        Next
        Return TopSueldos()
    End Function


    Public Overrides Function ToString() As String
        Return "nombre  " & _nombre
    End Function

End Class
