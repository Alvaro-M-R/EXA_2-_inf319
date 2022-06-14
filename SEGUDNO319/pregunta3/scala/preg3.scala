object Hola4{
  def main(args:Array[String]):Unit={
  val fib: Stream[BigInt] = BigInt(0) #:: BigInt(1) #:: fib.zip(fib.tail).map(p => p._1 + p._2)
  def fib4(n: Int) = fib(n)
  print(fib(10))

  }
}