using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMove : MonoBehaviour
{
    public GameObject prefab;
    private GameObject instance;
    public float repeat_time;
    private float curr_time;

    void Start()
    {
        repeat_time = 1f;
        curr_time = repeat_time * 1f;
    }

    void Update()
    {
        curr_time -= Time.deltaTime;
        if (curr_time <= 0)
        {
            if (instance != null)
            {
                Destroy(instance);
            }
            var rotation = Quaternion.identity;
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            instance = Instantiate(prefab, transform);
            curr_time = repeat_time * 1f;
        }
    }
}