using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class CharacterPhysics : MonoBehaviour
{

    /// Tiny player agent

    [SerializeField] private NavMeshAgent agent;
   

    //Tiny player going destination

    private Vector3 Destination;
    public Vector3 _Destination { get { return Destination; } set { Destination = value; } }

    private void OnEnable()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        if(agent.isOnNavMesh)//Moving character little bit random point
            agent.Move(this.transform.forward +( (Vector3.forward + Vector3.right)* Random.Range(-.1f,.1f)));
    }


    private void Update()
    {
        //If the character move too much far come back to main point
        if (Vector3.Distance(this.transform.position, this.transform.parent.position) > 4 &&  agent.isOnNavMesh)
        {
            agent.isStopped = false;
            agent.SetDestination(this.transform.parent.position);
        }
        //Else not move
        else if(Vector3.Distance(this.transform.position, this.transform.parent.position) <= 4 &&  agent.isOnNavMesh)
        {
            agent.isStopped = true; 
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("GreenArea"))
        {
            Destroy(other.gameObject);
        }
    }

}