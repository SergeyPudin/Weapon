using System;

namespace Weapon
{
    class Weapon : IWeapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullet)
        {
            ConfirmPositive(_damage);
            ConfirmPositive(_bullets);

            _damage = damage;   
            _bullets = bullet;
        }

        public int Damage => _damage;
        public int Bullets => _bullets;

        public void Fire(Player player)
        {
            if (player == null)
                throw new InvalidOperationException("Target is null");

            if (_bullets == 0)
                return;

            player.TakeDamage(_damage);

            _bullets --;
        }

        private void ConfirmPositive (int value)
        {
            if (value < 0)
                throw new InvalidOperationException(nameof(value));
        }
    }
}