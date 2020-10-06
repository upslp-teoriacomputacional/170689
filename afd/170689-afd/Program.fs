// Learn more about F# at http://fsharp.org

(* 
Camila Alejandra García López
Teoria Computacional
Prof. Juan Carlos González Ibarra
Universidad Politécnica de San Luis Potosi
170689
*)


open System
open System.Text.RegularExpressions //Para las expresiones regulares

//Declaramos las variables mutables para que su valor pueda ser modificado mas adelante
let mutable simbolo = ""
let mutable fin = ""


[<EntryPoint>]
let main argv =
    
    //Se define la funcion de caracter
    let caracter (character) : int = 
        simbolo <- ""
        fin <- ""
        let mutable digito = "[0-9]"
        let mutable operador = "(\+|\-|\*|\/)"
        let mutable x:char = 'e'

        //Hacemos la comparación para saber si es digito o caracter 
        if Regex.IsMatch(character, digito) then
            simbolo <- "Digito"
            0
        elif Regex.IsMatch(character, operador) then
            simbolo <- "Operador"
            1
        elif character.Equals(fin) then 
            2
        else //Si no es digito o caracter. Entonces es un caracter No valido
            printfn "Caracter NO valido"
            3

    //Declaramos la funcion body
    let body ()=
        printfn "+--------------+----------+--------------+---------------+"

    //Definimos la funcion encabezado
    let encabezado ()=
        printfn "|  Edo. Actual | Caracter |  Simbolo\t |Edo. Siguiente |"
        body()
    
    //Definimos la funcion contenido la cual guarde e imprime el valor despues de encontrarlo en un ciclo 
    let contenido (edosig, character, simbolo, estado)=
        printfn "|     %A        |   %A    | %A\t |       %A       |" edosig character simbolo estado
        body()
    
    //Tabla de transiciones del automata AFD donde 
    //tabla=[[1,"E","E"],["E",2,"E"],[3,"E","E"],["E","E","A"]]
    // E=6   A=7
    let tabla = [[1; 6; 6]; [6; 2; 6]; [3; 6; 6]; [6; 6; 7]]
    let mutable estado=0
    
    printfn "+-------------------------------------+"
    printfn "|    Ingrese una cadena a evaluar:    |"
    printfn "+-------------------------------------+"

    let cadena = Console.ReadLine()     //Guarda la cadena que se ingresa
    body()  //Se mandan llamar las funciones para el formato de la tabla 
    encabezado()

    //Ciclo que recorre la cadena ingresada 
    for character in cadena do
        let mutable estadosig = estado
        //Llamamos a la funcion para saber si el caracter es valido 
        let charac = caracter (string character)

        //Guardamos en la variable estado el valor que se obtuvo de la tabla segun las coordenasas dadas 
        estado <- tabla.[estado].[charac]
        
        //Si el valor obtenido es un 6(E) imprimimos cadena no valida
        if estado = 6 then
            printfn "|     %A        |   %A    | %A\t |       %A       |" estadosig character simbolo estado
            body()
            printfn "|                    Cadena No Válida                    |"
            printfn "+--------------------------------------------------------+"
        
        contenido(estadosig,character,simbolo,estado)

    //Si el estado no es 3, que es el de aceptacion, se imprime cadena no valida    
    if estado <> 3 then
        printfn "|                    Cadena No Válida                    |"
        printfn "+--------------------------------------------------------+"

    //Si el estado es 3 entonces SI es una cadena de aceptacion
    if estado = 3 then
        printfn "|     %A        |          |  Fin Cadena  |               |" estado 
        body()
        printfn "|                    Cadena Válida                       |"
        printfn "+--------------------------------------------------------+"



    0 // return an integer exit code

