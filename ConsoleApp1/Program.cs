namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var estore = new Estore();
			estore.DoIt(15, 13);
			//estore.DoIt(15, 13,,88);跳過C這樣不行
			estore.DoIt(b:99,a:9,d:79); //這樣可以跳過C，還可以換順序
			estore.DoIt(a: 3,
						b: 4,
						d: 78);
		}
	}

	public class Estore
	{
		public void DoIt(int a, int b,int c=0,int d =-1 ) { }
		


	}
}