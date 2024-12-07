using System;

namespace Weapon
{
    class Player
    {
        private int _health;

        public Player()
        {
            if (_health <= 0)
                throw new InvalidOperationException(nameof(_health));
        }

        public int Health => _health;

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health < 0)
                _health = 0;
        }
    }
}