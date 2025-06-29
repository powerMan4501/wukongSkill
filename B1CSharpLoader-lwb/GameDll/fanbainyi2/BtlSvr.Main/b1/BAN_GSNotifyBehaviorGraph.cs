using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("通知CBG")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph")]
public class BAN_GSNotifyBehaviorGraph : BAN_GSBase
{
	private static bool NotifyTag_IsValid;

	private static int NotifyTag_Offset;

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
	[DisplayName("通知信息")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:NotifyTag")]
	public string NotifyTag
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:NotifyTag");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, NotifyTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:NotifyTag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, NotifyTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
			if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld) && !string.IsNullOrEmpty(NotifyTag))
			{
				BGW_EventCollection.Get(owner)?.Evt_BGW_AMNotifyBehaviorGraph(owner, NotifyTag);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSNotifyBehaviorGraph bAN_GSNotifyBehaviorGraph = GCHelper.Find<BAN_GSNotifyBehaviorGraph>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSNotifyBehaviorGraph.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSNotifyBehaviorGraph bAN_GSNotifyBehaviorGraph = GCHelper.Find<BAN_GSNotifyBehaviorGraph>(obj);
		bool value = bAN_GSNotifyBehaviorGraph.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph");
		NotifyTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTag");
		NotifyTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTag", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSNotifyBehaviorGraph:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSNotifyBehaviorGraph()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSNotifyBehaviorGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSNotifyBehaviorGraph));
	}
}
