using UnityEngine;

namespace Weapon.Weapons.AssaultRifles
{
    public class AK47 : DefaultAssaultRifle
    {
        
        
        public override WeaponFireResponse Fire()
        {
            return new WeaponFireResponse(false, 0);
        }

        public override void Reload()
        {
            throw new System.NotImplementedException();
        }

        public override GameObject Spawn(Vector3 position, Quaternion rotation)
        {
            this.FireRate = 600;
            this.MagSize = 30;
            this.UsesReserve = 1;
            
            throw new System.NotImplementedException();
        }
    }
}