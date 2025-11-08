using System.Collections.Generic;
using CSharpModBase.Input;

namespace BlackMythWukong_Game_Helper;

public class TB_KeyHook : TB
{
	public List<KeyHook> List_ { get; set; }

	public TB_KeyHook()
	{
		List_ = new List<KeyHook>();
		Init();
	}

	public void Init()
	{
		GlobalObjectMgr.Get<NameCN>().Add(new List<Name>
		{
			new Name
			{
				Key = "test",
				Value = "作者测试专用(1)",
				HookKey = (Key)13
			},
			new Name
			{
				Key = "test1",
				Value = "作者测试专用(2)",
				HookKey = (Key)35
			},
			new Name
			{
				Key = "OpenMainMenu",
				Value = "打开主菜单",
				HookKey = (Key)192
			},
			new Name
			{
				Key = "OnGSLockHP",
				Value = "锁血",
				HookKey = (Key)112
			},
			new Name
			{
				Key = "OnGSLockMP",
				Value = "锁蓝",
				HookKey = (Key)113
			},
			new Name
			{
				Key = "OnGSLockPE",
				Value = "锁棍势",
				HookKey = (Key)114
			},
			new Name
			{
				Key = "OnGSLockStamina",
				Value = "锁定耐力",
				HookKey = (Key)115
			},
			new Name
			{
				Key = "OnGSLockVigorEnergy",
				Value = "锁精魄能量",
				HookKey = (Key)116
			},
			new Name
			{
				Key = "OnGSLockCD",
				Value = "重置CD",
				HookKey = (Key)117
			},
			new Name
			{
				Key = "OnGSSetSpeed",
				Value = "超级移速",
				HookKey = (Key)0
			},
			new Name
			{
				Key = "OnGSPreciseDodge",
				Value = "精准闪避",
				HookKey = (Key)0
			},
			new Name
			{
				Key = "OnGSPreciseGP",
				Value = "自动识破",
				HookKey = (Key)0
			},
			new Name
			{
				Key = "OnGsKuaiSuXuLi",
				Value = "加速蓄力(5倍和蓄4豆)",
				HookKey = (Key)0
			},
			new Name
			{
				Key = "OnGSLockJDY",
				Value = "筋斗云",
				HookKey = (Key)71
			},
			new Name
			{
				Key = "OnGSLockSpellRebirth",
				Value = "法术轮回",
				HookKey = (Key)0
			},
			new Name
			{
				Key = "OnGSPreciseHMQ",
				Value = "精准定身",
				HookKey = (Key)0
			}
		});
	}
}
