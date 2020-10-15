using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Permitindo que esse script possa ser instanciado como um asset em Unity
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // 10 linhas na text area, 14 linhas ate precisar scrollar pra ver mais
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
