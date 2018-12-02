using UnityEngine;

public class shoot : MonoBehaviour {
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        //rb.useGravity = true;
	}
    public void restart()
    {
        rb.useGravity = false;
        rb.transform.position = new Vector3(0, 0, 0);
    }

    float x=0, y = 0;
	// Update is called once per frame
	void Update () {
        Touch t = Input.GetTouch(0);
        switch (t.phase) {
            case TouchPhase.Began:
            y = t.position.y;
            x = t.position.x;
            break;
            case TouchPhase.Ended:
                rb.useGravity = true;
                // rb.AddForce(t.position.x - x, Mathf.Abs(t.position.y - y) * 100, Mathf.Abs(t.position.y - y) * 100);
                rb.velocity = new Vector3(-Mathf.Abs(t.position.y - y), -Mathf.Abs(t.position.y - y)/10000000);
            break;
        }
	}

}
