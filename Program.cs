using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Сollections
{
	// Интерфейс определяет, что можно делать с репозиторием
	public interface IRepository<T>
	{
		void Add(T item);
		bool Contains(T item);
		T GetElementAt(int index);
	}

	// Конкретная реализация репозитория
	public class ListRepository<T> : IRepository<T>
	{
		IList<T> list = new List<T>();

		public void Add(T item)
		{
			list.Add(item);
		}

		public bool Contains(T item)
		{
			return list.Contains(item);
		}

		public T GetElementAt(int index)
		{
			return list[index];
		}
	}

	static class Program
	{
		static void Main(string[] args)
		{
			Measure(new ListRepository<int>(), TestAppendToList);
			// Задача 2. Добавить тестирование других методов Repository:
			// Задача 3. Добавить новую реализацию IRepository, 
			//			 основанную на LinkedList<int>, вместо List<int>
			// Задача 4. Придумать ещё какую-нибудь (любую) реализацию IRepository.
			//			 Можете попробовать какую-то собственную оригинальную идею.
		}

		static void Measure(IRepository<int> list, Action<IRepository<int>, int> run)
		{
			// Задача 1. С помощью класса Stopwatсh замерить длительность работы run.
			// Вывести информацию о выполненном действии и его длительности.
			run(list, 10000); // возможно 10000 — слишком мало?
		}

		static void TestAppendToList(IRepository<int> list, int count)
		{
			for (int i = 0; i < count; i++)
				list.Add(i);
		}

		static void TestContains(IRepository<int> list, int count)
		{
			var containsAll = true;
			for (int i = 0; i < count; i++)
				containsAll &= list.Contains(i);
			Debug.Assert(containsAll); // это проверка, не нарушилось ли какое-то условие консистентности
		}

		static void TestSequentialAccess(IRepository<int> list, int count)
		{
			var sum = 0;
			for(int i=0; i<count; i++)
				sum += list.GetElementAt(i);
			Debug.Assert(sum != 0); 
		}
	}
}
