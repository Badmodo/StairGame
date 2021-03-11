using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRagdollOnClick : MonoBehaviour
{

    private Animator animator;
    private Scoring scoring;

    public Camera MainCamera;
    public Camera RagCam;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        scoring = GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R)) 
        {
            animator.enabled = !animator.enabled;
            scoring.enabled = !scoring.enabled;
            MainCamera.enabled = !MainCamera.enabled;
            RagCam.enabled = !RagCam.enabled;
        }


    }

}
