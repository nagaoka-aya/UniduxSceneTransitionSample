using Denity.UniduxSceneTransitionSample.Transitioner;
using Denity.UniduxSceneTransitionSample.Unidux;
using Zenject;

namespace Denity.UniduxSceneTransitionSample.LifeCycle
{
    public class UniduxBaseLifeCycle : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Register
            Container.BindInterfacesAndSelfTo<SceneWatcher>().AsSingle();
            Container.BindInterfacesAndSelfTo<PageWatcher>().AsSingle();
            Container.BindInterfacesAndSelfTo<BaseSceneTransitioner>().AsSingle();
        }

        PageWatcher _pageWatcher;
        SceneWatcher _sceneWatcher;
        BaseSceneTransitioner _transitioner;

        void Awake()
        {
            // Resolve
            _pageWatcher = Container.Resolve<PageWatcher>();
            _sceneWatcher = Container.Resolve<SceneWatcher>();
            _transitioner = Container.Resolve<BaseSceneTransitioner>();

            // Originate
            _pageWatcher.Originate();
            _sceneWatcher.Originate();
            _transitioner.EnterTitlePage();
        }

        void OnDestroy()
        {
            // Terminate
            _pageWatcher.Terminate();
            _sceneWatcher.Terminate();
        }
    }
}