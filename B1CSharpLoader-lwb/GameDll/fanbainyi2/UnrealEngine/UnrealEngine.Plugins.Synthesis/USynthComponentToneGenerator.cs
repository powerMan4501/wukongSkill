using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynthComponentToneGenerator : USynthComponent
{
	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	private static bool Volume_IsValid;

	private static int Volume_Offset;

	private static bool DistanceAttenuationCurve_IsValid;

	private static int DistanceAttenuationCurve_Offset;

	private static bool DistanceRange_IsValid;

	private static int DistanceRange_Offset;

	private static bool AttenuationDbAtMaxRange_IsValid;

	private static int AttenuationDbAtMaxRange_Offset;

	private static bool SetVolume_IsValid;

	private static IntPtr SetVolume_FunctionAddress;

	private static int SetVolume_ParamsSize;

	private static bool SetVolume_InVolume_IsValid;

	private static FFieldAddress SetVolume_InVolume_PropertyAddress;

	private static int SetVolume_InVolume_Offset;

	private static bool SetFrequency_IsValid;

	private static IntPtr SetFrequency_FunctionAddress;

	private static int SetFrequency_ParamsSize;

	private static bool SetFrequency_InFrequency_IsValid;

	private static FFieldAddress SetFrequency_InFrequency_PropertyAddress;

	private static int SetFrequency_InFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:Frequency")]
	public float Frequency
	{
		get
		{
			CheckDestroyed();
			if (!Frequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:Frequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Frequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Frequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:Frequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Frequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:Volume")]
	public float Volume
	{
		get
		{
			CheckDestroyed();
			if (!Volume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:Volume");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Volume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Volume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:Volume");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Volume_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:DistanceAttenuationCurve")]
	public FRuntimeFloatCurve DistanceAttenuationCurve
	{
		get
		{
			CheckDestroyed();
			if (!DistanceAttenuationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:DistanceAttenuationCurve");
				return default(FRuntimeFloatCurve);
			}
			return FRuntimeFloatCurve.FromNative(IntPtr.Add(base.Address, DistanceAttenuationCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceAttenuationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:DistanceAttenuationCurve");
			}
			else
			{
				FRuntimeFloatCurve.ToNative(IntPtr.Add(base.Address, DistanceAttenuationCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:DistanceRange")]
	public FVector2D DistanceRange
	{
		get
		{
			CheckDestroyed();
			if (!DistanceRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:DistanceRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DistanceRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:DistanceRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DistanceRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:AttenuationDbAtMaxRange")]
	public float AttenuationDbAtMaxRange
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationDbAtMaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:AttenuationDbAtMaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttenuationDbAtMaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationDbAtMaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentToneGenerator:AttenuationDbAtMaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttenuationDbAtMaxRange_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:SetVolume")]
	public unsafe void SetVolume(float InVolume)
	{
		CheckDestroyed();
		if (!SetVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentToneGenerator:SetVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolume_InVolume_Offset), 0, SetVolume_InVolume_PropertyAddress.Address, InVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolume_FunctionAddress, intPtr, SetVolume_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentToneGenerator:SetFrequency")]
	public unsafe void SetFrequency(float InFrequency)
	{
		CheckDestroyed();
		if (!SetFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentToneGenerator:SetFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrequency_InFrequency_Offset), 0, SetFrequency_InFrequency_PropertyAddress.Address, InFrequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequency_FunctionAddress, intPtr, SetFrequency_ParamsSize);
	}

	static USynthComponentToneGenerator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthComponentToneGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthComponentToneGenerator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SynthComponentToneGenerator");
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Volume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Volume");
		Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Volume", Classes.FFloatProperty);
		DistanceAttenuationCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceAttenuationCurve");
		DistanceAttenuationCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceAttenuationCurve", Classes.FStructProperty);
		DistanceRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceRange");
		DistanceRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceRange", Classes.FStructProperty);
		AttenuationDbAtMaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationDbAtMaxRange");
		AttenuationDbAtMaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationDbAtMaxRange", Classes.FFloatProperty);
		SetVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolume");
		SetVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolume_InVolume_PropertyAddress, SetVolume_FunctionAddress, "InVolume");
		SetVolume_InVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetVolume_FunctionAddress, "InVolume");
		SetVolume_InVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolume_FunctionAddress, "InVolume", Classes.FFloatProperty);
		SetVolume_IsValid = SetVolume_FunctionAddress != IntPtr.Zero && SetVolume_InVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentToneGenerator:SetVolume", SetVolume_IsValid);
		SetFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequency");
		SetFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequency_InFrequency_PropertyAddress, SetFrequency_FunctionAddress, "InFrequency");
		SetFrequency_InFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequency_FunctionAddress, "InFrequency");
		SetFrequency_InFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequency_FunctionAddress, "InFrequency", Classes.FFloatProperty);
		SetFrequency_IsValid = SetFrequency_FunctionAddress != IntPtr.Zero && SetFrequency_InFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentToneGenerator:SetFrequency", SetFrequency_IsValid);
	}
}
