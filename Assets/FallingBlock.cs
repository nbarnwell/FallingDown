using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    private Vector2 _halfScreenSize;
    private Vector2 _velocity;
    private Vector2 _sizeChange;

    // Start is called before the first frame update
    void Start()
    {
        var direction = new Vector2(Random.Range(-0.5f, 0.5f), Vector2.down.y).normalized;
        var speed = Random.Range(25, 80);
        _velocity = direction * speed;

        _halfScreenSize = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
        transform.position = new Vector2(Random.Range(-_halfScreenSize.x, _halfScreenSize.x), _halfScreenSize.y + (transform.localScale.y / 2));

        _sizeChange = new Vector3(Random.Range(1f, 15f), Random.Range(1f, 15f), 1f);
        transform.localScale += (Vector3)_sizeChange;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(_velocity * Time.fixedDeltaTime);

        if (topOfFallingBlock() < bottomOfScreen())
        {
            Destroy(transform.gameObject);
        }
    }

    private float topOfFallingBlock()
    {
        return transform.position.y + (transform.localScale.y / 2);
    }

    private float bottomOfScreen()
    {
        return -_halfScreenSize.y;
    }
}
