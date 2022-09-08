using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMove : MonoBehaviour
{
    public GameObject prefab;
    private GameObject instance;

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
        transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);
        instance = Instantiate(prefab, transform);
    }
}