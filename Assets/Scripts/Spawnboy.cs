using System.Collections;
using UnityEngine;

public class Spawnboy : MonoBehaviour
{
    public GameObject zombieprefab;
    public float spawninterval = 5f;
    public Transform spawnPoint;
    public GameObject obj;
    public Transform spawnpoint2;
    public Transform finalpoint;
    public int rand;
    public bool latch;
    public int rand2;
    
    public bool randlatch;
    public float rand3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        rand3 = UnityEngine.Random.Range(0.4f, 0.9f);
        obj = GameObject.FindGameObjectWithTag("zombee");
        if (obj != null)
        {
            Debug.Log("not spawning any zombees, gameobject found");
            latch = false;
        }
        else if (latch == false)
        {
            rand2 = UnityEngine.Random.Range(7, 20);
            StartCoroutine(spawnzombees(rand2));
            latch = true;
        }
    }

    IEnumerator spawnzombees(int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (randlatch == false)
            {
                rand = UnityEngine.Random.Range(1, 3);
                randlatch = true;
            }
            if (rand == 1)
            {
                finalpoint = spawnPoint;
            }
            else
            {
                finalpoint = spawnpoint2;
            }

            Instantiate(zombieprefab, finalpoint.position, Quaternion.identity);
            yield return new WaitForSeconds(rand3);
        }

        latch = false;
        randlatch = false;
    }
}
