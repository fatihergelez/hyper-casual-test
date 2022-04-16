using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinishManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag.Equals("Player") && !GameManager.isGameEnded)
        {
            GameManager.instance.EndGame();
        }
    }
}
