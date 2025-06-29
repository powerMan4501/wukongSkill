using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong")]
internal class BUAnim_PostProcess_Wukong : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool Alpha_FBIK_StandBar_IsValid;

	private static int Alpha_FBIK_StandBar_Offset;

	private static bool SlowIK_Alpha_IsValid;

	private static int SlowIK_Alpha_Offset;

	private static bool SlowIK_Enable_IsValid;

	private static int SlowIK_Enable_Offset;

	private static FFieldAddress SlowIK_Enable_PropertyAddress;

	private static bool SlowIKType_IsValid;

	private static int SlowIKType_Offset;

	private static FFieldAddress SlowIKType_PropertyAddress;

	private static bool LockTransform_Local_IsValid;

	private static int LockTransform_Local_Offset;

	private static bool Relative_l_in_r_IsValid;

	private static int Relative_l_in_r_Offset;

	private static bool Relative_r_in_l_IsValid;

	private static int Relative_r_in_l_Offset;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Alpha_FBIK_StandBar")]
	public float Alpha_FBIK_StandBar
	{
		get
		{
			CheckDestroyed();
			if (!Alpha_FBIK_StandBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Alpha_FBIK_StandBar");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Alpha_FBIK_StandBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Alpha_FBIK_StandBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Alpha_FBIK_StandBar");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Alpha_FBIK_StandBar_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("SlowIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Alpha")]
	public float SlowIK_Alpha
	{
		get
		{
			CheckDestroyed();
			if (!SlowIK_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Alpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlowIK_Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlowIK_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Alpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlowIK_Alpha_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SlowIK")]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Enable")]
	public bool SlowIK_Enable
	{
		get
		{
			CheckDestroyed();
			if (!SlowIK_Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Enable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SlowIK_Enable_Offset), 0, SlowIK_Enable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SlowIK_Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIK_Enable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SlowIK_Enable_Offset), 0, SlowIK_Enable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("SlowIK")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIKType")]
	public ESlowIKType SlowIKType
	{
		get
		{
			CheckDestroyed();
			if (!SlowIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIKType");
				return ESlowIKType.None;
			}
			return EnumMarshaler<ESlowIKType>.FromNative(IntPtr.Add(base.Address, SlowIKType_Offset), 0, SlowIKType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SlowIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:SlowIKType");
			}
			else
			{
				EnumMarshaler<ESlowIKType>.ToNative(IntPtr.Add(base.Address, SlowIKType_Offset), 0, SlowIKType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SlowIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:LockTransform_Local")]
	public FTransform LockTransform_Local
	{
		get
		{
			CheckDestroyed();
			if (!LockTransform_Local_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:LockTransform_Local");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, LockTransform_Local_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTransform_Local_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:LockTransform_Local");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, LockTransform_Local_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SlowIK")]
	[DisplayName("Slow期间Ik_hand_l相对于r的位置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_l_in_r")]
	public FTransform Relative_l_in_r
	{
		get
		{
			CheckDestroyed();
			if (!Relative_l_in_r_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_l_in_r");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Relative_l_in_r_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Relative_l_in_r_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_l_in_r");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Relative_l_in_r_Offset), value);
			}
		}
	}

	[Category("SlowIK")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Slow期间Ik_hand_r相对于l的位置")]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_r_in_l")]
	public FTransform Relative_r_in_l
	{
		get
		{
			CheckDestroyed();
			if (!Relative_r_in_l_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_r_in_l");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Relative_r_in_l_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Relative_r_in_l_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess_Wukong:Relative_r_in_l");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Relative_r_in_l_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.BlueprintInitializeAnimation_Implementation();
	}

	public void InitData()
	{
		Alpha_FBIK_StandBar = 0f;
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		base.BlueprintUpdateAnimation_Implementation(DeltaTimeX);
		BGUCharacterCS bGUCharacterCS = GetOwningActor() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			IBUC_ABPSlowIKData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSlowIKData, BUC_ABPSlowIKData>(bGUCharacterCS);
			if (unPersistentReadOnlyData != null)
			{
				SlowIK_Alpha = unPersistentReadOnlyData.Alpha;
				SlowIK_Enable = unPersistentReadOnlyData.Enable;
				SlowIKType = unPersistentReadOnlyData.SlowIKType;
				LockTransform_Local = unPersistentReadOnlyData.LockTransform_Local;
				Relative_l_in_r = unPersistentReadOnlyData.Relative_l_in_r;
				Relative_r_in_l = unPersistentReadOnlyData.Relative_r_in_l;
			}
		}
	}

	public void OnEntityInitFinish()
	{
		InitData();
		AttachEvent();
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
		UnAttachEvent();
	}

	private void AttachEvent()
	{
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		if (bUC_ABPEventCollection != null)
		{
			bUC_ABPEventCollection.Evt_SetValue_Alpha_FBIK_StandBar = (BUC_ABPEventCollection.Del_Void_Float)Delegate.Combine(bUC_ABPEventCollection.Evt_SetValue_Alpha_FBIK_StandBar, new BUC_ABPEventCollection.Del_Void_Float(SetValue_Alpha_FBIK_StandBar));
		}
	}

	private void UnAttachEvent()
	{
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		if (bUC_ABPEventCollection != null)
		{
			bUC_ABPEventCollection.Evt_SetValue_Alpha_FBIK_StandBar = (BUC_ABPEventCollection.Del_Void_Float)Delegate.Remove(bUC_ABPEventCollection.Evt_SetValue_Alpha_FBIK_StandBar, new BUC_ABPEventCollection.Del_Void_Float(SetValue_Alpha_FBIK_StandBar));
		}
	}

	private void SetValue_Alpha_FBIK_StandBar(float Alpha)
	{
		Alpha_FBIK_StandBar = Alpha;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess_Wukong bUAnim_PostProcess_Wukong = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess_Wukong>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnim_PostProcess_Wukong.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess_Wukong bUAnim_PostProcess_Wukong = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess_Wukong>(obj);
		bUAnim_PostProcess_Wukong.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnim_PostProcess_Wukong");
		Alpha_FBIK_StandBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "Alpha_FBIK_StandBar");
		Alpha_FBIK_StandBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Alpha_FBIK_StandBar", Classes.FFloatProperty);
		SlowIK_Alpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowIK_Alpha");
		SlowIK_Alpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowIK_Alpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SlowIK_Enable_PropertyAddress, intPtr, "SlowIK_Enable");
		SlowIK_Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowIK_Enable");
		SlowIK_Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowIK_Enable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SlowIKType_PropertyAddress, intPtr, "SlowIKType");
		SlowIKType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlowIKType");
		SlowIKType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlowIKType", Classes.FEnumProperty);
		LockTransform_Local_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTransform_Local");
		LockTransform_Local_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTransform_Local", Classes.FStructProperty);
		Relative_l_in_r_Offset = NativeReflection.GetPropertyOffset(intPtr, "Relative_l_in_r");
		Relative_l_in_r_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Relative_l_in_r", Classes.FStructProperty);
		Relative_r_in_l_Offset = NativeReflection.GetPropertyOffset(intPtr, "Relative_r_in_l");
		Relative_r_in_l_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Relative_r_in_l", Classes.FStructProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess_Wukong:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnim_PostProcess_Wukong()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BUAnim_PostProcess_Wukong)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BUAnim_PostProcess_Wukong));
	}
}
