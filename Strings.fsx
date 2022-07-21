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