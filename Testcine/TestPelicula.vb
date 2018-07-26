Imports Entidades
Module TestPelicula
    Sub Main()
        Dim titanic As New Pelicula
        Try
            titanic.Nombre = "titanic"
        Catch exc As Exception
            Console.WriteLine(exc.Message)
        Finally
            Console.ReadKey()
        End Try

        '        Dim it As New Pelicula
        '       Try
        '      titanic.Nombre = "it"
        '     Catch exc As Exception
        '    Console.WriteLine(exc.Message)
        '   Finally
        '  Console.ReadKey()
        ' End Try


        Dim actor As New Actor(#10/10/1987#, "yani")
        Dim actor2 As New Actor(#10/10/1940#, "gere")
        Dim actor3 As New Actor(#10/10/1933#, "maxi")
        Dim actor4 As New Actor(#10/10/1999#, "fabio")
        Dim actor5 As New Actor(#10/10/1988#, "gato")

        Dim personaje0 As New Personaje("quepes", actor, 3000)
        Dim personaje1 As New Personaje("caputo", actor2, 4000)
        Dim personaje2 As New Personaje("hada", actor3, 5000)
        Dim personaje3 As New Personaje("quep", actor4, 5000)
        Dim personaje4 As New Personaje("pesada", actor5, 8000)

        titanic.AddPersonaje(personaje0)
        titanic.AddPersonaje(personaje1)
        titanic.AddPersonaje(personaje2)
        titanic.AddPersonaje(personaje3)
        titanic.AddPersonaje(personaje4)

        Console.WriteLine(titanic.SumarSueldos())
        Console.WriteLine(titanic.TopSueldos())
        Console.WriteLine(titanic.ToString())


        Console.ReadKey()


    End Sub
End Module
