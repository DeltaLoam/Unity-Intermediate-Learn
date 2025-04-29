using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = "Profile/Card")]
public class SO_Card : ScriptableObject
{
    [Header("Card Details")]
    public string Name;
    public string Description;
    public Type ElementalType;

    [Space, ShowAssetPreview]

    public Sprite CardImage;

    [Header("Character Stats")]
    public int Cost;
    public int Health;
    public int ATK;

    public Sprite characterImage;

}

public enum Type
{
    Electro,
    Pyro,
    Hydro,
    Cryo,
    Geo,
    Anemo,
    Dendro,
}