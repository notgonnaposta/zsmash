using UnityEngine;

public class showpref : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject settingsmenu;

    public void preftomenu()
    {
        settingsmenu.SetActive(true);
        mainmenu.SetActive(false);
    }
}
