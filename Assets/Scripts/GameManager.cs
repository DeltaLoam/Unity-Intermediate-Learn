using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{

    public UnityEvent<int> OnMoneyChanged;

    private int _money;

    public int Money
    {
        get => _money;

        set
        {
            _money = value;
            OnMoneyChanged?.Invoke(_money);
        }
    }
}
