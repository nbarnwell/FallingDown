using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    private float _lastSpawnTime;

    public GameObject FallingBlockPrefab;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (_lastSpawnTime == 0f || (Time.fixedTime - _lastSpawnTime) > Random.Range(1f, 3.5f))
        {
            Instantiate<GameObject>(FallingBlockPrefab, transform);
            _lastSpawnTime = Time.fixedTime;
        }
    }
}
