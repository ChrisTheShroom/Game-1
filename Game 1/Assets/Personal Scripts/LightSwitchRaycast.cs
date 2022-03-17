using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchRaycast : MonoBehaviour
{
   [SerializeField] private int rayLength = 5;
   private LightSwitchController interactiveObj;

   [SerializeField] private Image crosshair;

   private void Update()
   {
       Vector3 fwd = transform.TransformDirection(Vector3.forward);

       if(Physics.Raycast(transform.position, fwd, out RaycastHit hit, rayLength))
       {
            var raycastObj = hit.collider.gameObject.GetComponent<LightSwitchController>();
           if (raycastObj != null)
           {
               interactiveObj = raycastObj;
               crosshairChange(true);
           }
           else
           {
               ClearInteraction();
           }
       }
       else{
           ClearInteraction();
       }

       if (interactiveObj != null)
       {
           
           if(Input.GetKeyDown(KeyCode.F))
           {
               interactiveObj.InteractSwitch();
           }
       }
   }

   private void ClearInteraction()
   {
       if (interactiveObj != null)
       {
           crosshairChange(false);
           interactiveObj = null;
       }
   }

   private void crosshairChange(bool on)
   {
       if(on)
       {
           crosshair.color = Color.red;
       }
       else
       {
           crosshair.color = Color.white;
       }
   } 
}
