using UnityEngine.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class Powerupscaler : MonoBehaviour
{
    public float scaleduration = 3f;
    public float scaletimerr = 0f;
    public float rotationspeed = 45f;
    public Vector2 fullscale = Vector2.one;
    public GameObject Powerupsprite;
    public float progress = 0f;
    private SpriteRenderer spriteRenderer;
    public bool isclickedpipes;

    private Vector2 initialScale = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = initialScale;

        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            Color color = spriteRenderer.color;
            color.a = 0f;
            spriteRenderer.color = color;
        }
    }

    void OnMouseDown()
    {
        isclickedpipes = true;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scaletimerr = scaletimerr + Time.deltaTime;
        float progress = scaletimerr / scaleduration;

        if (progress > 1f)
        {
            progress = 1f;
        }
        Vector2 currentScale = Vector2.Lerp(Vector2.zero, Vector2.one, progress);
        transform.localScale = currentScale;
        transform.Rotate(Vector3.forward * rotationspeed *Time.deltaTime);
        if (spriteRenderer != null)
        {
            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(0f, 1f, progress);
            spriteRenderer.color = color;
        }
        if (scaletimerr > 10)
        {
            float fadeoutprogress = (scaletimerr - 10f) /3f;
            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(1f, 0f, fadeoutprogress);
            spriteRenderer.color = color;
        }
        if (scaletimerr > 13)
        {
            Destroy(gameObject);
        }
    }
}
