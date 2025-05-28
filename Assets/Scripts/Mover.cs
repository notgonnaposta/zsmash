using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour

{
    public GameObject Target;
    public float haste = 5f;
    private Rigidbody2D rb;
    private Rigidbody2D piperb;
    public Grabby Grabby;
    public bool isonground;
    public bool isresting;
    public float zhealth = 100f;
    public float damagemultiplier = 10f;
    public bool zdead = false;
    public Zcount zcount;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        if (zhealth < 0)
        {
            StartCoroutine(Killer());
            isresting = true;
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
isresting = true;
if (isonground ==true){
yield return new WaitForSeconds(5);
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
        transform.rotation = quaternion.Euler(0,0, 90);
    
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
            rb.linearVelocity = direction * haste;
        }
        if (rb.linearVelocityX > 0.01f && Grabby.IsDrag == false && zdead == false && isresting == false)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);

        }
        else if (rb.linearVelocityX < -0.01f && Grabby.IsDrag == false && zdead == false && isresting == false)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
       }
    }
}
