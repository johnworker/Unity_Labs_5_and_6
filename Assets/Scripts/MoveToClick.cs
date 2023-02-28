using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace henry
{
    public class MoveToClick : MonoBehaviour
    {
        private NavMeshAgent agent;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Camera cameraConponent = GameObject.Find("Main Camera").GetComponent<Camera>();
                Ray ray = cameraConponent.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                // Physics.Raycast ���|�g�X�@�������g�u(��V����)�A�çi�D�A�����S���g�����F��C

                if (Physics.Raycast(ray, out hit, 100))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
