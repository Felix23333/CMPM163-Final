using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateTexture : MonoBehaviour
{
    public float Xspeed = 0;
    public float Yspeed = 0;
    float curX;
    float curY;
    // Start is called before the first frame update
    void Start()
    {
        curX = GetComponent<MeshRenderer>().material.mainTextureOffset.x;
        curY = GetComponent<MeshRenderer>().material.mainTextureOffset.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        curX += Xspeed * Time.deltaTime;
        curY += Yspeed * Time.deltaTime;
        GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(curX, curY));
        GetComponent<MeshRenderer>().material.SetTextureOffset("_BumpMap", new Vector2(curX, curY));
    }
}
