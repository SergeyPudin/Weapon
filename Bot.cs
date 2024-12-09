using System;

namespace Weapon
{
    class Bot
    {
        public IWeapon Weapon { get; private set; }

        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new InvalidOperationException("Target is null");

            Weapon.Fire(player);            
        }
    }
}