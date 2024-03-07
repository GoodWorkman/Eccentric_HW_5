using TMPro;
using UnityEngine;

public class ValueShower : MonoBehaviour
{
   private TextMeshProUGUI _valueText;

   private void Start()
   {
      _valueText = GetComponent<TextMeshProUGUI>();
   }

   public void SetValue(float value)
   {
      _valueText.text = value.ToString("0.0");
   }
}
