using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{

    Transform[] childObjects;
    public List<Transform> childSquareList = new List<Transform>();

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

    }

}
