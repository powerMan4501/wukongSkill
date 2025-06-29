using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Calc AM Scale")]
[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale")]
internal class BANS_GSCalcAMScale : BANS_GSBase
{
	private static bool AMScaleAxis_IsValid;

	private static int AMScaleAxis_Offset;

	private static FFieldAddress AMScaleAxis_PropertyAddress;

	private static bool AMScaleType_IsValid;

	private static int AMScaleType_Offset;

	private static FFieldAddress AMScaleType_PropertyAddress;

	private static bool AMScaleMinRate_IsValid;

	private static int AMScaleMinRate_Offset;

	private static bool AMScaleMaxRate_IsValid;

	private static int AMScaleMaxRate_Offset;

	private static bool AMScaleMoveOffset_IsValid;

	private static int AMScaleMoveOffset_Offset;

	private static bool AMScaleMoveOffsetZ_IsValid;

	private static int AMScaleMoveOffsetZ_Offset;

	private static bool PureScaleValue_IsValid;

	private static int PureScaleValue_Offset;

	private static bool CachedDataID_IsValid;

	private static int CachedDataID_Offset;

	private static bool LandingTraceLength_IsValid;

	private static int LandingTraceLength_Offset;

	private static bool AttackRangeLimit_IsValid;

	private static int AttackRangeLimit_Offset;

	private static FFieldAddress AttackRangeLimit_PropertyAddress;

	private static bool DebugMode_IsValid;

	private static int DebugMode_Offset;

	private static FFieldAddress DebugMode_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool GSAllowCrossSection_IsValid;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[DisplayName("缩放轴类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleAxis")]
	public EAMScaleRateAxis AMScaleAxis
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleAxis");
				return EAMScaleRateAxis.AllByScaleRateAxisX;
			}
			return EnumMarshaler<EAMScaleRateAxis>.FromNative(IntPtr.Add(base.Address, AMScaleAxis_Offset), 0, AMScaleAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleAxis");
			}
			else
			{
				EnumMarshaler<EAMScaleRateAxis>.ToNative(IntPtr.Add(base.Address, AMScaleAxis_Offset), 0, AMScaleAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AMScaleAxis != EAMScaleRateAxis::AxisZLanding")]
	[DisplayName("缩放目标类型")]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleType")]
	public EAMScaleType AMScaleType
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleType");
				return EAMScaleType.ScaleForTarget;
			}
			return EnumMarshaler<EAMScaleType>.FromNative(IntPtr.Add(base.Address, AMScaleType_Offset), 0, AMScaleType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleType");
			}
			else
			{
				EnumMarshaler<EAMScaleType>.ToNative(IntPtr.Add(base.Address, AMScaleType_Offset), 0, AMScaleType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::ScaleForTarget || AMScaleType == AMScaleType::UseSkillBaseTarget")]
	[Tooltip("less than 0 or 0 means Use SkillSDesc MinRate")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMinRate")]
	public float AMScaleMinRate
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleMinRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMinRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMScaleMinRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleMinRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMinRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMScaleMinRate_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::ScaleForTarget || AMScaleType == AMScaleType::UseSkillBaseTarget")]
	[Tooltip("less than 0 or 0 means Use SkillSDesc MaxRate")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMaxRate")]
	public float AMScaleMaxRate
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleMaxRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMaxRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMScaleMaxRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleMaxRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMaxRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMScaleMaxRate_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::ScaleForTarget || AMScaleType == AMScaleType::UseSkillBaseTarget")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffset")]
	public float AMScaleMoveOffset
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleMoveOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMScaleMoveOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleMoveOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMScaleMoveOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::ScaleForTarget || AMScaleType == AMScaleType::UseSkillBaseTarget")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffsetZ")]
	public float AMScaleMoveOffsetZ
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleMoveOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffsetZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMScaleMoveOffsetZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleMoveOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AMScaleMoveOffsetZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMScaleMoveOffsetZ_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::UsePureScale")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("单纯缩放，缩放值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:PureScaleValue")]
	public float PureScaleValue
	{
		get
		{
			CheckDestroyed();
			if (!PureScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:PureScaleValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PureScaleValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PureScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:PureScaleValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PureScaleValue_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "AMScaleType == AMScaleType::ScaleForCachedPoint")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("缓存的点集ID")]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:CachedDataID")]
	public int CachedDataID
	{
		get
		{
			CheckDestroyed();
			if (!CachedDataID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:CachedDataID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CachedDataID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CachedDataID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:CachedDataID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CachedDataID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AMScaleAxis == EAMScaleRateAxis::AxisZLanding")]
	[DisplayName("检测地面最大距离")]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:LandingTraceLength")]
	public float LandingTraceLength
	{
		get
		{
			CheckDestroyed();
			if (!LandingTraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:LandingTraceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LandingTraceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandingTraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:LandingTraceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LandingTraceLength_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("若该技能存在于PlayerSkillCtrl表中，当目标距离大于表中配置的攻击距离时，是否禁用AMScale")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("超出攻击距离是否禁用")]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:AttackRangeLimit")]
	public bool AttackRangeLimit
	{
		get
		{
			CheckDestroyed();
			if (!AttackRangeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AttackRangeLimit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttackRangeLimit_Offset), 0, AttackRangeLimit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttackRangeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:AttackRangeLimit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttackRangeLimit_Offset), 0, AttackRangeLimit_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("开启Debug模式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:DebugMode")]
	public bool DebugMode
	{
		get
		{
			CheckDestroyed();
			if (!DebugMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:DebugMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugMode_Offset), 0, DebugMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCalcAMScale:DebugMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugMode_Offset), 0, DebugMode_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.CalcAMScale;
		AMScaleType = EAMScaleType.ScaleForTarget;
		AMScaleAxis = EAMScaleRateAxis.AllByScaleRateAxisX;
		AMScaleMaxRate = 0f;
		AMScaleMinRate = 0f;
		AMScaleMoveOffset = 0f;
	}

	public EGsEnAnimNS GetEnAnimNs()
	{
		return base.AnimNSType;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetAMScaleRateByPosMultiCast.Invoke(AMScaleType, AMScaleAxis, LandingTraceLength, PureScaleValue, CachedDataID, AttackRangeLimit, DebugMode, TotalDuration, NotifyParam.NotifyBeginTime, NotifyParam.NotifyEndTime, AMScaleMinRate, AMScaleMaxRate, AMScaleMoveOffset, AMScaleMoveOffsetZ);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCalcAMScale:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		if (!(actor == null))
		{
			BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
			if (bGUCharacterCS != null && !bGUCharacterCS.IsPlayingRootMotion())
			{
				BGW_ValiDateMgr.Get(actor.World).ShowValidateWindow("Montage（" + GetOuter().GetPathName() + "）, 没有开启RootMotion，不能计算位移缩放");
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCalcAMScale:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCalcAMScale bANS_GSCalcAMScale = GCHelper.Find<b1.BANS_GSCalcAMScale>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCalcAMScale.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCalcAMScale:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCalcAMScale bANS_GSCalcAMScale = GCHelper.Find<b1.BANS_GSCalcAMScale>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bANS_GSCalcAMScale.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCalcAMScale:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCalcAMScale bANS_GSCalcAMScale = GCHelper.Find<b1.BANS_GSCalcAMScale>(obj);
		bool value = bANS_GSCalcAMScale.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCalcAMScale");
		NativeReflection.GetPropertyRef(ref AMScaleAxis_PropertyAddress, intPtr, "AMScaleAxis");
		AMScaleAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleAxis");
		AMScaleAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleAxis", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AMScaleType_PropertyAddress, intPtr, "AMScaleType");
		AMScaleType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleType");
		AMScaleType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleType", Classes.FEnumProperty);
		AMScaleMinRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleMinRate");
		AMScaleMinRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleMinRate", Classes.FFloatProperty);
		AMScaleMaxRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleMaxRate");
		AMScaleMaxRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleMaxRate", Classes.FFloatProperty);
		AMScaleMoveOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleMoveOffset");
		AMScaleMoveOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleMoveOffset", Classes.FFloatProperty);
		AMScaleMoveOffsetZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMScaleMoveOffsetZ");
		AMScaleMoveOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMScaleMoveOffsetZ", Classes.FFloatProperty);
		PureScaleValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "PureScaleValue");
		PureScaleValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PureScaleValue", Classes.FFloatProperty);
		CachedDataID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CachedDataID");
		CachedDataID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CachedDataID", Classes.FIntProperty);
		LandingTraceLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandingTraceLength");
		LandingTraceLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandingTraceLength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AttackRangeLimit_PropertyAddress, intPtr, "AttackRangeLimit");
		AttackRangeLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackRangeLimit");
		AttackRangeLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackRangeLimit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugMode_PropertyAddress, intPtr, "DebugMode");
		DebugMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugMode");
		DebugMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugMode", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCalcAMScale:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCalcAMScale:GSValidateInputCS", GSValidateInputCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCalcAMScale:GSAllowCrossSection", GSAllowCrossSection_IsValid);
	}

	static BANS_GSCalcAMScale()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCalcAMScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCalcAMScale));
	}
}
