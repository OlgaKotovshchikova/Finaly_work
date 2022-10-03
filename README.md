Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
1. Создание метода GetArr, получающий на вход первоначально заданный массив и возращающий новый сформированный массив из строк, длина которых меньше, либо равна 3 символам.
   В нашем случае метод получает на вход массив из 6 элементов.
   Для формирования итогового массива нужно знать его длину - для этого создается переменная arrLenght.
   Для того, чтобы запомнить индексы отобранных элементов, создается переменная indexes типа string.
   Метод пробегается по массиву и отбирает только те элементы, длина которых меньше или равна 3 символам.
   Если такой элемент обнаружен, его индекс записывается в переменную indexes, а arrLenght увеличивается на 1.
   После этого цикла создается массив result, длина которого равна arrLenght.
   Так как длина result и indexes равны, одним циклом пробегаемся по созданному массиву (result) и записываем в него элементы из первоначального массива с индексами, взятыми из indexes.
   Возвращаем массив result.
2. Написание кода для вывода полученного массива.
   Для красоты вывода в начале и конце этого блока прописан вывод символов "[" и "]".
   Цикл foreach проверяет, не является ли i-ый элемент полученного массива последним.
   Если не является, то элемент выводится с запятой и пробелом. 
   Если элемент последний, вывод осуществляется без запятой и пробела.