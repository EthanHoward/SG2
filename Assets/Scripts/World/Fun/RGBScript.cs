using UnityEngine;

public class RGBScript : MonoBehaviour
{

    private GlowObject go_Object;
    
    void Start()
    {
        go_Object = gameObject.GetComponent<GlowObject>();
    }
    
    void Update()
    {
        float hue = stepHSL();
        Color color = hslToRGB(hue, saturation, lightness);
        go_Object.glowColor = color;
    }

    [Header("HSL Settings")]
    [SerializeField] private float hue = 0f;
    [SerializeField] private float saturation = 255f;
    [SerializeField] private float lightness = 0.5f;

    float stepHSL()
    {
        hue += Time.deltaTime * 10f;
        if (hue >= 360f) hue -= 360f;
        return hue;
    }

    Color hslToRGB(float h, float s, float l)
    {
        h /= 360f;
        s /= 100f;
        l /= 100f;

        float c = (1f - Mathf.Abs(2f * l - 1f)) * s;
        float x = c * (1f - Mathf.Abs((h * 6f) % 2f - 1f));
        float m = l - c / 2f;

        float r, g, b;
        if (h < 1f / 6f)
        {
            r = c;
            g = x;
            b = 0f;
        }
        else if (h < 2f / 6f)
        {
            r = x;
            g = c;
            b = 0f;
        }
        else if (h < 3f / 6f)
        {
            r = 0f;
            g = c;
            b = x;
        }
        else if (h < 4f / 6f)
        {
            r = 0f;
            g = x;
            b = c;
        }
        else if (h < 5f / 6f)
        {
            r = x;
            g = 0f;
            b = c;
        }
        else
        {
            r = c;
            g = 0f;
            b = x;
        }

        return new Color(r + m, g + m, b + m);
    }
}