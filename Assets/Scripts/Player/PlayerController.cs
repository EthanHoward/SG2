using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(MeshCollider))]
    public class PlayerController : MonoBehaviour
    {

        [Tooltip("The camera to use for the player.")]
        [SerializeField] private new Camera camera;

        [Tooltip("Asset to use for player's character")]
        [SerializeField] private GameObject mdlPlayer;

        // -- -- -- -- PRIVATE FIELDS -- -- -- -- //

        private GameObject _gameobjectCharacterModel;

    

        void Start()
        {
            // here we will spawn the player and the camera.

            _gameobjectCharacterModel = Instantiate(mdlPlayer, gameObject.transform, true);
            _gameobjectCharacterModel.transform.position = gameObject.transform.position;

            var skinnedMeshRenderers =
                _gameobjectCharacterModel.GetComponentsInChildren<SkinnedMeshRenderer>();
            foreach (var smr in skinnedMeshRenderers)
            {
                var mesh = new Mesh();
                smr.BakeMesh(mesh);
                var meshCollider = smr.gameObject.AddComponent<MeshCollider>();
                meshCollider.sharedMesh = mesh;
                meshCollider.convex = false;
            }

        }

        // Update is called once per frame
        /*
        void Update()
        {
        
        }*/
    
    }
}
