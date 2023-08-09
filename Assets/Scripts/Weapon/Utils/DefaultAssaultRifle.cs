using UnityEngine;

namespace Weapon
{
    public abstract class DefaultAssaultRifle
    {
            public int FireRate    { get; protected set; }
            public int MagSize     { get; protected set; }
            public int UsesReserve { get; protected set; }
            
            
            public abstract WeaponFireResponse Fire();
            public abstract void Reload();
            public abstract GameObject Spawn(Vector3 position, Quaternion rotation);

            public class WeaponFireResponse
            {
                public bool couldFire { get; set; }
                public bool wasCanceled { get; set; }
                public int remainingAmmo { get; set; }
                
                
                public WeaponFireResponse(bool couldFire, int remainingAmmo)
                {
                    this.couldFire = couldFire;
                    this.remainingAmmo = remainingAmmo;
                }
            }
    }
}