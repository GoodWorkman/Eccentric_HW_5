using UnityEngine;
using UnityEngine.UI;

public class Scaler : MonoBehaviour
{
   [SerializeField] private Transform _bottomSphere, _middleSphere, _topSphere;
   [SerializeField] private Slider _bottomSlider, _middleSlider, _topSlider;
   
   private Vector3 _initialMiddlePosition, _initialTopPosition;
   private float _initialBottomScale, _initialMiddleScale;
  
   private void Start()
   {
      _initialMiddlePosition = _middleSphere.position;
      _initialTopPosition = _topSphere.position;

      _initialBottomScale = _bottomSphere.localScale.y;
      _initialMiddleScale = _middleSphere.localScale.y;
      
      _bottomSlider.onValueChanged.AddListener(delegate {UpdateSnowmanScale();  });
      _middleSlider.onValueChanged.AddListener(delegate {UpdateSnowmanScale();  });
      _topSlider.onValueChanged.AddListener(delegate {UpdateSnowmanScale();  });
   }

   private void UpdateSnowmanScale()
   {
      _bottomSphere.localScale = Vector3.one * _bottomSlider.value;
      _middleSphere.localScale = Vector3.one * _middleSlider.value;
      _topSphere.localScale = Vector3.one * _topSlider.value;
      
      float bottomScaleDelta = (_bottomSphere.localScale.y - _initialBottomScale) / 2;
      float middleScaleDelta = (_middleSphere.localScale.y - _initialMiddleScale) / 2;

      _middleSphere.position = new Vector3(0f, _initialMiddlePosition.y + bottomScaleDelta, 0f);
      _topSphere.position = new Vector3(0f, _initialTopPosition.y + bottomScaleDelta + middleScaleDelta, 0f);
   }
   
   void OnDisable()
   {
      // Отписываемся от событий при деактивации объекта
      _bottomSlider.onValueChanged.RemoveListener(delegate { UpdateSnowmanScale(); });
      _middleSlider.onValueChanged.RemoveListener(delegate { UpdateSnowmanScale(); });
      _topSlider.onValueChanged.RemoveListener(delegate { UpdateSnowmanScale(); });
   }
}
