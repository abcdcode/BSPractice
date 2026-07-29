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
        Debug.Log($"HPBar Set Fill : {HpBar.fillAmount}");
    }
    public Image HpBar;
}
