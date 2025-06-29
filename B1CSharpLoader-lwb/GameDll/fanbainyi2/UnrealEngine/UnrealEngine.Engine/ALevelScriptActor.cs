using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.LevelScriptActor", "Engine", UnrealModuleType.Engine)]
public class ALevelScriptActor : AActor
{
	private static bool WorldOriginLocationChanged_IsValid;

	private IntPtr WorldOriginLocationChanged_InstanceFunctionAddress;

	private static IntPtr WorldOriginLocationChanged_FunctionAddress;

	private static int WorldOriginLocationChanged_ParamsSize;

	private static bool WorldOriginLocationChanged_OldOriginLocation_IsValid;

	private static FFieldAddress WorldOriginLocationChanged_OldOriginLocation_PropertyAddress;

	private static int WorldOriginLocationChanged_OldOriginLocation_Offset;

	private static bool WorldOriginLocationChanged_NewOriginLocation_IsValid;

	private static FFieldAddress WorldOriginLocationChanged_NewOriginLocation_PropertyAddress;

	private static int WorldOriginLocationChanged_NewOriginLocation_Offset;

	private static bool SetCinematicMode_IsValid;

	private static IntPtr SetCinematicMode_FunctionAddress;

	private static int SetCinematicMode_ParamsSize;

	private static bool SetCinematicMode_bCinematicMode_IsValid;

	private static FFieldAddress SetCinematicMode_bCinematicMode_PropertyAddress;

	private static int SetCinematicMode_bCinematicMode_Offset;

	private static bool SetCinematicMode_bHidePlayer_IsValid;

	private static FFieldAddress SetCinematicMode_bHidePlayer_PropertyAddress;

	private static int SetCinematicMode_bHidePlayer_Offset;

	private static bool SetCinematicMode_bAffectsHUD_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsHUD_PropertyAddress;

	private static int SetCinematicMode_bAffectsHUD_Offset;

	private static bool SetCinematicMode_bAffectsMovement_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsMovement_PropertyAddress;

	private static int SetCinematicMode_bAffectsMovement_Offset;

	private static bool SetCinematicMode_bAffectsTurning_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsTurning_PropertyAddress;

	private static int SetCinematicMode_bAffectsTurning_Offset;

	private static bool RemoteEvent_IsValid;

	private static IntPtr RemoteEvent_FunctionAddress;

	private static int RemoteEvent_ParamsSize;

	private static bool RemoteEvent_EventName_IsValid;

	private static FFieldAddress RemoteEvent_EventName_PropertyAddress;

	private static int RemoteEvent_EventName_Offset;

	private static bool RemoteEvent_ReturnValue_IsValid;

	private static FFieldAddress RemoteEvent_ReturnValue_PropertyAddress;

	private static int RemoteEvent_ReturnValue_Offset;

	private static bool LevelReset_IsValid;

	private IntPtr LevelReset_InstanceFunctionAddress;

	private static IntPtr LevelReset_FunctionAddress;

	private static int LevelReset_ParamsSize;

