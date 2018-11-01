using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
    static public Hero S;

    [Header("Set in Inspector")]

    public float speed = 30;
    public float rollMult = 45;
    public float pitchMult = 30;

    [Header("Set Dynamically")]
    public float sheildLevel = 1;




    void Awake () {
		if(S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("Hero,Awake()- Attempt to assign second Hero.S!");
        }
	}
	
	void Update () {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
    }
}
