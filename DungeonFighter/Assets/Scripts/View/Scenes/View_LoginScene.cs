/*************************************
*   Author  ： Duan Bin
*   Time    ： 20180813
*   Function： 视图层 - 登录场景
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Global;
using kernel;
using Control;


namespace View{
    public class View_LoginScene : MonoBehaviour {

        public GameObject MObjSwordHero;
        public GameObject MObjMagicHero;
        public GameObject MObjUISwordHeroInfo;
        public GameObject MObjUIMagicHeroInfo;

        public InputField inpUserName;
		
		// Use this for initialization
		void Start () {
            // 获取玩家类型(系统默认）
            GlobalParamsMgr.PlayerTypes = PlayerType.MagicHero;
        }
	
		// Update is called once per frame
		void Update () {
			
		}	

        /// <summary>
        /// 选择少年剑侠
        /// </summary>
        public void ChangeToSwordHero()
        {
            // 显示对象
            MObjSwordHero.SetActive(true);
            MObjMagicHero.SetActive(false);
            // 显示UI
            MObjUISwordHeroInfo.SetActive(true);
            MObjUIMagicHeroInfo.SetActive(false);
            // 获取玩家类型
            GlobalParamsMgr.PlayerTypes = PlayerType.SwordHero;
            // 播放音效
            Ctrl_LoginScene.Instance.PlayAudioEffectBySword();
        }

        /// <summary>
        /// 选择魔杖真人
        /// </summary>
        public void ChangeToMagicHero()
        {
            // 显示对象
            MObjMagicHero.SetActive(true);
            MObjSwordHero.SetActive(false);
            // 显示UI
            MObjUIMagicHeroInfo.SetActive(true);
            MObjUISwordHeroInfo.SetActive(false);
            // 获取玩家类型
            GlobalParamsMgr.PlayerTypes = PlayerType.MagicHero;
            // 播放音效
            Ctrl_LoginScene.Instance.PlayAudioEffectByMagic();
        }

        /// <summary>
        /// 提交信息
        /// </summary>
        public void SubmitInfo()
        {
            //获取用户名
            GlobalParamsMgr.PlayerName = inpUserName.name;

            //跳转下一场景
            //(控制层方法）
            Ctrl_LoginScene.Instance.EnterNextScenes();
        }
    }
}

