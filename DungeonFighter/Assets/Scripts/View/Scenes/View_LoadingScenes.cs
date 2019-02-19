/*************************************
*   Author  ： Duan Bin
*   Time    ： 视图层 场景异步加载
*   Function： 
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using Global;

namespace View{
    public class View_LoadingScenes : MonoBehaviour {

        public Slider mLoadingSceneProgress;
        private AsyncOperation _asyOper;
        private float _currentLoadingValue;


        // Use this for initialization
        void Start () {
            StartCoroutine("LoadingScenesProgress");
		}
	
		// Update is called once per frame
		void Update () {
            if (_currentLoadingValue <= 1)
            {
                _currentLoadingValue += 0.01f;
            }
            mLoadingSceneProgress.value = _currentLoadingValue;
		}	

        IEnumerator LoadingScenesProgress()
        {
            _asyOper = SceneManager.LoadSceneAsync("2_LoginScene");
            GlobalParamsMgr.NextSceneName = SceneEnum.LoginScene;
            _asyOper = SceneManager.LoadSceneAsync(ConverterEnumToStr.getInstance().getStrSceneByEnumScene(GlobalParamsMgr.NextSceneName));
            _currentLoadingValue = _asyOper.progress;
            yield return _asyOper;
        }
	}
}

