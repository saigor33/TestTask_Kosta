Проект выполнен в среде Visual Studio 2019
База данных восстановлена в MSSQL Server 2016 и MSSQL Server 2014 (проведено два различных теста с подключением).

===================================================================================================
НАСТРОЙКА РАБОТЫ ПРИЛОЖЕНИЯ!!!!

Перед использованием приложения необходимо осуществить настройку подключения базы данных!
1) Необходимо развернуть базу данных в MSSQL Server 2005+ используя файл восстановления "TestDB.bak".

2) Необходимо изменить параметры подключения к базе данных.
Для этого в расположении проекта необходимо открыть файл "App.config" (можно с помощью приложения Блокнот) и
в строке подключения требуется откорректировать следующие данные:

(строка подключения: connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True")

*** "SQLEXPRESS" - имя сервера, к которому осуществляется подключение. Требуется изменить на своё!!! 

Данное значение указывается при подключении 
к базе данных в Mircosoft SQL Server Manager Studio. Может иметь вид "DESKTOP-RGD168B\SQLEXPRESS", где
"DESKTOP-RGD168B" - имя компьютера (может быть заменено на ".", если работа осуществляется с локальной БД),
 "SQLEXPRESS" - имя сервера.

*** "TestDB" - название базы данных, развернутой в MSSQL Server.

===================================================================================================

в папке "TaskAndResourses" лежит оригинал задания, бекап базы данных и скриншоты результата работы программы.




