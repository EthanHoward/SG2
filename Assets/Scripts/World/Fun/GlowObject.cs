using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowObject : MonoBehaviour
{

    [Header("Glow Config")]
    [Tooltip("The intensity of the glow")]
    [SerializeField] private float glowIntensity = 255.0f;
    [Tooltip("The color to glow.")]
    [SerializeField] public Color glowColor = Color.blue;

    // -- -- -- -- PRIVATE FIELDS -- -- -- -- //

    private Material glowMaterial;
    private Renderer parentRenderer;
    
    void Start()
    {
        parentRenderer = gameObject.GetComponent<Renderer>();

        glowMaterial = new Material(parentRenderer.material);
        glowMaterial.EnableKeyword("_EMISSION");
        glowMaterial.SetColor("_EmissionColor", glowColor * glowIntensity);
        parentRenderer.material = glowMaterial;

    }

    // Update is called once per frame
    void Update()
    {
        if (glowColor != (glowMaterial.GetColor("_EmissionColor") / glowIntensity))
        {
            glowMaterial.SetColor("_EmissionColor", glowColor * glowIntensity);
            parentRenderer.material = glowMaterial;
        }
    }
}
