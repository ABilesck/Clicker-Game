using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int Level = 1;

    public int Str = 1;
    public int Int = 1;
    public int Dex = 1;

    public float Exp = 0;
    private float NextLevelExp = 5;

    public Slider ExpSlider;
    public Text GoldText;

    public int Gold = 0;

    private void Awake()
    {
        ExpSlider.maxValue = NextLevelExp;
    }

    private void Update()
    {
        if(Exp >= NextLevelExp)
        {
            Level++;
            NextLevelExp *= 1.9f;
            ExpSlider.maxValue = NextLevelExp;
            Exp = 0;
        }

        ExpSlider.value = Exp;
        GoldText.text = Gold.ToString();
    }
}
