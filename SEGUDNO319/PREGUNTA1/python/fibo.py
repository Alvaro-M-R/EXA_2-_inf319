# -*- coding: utf-8 -*-
"""
@author: Alvaro
"""

def fib(n):
    a = 0
    b = 1
    
    for k in range(n):
        c = b+a
        a = b
        b = c
        
    return a

n=int(input("Ingrese un numero'n': "))
print("Serie Fibonacci:")
for n in range(0, n):
  print(fib(n))