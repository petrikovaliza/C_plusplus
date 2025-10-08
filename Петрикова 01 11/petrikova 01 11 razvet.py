"""1"""

import math as m

# x = float(input("Введите значение x: "))

# if x <= 0:
#     y = x
# else:
#     y = 2 * x

# print(f"Значение y равно {y}")

"""2"""

# summa = 0

# while True:
#     number = float(input("Введите число: "))
#     if not number:
#         break
#     if number > 0:
#         summa += number

# print(f"Сумма положительных чисел: {summa}")

"""3"""

# a = int(input("Введите первое число: "))
# b = int(input("Введите второе число: "))
# c = int(input("Введите третье число: "))

# count_0 = 0
# if a == 0:
#     count_0 += 1
# if b == 0:
#     count_0 += 1
# if c == 0:
#     count_0 += 1

# print(f"Количество нулей среди введённых значений: {count_0}")


"""4"""

# mark = float(input("Введите вашу оценку: "))

# if mark == 2:
#     print("У вас неудовлетворительная успеваемость")
# elif mark == 3:
#     print("У вас удовлетворительная успеваемость")
# elif mark == 4:
#     print("У вас хорошая успеваемость")
# elif mark == 5:
#     print("У вас отличная успеваемость")
# else:
#     print("Такой оценки не существует в РФ")

"""5"""

# a = float(input("Введите a: "))
# b = float(input("Введите b: "))
# c = float(input("Введите c: "))

# D = b**2 - 4*a*c

# if D > 0:
#     x1 = (-b + m.sqrt(D)) / (2 * a)
#     x2 = (-b - m.sqrt(D)) / (2 * a)
#     print(f"Корни уравнения: x1 = {x1:.2f}, x2 = {x2:.2f}")
# elif D == 0:
#     x = -b / (2 * a)
#     print(f"Уравнение имеет один корень: x = {x:.2f}")
# else:
#     print("Действительных корней нет.")

"""6"""

# distance = float(input("Введите расстояние до пункта назначения (км): "))
# days = int(input("Введите длительность пребывания (дней): "))
# price_1_km = 10 

# base_price = distance * price_1_km * 2

# if distance > 1000 and days > 7:
#     final_price = base_price * 0.70 
# else:
#     final_price = base_price

# print(f"Стоимость железнодорожного билета 'туда и обратно': {final_price:.2f} рублей")


"""7"""

# a = float(input("Введите первое число: "))
# b = float(input("Введите второе число: "))
# c = float(input("Введите третье число: "))

# if a < b < c:
#     print("Последовательность строго возрастает.")
# elif a > b > c:
#     print("Последовательность строго убывает.")
# else:
#     print("Последовательность не является ни строго возрастающей, ни строго убывающей.")

"""8"""

# a = float(input("Введите первое число: "))
# b = float(input("Введите второе число: "))
# c = float(input("Введите третье число: "))

# minimum = a
# if b < minimum:
#     minimum = b
# if c < minimum:
#     minimum = c

# print(f"Минимальное из трех чисел: {minimum}")

"""9"""

# x = float(input("Введите значение x: "))

# if x < 0:
#     y = 0
# elif 0 <= x <= 1:
#     y = x
# else:
#     y = 1

# print(f"Значение y равно {y}")

"""10"""

num1 = float(input("Введите первое число: "))
num2 = float(input("Введите второе число: "))

if num1 == num2:
    num1 = 100
    num2 = 100
else:
    if num1 < num2:
        num1 = 0
    else:
        num2 = 0

print(f"Изменённые числа: {num1}, {num2}")