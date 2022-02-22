using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSc : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            transform.position = new Vector3(transform.position.x, Target.transform.position.y - 11, transform.position.z);
        }
        
    }
}
