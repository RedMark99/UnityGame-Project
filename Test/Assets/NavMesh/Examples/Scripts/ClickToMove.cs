using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

// Use physics raycast hit from mouse click to set agent destination
[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
    RaycastHit m_HitInfo = new RaycastHit();
    public NavMeshAgent m_Agent;
    public ThirdPersonCharacter m_Character;
    public Camera cam;


    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        m_Agent.updateRotation = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
                m_Agent.destination = m_HitInfo.point;
        }

        
        if ( m_Agent.remainingDistance > m_Agent.stoppingDistance )    
            m_Character.Move(m_Agent.desiredVelocity, false ,false);
        else
            m_Character.Move(Vector3.zero, false ,false);

    }
}
