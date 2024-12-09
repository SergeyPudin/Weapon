using System;

namespace Weapon
{
    class Weapon : IWeapon
    {
        public Weapon(int damage, int bullet)
        {
            ConfirmPositive(Damage);
            ConfirmPositive(Bullets);

            Damage = damage;   
            Bullets = bullet;
        }

        public int Damage { get; private set; }
        public int Bullets { get; private set; }

        public void Fire(Player player)
        {
            if (player == null)
                throw new InvalidOperationException("Target is null");

            if (Bullets == 0)
                throw new InvalidOperationException("No bullets");

            player.TakeDamage(Damage);

            Bullets --;
        }

        private void ConfirmPositive (int value)
        {
            if (value < 0)
                throw new InvalidOperationException($"{nameof(value)} < 0");
        }
    }
}