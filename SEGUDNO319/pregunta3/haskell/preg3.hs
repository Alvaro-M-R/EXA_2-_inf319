fibn n = fibs !! n
  where
    fibs = 0 : 1 : map f [2..]
    f n = fibs !! (n-1) + fibs !! (n-2)

main = do
  print "Introduzca un numero para la serie"
  num <- getLine
  print(take (read num) [fibn n | n <- [0..]])