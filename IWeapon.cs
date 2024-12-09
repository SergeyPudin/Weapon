namespace Weapon
{
    interface IWeapon
    {
        int Damage { get; }
        int Bullets { get; }

        void Fire(Player player);
    }
}