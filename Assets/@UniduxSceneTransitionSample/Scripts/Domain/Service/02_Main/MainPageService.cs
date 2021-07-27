using Denity.UniduxSceneTransitionSample.PageData;
using Denity.UniduxSceneTransitionSample.Unidux;
using Unidux.SceneTransition;
using UniRx;

namespace Denity.UniduxSceneTransitionSample.Service
{
    public class MainPageService : IService
    {
        MainPageData _mainPageData;

        public IReadOnlyReactiveProperty<double> GodHpProperty => _godHpRp;
        DoubleReactiveProperty _godHpRp;

        double _godHp;
        double _damageDone;

        public void Originate()
        {
            // TODO: UniduxからページデータであるMainPageDataをどのように取得する？
            // _godHp = ...;
            // _damageDone = ...;
            _mainPageData = new MainPageData(_godHp, _damageDone);
            _godHpRp = new DoubleReactiveProperty(_godHp);
        }

        public void Terminate()
        {
            _godHpRp?.Dispose();
        }

        /// <summary>
        /// 神に攻撃する処理
        /// </summary>
        public void AttackGod()
        {
            // ビジネスロジック
            _godHp -= 10;
            _damageDone += 10;

            // View側に反映
            _godHpRp.Value = _godHp;

            // MainGameDataの更新処理
            _mainPageData.GodHp = _godHp;
            _mainPageData.DamageDone = _damageDone;

            // TODO : データの更新 → どうディスパッチする？
            // var action = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action);
        }
    }
}