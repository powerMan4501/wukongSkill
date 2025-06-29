using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_HandleAiConversation")]
internal class BAIT_HandleAiConversation : BAIT_Base
{
	private static bool ConversationContentIDList_IsValid;

	private static int ConversationContentIDList_Offset;

	private static FFieldAddress ConversationContentIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ConversationContentIDList_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_HandleAiConversation:ConversationContentIDList")]
	public TArrayReadWrite<int> ConversationContentIDList
	{
		get
		{
			CheckDestroyed();
			if (!ConversationContentIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_HandleAiConversation:ConversationContentIDList");
				return null;
			}
			if (ConversationContentIDList_Marshaler == null)
			{
				ConversationContentIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ConversationContentIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ConversationContentIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ConversationContentIDList_Offset));
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
		if (bUS_GSEventCollection != null)
		{
			string sourceLog = "行为树节点::BAIT_HandleAiConversation";
			bUS_GSEventCollection.Evt_HandleConversationByContentIDList.Invoke(sourceLog, ConversationContentIDList.ToList());
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_HandleAiConversation");
		NativeReflection.GetPropertyRef(ref ConversationContentIDList_PropertyAddress, unrealStruct, "ConversationContentIDList");
		ConversationContentIDList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConversationContentIDList");
		ConversationContentIDList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConversationContentIDList", Classes.FArrayProperty);
	}

	static BAIT_HandleAiConversation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_HandleAiConversation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_HandleAiConversation));
	}
}
