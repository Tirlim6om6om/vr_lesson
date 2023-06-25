using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Coloring
{
    public Types type;
    public Color color;
}


public class ListTesting : MonoBehaviour
{
    public List<Element> elements = new List<Element>();
    public List<Coloring> colors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Element>(out Element element))
        {
            if (FindElement(element, elements) == false)
            {
                elements.Add(element);//Добавить элемент
                SwitchColor(element);
            }
        }
    }

    private bool FindElement(Element element, List<Element> listElements)
    {
        //for
        for (int i = 0; i < listElements.Count; i++)
        {
            if (listElements[i] == element)
            {
                return true;
            }
        }
        return false;
        //foreach
        foreach (var e in listElements)
        {
            if (e == element)//listElements[i] == element
            {
                return true;
            }
        }
        return false;
    }

    private void SwitchColor(Element element)
    {
        Coloring needColor = null;
        foreach (var color in colors)
        {
            if (color.type == element.type)
            {
                needColor = color;
                print("Find");
                break;
            }
        }
        if(needColor == null) return;
        print(needColor.color.ToString());
        element.mesh.material.SetColor("_Color", needColor.color);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Element>(out Element element))
        {
            elements.Remove(element);//Удалить элемент
        }
    }
}
