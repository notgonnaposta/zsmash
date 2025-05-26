using UnityEngine;

public class thedreadedscript : MonoBehaviour
{
    public Zcount zcount;
    public int howmanyoftheundeadyouhavetovanquishtogetaspawnchance;
    public int minvaluerand;
    public int maxvaluerand;
    public GameObject powerup;
    private int lasttriggercount = -1;
    public bigbertha bigbertha;
    public bool powerupmade;
    public GameObject spawnedpowerup;
    public piperscript piperscript;
    public bool hasbeenexecuted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (zcount.zcounter % howmanyoftheundeadyouhavetovanquishtogetaspawnchance == 0 && lasttriggercount != zcount.zcounter && zcount.zcounter > 0)
        {
            Debug.Log("made it past the IF");
            powerupmade = true;
            lasttriggercount = zcount.zcounter;
            int randomValue = Random.Range(minvaluerand, maxvaluerand);
            if (randomValue == 1)
            
            {
                powerupmade = true;
                Debug.Log("made it to the second IF");
                spawnedpowerup = Instantiate(powerup,transform.position, Quaternion.identity);

                
                
            }

        }
        if (piperscript.jimshin == true)
        {
           powerupmade = false; 
        }
          if (piperscript.jimshin == false)
        {
           powerupmade = true; 
        }
    }
}
