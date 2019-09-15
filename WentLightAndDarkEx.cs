using UnityEngine;
using TheForest.Utils;
using System.Collections.Generic;
using System;

namespace KillInsteadOfDespawn
{
    public class WentLightAndDarkEx : sceneTracker
    {
        public override void WentLight()
        {
            ModAPI.Log.Write("Do WentLight 1");
            KillCannibals(Scene.MutantControler.ActiveCannibals);
            ModAPI.Log.Write("Do WentLight 2");
            KillCannibals(Scene.MutantControler.ActiveInstantSpawnedCannibals);
            ModAPI.Log.Write("Do WentLight 3");
            KillCannibals(Scene.MutantControler.ActiveWorldCannibals);
            ModAPI.Log.Write("Do WentLight 4");
            //KillCannibals(Scene.MutantControler.AllWorldSpawns);
            //ModAPI.Log.Write("Do WentLight 5");
            base.WentLight();
        }

        public override void WentDark()
        {
            ModAPI.Log.Write("Do WentDark");
            base.WentDark();
        }

        private void KillCannibals(List<GameObject> obj)
        {
            try
            {
                ModAPI.Log.Write("KillCannibals X.1");
                List<GameObject> list = new List<GameObject>(obj);
                ModAPI.Log.Write("KillCannibals X.2");
                if (list.Count > 0)
                {
                    ModAPI.Log.Write("KillCannibals X.3");
                    foreach (GameObject item in list)
                    {
                        if(item != null)
                            KillIt(item);
                    }
                    ModAPI.Log.Write("KillCannibals X.4");
                }
                ModAPI.Log.Write("KillCannibals X.5");
            }
            catch (Exception ex)
            {
                ModAPI.Log.Write("Error in Kill Cannibals. " + ex.Message);
            }
            ModAPI.Log.Write("KillCannibals X.6");
        }

        private void KillIt(GameObject obj)
        {
            ModAPI.Log.Write("Kill " + obj.name + " (" + obj.layer + ")");
            obj.SendMessage("killThisEnemy", SendMessageOptions.DontRequireReceiver);
        }
    }
}
