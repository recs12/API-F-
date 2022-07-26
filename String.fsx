// run with
// dotnet fsi .\Strings.fsx

open System

printfn "-1 concat"
printfn "%A\n" 
    (String.concat " - " ["a";"b";"c"])

printfn "-2 collect"
printfn "%A\n" 
    (String.collect  (fun c -> c.ToString().ToUpper()) "Stefan says: Hi!" )

printfn "-3 exists"
printfn "%A\n" 
    (String.exists  Char.IsDigit "6Stefan says: Hi!" )

printfn "-4 filter"
(*
    Builds a new string containing only the characters of the input string for which the given predicate returns "true".
*)
printfn "%A\n" 
    (String.filter  Char.IsDigit "6Stefan says: Hi!" )

printfn "-5 forall"
(*	
    Tests if all characters in the string satisfy the given predicate.
*)
printfn "%A\n" 
    (String.forall  Char.IsDigit "6Stefan says: Hi!" )

printfn "-6 init"
(*	
    Builds a new string whose characters are the results 
    of applying the function mapping to each 
    index from 0 to count-1 and concatenating the resulting strings
*)
printfn "%A\n" 
    ( String.init  3 (fun i -> (i+3).ToString()))

printfn "-7 iter"
(*	
    Applies the function action to each character in the string.
*)
printfn "%A\n" 
    ( String.iter (fun c -> printfn "%c %d" c (int c)) "Hello")

printfn "-8 iteri"
(*	
    Applies the function action to the index of each character in the string and the character itself.
*)
printfn "%A\n" 
    ( String.iteri (fun i c -> printfn "%A %A" i c) "Hello")

printfn "-9 map"
(*	
    Applies the function action to the index of each character in the string and the character itself.
*)
printfn "%A\n" 
    ( String.map id "Hello")

printfn "-10 mapi"
(*	
    Applies the function action to the index of each character in the string and the character itself.
*)
// printfn "%A\n" 
//     ( String.mapi (fun i c -> (i,c)) "Hello")

printfn "-11 replicate"
(*	
    Returns a string by concatenating count instances of str.
*)
printfn "%A\n" 
    ( String.replicate 10 "*")