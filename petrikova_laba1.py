# В кортеже целых чисел вычислите произведение отрицательных элементов, имеющих нечетные индексы.

korteg = (1, -3, 3, -4, -5)
pr = 1
for i in range(len(korteg)):
    if korteg[i] % 2 != 0 and korteg[i] < 0:
        pr *= korteg[i]

print(pr)

# Из исходного списка целых чисел сформируйте два списка: список четных чисел В и список нечетных чисел С.

lst = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
B = []
C = []

for i in lst:
    if i % 2 == 0:
        B.append(i)
    else:
        C.append(i)

print('Четные числаж: ', B)
print('Нечетные числаж: ', C)

# Определите среднее арифметическое элементов кортежа, удовлетворяющих условию abs(korteg[i])>С. Значение С вводится с клавиатуры.

korteg  = (1, 2, -3, -4, 5, 6, -7, 8, 9, 10)
C = int(input('Введите значение С: '))

summa = 0
count = 0

for i in korteg:
    if abs(i) > C:
        summa += i
        count += 1

if count > 0:
    average = summa / count
    print('Среднее арифметическое: ', average)
else:
    print('В кортеже нет элементов, удовлетворяющих условию')

# Разработайте программу, в которой определяются максимальный и минимальный элементы среди положительных нечетных элементов целочисленного кортежа А(10).

А = (1, 2, -3, -4, 5, 6, -7, 8, 9, 10)
positive_number = [i for i in А if i > 0 and i % 2 != 0]

if positive_number:
    max_element = max(positive_number)
    min_element = min(positive_number)
    print('Максимальный элемент: ', max_element )
    print('Минимальный элемент: ', min_element )

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, 
# находящимися в интервале от -20 до 40. Выведите на экран компьютера созданный список. 
# В списке положительные элементы уменьшите вдвое, и отрицательные замените на значения их индексов.

import random

count_elements = int(input('Введите количество элементов списка: '))

numbers = [random.randint(-20, 40) for _ in range(count_elements)]
print('Изначальный списко: ', numbers)

for i in range(count_elements):
    if numbers[i] > 0:
        numbers[i] //= 2
    elif numbers[i] < 0:
        numbers[i] = i

print('Измененный список: ', numbers)

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, находящимися в интервале от 1 до 40.
#  Определите, сколько процентов всего количества элементов списка составляют нечетные элементы.

import random

count_elements = int(input('Введите количество элементов списка: '))

numbers = [random.randint(1, 40) for _ in range(count_elements)]
print('Список: ', numbers)

count_odd_elements = sum(1 for number in numbers if number %2 != 0)

percent = (count_odd_elements / count_elements) * 100

print('Процент нечетных элементов:  ', percent, '%')

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, 
# находящимися в интервале от 1 до 50. Выведите на экран компьютера созданный список и упорядочите элементы данного
# списка по возрастанию их значений.

import random

count_elements = int(input('Введите количество элементов списка: '))

numbers = [random.randint(1, 50) for _ in range(count_elements)]
print('Список: ', numbers)

numbers.sort()

print('Отсортированный список: ', numbers)

# Из списка произвольных чисел А[10] сформируйте другой список таким образом, чтобы вначале шли отрицательные элементы исходного списка
# затем положительные и, наконец, нулевые.

import random

А = [random.randint(-10, 10) for _ in range(10)]
print('Изначальный список: ', А)

negative_elements = []
positive_elements = []
zero_elements = []

for element in А:
    if element > 0:
        positive_elements.append(element)
    elif element < 0:
        negative_elements.append(element)
    else:
        zero_elements.append(element)

new_list = negative_elements + positive_elements + zero_elements
print('Новый список: ', new_list)

# Разработайте программу, заполняюшую список из N элементов случайными целыми числами, находящимися в интервале от до 30. 
# Выведите на экран компьютера созданный список и найдите максимальный элемент,
# его номер и поменяйте местами максимальный и первый элемент списка. 

import random

numbers = [random.randint(0, 30) for _ in range(10)]
print('Изначальный список: ', numbers)

max_element = max(numbers)
max_index = numbers.index(max_element)

print("Максимальный элемент: ", max_element)
print("Номер максимального элемента: ", max_index)

numbers[0], numbers[max_index] = numbers[max_index], numbers[0]

print('Измененный список: ', numbers)

# Разработайте программу, которая включает заданное число D в список А[10], упорядоченный по возрастанию, с сохранением упорядоченности. 

import random

А = sorted([random.randint(0, 20) for _ in range(10)])
print('Изначальный список: ', А)

D = int(input('Введите число D: '))

i = 0
while i < len(А) and А[i] < D:
    i += 1

