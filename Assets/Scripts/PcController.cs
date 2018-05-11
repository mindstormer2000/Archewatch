using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
[RequireComponent(typeof(NavMeshAgent))]
public class PcController : MonoBehaviour {
    public NavMeshAgent agent;

	void Start()
	{
		
	}
	void Update()
	{
        if (Input.GetKey("Forward")) {
            agent.destination = this.gameObject.transform.forward*3;

        }
	}
}
