using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalarVectorMultiplication : MonoBehaviour
{
    [SerializeField]
    private Vector3 _vectorFirst;
    [SerializeField]
    private Vector3 _vectorSecond;
    // Start is called before the first frame update
    void Update()
    {
        //Relations of vectors
        Debug.Log($"Scalar multiplication: {Vector3.Dot(_vectorFirst.normalized, _vectorSecond.normalized)}");
        //Normal of vectors
        Debug.Log($"Vector multiplication: {Vector3.Cross(_vectorFirst.normalized, _vectorSecond.normalized)}");
    }
}
