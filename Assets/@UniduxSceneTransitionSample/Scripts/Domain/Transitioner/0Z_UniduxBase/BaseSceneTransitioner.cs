using Denity.UniduxSceneTransitionSample.Unidux;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.Transitioner
{
    public class BaseSceneTransitioner
    {
        /// <summary>
        /// タイトル画面に遷移する
        /// 次の画面に遷移する時はEnterXXXXPageと書く
        /// </summary>
        public void EnterTitlePage()
        {
            // TODO: 一旦ステートのクリーン → どのアクションでディスパッチする？
            // var action1 = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action1);
            // TODO: 最初のタイトル画面を起動 → どのアクションでディスパッチする？
            // var action2 = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action2);
        }
    }
}