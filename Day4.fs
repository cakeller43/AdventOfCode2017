let i = "oaoe rxeq vssdqtu xrk cjv yaoqp loo
mveua dogbam szydvri hyzk lbega abzqw xwjn wniug kwbre"

let input = i.Split '\n'
            |> Array.map (fun x ->
                x.Split ' ')

let filterFunc elem = 
    let a = Array.length elem
    let b = Array.distinct elem |> Array.length
    a = b

let f = Array.filter filterFunc input |> Array.length