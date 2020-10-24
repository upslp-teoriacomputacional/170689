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



[<EntryPoint>]
let main argv =
    let mutable tokens = []    //Lista para los tokens
    let sourceCode = "int result = 1;".Split(' ')

    //FOR que recorre la cadena source code    
    for word in sourceCode do
        //If que verifica que tipo de dato es
        if (word.Equals("str") || word.Equals("int") || word.Equals("bool")) then
            
            tokens <- List.append tokens ["DATATYPE", word]
        //Revisa que solo sea una palabra 
        elif (Regex.IsMatch (word, "[a-z]") || Regex.IsMatch (word, "[A-Z]")) then
            tokens <- List.append tokens ["IDENTIFIER", word]
        //Verifica que sea un un operador
        elif (Regex.IsMatch(word, "(\+|\-|\*|\/|\%|\=)" )) then 
            tokens <- List.append tokens ["OPERATOR", word]
        //Verifica que sea un numero 
        elif (Regex.IsMatch(word, "[0-9]")) then
            if (word.EndsWith ";") then
                tokens <- List.append tokens ["INTEGER", word]
                tokens <- List.append tokens ["END_STATEMENT", ";"]
            else
                tokens <- List.append tokens ["INTEGER", word]
    
    printfn "%A" tokens
    0 // return an integer exit code
