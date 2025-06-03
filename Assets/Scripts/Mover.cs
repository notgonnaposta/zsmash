using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour

{
    public GameObject Target; //the thing they go towards
    public float haste = 5f; //speed multiplier
    private Rigidbody2D rb; //the zombee's rigidbody
    public Grabby Grabby; //grab script
    public bool isonground; //bool to see if the zombee is colliding with a gameobject with the tag "ground"
    public bool isresting; //bool to control the rest after drop
    public float zhealth = 100f;//float for health
    public float damagemultiplier = 10f;// damage mutliplier
    public bool zdead = false;// death bool
    public Zcount zcount;// count of how many have died, used to roll for a chance at powerup spawning
    public bool latch; //footgun prevention 101: use latches
    

    // guess when start is called.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isonground = false;
        Grabby = GetComponent<Grabby>();
        Target = GameObject.Find("goto");
        zcount = GameObject.FindGameObjectWithTag("count").GetComponent<Zcount>();
    }
    void Update()
    {
        if (zhealth < 1 && zdead == false && latch == false)
        {
            StartCoroutine(Killer());
            isresting = true;
            latch = true;
        }
    }

    public IEnumerator Killer()
    {
zdead = true;        gameObject.layer = LayerMask.NameToLayer("dead zombee");
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        zcount.zcounter = zcount.zcounter + 1;
    }

    private IEnumerator Restafterdrop()
    {
        if (Grabby.HasBeenGrabbed == true){
            transform.rotation = Quaternion.Euler(0,0, 90);
isresting = true;
if (isonground ==true){
yield return new WaitForSeconds(5);
transform.rotation = Quaternion.Euler(0,0, 0);
isresting = false;
Grabby.HasBeenGrabbed = false;
}
        }   




    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Ground"))
        {
            zhealth -= Grabby.mouseVelocity.magnitude / damagemultiplier;
            
            isonground = true;
            if (Grabby.HasBeenGrabbed == true)
            {
StartCoroutine(Restafterdrop());
            }
        }

if (collision2D.gameObject.CompareTag("Falling Object"))
    {
        zhealth = -1f;
        isresting = true;
        Grabby.HasBeenGrabbed = true;
        transform.rotation = Quaternion.Euler(0,0, 90);
    
    }
        
    }
    private void OnCollisionExit2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Ground"))
        {
            isonground = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Grabby.IsDrag == false && Target != null && isonground == true && isresting == false && zhealth > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Vector3 direction = (Target.transform.position - transform.position).normalized;
            rb.linearVelocity = direction * haste; //linear velocity is a newer function, its different from the old one.
        }
        if (rb.linearVelocityX > 0.01f && Grabby.IsDrag == false && zdead == false && isresting == false && Grabby.HasBeenGrabbed == false)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);

        }
        else if (rb.linearVelocityX < -0.01f && Grabby.IsDrag == false && zdead == false && isresting == false && Grabby.HasBeenGrabbed == false)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
       }
    }
}