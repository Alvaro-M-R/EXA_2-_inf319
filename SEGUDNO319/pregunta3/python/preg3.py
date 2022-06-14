# -*- coding: utf-8 -*-
"""
Created on Tue Jun 14 17:12:17 2022

@author: Alvaro
"""

def fibonacci(count): 
    fib_list = [0, 1] 
  
    any(map(lambda _: fib_list.append(sum(fib_list[-2:])), 
                                         range(2, count))) 
  
    return fib_list[:count] 
 
n=int(input("Ingrese un numero'n': "))
print("Serie Fibonacci:")    
print(fibonacci(n)) 