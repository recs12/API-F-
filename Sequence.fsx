// run with
// dotnet fsi .\Seqs.fsx

open System

printfn "-1 allPairs"
printfn "%A\n" 
    (Seq.allPairs [1;2;3] ["a";"b";"c"])

printfn "-2 append"
printfn "%A\n" 
    (Seq.append [1;2;3] [5;6;8])

printfn "-3 average"
printfn "%A\n" 
    (Seq.average [10.0;20.0;30.0] )

printfn "-4 averageBy"
printfn "%A\n" 
    (Seq.averageBy (fun x -> x + 1.0) [10.0;20.0;30.0] )

printfn "-5 compareWith"
printfn "%A\n" 
    (Seq.compareWith (fun a b -> (a % 12).CompareTo(b % 12)) [10;20;30] [11;20;33])


printfn "-6 concat"
printfn "%A\n" 
    (Seq.concat [[10;20;30]; [11;20;33];[2]])


