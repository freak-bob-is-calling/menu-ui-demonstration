using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsAndMovement : MonoBehaviour
{
    public Rigidbody rb;

    [Header("Force Values")]
    public float ff = 2000;
    public float rf = 1000;
    public float lf = -1000;
    public float jf = 100;

    [Header("Sliders")]
    public Slider forwardSlider;
    public Slider rightSlider;
    public Slider leftSlider;

    [Header("Text Displays")]
    public TextMeshProUGUI forwardText;
    public TextMeshProUGUI rightText;
    public TextMeshProUGUI leftText;

    void Start()
    {
        
        ff = PlayerPrefs.GetFloat("ForwardForce", 2000f);
        rf = PlayerPrefs.GetFloat("RightForce", 1000f);
        lf = PlayerPrefs.GetFloat("LeftForce", -1000f);

        
        if (forwardSlider != null) forwardSlider.value = ff;
        if (rightSlider != null) rightSlider.value = rf;
        if (leftSlider != null) leftSlider.value = lf;
    }

    void Update()
    {
        if (forwardSlider != null)
        {
            ff = forwardSlider.value;
            PlayerPrefs.SetFloat("ForwardForce", ff);
            if (forwardText != null) forwardText.text = "Forward Force: " + ff.ToString("F0");
        }

        if (rightSlider != null)
        {
            rf = rightSlider.value;
            PlayerPrefs.SetFloat("RightForce", rf);
            if (rightText != null) rightText.text = "Right Force: " + rf.ToString("F0");
        }

        if (leftSlider != null)
        {
            lf = leftSlider.value;
            PlayerPrefs.SetFloat("LeftForce", lf);
            if (leftText != null) leftText.text = "Left Force: " + lf.ToString("F0");
        }
    }

    void FixedUpdate()
    {
        
        if (rb == null) return;

        rb.AddForce(0, 0, ff * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(rf * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(lf * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0f, jf * Time.deltaTime, 0f), ForceMode.Impulse);
        }
    }

}