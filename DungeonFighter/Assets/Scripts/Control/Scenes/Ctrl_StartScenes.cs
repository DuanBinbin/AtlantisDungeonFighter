/*************************************
*   Author  ： Duan Bin
*   Time    ： 20180717
*   Function： 
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Global;
using kernel;

namespace Control{
    public class Ctrl_StartScenes : BaseCtrl {

        public static Ctrl_StartScenes instance;
        public AudioClip startScenePlaygroundAudio;

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            // 设置音频音量
            AudioManager.SetAudioBackgroundVolumns(0.5f);
            AudioManager.SetAudioEffectVolumns(1f);
            // 播放背景音乐
            //AudioManager.PlayBackground("StartScenes");// 方式1
            AudioManager.PlayBackground(startScenePlaygroundAudio);// 方式2
        }

        /// <summary>
        /// 开始新的传奇
        /// </summary>
        internal void ClickNewGame()
        {
            print(GetType() + "/ClickNewGame");
            StartCoroutine("EnterLoadingScene");
        }

        /// <summary>
        /// 继续游戏
        /// </summary>
        internal void ClickGameContinue()
        {
            print(GetType() + "/ClickGameContinue");
        }

        IEnumerator EnterLoadingScene()
        {
            FadeInAndOut.instance.setScenesFadeOut();//设置场景淡入
            yield return new WaitForSeconds(1.5f);

            // 转入下一场景
            //GlobalParamsMgr.NextSceneName = SceneEnum.LoadingScene;
            //SceneManager.LoadScene(ConverterEnumToStr.getInstance().getStrSceneByEnumScene(GlobalParamsMgr.NextSceneName));// 加载新的场景          
            base.EnterNextScenes(SceneEnum.LoadingScene);
        }
	}
}

