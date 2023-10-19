using System.Collections;
using UnityEngine;

public class Singleton<T> where T : Singleton<T>, new()
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }

    public virtual void Dispose()
    {
        _instance = null;
    }
}
