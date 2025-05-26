using UnityEngine;

public class bigbertha : MonoBehaviour
{
    public Powerupscaler powerupscaler;
    public GameObject powerup;
    public GameObject pipes;
    public thedreadedscript thedreadedscript;
    public bool hasbeendone;
    public piperscript piperscript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasbeendone = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (thedreadedscript.powerupmade == true && thedreadedscript.spawnedpowerup != null)
        {
            powerup = thedreadedscript.spawnedpowerup;
        powerupscaler = powerup.GetComponent<Powerupscaler>();
    }
        if (thedreadedscript.spawnedpowerup != null && thedreadedscript.powerupmade == true)
        {
        if (powerupscaler.isclickedpipes == true && hasbeendone == false && thedreadedscript.powerupmade == true )
        {
            pipes.SetActive(true);
            hasbeendone = true;
            thedreadedscript.powerupmade = false;
            gameObject.SetActive(false);
        }
        }
        
    }
}
