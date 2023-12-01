using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISensor : MonoBehaviour
{

    //Private 
    private AIStateMachine _parentStateMachine = null;
    public AIStateMachine parentStateMachine { set { _parentStateMachine = value; } }

    void OnTriggerEnter(Collider col)
    {
        if (_parentStateMachine != null)
            _parentStateMachine.onTriggerEvent(AITriggerEventType.Enter, col);
    }

    void OnTriggerStay(Collider col)
    {
        if(_parentStateMachine != null)
            _parentStateMachine.onTriggerEvent(AITriggerEventType.Stay, col);
    }

    void OnTriggerExit(Collider col)
    {
        if(_parentStateMachine != null)
            _parentStateMachine.onTriggerEvent(AITriggerEventType.Exit, col);
    }

}
