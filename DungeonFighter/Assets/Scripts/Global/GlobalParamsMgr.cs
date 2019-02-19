/*************************************
*   Author  ： Duan Bin
*   Time    ： 2018.07.19
*   Function： 1.公共层： 全局参数管理器
*              2.跨场景全局数据传递
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global{
    public static class GlobalParamsMgr  {

        // 下一场景
        public static SceneEnum NextSceneName = SceneEnum.LoadingScene;
        //玩家的姓名
        public static string PlayerName = "";
        //玩家类型
        public static PlayerType PlayerTypes = PlayerType.SwordHero;
	}
}

