using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCtrl : MonoBehaviour
{
    public GameObject sparkEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BULLET")
        {
            GameObject spark = Instantiate(sparkEffect, collision.transform.position, Quaternion.identity);
            Destroy(spark, spark.GetComponent<ParticleSystem>().main.duration + 2.2f);
            Destroy(collision.gameObject);
        }
    }
}
