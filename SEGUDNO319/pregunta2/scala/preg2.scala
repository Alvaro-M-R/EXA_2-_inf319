object Hola3{
  def main(args:Array[String]):Unit={
  def fib(n:Int):BigInt = {
    def fibs(n:Int):(BigInt,BigInt) = if (n == 1) (1,0) else {
      val (a,b) = fibs(n/2)
      val p = (2*b+a)*a
      val q = a*a + b*b
      if(n % 2 == 0) (p,q) else (p+q,p)
    }
    fibs(n)._1
  }
  for (i <- 0 to 10){
      print(fib(i))
    }
  }
}