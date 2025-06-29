using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AudioCapture.AudioCaptureFunctionLibrary", "AudioCapture", UnrealModuleType.EnginePlugin)]
public class UAudioCaptureFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CreateAudioCapture_IsValid;

	private static IntPtr CreateAudioCapture_FunctionAddress;

	private static int CreateAudioCapture_ParamsSize;

	private static bool CreateAudioCapture_ReturnValue_IsValid;

	private static FFieldAddress CreateAudioCapture_ReturnValue_PropertyAddress;

	private static int CreateAudioCapture_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureFunctionLibrary:CreateAudioCapture")]
	public unsafe static UAudioCapture CreateAudioCapture()
	{
		if (!CreateAudioCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCaptureFunctionLibrary:CreateAudioCapture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAudioCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAudioCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAudioCapture_FunctionAddress, intPtr, CreateAudioCapture_ParamsSize);
		return UObjectMarshaler<UAudioCapture>.FromNative(IntPtr.Add(intPtr, CreateAudioCapture_ReturnValue_Offset), 0, CreateAudioCapture_ReturnValue_PropertyAddress.Address);
	}

	static UAudioCaptureFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioCaptureFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioCaptureFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AudioCapture.AudioCaptureFunctionLibrary");
		CreateAudioCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAudioCapture");
		CreateAudioCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAudioCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAudioCapture_ReturnValue_PropertyAddress, CreateAudioCapture_FunctionAddress, "ReturnValue");
		CreateAudioCapture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAudioCapture_FunctionAddress, "ReturnValue");
		CreateAudioCapture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAudioCapture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAudioCapture_IsValid = CreateAudioCapture_FunctionAddress != IntPtr.Zero && CreateAudioCapture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCaptureFunctionLibrary:CreateAudioCapture", CreateAudioCapture_IsValid);
	}
}
