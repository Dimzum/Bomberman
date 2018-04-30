﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour {

    public Tilemap tilemap;

    public GameObject bombPrefab;
	
	// Update is called once per frame
	void Update () {
        /*-- Change to keys later when a player is implemented --*/
		if (Input.GetMouseButtonDown(0)) {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = tilemap.WorldToCell(worldPos); // Vector3Int is faster - cells are whole numbers
            Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        }
	}
}
