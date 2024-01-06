// Re: devmarcstorm/ObjectSpawner.cs - 2018
// https://gist.github.com/devmarcstorm/22664b8ba8fe7e19926199733c797cf4

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Objects to spawn")]
    public List<GameObject> objects = new List<GameObject>();

    [Header("Reference")]
    GameObject reference;

    // Start is called before the first frame update
    void Start()
    {
        // Disable Renderer 
        Renderer renderer = GetComponent<Renderer>();
        if (renderer)
            renderer.enabled = false;

        // Destroy referenced object if active
        if (reference)
            Destroy(reference);

        // Randomly Spawn an Object
        int index = Random.Range(0, objects.Count);
        Instantiate(objects[index], transform);
    }
}