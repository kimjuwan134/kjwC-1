using System.Collections;
using System.Xml.Linq;

namespace kjwProgram
{
    public class GameObject
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션

            // ArrayList
            /*
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add("String");
            arrayList.Add(57.5f);
            arrayList.Add('A');
            arrayList.Add("A");

            Console.WriteLine("arrayList Count : " + arrayList.Count);

            foreach (object element in arrayList) 
            {
                Console.WriteLine(element);
            }

            arrayList.Remove(10);

            Console.WriteLine("");
            Console.WriteLine("arrayList Count : " + arrayList.Count);



            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            */

            // List
            /*
            List<int> list = new List<int>();
            list.Capacity = 10;
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.Remove(40);
            list.RemoveAt(2);

            list.Reverse();
            list.Sort();

            for(int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
            }
            */

            // LinkedList
            /*
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddLast(100);

            foreach(var item in linkedlist) 
            {
                Console.WriteLine(item);
            }
            */

            // Stack
            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Pop(); // Pop : 가장 위에 있는 데이터 삭제.
            Console.WriteLine("stack Peek : " + stack.Peek()); // Peek : 가장 위에 있는 데이터 반환.
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            */

            // Queue
            /*
            Queue<GameObject> queue = new Queue<GameObject>();
            string[] objectName = new string[4] { "Cube", "Sphere", "Cylinder", "Capsule" };
            queue.Enqueue(new GameObject());
            queue.Enqueue(new GameObject());
            queue.Enqueue(new GameObject());
            queue.Enqueue(new GameObject());
            int queueSize = queue.Count;
            for(int i = 0; i < queueSize; i++)
            {
                GameObject gameObject = queue.Dequeue();
                gameObject.Name = objectName[i];
                Console.WriteLine(gameObject.Name);
            }
            */



            // Random 클래스
            /*
            Random random = new Random();
            int rand = random.Next(0,10);
            Console.WriteLine("rand : " + rand);
            

            List<string> list = new List<string>();
            list.Capacity = 5;
            list.Add("메이플스토리");
            list.Add("서든어택");
            list.Add("바람의나라");
            list.Add("피파온라인");
            list.Add("마구마구");
            Console.WriteLine(list.Count);
            Random random = new Random();

            while (list.Count != 0)
            {
                int rand = random.Next(0, list.Count);
                Console.WriteLine(list[rand]);
                list.RemoveAt(rand);
            }
            */




            #endregion

        }
    }
}