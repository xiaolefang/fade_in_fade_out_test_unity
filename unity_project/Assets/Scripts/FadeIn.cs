using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private Material fadeInMaterial; // Assign the material with the custom shader in the inspector
    public float fadeInTime = 100.0f;
    private float currentTransparency = 0.0f;

    private void Start() {
        fadeInMaterial = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        if (currentTransparency < 1.0f)
        {
            currentTransparency += Time.deltaTime / fadeInTime;
            currentTransparency = Mathf.Clamp01(currentTransparency);
            fadeInMaterial.SetFloat("_Transparency", currentTransparency);
        }
    }
}