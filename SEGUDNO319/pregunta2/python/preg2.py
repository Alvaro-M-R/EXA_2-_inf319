# -*- coding: utf-8 -*-
"""
Created on Tue Jun 14 17:10:47 2022

@author: Alvaro
"""

from functools import reduce
  
fib = lambda n: reduce(lambda x, _: x+[x[-1]+x[-2]], 
                                 range(n-2), [0, 1]) 
  
n=int(input("Ingrese un numero'n': "))
print("Serie Fibonacci:")
print(fib(n))