using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Attack Offset")]
[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset")]
internal class BANS_GSAttackRangeOffset : BANS_GSBase
{
	private float Timer;

	private float Alpha;

	private float _TotalDuration;

	private bool Active;

	private static bool EnablePitch_IsValid;

	private static int EnablePitch_Offset;

	private static FFieldAddress EnablePitch_PropertyAddress;

	private static bool PitchMin_IsValid;

	private static int PitchMin_Offset;

	private static bool PitchMax_IsValid;

	private static int PitchMax_Offset;

	private static bool AimSocketName_IsValid;

	private static int AimSocketName_Offset;

	private static bool AnimSequence_IsValid;

	private static int AnimSequence_Offset;

	private static bool BaseAnimSequencePosition_IsValid;

	private static int BaseAnimSequencePosition_Offset;

	private static bool BasePosition_Local_IsValid;

	private static int BasePosition_Local_Offset;

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

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:EnablePitch")]
	public bool EnablePitch
	{
		get
		{
			CheckDestroyed();
			if (!EnablePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:EnablePitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePitch_Offset), 0, EnablePitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:EnablePitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePitch_Offset), 0, EnablePitch_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnablePitch")]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMin")]
	public float PitchMin
	{
		get
		{
			CheckDestroyed();
			if (!PitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UMeta(MDProp.EditCondition, "EnablePitch")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMax")]
	public float PitchMax
	{
		get
		{
			CheckDestroyed();
			if (!PitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:PitchMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:AimSocketName")]
	public FName AimSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AimSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:AimSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AimSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:AimSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AimSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:AnimSequence")]
	public UAnimSequence AnimSequence
	{
		get
		{
			CheckDestroyed();
			if (!AnimSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:AnimSequence");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:AnimSequence");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimSequence_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:BaseAnimSequencePosition")]
	public float BaseAnimSequencePosition
	{
		get
		{
			CheckDestroyed();
			if (!BaseAnimSequencePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BaseAnimSequencePosition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BaseAnimSequencePosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseAnimSequencePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BaseAnimSequencePosition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BaseAnimSequencePosition_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:BasePosition_Local")]
	public FVector BasePosition_Local
	{
		get
		{
			CheckDestroyed();
			if (!BasePosition_Local_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BasePosition_Local");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, BasePosition_Local_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BasePosition_Local_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BasePosition_Local");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, BasePosition_Local_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendInTime");
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
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRangeOffset:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		Timer = 0f;
		Alpha = 0f;
		_TotalDuration = TotalDuration;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return;
		}
		AActor lockTargetActor = readOnlyData.GetTargetInfo().LockTargetActor;
		if (!(lockTargetActor == null))
		{
			FQuat attackOffset_WorldRotOffset = CalcRotOffset(bGUCharacterCS, lockTargetActor);
			Active = true;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetAttackOffset.Invoke(EAttackOffsetType.AttackOffset_WorldRotOffset, attackOffset_WorldRotOffset);
				bUS_GSEventCollection.Evt_SetAttackOffsetAlpha.Invoke(Alpha);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (!Active)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			Timer += FrameDeltaTime;
			if (Timer <= BlendInTime)
			{
				Alpha = FMath.Clamp(Timer / BlendInTime, 0f, 1f);
			}
			else if (Timer >= _TotalDuration - BlendOutTime)
			{
				Alpha = FMath.Clamp((_TotalDuration - Timer) / BlendOutTime, 0f, 1f);
			}
			else
			{
				Alpha = 1f;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetAttackOffsetAlpha.Invoke(Alpha);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!Active)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetAttackOffsetAlpha.Invoke(0f);
			}
		}
	}

	private FQuat CalcRotOffset(AActor Owner, AActor Target)
	{
		FVector zeroVector = FVector.ZeroVector;
		FTransform fTransform = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSequence, BaseAnimSequencePosition, AimSocketName);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner).InverseTransformLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Target));
		if (EnablePitch)
		{
			FVector fVector2 = BasePosition_Local - fTransform.GetLocation();
			FVector fVector3 = fVector - fTransform.GetLocation();
			FVector2D safeNormal = new FVector2D(fVector2.X, fVector2.Z).GetSafeNormal();
			FVector2D safeNormal2 = new FVector2D(fVector3.X, fVector3.Z).GetSafeNormal();
			float num = MathLib.DegAcos(FVector2D.DotProduct(safeNormal, safeNormal2));
			if (fVector2.X > fVector3.X)
			{
				num *= -1f;
			}
			zeroVector.Z = num;
		}
		return zeroVector.ToOrientationQuat();
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackRangeOffset bANS_GSAttackRangeOffset = GCHelper.Find<b1.BANS_GSAttackRangeOffset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackRangeOffset.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackRangeOffset bANS_GSAttackRangeOffset = GCHelper.Find<b1.BANS_GSAttackRangeOffset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSAttackRangeOffset.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackRangeOffset bANS_GSAttackRangeOffset = GCHelper.Find<b1.BANS_GSAttackRangeOffset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackRangeOffset.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackRangeOffset");
		NativeReflection.GetPropertyRef(ref EnablePitch_PropertyAddress, intPtr, "EnablePitch");
		EnablePitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnablePitch");
		EnablePitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnablePitch", Classes.FBoolProperty);
		PitchMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchMin");
		PitchMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchMin", Classes.FFloatProperty);
		PitchMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchMax");
		PitchMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchMax", Classes.FFloatProperty);
		AimSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimSocketName");
		AimSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimSocketName", Classes.FNameProperty);
		AnimSequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSequence");
		AnimSequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSequence", Classes.FObjectProperty);
		BaseAnimSequencePosition_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseAnimSequencePosition");
		BaseAnimSequencePosition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseAnimSequencePosition", Classes.FFloatProperty);
		BasePosition_Local_Offset = NativeReflection.GetPropertyOffset(intPtr, "BasePosition_Local");
		BasePosition_Local_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BasePosition_Local", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRangeOffset:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAttackRangeOffset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttackRangeOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttackRangeOffset));
	}
}
