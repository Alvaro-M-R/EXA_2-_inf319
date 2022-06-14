object Hola{
  def fiboR(n: Int): Int = {
    if      (n < 2) n
    else    fiboR(n-1) + fiboR(n-2)
  }
 
  def main(args:Array[String]):Unit={

  println("introdusca un n:")
  val a = scala.io.StdIn.readInt()
  println("serie fibo:")
  for (i <- 0 to a){
      print(fiboR(i)+" ")
    }
  }


}