А.insert(i, D)

print('Измененный список: ', А)

# Разработайте программу, в которой удалите из списка А, состоящего из п элементов, первые четыре нулевых элемента.

import random

n = 10

A = [random.randint(-5, 5) for _ in range(n)]
print('Изначальный список: ', A)

zero_count = 0
i = 0
while i <len(A) and zero_count < 4:
    if A[i] == 0:
        del A[i]
        zero_count += 1
    else:
        i += 1

print('Измененный список: ', A)

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, находящимися в интервале от 30 до 50. 
# Выведите на экран компьютера созданный список и определите, есть ли в нем серии элементов, состоящих из знакочередующихся чисел. 
# Если есть, то выведите на экран количество таких серий.

import random

n = 10

А = [random.randint(30, 50) for _ in range(n)]
print('Изначальный список: ', А)

series_count = 0
current_series = False
for i in range(1, len(А)):
    if(А[i] - А[i -1]) < 0:
        if not current_series:
            series_count += 1
            current_series = True
    else:
        current_series = False

if series_count > 0:
    print('Количество серий знакочередующихся чисел: ', series_count)
else:
    print('Серий знакочередующихся чисел нет')

# Разработайте программу, которая выводит на экран два кортежа А(10), содержащих диаметры и веса шин. 
# Следует отобрать две шины, диаметры которых отличаются не более чем на D см, 
# а вес - не более чем на W килограмм.

import random

D = 5  
W = 2  

diameters = tuple(random.randint(15, 25) for _ in range(10))
weights = tuple(random.randint(8, 12) for _ in range(10))

print("Диаметры шин:", diameters)
print("Веса шин:", weights)

found = False
for i in range(len(diameters)):
    for j in range(i + 1, len(diameters)):
        if abs(diameters[i] - diameters[j]) <= D and abs(weights[i] - weights[j]) <= W:
            print(f"Шина 1: {diameters[i]} см, {weights[i]} кг")
            print(f"Шина 2: {diameters[j]} см, {weights[j]} кг")
            found = True
            break
    if found:
        break

if not found:
    print("Шин с подходящей разницей не найдено")

# Из списка произвольных чисел А[10] сформируйте два списка, содержащих номера положительных и отрицательных элементов.

import random

A = [random.randint(-10, 10) for _ in range(10)]
print("Исходный список:", A)

positive_number = []
negative_number = []

for i in range(len(A)):
    if A[i] > 0:
        positive_number.append(i)
    elif A[i] < 0:
        negative_number.append(i)

print("Номера положительных элементов:", positive_number)
print("Номера отрицательных элементов:", negative_number)

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, находящимися в интервале от -20 до 40. 
# Выведите на экран компьютера созданный список и вычислите среднее арифметическое значение квадратов положительных элементов.

import random

N = int(input("Введите количество элементов списка: "))

numbers = [random.randint(-20, 40) for _ in range(N)]
print("Исходный список:", numbers)

sum_of_squares = 0
count = 0
for number in numbers:
    if number > 0:
        sum_of_squares += number**2
        count += 1

if count > 0:
    average_square = sum_of_squares / count
    print("Среднее арифметическое квадратов положительных элементов:", average_square)
else:
    print("В списке нет положительных элементов")

# В кортеже целых чисел произведите обмен соседних элементов, стоящих на четных местах, с элементами, стоящими на нечетных местах.

import random

n = 10
korteg = tuple(random.randint(-10, 10) for _ in range(n))

print("Исходный кортеж:", korteg)

new_list = list(korteg)

for i in range(0, len(korteg) - 1, 2):
    new_list[i], new_list[i + 1] = new_list[i + 1], new_list[i]

new_korteg = tuple(new_list)


print("Новый кортеж:", new_korteg)

# Разработайте программу, заполняющую список из N элементов случайными вещественными числами, находящимися в интервале от 1 до 30. 
# Все элементы списка с четными номерами, предшествующие первому по порядку элементу с наибольшим значением, до множьте на него.

import random

N = int(input("Введите количество элементов списка: "))
numbers = [random.uniform(1, 30) for _ in range(N)]
print("Исходный список:", numbers)

max_value = max(numbers)
max_index = numbers.index(max_value)

for i in range(0, max_index, 2):
    numbers[i] *= max_value

print("Измененный список:", numbers)

# Разработайте программу, заполняюшую список из N элементов случайными целыми числами, находящимися в интервале от -15 до 20. 
# Выведите на экран компьютера созданный список и найдите наибольший элемент из отрицательных.

import random

N = int(input("Введите количество элементов списка: "))
numbers = [random.randint(-15, 20) for _ in range(N)]

