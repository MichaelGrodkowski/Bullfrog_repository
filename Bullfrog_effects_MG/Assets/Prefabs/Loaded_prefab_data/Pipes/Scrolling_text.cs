using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_text : MonoBehaviour
{
    public float ScrollX = 0.5f;
    public float Scrolly = 0.5f;
    void Update()
    {
        float offsetX = Time.time * ScrollX;
        float offsetY = Time.time * Scrolly;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
