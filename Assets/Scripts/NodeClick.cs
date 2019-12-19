using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ShowChild);
    }
    
    private void ShowChild()
    {
        transform.Find("RedDot").gameObject.SetActive(false);
        foreach (Transform child in transform.parent)
        {
            if (child.CompareTag("Node"))
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
