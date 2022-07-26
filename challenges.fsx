open System

// Challenge #1
let capital_indexes (word:string) = 
    word.ToCharArray()
    |> List.ofArray
    |> List.indexed
    |> List.filter (fun (_,j) -> System.Char.IsUpper(j))
    |> List.mapi (fun _ (x,_) -> x)
    
printfn "%A" (capital_indexes "HeLlO")