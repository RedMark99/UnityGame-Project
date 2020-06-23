﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick : MonoBehaviour {
	public GameObject Text1;
	public GameObject Text2;
	private bool isText1 =true;
	public NPC_Task npc_taskScript;
	public bool fin_Dialog;
	public GameObject QbjectQuest;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (isText1 == true) {
				isText1 = false;
			}
			else{
			if(fin_Dialog == false)
			{
				isText1 = true;
				npc_taskScript.EndDialog = true;
				QbjectQuest.SetActive(true);
			}
			else
			{
				isText1 = true;
				npc_taskScript.fin_Dialog = true;
			}
			}
		}
		if (isText1 == true) {
			Text1.SetActive (true);
			Text2.SetActive (false);
		} else {
			Text1.SetActive (false);
			Text2.SetActive (true);
		}
	}
}