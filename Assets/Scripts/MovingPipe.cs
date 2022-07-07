using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    public float speed;
    private float coordX;
    private float coordY;
    public float start;
    public float end;
    public float startY;
    public float endY;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Start()
    {
        coordX = GetComponent<Transform>().position.x;
        coordY = Random.Range(startY, endY);
    }

    void Update()
    {
        coordX -= Time.deltaTime * speed;
        transform.position = new Vector3(coordX,coordY,0f);
        if (coordX < end)
        {
            transform.position = new Vector3(start,coordY,0f);
            coordX = start;
        }
    }
}
