using UnityEngine;

public class HorrorAtmosphere : MonoBehaviour
{
    [Header("Tunnel Wall Settings")]
    public MeshRenderer tunnelRenderer;
    public Color tunnelColor = new Color(0.15f, 0.15f, 0.15f); // Dark Grey/Black

    [Header("Fog Settings (Hides the Sky)")]
    public bool useFog = true;
    public Color fogColor = Color.black;
    public float fogDensity = 0.05f;

    void Start()
    {
        // 1. Setup the Walls to look scary and wet
        if (tunnelRenderer != null)
        {
            // Use 'material' to create a unique instance for this ride
            tunnelRenderer.material.color = tunnelColor;
            
            // This makes the walls reflect your flickering light (slimy look)
            tunnelRenderer.material.SetFloat("_Glossiness", 0.8f); 
            tunnelRenderer.material.SetFloat("_Metallic", 0.4f);
        }

        // 2. Setup the Fog so the 'hole' at the end is pitch black
        if (useFog)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = fogColor;
            RenderSettings.fogDensity = fogDensity;
            RenderSettings.fogMode = FogMode.ExponentialSquared;
        }
    }
}