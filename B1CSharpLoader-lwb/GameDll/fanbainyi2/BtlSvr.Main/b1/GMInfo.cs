using System.Collections.Generic;
using System.Text;

namespace b1;

public class GMInfo
{
	public EGMType GMType;

	public int Level;

	public string GMCmd;

	public string GMDescription;

	private static readonly Dictionary<EGMType, List<GMInfo>> GMInfoMap = new Dictionary<EGMType, List<GMInfo>>();

	private static EGMType CurRegistType = EGMType.GM_None;

	private static int CurRegistLevel = 1;

	public GMInfo(string InCmd, string InDescription)
	{
		GMType = CurRegistType;
		Level = CurRegistLevel;
		GMCmd = InCmd;
		GMDescription = InDescription;
		if (CurRegistType == EGMType.GM_None || CurRegistLevel == 1)
		{
			BGW_LogUtil.LogError($"[GMInfo] Type = {GMType}, Level = {Level}");
		}
	}

	public static void RegisterGMInfo(string name, string help)
	{
		if (!GMInfoMap.TryGetValue(CurRegistType, out var value))
		{
			value = new List<GMInfo>();
			GMInfoMap.Add(CurRegistType, value);
		}
		value.Add(new GMInfo(name, help));
	}

	public static void SetCurRegistInfo(EGMType InGMType, int InLevel)
	{
		CurRegistType = InGMType;
		CurRegistLevel = InLevel;
	}

	public static void ResetCurRegistInfo()
	{
		CurRegistType = EGMType.GM_None;
		CurRegistLevel = 1;
	}

	public static string Dump()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 5; i++)
		{
			EGMType eGMType = (EGMType)i;
			if (GMInfoMap.TryGetValue(eGMType, out var value))
			{
				stringBuilder.AppendLine("> # " + GetGMTypeName(eGMType));
				if (!string.IsNullOrEmpty(GetGMTypeDesc(eGMType)))
				{
					stringBuilder.AppendLine("> ### " + GetGMTypeDesc(eGMType));
				}
				stringBuilder.AppendLine("> ###\r\n> 命令 | 描述 | 调试等级\r\n> ------------ | ------------- | ------------");
				for (int j = 0; j < value.Count; j++)
				{
					GMInfo gMInfo = value[j];
					stringBuilder.AppendLine("> " + gMInfo.GMCmd + " | " + gMInfo.GMDescription + " | " + GetGMFlagDesc(gMInfo.Level));
				}
				stringBuilder.AppendLine("#");
			}
		}
		return stringBuilder.ToString();
	}

	private static string GetGMTypeName(EGMType GMType)
	{
		return GMType switch
		{
			EGMType.GM_BGW => "常驻GM", 
			EGMType.GM_BUS => "角色GM", 
			EGMType.GM_SYSTEM => "系统GM", 
			EGMType.GM_SERVER => "角色数据GM", 
			_ => "默认GM", 
		};
	}

	private static string GetGMTypeDesc(EGMType GMType)
	{
		return GMType switch
		{
			EGMType.GM_BGW => "随时可以触发的GM", 
			EGMType.GM_BUS => "需要角色单位存在才能触发的GM，开始菜单不可触发", 
			EGMType.GM_SYSTEM => "执行前需要添加b.sys", 
			EGMType.GM_SERVER => "执行前需要添加b.sys", 
			_ => "", 
		};
	}

	private static string GetGMFlagDesc(int Flag)
	{
		return Flag switch
		{
			1 => "默认GM（不受权限控制，默认注册）", 
			2 => "作弊GM（Diana内）", 
			4 => "调试GM（各种调试命令）", 
			8 => "UE快捷键调试GM（F11等）", 
			_ => "", 
		};
	}
}
