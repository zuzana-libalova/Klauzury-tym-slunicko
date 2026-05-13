using UnityEngine;

public class SunCycle : MonoBehaviour
{
    public Light sunLight;

    public float dayTemperature = 6500f;
    public float sunsetTemperature = 2000f;

    public float duration = 180f;
    private float timer = 30f;

    void Update()
    {
        timer += Time.deltaTime;

        float t = Mathf.Clamp01(timer / duration);

        float temp = Mathf.Lerp(dayTemperature, sunsetTemperature, t);
        sunLight.colorTemperature = temp;
    
    }

}