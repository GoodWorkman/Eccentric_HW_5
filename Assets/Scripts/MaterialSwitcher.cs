using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{
    [SerializeField] private List<Renderer> _renderers;

    public void SetMaterial(Material material)
    {
        foreach (Renderer renderer in _renderers)
        {
            renderer.material = material;
        }
    }
}
