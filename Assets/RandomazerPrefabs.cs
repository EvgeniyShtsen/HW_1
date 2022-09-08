using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomazerPrefabs : MonoBehaviour
{
    public GameObject[] prefabsArray = new GameObject[4];
    private GameObject instance;

    void Start()
    {
        int rand = Random.Range(0, prefabsArray.Length);
        instance = Instantiate(prefabsArray[rand], prefabsArray[rand].transform.position, prefabsArray[rand].transform.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (instance != null)
            {
                Destroy(instance);
            }
            int rand = Random.Range(0, prefabsArray.Length);
            instance = Instantiate(prefabsArray[rand], prefabsArray[rand].transform.position, prefabsArray[rand].transform.rotation);
        }
    }
}