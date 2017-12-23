using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorPicker : MonoBehaviour {

    public Button button;
    public Slider rSlide;
    public Slider gSlide;
    public Slider bSlide;
    public string cTypeName;

    ColorMenuControl cMC;
    bool initialised = false;
    Text rText;
    Text gText;
    Text bText;

    void Update() {

        #region Initialisation
        if (gameObject.activeSelf && !initialised) {
            
            //Get RGB sliders and Button
            button = gameObject.GetComponentInParent<Button>();
            rSlide = gameObject.transform.GetChild(0).GetComponent<Slider>();
            gSlide = gameObject.transform.GetChild(1).GetComponent<Slider>();
            bSlide = gameObject.transform.GetChild(2).GetComponent<Slider>();

            //Get Slider Value Text
            rText = rSlide.transform.Find("Value").GetComponent<Text>();
            gText = gSlide.transform.Find("Value").GetComponent<Text>();
            bText = bSlide.transform.Find("Value").GetComponent<Text>();

            //Initialise sliders value to default color value.
            SliderInteractactable(false);
            rSlide.value = button.colors.normalColor.r;
            gSlide.value = button.colors.normalColor.g;
            bSlide.value = button.colors.normalColor.b;
            SliderInteractactable(true);
            //Initialise Slider Text
            float rT = rSlide.value * 255;//Muiltiplies 0 to 1 float so display shows 0 to 255
            float gT = gSlide.value * 255;
            float bT = bSlide.value * 255;
            rText.text = rT.ToString("000");
            gText.text = gT.ToString("000");
            bText.text = bT.ToString("000");

            //Initialise Button Colors to normal color value 
            var colors = button.colors;
            colors.highlightedColor = colors.normalColor;
            colors.pressedColor = colors.normalColor;
            //Initialise presets button colors to the same as the normal
            Button[] buttons = GetComponentsInChildren<Button>();
            foreach (Button button in buttons)
            {
                var butColors = button.colors;

                butColors.highlightedColor = button.colors.normalColor;
                butColors.pressedColor = button.colors.normalColor;
                button.colors = butColors;
            }

            initialised = true;
        }
        #endregion
    }

    #region Internal Methods
    void Initialise() {

    }

    void ColorSliders(float r, float g, float b ) {
        cMC = GetComponentInParent<ColorMenuControl>();
        rText = rSlide.transform.Find("Value").GetComponent<Text>();
        gText = gSlide.transform.Find("Value").GetComponent<Text>();
        bText = bSlide.transform.Find("Value").GetComponent<Text>();

        var colors = button.colors;
        colors.normalColor = new Color(r, g, b, 1f);
        colors.highlightedColor = colors.normalColor;
        colors.pressedColor = colors.normalColor;

        float rT = r * 255;//Muiltiplies 0 to 1 float so display shows 0 to 255
        float gT = g * 255;
        float bT = b * 255;
        rText.text = rT.ToString("000");
        gText.text = gT.ToString("000");
        bText.text = bT.ToString("000");
        cMC.ChangeColor(cTypeName, r, g, b);
        button.colors = colors;

    }

    void SliderInteractactable(bool interactable)
    {
        if (!interactable)
        {
            rSlide.interactable = false;
            gSlide.interactable = false;
            bSlide.interactable = false;
        }
        else
        {
            rSlide.interactable = true;
            gSlide.interactable = true;
            bSlide.interactable = true;
        }
    }
    #endregion

    #region Button And Slider Methods
    public void SliderAdjust()
    {
        if (rSlide.interactable && gSlide.interactable && bSlide.interactable)
        {
            ColorSliders(rSlide.value, gSlide.value, bSlide.value);
        }
    }

    public void ColorPresets(Color color) {
        SliderInteractactable(false);
        cMC = GetComponentInParent<ColorMenuControl>();
        float r = color.r;
        float g = color.g;
        float b = color.b;

        var colors = button.colors;
        colors.normalColor = color;
        colors.highlightedColor = color;
        colors.pressedColor = color;

        cMC.ChangeColor(cTypeName, r, g, b);
        button.colors = colors;

        rSlide.value = button.colors.normalColor.r;
        gSlide.value = button.colors.normalColor.g;
        bSlide.value = button.colors.normalColor.b;

        float rT = rSlide.value * 255;//Muiltiplies 0 to 1 float so display shows 0 to 255
        float gT = gSlide.value * 255;
        float bT = bSlide.value * 255;
        rText.text = rT.ToString("000");
        gText.text = gT.ToString("000");
        bText.text = bT.ToString("000");

        SliderInteractactable(true);
    }
    #endregion
}
