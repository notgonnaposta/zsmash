using UnityEngine;

public class hidepref : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject settingsmenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void preftomenu()
    {
        mainmenu.SetActive(true);
        settingsmenu.SetActive(false);
    }
}
