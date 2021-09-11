using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    

    bool m_IsGhostInRange;


   void OnTriggerEnter (Collider other)
    {
        GhostBase gb = other.GetComponent<GhostBase>();
        if(gb != null)
        {
            m_IsGhostInRange = true;
            gb.Damage();
        }

    }


    void Update ()
    {
        if(m_IsGhostInRange)
        {
            Vector3 direction =  transform.position + Vector3.up;
            
        }
    }
}
