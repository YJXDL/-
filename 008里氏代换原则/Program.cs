using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008里氏代换原则
{
    public abstract class AbstractGun
    {
        public abstract void Shoot();
    }
    public class HandGun: AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("手枪射击");
        }
    }
    public class Rifle:AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("莱福枪射击");
        }
    }

    public class MachineGun : AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("机枪射击");
        }
    }
    public class ToyGun : AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("玩具枪射击");
        }
    }
    public class G3 : Rifle
    {
        public void ZoomOut()
        {
            Console.WriteLine("用望远镜查看敌人");
        }
        public  void Shoot()
        {
            Console.WriteLine("G3射击");
        }
    }

    public class Snipper
    {
        public void KillEnermy(G3 g3)
        {
            g3.ZoomOut();
            g3.Shoot();
        }
    }

    public class Soldier
    {
        public void KillEnermy(AbstractGun gun)
        {
            Console.Write("战士开始战斗,用") ;
            gun.Shoot();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.KillEnermy(new HandGun());
            soldier.KillEnermy(new Rifle());
            Snipper snipper = new Snipper();
            snipper.KillEnermy(new G3());
            Console.ReadKey();
        }
    }
}
