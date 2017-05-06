// GNU General Public License v3.0 Shahryar Saqib 
// Youtube: The Mannered Coder https://www.youtube.com/channel/UCGrnFZJWOB769Pirppb8Xog

using UnityEngine;

/// <summary>
/// NON-Persistant Version of the Singleton Class.V1.0
/// <para>by Shahryar Saqib</para>
/// </summary>
/// <typeparam name="T">Pass the name of this class so a proper typed static instance is created</typeparam>
public class UnitySingleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    var obj = new GameObject();
                    obj.hideFlags = HideFlags.HideAndDontSave;
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }
}