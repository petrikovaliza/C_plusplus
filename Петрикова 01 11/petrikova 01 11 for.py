import math as m

"""1"""

# a = float(input("Начальная точка: "))
# b = float(input("Конечная точка: "))
# h = float(input("Шаг: "))

# max_y = -float('inf')
# x = a
# while x <= b:
#     if m.sin(x) != 0:
#         y = m.cos(x) / m.sin(x)
#         if y > max_y:
#             max_y = y
#     x += h

# print(f"Максимальное значение функции: {max_y}")

"""2"""

# numbers = list(map(float, input("Введите последовательность чисел через пробел: ").split()))
# numbers.pop()

# positive_count = 0
# min_positive = None

# for num in numbers:
#     if num > 0:
#         positive_count += 1
#         if min_positive is None or num < min_positive:
#             min_positive = num

# if positive_count == 0:
#     print("Положительные числа отсутствуют.")
# else:
#     print(f"Количество положительных чисел: {positive_count}")
#     print(f"Минимальное положительное число: {min_positive}")

"""3"""

# numbers = list(map(int, input("Введите последовательность целых чисел через пробел: ").split()))
# numbers.pop()

# positive_count = 0
# negative_count = 0

# for num in numbers:
#     if num > 0:
#         positive_count += 1
#     elif num < 0:
#         negative_count += 1

# if positive_count > negative_count:
#     print("Положительных чисел больше.")
# elif positive_count < negative_count:
#     print("Отрицательных чисел больше.")
# else:
#     print("Положительных и отрицательных чисел поровну.")

"""4"""

# numbers = list(map(float, input("Введите последовательность чисел через пробел: ").split()))
# numbers.pop()

# positive_sum = 0
# negative_sum = 0

# for num in numbers:
#     if num > 0:
#         positive_sum += num
#     elif num < 0:
#         negative_sum += num

# print(f"Сумма положительных чисел: {positive_sum}")
# print(f"Сумма отрицательных чисел: {negative_sum}")

"""5"""

# numbers = list(map(int, input("Введите последовательность целых чисел через пробел: ").split()))
# positive_sum = 0

# for num in numbers:
#     if num < 0:
#         break
#     positive_sum += num

# print(f"Сумма положительных чисел до первого отрицательного числа: {positive_sum}")

"""6"""

# numbers = list(map(int, input("Введите последовательность чисел через пробел: ").split()))
# non_zero_sum = 0

# for num in numbers:
#     if num != 0:
#         non_zero_sum += num

# print(f"Сумма ненулевых чисел: {non_zero_sum}")


"""7"""

# numbers = list(map(int, input("Введите последовательность чисел через пробел: ").split()))
# sravnenie = int(input("Введите число для сравнения: "))
# count = 0

# for i in range(len(numbers)):
#     for j in range(i+1, len(numbers)):
#         if numbers[i] + numbers[j] < sravnenie:
#             count += 1

# print(f"Количество пар чисел, сумма которых меньше заданного числа: {count}")

"""8"""

# start_deposit = float(input("Введите начальный вклад: "))
# stavka = float(input("Введите годовую процентную ставку (в десятичной форме): "))

# month = stavka / 12
# years = 0
# deposit = start_deposit

# while deposit < 1000000:
#     deposit *= 1 + month
#     years += 1
#     print(f"Вклад после {years} года: {round(deposit, 2)}")

#     if deposit >= 1000000:
#         break

# print(f"Вклад превысил 1 млн долларов через {years} лет.\nЕго величина составила {round(deposit, 2)}.")

"""9"""

# start = 10
# end = 30
# even_sum = 0

# for num in range(start, end + 1):
#     if num % 2 == 0:
#         even_sum += num
#     if num % 2 == 1:
#         continue

# print(f"Сумма четных чисел на отрезке от 10 до 30: {even_sum}")

"""10"""

# height = float(input("Введите ваш рост в сантиметрах: "))
# ideal_weight = height - 100

# if height < 250:
#     print("Идеальный вес для вашего роста составляет:", ideal_weight, "кг")
# elif height >= 250:
#     print("Вы какой-то слишком высокий")

for height in range(150, 250):
    ideal_weight = height - 100
    while height > 250:
        print(f"Ваш рост: {height}, ваш идеальный вес: {ideal_weight}")