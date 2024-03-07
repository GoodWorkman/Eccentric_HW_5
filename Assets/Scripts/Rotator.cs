using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Transform _snowman;
    [SerializeField] private Slider _rotatorSlider;
    [SerializeField] private float _rotationSpeed = 1f;

    private void Start()
    {
        _rotatorSlider.onValueChanged.AddListener(delegate {RotateSnowman();  });
    }

    private void RotateSnowman()
    {
        _snowman.transform.rotation = Quaternion.Euler(0f, _rotatorSlider.value * _rotationSpeed, 0f);
    }

    private void OnDisable()
    {
        _rotatorSlider.onValueChanged.RemoveListener(delegate {RotateSnowman();  });

    }
}
