using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRagdoll : MonoBehaviour
{
    public GameObject RagdollPrefab;
    [SerializeField]
    public GameObject InactiveCharacter;

    private GameObject toDistroy;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            InactiveCharacter.SetActive(false);

            toDistroy = Instantiate(RagdollPrefab, transform.position, transform.rotation);

            StartCoroutine(WaitToSpawn());


        }
        
    }
    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Dragon");


        InactiveCharacter.SetActive(true);
    }
}
