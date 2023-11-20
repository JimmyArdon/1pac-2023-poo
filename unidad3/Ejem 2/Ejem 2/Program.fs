open System.Text.RegularExpressions

// Definimos un tipo para representar el registro de un estudiante (nombre y calificación)
type RegistroEstudiante = string * float

// Función auxiliar para agregar un nuevo registro de estudiante a la lista
let agregarRegistroEstudiante (nombreEstudiante: string) (calificacion: float) (registros: RegistroEstudiante list) =
    (nombreEstudiante, calificacion) :: registros

// Función auxiliar para buscar un registro de estudiante por nombre usando expresion regular
let buscarEstudiantePorNombre (patronNombre: string) (registros: RegistroEstudiante list) =
    let regex = new Regex(patronNombre, RegexOptions.IgnoreCase)
    registros |> List.filter (fun (nombre, _) -> regex.IsMatch(nombre))

// Expresión regular para validar el nombre del estudiante: solo letras y espacios permitidos
let nombreEstudianteRegex = new Regex("^[A-Za-záéíóúÁÉÍÓÚüÜñÑ\\s]+$")

// Expresión regular para validar la calificación: número decimal con o sin parte decimal
let calificacionRegex = new Regex("^\\d+(\\.\\d+)?$")

// Función auxiliar para validar el nombre del estudiante con la expresión regular
let validarNombreEstudiante (nombreEstudiante: string) =
    nombreEstudianteRegex.IsMatch(nombreEstudiante)

// Función auxiliar para validar la calificación con la expresión regular
let validarCalificacion (calificacion: string) =
    calificacionRegex.IsMatch(calificacion)

[<EntryPoint>]
let main argv =
    let mutable registrosEstudiantes = [] 

  
    registrosEstudiantes <- agregarRegistroEstudiante "Juan Pérez" 90.0 registrosEstudiantes
    registrosEstudiantes <- agregarRegistroEstudiante "María Mejia" 85.5 registrosEstudiantes

    let rec bucleConsola () =
        printfn "Elige una opción:"
        printfn "1. Agregar Registro de Estudiante"
        printfn "2. Buscar por Nombre de Estudiante (Regex)"
        printfn "3. Salir"
        match System.Console.ReadLine() with
        | "1" ->
            printfn "Ingresa el nombre del estudiante:"
            let nombre = System.Console.ReadLine()
            if validarNombreEstudiante nombre then
                printfn "Ingresa la calificación:"
                match System.Console.ReadLine() with
                | calificacionString when validarCalificacion calificacionString ->
                    let calificacion = System.Double.Parse(calificacionString)
                    registrosEstudiantes <- agregarRegistroEstudiante nombre calificacion registrosEstudiantes
                    printfn "Registro de estudiante agregado exitosamente.\n"
                    bucleConsola ()
                | _ ->
                    printfn "Calificación inválida. Por favor, ingresa un número válido.\n"
                    bucleConsola ()
            else
                printfn "Nombre inválido. Por favor, ingresa un nombre con letras y espacios solamente.\n"
                bucleConsola ()
        | "2" ->
            printfn "Ingresa el patrón de nombre para buscar (admite regex):"
            let patron = System.Console.ReadLine()
            let resultados = buscarEstudiantePorNombre patron registrosEstudiantes
            if List.isEmpty resultados then
                printfn "No se encontraron registros coincidentes.\n"
            else
                printfn "Registros coincidentes:"
                resultados |> List.iter (fun (nombre, calificacion) -> printfn "%s: %.1f" nombre calificacion)
            bucleConsola ()
        | "3" -> ()
        | _ ->
            printfn "Opción inválida. Por favor, elige una opción válida.\n"
            bucleConsola ()

    bucleConsola ()
    0
