﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkConnector : MonoBehaviour {

    private GameObject GameManager;
    public GameObject ship;
    private GameObject shiptracker;

    void Start () {
        GameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    public void Spawn(Vector3 pos)
    {
        shiptracker = Instantiate(ship, pos, Quaternion.identity);
        shiptracker.GetComponent<MeshRenderer>().enabled = false;
        GameManager.GetComponent<ManagerControlls>().enemyfield.Add(shiptracker.transform.position);
    }
}
