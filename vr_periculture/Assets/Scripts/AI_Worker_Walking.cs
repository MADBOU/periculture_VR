using UnityEngine;
using UnityEngine.AI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(ThirdPersonCharacter))]
    //[RequireComponent(typeof(AudioSource))]

    public class AI_Worker_Walking : MonoBehaviour
    {
        public Transform[] points;
        public bool agentBraking = false;
        public bool shouldLoop = true;
        public bool isWalking = false;

        private ThirdPersonCharacter character;
        private NavMeshAgent agent;
        private int destPoint = 0;

        private void Start()
        {
            agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

            agent.updateRotation = true;
            agent.updatePosition = true;
            agent.autoBraking = agentBraking;
        }

        private void Update()
        {
            if(isWalking)
            {
                if (!agent.isOnNavMesh)
                    return;

                if (!agent.pathPending && agent.remainingDistance < 0.5f)
                    GotoNextPoint();

                if (agent.remainingDistance > agent.stoppingDistance)
                    character.Move(agent.desiredVelocity, false, false);
                else
                    character.Move(Vector3.zero, false, false);
            }

        }

        private void GotoNextPoint()
        {
            if (points.Length == 0)
                return;

            if (destPoint >= points.Length)
            {
                if (shouldLoop)
                    destPoint = 0;
                else
                    return;
            }

            agent.destination = points[destPoint].position;
            destPoint++;
        }
    }
}
