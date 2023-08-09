using UnityEngine;
using Weapon.Utils;

namespace Weapon
{
    public class AssaultRifle
    {
        [Header("Important Locations")] 
        public Transform MuzzleFlashLocation;
        public Transform AttachmentLocation;
        public Transform OpticLocation;
        public Transform OptionalGunOffset;
        
        [Header("Allowed Optics")] public Accessories.Optics[] AllowedOptics;

        [Header("Allowed Attachments")] public Accessories.Attachments[] AllowedAttachments;

        [Header("Gun Variables")] 
        public int FireRate = 100;
        
        public AssaultRifle()
        {
            
        }
        
        private void Start()
        {
            
        }

        public void Fire()
        {
            
        }

        public void Reload()
        {
            
        }

        /**
         * Do this in the future
         */
        
        public void Inspect()
        {
            
        }
    }
}