using UnityEngine;
using TheForest.Utils;
using System.Collections.Generic;
using System;

namespace KillInsteadOfDespawn
{
    public class sceneTrackerEx : sceneTracker
    {
        public override void WentLight()
        {
            ModAPI.Log.Write("Do WentLight");
            Utils.killCannibals();
            base.WentLight();
        }

        public override void WentDark()
        {
            ModAPI.Log.Write("Do WentDark");
            base.WentDark();
        }
    }
}
