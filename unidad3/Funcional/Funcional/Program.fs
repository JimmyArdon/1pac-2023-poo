open System

let sumar x y = x + y
let restar x y = x - y
let multiplicar x y = x * y
let dividir x y = x / y

let rec calcular() =
    printfn "=== CALCULADORA ==="
    printfn "Ingrese el primer numero:"
    let mutable num1 = Console.ReadLine() |> float
    printfn "Ingrese el segundo numero:"
    let mutable num2 = Console.ReadLine() |> float

    let rec realizarOperacion() =
        printfn "Seleccione una operacion:"
        printfn "1. Sumar"
        printfn "2. Restar"
        printfn "3. Multiplicar"
        printfn "4. Dividir"

        let opcion = Console.ReadLine() |> int

        match opcion with
        | 1 -> 
            let resultado = sumar num1 num2
            printfn "El resultado de la suma es: %f" resultado
        | 2 -> 
            let resultado = restar num1 num2
            printfn "El resultado de la resta es: %f" resultado
        | 3 -> 
            let resultado = multiplicar num1 num2
            printfn "El resultado de la multiplicacion es: %f" resultado
        | 4 -> 
            let resultado = dividir num1 num2
            printfn "El resultado de la division es: %f" resultado
        | _ -> 
            printfn "Opción invalida. Intente nuevamente."
            realizarOperacion()

    let mutable repetirOpcion = ""
    while repetirOpcion.ToUpper() <> "N" do
        realizarOperacion()
        printfn "¿Desea hacer otra operacion con los mismos numeros? (S/N)"
        repetirOpcion <- Console.ReadLine() |> string
        if repetirOpcion.ToUpper() = "N" then
            printfn "¿Desea hacer otra operacion con numeros diferentes? (S/N)"
            repetirOpcion <- Console.ReadLine() |> string
            if repetirOpcion.ToUpper() = "S" then
                printfn "Ingrese el primer numero:"
                num1 <- Console.ReadLine() |> float
                printfn "Ingrese el segundo numero:"
                num2 <- Console.ReadLine() |> float

    printfn "Saliendo del programa"

[<EntryPoint>]
let main argv =
    calcular()
    0 // Valor de retorno del programa



