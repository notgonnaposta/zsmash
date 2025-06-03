using UnityEngine;

public class Zdamage : MonoBehaviour
{
    public Damage damage;
    public Grabby grabby;
    public Mover mover;
    public float damagetime = 1f;
    public bool updatejimmy =false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damage = GameObject.Find("goto").GetComponent<Damage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (updatejimmy == true && IsInvoking("damager") == false) 
        {
            if (grabby.IsDrag == false && mover.zhealth > 0 && mover.isresting == false && grabby.HasBeenGrabbed == false && mover.zdead == false)
            {
                Debug.Log("damge");
                InvokeRepeating("damager", 0, 1);
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        updatejimmy = true;
        if (collision.CompareTag("damage") && grabby.IsDrag == false && mover.zhealth > 0 && mover.isresting == false && grabby.HasBeenGrabbed == false && IsInvoking("damager") == false && mover.zdead == false)

        {
InvokeRepeating("damager", 0, 1);

        }

 }

private void OnTriggerExit2D(Collider2D collision)
{

CancelInvoke("damager");
updatejimmy = false;

}




 
    private void damager()
    {
        
        if (damage.health > 0 && mover.zhealth > 0)
        {

        
damage.health -= 1f;
        }
    }

}
