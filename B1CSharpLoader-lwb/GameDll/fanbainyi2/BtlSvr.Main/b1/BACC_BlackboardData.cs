using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_BlackboardData : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target != null)
		{
			string[] array = ConditionInstData.ConditionValue.Split(new char[1] { '，' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length != 3)
			{
				return false;
			}
			string keyName = array[0];
			b1.IBUC_AiConversationBlackboard readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_AiConversationBlackboard, BUC_AiConversationBlackboard>(ConditionInstData.Target);
			if (readOnlyData == null)
			{
				return false;
			}
			if (!readOnlyData.GetFactDataType(keyName, out var FactType))
			{
				return false;
			}
			switch (FactType)
			{
			case EAiConversationFactType.FactType_Int:
			{
				if (!readOnlyData.GetFactData_Int(keyName, out var IntValue))
				{
					return false;
				}
				if (!BGUFuncLibAiConversation.AnalysisStrParam_To_LMType(array[1], out var LMType))
				{
					return false;
				}
				if (!int.TryParse(array[2], out var result))
				{
					return false;
				}
				if (BGUFuncLibAiConversation.bPocess_LessMore(IntValue, LMType, result))
				{
					return true;
				}
				break;
			}
			case EAiConversationFactType.FactType_Bool:
			{
				if (!readOnlyData.GetFactData_Bool(keyName, out var BoolValue))
				{
					return false;
				}
				string text3 = array[1];
				string param = array[2];
				bool flag = true;
				if (!(text3 == "="))
				{
					if (!(text3 == "!="))
					{
						return false;
					}
					flag = false;
				}
				else
				{
					flag = true;
				}
				if (!BGUFuncLibAiConversation.AnalysisStrParam_To_BoolValue(param, out var BoolValue2))
				{
					return false;
				}
				return flag == (BoolValue == BoolValue2);
			}
			case EAiConversationFactType.FactType_String:
			{
				if (!readOnlyData.GetFactData_Str(keyName, out var StrValue))
				{
					return false;
				}
				string text = array[1];
				string text2 = array[2];
				if (!(text == "="))
				{
					if (text == "!=")
					{
						return StrValue != text2;
					}
					return false;
				}
				return StrValue == text2;
			}
			}
		}
		return false;
	}
}
