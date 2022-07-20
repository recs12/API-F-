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


