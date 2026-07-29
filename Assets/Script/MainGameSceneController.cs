using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGameSceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ps = GameManager.Instance.CurState.PStat;
        HpBar.fillAmount = ps.Hp / ps.MaxHp;
        SurvivalTimer.text = $"Survival Time : {Mathf.Round(GameManager.Instance.CurState.GameTime*10)/10}";
    }
    public Image HpBar;
    public TextMeshProUGUI SurvivalTimer;
}
