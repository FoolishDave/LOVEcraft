﻿using UnityEngine;
using System.Collections;

public class RoomStart : MonoBehaviour {

    public bool northDoor = false;
    public bool southDoor = false;
    public bool eastDoor = false;
    public bool westDoor = false;

    public GameObject northRoom;
    public GameObject southRoom;
    public GameObject eastRoom;
    public GameObject westRoom;

    public bool[] doors = new bool[4];
    public ArrayList neighbors = new ArrayList();

	// Use this for initialization
	void Awake () {
        doors[0] = northDoor;
        doors[1] = eastDoor;
        doors[2] = southDoor;
        doors[3] = westDoor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
