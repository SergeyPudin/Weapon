namespace Weapon
{
    class Bot
    {
        public IWeapon Weapon { get; private set; }

        public void OnSeePlayer(Player player)
        {
            Weapon.Fire(player);            
        }
    }
}