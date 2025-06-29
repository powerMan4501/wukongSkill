using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibAiConversation
{
	public enum ELessMoreType
	{
		Equal = 1,
		LessThan = 2,
		MoreThan = 4
	}

	public static bool AnalysisStrParam_To_IntValue(string Param, out int IntValue)
	{
		IntValue = 0;
		if (!int.TryParse(Param, out IntValue))
		{
			return false;
		}
		return true;
	}

	public static bool AnalysisStrParam_To_BoolValue(string Param, out bool BoolValue)
	{
		BoolValue = false;
		switch (Param)
		{
		case "Yes":
		case "YES":
		case "yes":
		case "True":
		case "TRUE":
		case "true":
			BoolValue = true;
			break;
		case "No":
		case "NO":
		case "no":
		case "False":
		case "FALSE":
		case "false":
			BoolValue = false;
			break;
		}
		return BoolValue;
	}

	public static bool AnalysisStrParam_To_IntStrValue(string Param, out int IntValue, out string StrValue, char SplitTag)
	{
		IntValue = 0;
		StrValue = "";
		string[] array = Param.Split(new char[1] { SplitTag }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length < 2)
		{
			return false;
		}
		if (!int.TryParse(array[0], out IntValue))
		{
			return false;
		}
		StrValue = array[1];
		return true;
	}

	public static List<int> AnalysisStrParam_To_IntValueList(string Param, char _split = '，')
	{
		List<int> list = new List<int>();
		string[] array = Param.Split(new char[1] { _split }, StringSplitOptions.RemoveEmptyEntries);
		int num = array.Length;
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					list.Add(result);
				}
			}
		}
		return list;
	}

	public static List<string> AnalysisStrParam_To_StrValueList(string Param, char splitTag = '$')
	{
		List<string> list = new List<string>();
		string[] array = Param.Split(new char[1] { splitTag }, StringSplitOptions.RemoveEmptyEntries);
		int num = array.Length;
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				list.Add(array[i]);
			}
		}
		return list;
	}

	public static bool AnalysisStrParam_To_TwoValueBetween(string Param, out int SmallValue, out int LargeValue)
	{
		SmallValue = 0;
		LargeValue = 0;
		int result = 0;
		int result2 = 0;
		string[] array = Param.Split(new char[1] { '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 2)
		{
			return false;
		}
		if (!int.TryParse(array[0], out result))
		{
			return false;
		}
		if (!int.TryParse(array[1], out result2))
		{
			return false;
		}
		LargeValue = FMath.Max(result, result2);
		SmallValue = FMath.Min(result, result2);
		return true;
	}

	public static bool AnalysisStrParam_To_Str_LessMore_Int(string Param, out string Str_1, out int LMType, out int Int_1)
	{
		Str_1 = "";
		LMType = 0;
		Int_1 = 0;
		string[] array = Param.Split(new char[1] { '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 3)
		{
			return false;
		}
		Str_1 = array[0];
		if (!AnalysisStrParam_To_LMType(array[1], out LMType))
		{
			return false;
		}
		if (!int.TryParse(array[2], out Int_1))
		{
			return false;
		}
		return true;
	}

	public static bool AnalysisStrParam_To_Int_LessMore_Int(string Param, out int Int_1, out int LMType, out int Int_2)
	{
		Int_1 = 0;
		LMType = 0;
		Int_2 = 0;
		string[] array = Param.Split(new char[1] { '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 3)
		{
			return false;
		}
		if (!int.TryParse(array[0], out Int_1))
		{
			return false;
		}
		if (!AnalysisStrParam_To_LMType(array[1], out LMType))
		{
			return false;
		}
		if (!int.TryParse(array[2], out Int_2))
		{
			return false;
		}
		return true;
	}

	public static bool AnalysisStrParam_To_Int_LessMore_Int_Str(string Param, out int Int_1, out int LMType, out int Int_2, out string Str_0)
	{
		Int_1 = 0;
		LMType = 0;
		Int_2 = 0;
		Str_0 = string.Empty;
		string[] array = Param.Split(new char[1] { '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 4)
		{
			return false;
		}
		if (!int.TryParse(array[0], out Int_1))
		{
			return false;
		}
		if (!AnalysisStrParam_To_LMType(array[1], out LMType))
		{
			return false;
		}
		if (!int.TryParse(array[2], out Int_2))
		{
			return false;
		}
		Str_0 = array[3];
		return true;
	}

	public static bool AnalysisStrParam_To_LMType(string Param, out int LMType)
	{
		LMType = 0;
		switch (Param)
		{
		case "=":
			LMType = 1;
			break;
		case "<":
			LMType = 2;
			break;
		case "<=":
			LMType = 3;
			break;
		case ">":
			LMType = 4;
			break;
		case ">=":
			LMType = 5;
			break;
		default:
			return false;
		}
		return true;
	}

	public static bool bPocess_LessMore(int Int_1, int LMType, int Int_2)
	{
		bool flag = false;
		if ((LMType & 1) != 0 && Int_1 == Int_2)
		{
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		if ((LMType & 2) != 0 && Int_1 < Int_2)
		{
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		if ((LMType & 4) != 0 && Int_1 > Int_2)
		{
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		return flag;
	}

	public static AActor TargetFilter(AActor BaseActor, AActor EvenetCaster, EAiConversationTargetType TargetType, string TargetFilterParam)
	{
		AActor result = null;
		switch (TargetType)
		{
		case EAiConversationTargetType.Self:
			result = BaseActor;
			break;
		case EAiConversationTargetType.LocalPlayer:
			result = UGSE_EngineFuncLib.GetFirstLocalPlayerController(BaseActor).GetControlledPawn();
			break;
		case EAiConversationTargetType.CurTarget:
			result = BGUFunctionLibraryCS.BGUGetTarget(BaseActor);
			break;
		case EAiConversationTargetType.ByGuid:
			result = BGU_DataUtil.GetActorByGuid(BaseActor, TargetFilterParam);
			break;
		case EAiConversationTargetType.ByTag:
		{
			BaseActor.World.GetAllActorsOfClassWithTag(UClass.GetClass<BGUCharacterCS>(), new FName(TargetFilterParam), out var OutActors);
			if (OutActors.Count > 0)
			{
				result = OutActors[0];
			}
			break;
		}
		case EAiConversationTargetType.EventCaster:
			result = EvenetCaster;
			break;
		case EAiConversationTargetType.Narrator:
			result = ((IBGC_AiConversationMgrData)BGU_DataUtil.GetGameStateReadonlyData<BGC_AiConversationMgrData>(BaseActor)).GetNarrator();
			break;
		}
		return result;
	}

	public static List<int> AnalysisAiConversationIDList(List<int> ConversationContentIDList)
	{
		List<int> list = new List<int>();
		foreach (int ConversationContentID in ConversationContentIDList)
		{
			if (ConversationContentID > 0)
			{
				list.Add(ConversationContentID);
			}
			else
			{
				if (ConversationContentID >= 0)
				{
					continue;
				}
				FUStAiConversationGroupDesc aiConversationGroupDesc = BGW_GameDB.GetAiConversationGroupDesc(-ConversationContentID);
				if (aiConversationGroupDesc == null)
				{
					continue;
				}
				foreach (int aiConversationID in aiConversationGroupDesc.AiConversationIDList)
				{
					list.Add(aiConversationID);
				}
			}
		}
		return list;
	}
}
