using UnityEngine;

public static class GameUtils
{
    public static string DescribeItem<T>(T something)
    {
        return $"This item is a {something}.";
    }
}