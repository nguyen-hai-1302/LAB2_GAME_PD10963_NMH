using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject Egg;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 100)
        {
            Instantiate(Egg, transform.position,Quaternion.identity);
            count = 0;
        }
    }
}
