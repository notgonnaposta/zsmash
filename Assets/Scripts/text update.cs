using UnityEngine;
using UnityEngine.UI;

public class textupdate : MonoBehaviour
{
    public Text textt;
    public Damage damage;
    public float health2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (damage != null)
        {
            textt.text = damage.health.ToString();
        }
    }
}
