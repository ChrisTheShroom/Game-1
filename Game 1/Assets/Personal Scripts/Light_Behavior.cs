using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Behavior : MonoBehaviour
{
    public GameObject Ceiling_light;
    public GameObject Lamp_light;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            if(Ceiling_light.activeSelf){
                    Ceiling_light.SetActive(false);
                } else {
                    Ceiling_light.SetActive(true);
                }
            
            }

            if (Input.GetKeyDown(KeyCode.R)){
            if(Lamp_light.activeSelf){
                    Lamp_light.SetActive(false);
                } else {
                    Lamp_light.SetActive(true);
                }
            
            }
            
        }
}
