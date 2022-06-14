object Hola2{
  def fib2( n : Int ) : Int = {
  var a = 0
  var b = 1
  var i = 0	  
 
  while( i < n ) {
    val c = a + b
    a = b
    b = c
    i = i + 1
  } 
  return a
}
 
  def main(args:Array[String]):Unit={
  println("introdusca un n:")
  val a = scala.io.StdIn.readInt()
  println("serie fibo:")
  for (i <- 0 to a){
      print(fib2(i)+" ")
    }
  }
  


}