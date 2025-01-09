let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

let swap2 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // This will print 20 10

swap2 &x &y
printf "%d %d" x y // This will print 10 20