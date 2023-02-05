using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCode : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    private float sepped = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float p1y = GameObject.Find("PO_Root"+p1.GetComponent<playerMove>().rootCounter).transform.position.y;

        float p2y = GameObject.Find("PT_Root"+p2.GetComponent<playerMove>().rootCounter).transform.position.y;

        
        if(gameObject.transform.position.y < p1y-5 || gameObject.transform.position.y < p2y-5){
            //sepped = 2f;
        }else{
            gameObject.transform.position -= new Vector3(0,0.006f*sepped,0);
        }
        
        
        
    }
}
