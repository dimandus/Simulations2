﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameLogic : MonoBehaviour {

	public GameObject mainUI;
	public GameObject villagerExample;

	public static List<GameObject> villagers;
	public static List<GameObject> buildings;
	public static List<string> villagerNeeds;
	
	void Awake (){
		villagerNeeds = new List<string> ();
		villagerNeeds.Add ("Food");
		villagerNeeds.Add ("Water");
		
		villagers = new List<GameObject> ();
		
		foreach (GameObject villager in GameObject.FindGameObjectsWithTag("Villager")) {
			villagers.Add(villager);
		}
		
		buildings = new List<GameObject> ();
		
		foreach (GameObject building in GameObject.FindGameObjectsWithTag("Building")) {
			buildings.Add(building);
		}

	}

	public static void Kill(GameObject villager)
	{
		Debug.Log (string.Format("{0} умер в возрасте {1}",villager.GetComponent<CharacterMemory>().Name,villager.GetComponent<CharacterMemory>().Age));
		villagers.Remove (villager);
		Transform.Destroy (villager);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
}
