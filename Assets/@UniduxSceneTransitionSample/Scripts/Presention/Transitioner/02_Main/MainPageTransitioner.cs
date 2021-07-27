﻿using Denity.UniduxSceneTransitionSample.PageData;
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
            // MainGameDataにある神のHPとDDをResultPageDataに渡しながら画面遷移を実行
            var damageDone = UniduxCore.State.Page.GetData<MainPageData>().DamageDone;
            // 情報をリザルト画面に引継ぎつつ画面遷移 → Pushでディスパッチ
            UniduxCore.Dispatch(PageDuck<PageName, SceneName>.ActionCreator.Push(PageName.Result, new ResultPageData(damageDone)));
        }

        /// <summary>
        /// タイトル画面に遷移する処理
        /// 前に遷移する場合はReturnXXXXPageと書く
        /// </summary>
        public void ReturnTitlePage()
        {
            // タイトル画面に戻る → 前のページに戻る Pop
            var action = PageDuck<PageName, SceneName>.ActionCreator.Pop();
            UniduxCore.Dispatch(action);
        }
    }
}