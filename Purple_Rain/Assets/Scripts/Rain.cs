using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField] Line raindrop;
    [SerializeField] Line raindropFar;
    [SerializeField] Line raindropClose;

    // Start is called before the first frame update

    private void Start()
    {
        RainMaker();
        RainMakerClose();
        RainMakerFar();
    }

    void RainMaker()
    {
        for(var i = 0; i <100; i++)
        {
            Instantiate(raindrop);
        }
    }

    void RainMakerClose()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(raindropClose);
        }
    }

    void RainMakerFar()
    {
        for (var i = 0; i < 300; i++)
        {
            Instantiate(raindropFar);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
