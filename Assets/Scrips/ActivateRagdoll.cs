using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRagdoll : MonoBehaviour
{
    [SerializeField]
    public GameObject InactiveCharacter;

    [SerializeField]
    public GameObject ActiveCharacter;

    private void Start()
    {
        InactiveCharacter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            InactiveCharacter.SetActive(true);

        else if (Input.GetKeyUp(KeyCode.LeftShift))
            InactiveCharacter.SetActive(false);

        if (Input.GetKeyDown(KeyCode.LeftShift))
            ActiveCharacter.SetActive(false);

        else if (Input.GetKeyUp(KeyCode.LeftShift))
            ActiveCharacter.SetActive(true);
    }
}
