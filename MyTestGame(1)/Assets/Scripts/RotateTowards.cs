using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 1;

    private void FixedUpdate()
    {
        Vector3 targetDir = _target.position - transform.position;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir,
        _speed * Time.deltaTime, 0.0F);
        Debug.DrawRay(transform.position, newDir, Color.red);

        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
