/*************************************
*   Author  ： Duan Bin
*   Time    ： $time$
*   Function： 控制层 英雄的展示
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Global;
using kernel;

namespace Control{
    public class Ctrl_DisplayHero : MonoBehaviour {

        public AnimationClip AniIdle;
        public AnimationClip AniRunning;
        public AnimationClip AniAttack;

        private Animation _aniCurrentAnimation;     // 当前动画

        private float _floIntervelTimes = 3f;       // 间隔三秒

        private int _intRandomPlayNumber;     // 随机动作编号

		// Use this for initialization
		void Start () {
            _aniCurrentAnimation = this.GetComponent<Animation>();               			
		}

        /// <summary>
        /// 算法：间隔三秒钟，随机播放一个人物动画
        /// </summary>
        void Update()
        {
            _floIntervelTimes -= Time.deltaTime;
            if (_floIntervelTimes <= 0)
            {
                _floIntervelTimes = 3f;
                // 得到随机数
                _intRandomPlayNumber = Random.Range(1, 4);      // Random.Range 根据经验不会随机最大值
                DisplayHeroPlaying(_intRandomPlayNumber);
            }
        }


        /// <summary>
        /// 随机播放动作
        /// </summary>
        /// <param name="intPlayingNum">动作编号</param>
        internal void DisplayHeroPlaying(int intPlayingNum)
        {
            switch (intPlayingNum)
            {
                case 1:
                    DisplayIdle();
                    break;
                case 2:
                    DisplayRunning();
                    break;
                case 3:
                    DisplayAttack();
                    break;
            }
        }



        /// <summary>
        /// 展示休闲动作
        /// </summary>
        internal void DisplayIdle()
        {
            if (_aniCurrentAnimation)
            {
                _aniCurrentAnimation.CrossFade(AniIdle.name);
            }
        }

        /// <summary>
        /// 展示跑步动作
        /// </summary>
        internal void DisplayRunning()
        {
            if (_aniCurrentAnimation)
            {
                _aniCurrentAnimation.CrossFade(AniRunning.name);
            }
        }

        /// <summary>
        /// 展示攻击动作
        /// </summary>
        internal void DisplayAttack()
        {
            if (_aniCurrentAnimation)
            {
                _aniCurrentAnimation.CrossFade(AniAttack.name);
            }
        }


	}
}

