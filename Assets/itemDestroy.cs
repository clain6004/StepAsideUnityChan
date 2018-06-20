using System.Collections;
using UnityEngine;

public class itemDestroy : MonoBehaviour {

     GameObject unitychan;

   public float unitypos;

    float itempos;

    private float goalPos = 120;

    // Use this for initialization
    void Start () {

        unitychan = GameObject.Find("unitychan");

        itempos = this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {

        unitypos = unitychan.transform.position.z;

        if (itempos+5 <= unitypos)
        {

            Destroy(this.gameObject);

        }

        if (itempos >= goalPos)
        {

            Destroy(this.gameObject);

        }

	}
}
