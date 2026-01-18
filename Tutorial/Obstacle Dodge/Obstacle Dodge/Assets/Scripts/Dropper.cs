using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    MeshRenderer dropTrapMeshRenderer;
    Rigidbody dropTrapRigidBody;
    void Start()
    {
        dropTrapMeshRenderer = GetComponent<MeshRenderer>();
        dropTrapRigidBody = GetComponent<Rigidbody>();

        dropTrapMeshRenderer.enabled = false;
        dropTrapRigidBody.useGravity = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            dropTrapMeshRenderer.enabled = true;
            dropTrapRigidBody.useGravity = true; 
        }
    }
}
