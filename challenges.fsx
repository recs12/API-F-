open System
open Microsoft.FSharp.Collections


// Challenge #1
let capital_indexes (word: string) =
    word.ToCharArray()
    |> List.ofArray
    |> List.indexed
    |> List.filter (fun (_, j) -> System.Char.IsUpper(j))
    |> List.mapi (fun _ (x, _) -> x)

printfn "%A" 
    (capital_indexes "HeLlO")


// Challenge #2
let isEven num = num % 2 = 0
let isOdd num = isEven num = false

let mid (word: string) =
    let num = String.length word
    match isOdd num with 
    | false -> ""
    | true -> word.ToCharArray() 
            |> List.ofArray 
            |> List.item (num / 2) 
            |> fun c -> c.ToString() 

// Solution:
printfn "%A" 
    (mid "finager")


// Challenge #3
type status = {
    Name : string ;
    Status : string }

let online_count (dt : list<status>) = 
    dt 
    |> List.countBy (fun d -> d.Status = "online")
    |> List.where (fun (bol,num) -> bol = true)
    |> List.exactlyOne
    |> fun (_,b) -> b

printfn "%A" 
    (online_count [{Name="Alice"; Status="offline"};{Name="Olive"; Status="online"};{Name="Beath"; Status="online"};])




// Challenge #4

let generate_number = 
    printfn "%i" (Random().Next(0, 100))
    0




// Challenge #5

let exemple = [11;22] 
let exemple1 = [11;"a"] 

let only_ints (ints:list<'T> ): bool =
    match ints with
    | ints when 
        ints.Length = 2 
        && (ints.Item 0).GetType().Name = "Int32"
        && (ints.Item 1).GetType().Name = "Int32" 
        -> true
    | _ -> false 

    
// Challenge #6

let double_letters (word:string) : bool =
    let charList = word.ToCharArray() |> List.ofArray
    charList 
    |> List.mapi (fun i _ -> charList[i .. i+1])
    |> List.filter (fun x -> x.Length > 1) 
    |> List.filter (fun x -> x[0] = x[1])
    |> List.isEmpty 
    |> fun b -> not b

// > double_letters "abc";;
// val it: bool = false

// > double_letters "aabc";;
// val it: bool = true


// Challenge #7

let withDot (word:string) =
    seq { for i in word.ToCharArray() do i.ToString()}
    |> String.concat "." 

let withoutDot (word:string) =
    seq { for i in word.ToCharArray() do if i.ToString() = "." then i.ToString()}
    |> String.concat "" 

// Challenge #8

// You function should return the number of syllales
// "ho-tel" 2
let count (word:string) = 
    let charList = word.ToCharArray() |> List.ofArray
    charList
    |> List.mapi (fun i x -> if x.ToString() = "-" then i else -1)  
    |> List.filter (fun x -> x <> -1)  

// Challenge #9

let is_anagram (word1:string) (word2:string)  =
    
    let comp a b =
        (a.ToString()).CompareTo(b.ToString())

    let charList = word1.ToCharArray() |> List.ofArray
    let reversedCharList = charList |> List.rev
    
    let charList2 = word2.ToCharArray() |> List.ofArray

    (charList, charList2) ||> List.compareWith comp


