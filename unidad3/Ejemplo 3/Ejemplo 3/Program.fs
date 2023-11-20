open System


let esPalindromo (texto: string) =
    let textoReverso = new string(Array.rev (texto.ToCharArray()))
    texto = textoReverso

[<EntryPoint>]
let main args =
    let mutable continuar = true
    while continuar do
        printfn "Ingrese una palabra o frase:"
        let texto = System.Console.ReadLine()
        let resultado = if esPalindromo texto then "Es un palíndromo" else "No es un palíndromo"
        printfn "%s" resultado

        printfn "¿Desea ingresar otra palabra o frase? (S/N)"
        let respuesta = System.Console.ReadLine()
        continuar <- respuesta.ToUpper() = "S"

    0 // Exit code


