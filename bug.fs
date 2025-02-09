let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let y = addOne x
printfn "%d %d" x y //Output: 11 11

//Now modify the above code slightly, and see what happens:

let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let y = addOne x
printfn "%d %d" x y //Output: 11 11

let z = addOne x
printfn "%d %d %d" x y z //Output: 12 11 12