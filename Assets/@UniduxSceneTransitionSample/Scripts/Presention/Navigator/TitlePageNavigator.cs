using Denity.UniduxSceneTransitionSample.Progression;
using Denity.UniduxSceneTransitionSample.View;
using UniRx;
using Zenject;

namespace Denity.UniduxSceneTransitionSample.Navigator
{
    public class TitlePageNavigator : IPeriod
    {
        readonly TitleView _titleView;
        readonly LicenceView _licenceView;
        readonly CompositeDisposable _disposable;

        [Inject]
        public TitlePageNavigator(TitleView titleView, LicenceView licenceView)
        {
            _titleView = titleView;
            _licenceView = licenceView;
            _disposable = new CompositeDisposable();
        }

        public void Originate()
        {
            _licenceView.Hide();

            _titleView.OnShowLicenceAsObservable()
                // TODO: ライセンス表記を表示する
                .Subscribe()
                .AddTo(_disposable);

            _licenceView.OnHideLicenceAsObservable()
                // TODO: ライセンス表記を隠す
                .Subscribe()
                .AddTo(_disposable);
        }

        public void Terminate()
        {
            _disposable?.Dispose();
        }
    }
}