using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalizedVector : MonoBehaviour
{
    [SerializeField]
    private Vector3 _vectorFirst;
    // Start is called before the first frame update
    void Start()
    {
        var a = _vectorFirst.normalized;
        Debug.Log($"Normalize vector: {a}");
    }
}
