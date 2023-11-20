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
        let resultado = if esPalindromo texto then "Es un pal�ndromo" else "No es un pal�ndromo"
        printfn "%s" resultado

        printfn "�Desea ingresar otra palabra o frase? (S/N)"
        let respuesta = System.Console.ReadLine()
        continuar <- respuesta.ToUpper() = "S"

    0 // Exit code


