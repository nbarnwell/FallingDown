using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject FallingBlockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate<GameObject>(FallingBlockPrefab, transform);
    }
}
