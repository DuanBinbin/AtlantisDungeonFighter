/*
* ==============================
* FileName:		BaseCtrl
* Author:		DuanBin
* CreateTime:	9/19/2018 10:18:20 PM
* Description:	控制层脚本中公共的部分，在本脚本继承
* ==============================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Global;
using kernel;

namespace Control
{
	public class BaseCtrl : MonoBehaviour {
        /// <summary>
        /// 进入下一场景
        /// </summary>
        /// <param name="scenesEnumName"> 场景（枚举）名称</param>
	    protected void EnterNextScenes(SceneEnum scenesEnumName)
        {
            // 转入下一场景
            GlobalParamsMgr.NextSceneName = scenesEnumName;
            SceneManager.LoadScene(ConverterEnumToStr.getInstance().getStrSceneByEnumScene(GlobalParamsMgr.NextSceneName));// 加载新的场景     
        }
	}
}