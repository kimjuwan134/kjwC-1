using Microsoft.VisualBasic;

namespace kjwProgram
{

    internal class Program
    {

        static void Main(string[] args)
        {
            #region SRP 5대 원칙

            //Monster spider = new Monster("독거미", 10, 100);
            //spider.Patrol();

            //Information information = new Information();
            //information.MonsterInfo(spider);

            #endregion

            #region OCP 5대 원칙

            UnitManager unitManager = new UnitManager();

            unitManager.Commend(new Marine());
            unitManager.Commend(new Firebet());
            unitManager.Commend(new Ghost());

            #endregion
        }
    }
}