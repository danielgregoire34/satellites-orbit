using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingStateManager : MonoBehaviour
{
    public OrbitState currentState;

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        OrbitState nextState= currentState?.RunCurrentState();

        if(nextState != null)
        {
            SwitchToNextState(nextState);
        }

    }
     private void SwitchToNextState(OrbitState nextState)
    {
        currentState = nextState;
    }
}
