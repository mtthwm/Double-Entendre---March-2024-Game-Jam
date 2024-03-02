using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueInteraction : BaseInteraction
{
    [SerializeField] private string dialogueNode;

    private DialogueRunner _yarn;

    private void Start () 
    {
        _yarn = FindObjectOfType<DialogueRunner>();
    }

    protected override void Action()
    {
        _yarn.StartDialogue(dialogueNode);
    }
}
