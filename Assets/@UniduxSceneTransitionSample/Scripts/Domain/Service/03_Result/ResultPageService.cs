using Denity.UniduxSceneTransitionSample.PageData;
using Denity.UniduxSceneTransitionSample.Unidux;
using UniRx;

namespace Denity.UniduxSceneTransitionSample.Service
{
    public class ResultPageService : IService
    {
        ResultPageData _pageData;

        public IReadOnlyReactiveProperty<double> DamageDoneProperty => _damageDoneRp;
        DoubleReactiveProperty _damageDoneRp;

        public void Originate()
        {
            // TODO: UniduxからページデータであるResultPageDataをどのように取得する？
            // _pageData = ...;
            _damageDoneRp = new DoubleReactiveProperty(_pageData.DamageDone);
        }

        public void Terminate()
        {
            _damageDoneRp?.Dispose();
        }
    }
}