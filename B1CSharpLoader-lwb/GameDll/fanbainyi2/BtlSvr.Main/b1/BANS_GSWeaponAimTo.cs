using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS BoneAimTo")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo")]
internal class BANS_GSWeaponAimTo : BANS_GSBase
{
	private static bool WeaponBoneName_IsValid;

	private static int WeaponBoneName_Offset;

	private static bool AimAxis_IsValid;

	private static int AimAxis_Offset;

	private static bool AimToType_IsValid;

	private static int AimToType_Offset;

	private static FFieldAddress AimToType_PropertyAddress;

	private static bool TargetSocketName_IsValid;

	private static int TargetSocketName_Offset;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool TraceSpd_IsValid;

	private static int TraceSpd_Offset;

	private static bool DegreesConstraint_IsValid;

	private static int DegreesConstraint_Offset;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

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
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:WeaponBoneName")]
	public FName WeaponBoneName
	{
		get
		{
			CheckDestroyed();
			if (!WeaponBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:WeaponBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WeaponBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:WeaponBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WeaponBoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:AimAxis")]
	public FVector AimAxis
	{
		get
		{
			CheckDestroyed();
			if (!AimAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:AimAxis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, AimAxis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:AimAxis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, AimAxis_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:AimToType")]
	public EAimToType AimToType
	{
		get
		{
			CheckDestroyed();
			if (!AimToType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:AimToType");
				return EAimToType.None;
			}
			return EnumMarshaler<EAimToType>.FromNative(IntPtr.Add(base.Address, AimToType_Offset), 0, AimToType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AimToType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:AimToType");
			}
			else
			{
				EnumMarshaler<EAimToType>.ToNative(IntPtr.Add(base.Address, AimToType_Offset), 0, AimToType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[Tooltip("None: 先看有没有部位锁定，没有的话取目标胶囊体中心点位置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:TargetSocketName")]
	public FName TargetSocketName
	{
		get
		{
			CheckDestroyed();
			if (!TargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:TargetSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:TargetSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	[DisplayName("追踪速度")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:TraceSpd")]
	public float TraceSpd
	{
		get
		{
			CheckDestroyed();
			if (!TraceSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:TraceSpd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceSpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:TraceSpd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceSpd_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("旋转角度约束")]
	[Tooltip("填0或者180即是不约束")]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:DegreesConstraint")]
	public float DegreesConstraint
	{
		get
		{
			CheckDestroyed();
			if (!DegreesConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:DegreesConstraint");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DegreesConstraint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DegreesConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:DegreesConstraint");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DegreesConstraint_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("开启当前瞄准点Debug")]
	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeaponAimTo:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AimToType = EAimToType.Target;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(aCharacter))
		{
			BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnAimToEnd.Invoke();
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			ACharacter aCharacter = NotifyParam.owner as ACharacter;
			if (!(aCharacter == null) && !(aCharacter.Mesh == null))
			{
				FAimToConfig aimToConfig = new FAimToConfig
				{
					bEnableDebug = EnableDebug,
					WeaponBoneName = WeaponBoneName,
					AimAxis = AimAxis,
					AimToType = AimToType,
					TargetSocketName = TargetSocketName,
					BlendInTime = BlendInTime,
					BlendOutTime = BlendOutTime,
					TraceSpd = TraceSpd,
					DegreesConstraint = DegreesConstraint,
					TotalTime = TotalDuration
				};
				BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnAimToBegin.Invoke(aimToConfig);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSWeaponAimTo bANS_GSWeaponAimTo = GCHelper.Find<b1.BANS_GSWeaponAimTo>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSWeaponAimTo.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSWeaponAimTo bANS_GSWeaponAimTo = GCHelper.Find<b1.BANS_GSWeaponAimTo>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSWeaponAimTo.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSWeaponAimTo");
		WeaponBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponBoneName");
		WeaponBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponBoneName", Classes.FNameProperty);
		AimAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimAxis");
		AimAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimAxis", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AimToType_PropertyAddress, intPtr, "AimToType");
		AimToType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimToType");
		AimToType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimToType", Classes.FEnumProperty);
		TargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSocketName");
		TargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSocketName", Classes.FNameProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		TraceSpd_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceSpd");
		TraceSpd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceSpd", Classes.FFloatProperty);
		DegreesConstraint_Offset = NativeReflection.GetPropertyOffset(intPtr, "DegreesConstraint");
		DegreesConstraint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DegreesConstraint", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSWeaponAimTo:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSWeaponAimTo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSWeaponAimTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSWeaponAimTo));
	}
}
