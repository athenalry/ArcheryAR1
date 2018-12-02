using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class arrow : MonoBehaviour {
    public Text t;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("target")) {
            t.text = " HIT";
        }
    }
}
