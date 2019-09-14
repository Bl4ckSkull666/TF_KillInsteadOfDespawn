using ModAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace KillInsteadOfDespawn
{
    public class KillInsteadOfDespawn
    {
        [ExecuteOnGameStart]
        private static void Load()
        {
            ModAPI.Log.Write("Loading Kill instead of DeSpawn");
            GameObject obj = new GameObject("__KillInsteadOfDespawn__");
            obj.AddComponent<sceneTrackerEx>();
            
        }

        private void Start()
        {
            ModAPI.Log.Write("Starting Kill instead of DeSpawn");
        }
    }
}
