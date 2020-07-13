using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApplication
{
	class Person
	{
		private static Person instance;

		public static Person Instance
		{
			get { if (instance == null) instance = new Person(); return instance; }
			private set { instance = value; }
		}

		public int ID { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Sex { get => sex; set => sex = value; }
		public string Role { get => role; set => role = value; }
		public string Phone_number { get => phone_number; set => phone_number = value; }

		private int id;
		private string name;
		private string sex;
		private string role;
		private string phone_number;

		public Person() { }

		public Person(int id, string name, string sex, string type, string phone_number)
		{
			this.ID = id;
			this.Name = name;
			this.Sex = sex;
			this.Role = role;
			this.Phone_number = phone_number;
		}
	}
}
