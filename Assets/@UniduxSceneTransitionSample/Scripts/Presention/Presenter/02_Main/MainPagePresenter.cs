﻿using System;
using Denity.UniduxSceneTransitionSample.Dispatcher;
using Denity.UniduxSceneTransitionSample.View;
using UniRx;
using Zenject;

namespace Denity.UniduxSceneTransitionSample.Presenter
{
    /// <summary>
    /// ゲーム画面のPresenter
    /// 純粋にViewからDomain，DomainからViewの処理の橋渡し役
    /// ここでの処理は初期化順等を伴わないものとする
    /// </summary>
    public class MainPagePresenter : IDisposable
    {
        readonly MainPageDispatcher _dispatcher;
        readonly MainPageView _view;
        readonly CompositeDisposable _disposable;

        [Inject]
        public MainPagePresenter(MainPageDispatcher dispatcher, MainPageView view)
        {
            _dispatcher = dispatcher;
            _view = view;
            _disposable = new CompositeDisposable();
        }

        public void Originate()
        {
            _view.OnAttackedAsObservable()
                .Subscribe(_ => _dispatcher.AttackGod())
                .AddTo(_disposable);

            _dispatcher.GodHpProperty
                .Subscribe(_view.DisplayGodHp)
                .AddTo(_disposable);

            _view.OnLoadResultAsObservable()
                .Subscribe(_ => _dispatcher.LoadResultPage())
                .AddTo(_disposable);

            _view.OnReturnTitleAsObservable()
                .Subscribe(_ => _dispatcher.ReturnTitlePage())
                .AddTo(_disposable);
        }

        public void Dispose()
        {
            _dispatcher?.Dispose();
            _disposable?.Dispose();
        }
    }
}