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
    let palindromo="anitalavalatina"    //Se declara el palindromo
    let arreglo = palindromo.ToCharArray()  //Lo convertimos a Array
    let tam =(arreglo.Length/2) //Sacamos el tamaño del arreglo
    let newArreglo = Array.zeroCreate (tam+1) //Creamos un nuevo arreglo
    let mutable inc =0 //Acumulador

    for i=0 to tam do   //For que llena el nuevo arreglo hasta la mitad
        Array.set newArreglo i (arreglo.[i])    //Ingeresa dato por dato
        printfn "%A" newArreglo.[0..inc]    //Imprime el arreglo
        inc <- inc+1

    inc <- inc-2
    for i=0 to tam-1 do //For que imprime el arreglo de forma decremental
        printfn "%A" newArreglo.[0..inc]
        inc <- inc-1
    
    0 // return an integer exit code
    