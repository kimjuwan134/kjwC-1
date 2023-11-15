namespace kjwProgram
{
    #region 개방 폐쇄 원칙

    // 객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀있어야 함

    public class UnitManager
    {
        public void Commend(Unit unit)
        {
            unit.Move();
        }
    }

    public abstract class Unit
    {
        protected int health;
        protected int defense;
        public abstract void Move();
    }

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("마린 이동");
        }
    }

    public class Firebet : Unit
    {
        public override void Move()
        {
            Console.WriteLine("파이어벳 이동");
        }
    }

    public class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine("고스트 이동");
        }
    }


    #endregion

}
