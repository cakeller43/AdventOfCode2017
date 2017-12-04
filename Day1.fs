open System
let i = "1221"
let input = List.map (Char.GetNumericValue >> int) (Seq.toList i)

// Part 1
let (_,ans) = List.fold (fun (last,sum) elem -> if last = elem then (elem,sum+elem) else (elem,sum)) (List.last input,0) input

//Part 2
let (list1,list2) =  List.splitAt (input.Length/2) input
let halfSum = List.fold2 (fun state elem1 elem2 -> if elem1 = elem2 then state+elem1 else state ) 0 list1 list2
let ans2 = halfSum * 2