using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("闲话")]
[USharpPath("/Script/b1-Managed.PerformerAction_AIConversation")]
public class UPerformerAction_AIConversation : UPerformerActionBase
{
	private static bool ConversationContentIDList_IsValid;

	private static int ConversationContentIDList_Offset;

	private static FFieldAddress ConversationContentIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ConversationContentIDList_Marshaler;

	private static bool Performer_IsValid;

	private static int Performer_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_AIConversation:ConversationContentIDList")]
	public TArrayReadWrite<int> ConversationContentIDList
	{
		get
		{
			CheckDestroyed();
			if (!ConversationContentIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AIConversation:ConversationContentIDList");
				return null;
			}
			if (ConversationContentIDList_Marshaler == null)
			{
				ConversationContentIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ConversationContentIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ConversationContentIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ConversationContentIDList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_AIConversation:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AIConversation:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AIConversation:Performer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	protected override bool DoAction()
	{
		if (base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_HandleConversationByContentIDList.Invoke("PerformerController(控制一个LSP在非seq的情况下表演)", ConversationContentIDList.ToList());
			}
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_AIConversation");
		NativeReflection.GetPropertyRef(ref ConversationContentIDList_PropertyAddress, unrealStruct, "ConversationContentIDList");
		ConversationContentIDList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConversationContentIDList");
		ConversationContentIDList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConversationContentIDList", Classes.FArrayProperty);
		Performer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performer", Classes.FStructProperty);
	}

	static UPerformerAction_AIConversation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_AIConversation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_AIConversation));
	}
}
