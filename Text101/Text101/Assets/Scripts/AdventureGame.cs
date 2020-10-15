using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Essa tag traz uma propriedade Text para o objeto Game
    [SerializeField] Text textComponent;
    // Criando um campo do tipo State em Game
    [SerializeField] State startingState;


    // Declarando uma variável do tipo State
    State state;

    // Start is called before the first frame update
    void Start()
    {
        // Atribuindo o valor de startingState para state
        state = startingState;
        // Acessando o texto (text) do elemento UI
        SetStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            // Isso funciona pois aparentemente Alpha1 tem valor numerico de 49, e os numeros subsequentes de 50 em diante.
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        //if (Input.GetKeyDown(KeyCode.Alpha1)) // Alpha1 = Tecla 1
        //{
        //    state = nextStates[0];
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    state = nextStates[1];
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    state = nextStates[2];
        //}
        SetStoryText();
    }

    private void SetStoryText()
    {
        // Com esse Get, a string que atribumos no Unity é retornada.
        textComponent.text = state.GetStateStory();
    }
}
