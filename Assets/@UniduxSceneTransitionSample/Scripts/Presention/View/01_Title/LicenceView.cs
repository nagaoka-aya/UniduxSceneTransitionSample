﻿using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Denity.UniduxSceneTransitionSample.View
{
    public class LicenceView : UIViewBase
    {
        [SerializeField] Button _buttonHideLicence;

        readonly Subject<Unit> _hideLicence = new Subject<Unit>();
        public IObservable<Unit> OnHideLicenceAsObservable() => _hideLicence;

        protected override void Awake()
        {
            _buttonHideLicence
                .OnClickAsObservable()
                .Subscribe(_ => _hideLicence.OnNext(Unit.Default))
                .AddTo(this);
        }
    }
}