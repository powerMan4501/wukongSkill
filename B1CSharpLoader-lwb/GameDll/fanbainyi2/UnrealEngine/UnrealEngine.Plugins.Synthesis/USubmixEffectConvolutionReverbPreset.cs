using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectConvolutionReverbPreset : USoundEffectSubmixPreset
{
	private static bool ImpulseResponse_IsValid;

	private static int ImpulseResponse_Offset;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool BlockSize_IsValid;

	private static FFieldAddress BlockSize_PropertyAddress;

	private static int BlockSize_Offset;

	private static bool EnableHardwareAcceleration_IsValid;

	private static FFieldAddress EnableHardwareAcceleration_PropertyAddress;

	private static int EnableHardwareAcceleration_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	private static bool SetImpulseResponse_IsValid;

	private static IntPtr SetImpulseResponse_FunctionAddress;

	private static int SetImpulseResponse_ParamsSize;

	private static bool SetImpulseResponse_InImpulseResponse_IsValid;

	private static FFieldAddress SetImpulseResponse_InImpulseResponse_PropertyAddress;

	private static int SetImpulseResponse_InImpulseResponse_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:ImpulseResponse")]
	public UAudioImpulseResponse ImpulseResponse
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseResponse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:ImpulseResponse");
				return null;
			}
			return UObjectMarshaler<UAudioImpulseResponse>.FromNative(IntPtr.Add(base.Address, ImpulseResponse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseResponse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:ImpulseResponse");
			}
			else
			{
				UObjectMarshaler<UAudioImpulseResponse>.ToNative(IntPtr.Add(base.Address, ImpulseResponse_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:Settings")]
	public FSubmixEffectConvolutionReverbSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:Settings");
				return default(FSubmixEffectConvolutionReverbSettings);
			}
			return FSubmixEffectConvolutionReverbSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:Settings");
			}
			else
			{
				FSubmixEffectConvolutionReverbSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:BlockSize")]
	public ESubmixEffectConvolutionReverbBlockSize BlockSize
	{
		get
		{
			CheckDestroyed();
			if (!BlockSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:BlockSize");
				return ESubmixEffectConvolutionReverbBlockSize.BlockSize256;
			}
			return EnumMarshaler<ESubmixEffectConvolutionReverbBlockSize>.FromNative(IntPtr.Add(base.Address, BlockSize_Offset), 0, BlockSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlockSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:BlockSize");
			}
			else
			{
				EnumMarshaler<ESubmixEffectConvolutionReverbBlockSize>.ToNative(IntPtr.Add(base.Address, BlockSize_Offset), 0, BlockSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:bEnableHardwareAcceleration")]
	public bool EnableHardwareAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!EnableHardwareAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:bEnableHardwareAcceleration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHardwareAcceleration_Offset), 0, EnableHardwareAcceleration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHardwareAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:bEnableHardwareAcceleration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHardwareAcceleration_Offset), 0, EnableHardwareAcceleration_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectConvolutionReverbSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectConvolutionReverbSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetImpulseResponse")]
	public unsafe void SetImpulseResponse(UAudioImpulseResponse InImpulseResponse)
	{
		CheckDestroyed();
		if (!SetImpulseResponse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetImpulseResponse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetImpulseResponse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetImpulseResponse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioImpulseResponse>.ToNative(IntPtr.Add(intPtr, SetImpulseResponse_InImpulseResponse_Offset), 0, SetImpulseResponse_InImpulseResponse_PropertyAddress.Address, InImpulseResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetImpulseResponse_FunctionAddress, intPtr, SetImpulseResponse_ParamsSize);
	}

	static USubmixEffectConvolutionReverbPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectConvolutionReverbPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectConvolutionReverbPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectConvolutionReverbPreset");
		ImpulseResponse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImpulseResponse");
		ImpulseResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImpulseResponse", Classes.FObjectProperty);
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockSize_PropertyAddress, intPtr, "BlockSize");
		BlockSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlockSize");
		BlockSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlockSize", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableHardwareAcceleration_PropertyAddress, intPtr, "bEnableHardwareAcceleration");
		EnableHardwareAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableHardwareAcceleration");
		EnableHardwareAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableHardwareAcceleration", Classes.FBoolProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetSettings", SetSettings_IsValid);
		SetImpulseResponse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetImpulseResponse");
		SetImpulseResponse_ParamsSize = NativeReflection.GetFunctionParamsSize(SetImpulseResponse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetImpulseResponse_InImpulseResponse_PropertyAddress, SetImpulseResponse_FunctionAddress, "InImpulseResponse");
		SetImpulseResponse_InImpulseResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetImpulseResponse_FunctionAddress, "InImpulseResponse");
		SetImpulseResponse_InImpulseResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetImpulseResponse_FunctionAddress, "InImpulseResponse", Classes.FObjectProperty);
		SetImpulseResponse_IsValid = SetImpulseResponse_FunctionAddress != IntPtr.Zero && SetImpulseResponse_InImpulseResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectConvolutionReverbPreset:SetImpulseResponse", SetImpulseResponse_IsValid);
	}
}
