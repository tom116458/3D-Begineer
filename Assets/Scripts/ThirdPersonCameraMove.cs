using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraMove : MonoBehaviour
{
   public Transform Player;
   private float m1;
   private float m2;
   private int x = 0;
   public float mo = 5;
   Vector3 c;
   
   private void Start() 
   {
       c = (transform.position - Player.position).normalized;
   }

   private void LateUpdate()
   {
       Look();
   }

   private void Look()
   {
       if(Input.GetAxis("Mouse Y") !=0 || Input.GetAxis("Mouse X")!=0)
       {
           c = (transform.position - Player.position).normalized;
       }
       Vector3 cc;
       if (c.z==0)
       {
           cc = new Vector3(0,0,-1);
       }
       else
       {
           cc = new Vector3 (-c.z/c.x, 0, 1).normalized;
       }

       if(c.x>0)
       {
           x=1;
       }
       else
       {
           x=-1;
       }

       if((c.y>0 && c.y*mo<4) || (c.y<=0 && Input.GetAxis("Mouse Y")<0) || (c.y*mo >=4 && Input.GetAxis("Mouse Y")>0))
       {
           m1 = -Input.GetAxis("Mouse Y") *x;
       }
       else
       {
           m1 = 0;
       }
       m2 = Input.GetAxis("Mouse X");
       Quaternion q = Quaternion.AngleAxis(m2, Vector3.up);
       q*=Quaternion.AngleAxis(m1,cc);
       transform.position = q*c*mo+Player.position;
       transform.LookAt(Player);   
       Cursor.lockState = CursorLockMode.Locked;
       
   }
}
