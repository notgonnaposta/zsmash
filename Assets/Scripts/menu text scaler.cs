using System.Numerics;
using UnityEngine;

public class menutextscaler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public UnityEngine.Vector2 minscale = new UnityEngine.Vector2(1f,1f);
public UnityEngine.Vector2 maxscale = new UnityEngine.Vector2 (1.3f, 1.3f);
public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        float lerpFactor = Mathf.PingPong(Time.time * speed, 1f);
        transform.localScale = UnityEngine.Vector2.Lerp(minscale, maxscale, lerpFactor);
    }
}
