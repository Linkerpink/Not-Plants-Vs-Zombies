using UnityEngine;

[CreateAssetMenu]
public class LevelSO : ScriptableObject
{
    public int lanes;
    public int laneLength;

    public enum LevelTypes
    {
        Day,
        Night,
        Pool,
        Fog,
        Roof,
    }

    public LevelTypes levelType;
}