	[UFunction(Flags = 142739456u)]
	[UMetaPath("/Script/Engine.LevelScriptActor:WorldOriginLocationChanged")]
	public unsafe void WorldOriginLocationChanged(FIntVector OldOriginLocation, FIntVector NewOriginLocation)
	{
		CheckDestroyed();
		if (!WorldOriginLocationChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:WorldOriginLocationChanged");
			return;
		}
		if (WorldOriginLocationChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			WorldOriginLocationChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "WorldOriginLocationChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldOriginLocationChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldOriginLocationChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, WorldOriginLocationChanged_OldOriginLocation_Offset), 0, WorldOriginLocationChanged_OldOriginLocation_PropertyAddress.Address, OldOriginLocation);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, WorldOriginLocationChanged_NewOriginLocation_Offset), 0, WorldOriginLocationChanged_NewOriginLocation_PropertyAddress.Address, NewOriginLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, WorldOriginLocationChanged_InstanceFunctionAddress, intPtr, WorldOriginLocationChanged_ParamsSize);
	}

	protected unsafe virtual void WorldOriginLocationChanged_Implementation(FIntVector OldOriginLocation, FIntVector NewOriginLocation)
	{
		CheckDestroyed();
		if (!WorldOriginLocationChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:WorldOriginLocationChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldOriginLocationChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldOriginLocationChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, WorldOriginLocationChanged_OldOriginLocation_Offset), 0, WorldOriginLocationChanged_OldOriginLocation_PropertyAddress.Address, OldOriginLocation);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, WorldOriginLocationChanged_NewOriginLocation_Offset), 0, WorldOriginLocationChanged_NewOriginLocation_PropertyAddress.Address, NewOriginLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, WorldOriginLocationChanged_FunctionAddress, intPtr, WorldOriginLocationChanged_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.LevelScriptActor:SetCinematicMode")]
	public unsafe void SetCinematicMode(bool bCinematicMode, bool bHidePlayer = true, bool bAffectsHUD = true, bool bAffectsMovement = false, bool bAffectsTurning = false)
	{
		CheckDestroyed();
		if (!SetCinematicMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:SetCinematicMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCinematicMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCinematicMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bCinematicMode_Offset), 0, SetCinematicMode_bCinematicMode_PropertyAddress.Address, bCinematicMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bHidePlayer_Offset), 0, SetCinematicMode_bHidePlayer_PropertyAddress.Address, bHidePlayer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsHUD_Offset), 0, SetCinematicMode_bAffectsHUD_PropertyAddress.Address, bAffectsHUD);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsMovement_Offset), 0, SetCinematicMode_bAffectsMovement_PropertyAddress.Address, bAffectsMovement);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsTurning_Offset), 0, SetCinematicMode_bAffectsTurning_PropertyAddress.Address, bAffectsTurning);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCinematicMode_FunctionAddress, intPtr, SetCinematicMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.LevelScriptActor:RemoteEvent")]
	public unsafe bool RemoteEvent(FName EventName)
	{
		CheckDestroyed();
		if (!RemoteEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:RemoteEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoteEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoteEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoteEvent_EventName_Offset), 0, RemoteEvent_EventName_PropertyAddress.Address, EventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoteEvent_FunctionAddress, intPtr, RemoteEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoteEvent_ReturnValue_Offset), 0, RemoteEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350852u)]
	[UMetaPath("/Script/Engine.LevelScriptActor:LevelReset")]
	public unsafe void LevelReset()
	{
		CheckDestroyed();
		if (!LevelReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:LevelReset");
			return;
		}
		if (LevelReset_InstanceFunctionAddress == IntPtr.Zero)
		{
			LevelReset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "LevelReset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(LevelReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelReset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LevelReset_InstanceFunctionAddress, argsSize: LevelReset_ParamsSize);
	}

	protected unsafe virtual void LevelReset_Implementation()
	{
		CheckDestroyed();
		if (!LevelReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelScriptActor:LevelReset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LevelReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelReset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LevelReset_FunctionAddress, argsSize: LevelReset_ParamsSize);
	}

	static ALevelScriptActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALevelScriptActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALevelScriptActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.LevelScriptActor");
		WorldOriginLocationChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WorldOriginLocationChanged");
		WorldOriginLocationChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldOriginLocationChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldOriginLocationChanged_OldOriginLocation_PropertyAddress, WorldOriginLocationChanged_FunctionAddress, "OldOriginLocation");
		WorldOriginLocationChanged_OldOriginLocation_Offset = NativeReflectionCached.GetPropertyOffset(WorldOriginLocationChanged_FunctionAddress, "OldOriginLocation");
		WorldOriginLocationChanged_OldOriginLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldOriginLocationChanged_FunctionAddress, "OldOriginLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldOriginLocationChanged_NewOriginLocation_PropertyAddress, WorldOriginLocationChanged_FunctionAddress, "NewOriginLocation");
		WorldOriginLocationChanged_NewOriginLocation_Offset = NativeReflectionCached.GetPropertyOffset(WorldOriginLocationChanged_FunctionAddress, "NewOriginLocation");
		WorldOriginLocationChanged_NewOriginLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldOriginLocationChanged_FunctionAddress, "NewOriginLocation", Classes.FStructProperty);
		WorldOriginLocationChanged_IsValid = WorldOriginLocationChanged_FunctionAddress != IntPtr.Zero && WorldOriginLocationChanged_OldOriginLocation_IsValid && WorldOriginLocationChanged_NewOriginLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelScriptActor:WorldOriginLocationChanged", WorldOriginLocationChanged_IsValid);
		SetCinematicMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCinematicMode");
		SetCinematicMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCinematicMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bCinematicMode_PropertyAddress, SetCinematicMode_FunctionAddress, "bCinematicMode");
		SetCinematicMode_bCinematicMode_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bCinematicMode");
		SetCinematicMode_bCinematicMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bCinematicMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bHidePlayer_PropertyAddress, SetCinematicMode_FunctionAddress, "bHidePlayer");
		SetCinematicMode_bHidePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bHidePlayer");
		SetCinematicMode_bHidePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bHidePlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsHUD_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsHUD");
		SetCinematicMode_bAffectsHUD_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsHUD");
		SetCinematicMode_bAffectsHUD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsHUD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsMovement_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsMovement");
		SetCinematicMode_bAffectsMovement_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsMovement");
		SetCinematicMode_bAffectsMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsTurning_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsTurning");
		SetCinematicMode_bAffectsTurning_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsTurning");
		SetCinematicMode_bAffectsTurning_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsTurning", Classes.FBoolProperty);
		SetCinematicMode_IsValid = SetCinematicMode_FunctionAddress != IntPtr.Zero && SetCinematicMode_bCinematicMode_IsValid && SetCinematicMode_bHidePlayer_IsValid && SetCinematicMode_bAffectsHUD_IsValid && SetCinematicMode_bAffectsMovement_IsValid && SetCinematicMode_bAffectsTurning_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelScriptActor:SetCinematicMode", SetCinematicMode_IsValid);
		RemoteEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoteEvent");
		RemoteEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoteEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoteEvent_EventName_PropertyAddress, RemoteEvent_FunctionAddress, "EventName");
		RemoteEvent_EventName_Offset = NativeReflectionCached.GetPropertyOffset(RemoteEvent_FunctionAddress, "EventName");
		RemoteEvent_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoteEvent_FunctionAddress, "EventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoteEvent_ReturnValue_PropertyAddress, RemoteEvent_FunctionAddress, "ReturnValue");
		RemoteEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoteEvent_FunctionAddress, "ReturnValue");
		RemoteEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoteEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoteEvent_IsValid = RemoteEvent_FunctionAddress != IntPtr.Zero && RemoteEvent_EventName_IsValid && RemoteEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelScriptActor:RemoteEvent", RemoteEvent_IsValid);
		LevelReset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LevelReset");
		LevelReset_ParamsSize = NativeReflection.GetFunctionParamsSize(LevelReset_FunctionAddress);
		LevelReset_IsValid = LevelReset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelScriptActor:LevelReset", LevelReset_IsValid);
	}
}
