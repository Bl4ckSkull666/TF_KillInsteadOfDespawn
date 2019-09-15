using ModAPI.Attributes;
using UnityEngine;

namespace KillInsteadOfDespawn
{
    public class KillInsteadOfDespawn : MonoBehaviour
    {
        [ExecuteOnGameStart]
        private static void Load()
        {
            ModAPI.Log.Write("Loading Kill instead of DeSpawn");
            /* GameObject obj = new GameObject("__KillInsteadOfDespawn__");
            obj.AddComponent<WentLightAndDarkEx>(); */
        }

        private void Start()
        {
            ModAPI.Log.Write("Starting Kill instead of DeSpawn");
        }
    }
}
