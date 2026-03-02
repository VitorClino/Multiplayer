using UnityEngine;
using Mirror;

public class Move : NetworkBehaviour
{
    public float speed = 1;
    
    void Update()
    {
        if(!isLocalPlayer) return;


        float dt = Time.deltaTime;

        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.W)) input.z = 1f;
        if(Input.GetKey(KeyCode.S)) input.z = -1f;
        if(Input.GetKey(KeyCode.A)) input.x = 1f;
        if(Input.GetKey(KeyCode.D)) input.x = -1f;   
        input.Normalize();
        
        Mover(input, dt);
    }

    [Command]

    void Mover(Vector3 input, float dt)
    {
        transform.position += input*speed*dt;

    }
}
