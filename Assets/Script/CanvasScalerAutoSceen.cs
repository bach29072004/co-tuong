using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerAutoSceen : MonoBehaviour
{
    private void Awake()
    {
        
        float aspectRatio = AspectRatioSceen();
        if (aspectRatio >= 1.99F)
        {
            CanvasScaler canvasScaler = GetComponent<CanvasScaler>();
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            canvasScaler.matchWidthOrHeight = 1F;
        }
    }
    private static float AspectRatioSceen()
    {
        if (Screen.width > Screen.height)
            return (float)Screen.width / (float)Screen.height;
        else return (float)Screen.height / (float)Screen.width;
    }
}