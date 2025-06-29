using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters")]
public class UDispLib_PPEffectParameters : UObject
{
	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool BeginningDuration_IsValid;

	private static int BeginningDuration_Offset;

	private static bool FinishingDuration_IsValid;

	private static int FinishingDuration_Offset;

	private static bool VectorParams_IsValid;

	private static int VectorParams_Offset;

	private static FFieldAddress VectorParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector4> VectorParams_Marshaler;

	private static bool ScalarParams_IsValid;

	private static int ScalarParams_Offset;

	private static FFieldAddress ScalarParams_PropertyAddress;

	private TArrayReadWriteMarshaler<float> ScalarParams_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters:BeginningDuration")]
	public float BeginningDuration
	{
		get
		{
			CheckDestroyed();
			if (!BeginningDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:BeginningDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginningDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginningDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:BeginningDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginningDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters:FinishingDuration")]
	public float FinishingDuration
	{
		get
		{
			CheckDestroyed();
			if (!FinishingDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:FinishingDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FinishingDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinishingDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:FinishingDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FinishingDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters:VectorParams")]
	public TArrayReadWrite<FVector4> VectorParams
	{
		get
		{
			CheckDestroyed();
			if (!VectorParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:VectorParams");
				return null;
			}
			if (VectorParams_Marshaler == null)
			{
				VectorParams_Marshaler = new TArrayReadWriteMarshaler<FVector4>(1, VectorParams_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative);
			}
			return VectorParams_Marshaler.FromNative(IntPtr.Add(base.Address, VectorParams_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_PPEffectParameters:ScalarParams")]
	public TArrayReadWrite<float> ScalarParams
	{
		get
		{
			CheckDestroyed();
			if (!ScalarParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PPEffectParameters:ScalarParams");
				return null;
			}
			if (ScalarParams_Marshaler == null)
			{
				ScalarParams_Marshaler = new TArrayReadWriteMarshaler<float>(1, ScalarParams_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return ScalarParams_Marshaler.FromNative(IntPtr.Add(base.Address, ScalarParams_Offset));
		}
	}

	public void CopyValue(PPEffectParametersValue InValue)
	{
		if (InValue == null)
		{
			return;
		}
		Duration = InValue.Duration;
		BeginningDuration = InValue.BeginningDuration;
		FinishingDuration = InValue.FinishingDuration;
		VectorParams.Clear();
		if (InValue.VectorParams != null)
		{
			foreach (FVector4 vectorParam in InValue.VectorParams)
			{
				VectorParams.Add(vectorParam);
			}
		}
		ScalarParams.Clear();
		if (InValue.ScalarParams == null)
		{
			return;
		}
		foreach (float scalarParam in InValue.ScalarParams)
		{
			ScalarParams.Add(scalarParam);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.DispLib_PPEffectParameters");
		Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
		BeginningDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginningDuration");
		BeginningDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginningDuration", Classes.FFloatProperty);
		FinishingDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FinishingDuration");
		FinishingDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FinishingDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref VectorParams_PropertyAddress, unrealStruct, "VectorParams");
		VectorParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VectorParams");
		VectorParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VectorParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ScalarParams_PropertyAddress, unrealStruct, "ScalarParams");
		ScalarParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScalarParams");
		ScalarParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScalarParams", Classes.FArrayProperty);
	}

	static UDispLib_PPEffectParameters()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDispLib_PPEffectParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDispLib_PPEffectParameters));
	}
}
