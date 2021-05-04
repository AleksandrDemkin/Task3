using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField]
    private Vector3 _vectorFirst;
    private float _distance;

    void Start()
    {
        _distance = Vector3.Distance(_vectorFirst, transform.position);
        Debug.Log(_distance);

        _distance = (_vectorFirst - transform.position).magnitude;
        Debug.Log(_distance);
    }
}
