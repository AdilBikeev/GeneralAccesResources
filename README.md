# GeneralAccesResources
Постановка задачи  В программе одновременно запущены три потока, действующих следующим образом (см. рис.). Поток 1 каждую секунду генерирует случайное число и записывает его в первый Файл 1 (text_1.txt). Поток 2 отслеживает записи в первом файле Файл 1 (text_1.txt) и после добавления каждых двух чисел записывает их сумму во второй файл Файл 2 (text_2.txt). Поток 3 отслеживает записи во втором файле Файл 2 (text_2.txt) и после добавления каждых двух чисел записывает их сумму в первый файл Файл 1 (text_1.txt).  При этом, если Поток 1 добавил в Файл 1 число, а следом приходит число из Потока 3, то Поток 2 отрабатывает аналогично.    Рисунок 1 – Совместная работа трёх потоков