using System.Numerics;
using UnityEngine;
using UnityEngine.Rendering;

public class Grabby : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool IsDrag = false;
    public bool HasBeenGrabbed = false;
    private UnityEngine.Vector2 release;
    private UnityEngine.Vector2 lastMousePosition;
    public UnityEngine.Vector2 mouseVelocity;
    public float YeetMultiplier = 10f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
       IsDrag = true;
       HasBeenGrabbed = true;
       lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
    void OnMouseUp()
    {
        rb.linearVelocity = mouseVelocity * YeetMultiplier;
       
        IsDrag = false;
        
    }


    void FixedUpdate()
    {
        if(IsDrag)
        {
UnityEngine.Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        rb.MovePosition(mousePosition);

        // Calculate mouse velocity when dragging
        mouseVelocity = (UnityEngine.Vector2)(mousePosition - (UnityEngine.Vector3)lastMousePosition) / Time.fixedDeltaTime;
        lastMousePosition = mousePosition;
        }
        
    }
}
