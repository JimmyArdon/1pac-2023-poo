open System


let longitudCadena (texto: string) =
    String.length texto

[<EntryPoint>]
let main argv =
    printfn "Ingrese una cadena de texto:"
    let texto = System.Console.ReadLine()
    let longitud = longitudCadena texto
    printfn "La longitud de la cadena \"%s\" es %d" texto longitud
    0 // Valor de retorno del programa
