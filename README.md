# Platipus_TestTask
 Completed a test task for Platipus
 
# Тестовое задание
Написать Web Service с одним GET методом reverse.
Метод принимает одним параметр data. GET: /reverse?data=test
Если значение в параметре data число, вернуть корень от числа.
Если значение в параметре data строка, вернуть строку у которой символы идут
в обратном порядке.
Ответ вернуть в JSON формате.

# Примеры: 
GET: /reverse?data=test 
Result:
{ 
    "result": "tset" 
} 

GET: /reverse?data=16 
Result:
{
    "result": 4 
}
