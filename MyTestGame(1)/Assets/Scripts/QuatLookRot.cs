using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatLookRot : MonoBehaviour
{
    [SerializeField]
    private Transform _transformObject;

    
    void Update()
    {
        var relativePosition = _transformObject.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation;
    }
}
