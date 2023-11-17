namespace kjwClass6th
{
    public abstract class Zerg
    {
        protected int attack;
        protected int defense;
        protected abstract void Move();
    }

    public class GroundUnit : Zerg
    {
        public GroundUnit(int attack, int defense)
        {
            this.attack = attack;
            this.defense = defense;
        }
        public void Ground()
        {
            Console.WriteLine("On the Ground");
        }
        protected override void Move()
        {
            Ground();
            Console.WriteLine("Move");
        }
    }

    public class AirUnit : Zerg
    {
        public AirUnit(int attack, int defense)
        {
            this.attack = attack;
            this.defense = defense;
        }
        public void Fly()
        {
            Console.WriteLine("공중 유닛");
        }

        protected override void Move()
        {
            Fly();
            Console.WriteLine("공중 유닛 이동");
        }
    }

    public class Drone : GroundUnit
    {
        public Drone() : base(10, 5)
        {
            base.Move();
        }
    }

    public class Mutalisk : AirUnit
    {
        public Mutalisk() : base(20, 10)
        {
            base.Move();
        }
    }
}
