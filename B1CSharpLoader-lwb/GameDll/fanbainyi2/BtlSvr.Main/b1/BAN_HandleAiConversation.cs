using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Handle AiConversation")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_HandleAiConversation")]
internal class BAN_HandleAiConversation : BAN_GSBase
{
	private static bool ConversationContentIDList_IsValid;

	private static int ConversationContentIDList_Offset;

	private static FFieldAddress ConversationContentIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ConversationContentIDList_Marshaler;

	private static bool UseInteractTemplete_IsValid;

	private static int UseInteractTemplete_Offset;

	private static FFieldAddress UseInteractTemplete_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_HandleAiConversation:ConversationContentIDList")]
	public TArrayReadWrite<int> ConversationContentIDList
	{
		get
		{
			CheckDestroyed();
			if (!ConversationContentIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_HandleAiConversation:ConversationContentIDList");
				return null;
			}
			if (ConversationContentIDList_Marshaler == null)
			{
				ConversationContentIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ConversationContentIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ConversationContentIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ConversationContentIDList_Offset));
		}
	}

	[DisplayName("使用交互模板中的配置")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_HandleAiConversation:UseInteractTemplete")]
	public bool UseInteractTemplete
	{
		get
		{
			CheckDestroyed();
			if (!UseInteractTemplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_HandleAiConversation:UseInteractTemplete");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInteractTemplete_Offset), 0, UseInteractTemplete_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInteractTemplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_HandleAiConversation:UseInteractTemplete");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInteractTemplete_Offset), 0, UseInteractTemplete_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_HandleAiConversation:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_HandleAiConversation:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		string text = NotifyParam.Animation.GetPathName() + "中的Notify::HandleAiConversation";
		if (UseInteractTemplete)
		{
			BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(owner);
			if (readOnlyData != null)
			{
				ConversationContentIDList.Clear();
				ConversationContentIDList.Add(readOnlyData.AiConversationNeedToPlay);
				text += ",并使用了交互模板中的配置";
			}
		}
		bUS_GSEventCollection.Evt_HandleConversationByContentIDList.Invoke(text, ConversationContentIDList.ToList());
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_HandleAiConversation:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_HandleAiConversation bAN_HandleAiConversation = GCHelper.Find<b1.BAN_HandleAiConversation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_HandleAiConversation.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_HandleAiConversation:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_HandleAiConversation bAN_HandleAiConversation = GCHelper.Find<b1.BAN_HandleAiConversation>(obj);
		bool value = bAN_HandleAiConversation.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_HandleAiConversation");
		NativeReflection.GetPropertyRef(ref ConversationContentIDList_PropertyAddress, intPtr, "ConversationContentIDList");
		ConversationContentIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConversationContentIDList");
		ConversationContentIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConversationContentIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseInteractTemplete_PropertyAddress, intPtr, "UseInteractTemplete");
		UseInteractTemplete_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseInteractTemplete");
		UseInteractTemplete_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseInteractTemplete", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_HandleAiConversation:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_HandleAiConversation:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_HandleAiConversation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_HandleAiConversation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_HandleAiConversation));
	}
}
