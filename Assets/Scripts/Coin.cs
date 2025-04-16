using UnityEngine;
using PrimeTween;

public class Coin : MonoBehaviour
{
    [SerializeField] private int price = 5;
    void PrintCurrentMoney(int currentmoney)
    {
        Debug.Log($"Current money is {currentmoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);

        Tween.PositionY(transform, transform.position.y + 0.25f, 1f, cycles: 9999, cycleMode: CycleMode.Yoyo);

    }

    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.RemoveListener(PrintCurrentMoney);    
    }

    public void Collect()
    {
        GameManager.Instance.Money = price;
        Destroy(gameObject);
    }
}