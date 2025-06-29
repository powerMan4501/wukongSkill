using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Spline Fly Move")]
[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove")]
internal class BAN_GSSplineFlyMove : BAN_GSBase
{
	private static bool bEnableSplineFlyMove_IsValid;

	private static int bEnableSplineFlyMove_Offset;

	private static FFieldAddress bEnableSplineFlyMove_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool TraceVelocityCameraSpeedRate_IsValid;

	private static int TraceVelocityCameraSpeedRate_Offset;

	private static bool SplineActorTag_IsValid;

	private static int SplineActorTag_Offset;

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
	[Category("Notify Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:bEnableSplineFlyMove")]
	public bool bEnableSplineFlyMove
	{
		get
		{
			CheckDestroyed();
			if (!bEnableSplineFlyMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:bEnableSplineFlyMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableSplineFlyMove_Offset), 0, bEnableSplineFlyMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableSplineFlyMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:bEnableSplineFlyMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableSplineFlyMove_Offset), 0, bEnableSplineFlyMove_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bEnableSplineFlyMove")]
	[Category("Notify Setting")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bEnableSplineFlyMove")]
	[Category("Notify Setting")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:TraceVelocityCameraSpeedRate")]
	public float TraceVelocityCameraSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!TraceVelocityCameraSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:TraceVelocityCameraSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceVelocityCameraSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceVelocityCameraSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:TraceVelocityCameraSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceVelocityCameraSpeedRate_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bEnableSplineFlyMove")]
	[Category("Notify Setting")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:SplineActorTag")]
	public FName SplineActorTag
	{
		get
		{
			CheckDestroyed();
			if (!SplineActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:SplineActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SplineActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSplineFlyMove:SplineActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SplineActorTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSplineFlyMove:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null || BUS_EventCollectionCS.Get(aCharacter) == null)
		{
			return;
		}
		if (bEnableSplineFlyMove)
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(aCharacter, UClass.GetClass<BGUSplineActor>(), SplineActorTag, out var OutActors);
			if (OutActors.Count != 0)
			{
				BGUFuncLibForMove.BGUSplineFlyMove(bEnableSplineFlyMove: true, aCharacter, OutActors[0] as BGUSplineActor, default(FGSSplineFlyMoveInfo), SpeedRateType, TraceVelocityCameraSpeedRate);
			}
		}
		else
		{
			BGUFuncLibForMove.BGUSplineFlyMove(bEnableSplineFlyMove: false, aCharacter, null, default(FGSSplineFlyMoveInfo));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSplineFlyMove:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSplineFlyMove bAN_GSSplineFlyMove = GCHelper.Find<b1.BAN_GSSplineFlyMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSplineFlyMove.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSplineFlyMove:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSplineFlyMove bAN_GSSplineFlyMove = GCHelper.Find<b1.BAN_GSSplineFlyMove>(obj);
		bool value = bAN_GSSplineFlyMove.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSplineFlyMove");
		NativeReflection.GetPropertyRef(ref bEnableSplineFlyMove_PropertyAddress, intPtr, "bEnableSplineFlyMove");
		bEnableSplineFlyMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSplineFlyMove");
		bEnableSplineFlyMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSplineFlyMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, intPtr, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateType", Classes.FEnumProperty);
		TraceVelocityCameraSpeedRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceVelocityCameraSpeedRate");
		TraceVelocityCameraSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceVelocityCameraSpeedRate", Classes.FFloatProperty);
		SplineActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActorTag");
		SplineActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActorTag", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSplineFlyMove:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSplineFlyMove:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSSplineFlyMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSplineFlyMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSplineFlyMove));
	}
}
