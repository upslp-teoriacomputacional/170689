// Learn more about F# at http://fsharp.org

(* 
Camila Alejandra García López
Teoria Computacional
Prof. Juan Carlos González Ibarra
Universidad Politécnica de San Luis Potosi
170689
*)

open System

[<EntryPoint>]
let main argv =
    
    //Se crea una lista tipo bool con dos posibles valores
    let booleanos= [false; true]

    //Haremos la tabla de verdad or 
    //Nos imprimira la parte superior de la tabla junto con una separacion 
    printfn "x \ty \tx or y"    
    printfn "----------------------"
    //Esta doble iteracion nos dira la tabla de verdad or
    for x in booleanos do
        for y in booleanos do
            printfn "%A \t%A \t%A" x y (x || y) //Imprime el valor de x, y, x or y
    
    printfn ""  //Salto de linea

    //Haremos la tabla de verdad and
    //Nos imprimira la parte superior de la tabla junto con una separacion
    printfn "x \ty \tx and y"
    printfn "----------------------"
    //Esta doble iteracion nos dira la tabla de verdad and
    for x in booleanos do
        for y in booleanos do
            printfn "%A \t%A \t%A" x y (x && y) //Imprime el valor de x, y, x and y
    
    printfn ""  //Salto de linea

    //Hremos la tabla de verdad not
    //Nos imprimira la parte superior de la tabla junto con una separacion
    printfn "x \tnot x"
    printfn"-------------"
    //Esta iteracion nos dira la tabla de verdad not
    for x in booleanos do
        printfn "%A \t%A" x (not x) //Imprime el valor de x y not x
    
    printfn ""  //Salto de linea

    //Haremos la tabla de verdad xor
    //Nos imprimira la parte superior de la tabla junto con una separacion
    printfn "x \ty \tx ^ y"
    printfn "----------------------"
    //Esta doble iteracion nos dira la tabla de verdad xor
    for x in booleanos do
        for y in booleanos do
            printfn "%A \t%A \t%A" x y ( (x||y) && not (x && y))  //Imprime el valor de x, y, x^y
            

    
    0 // return an integer exit code
