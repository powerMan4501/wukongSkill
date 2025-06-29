using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

public class GSInCharacterViewCVarHelper
{
	public class GSInCharacterViewCVar
	{
		public enum EnGSInCVarType
		{
			INT,
			FLOAT
		}

		public string CVarFullName;

		public bool IsGMIgnore;

		public EnGSInCVarType ValType;

		public bool IsSavedPreValue;

		public int ValIntOrg;

		public int ValIntNew;

		public float ValFloatOrg;

		public float ValFloatNew;

		public void SetIsGMIgnore(bool InIsGMIgnore)
		{
			IsGMIgnore = InIsGMIgnore;
		}

		public GSInCharacterViewCVar(string InCVarFullName, EnGSInCVarType InValType, bool InIsGMIgnore = false, int InValIntNew = 0, float InValFloatNew = 0f)
		{
			CVarFullName = InCVarFullName;
			IsGMIgnore = InIsGMIgnore;
			ValType = InValType;
			ValIntNew = InValIntNew;
			ValFloatNew = InValFloatNew;
		}

		public void ResumePreValue(UObject Context)
		{
			if (IsGMIgnore)
			{
				return;
			}
			if (!IsSavedPreValue)
			{
				BGW_LogUtil.LogError("GSInCharacterViewCVar ResumePreValue Failed IsSavedPreValue Is False");
				return;
			}
			string text = CVarFullName ?? "";
			if (ValType == EnGSInCVarType.INT)
			{
				text += $" {ValIntOrg}";
			}
			else if (ValType == EnGSInCVarType.FLOAT)
			{
				text += $" {ValFloatOrg}";
			}
			USystemLibrary.ExecuteConsoleCommand(Context, text ?? "", null);
			_ = DebugConfig.IsDebugUISys;
		}

		public void SetNewValue(UObject Context)
		{
			if (IsGMIgnore)
			{
				return;
			}
			if (!IsSavedPreValue)
			{
				BGW_LogUtil.LogError("GSInCharacterViewCVar SetNewValue Failed IsSavedPreValue Is False");
				return;
			}
			string text = CVarFullName ?? "";
			if (ValType == EnGSInCVarType.INT)
			{
				text += $" {ValIntNew}";
			}
			else if (ValType == EnGSInCVarType.FLOAT)
			{
				text += $" {ValFloatNew}";
			}
			USystemLibrary.ExecuteConsoleCommand(Context, text ?? "", null);
			_ = DebugConfig.IsDebugUISys;
		}

		public void SavePreValue()
		{
			if (IsGMIgnore)
			{
				return;
			}
			IsSavedPreValue = true;
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(CVarFullName);
			if (consoleVariable == null)
			{
				ValIntOrg = 0;
				ValFloatOrg = 0f;
				return;
			}
			if (ValType == EnGSInCVarType.INT)
			{
				ValIntOrg = consoleVariable.GetInt();
			}
			else if (ValType == EnGSInCVarType.FLOAT)
			{
				ValFloatOrg = consoleVariable.GetFloat();
			}
			else
			{
				BGW_LogUtil.LogError($"SavePreValue Failed Invalid ValType:{ValType}");
			}
			_ = DebugConfig.IsDebugUISys;
		}
	}

	private List<GSInCharacterViewCVar> CharacterViewCVarList;

	public void SaveAllPreValue()
	{
		for (int i = 0; i < CharacterViewCVarList.Count; i++)
		{
			CharacterViewCVarList[i].SavePreValue();
		}
	}

	public void ResumeAllPreValue(UObject Context)
	{
		for (int i = 0; i < CharacterViewCVarList.Count; i++)
		{
			CharacterViewCVarList[i].ResumePreValue(Context);
		}
	}

	public void SetAllNewValue(UObject Context)
	{
		for (int i = 0; i < CharacterViewCVarList.Count; i++)
		{
			CharacterViewCVarList[i].SetNewValue(Context);
		}
	}

	public void AddNewCVarInt(string InCVarFullName, int _InValIntNew = 0, bool _InIsGMIgnore = false)
	{
	}

	public void AddNewCVarFloat(string InCVarFullName, float _InValFloatNew = 0f, bool _InIsGMIgnore = false)
	{
	}

	public bool GMSetCVarIsIgnore(string InCVarFullName, bool IsIgnore)
	{
		for (int i = 0; i < CharacterViewCVarList.Count; i++)
		{
			if (CharacterViewCVarList[i].CVarFullName == InCVarFullName)
			{
				CharacterViewCVarList[i].SetIsGMIgnore(IsIgnore);
				return true;
			}
		}
		return false;
	}

	public GSInCharacterViewCVarHelper()
	{
		CharacterViewCVarList = new List<GSInCharacterViewCVar>();
	}
}
