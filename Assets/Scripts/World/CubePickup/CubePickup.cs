using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePickup : MonoBehaviour
{
    private Vector3 rotation = new Vector3();
    
    void Start()
    {
        rotation.x = 0f;
        rotation.y = 0f;
        rotation.z = 0f;

        Vector3 newPos = new Vector3(0f, gameObject.transform.position.y + 2f, 0f);
        
        gameObject.transform.position = newPos;
    }

    [Tooltip("The modifier for the rotation speed, below 1f is slower and above 1f is faster")]
    [SerializeField] private float rotationModifier = 1f;
    [Tooltip("The modifier for the bob action, below 1f makes it (s)lower and above 1f is faster / higher")]

    void Update()
    {
        rotation.y += (1f * rotationModifier);
        gameObject.transform.eulerAngles = rotation;
    }
}
