using System;
using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimEquipHeadPostProcess")]
internal class BUAnimEquipHeadPostProcess : UAnimInstance
{
	private static bool IdleBlendWight_IsValid;

	private static int IdleBlendWight_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimEquipHeadPostProcess:IdleBlendWight")]
	public float IdleBlendWight
	{
		get
		{
			CheckDestroyed();
			if (!IdleBlendWight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimEquipHeadPostProcess:IdleBlendWight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IdleBlendWight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IdleBlendWight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimEquipHeadPostProcess:IdleBlendWight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IdleBlendWight_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimEquipHeadPostProcess:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.BlueprintInitializeAnimation_Implementation();
		AActor owner = GetOwningComponent().GetOwner();
		if (owner is b1.BGUEquipPreviewActorBase)
		{
			IdleBlendWight = 1f;
			UAnimInstance uAnimInstance = owner.GetComponentByClass<USkeletalMeshComponent>()?.GetAnimInstance();
			UAnimMontage uAnimMontage = uAnimInstance?.GetCurrentActiveMontage();
			if (!(uAnimMontage != null))
			{
				return;
			}
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
			if (bGW_PreloadAssetMgr != null)
			{
				bGW_PreloadAssetMgr.EquipPreviewConfigDataAsset.PositionConfigMap.TryGetValue(EquipPosition.Head, out var value);
				UAnimMontage uAnimMontage2 = null;
				if (uAnimMontage == value.AnimIn)
				{
					uAnimMontage2 = value.HeadAnimIn;
				}
				else if (uAnimMontage == value.AnimOutSuccess)
				{
					uAnimMontage2 = value.HeadAnimOutSuccess;
				}
				else if (uAnimMontage == value.AnimOutBack)
				{
					uAnimMontage2 = value.HeadAnimOutBack;
				}
				if (uAnimMontage2 != null)
				{
					this?.Montage_Play(uAnimMontage2, 1f, EMontagePlayReturnType.MontageLength, uAnimInstance.Montage_GetPosition(uAnimMontage));
				}
			}
		}
		else
		{
			IdleBlendWight = 0f;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimEquipHeadPostProcess:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimEquipHeadPostProcess bUAnimEquipHeadPostProcess = GCHelper.Find<b1.BUAnimEquipHeadPostProcess>(obj);
		bUAnimEquipHeadPostProcess.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimEquipHeadPostProcess");
		IdleBlendWight_Offset = NativeReflection.GetPropertyOffset(intPtr, "IdleBlendWight");
		IdleBlendWight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IdleBlendWight", Classes.FFloatProperty);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimEquipHeadPostProcess:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimEquipHeadPostProcess()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUAnimEquipHeadPostProcess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUAnimEquipHeadPostProcess));
	}
}
