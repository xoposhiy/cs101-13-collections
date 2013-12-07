#Коллекции

* List&lt;T> - список на основе массива.
* LinkedList&lt;T> - связный список
* HashSet&lt;T> - множество, реализованное на основе хэш-таблиц.

В этом блоке задач вы выполните тестирование производительности различных операций разных структур данных. 


##Stopwatch
С помощью класса Stopwatсh замерить длительность работы run.
Вывести среднее количество операций, которое можно выполнить за одну милисекунду.

##Тестирование различных методов IRepository

Добавьте тестирование остальных методов ListRepository, используя подготовленные для этого методы Test***.

Есть причины, по которым первый запуск любого метода может занимать чуть больше времени, чем все последующие.
Поэтому при замерах производительности важно, чтобы первое измерение не шло в зачет.
Пронаблюдайте этот эффект и учтите его.

## LinkedListRepository
Создайте новую реализацию IRepository, основанную на LinkedList<int>, вместо List<int>.
Добавьте тестирование ещё и этой реализации.

## Творчество
Придумайте ещё какую-нибудь (любую) реализацию IRepository. 
Можете попробовать какую-то оригинальную идею. Можете попытаться придумать реализацию IRepository, 
которая будет работать быстрее остальных. Можете испытать другие структуры данных.

## Ссылки по теме
* http://habrahabr.ru/post/191636/
* https://github.com/AndreyAkinshin/BenchmarkDotNet
