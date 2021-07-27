﻿using Denity.UniduxSceneTransitionSample.Answer.Unidux;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.Answer.Dispatcher
{
    public class ResultPageDispatcher
    {
        /// <summary>
        /// タイトル画面に遷移する
        /// </summary>
        public void ReturnTitlePage()
        {
            // これまでの情報を破棄してタイトル画面に戻る → Replaceでディスパッチ
            UniduxCore.Dispatch(PageDuck<PageName, SceneName>.ActionCreator.Replace(PageName.Title));
        }
    }
}