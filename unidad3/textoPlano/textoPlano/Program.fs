open System
open System.IO
open System.Text.RegularExpressions

type PartidaNacimiento = {
    Nombre: string
    Apellido: string
    FechaNacimiento: string
    LugarNacimiento: string
    Genero: string
    NombrePadre: string
    NombreMadre: string
    NumeroRegistro: string
}


let cargarPartidasDeNacimiento (rutaArchivo: string) : PartidaNacimiento list =
    File.ReadLines(rutaArchivo)
    |> Seq.skip 1 
    |> Seq.map (fun line ->
        let columns = line.Split(',')
        {
            Nombre = columns.[0]
            Apellido = columns.[1]
            FechaNacimiento = columns.[2]
            LugarNacimiento = columns.[3]
            Genero = columns.[4]
            NombrePadre = columns.[5]
            NombreMadre = columns.[6]
            NumeroRegistro = columns.[7]
        })
    |> Seq.toList


let filtrarPorExpresionRegular (partidas: PartidaNacimiento list) (expresionRegular: string) : PartidaNacimiento list =
    let regex = new Regex(expresionRegular, RegexOptions.Compiled)
    partidas
    |> List.filter (fun partida ->
        regex.IsMatch(partida.Nombre) ||
        regex.IsMatch(partida.Apellido) ||
        regex.IsMatch(partida.FechaNacimiento) ||
        regex.IsMatch(partida.LugarNacimiento) ||
        regex.IsMatch(partida.Genero) ||
        regex.IsMatch(partida.NombrePadre) ||
        regex.IsMatch(partida.NombreMadre) ||
        regex.IsMatch(partida.NumeroRegistro)
    )


let rutaArchivoCSV = @"C:\Users\jorgi\Downloads\Datos.csv"

let partidasDeNacimiento = cargarPartidasDeNacimiento rutaArchivoCSV


let pedirExpresionRegular () =
    printfn "Ingresa una expresión regular para filtrar los registros de partida de nacimiento:"
    Console.ReadLine()

let rec procesarPreguntaFiltrado () =
    let expresionRegularFiltro = pedirExpresionRegular()
    if String.IsNullOrWhiteSpace(expresionRegularFiltro) then
        printfn "Saliendo del programa."
    else
        let partidasFiltradas = filtrarPorExpresionRegular partidasDeNacimiento expresionRegularFiltro


        if List.isEmpty partidasFiltradas then
            printfn "No se encontraron registros que coincidan con la expresión regular."
        else
            partidasFiltradas |> List.iter (fun partida ->
                printfn "Nombre:%s,Apellido:%s,FechaNacimiento:%s,LugarNacimiento:%s,Genero:%s,NombrePadre:%s,NombreMadre:%s,NumeroRegistro:%s"
                    partida.Nombre partida.Apellido partida.FechaNacimiento partida.LugarNacimiento partida.Genero partida.NombrePadre partida.NombreMadre partida.NumeroRegistro
            )
        procesarPreguntaFiltrado () 


procesarPreguntaFiltrado ()
