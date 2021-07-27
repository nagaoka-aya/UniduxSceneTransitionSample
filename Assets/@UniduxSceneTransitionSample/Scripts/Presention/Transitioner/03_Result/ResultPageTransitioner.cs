using Denity.UniduxSceneTransitionSample.Unidux;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.Transitioner
{
    public class ResultPageTransitioner
    {
        /// <summary>
        /// タイトル画面に遷移する
        /// 全く違う画面に遷移する場合はGoToXXXXPageと書く
        /// </summary>
        public void GoToTitlePage()
        {
            // TODO : これまでの情報を破棄してタイトル画面に戻る → どのアクションでディスパッチする？
            // var action = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action);
        }
    }
}