// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
[<EntryPoint>]
let main argv =     
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
    
    Console.WriteLine("intrdusca un numero n")
    let num= Console.ReadLine()
    let nu=Convert.ToInt32(num)
    for i in 0 .. (nu - 1) do
        fib i |> printfn "%i" |> ignore       
    
    

    let tecla = Console.ReadKey()
    0  // devolver un código de salida entero
    