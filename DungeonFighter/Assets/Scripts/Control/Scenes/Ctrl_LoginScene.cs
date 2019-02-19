/*************************************
*   Author  ： Duan Bin
*   Time    ： 20180813
*   Function： 
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Global;
using kernel;

namespace Control
{
    public class Ctrl_LoginScene : BaseCtrl {

        public static Ctrl_LoginScene Instance;
        public AudioClip aucBackgroundMusic;    //登录场景背景音乐
		
		// Use this for initialization
		void Awake () {
            Instance = this;
		}

        private void Start()
        {
            //确定音频的音量
            AudioManager.SetAudioBackgroundVolumns(0.5f);
            AudioManager.SetAudioEffectVolumns(0.5f);

            //播放背景音乐
            AudioManager.PlayBackground(aucBackgroundMusic);
        }

        public void PlayAudioEffectBySword()
        {
            AudioManager.PlayAudioEffectA("Hero_MagicA");
        }

        public void PlayAudioEffectByMagic()
        {
            AudioManager.PlayAudioEffectA("2_FireBallEffect_MagicHero");
        }

        /// <summary>
        /// 转到下一场景
        /// </summary>
        public void EnterNextScenes()
        {
            //// 转入下一场景
            //GlobalParamsMgr.NextSceneName = SceneEnum.LevelOne;
            //SceneManager.LoadScene(ConverterEnumToStr.getInstance().getStrSceneByEnumScene(GlobalParamsMgr.NextSceneName));// 加载新的场景     
            base.EnterNextScenes(SceneEnum.LevelOne);
        }	
	}
}

