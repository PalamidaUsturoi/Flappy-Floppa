using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MovingPipe : MonoBehaviour {
    public float speed;
    public float coordX;
    public float coordY;
    public float start;
    public float end;
    public float startY;
    public float endY;
    public Action<Collision2D> OnCollision;

    private void Start() {
        coordX = GetComponent<Transform>().position.x;
    }

    public void Stop() {
        speed = 0;
    }

    void Update() {
        coordX -= Time.deltaTime * speed;
        transform.position = new Vector3(coordX, coordY, 0f);
    }
}
