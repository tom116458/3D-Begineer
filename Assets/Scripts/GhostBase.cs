using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Damage()
    {
        Destroy(gameObject);
    }
}
