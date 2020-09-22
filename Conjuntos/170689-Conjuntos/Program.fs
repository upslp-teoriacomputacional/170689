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

    //Definimos 3 conjuntos
    let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)
    let B = Set.empty.Add(3).Add(4).Add(5).Add(6).Add(7)
    let C = Set.empty 
    //Se imprimen los conjuntos
    printfn "Conjunto A: %A" A
    printfn "Conjunto B: %A" B
    printfn "Conjunto C: %A \n\n" C
   

    //Funcion de pertenencia
    let pertenencia n=
        let x= Set.contains 1 A //Checamos si el elemento dado se encuentra dentro del conjunto
        let y= not(Set.contains 1 A)
        let z= Set.contains 10 A
        let m= not(Set.contains 10 A)
        printfn"1 contains in A: %A" x   //Imprimimos
        printfn"1 not contains in A %A" y
        printfn"10 contains in A %A" z
        printfn"10 not contains in A %A \n" m

    //Funcion donde convertimos a un Conjunto
    let transformarConj n=
        let a= [1; 2; 3]    //Creamos una lista
        let conjuntoA= Set.ofList a //Convertimos la lista a conjunto
        printfn"El conjunto de lista es: %A" conjuntoA   //Imprimimos
        let b = seq {1 .. 5}    //Creamos una secuencia
        let conjuntoB= Set.ofSeq b  //Cpnvertimos la secuencia a conjunto
        printfn"El conjunto de secuencia es: %A " conjuntoB
        //Creamos una secuencia y luego la convertimos a lista para despues a conjunto
        let conjuntoC= Set.ofList(Seq.toList"Hola Mundo")   
        printfn"El conjunto es: %A \n" conjuntoC
    
    //Funcion donde eliminamos un elemento del conjunto
    let quitar n=
        let A= Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4).Add(5)  //Se definen los conjuntos
        printfn"El conjunto A: %A" A //Imprimimos
        let A = A.Remove 2  //Quitamos un elemento del conjunto
        printfn"El conjunto A despues de eliminar: %A \n"  A  //Imprimimos
    
    //Quitar todos los elementos 
    let clearSet n=
        let A= Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4).Add(5)  //Se definen los conjuntos
        printfn"El conjnto A: %A" A  //Imprimimos
        let A= Set.empty    //Eliminamos todos los elementos del conjunto
        printfn"El conjunto A despues de eliminar todo: %A \n"  A  //Imprimimos


    //Copiar un conjunto
    let copiar n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = A   //Copiamos el conjunto A en el B
        printfn"Set A = %A" A   //Imprimimos
        printfn "compare set B = %A \n" B
    
    //Agregar elemento: Se agrega un elemento al conjunto
    let agregar n=
        printfn"Conjunto B: %A " B    //Imprimimos
        let B=B.Add 987 //Agregamos el numero 987 al conjunto B
        printfn"Conjunto B desp agregar elem: %A \n" B    //Imprimimos
    

    (*
        Operaciones de Conjuntos
    *)

    //Union: Junta el conjunto A y B y elimina los elementos repetidos
    let union n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6).Add(7)
        let A= Set.union A B
        printfn"Union A|B: %A \n" A  //Imprimimos

    //Interseccion: Nos dice que numeros iguales hay en el conjunto A y B
    let interseccion n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6).Add(7)
        let A= Set.intersect A B
        printfn"Interseccion A&B: %A \n" A  //Imprimimos
    
    //Diferencia: Nos dice que numeros hay en el conjunto A que no hay en el B
    let diferencia n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6).Add(7)
        let A = Set.difference A B  //Se hace la funcion
        printfn"Diferencia A-B: %A \n" A    //Imprimimos
    
    //Diferencia simetrica
    let simetrica n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)//Se definen los conjuntos
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6).Add(7)
        let C = Set.empty
        let AB= Set.difference A B //Union Simetrica A^B
        let AsB = Set.difference B A
        let AB = Set.union AB AsB
        let BA= Set.difference B A //Union Simetrica B^A
        let BsA = Set.difference A B
        let BA = Set.union BA BsA   
        let AC= Set.difference A C  //Union Simetrica A^C
        let AsC = Set.difference C A    //Este No es necesario debido a que el conjunto C esta vacio
        let AC = Set.union AC AsC
        let BC= Set.difference B C  //Union Simetrica B^C
        let BsC = Set.difference C B    //Este No es necesario debido a que el conjunto C esta vacio
        let BC = Set.union BC BsC
        printfn"Diferencia Simetrica A^B: %A " AB  //Imprimimos
        printfn"Diferencia Simetrica B^A: %A " BA
        printfn"Diferencia Simetrica A^C: %A " AC
        printfn"Diferencia Simetrica B^C: %A \n" BC

    
    //Subconjunto: Nos dice si tal conjunto es subconjunto del otro
    let subconjunto n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7).Add(8).Add(9)
        let a = Set.isSubset A B    //Checamos si son subconjuntos
        let b = Set.isSubset B A
        printfn"A subconjunto de B: %A " a  //Imprimimos
        printfn"B subconjunto de A: %A \n" b
    
    //Superconjunto: Nos dice si tal conjunto es superconjunto del otro
    let superconjunto n=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4).Add(5)    //Se definen los conjuntos
        let B = Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7).Add(8).Add(9)
        let a = Set.isSuperset A B  //Checamos si son superconjuntos
        let b = Set.isSuperset B A
        printfn"A superconjunto de B: %A " a    //Imprimimos
        printfn"B superconjunto de A: %A \n" b

    //Manda llamar a las funciones.
    pertenencia 1
    transformarConj 1
    quitar 1
    clearSet 1
    copiar 1
    agregar 1
    union 1
    interseccion 1
    diferencia 1
    simetrica 1
    subconjunto 1
    superconjunto 1



    0 // return an integer exit code
