ДОКУМЕНТАЦИЯ ПРОЕКТА "SimpleNote"

ВВЕДЕНИЕ

Проект "SimpleNote" предстовляет собой веб-приложение для записи задач для каждого пользователя по категориям. Приложение предоставляет API для создания, чтения, обновления и удаление задач, пользователей и категорий.

Зависимости
* ASP.NET CORE
* Entity Framework Core
* Postman

Установка:
1. Клонируйте репозиторий: https://github.com/firuzd1/SimpleNote.git
2. Перейдите в директорию проекта: cd Note.web
3. Установите необходимые пакеты : dotnet restore
4. Такие же действия для директорий Note.BusinessLogic и NoteDataAccess для установки пакетов для работы с DI контейнера

КОНФИГУРАЦИЯ
* ConnectionString: Настройте строку подключения к базе данных в файле 'DatabaseHelper'
* ApiKey: Укажите Api-ключ в файле 'ApiKeyAuthenticationOptions'

ЗАПУСК
1. Выполните миграцию базы данных: dotnet ef database update
2. Запустите проект: dotnet run

Использование API
*** ВАЖНО ОТМЕТИТЬ ЧТО СПЕРВА НУЖНО СОЗДАТЬ ПОЛЬЗОВАТЕЛЯ, КАТЕГОРИЮ И ТОЛЬКО ПОТОМ ЗАДАЧУ *** 
для работой с приложением требуется API-ключ, но для создания пользователя он не нужен.

СОЗДАНИЕ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'POST'
* Описание: Возвращает созданного пользователя.

пример запроса:
http://localhost:5000/users

нужно перейти в body и нажав на raw выбрать json после ввести ниже указанную команду
{
    "FirstName" : "Shamsi",
    "LastName" : "Akhmatbek",
    "Email" : "sh.bek@",
    "Password" : "qwe176755"
}

--------------------------

ПОЛУЧЕНИЕ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'GET'
* Описание: Возвращает пользователя по id.

http://localhost:5219/users/1
(1 это id пользователя, замените его на нужный вам id)

--------------------------

УДАЛЕНИЕ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'DELETE'
* Описание: удаляет пользователя по id, возвращает true/false.

http://localhost:5219/users/1
(1 это id пользователя, замените его на нужный вам id)

--------------------------

ИЗМЕНЕНИЯ ИМЕНИ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'PATCH'
* Описание: Изменяет имя пользователя и возвращает пользователя.

http://localhost:5219/users/name/1?name=Firuz1
(1 это id, ?name это свойсто для хранения имени пользователя, Firuz1 это новое имя(замените его на нужное для вас имя))

--------------------------

ИЗМЕНЕНИЯ ФАМИЛИИ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'PATCH'
* Описание: Изменяет фамилию пользователя и возвращает пользователя.

http://localhost:5219/users/lastName/1?newLastName=Dostiev1
(1 это id, ?newLastName это свойсто для хранения фамилии пользователя, Dostiev1 это новая фамилия(замените его на нужную для вас фамилию))

--------------------------

ИЗМЕНЕНИЯ ПОЧТЫ ПОЛЬЗОВАТЕЛЯ
* URL:/users
* Метод 'PATCH'
* Описание: Изменяет почту пользователя и возвращает пользователя.

http://localhost:5219/users/email/1?newEmail=dostiev.f@gmail.com
(1 это id, ?newEmail это свойсто для хранения фамилии пользователя, dostiev.f@gmail.com это новая почта(замените его на нужную для вас почту))

--------------------------------------------------------------------------------------------------------

СОЗДАНИЕ КАТЕГОРИИ
* URL:/categories
* Метод 'POST'
* Описание: Возвращает созданную категорию.

пример запроса:
http://localhost:5000/categories

нужно перейти в body и нажав на raw выбрать json после ввести ниже указанную команду
{
    "Name" : "Test"
}

--------------------------

ПОЛУЧЕНИЕ КАТЕГОРИИ
* URL:/categories
* Метод 'GET'
* Описание: Возвращает категорию по id.

http://localhost:5219/categories/1
(1 это id категории, замените его на нужный вам id)

--------------------------

ИЗМЕНЕНИЕ КАТЕГОРИИ
* URL:/categories
* Метод 'PATCH'
* Описание: Поиск id, изменение категории.

http://localhost:5219/categories/1?newName=newCategoryTest
(1 это id, ?newName это свойсто для хранения название категории, newCategoryTest это новая категория(замените его на нужную для вас категорию))

--------------------------

УДАЛЕНИЕ КАТЕГОРИИ
* URL:/categories
* Метод 'DELETE'
* Описание: Поиск id, удаление категории.

http://localhost:5219/categories/1
(1 это id по которому будет удалена категория)ы

--------------------------------------------------------------------------------------------------------

СОЗДАНИЕ ЗАДАЧИ
* URL:/tasks
* Метод 'POST'
* Описание: Возвращает созданную задачу.

пример запроса:
http://localhost:5000/tasks

нужно перейти в body и нажав на raw выбрать json после ввести ниже указанную команду
{
    "Title" : "Test",
    "Description" : "testDescription",
    "Status" : "1",
    "UserId" : 1,
    "CategoryId" : 1
}

--------------------------

ПОЛУЧЕНИЕ ЗАДАЧИ
* URL:/tasks
* Метод 'GET'
* Описание: Возвращает задачу по id.

http://localhost:5219/tasks/1
(1 это id задачи, замените его на нужный вам id)

--------------------------

УДАЛЕНИЕ ЗАДАЧИ
* URL:/tasks
* Метод 'DELETE'
* Описание: Удаление задачу по id.

http://localhost:5219/tasks/4
(1 это id задачи, замените его на нужный вам id)

--------------------------

ИЗМЕНЕНИЕ ОПИСАНИЯ
* URL:/tasks
* Метод 'PATCH'
* Описание: Поиск по id, изменения описания.

http://localhost:5219/tasks/description/4?newDescription=newTestDescription
(4 это id, ?newDescription это свойство которое хранит описание, newTestDescription это новое описание(измените его на нужное вам описание))

--------------------------

ИЗМЕНЕНИЕ СТАТУСА
* URL:/tasks
* Метод 'PATCH'
* Описание: Поиск по id, изменения статуса.

*** ВАЖНО ОТМЕТИТЬ ЧТО СТАТУС ВЫ МОЖЕТЕ ВЫБРАТЬ ТОЛЬКО ИЗ ПРЕДСТАВЛЕННЫХ ***
   
    pending = 0,
    inProgress = 1,
    complated = 2

http://localhost:5219/tasks/status/4?newStatus=1
(4 это id, newStatus свойство для хранения статусов и 1 это сам статус(измените на нужный вам статус))

--------------------------

ИЗМЕНЕНИЕ ОГЛАВЛЕНИЯ
* URL:/tasks
* Метод 'PATCH'
* Описание: Поиск по id, изменения оглавления.

http://localhost:5219/tasks/title/4?newTitle=newTestTitle
(4 это id, newTitle свойство для хранения статусов и newTestTitle это новое оглавление(измените на нужный вам оглавление))