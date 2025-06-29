using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PawnNoiseEmitterComponent", "Engine", UnrealModuleType.Engine)]
public class UPawnNoiseEmitterComponent : UActorComponent
{
	private static bool NoiseLifetime_IsValid;

	private static int NoiseLifetime_Offset;

	private static bool MakeNoise_IsValid;

	private static IntPtr MakeNoise_FunctionAddress;

	private static int MakeNoise_ParamsSize;

	private static bool MakeNoise_NoiseMaker_IsValid;

	private static FFieldAddress MakeNoise_NoiseMaker_PropertyAddress;

	private static int MakeNoise_NoiseMaker_Offset;

	private static bool MakeNoise_Loudness_IsValid;

	private static FFieldAddress MakeNoise_Loudness_PropertyAddress;

	private static int MakeNoise_Loudness_Offset;

	private static bool MakeNoise_NoiseLocation_IsValid;

	private static FFieldAddress MakeNoise_NoiseLocation_PropertyAddress;

	private static int MakeNoise_NoiseLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PawnNoiseEmitterComponent:NoiseLifetime")]
	public float NoiseLifetime
	{
		get
		{
			CheckDestroyed();
			if (!NoiseLifetime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PawnNoiseEmitterComponent:NoiseLifetime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseLifetime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseLifetime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PawnNoiseEmitterComponent:NoiseLifetime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseLifetime_Offset), value);
			}
		}
	}

	[UFunction(Flags = 79823876u)]
	[UMetaPath("/Script/Engine.PawnNoiseEmitterComponent:MakeNoise")]
	public unsafe void MakeNoise(AActor NoiseMaker, float Loudness, FVector NoiseLocation)
	{
		CheckDestroyed();
		if (!MakeNoise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnNoiseEmitterComponent:MakeNoise");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeNoise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeNoise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MakeNoise_NoiseMaker_Offset), 0, MakeNoise_NoiseMaker_PropertyAddress.Address, NoiseMaker);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeNoise_Loudness_Offset), 0, MakeNoise_Loudness_PropertyAddress.Address, Loudness);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MakeNoise_NoiseLocation_Offset), 0, MakeNoise_NoiseLocation_PropertyAddress.Address, NoiseLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeNoise_FunctionAddress, intPtr, MakeNoise_ParamsSize);
	}

	static UPawnNoiseEmitterComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnNoiseEmitterComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnNoiseEmitterComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PawnNoiseEmitterComponent");
		NoiseLifetime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NoiseLifetime");
		NoiseLifetime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NoiseLifetime", Classes.FFloatProperty);
		MakeNoise_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeNoise");
		MakeNoise_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeNoise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_NoiseMaker_PropertyAddress, MakeNoise_FunctionAddress, "NoiseMaker");
		MakeNoise_NoiseMaker_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "NoiseMaker");
		MakeNoise_NoiseMaker_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "NoiseMaker", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_Loudness_PropertyAddress, MakeNoise_FunctionAddress, "Loudness");
		MakeNoise_Loudness_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "Loudness");
		MakeNoise_Loudness_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "Loudness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_NoiseLocation_PropertyAddress, MakeNoise_FunctionAddress, "NoiseLocation");
		MakeNoise_NoiseLocation_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "NoiseLocation");
		MakeNoise_NoiseLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "NoiseLocation", Classes.FStructProperty);
		MakeNoise_IsValid = MakeNoise_FunctionAddress != IntPtr.Zero && MakeNoise_NoiseMaker_IsValid && MakeNoise_Loudness_IsValid && MakeNoise_NoiseLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnNoiseEmitterComponent:MakeNoise", MakeNoise_IsValid);
	}
}
