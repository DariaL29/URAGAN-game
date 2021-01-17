using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public AudioSource collectSource;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(50 * Time.deltaTime, 0, 0);
        



    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           
            playerControl.numberSun += 1;
            Debug.Log("Score:" + playerControl.numberSun);
            Destroy(gameObject);
            collectSource.Play();

        }
    }
}
