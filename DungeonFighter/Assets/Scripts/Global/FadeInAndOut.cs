/*************************************
*   Author  ： Duan Bin
*   Time    ： 20180707
*   Function： 公共层 场景的淡入淡出
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Global{
    public class FadeInAndOut : MonoBehaviour {

        public static FadeInAndOut instance;
        public GameObject mGoRawIamge;
        private RawImage _rawImage;

        // 颜色变化速度
        [Range(0,1)]
        public float colorChangeSpeed = 1.0f;

        private bool _screenToClear = true;
        private bool _screenToBlack = false;

        private void Awake()
        {
            instance = this;
            if (mGoRawIamge)
            {
                _rawImage = mGoRawIamge.GetComponent<RawImage>();
            }
        }

        // Use this for initialization
        void Start () {
			
		}
	
		// Update is called once per frame
		void Update () {
            if (_screenToClear)
            {
                // 屏幕淡入
                ScreenFadeIn();
            }
            else if (_screenToBlack)
            {
                // 屏幕淡出
                ScreenFadeOut();
            }			
		}
        
        /// <summary>
        /// 淡入(屏幕清晰)
        /// </summary>
        private void FadeIn()
        {
            _rawImage.color = Color.Lerp(_rawImage.color, Color.clear, colorChangeSpeed * Time.deltaTime);
        }

        /// <summary>
        /// 淡出（屏幕暗淡）
        /// </summary>
        private void FadeOut()
        {
            _rawImage.color = Color.Lerp(_rawImage.color, 
                Color.black, colorChangeSpeed * Time.deltaTime);
        }

        /// <summary>
        /// 屏幕淡入
        /// </summary>
        private void ScreenFadeIn()
        {
            FadeIn();
            if (_rawImage.color.a <= 0.05)
            {
                _rawImage.color = Color.clear;
                _rawImage.enabled = false;
                _screenToClear = false;
            }
        }

        /// <summary>
        /// 屏幕淡出
        /// </summary>
        private void ScreenFadeOut()
        {
            _rawImage.enabled = true;
            FadeOut();    
            if (_rawImage.color.a >= 0.95)
            {
                _rawImage.color = Color.black;
                
               _screenToBlack = false;
            }
        }

        /// <summary>
        /// 设置场景淡入
        /// </summary>
        public void setScenesFadeIn()
        {
            _screenToClear = true;
            _screenToBlack = false;
        }

        /// <summary>
        /// 设置场景淡出
        /// </summary>
        public void setScenesFadeOut()
        {
            _screenToClear = false;
            _screenToBlack = true;
        }
    }
}

