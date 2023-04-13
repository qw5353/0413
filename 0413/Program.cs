namespace _0413
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member men = new Member("Text");
			//men.Name = "Test";
			Console.WriteLine(Member.Greet()+men.Name);
			var men1 = new demo.imageHelper(); //找到demo資料夾內的imageHelper	
		}
	}


	public class Member
	{
		public string Name { get; set; }
		//public Member() { }
		public Member(string name) 
		{
			Name = name;
		}

		public static string Greet()
		{
			return "安安";
		}
	}
}