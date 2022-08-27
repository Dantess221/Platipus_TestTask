# Platipus_TestTask
 Completed a test task for Platipus
 
<b>Тестовое задание</b>

Написать Web Service с одним GET методом reverse.
Метод принимает одним параметр data. GET: /reverse?data=test
Если значение в параметре data число, вернуть корень от числа.
Если значение в параметре data строка, вернуть строку у которой символы идут
в обратном порядке.
Ответ вернуть в JSON формате.

<b>Примеры</b>

* GET: /reverse?data=test 
Result:
{ 
    "result": "tset" 
} 

* GET: /reverse?data=16 
Result:
{
    "result": 4 
}


# Deployed in Heroku. Try:

* https://platipus-test-task.herokuapp.com/Test/reverse?data=test
* https://platipus-test-task.herokuapp.com/Test/reverse?data=16
