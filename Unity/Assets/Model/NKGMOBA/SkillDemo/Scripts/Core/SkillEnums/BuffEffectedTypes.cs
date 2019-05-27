//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2019年5月16日 11:49:10
//------------------------------------------------------------

using Sirenix.OdinInspector;

namespace ETModel
{
    [System.Flags]
    public enum BuffEffectedTypes
    {
        /// <summary>
        /// 来自英雄等级
        /// </summary>
        [LabelText("来自英雄等级的加成")] FromHeroLevel = 1 << 1,

        /// <summary>
        /// 来自技能等级
        /// </summary>
        [LabelText("来自技能等级的加成")] FromSkillLevel = 1 << 2,

        /// <summary>
        /// 来自英雄等级和技能等级
        /// </summary>
        [LabelText("来自英雄和技能等级的加成")] ALL = FromHeroLevel | FromSkillLevel,
    }
}