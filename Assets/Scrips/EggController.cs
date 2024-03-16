using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    public GameObject Egg;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("ground")) 
        {
            //ScoreController.scoreValue -= 1;
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("Egg"))
        {
            
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("Farmer"))
        {
            
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }

        if (col.gameObject.name.Equals("Box"))
        {             
            Destroy(gameObject, 0.1f);
            Destroy(this);            
        }
    }
}
