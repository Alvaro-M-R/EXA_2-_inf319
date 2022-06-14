# -*- coding: utf-8 -*-
"""
@author: Alvaro
"""

def Fibonacci(n):
    if(n==0):
        return 0
    elif(n==1):
        return 1
    else:
        return (Fibonacci(n-2)+Fibonacci(n-1)) 
n=int(input("Ingrese un numero'n': "))
print("Serie Fibonacci:")
for n in range(0, n):
  print(Fibonacci(n))