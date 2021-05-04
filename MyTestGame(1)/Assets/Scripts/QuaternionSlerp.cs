using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionSlerp : MonoBehaviour
{
    [SerializeField] private Transform _from;
    [SerializeField] private Transform _to;

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Slerp(_from.rotation, _to.rotation,
        Time.time);
    }
}
