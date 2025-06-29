using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequencePlayer", "LevelSequence", UnrealModuleType.Engine)]
public class ULevelSequencePlayer : UMovieSceneSequencePlayer
{
	private static IntPtr classAddress;

	private static bool OnCameraCut_IsValid;

	private static int OnCameraCut_Offset;

	private FOnLevelSequencePlayerCameraCutEvent OnCameraCut_DelegateCached;

	private static bool GetActiveCameraComponent_IsValid;

	private static IntPtr GetActiveCameraComponent_FunctionAddress;

	private static int GetActiveCameraComponent_ParamsSize;

	private static bool GetActiveCameraComponent_ReturnValue_IsValid;

	private static FFieldAddress GetActiveCameraComponent_ReturnValue_PropertyAddress;

	private static int GetActiveCameraComponent_ReturnValue_Offset;

	private static bool CreateLevelSequencePlayer_IsValid;

	private static IntPtr CreateLevelSequencePlayer_FunctionAddress;

	private static int CreateLevelSequencePlayer_ParamsSize;

	private static bool CreateLevelSequencePlayer_WorldContextObject_IsValid;

	private static FFieldAddress CreateLevelSequencePlayer_WorldContextObject_PropertyAddress;

	private static int CreateLevelSequencePlayer_WorldContextObject_Offset;

	private static bool CreateLevelSequencePlayer_LevelSequence_IsValid;

	private static FFieldAddress CreateLevelSequencePlayer_LevelSequence_PropertyAddress;

	private static int CreateLevelSequencePlayer_LevelSequence_Offset;

	private static bool CreateLevelSequencePlayer_Settings_IsValid;

	private static FFieldAddress CreateLevelSequencePlayer_Settings_PropertyAddress;

	private static int CreateLevelSequencePlayer_Settings_Offset;

	private static bool CreateLevelSequencePlayer_OutActor_IsValid;

	private static FFieldAddress CreateLevelSequencePlayer_OutActor_PropertyAddress;

	private static int CreateLevelSequencePlayer_OutActor_Offset;

	private static bool CreateLevelSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress CreateLevelSequencePlayer_ReturnValue_PropertyAddress;

	private static int CreateLevelSequencePlayer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayer:OnCameraCut")]
	public FOnLevelSequencePlayerCameraCutEvent OnCameraCut
	{
		get
		{
			CheckDestroyed();
			if (!OnCameraCut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequencePlayer:OnCameraCut");
				return new FOnLevelSequencePlayerCameraCutEvent();
			}
			if (OnCameraCut_DelegateCached == null)
			{
				OnCameraCut_DelegateCached = new FOnLevelSequencePlayerCameraCutEvent();
				OnCameraCut_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCameraCut_Offset));
			}
			return OnCameraCut_DelegateCached;
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayer:GetActiveCameraComponent")]
	public unsafe UCameraComponent GetActiveCameraComponent()
	{
		CheckDestroyed();
		if (!GetActiveCameraComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequencePlayer:GetActiveCameraComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveCameraComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveCameraComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActiveCameraComponent_FunctionAddress, intPtr, GetActiveCameraComponent_ParamsSize);
		return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(intPtr, GetActiveCameraComponent_ReturnValue_Offset), 0, GetActiveCameraComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayer:CreateLevelSequencePlayer")]
	public unsafe static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, out ALevelSequenceActor OutActor)
	{
		if (!CreateLevelSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequencePlayer:CreateLevelSequencePlayer");
			OutActor = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLevelSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLevelSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateLevelSequencePlayer_WorldContextObject_Offset), 0, CreateLevelSequencePlayer_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, CreateLevelSequencePlayer_LevelSequence_Offset), 0, CreateLevelSequencePlayer_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InitializeValue_InContainer(CreateLevelSequencePlayer_Settings_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(intPtr, CreateLevelSequencePlayer_Settings_Offset), 0, CreateLevelSequencePlayer_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLevelSequencePlayer_FunctionAddress, intPtr, CreateLevelSequencePlayer_ParamsSize);
		OutActor = UObjectMarshaler<ALevelSequenceActor>.FromNative(IntPtr.Add(intPtr, CreateLevelSequencePlayer_OutActor_Offset), 0, CreateLevelSequencePlayer_OutActor_PropertyAddress.Address);
		return UObjectMarshaler<ULevelSequencePlayer>.FromNative(IntPtr.Add(intPtr, CreateLevelSequencePlayer_ReturnValue_Offset), 0, CreateLevelSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	static ULevelSequencePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequencePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequencePlayer));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/LevelSequence.LevelSequencePlayer");
		OnCameraCut_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnCameraCut");
		OnCameraCut_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnCameraCut", Classes.FMulticastDelegateProperty);
		GetActiveCameraComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActiveCameraComponent");
		GetActiveCameraComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveCameraComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveCameraComponent_ReturnValue_PropertyAddress, GetActiveCameraComponent_FunctionAddress, "ReturnValue");
		GetActiveCameraComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveCameraComponent_FunctionAddress, "ReturnValue");
		GetActiveCameraComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveCameraComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActiveCameraComponent_IsValid = GetActiveCameraComponent_FunctionAddress != IntPtr.Zero && GetActiveCameraComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequencePlayer:GetActiveCameraComponent", GetActiveCameraComponent_IsValid);
		CreateLevelSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLevelSequencePlayer");
		CreateLevelSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLevelSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelSequencePlayer_WorldContextObject_PropertyAddress, CreateLevelSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateLevelSequencePlayer_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateLevelSequencePlayer_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelSequencePlayer_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelSequencePlayer_LevelSequence_PropertyAddress, CreateLevelSequencePlayer_FunctionAddress, "LevelSequence");
		CreateLevelSequencePlayer_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelSequencePlayer_FunctionAddress, "LevelSequence");
		CreateLevelSequencePlayer_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelSequencePlayer_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelSequencePlayer_Settings_PropertyAddress, CreateLevelSequencePlayer_FunctionAddress, "Settings");
		CreateLevelSequencePlayer_Settings_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelSequencePlayer_FunctionAddress, "Settings");
		CreateLevelSequencePlayer_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelSequencePlayer_FunctionAddress, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelSequencePlayer_OutActor_PropertyAddress, CreateLevelSequencePlayer_FunctionAddress, "OutActor");
		CreateLevelSequencePlayer_OutActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelSequencePlayer_FunctionAddress, "OutActor");
		CreateLevelSequencePlayer_OutActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelSequencePlayer_FunctionAddress, "OutActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelSequencePlayer_ReturnValue_PropertyAddress, CreateLevelSequencePlayer_FunctionAddress, "ReturnValue");
		CreateLevelSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelSequencePlayer_FunctionAddress, "ReturnValue");
		CreateLevelSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelSequencePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateLevelSequencePlayer_IsValid = CreateLevelSequencePlayer_FunctionAddress != IntPtr.Zero && CreateLevelSequencePlayer_WorldContextObject_IsValid && CreateLevelSequencePlayer_LevelSequence_IsValid && CreateLevelSequencePlayer_Settings_IsValid && CreateLevelSequencePlayer_OutActor_IsValid && CreateLevelSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequencePlayer:CreateLevelSequencePlayer", CreateLevelSequencePlayer_IsValid);
	}
}
