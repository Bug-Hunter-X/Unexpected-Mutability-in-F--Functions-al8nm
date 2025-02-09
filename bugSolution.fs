let x = 10

let addOne x = 
    x + 1

let y = addOne x
printfn "%d %d" x y //Output: 10 11

let z = addOne x
printfn "%d %d %d" x y z //Output: 10 11 11

//Alternatively, using a mutable variable and making a copy:

let mutable x = 10

let addOne x = 
    let mutable tempX = x
    tempX <- tempX + 1
    tempX

let y = addOne x
printfn "%d %d" x y //Output: 10 11

let z = addOne x
printfn "%d %d %d" x y z //Output: 10 11 11