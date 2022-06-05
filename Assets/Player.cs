using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 7f;

    private float _leftLimit;
    private float _rightLimit;

    void Start() 
    {
        var gameAreaWidth = Camera.main.aspect * Camera.main.orthographicSize;
        _leftLimit = -gameAreaWidth - transform.localScale.x / 2;
        _rightLimit =  gameAreaWidth + transform.localScale.x / 2;
    }

    void FixedUpdate()
    {
        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        var velocity = input.normalized * speed;
        transform.Translate(velocity * Time.fixedDeltaTime);

        if (transform.position.x < _leftLimit)
        {
            transform.position = new Vector2(_rightLimit, transform.position.y);
        }
        else if (transform.position.x > _rightLimit)
        {
            transform.position = new Vector2(_leftLimit, transform.position.y);
        }
    }
}
