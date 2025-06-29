using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS SlowIK")]
[USharpPath("/Script/b1-Managed.BANS_GSSlowIK")]
internal class BANS_GSSlowIK : BANS_GSBase
{
	private static bool SlowIKType_IsValid;

	private static int SlowIKType_Offset;

	private static FFieldAddress SlowIKType_PropertyAddress;

	private static bool SlowTime_IsValid;

	private static int SlowTime_Offset;

	private static bool SlowTime_Crit_IsValid;

	private static int SlowTime_Crit_Offset;

	private static bool ProtectGap_IsValid;

	private static int ProtectGap_Offset;

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

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:SlowIKType")]
	public ESlowIKType SlowIKType
	{
		get
		{
			CheckDestroyed();
			if (!SlowIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowIKType");
				return ESlowIKType.None;
			}
			return EnumMarshaler<ESlowIKType>.FromNative(IntPtr.Add(base.Address, SlowIKType_Offset), 0, SlowIKType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SlowIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowIKType");
			}
			else
			{
				EnumMarshaler<ESlowIKType>.ToNative(IntPtr.Add(base.Address, SlowIKType_Offset), 0, SlowIKType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("缓慢时间")]
	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:SlowTime")]
	public float SlowTime
	{
		get
		{
			CheckDestroyed();
			if (!SlowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("缓慢时间_暴击")]
	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:SlowTime_Crit")]
	public float SlowTime_Crit
	{
		get
		{
			CheckDestroyed();
			if (!SlowTime_Crit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowTime_Crit");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlowTime_Crit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlowTime_Crit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:SlowTime_Crit");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlowTime_Crit_Offset), value);
			}
		}
	}

	[Tooltip("触发后开始计时，间隔内不再触发")]
	[DisplayName("频繁触发保护间隔")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:ProtectGap")]
	public float ProtectGap
	{
		get
		{
			CheckDestroyed();
			if (!ProtectGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:ProtectGap");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProtectGap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProtectGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowIK:ProtectGap");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProtectGap_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(aCharacter))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DisableSlowIK.Invoke();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			return;
		}
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetSlowIKConfig.Invoke(SlowIKType, SlowTime, SlowTime_Crit, ProtectGap);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSlowIK bANS_GSSlowIK = GCHelper.Find<b1.BANS_GSSlowIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSlowIK.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSlowIK bANS_GSSlowIK = GCHelper.Find<b1.BANS_GSSlowIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSlowIK.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSlowIK bANS_GSSlowIK = GCHelper.Find<b1.BANS_GSSlowIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSlowIK.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSlowIK");
		NativeReflection.GetPropertyRef(ref SlowIKType_PropertyAddress, intPtr, "SlowIKType");
		SlowIKType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowIKType");
		SlowIKType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowIKType", Classes.FEnumProperty);
		SlowTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowTime");
		SlowTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowTime", Classes.FFloatProperty);
		SlowTime_Crit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowTime_Crit");
		SlowTime_Crit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowTime_Crit", Classes.FFloatProperty);
		ProtectGap_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProtectGap");
		ProtectGap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProtectGap", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSlowIK:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSlowIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSlowIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSlowIK));
	}
}
