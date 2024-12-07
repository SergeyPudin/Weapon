using System;

namespace Weapon
{
    class Weapon : IWeapon
    {
        private int _damage;
        private int _bullets;

        public Weapon()
        {
            ConfirmPositive(_damage);
            ConfirmPositive(_bullets);
        }

        public int Damage => _damage;
        public int Bullets => _bullets;

        public void Fire(Player player)
        {
            if (_bullets == 0)
                return;

            player.TakeDamage(_damage);

            _bullets -= 1;
        }

        private void ConfirmPositive (int value)
        {
            if (value < 0)
                throw new InvalidOperationException(nameof(value));
        }
    }
}