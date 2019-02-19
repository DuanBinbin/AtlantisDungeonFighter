/*************************************
*   Author  ： Duan Bin
*   Time    ： 2018.07.19
*   Function： 公共层：枚举类型转换
**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global{
    public class ConverterEnumToStr  {

        private static ConverterEnumToStr instance;

        // 场景枚举字典
        private Dictionary<SceneEnum, string> _sceneEnumDic;

        private ConverterEnumToStr()
        {
            _sceneEnumDic = new Dictionary<SceneEnum, string>();

            _sceneEnumDic.Add(SceneEnum.StartScene, "1_StartScene");
            _sceneEnumDic.Add(SceneEnum.LoginScene, "2_LoginScene");
            _sceneEnumDic.Add(SceneEnum.LoadingScene, "LoadingScene");           
            _sceneEnumDic.Add(SceneEnum.LevelOne, "3_LevelOneScene");
            _sceneEnumDic.Add(SceneEnum.LevelTwo, "");
            _sceneEnumDic.Add(SceneEnum.BaseScene, "");
        }

        public static ConverterEnumToStr getInstance()
        {
            if (instance == null)
            {
                instance = new ConverterEnumToStr();
            }
            return instance;
        }

        /// <summary>
        /// 获取字符串类型的场景名称
        /// </summary>
        /// <param name="sceneEnum">枚举类型的场景名称</param>
        /// <returns></returns>
        public string getStrSceneByEnumScene(SceneEnum sceneEnum)
        {
            if (null != _sceneEnumDic && _sceneEnumDic.Count >= 1)
            {
                return _sceneEnumDic[sceneEnum];
            }
            else
            {
                Debug.LogWarning(GetType() + "getStrSceneByEnumScene()/_sceneEnumDic.Count < = 0,please check!!!"); 
                return null;
            }
        }
		
		
	}
}

