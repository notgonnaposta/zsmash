using Unity.Mathematics;
using UnityEngine;

public class Spawnboy : MonoBehaviour
{
    public GameObject zombieprefab;
    public float spawninterval = 5f;
    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        InvokeRepeating("spawnzombie", 0f, spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnzombie()
    {
        Instantiate(zombieprefab, spawnPoint.position, Quaternion.identity);
    }
}
