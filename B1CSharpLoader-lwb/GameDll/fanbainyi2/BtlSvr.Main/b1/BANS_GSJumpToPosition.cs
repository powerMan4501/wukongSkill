using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Jump To Position")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition")]
internal class BANS_GSJumpToPosition : BANS_GSBase
{
	private static bool JumpTarget_IsValid;

	private static int JumpTarget_Offset;

	private static FFieldAddress JumpTarget_PropertyAddress;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool TargetAddCapsuleHalfHeight_IsValid;

	private static int TargetAddCapsuleHalfHeight_Offset;

	private static FFieldAddress TargetAddCapsuleHalfHeight_PropertyAddress;

	private static bool CalibrationTrans_IsValid;

	private static int CalibrationTrans_Offset;

	private static FFieldAddress CalibrationTrans_PropertyAddress;

	private static bool bResetSceneItemOnFinish_IsValid;

	private static int bResetSceneItemOnFinish_Offset;

	private static FFieldAddress bResetSceneItemOnFinish_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标点类型")]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:JumpTarget")]
	public EBGUJumpTargetType JumpTarget
	{
		get
		{
			CheckDestroyed();
			if (!JumpTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:JumpTarget");
				return EBGUJumpTargetType.CurrentTarget;
			}
			return EnumMarshaler<EBGUJumpTargetType>.FromNative(IntPtr.Add(base.Address, JumpTarget_Offset), 0, JumpTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!JumpTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:JumpTarget");
			}
			else
			{
				EnumMarshaler<EBGUJumpTargetType>.ToNative(IntPtr.Add(base.Address, JumpTarget_Offset), 0, JumpTarget_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("抛物线最高点相对初始位置高度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抛物线最高点相对初始位置高度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:Height")]
	public float Height
	{
		get
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:Height");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Height_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:Height");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Height_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标位置Z轴是否加上自身胶囊体高度")]
	[Tooltip("目标位置Z轴是否加上自身胶囊体高度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:TargetAddCapsuleHalfHeight")]
	public bool TargetAddCapsuleHalfHeight
	{
		get
		{
			CheckDestroyed();
			if (!TargetAddCapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:TargetAddCapsuleHalfHeight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TargetAddCapsuleHalfHeight_Offset), 0, TargetAddCapsuleHalfHeight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetAddCapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:TargetAddCapsuleHalfHeight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TargetAddCapsuleHalfHeight_Offset), 0, TargetAddCapsuleHalfHeight_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("移动完成后，是否强制矫正自身Transform到目标Transform")]
	[DisplayName("移动完成后强制矫正Transform")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:CalibrationTrans")]
	public bool CalibrationTrans
	{
		get
		{
			CheckDestroyed();
			if (!CalibrationTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:CalibrationTrans");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CalibrationTrans_Offset), 0, CalibrationTrans_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CalibrationTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:CalibrationTrans");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CalibrationTrans_Offset), 0, CalibrationTrans_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移动完成后清空SceneItem缓存")]
	[Tooltip("移动完成后，是否清空SceneItem缓存")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:bResetSceneItemOnFinish")]
	public bool bResetSceneItemOnFinish
	{
		get
		{
			CheckDestroyed();
			if (!bResetSceneItemOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:bResetSceneItemOnFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bResetSceneItemOnFinish_Offset), 0, bResetSceneItemOnFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bResetSceneItemOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToPosition:bResetSceneItemOnFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bResetSceneItemOnFinish_Offset), 0, bResetSceneItemOnFinish_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		JumpTarget = EBGUJumpTargetType.CurrentTarget;
		Height = 0f;
		TargetAddCapsuleHalfHeight = true;
		CalibrationTrans = false;
		bResetSceneItemOnFinish = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSJumpToPosition:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_TriggerJumpToPosition.Invoke(JumpTarget, Height, TargetAddCapsuleHalfHeight, CalibrationTrans, bResetSceneItemOnFinish, TotalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSJumpToPosition:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSJumpToPosition bANS_GSJumpToPosition = GCHelper.Find<b1.BANS_GSJumpToPosition>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSJumpToPosition.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSJumpToPosition");
		NativeReflection.GetPropertyRef(ref JumpTarget_PropertyAddress, intPtr, "JumpTarget");
		JumpTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpTarget");
		JumpTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpTarget", Classes.FEnumProperty);
		Height_Offset = NativeReflection.GetPropertyOffset(intPtr, "Height");
		Height_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Height", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TargetAddCapsuleHalfHeight_PropertyAddress, intPtr, "TargetAddCapsuleHalfHeight");
		TargetAddCapsuleHalfHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetAddCapsuleHalfHeight");
		TargetAddCapsuleHalfHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetAddCapsuleHalfHeight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CalibrationTrans_PropertyAddress, intPtr, "CalibrationTrans");
		CalibrationTrans_Offset = NativeReflection.GetPropertyOffset(intPtr, "CalibrationTrans");
		CalibrationTrans_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CalibrationTrans", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bResetSceneItemOnFinish_PropertyAddress, intPtr, "bResetSceneItemOnFinish");
		bResetSceneItemOnFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bResetSceneItemOnFinish");
		bResetSceneItemOnFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bResetSceneItemOnFinish", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSJumpToPosition:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSJumpToPosition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSJumpToPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSJumpToPosition));
	}
}
