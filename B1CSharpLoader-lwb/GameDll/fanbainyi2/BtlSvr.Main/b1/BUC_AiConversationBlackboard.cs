using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1;

public class BUC_AiConversationBlackboard : b1.IBUC_AiConversationBlackboard, IPersistentECSData
{
	private Dictionary<string, EAiConversationFactType> FactTypeMap;

	private Dictionary<string, int> AiConvRecordData_Int;

	private Dictionary<string, bool> AiConvRecordData_Bool;

	private Dictionary<string, string> AiConvRecordData_Str;

	public BUC_AiConversationBlackboard()
	{
		FactTypeMap = new Dictionary<string, EAiConversationFactType>();
		AiConvRecordData_Int = new Dictionary<string, int>();
		AiConvRecordData_Bool = new Dictionary<string, bool>();
		AiConvRecordData_Str = new Dictionary<string, string>();
	}

	public void RegistFactData(FAiConversationFact Fact)
	{
		switch (Fact.FactType)
		{
		case EAiConversationFactType.FactType_Int:
			RegistFactData(Fact.KeyName, Fact.DefaultValue_Int);
			break;
		case EAiConversationFactType.FactType_Bool:
			RegistFactData(Fact.KeyName, Fact.DefaultValue_Bool);
			break;
		case EAiConversationFactType.FactType_String:
			RegistFactData(Fact.KeyName, Fact.DefaultValue_Str);
			break;
		}
	}

	public void RegistFactData(string KeyName, int DataValue)
	{
		if (!FactTypeMap.ContainsKey(KeyName))
		{
			FactTypeMap.Add(KeyName, EAiConversationFactType.FactType_Int);
			AiConvRecordData_Int.Add(KeyName, DataValue);
		}
	}

	public void RegistFactData(string KeyName, bool DataValue)
	{
		if (!FactTypeMap.ContainsKey(KeyName))
		{
			FactTypeMap.Add(KeyName, EAiConversationFactType.FactType_Bool);
			AiConvRecordData_Bool.Add(KeyName, DataValue);
		}
	}

	public void RegistFactData(string KeyName, string DataValue)
	{
		if (!FactTypeMap.ContainsKey(KeyName))
		{
			FactTypeMap.Add(KeyName, EAiConversationFactType.FactType_String);
			AiConvRecordData_Str.Add(KeyName, DataValue);
		}
	}

	public object GetFactData(string KeyName, out EAiConversationFactType FactType)
	{
		if (!FactTypeMap.TryGetValue(KeyName, out FactType))
		{
			return null;
		}
		return FactType switch
		{
			EAiConversationFactType.FactType_Int => AiConvRecordData_Int[KeyName], 
			EAiConversationFactType.FactType_Bool => AiConvRecordData_Bool[KeyName], 
			EAiConversationFactType.FactType_String => AiConvRecordData_Str[KeyName], 
			_ => null, 
		};
	}

	public bool GetFactDataType(string KeyName, out EAiConversationFactType FactType)
	{
		if (FactTypeMap.TryGetValue(KeyName, out FactType))
		{
			return true;
		}
		return false;
	}

	public bool GetFactData_Int(string KeyName, out int IntValue)
	{
		if (AiConvRecordData_Int.TryGetValue(KeyName, out IntValue))
		{
			return true;
		}
		return false;
	}

	public bool GetFactData_Bool(string KeyName, out bool BoolValue)
	{
		if (AiConvRecordData_Bool.TryGetValue(KeyName, out BoolValue))
		{
			return true;
		}
		return false;
	}

	public bool GetFactData_Str(string KeyName, out string StrValue)
	{
		if (AiConvRecordData_Str.TryGetValue(KeyName, out StrValue))
		{
			return true;
		}
		return false;
	}

	public bool ModifyData(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		if (!FactTypeMap.TryGetValue(KeyName, out var value))
		{
			return false;
		}
		return value switch
		{
			EAiConversationFactType.FactType_Int => ModifyData_Int(KeyName, OperateType, ModifyContent), 
			EAiConversationFactType.FactType_Bool => ModifyData_Bool(KeyName, OperateType, ModifyContent), 
			EAiConversationFactType.FactType_String => ModifyData_Str(KeyName, OperateType, ModifyContent), 
			_ => false, 
		};
	}

	public bool ModifyData_Int(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		if (!AiConvRecordData_Int.TryGetValue(KeyName, out var _))
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_IntValue(ModifyContent, out var IntValue))
		{
			return false;
		}
		switch (OperateType)
		{
		case EACFactDataOperateType.Increase:
			AiConvRecordData_Int[KeyName] += IntValue;
			break;
		case EACFactDataOperateType.Decrease:
			AiConvRecordData_Int[KeyName] -= IntValue;
			break;
		case EACFactDataOperateType.Replace:
			AiConvRecordData_Int[KeyName] = IntValue;
			break;
		default:
			return false;
		}
		return true;
	}

	public bool ModifyData_Bool(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		if (!AiConvRecordData_Bool.TryGetValue(KeyName, out var _))
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_BoolValue(ModifyContent, out var BoolValue))
		{
			return false;
		}
		switch (OperateType)
		{
		case EACFactDataOperateType.Or:
			AiConvRecordData_Bool[KeyName] |= BoolValue;
			break;
		case EACFactDataOperateType.And:
			AiConvRecordData_Bool[KeyName] &= BoolValue;
			break;
		case EACFactDataOperateType.Replace:
			AiConvRecordData_Bool[KeyName] = BoolValue;
			break;
		default:
			return false;
		}
		return true;
	}

	public bool ModifyData_Str(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		if (!AiConvRecordData_Str.TryGetValue(KeyName, out var _))
		{
			return false;
		}
		if (OperateType == EACFactDataOperateType.Replace)
		{
			AiConvRecordData_Str[KeyName] = ModifyContent;
			return true;
		}
		return false;
	}
}
