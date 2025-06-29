using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS PoleDrink")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink")]
internal class BANS_GSPoleDrink : BANS_GSBase
{
	private static bool Condition_IsValid;

	private static int Condition_Offset;

	private static bool DrinkHPBottomSuccessAM_IsValid;

	private static int DrinkHPBottomSuccessAM_Offset;

	private static bool DrinkHPBottomFailedAM_IsValid;

	private static int DrinkHPBottomFailedAM_Offset;

	private static bool UseItemAMMapping_IsValid;

	private static int UseItemAMMapping_Offset;

	private static FFieldAddress UseItemAMMapping_PropertyAddress;

	private TMapReadWriteMarshaler<int, UAnimMontage> UseItemAMMapping_Marshaler;

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

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("可触发的前提条件")]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:Condition")]
	public FPoleDrinkCondition Condition
	{
		get
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:Condition");
				return default(FPoleDrinkCondition);
			}
			return FPoleDrinkCondition.FromNative(IntPtr.Add(base.Address, Condition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:Condition");
			}
			else
			{
				FPoleDrinkCondition.ToNative(IntPtr.Add(base.Address, Condition_Offset), value);
			}
		}
	}

	[DisplayName("喝药成功动画")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomSuccessAM")]
	public UAnimMontage DrinkHPBottomSuccessAM
	{
		get
		{
			CheckDestroyed();
			if (!DrinkHPBottomSuccessAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomSuccessAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, DrinkHPBottomSuccessAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrinkHPBottomSuccessAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomSuccessAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, DrinkHPBottomSuccessAM_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("喝药失败动画")]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomFailedAM")]
	public UAnimMontage DrinkHPBottomFailedAM
	{
		get
		{
			CheckDestroyed();
			if (!DrinkHPBottomFailedAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomFailedAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, DrinkHPBottomFailedAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrinkHPBottomFailedAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:DrinkHPBottomFailedAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, DrinkHPBottomFailedAM_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("使用道具动画映射")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:UseItemAMMapping")]
	public TMapReadWrite<int, UAnimMontage> UseItemAMMapping
	{
		get
		{
			CheckDestroyed();
			if (!UseItemAMMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:UseItemAMMapping");
				return null;
			}
			if (UseItemAMMapping_Marshaler == null)
			{
				UseItemAMMapping_Marshaler = new TMapReadWriteMarshaler<int, UAnimMontage>(1, UseItemAMMapping_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return UseItemAMMapping_Marshaler.FromNative(IntPtr.Add(base.Address, UseItemAMMapping_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPoleDrink:BlendOutTime");
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
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null && PocessCondition(bGUCharacterCS))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_PoleDrinkStateBegin.Invoke(DrinkHPBottomSuccessAM, DrinkHPBottomFailedAM, UseItemAMMapping);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_PoleDrinkStateEnd.Invoke();
			}
		}
	}

	private bool PocessCondition(BGUCharacterCS Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		if (Condition.ConditionType == EPoleDrinkConditionType.HasTalent)
		{
			if (Condition.TalentID == 0)
			{
				return true;
			}
			return BGUFunctionLibraryCS.BGUHasTalentByID(Unit, Condition.TalentID);
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPoleDrink bANS_GSPoleDrink = GCHelper.Find<b1.BANS_GSPoleDrink>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPoleDrink.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPoleDrink bANS_GSPoleDrink = GCHelper.Find<b1.BANS_GSPoleDrink>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPoleDrink.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPoleDrink");
		Condition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condition");
		Condition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condition", Classes.FStructProperty);
		DrinkHPBottomSuccessAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrinkHPBottomSuccessAM");
		DrinkHPBottomSuccessAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrinkHPBottomSuccessAM", Classes.FObjectProperty);
		DrinkHPBottomFailedAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrinkHPBottomFailedAM");
		DrinkHPBottomFailedAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrinkHPBottomFailedAM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseItemAMMapping_PropertyAddress, intPtr, "UseItemAMMapping");
		UseItemAMMapping_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseItemAMMapping");
		UseItemAMMapping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseItemAMMapping", Classes.FMapProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPoleDrink:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSPoleDrink()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPoleDrink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPoleDrink));
	}
}
