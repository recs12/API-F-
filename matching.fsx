open System.IO

// # single case matching
let  (|GetExtensionFile|) (pathFile:string) = Path.GetExtension(pathFile)

let example = @"C:\Users\recs\OneDrive - Premier Tech\Bureau\API F#\socketServer.pp"

match example with
| GetExtensionFile ".jpg"
| GetExtensionFile ".fsx"
    -> printfn "all good"
| _ -> printfn "Unvalid"