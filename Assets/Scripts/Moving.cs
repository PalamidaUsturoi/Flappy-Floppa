using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 1;
    private float sizeX;
    private Vector2 offset;
    private Material material;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Start()
    {
        sizeX = GetComponent<SpriteRenderer>().size.x;
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        offset.x += Time.deltaTime * speed;
        offset.x %= sizeX;
        material.SetTextureOffset("_MainTex", offset);
    }
}
