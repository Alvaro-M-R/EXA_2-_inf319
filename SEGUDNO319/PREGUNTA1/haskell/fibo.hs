fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib n = (fib (n - 1)) + (fib (n - 2))

main = do
  print "Introduzca un numero para la serie"
  num <- getLine
  putStrLn "serie fibo"
  print(take (read num) [fib n | n <- [0..]])
