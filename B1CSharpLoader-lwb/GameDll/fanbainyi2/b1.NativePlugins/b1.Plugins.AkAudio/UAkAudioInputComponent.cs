using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkAudioInputComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkAudioInputComponent : UAkComponent
{
	private static bool PostAssociatedAudioInputEvent_IsValid;

	private static IntPtr PostAssociatedAudioInputEvent_FunctionAddress;

	private static int PostAssociatedAudioInputEvent_ParamsSize;

	private static bool PostAssociatedAudioInputEvent_ReturnValue_IsValid;

	private static FFieldAddress PostAssociatedAudioInputEvent_ReturnValue_PropertyAddress;

	private static int PostAssociatedAudioInputEvent_ReturnValue_Offset;

	[UFunction(Flags = 67240968u)]
	[UMetaPath("/Script/AkAudio.AkAudioInputComponent:PostAssociatedAudioInputEvent")]
	public unsafe int PostAssociatedAudioInputEvent()
	{
		CheckDestroyed();
		if (!PostAssociatedAudioInputEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioInputComponent:PostAssociatedAudioInputEvent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAssociatedAudioInputEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAssociatedAudioInputEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAssociatedAudioInputEvent_FunctionAddress, intPtr, PostAssociatedAudioInputEvent_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAssociatedAudioInputEvent_ReturnValue_Offset), 0, PostAssociatedAudioInputEvent_ReturnValue_PropertyAddress.Address);
	}

	static UAkAudioInputComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkAudioInputComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkAudioInputComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AkAudio.AkAudioInputComponent");
		PostAssociatedAudioInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostAssociatedAudioInputEvent");
		PostAssociatedAudioInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAssociatedAudioInputEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAudioInputEvent_ReturnValue_PropertyAddress, PostAssociatedAudioInputEvent_FunctionAddress, "ReturnValue");
		PostAssociatedAudioInputEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAudioInputEvent_FunctionAddress, "ReturnValue");
		PostAssociatedAudioInputEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAudioInputEvent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAssociatedAudioInputEvent_IsValid = PostAssociatedAudioInputEvent_FunctionAddress != IntPtr.Zero && PostAssociatedAudioInputEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioInputComponent:PostAssociatedAudioInputEvent", PostAssociatedAudioInputEvent_IsValid);
	}
}
