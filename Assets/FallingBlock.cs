using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    private float _speed;
    private Vector2 _sizeChange;

    // Start is called before the first frame update
    void Start()
    {
        _speed = Random.Range(25, 80);

        var halfScreenSize = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
        transform.position = new Vector2(Random.Range(-halfScreenSize.x, halfScreenSize.x), halfScreenSize.y + (transform.localScale.y / 2));

        _sizeChange = new Vector3(Random.Range(1f, 15f), Random.Range(1f, 15f), 1f);
        transform.localScale += (Vector3)_sizeChange;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * _speed * Time.fixedDeltaTime);
    }
}
