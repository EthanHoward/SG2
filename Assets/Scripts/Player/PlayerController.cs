using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class PlayerController : MonoBehaviour
{

    [Tooltip("The camera to use for the player.")]
    [SerializeField] private Camera camera;

    [Tooltip("Asset to use for player's character")]
    [SerializeField] private GameObject mdlPlayer;

    // -- -- -- -- PRIVATE FIELDS -- -- -- -- //

    private GameObject _gameobjectCharacterModel;

    

    void Start()
    {
        // here we will spawn the player and the camera.

        _gameobjectCharacterModel = Instantiate(mdlPlayer);
        _gameobjectCharacterModel.transform.parent = gameObject.transform;
        _gameobjectCharacterModel.transform.position = gameObject.transform.position;

        SkinnedMeshRenderer[] skinnedMeshRenderers =
            _gameobjectCharacterModel.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
        {
            Mesh mesh = new Mesh();
            smr.BakeMesh(mesh);
            MeshCollider meshCollider = smr.gameObject.AddComponent<MeshCollider>();
            meshCollider.sharedMesh = mesh;
            meshCollider.convex = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // -- Gun Logic -- //

    private enum Guns
    {
        RIFLE_AK47,
        RIFLE_AUGA3,
        RIFLE_G36C,
        RIFLE_M16 //?
    }

    
}
