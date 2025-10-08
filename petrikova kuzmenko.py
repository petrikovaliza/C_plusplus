"""1"""

import math as m

# R = 5
# S = 4 * m.pi * m.pow(R, 2)
# V = S * R / 3
# print(S)
# print(V)

"""2"""
# S = 2 
# ch = 24 * S
# min = 60 * ch
# sec = 60 * min

# print(ch, min , sec)

"""3"""
# a = 13
# b = 14
# c = 5
# p = (a+b+c) / 2
# S = m.sqrt(p*(p-a)*(p-b)*(p-c))

# print(S)

"""4"""

# def kramer(a1, b1, c1, a2, b2, c2):
#     determinant = a1 * b2 - a2 * b1
#     if determinant == 0:
#         print("Система уравнений не имеет единственного решения.")
#     else:
#         x = (c1 * b2 - c2 * b1) / determinant
#         y = (a1 * c2 - a2 * c1) / determinant
#         print("Решение системы уравнений: x =", x, "y =", y)

# a1 = float(input("Введите a1: "))
# b1 = float(input("Введите b1: "))
# c1 = float(input("Введите c1: "))
# a2 = float(input("Введите a2: "))
# b2 = float(input("Введите b2: "))
# c2 = float(input("Введите c2: "))

# kramer(a1, b1, c1, a2, b2, c2)

"""5"""

# R = 5  
# h = 8  
# Vc = h * m.pi * R**2
# Vk = (1 / 3) * h * m.pi * R**2

# print(f'Объем цилиндра: {Vc:.2f}')
# print(f'Объем конуса: {Vk:.2f}')

"""6"""

# R1 = float(input("Введите значение R1: "))
# R2 = float(input("Введите значение R2: "))
# R3 = float(input("Введите значение R3: "))

# R_niz = R2 * R3 + R1 * R3 + R1 * R2
# R_verh = R1 * R2 * R3
# R = R_verh / R_niz

# print(f"Общее сопротивление цепи равно: {R:.2f}")

"""6.1"""

# def sum_of_array(arr):
#     total_sum = 0  
#     for element in arr: 
#         total_sum += element  
#     return total_sum  

# array = [1, 2, 3, 4, 5]
# result = sum_of_array(array)
# print("Сумма элементов массива:", result)

""""7"""

# def find_max_element(arr):
#     if len(arr) == 0:  
#         return None  
    
#     max_element = arr[0]  
#     for element in arr[1:]:  
#         if element > max_element:  
#             max_element = element  
#     return max_element  

# array = [3, 1, 4, 1, 5, 9, 2, 6]
# result = find_max_element(array)
# print("Наибольший элемент массива:", result)

"""8"""

# def find_even_numbers(arr):
#     even_numbers = []  
#     for element in arr:  
#         if element % 2 == 0:  
#             even_numbers.append(element)  
#     return even_numbers  

# array = [3, 1, 4, 1, 5, 9, 2, 6, 8, 7]
# result = find_even_numbers(array)
# print("Четные числа в массиве:", result)

"""9"""

# def average(arr):
#     return sum(arr) / len(arr) if arr else 0

# array = [10, 20, 30, 40, 50]
# result = average(array)
# print("Среднее арифметическое всех элементов в массиве:", result)

"""10"""

# def reverse_number(n):
#     str_n = str(n)
#     reversed_str_n = str_n[::-1]
#     reversed_n = int(reversed_str_n)
#     return reversed_n

# number = 25
# reversed_number = reverse_number(number)
# print(f"Обратное число для {number} -> {reversed_number}")

"""11"""

# def sum_of_digits(n):
#     n_str = str(n)
#     digit_sum = 0
#     for char in n_str:
#         digit_sum += int(char)
        
#     return digit_sum

# number = int(input("Введите число: "))
# result = sum_of_digits(number)
# print(f"Сумма цифр числа {number} равна {result}.")

"""12"""

# a = float(input("Введите коэффициент a: "))
# b = float(input("Введите коэффициент b: "))
# c = float(input("Введите коэффициент c: "))

# if a == 0:
#     print("Уравнение не является квадратным.")
# else:
#     D = b**2 - 4 * a * c

#     if D > 0:
#         x1 = (-b + m.sqrt(D)) / (2 * a)
#         x2 = (-b - m.sqrt(D)) / (2 * a)
#         print(f"Корни уравнения: x1 = {x1}, x2 = {x2}")
#     elif D == 0:
#         x = -b / (2 * a)
#         print(f"Уравнение имеет один корень: x = {x}")
#     else:
#         print("Уравнение не имеет действительных корней.")