print("Исходный список:", numbers)

max_negative = -float('inf')  
for number in numbers:
    if number < 0 and number > max_negative:
        max_negative = number

if max_negative != -float('inf'):
    print("Наибольший отрицательный элемент:", max_negative)
else:
    print("В списке нет отрицательных элементов")

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, находящимися в интервале от 1 до 50. 
# Выведите на экран компьютера созданный список и найдите количество тех элементов, значения которых находятся в диапазоне от А до В.

import random

N = int(input("Введите количество элементов списка: "))
A = int(input("Введите начало диапазона (A): "))
B = int(input("Введите конец диапазона (B): "))

numbers = [random.randint(1, 50) for _ in range(N)]

print("Исходный список:", numbers)

count = 0
for number in numbers:
    if A <= number <= B:
        count += 1

print("Количество элементов в диапазоне от", A, "до", B, ":", count)

# Пользователь вводит с клавиатуры элементы списка A[n]. Определите, является ли заданная последовательность чисел, а1, a2, …, an монотонно убывающей.

n = int(input("Введите количество элементов списка: "))

A = []
print("Введите элементы списка:")
for i in range(n):
    A.append(int(input()))


is_monotonic = True
for i in range(1, n):
    if A[i] >= A[i - 1]:  
        is_monotonic = False
        break

if is_monotonic:
    print("Последовательность монотонно убывающая.")
else:
    print("Последовательность не является монотонно убывающей.")

# Разработайте программу, заполняюшую список из N элементов случайными целыми числами, находящимися в интервале от 1 до 30. 
# Замените нулями элементы между максимальным и минимальным значениями, кроме них самих.

import random

N = int(input("Введите количество элементов списка: "))
numbers = [random.randint(1, 30) for _ in range(N)]
print("Исходный список:", numbers)

max_value = max(numbers)
min_value = min(numbers)

max_index = numbers.index(max_value)
min_index = numbers.index(min_value)

if max_index > min_index:
    for i in range(min_index + 1, max_index):
        numbers[i] = 0
else:
    for i in range(max_index + 1, min_index):
        numbers[i] = 0

print("Измененный список:", numbers)

# Разработайте программу, в которой в кортеже целых чисел требуется найти индекс последнего по счету отрицательного элемента

import random
n = 10
korteg = tuple(random.randint(-10, 10) for _ in range(n))


print("Исходный кортеж:", korteg)

last_negative_index = -1 
for i in range(len(korteg) - 1, -1, -1):
    if korteg[i] < 0:
        last_negative_index = i
        break

if last_negative_index != -1:
    print("Индекс последнего отрицательного элемента:", last_negative_index)
else:
    print("В кортеже нет отрицательных элементов")

# Разработайте программу, которая определяет, имеется ли в заданном целочисленном кортеже А(10) хотя бы одна пара совпадающих по значению чисел.

import random

A = tuple(random.randint(-10, 10) for _ in range(10))
print("Исходный кортеж:", A)

found_pair = False
for i in range(len(A)):
    for j in range(i + 1, len(A)):
        if A[i] == A[j]:
            found_pair = True
            break
    if found_pair:
        break

if found_pair:
    print("В кортеже есть пара совпадающих элементов.")
else:
    print("В кортеже нет пары совпадающих элементов.")

# Разработайте программу, которая выводит на экран два кортежа, содержащих кортежи ростов игроков двух команд (в см),
#  и определяет, имеется ли в данных командах игроки одинакового роста.

import random

n = 5
team1_heights = tuple(random.randint(170, 200) for _ in range(n))
team2_heights = tuple(random.randint(170, 200) for _ in range(n))

print("Росты игроков команды 1:", team1_heights)
print("Росты игроков команды 2:", team2_heights)

found_match = False
for height1 in team1_heights:
    for height2 in team2_heights:
        if height1 == height2:
            print(f"Найдены игроки с одинаковым ростом: {height1} см")
            found_match = True
            break
    if found_match:
        break

if not found_match:
    print("Игроков с одинаковым ростом не найдено")

# Разработайте программу, заполняющую список из N элементов случайными целыми числами, находящимися в интервале от 1 до 50. 
# Выведите на экран компьютера созданный список и найдите максимальный и минимальный элементы, вычислите их разность.

import random

N = int(input("Введите количество элементов списка: "))

numbers = [random.randint(1, 50) for _ in range(N)]

print("Исходный список:", numbers)

max_element = max(numbers)
min_element = min(numbers)

difference = max_element - min_element

print("Максимальный элемент:", max_element)
print("Минимальный элемент:", min_element)
print("Разность между максимальным и минимальным элементом:", difference)










