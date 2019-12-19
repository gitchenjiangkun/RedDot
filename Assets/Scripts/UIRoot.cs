using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRoot : MonoBehaviour
{
    public Transform RedDot1;
    public Transform RedDot2;
    public Transform RedDot3;
    public static UITree Tree;

    private void Start()
    {
        Tree = new UITree(transform);
        Tree.SetRedDot(RedDot1);
        Tree.SetRedDot(RedDot2);
        Tree.SetRedDot(RedDot3);
        
    }
}

public class UITree
{
    public Transform Root;

    public UITree(Transform root)
    {
        Root = root;
    }
    
    public void SetRedDot(Transform node)
    {
        if (node.parent == null) return;
        Transform redDot = node.Find("Button/RedDot");
        if (redDot) redDot.gameObject.SetActive(true);
        SetRedDot(node.parent);
    }
}

