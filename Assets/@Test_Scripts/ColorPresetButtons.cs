using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorPresetButtons : MonoBehaviour {

    public ColorPicker cp;
    Button button;

    public void GetColor() {
        button = GetComponent<Button>();
        cp = GetComponentInParent<ColorPicker>();

        var colors = button.colors;
        Color color;

        colors.highlightedColor = button.colors.normalColor;
        colors.pressedColor = button.colors.normalColor;
        button.colors = colors;
        color = colors.normalColor;
        cp.ColorPresets(color);

    }
}
