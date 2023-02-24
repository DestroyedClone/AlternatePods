using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Engi
{
    public class EngiHumanPod : PodModPodBase
    {
        public override string PodName => "Humanity";

        public override string PodToken => "PODMOD_ENGI_HUMANITY";

        public override Texture2D Icon => throw new NotImplementedException();
    }
}
