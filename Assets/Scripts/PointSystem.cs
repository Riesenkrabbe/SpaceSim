using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public int combo = 0;
    private float combotimer;
    // Start is called before the first frame update
    void Start()
    {

        //Physics.IgnoreCollision(GameObject.Find("Player").GetComponent<Collider>(), GetComponent<Collider>());
        Debug.Log("PointSystem Startup");
    }
    void FixedUpdate()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        combo = 0;
        combotimer = 0.0f;
    }
    private void OnTriggerStay(Collider other)
    {
        combo++;
        combotimer = 0.0f;
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        combotimer += Time.deltaTime;
        if (combotimer >= 5.0f)
        {
            points += combo;
            combo = 0;
        }
    }
}
