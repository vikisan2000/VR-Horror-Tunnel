using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    private Light horrorLight;
    void Start() { horrorLight = GetComponent<Light>(); }

    void Update()
    {
        // Randomly changes intensity to create a scary flicker
        if (Random.value > 0.9f) 
            horrorLight.enabled = !horrorLight.enabled;
    }
}