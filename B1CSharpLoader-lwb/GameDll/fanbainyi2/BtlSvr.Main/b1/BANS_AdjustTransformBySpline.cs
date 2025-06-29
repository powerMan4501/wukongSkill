using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS AdjustTransformBySpline")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline")]
internal class BANS_AdjustTransformBySpline : BANS_GSBase
{
	private static bool bShowDebug_IsValid;

	private static int bShowDebug_Offset;

	private static FFieldAddress bShowDebug_PropertyAddress;

	private static bool SplineGuid_IsValid;

	private static int SplineGuid_Offset;

	private static bool RotateType_IsValid;

	private static int RotateType_Offset;

	private static FFieldAddress RotateType_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:bShowDebug")]
	public bool bShowDebug
	{
		get
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:bShowDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:bShowDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:SplineGuid")]
	public FGameplayTag SplineGuid
	{
		get
		{
			CheckDestroyed();
			if (!SplineGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:SplineGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, SplineGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:SplineGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, SplineGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:RotateType")]
	public ETransformBySplineRotateType RotateType
	{
		get
		{
			CheckDestroyed();
			if (!RotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:RotateType");
				return ETransformBySplineRotateType.RotateToSplineTangentByTargetSide;
			}
			return EnumMarshaler<ETransformBySplineRotateType>.FromNative(IntPtr.Add(base.Address, RotateType_Offset), 0, RotateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_AdjustTransformBySpline:RotateType");
			}
			else
			{
				EnumMarshaler<ETransformBySplineRotateType>.ToNative(IntPtr.Add(base.Address, RotateType_Offset), 0, RotateType_PropertyAddress.Address, value);
			}
		}
	}

	private TWeakObject<BGUSplineActor> SplineActorRef { get; set; }

	private float RemainTime { get; set; }

	private FTransform TargetTransform { get; set; }

	private bool bCanAdjust { get; set; }

	private BUS_GSEventCollection BE { get; set; }

	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(NotifyParam.owner.World))
		{
			AActor owner = NotifyParam.owner;
			BE = BUS_EventCollectionCS.Get(owner);
			AActor _Target = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(owner).GetTargetInfo().LockTargetActor;
			if (BE != null && _Target != null)
			{
				GSDel_AITransformBySplineChange evt_AITransformBySplineChange = BE.Evt_AITransformBySplineChange;
				ETransformBySplineRotateType rotateType = RotateType;
				FGameplayTag SplineGuid = this.SplineGuid;
				bool num = bShowDebug;
				BAIT_Base _BAITRef = null;
				BANS_GSBase _BANSRef = this;
				evt_AITransformBySplineChange.Invoke(TotalDuration, rotateType, in _Target, in SplineGuid, num, in _BAITRef, in _BANSRef);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(NotifyParam.owner.World))
		{
			AActor _Target = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(NotifyParam.owner).GetTargetInfo().LockTargetActor;
			if (BE != null && _Target != null)
			{
				GSDel_AITransformBySplineStop evt_AITransformBySplineStop = BE.Evt_AITransformBySplineStop;
				BAIT_Base _BAITRef = null;
				BANS_GSBase _BANSRef = this;
				evt_AITransformBySplineStop.Invoke(in _Target, in _BAITRef, in _BANSRef);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_AdjustTransformBySpline bANS_AdjustTransformBySpline = GCHelper.Find<b1.BANS_AdjustTransformBySpline>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_AdjustTransformBySpline.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_AdjustTransformBySpline bANS_AdjustTransformBySpline = GCHelper.Find<b1.BANS_AdjustTransformBySpline>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_AdjustTransformBySpline.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_AdjustTransformBySpline bANS_AdjustTransformBySpline = GCHelper.Find<b1.BANS_AdjustTransformBySpline>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_AdjustTransformBySpline.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_AdjustTransformBySpline");
		NativeReflection.GetPropertyRef(ref bShowDebug_PropertyAddress, intPtr, "bShowDebug");
		bShowDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowDebug");
		bShowDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowDebug", Classes.FBoolProperty);
		SplineGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineGuid");
		SplineGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref RotateType_PropertyAddress, intPtr, "RotateType");
		RotateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateType");
		RotateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateType", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_AdjustTransformBySpline:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_AdjustTransformBySpline()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_AdjustTransformBySpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_AdjustTransformBySpline));
	}
}
