using UnityEngine;

namespace Weapon.Weapons.AssaultRifles
{
    public class AK47 : DefaultAssaultRifle
    {
        public override GameObject Spawn(Vector3 position, Quaternion rotation)
        {
            this.fireRate = 100;
            this.magSize = 30;
            this.reserveSize = 124;
            
            this.inChamberAmmo = 1;
            this.inMagazineAmmo = 30;
            this.remainingReserve = this.reserveSize;
            
            
            
            throw new System.NotImplementedException();
        }
    }
}