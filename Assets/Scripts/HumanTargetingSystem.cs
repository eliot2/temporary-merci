﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HumanTargetingSystem : MonoBehaviour {

    private bool H_isfighting;
    public List<Transform> AlienRegiment { get; set; }

    // Use this for initialization
    void Start()
    {
        //Get the list/vector of aliens. Let's call it alienindex
        H_isfighting = false;
        AlienRegiment = getAlienRegiment();
    }

    // Update is called once per frame
    void Update()
    {
        if (H_isfighting == false)
        {
            chooseRandomTarget();
            H_isfighting = true;
        }
        //This should occur when your target is dead.
        else if (H_isfighting && true /* Fill in for AlienRegiment[Alientarget].gameObject.GetComponent<???>().Getaliveness();*/)
        {
            //H_isfighting = false;
            Debug.Log("Resetting Alien Target.");
        }

    }

    //This function will find a random target from the size, set his targeted up 1
    //and say that this is targeting something.
    void chooseRandomTarget()
    {
       Debug.Log("Total Aliens: " + AlienRegiment.Count);
       int Alientarget = Random.Range(0, AlienRegiment.Count);
       Debug.Log("Target Human: " + Alientarget);

       AlienRegiment[Alientarget].gameObject.GetComponent<AlienTargeted>().Increasetargeted();
       H_isfighting = true;
       Debug.Log("Found an Alien Target.");
    }

    List<Transform> getAlienRegiment(){
        return GameObject.Find("List_creator").GetComponent<ListingHumes_Aliens>().AlienRegiment;
    }
}