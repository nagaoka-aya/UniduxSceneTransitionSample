﻿using System;
using Denity.UniduxSceneTransitionSample.Answer.Dispatcher;
using Denity.UniduxSceneTransitionSample.Answer.View;
using UniRx;

namespace Denity.UniduxSceneTransitionSample.Answer.Presenter
{
    /// <summary>
    /// リザルト画面のPresenter
    /// 純粋にViewからDomain，DomainからViewの処理の橋渡し役
    /// ここでの処理は初期化順等を伴わないものとする
    /// </summary>
    public class ResultPagePresenter : IPresenter
    {
        readonly ResultPageDispatcher _dispatcher;
        readonly ResultPageView _view;
        readonly CompositeDisposable _disposable;

        public ResultPagePresenter(ResultPageDispatcher dispatcher, ResultPageView view)
        {
            _dispatcher = dispatcher;
            _view = view;
            _disposable = new CompositeDisposable();
        }

        public void Originate()
        {
            _dispatcher.DamageDoneProperty
                .Subscribe(_view.DisplayResult)
                .AddTo(_disposable);

            _view.OnReturnTitleTriggerAsObservable()
                .Subscribe(_ => _dispatcher.ReturnTitle())
                .AddTo(_disposable);
        }

        public void Terminate()
        {
            _dispatcher?.Terminate();
            _disposable?.Dispose();
        }
    }
}