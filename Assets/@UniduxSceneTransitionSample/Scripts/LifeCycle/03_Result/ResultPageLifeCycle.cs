using Denity.UniduxSceneTransitionSample.Presenter;
using Denity.UniduxSceneTransitionSample.ResultService;
using Denity.UniduxSceneTransitionSample.View;
using UnityEngine;
using Zenject;

namespace Denity.UniduxSceneTransitionSample.LifeCycle
{
    /// <summary>
    /// リザルト画面用のライフサイクルクラス
    /// <remarks>
    /// AwakeでRegisterしたTransitioner・Viewを除くクラスの初期化処理を行い，
    /// OnDestroyでRegisterしたTransitioner・Viewを除くクラスの終端処理を行う
    /// </remarks>
    /// </summary>
    public class ResultPageLifeCycle : MonoInstaller
    {
        [SerializeField] ResultPageView _view;

        public override void InstallBindings()
        {
            // Register
            Container.BindInterfacesAndSelfTo<ResultPageService>().AsSingle();
            Container.BindInstance(_view);
            Container.Bind<UIViewBase>().FromInstance(_view);
            Container.BindInterfacesAndSelfTo<ResultPagePresenter>().AsSingle();
        }

        ResultPageService _service;
        ResultPagePresenter _presenter;

        void Awake()
        {
            // Resolve
            _service = Container.Resolve<ResultPageService>();
            _presenter = Container.Resolve<ResultPagePresenter>();

            // Originate
            _service.Originate();
            _presenter.Originate();
        }

        void OnDestroy()
        {
            // Terminate
            _service.Terminate();
            _presenter.Terminate();
        }
    }
}