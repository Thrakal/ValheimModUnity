using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardProtect : MonoBehaviour
{
    private Material mat;
    private float pulseTime = 3f;
    private float timer = 0f;
    private bool fadeIn = true;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponentInChildren<MeshRenderer>().material;
        StartCoroutine(PulseColor());
    }
    
    IEnumerator PulseColor() {
        while(true) {
            float perc = 0f;
 
            if(fadeIn) {
                timer += Time.deltaTime;
                perc = Mathf.Min(timer / pulseTime, 1f);
            } else {
                timer -= Time.deltaTime;
                perc = Mathf.Max(timer / pulseTime, 0f);
            }

            if(timer <= 0f) {
                fadeIn = true;
            } else if(timer >= pulseTime) {
                fadeIn = false;
            }

            mat.color = Color.HSVToRGB(277f / 360f, 1f, perc);
            yield return null;
        }
    }
}
