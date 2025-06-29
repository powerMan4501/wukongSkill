using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS PlayRotAMByCamRotInAM")]
[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM")]
internal class BANS_PlayRotAMByCamRotInAM : BANS_GSBase
{
	private static bool RotTypeInSmallAngle_IsValid;

	private static int RotTypeInSmallAngle_Offset;

	private static FFieldAddress RotTypeInSmallAngle_PropertyAddress;

	private static bool RotTypeInLargeAngle_IsValid;

	private static int RotTypeInLargeAngle_Offset;

	private static FFieldAddress RotTypeInLargeAngle_PropertyAddress;

	private static bool AngleThreshold_IsValid;

	private static int AngleThreshold_Offset;

	private static bool TurnSpd_IsValid;

	private static int TurnSpd_Offset;

	private static bool RotateWithCamSpeed_IsValid;

	private static int RotateWithCamSpeed_Offset;

	private static bool TurnRightAM_IsValid;

	private static int TurnRightAM_Offset;

	private static bool TurnLeftAM_IsValid;

	private static int TurnLeftAM_Offset;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

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

	[DisplayName("小角度旋转类型")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInSmallAngle")]
	public ERotTypeInSmallAngle RotTypeInSmallAngle
	{
		get
		{
			CheckDestroyed();
			if (!RotTypeInSmallAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInSmallAngle");
				return ERotTypeInSmallAngle.None;
			}
			return EnumMarshaler<ERotTypeInSmallAngle>.FromNative(IntPtr.Add(base.Address, RotTypeInSmallAngle_Offset), 0, RotTypeInSmallAngle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotTypeInSmallAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInSmallAngle");
			}
			else
			{
				EnumMarshaler<ERotTypeInSmallAngle>.ToNative(IntPtr.Add(base.Address, RotTypeInSmallAngle_Offset), 0, RotTypeInSmallAngle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("大角度旋转类型")]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInLargeAngle")]
	public ERotTypeInLargeAngle RotTypeInLargeAngle
	{
		get
		{
			CheckDestroyed();
			if (!RotTypeInLargeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInLargeAngle");
				return ERotTypeInLargeAngle.None;
			}
			return EnumMarshaler<ERotTypeInLargeAngle>.FromNative(IntPtr.Add(base.Address, RotTypeInLargeAngle_Offset), 0, RotTypeInLargeAngle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotTypeInLargeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotTypeInLargeAngle");
			}
			else
			{
				EnumMarshaler<ERotTypeInLargeAngle>.ToNative(IntPtr.Add(base.Address, RotTypeInLargeAngle_Offset), 0, RotTypeInLargeAngle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("角度阈值")]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:AngleThreshold")]
	public float AngleThreshold
	{
		get
		{
			CheckDestroyed();
			if (!AngleThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:AngleThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:AngleThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleThreshold_Offset), value);
			}
		}
	}

	[DisplayName("大于等于阈值的旋转速度")]
	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnSpd")]
	public float TurnSpd
	{
		get
		{
			CheckDestroyed();
			if (!TurnSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnSpd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurnSpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnSpd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurnSpd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[DisplayName("小于阈值的旋转速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotateWithCamSpeed")]
	public float RotateWithCamSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RotateWithCamSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotateWithCamSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateWithCamSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateWithCamSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:RotateWithCamSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateWithCamSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("右转动画")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnRightAM")]
	public UAnimMontage TurnRightAM
	{
		get
		{
			CheckDestroyed();
			if (!TurnRightAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnRightAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, TurnRightAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnRightAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnRightAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, TurnRightAM_Offset), value);
			}
		}
	}

	[DisplayName("左转动画")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnLeftAM")]
	public UAnimMontage TurnLeftAM
	{
		get
		{
			CheckDestroyed();
			if (!TurnLeftAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnLeftAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, TurnLeftAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnLeftAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:TurnLeftAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, TurnLeftAM_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.CanUseQueuedType = true;
		RotTypeInSmallAngle = ERotTypeInSmallAngle.SimpleRotate;
		RotTypeInLargeAngle = ERotTypeInLargeAngle.AMMatryoshka;
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnPlayRotAMByCamRotBegin.Invoke(TurnRightAM, TurnLeftAM, BlendInTime, BlendOutTime, AngleThreshold, TurnSpd, RotateWithCamSpeed, RotTypeInSmallAngle, RotTypeInLargeAngle);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnPlayRotAMByCamRotEnded.Invoke();
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayRotAMByCamRotInAM bANS_PlayRotAMByCamRotInAM = GCHelper.Find<b1.BANS_PlayRotAMByCamRotInAM>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_PlayRotAMByCamRotInAM.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayRotAMByCamRotInAM bANS_PlayRotAMByCamRotInAM = GCHelper.Find<b1.BANS_PlayRotAMByCamRotInAM>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_PlayRotAMByCamRotInAM.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayRotAMByCamRotInAM bANS_PlayRotAMByCamRotInAM = GCHelper.Find<b1.BANS_PlayRotAMByCamRotInAM>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_PlayRotAMByCamRotInAM.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM");
		NativeReflection.GetPropertyRef(ref RotTypeInSmallAngle_PropertyAddress, intPtr, "RotTypeInSmallAngle");
		RotTypeInSmallAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotTypeInSmallAngle");
		RotTypeInSmallAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotTypeInSmallAngle", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RotTypeInLargeAngle_PropertyAddress, intPtr, "RotTypeInLargeAngle");
		RotTypeInLargeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotTypeInLargeAngle");
		RotTypeInLargeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotTypeInLargeAngle", Classes.FEnumProperty);
		AngleThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleThreshold");
		AngleThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleThreshold", Classes.FFloatProperty);
		TurnSpd_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnSpd");
		TurnSpd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnSpd", Classes.FFloatProperty);
		RotateWithCamSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateWithCamSpeed");
		RotateWithCamSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateWithCamSpeed", Classes.FFloatProperty);
		TurnRightAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnRightAM");
		TurnRightAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnRightAM", Classes.FObjectProperty);
		TurnLeftAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnLeftAM");
		TurnLeftAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnLeftAM", Classes.FObjectProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayRotAMByCamRotInAM:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_PlayRotAMByCamRotInAM()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_PlayRotAMByCamRotInAM)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_PlayRotAMByCamRotInAM));
	}
}
