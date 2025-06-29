using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TransEffectSetting")]
public class BGWDataAsset_TransEffectSetting : UBGWDataAsset
{
	private static bool TransEffect_IsValid;

	private static int TransEffect_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool NiagaraParams_IsValid;

	private static int NiagaraParams_Offset;

	private static FFieldAddress NiagaraParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSNiagaraSysParam> NiagaraParams_Marshaler;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("变身特效")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:TransEffect")]
	public UNiagaraSystem TransEffect
	{
		get
		{
			CheckDestroyed();
			if (!TransEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:TransEffect");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, TransEffect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:TransEffect");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, TransEffect_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("特效持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:NiagaraParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> NiagaraParams
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TransEffectSetting:NiagaraParams");
				return null;
			}
			if (NiagaraParams_Marshaler == null)
			{
				NiagaraParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, NiagaraParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return NiagaraParams_Marshaler.FromNative(IntPtr.Add(base.Address, NiagaraParams_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TransEffectSetting");
		TransEffect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TransEffect");
		TransEffect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TransEffect", Classes.FObjectProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NiagaraParams_PropertyAddress, unrealStruct, "NiagaraParams");
		NiagaraParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NiagaraParams");
		NiagaraParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NiagaraParams", Classes.FArrayProperty);
	}

	static BGWDataAsset_TransEffectSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TransEffectSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TransEffectSetting));
	}
}
