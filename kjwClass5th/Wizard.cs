namespace kjwClass5th
{
    internal class Wizard : Job
    {
        int attack = 100;

        // this와 base 키워드 중 this 키워드의 우선 순위가 더 높음
        public Wizard() : base(100)
        {
            Console.WriteLine("attack의 값 : " + base.attack);
            Console.WriteLine("health의 값 : " + health);
            //das
        }
    }
}
