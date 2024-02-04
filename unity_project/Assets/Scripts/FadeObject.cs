using UnityEngine;

public class FadeObject : MonoBehaviour
{
    public float fadeDuration = 2.0f;
    private Material material;
    private bool isFadingIn = true;
    private float lerpTime;
    private float unit;
    private float alpha = 0;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
        lerpTime = isFadingIn ? 0f : 1f;
        unit = 1 / fadeDuration;
    }

    void Update()
    {
        // float alpha = Mathf.Lerp(isFadingIn ? 0f : 1f, isFadingIn ? 1f : 0f, lerpTime / fadeDuration);
        // material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
        // lerpTime += Time.deltaTime;

        // if (lerpTime > fadeDuration)
        // {
        //     isFadingIn = !isFadingIn;
        //     lerpTime = 0f;
        // }
        if (isFadingIn)
        {
            alpha = material.color.a;
            Debug.Log(alpha);
            if (alpha >= 1) {
                isFadingIn = false;
                return;
            }
            alpha += Time.deltaTime * unit;
            material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
        }
    }
}