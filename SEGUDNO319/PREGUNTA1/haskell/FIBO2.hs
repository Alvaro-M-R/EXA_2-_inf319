fib :: Int -> Integer
fib n = fst $ sequence !! n
  where
    sequence = iterate (\(x, y) -> (y, x + y)) (0, 1)  
    
main = do
  print "Introduzca un numero para la serie"
  num <- getLine
  putStrLn "serie fibo"
  print(take (read num) [fib n | n <- [0..]])