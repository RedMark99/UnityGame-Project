using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour {
	public bool EndDialog;
	public GameObject Dialog1;
	public GameObject Dialog2;
	public bool check;
	public Quest_Event QE;
	public bool fin_Dialog;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		
		if (EndDialog == true) {
			Time.timeScale = 1;
			QE.Quest1 = true;
			Dialog1.SetActive (false);
			Debug.Log("EndDialog");
		}

		if(fin_Dialog == true)
		{
			Time.timeScale = 1;
			QE.Quest1 = false;
			check = true;
			Dialog2.SetActive(false);
			Debug.Log("fin_dialog");
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			Time.timeScale = 0;
			if(QE.end_Quest1 == false)
			{
				Dialog1.SetActive (true);
				Debug.Log("Trigger EndDialog");
			}
			else if (QE.end_Quest1 == true)
			{
				Dialog2.SetActive (true);
				Debug.Log("Trigger fin_dialog");
			}
		}
	}
}