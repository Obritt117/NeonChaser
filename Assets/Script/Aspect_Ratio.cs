using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspect_Ratio : MonoBehaviour
{
    public float targetAspectWidth = 80.0f; // Target aspect width (e.g., 16)
    public float targetAspectHeight = 1.0f; // Target aspect height (e.g., 9)

    // Start is called before the first frame update
    void Start()
    {
        float targetAspect = targetAspectWidth / targetAspectHeight;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera camera = Camera.main;

        if (scaleHeight < 1.0f)
        {
            Rect rect = camera.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            camera.rect = rect;
        }
        else 
        {
             float scaleWidth = 1.0f / scaleHeight;
            Rect rect = camera.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            camera.rect = rect;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
