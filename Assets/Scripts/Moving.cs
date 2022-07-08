using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public float speed = 1;
    private float sizeX;
    private Vector2 offset;
    private Material material;

    private void Start() {
        sizeX = GetComponent<SpriteRenderer>().size.x;
        material = GetComponent<SpriteRenderer>().material;
    }

    public void Stop() {
        speed = 0;
    }

    void Update() {
        offset.x += Time.deltaTime * speed;
        offset.x %= sizeX;
        material.SetTextureOffset("_MainTex", offset);
    }
}
