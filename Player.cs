using System;

namespace Weapon
{
    class Player
    {
        public Player(int health)
        {
            Health = health;

            if (Health <= 0)
                throw new InvalidOperationException($"{nameof(Health)} <= 0");
        }

        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new InvalidOperationException($"{nameof(damage)} < 0");

            Health -= damage;

            if (Health < 0)
                Health = 0;
        }
    }
}