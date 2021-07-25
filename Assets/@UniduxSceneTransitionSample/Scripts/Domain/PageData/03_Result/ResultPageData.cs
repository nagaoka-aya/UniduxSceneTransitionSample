﻿using System;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.PageData
{
    [Serializable]
    public class ResultPageData : IPageData
    {
        public double DamageDone { get; set; }

        public ResultPageData()
        {
            DamageDone = 0;
        }

        public ResultPageData(double defaultDamageDone)
        {
            DamageDone = defaultDamageDone > 0 ? defaultDamageDone : 0;
        }
    }
}