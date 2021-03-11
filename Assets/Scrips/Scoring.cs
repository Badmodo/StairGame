using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    List<Joint> joints;

    [SerializeField]
    private float minForceForScore;

    private float currentScore = 0;

    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private float scoreMultiplier = 0;


    // Start is called before the first frame update
    void Start()
    {
        joints = new List<Joint> (GetComponentsInChildren<Joint>());
    }

    // Update is called once per frame
    void Update()
    {
        float forceBeingApplied = 0;

        foreach(Joint joint in joints)
        {
            forceBeingApplied += joint.currentForce.magnitude;
        }

        if(forceBeingApplied > minForceForScore)
        {
            currentScore += (forceBeingApplied * scoreMultiplier * Time.deltaTime);
            scoreText.text = ("Score:") + Mathf.RoundToInt(currentScore).ToString(); 
        }

        Debug.Log(forceBeingApplied);
    }
}
