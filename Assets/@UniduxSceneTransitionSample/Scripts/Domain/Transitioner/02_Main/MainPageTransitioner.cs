using Denity.UniduxSceneTransitionSample.PageData;
using Denity.UniduxSceneTransitionSample.Unidux;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.Transitioner
{
    public class MainPageTransitioner
    {
        /// <summary>
        /// リザルト画面に遷移する処理
        /// 次に遷移する場合はEnterXXXXPageと書く
        /// </summary>
        public void EnterResultPage()
        {
            // MainGameDataにある神のHPとDDをResultPageDataに渡しながら画面遷移を実行する
            // TODO: 今のMainPageDataをどのように取得するか？
            // var damageDone = ...;
            // TODO: 情報をリザルト画面に引継ぎつつ画面遷移 → どうディスパッチする？
            // var action = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action);
        }

        /// <summary>
        /// タイトル画面に遷移する処理
        /// 前に遷移する場合はReturnXXXXPageと書く
        /// </summary>
        public void ReturnTitlePage()
        {
            // TODO: タイトル画面に戻る → 前のページに戻る → どうディスパッチする？
            // var action = PageDuck<PageName, SceneName>.ActionCreator.;
            // UniduxCore.Dispatch(action);
        }
    }
}