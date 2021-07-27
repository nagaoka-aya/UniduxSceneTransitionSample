using System.Collections.Generic;
using Unidux.SceneTransition;

namespace Denity.UniduxSceneTransitionSample.Unidux
{
    /// <summary>
    /// シーン設定を行うクラス
    /// </summary>
    public class SceneConfig : ISceneConfig<SceneName, PageName>
    {
        /// <summary>
        /// カテゴリーマップの設定
        /// <remarks>ここにUnitySceneとカテゴリーの紐づけを行う</remarks>
        /// </summary>
        public IDictionary<SceneName, int> CategoryMap { get; } =
            new Dictionary<SceneName, int>
        {
            // TODO: カテゴリーマップの設定
        };

        /// <summary>
        /// ページマップの設定
        /// <remarks>ページと複数のUnitySceneの紐づけを行う</remarks>
        /// </summary>
        public IDictionary<PageName, SceneName[]> PageMap { get; } =
            new Dictionary<PageName, SceneName[]>
        {
            // TODO: ページマップの設定
        };
    }
}