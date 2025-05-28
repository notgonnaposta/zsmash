using UnityEngine;

public class GameoverYEAHHH : MonoBehaviour
{
    public GameObject Gameoverscreen;
    public Damage damage;
    public pause pause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage.health == 0)
        {


            Gameoverscreen.SetActive(true);
             Time.timeScale = 0;
        AudioListener.pause = true;
        }
        
    }
}
