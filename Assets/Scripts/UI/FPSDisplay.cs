using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayFPSText;
    private float deltaTime = 0.0f;
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        displayFPSText.text = Mathf.Ceil(fps).ToString() + " FPS";
        Debug.Log(Time.deltaTime);
    }
}
