using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TemplateSequence.TemplateSequencePlayer", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public class UTemplateSequencePlayer : UMovieSceneSequencePlayer
{
	private static IntPtr classAddress;

	private static bool CreateTemplateSequencePlayer_IsValid;

	private static IntPtr CreateTemplateSequencePlayer_FunctionAddress;

	private static int CreateTemplateSequencePlayer_ParamsSize;

	private static bool CreateTemplateSequencePlayer_WorldContextObject_IsValid;

	private static FFieldAddress CreateTemplateSequencePlayer_WorldContextObject_PropertyAddress;

	private static int CreateTemplateSequencePlayer_WorldContextObject_Offset;

	private static bool CreateTemplateSequencePlayer_TemplateSequence_IsValid;

	private static FFieldAddress CreateTemplateSequencePlayer_TemplateSequence_PropertyAddress;

	private static int CreateTemplateSequencePlayer_TemplateSequence_Offset;

	private static bool CreateTemplateSequencePlayer_Settings_IsValid;

	private static FFieldAddress CreateTemplateSequencePlayer_Settings_PropertyAddress;

	private static int CreateTemplateSequencePlayer_Settings_Offset;

	private static bool CreateTemplateSequencePlayer_OutActor_IsValid;

	private static FFieldAddress CreateTemplateSequencePlayer_OutActor_PropertyAddress;

	private static int CreateTemplateSequencePlayer_OutActor_Offset;

	private static bool CreateTemplateSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress CreateTemplateSequencePlayer_ReturnValue_PropertyAddress;

	private static int CreateTemplateSequencePlayer_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequencePlayer:CreateTemplateSequencePlayer")]
	public unsafe static UTemplateSequencePlayer CreateTemplateSequencePlayer(UObject WorldContextObject, UTemplateSequence TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, out ATemplateSequenceActor OutActor)
	{
		if (!CreateTemplateSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequencePlayer:CreateTemplateSequencePlayer");
			OutActor = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTemplateSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTemplateSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateTemplateSequencePlayer_WorldContextObject_Offset), 0, CreateTemplateSequencePlayer_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTemplateSequence>.ToNative(IntPtr.Add(intPtr, CreateTemplateSequencePlayer_TemplateSequence_Offset), 0, CreateTemplateSequencePlayer_TemplateSequence_PropertyAddress.Address, TemplateSequence);
		NativeReflection.InitializeValue_InContainer(CreateTemplateSequencePlayer_Settings_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(intPtr, CreateTemplateSequencePlayer_Settings_Offset), 0, CreateTemplateSequencePlayer_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTemplateSequencePlayer_FunctionAddress, intPtr, CreateTemplateSequencePlayer_ParamsSize);
		OutActor = UObjectMarshaler<ATemplateSequenceActor>.FromNative(IntPtr.Add(intPtr, CreateTemplateSequencePlayer_OutActor_Offset), 0, CreateTemplateSequencePlayer_OutActor_PropertyAddress.Address);
		return UObjectMarshaler<UTemplateSequencePlayer>.FromNative(IntPtr.Add(intPtr, CreateTemplateSequencePlayer_ReturnValue_Offset), 0, CreateTemplateSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	static UTemplateSequencePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTemplateSequencePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTemplateSequencePlayer));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/TemplateSequence.TemplateSequencePlayer");
		CreateTemplateSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTemplateSequencePlayer");
		CreateTemplateSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTemplateSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTemplateSequencePlayer_WorldContextObject_PropertyAddress, CreateTemplateSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateTemplateSequencePlayer_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateTemplateSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateTemplateSequencePlayer_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTemplateSequencePlayer_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTemplateSequencePlayer_TemplateSequence_PropertyAddress, CreateTemplateSequencePlayer_FunctionAddress, "TemplateSequence");
		CreateTemplateSequencePlayer_TemplateSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateTemplateSequencePlayer_FunctionAddress, "TemplateSequence");
		CreateTemplateSequencePlayer_TemplateSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTemplateSequencePlayer_FunctionAddress, "TemplateSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTemplateSequencePlayer_Settings_PropertyAddress, CreateTemplateSequencePlayer_FunctionAddress, "Settings");
		CreateTemplateSequencePlayer_Settings_Offset = NativeReflectionCached.GetPropertyOffset(CreateTemplateSequencePlayer_FunctionAddress, "Settings");
		CreateTemplateSequencePlayer_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTemplateSequencePlayer_FunctionAddress, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTemplateSequencePlayer_OutActor_PropertyAddress, CreateTemplateSequencePlayer_FunctionAddress, "OutActor");
		CreateTemplateSequencePlayer_OutActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateTemplateSequencePlayer_FunctionAddress, "OutActor");
		CreateTemplateSequencePlayer_OutActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTemplateSequencePlayer_FunctionAddress, "OutActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTemplateSequencePlayer_ReturnValue_PropertyAddress, CreateTemplateSequencePlayer_FunctionAddress, "ReturnValue");
		CreateTemplateSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTemplateSequencePlayer_FunctionAddress, "ReturnValue");
		CreateTemplateSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTemplateSequencePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTemplateSequencePlayer_IsValid = CreateTemplateSequencePlayer_FunctionAddress != IntPtr.Zero && CreateTemplateSequencePlayer_WorldContextObject_IsValid && CreateTemplateSequencePlayer_TemplateSequence_IsValid && CreateTemplateSequencePlayer_Settings_IsValid && CreateTemplateSequencePlayer_OutActor_IsValid && CreateTemplateSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequencePlayer:CreateTemplateSequencePlayer", CreateTemplateSequencePlayer_IsValid);
	}
}
