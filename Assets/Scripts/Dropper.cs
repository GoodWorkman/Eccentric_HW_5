using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objects;

    public void SetObject(int index)
    {
        for (int i = 0; i < _objects.Count; i++)
        {
            if (i == index)
            {
                _objects[i].SetActive(true);
            }
            else
            {
                _objects[i].SetActive(false);
            }
        }
    }
}
