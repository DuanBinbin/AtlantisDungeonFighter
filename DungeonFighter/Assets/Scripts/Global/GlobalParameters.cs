/*************************************
*   Author  ： Duan Bin
*   Time    ： 2018.07.19
*   Function： 1.公共层 全局变量
*              2.定义整个项目的枚举类型
*              3.定义整个项目的委托
*              4.定义整个项目的变量
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global{

    public class GlobalParameters
    {		
		
	}

    /// <summary>
    /// 场景名称
    /// </summary>
    public enum SceneEnum
    {
        StartScene,
        LoadingScene,
        LoginScene,
        LevelOne,
        LevelTwo,
        BaseScene
    }

    /// <summary>
    /// 玩家类型
    /// </summary>
    public enum PlayerType
    {
        SwordHero,      // 少年剑侠
        MagicHero,      // 魔杖真人
        Other
    }
}

