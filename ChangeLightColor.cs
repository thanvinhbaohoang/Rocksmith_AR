using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLightColorRed()
    {
        print("red pressed");
        light.color = Color.red;
    }

    public void SetLightColorWhite()
    {
        print("white pressed");
        light.color = Color.white;
    }

    public void SetLightColorZap()
    {
        print("zap started");
        StartCoroutine(ZapCoroutine());
    }

    public IEnumerator ZapCoroutine()
    {
        Color oldColor = light.color;
        light.color = Color.cyan;

        yield return new WaitForSeconds(0.5f);
        light.color = oldColor;
        yield return new WaitForSeconds(0.2f);
        light.color = Color.cyan;
        yield return new WaitForSeconds(0.2f);
        light.color = oldColor;
        yield return new WaitForSeconds(0.2f);
        light.color = Color.cyan;
        yield return new WaitForSeconds(0.5f);
        light.color = oldColor;
    }
}
