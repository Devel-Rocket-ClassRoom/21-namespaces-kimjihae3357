using System;
using MyGame.Characters;
using MyGame.Items;

MyGame.Characters.Player character = new MyGame.Characters.Player();
character.Attack();
MyGame.Characters.Enemy character = new MyGame.Characters.Enemy();
character.TakeDamage();

MyGame.Items.Weapon item = new MyGame.Items.Weapon();
item.GetDamage();


namespace MyGame.Characters
{
    public class Player
    {
        public string Name = "용사";

        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }

    public class Enemy
    {
        public string Type = "고블린";

        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    public class Weapon
    {
        public string Name = "불꽃검";
        public int attack = 50;

        public void GetDamage()
        {
            Console.WriteLine($"무기 {Name}의 공격력: {attack}");
        }
    }

    public class Potion
    {
        public string Name = "체력 포션";

        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }

}
