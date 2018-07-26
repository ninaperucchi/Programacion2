Imports Entidades
Module TesPersonaje

    Sub Main()
        Dim personaje As New Personaje
        Dim actor As New Actor
        personaje.Nombre = "raul"
        actor.FechaNacimiento = #10/10/1987#
        personaje.Sueldo = 456543
        personaje.Actor.nombre = "culo"
        actor.nombre = "culo"
        Console.WriteLine(personaje.ToString)
        Console.ReadKey()


    End Sub

End Module
