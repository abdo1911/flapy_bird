using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapes : MonoBehaviour
{
    public GameObject shape;
    public float spawnRate = 1f;
    public float min = -1f;
    public float max = 1f;

    public void onEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    public void onDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    public void Spawn()
    {
        GameObject pipes = Instantiate(shape, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(min, max);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
