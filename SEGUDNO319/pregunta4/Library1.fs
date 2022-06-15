namespace Library1
module fibonaci=
    let fib n = 
        match n with 
        | 0 -> 0
        | n -> 
         let mutable last = 0
         let mutable next = 1
         for i in 1 .. (n - 1) do
            let temp = last + next
            last <- next
            next <- temp
         next
    let rec fibr n =
        match n with
        | 0 | 1 -> n
        | n -> fib (n-1) + fib (n-2)

type Class1() = 
    member this.X = "F#"
