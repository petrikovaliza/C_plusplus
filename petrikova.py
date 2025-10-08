"""1 Разработайте программу, которая подсчитывает число слов во введенной с клавиатуры строке. Условимся считать словом любую последовательность символов, которая отделена от других пробелом."""

# text = input("Введите строку: ")
# print(f"В строке '{text}' {len(text.split())} слов.")

"""2. Разработайте программу, которая проверяет, является ли введенная с клавиатуры последовательность символов целым числом, записанным в двоичной системе счисления."""
 
# text = input("Введите последовательность символов: ")

# is_binary = True
# if text.isdigit():
#     for digit in text:
#         if digit not in '01':
#             is_binary = False
#             break
# else:
#     is_binary = False

# if is_binary:
#     print(f"'{text}' - двоичное число.")
# else:
#     print(f"'{text}' - не двоичное число.")

"""3. Разработайте программу, которая вычисляет среднюю длину слов во введенной с клавиатуры строке."""

# text = input("Введите строку: ")
# words = text.split()

# if words:
#     average_length = sum(len(word) for word in words) / len(words)
#     print(f"Средняя длина слов в строке: {average_length}")

"""4. Разработайте программу, которая зашифровывает введенный с клавиатуры текст. Процесс шифровки производится следующим образом: 
из десятичного кода каждого введенного с клавиатуры символа вычитается число десять, Получившаяся в результате вычитания величина интерпретируется как десятичный код 
некоторого другого символа, который и выводится на экран компьютера."""

# def caesar_cipher(text):
#     encrypted_text = ''
#     for char in text:
#         encrypted_char = chr(ord(char) - 10)
#         encrypted_text += encrypted_char
#         return encrypted_text

# text = input("Введите текст для шифрования: ")
# encrypted_text = caesar_cipher(text)
# print(f"Зашифрованный текст: {encrypted_text}")

"""5. Дано слово. Определите, является ли оно палиндромом (словом, которое читается одинаково в обоих направлениях, например, «потоп»)."""

# def is_palindrome(word):
#     return word == word[::-1]

# word = input("Введите слово: ")

# if is_palindrome(word):
#     print(f"Слово '{word}' является палиндромом.")
# else:
#     print(f"Слово '{word}' не является палиндромом.")

"""6. Дана строка символов. Определите самое длинное слово в строке и количество слов такой же длины."""

# def find_longest_word(text):
#     words = text.split()
#     if words:
#         longest_word = max(words, key=len)
#         longest_length = len(longest_word)
#         count = sum(1 for word in words if len(word) == longest_length)
#         return longest_word, count
#     else:
#         return None, 0

# text = input("Введите строку: ")
# longest_word, count = find_longest_word(text)

# if longest_word:
#   print(f"Самое длинное слово: '{longest_word}'")
#   print(f"Количество слов такой же длины: {count}")
# else:
#   print("В строке нет слов.")

"""7. Дана строка символов. Удалите из нее все пробелы."""

# text = input("Введите строку: ")
# text_without_spaces = text.replace(" ", "")
# print(f"Строка без пробелов: {text_without_spaces}")

"""8. Дана строка символов. Дано слово, удалите из строки это слово."""

# text = input("Введите строку: ")
# word = input("Введите слово для удаления: ")

# words = text.split()
# new_words = [w for w in words if w != word]
# new_text = ' '.join(new_words)
# print(f"Строка без слова '{word}': {new_text}")

"""9. Дана строка символов. Выделите подстроку между первой и второй точками."""

# def extract_substring(text):
#     first_dot_index = text.find(".")
#     second_dot_index = text.find(".", first_dot_index + 1)
#     if first_dot_index != -1 and second_dot_index != -1:
#         return text[first_dot_index + 1:second_dot_index]
#     else:
#         return ""

# text = input("Введите строку: ")
# substring = extract_substring(text)
# print(f"Подстрока между первой и второй точками: {substring}")

"""10.Дана строка символов, определите длину самого короткого и самого длинного слова."""

# def find_shortest_longest_words(text):
#     words = text.split()
#     if words:
#         shortest_length = len(min(words, key=len))
#         longest_length = len(max(words, key=len))
#         return shortest_length, longest_length
#     else:
#         return 0, 0

# text = input("Введите строку: ")
# shortest_length, longest_length = find_shortest_longest_words(text)
# print(f"Длина самого короткого слова: {shortest_length}")
# print(f"Длина самого длинного слова: {longest_length}")

"""11.Дана строка символов. Определите, сколько слов начинается и кончается одной и той же буквой."""

# def count_words_with_same_first_last(text):
#     count = 0
#     for word in text.split():
#         if word and word[0].lower() == word[-1].lower():
#             count += 1
#     return count

# text = input("Введите строку: ")
# word_count = count_words_with_same_first_last(text)
# print(f"Количество слов, начинающихся и заканчивающихся одной и той же буквой: {word_count}")
 
"""12. Дана строка символов. Определите, сколько слов содержат хотя бы одну букву «е»."""

# def count_words_with_e(text):
#     count = 0
#     for word in text.split():
#         if 'e' in word.lower():
#             count += 1
#     return count

# text = input("Введите строку: ")
# word_count = count_words_with_e(text)
# print(f"Количество слов, содержащих букву 'е': {word_count}")

"""13. Дана строка символов. Определите, является ли она правильным скобочным выражением. Рассматривайте только круглые скобки."""

# def is_valid_parentheses(text):
#     balance = 0
#     for char in text:
#         if char == '(':
#             balance += 1
#         elif char == ')':
#             balance -= 1
#         if balance < 0:
#             return False
#     return balance == 0

