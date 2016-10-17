using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//this class will be responsible for showing the text
public class DialogDisplay : MonoBehaviour
{
    [SerializeField]
    Text _textField;

    int node_id = 0;

    Text TestText;

    void Start()
    {
        _textField = GetComponent<Text>();
        StartCoroutine(Run());
    }

    private IEnumerator Run()
    {
        while (node_id == 0)
        {
            /*switch (node_id)
            {
                case 1: TestText = "this isnt fun annymore";
                    break;
                case 2: TestText = "this still fun!";
                    break;
                case 3: TestText = "I am tired";
                    break;
                default:
                    break;
            }*/
            yield return new WaitForSeconds(0.25f); 
        }
        
    }

    public void OnClick(int nextId)
    {
        node_id = nextId;
    }
}
