open System

let input = 
    let i = System.IO.File.ReadLines "input.txt"    
    i.Split '\n'
    |> Array.map (fun x -> x.Split ' ')

let filterFunc elem = 
    let a = Array.length elem
    let b = Array.distinct elem |> Array.length
    a = b
let f = Array.filter filterFunc input |> Array.length