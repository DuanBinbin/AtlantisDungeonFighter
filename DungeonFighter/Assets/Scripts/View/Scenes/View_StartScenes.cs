/*************************************
*   Author  ： Duan Bin
*   Time    ： $time$
*   Function： 视图层 开始场景的控制
**************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Control;

namespace View{
    public class View_StartScenes : MonoBehaviour
    {
        public Button mNewGameBtn;
        public Button mContinueGameBtn;

        private void Start()
        {
            mNewGameBtn.onClick.AddListener(ClickNewGame);
            mContinueGameBtn.onClick.AddListener(ClickGameContine);
        }

        private void OnDestroy()
        {
            mNewGameBtn.onClick.RemoveAllListeners();
            mContinueGameBtn.onClick.RemoveAllListeners();
        }


        public void ClickNewGame()
        {
            print(GetType() + "/ClickNewGame");
            // 调用控制层开始新的传奇
            Ctrl_StartScenes.instance.ClickNewGame();
        }

        public void ClickGameContine()
        {
            print(GetType() + "/ClickGameContine");
            Ctrl_StartScenes.instance.ClickGameContinue();
        }


    }

}
