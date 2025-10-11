using UnityEngine;
using UnityEngine.UI;

public class BarreDeSante : MonoBehaviour
{
    [SerializeField] private Slider SliderDeSante;
    [SerializeField] private SystemeDeSante SystemeDeSante;
    [SerializeField] private float smoothSpeed = 5f;

    private float targetFillAmount = 1f;

    private void Start()
 {
        if (SliderDeSante == null || SystemeDeSante == null) return;
        
        SliderDeSante.minValue = 0f;
        SliderDeSante.maxValue = 1f;
        SliderDeSante.value = 1f;
        
        float initialHealth = SystemeDeSante.ObtenirSanteNormalisee();
        targetFillAmount = Mathf.Clamp01(initialHealth);
        UpdateFillColor(initialHealth);
        
        SystemeDeSante.OnchangedeSante += HandleHealthChanged;
    }

    void Update()
    {
        SliderDeSante.value = Mathf.Lerp(SliderDeSante.value, targetFillAmount, Time.deltaTime * smoothSpeed);
    }

    private void HandleHealthChanged(float normalizedHealth)
    {
        targetFillAmount = Mathf.Clamp01(normalizedHealth);
        UpdateFillColor(normalizedHealth);
    }


    private void UpdateFillColor(float healthNormalized)
    {
        if (SliderDeSante.fillRect != null)
        {
            var fillImage = SliderDeSante.fillRect.GetComponent<Image>();
            if (fillImage != null)
            {
                fillImage.color = Color.Lerp(new Color(0.7f, 0.1f, 0.1f), Color.green, healthNormalized);
            }
        }
    }
}
