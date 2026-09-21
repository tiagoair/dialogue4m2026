using UnityEngine;

namespace IA.Inimigo
{
    public class InimigoAtaqueBehaviour : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("Ataque!!");
        }
    }
}