using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scaler : MonoBehaviour
{
    public GameObject prefab;
    private GameObject instance;
    public float minimum = 1.0F;
    public float maximum = 2.0F;


    void Start()
    {

    }

    void Update()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        var rotation = Quaternion.identity;
        transform.localScale = new Vector3(Mathf.PingPong(Time.time, maximum - minimum) + minimum, Mathf.PingPong(Time.time, maximum - minimum) + minimum, Mathf.PingPong(Time.time, maximum - minimum) + minimum);
        instance = Instantiate(prefab, transform);
    }
}