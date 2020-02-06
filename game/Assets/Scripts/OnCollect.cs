using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollect : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * (Time.deltaTime *speed));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            other.gameObject.GetComponent<PointsManager>().givePoint();
            Destroy(gameObject);
        }
    }
}
