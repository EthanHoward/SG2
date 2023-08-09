using UnityEngine;

namespace Weapon
{
    public abstract class DefaultAssaultRifle
    {
            /**
             * The fireRate is rounds/minute
             * For example:
             * -- AK47 - 600 rpm 'Cyclic' which is full auto and no degredation due to heat wear or ammo constraints
             * -- AK47 - 40 rpm 'Semi-Auto'
             * -- Ak47 - 100 rpm ' Full Auto '
             */
            public int fireRate    { get; protected set; }
            /**
             * Initial magSize
             */
            public int magSize     { get; protected set; }
            /**
             * Initial reserveSize
             */
            public int reserveSize { get; protected set; }
            
            /**
             * Stores the current ammunition which is withing the magazine this does NOT include the possibly chambered round
             */
            public int inMagazineAmmo { get; protected set; }
            /**
             * Stores the remaining ammunition which is not in the magazine
             */
            public int remainingReserve { get; protected set; }
            /**
             * This is an int simply as it is easier to sort chamber calculations out using ints than booleans.
             */
            public int inChamberAmmo { get; protected set; }
        
            public abstract GameObject Spawn(Vector3 position, Quaternion rotation);

            
    }
}