using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] Camera camera;

    Vector3 vector0;
    Vector3 vector1;
    float height;
    float width;
   
    float dropSize;
    // Start is called before the first frame update

    void Start()
    {
        CameraSize();
        ResetFall();
        dropSize = GetComponent<LineRenderer>().GetPosition(0).y;
    }

    void CameraSize()
    {
        height = 2 * Camera.main.orthographicSize;
        width = Camera.main.aspect * height;
    }

    float RandomPosition()
    {
        return UnityEngine.Random.Range(width /2 * -1, width / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + dropSize < camera.orthographicSize * -1)
            ResetFall();
        RainFall();
    }

    private void ResetFall()
    {
        //TODO: tirar magic number
        transform.position = new Vector3(RandomPosition(), UnityEngine.Random.Range(6.00f, 12.00f));

        if (dropSize > 0.5)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UnityEngine.Random.Range(-5.00f, -1.00f));
        if (dropSize < 0.5)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UnityEngine.Random.Range(-10.00f, -5.00f));
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UnityEngine.Random.Range(-15.00f, -10.00f));

    }

    private void RainFall()
    {
        vector0 = new Vector3(transform.position.x, transform.position.y + dropSize);
        vector1 = new Vector3(transform.position.x, transform.position.y);
        GetComponent<LineRenderer>().SetPosition(0, vector0);
        GetComponent<LineRenderer>().SetPosition(1, vector1);
        
    }
}