# text = input("Введите строку символов: ")
# if is_valid_parentheses(text):
#     print("Строка является правильным скобочным выражением.")
# else:
#     print("Строка не является правильным скобочным выражением.")

"""14. Дана строка символов. Определите, сколько слов содержат ровно три буквы «е»."""

# def count_words_with_three_e(text):
#     count = 0
#     for word in text.split():
#         if word.lower().count('e') == 3:
#             count += 1
#     return count

# text = input("Введите строку: ")
# word_count = count_words_with_three_e(text)
# print(f"Количество слов, содержащих ровно три буквы 'е': {word_count}")

"""15.Строка содержит только цифры. Удалите все впереди стоящие нули. """

# def remove_leading_zeros(text):
#     if text.isdigit():
#         while text.startswith("0") and len(text) > 1:
#             text = text[1:]  
#         return text
#     else:
#         return "Ошибка: Строка должна содержать только цифры."

# text = input("Введите строку, содержащую только цифры: ")
# result = remove_leading_zeros(text)
# print(f"Строка без ведущих нулей: {result}")

"""16.Дана строка символов. Подсчитайте количество знаков препинания в строке."""

# def count_punctuation_marks(text):
#     punctuation_marks = ",.!?;:-"
#     count = 0
#     for char in text:
#         if char in punctuation_marks:
#             count += 1
#     return count

# text = input("Введите строку: ")
# punctuation_count = count_punctuation_marks(text)
# print(f"Количество знаков препинания в строке: {punctuation_count}")

"""17. Дана строка символов, удалите из строки все запятые."""

# def remove_commas(text):
#     return text.replace(",", "")

# text = input("Введите строку: ")
# text_without_commas = remove_commas(text)
# print(f"Строка без запятых: {text_without_commas}")

"""18.Дана строка символов. Приведено некоторое слово. Вставьте его после
каждого пробела."""

# def insert_word_after_spaces(text, word):
#     new_text = ""
#     for i, char in enumerate(text):
#         if char == " " and i != len(text) - 1:
#             new_text += char + word + " "
#         else:
#             new_text += char
#     return new_text

# text = input("Введите строку: ")
# word = input("Введите слово для вставки: ")
# new_text = insert_word_after_spaces(text, word)
# print(f"Новая строка: {new_text}")

"""19. Дана строка символов. Найдите сумму чисел, встречающихся """

# def sum_of_numbers(text):
#     numbers = text.split()
#     sum = 0
#     for number in numbers:
#         try:
#             sum += int(number)
#         except ValueError:
#             pass
#     return sum

# def remove_numbers(text):
#     return " ".join([word for word in text.split() if not word.isdigit()])

# text = input("Введите строку: ")
# sum_of_numbers_in_text = sum_of_numbers(text)
# text_without_numbers = remove_numbers(text)
# print(f"Сумма чисел в строке: {sum_of_numbers_in_text}")
# print(f"Строка без чисел: {text_without_numbers}")
 
"""20. Дана строка символов. Удалите из строки все числа.
в строке."""

# def remove_numbers(text):
#     return " ".join([word for word in text.split() if not word.isdigit()])

# text = input("Введите строку: ")
# text_without_numbers = remove_numbers(text)
# print(f"Строка без чисел: {text_without_numbers}")

"""21. Дана строка символов. Удалите из строки слово, имеющее наибольшую длину."""

# def remove_longest_word(text):
#     words = text.split()
#     if words:
#         longest_word = max(words, key=len)
#         return " ".join([word for word in words if word != longest_word])
#     else:
#         return text

# text = input("Введите строку: ")
# new_text = remove_longest_word(text)
# print(f"Строка без самого длинного слова: {new_text}")


"""22. Дана строка символов. Вставьте в строку пробел после каждого знака препинания."""

# def insert_space_after_punctuation(text):
#     punctuation_marks = ",.!?;:-"
#     new_text = ""
#     for i, char in enumerate(text):
#         if char in punctuation_marks and i != len(text) - 1:
#             new_text += char + " "
#         else:
#             new_text += char
#     return new_text

# text = input("Введите строку: ")
# new_text = insert_space_after_punctuation(text)
# print(f"Новая строка: {new_text}")
 
""" 23. Дана строка из цифр и латинских букв. Определите, каких букв - гласных
(A, E. I. O, U) или согласных - больше в этой строке. """

# text = input("Введите строку: ")
# vowels = "aeiouAEIOU"
# consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"
# vowel_count = sum(1 for char in text if char in vowels)
# consonant_count = sum(1 for char in text if char in consonants)

# if vowel_count > consonant_count:
#     print("В строке больше гласных.")
# elif vowel_count < consonant_count:
#     print("В строке больше согласных.")
# else:
#     print("В строке одинаковое количество гласных и согласных.")
 

"""24. Из заданной строки удалите те ее части, которые заключены в кавычки (вместе с кавычками)."""

# def remove_quoted_parts(text):
#     result = ""
#     inside_quotes = False
#     for char in text:
#         if char == '"' and not inside_quotes:
#             inside_quotes = True
#         elif char == '"' and inside_quotes:
#             inside_quotes = False
#         elif not inside_quotes:
#             result += char
#     return result

# text = input("Введите строку: ")
# new_text = remove_quoted_parts(text)
# print(f"Строка без частей в кавычках: {new_text}")

"""25. Задано слово, замените в этом слове букву А на букву О. Если буквы А в
этом слове нет, то выведите соответствующее сообщение."""

# def replace_a_with_o(word):
#     if "А" in word:
#         return word.replace("А", "О")
#     else:
#         return "В слове нет буквы 'А'."

# word = input("Введите слово: ")
# new_word = replace_a_with_o(word)
# print(f"Новое слово: {new_word}")