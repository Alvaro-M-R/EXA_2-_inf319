// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
[<EntryPoint>]
let main argv = 
    
    let rec fib n =
        match n with
        | 0 | 1 -> n
        | n -> fib (n-1) + fib (n-2)


    Console.WriteLine("intrdusca un numero n")
    let num= Console.ReadLine()
    let nu=Convert.ToInt32(num)
    for i in 0 .. (nu - 1) do
        fib i |> printfn "%i" |> ignore
    
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
