using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
    Vector3 old;
    // Use this for initialization
    float f;
	void Start () {
        old = this.transform.position;
        f = Random.RandomRange(0, 10);
    }
    float d = 0;
	// Update is called once per frame
	void Update () {
        if (Random.RandomRange(0, 100) > 98)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
        else
        {
            d += Time.deltaTime;
            if (d>f)
            {
                if (this.transform.position != old)
                {
                    this.transform.position = old;
                }
                d = 0;
            }
            
        }
    }
}
