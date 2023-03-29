using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverY : MonoBehaviour
{
    public Slider sliderY;
    public void  MoverDeLugar()
    {
        gameObject.transform.position = new Vector3(0,5,0);
    
    }

    public void CambioSlider()
{
    Debug.Log("Cambió En Y");
    Debug.Log(sliderY.value);
    gameObject.transform.position = new Vector3(0,sliderY.value,0);
}
}