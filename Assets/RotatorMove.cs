
using UnityEngine;

public class RotatorMove : MonoBehaviour
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
        transform.Rotate(0, 0.15f, 0);
        instance = Instantiate(prefab, transform);
    }
}