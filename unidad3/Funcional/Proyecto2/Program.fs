open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

let longitudCadena texto =
    String.length texto

[<EntryPoint>]
let main argv =
    let texto = "Hola, mundo!"
    let longitud = longitudCadena texto
    printfn "La longitud de la cadena \"%s\" es %d" texto longitud
    0 // Valor de retorno del programa

