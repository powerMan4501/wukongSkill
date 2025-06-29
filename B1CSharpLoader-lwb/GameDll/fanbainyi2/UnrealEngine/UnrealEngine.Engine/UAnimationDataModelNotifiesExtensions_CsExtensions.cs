using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UAnimationDataModelNotifiesExtensions_CsExtensions
{
	public static FEmptyPayload GetPayload(this FAnimDataModelNotifPayload Payload)
	{
		return UAnimationDataModelNotifiesExtensions.GetPayload(Payload);
	}

	public static void CopyPayload(this FAnimDataModelNotifPayload Payload, UScriptStruct ExpectedStruct, ref FEmptyPayload OutPayload)
	{
		UAnimationDataModelNotifiesExtensions.CopyPayload(Payload, ExpectedStruct, ref OutPayload);
	}
}
