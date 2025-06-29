using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MediaAssets;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController", "LevelSequence", UnrealModuleType.Engine)]
public class ALevelSequenceMediaController : AActor, IMovieSceneCustomClockSource, IInterface
{
	private static bool ServerStartTimeSeconds_IsValid;

	private static int ServerStartTimeSeconds_Offset;

	private static bool SynchronizeToServer_IsValid;

	private static IntPtr SynchronizeToServer_FunctionAddress;

	private static int SynchronizeToServer_ParamsSize;

	private static bool SynchronizeToServer_DesyncThresholdSeconds_IsValid;

	private static FFieldAddress SynchronizeToServer_DesyncThresholdSeconds_PropertyAddress;

	private static int SynchronizeToServer_DesyncThresholdSeconds_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	private static bool GetMediaComponent_IsValid;

	private static IntPtr GetMediaComponent_FunctionAddress;

	private static int GetMediaComponent_ParamsSize;

	private static bool GetMediaComponent_ReturnValue_IsValid;

	private static FFieldAddress GetMediaComponent_ReturnValue_PropertyAddress;

	private static int GetMediaComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)20266272411353652uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController:ServerStartTimeSeconds")]
	public float ServerStartTimeSeconds
	{
		get
		{
			CheckDestroyed();
			if (!ServerStartTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceMediaController:ServerStartTimeSeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ServerStartTimeSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ServerStartTimeSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceMediaController:ServerStartTimeSeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ServerStartTimeSeconds_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController:SynchronizeToServer")]
	public unsafe void SynchronizeToServer(float DesyncThresholdSeconds = 2f)
	{
		CheckDestroyed();
		if (!SynchronizeToServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceMediaController:SynchronizeToServer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SynchronizeToServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SynchronizeToServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SynchronizeToServer_DesyncThresholdSeconds_Offset), 0, SynchronizeToServer_DesyncThresholdSeconds_PropertyAddress.Address, DesyncThresholdSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, SynchronizeToServer_FunctionAddress, intPtr, SynchronizeToServer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceMediaController:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController:GetSequence")]
	public unsafe ALevelSequenceActor GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceMediaController:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<ALevelSequenceActor>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceMediaController:GetMediaComponent")]
	public unsafe UMediaComponent GetMediaComponent()
	{
		CheckDestroyed();
		if (!GetMediaComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceMediaController:GetMediaComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaComponent_FunctionAddress, intPtr, GetMediaComponent_ParamsSize);
		return UObjectMarshaler<UMediaComponent>.FromNative(IntPtr.Add(intPtr, GetMediaComponent_ReturnValue_Offset), 0, GetMediaComponent_ReturnValue_PropertyAddress.Address);
	}

	static ALevelSequenceMediaController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALevelSequenceMediaController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALevelSequenceMediaController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.LevelSequenceMediaController");
		ServerStartTimeSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ServerStartTimeSeconds");
		ServerStartTimeSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ServerStartTimeSeconds", Classes.FFloatProperty);
		SynchronizeToServer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SynchronizeToServer");
		SynchronizeToServer_ParamsSize = NativeReflection.GetFunctionParamsSize(SynchronizeToServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SynchronizeToServer_DesyncThresholdSeconds_PropertyAddress, SynchronizeToServer_FunctionAddress, "DesyncThresholdSeconds");
		SynchronizeToServer_DesyncThresholdSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SynchronizeToServer_FunctionAddress, "DesyncThresholdSeconds");
		SynchronizeToServer_DesyncThresholdSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SynchronizeToServer_FunctionAddress, "DesyncThresholdSeconds", Classes.FFloatProperty);
		SynchronizeToServer_IsValid = SynchronizeToServer_FunctionAddress != IntPtr.Zero && SynchronizeToServer_DesyncThresholdSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceMediaController:SynchronizeToServer", SynchronizeToServer_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceMediaController:Play", Play_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceMediaController:GetSequence", GetSequence_IsValid);
		GetMediaComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMediaComponent");
		GetMediaComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaComponent_ReturnValue_PropertyAddress, GetMediaComponent_FunctionAddress, "ReturnValue");
		GetMediaComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaComponent_FunctionAddress, "ReturnValue");
		GetMediaComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMediaComponent_IsValid = GetMediaComponent_FunctionAddress != IntPtr.Zero && GetMediaComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceMediaController:GetMediaComponent", GetMediaComponent_IsValid);
	}
}
