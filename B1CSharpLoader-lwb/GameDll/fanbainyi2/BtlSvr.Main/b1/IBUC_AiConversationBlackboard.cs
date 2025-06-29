namespace b1;

internal interface IBUC_AiConversationBlackboard
{
	bool GetFactDataType(string KeyName, out EAiConversationFactType FactType);

	bool GetFactData_Int(string KeyName, out int IntValue);

	bool GetFactData_Bool(string KeyName, out bool BoolValue);

	bool GetFactData_Str(string KeyName, out string StrValue);
}
