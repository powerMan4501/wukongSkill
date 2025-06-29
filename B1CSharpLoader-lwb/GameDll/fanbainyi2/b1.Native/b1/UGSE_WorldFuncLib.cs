using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_WorldFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WorldViewportForeground_IsValid;

	private static IntPtr WorldViewportForeground_FunctionAddress;

	private static int WorldViewportForeground_ParamsSize;

	private static bool WorldViewportForeground_World_IsValid;

	private static FFieldAddress WorldViewportForeground_World_PropertyAddress;

	private static int WorldViewportForeground_World_Offset;

	private static bool WorldViewportForeground_ReturnValue_IsValid;

	private static FFieldAddress WorldViewportForeground_ReturnValue_PropertyAddress;

	private static int WorldViewportForeground_ReturnValue_Offset;

	private static bool WorldViewportCursorVisible_IsValid;

	private static IntPtr WorldViewportCursorVisible_FunctionAddress;

	private static int WorldViewportCursorVisible_ParamsSize;

	private static bool WorldViewportCursorVisible_World_IsValid;

	private static FFieldAddress WorldViewportCursorVisible_World_PropertyAddress;

	private static int WorldViewportCursorVisible_World_Offset;

	private static bool WorldViewportCursorVisible_ReturnValue_IsValid;

	private static FFieldAddress WorldViewportCursorVisible_ReturnValue_PropertyAddress;

	private static int WorldViewportCursorVisible_ReturnValue_Offset;

	private static bool WorldSetCurrentLevel_IsValid;

	private static IntPtr WorldSetCurrentLevel_FunctionAddress;

	private static int WorldSetCurrentLevel_ParamsSize;

	private static bool WorldSetCurrentLevel_World_IsValid;

	private static FFieldAddress WorldSetCurrentLevel_World_PropertyAddress;

	private static int WorldSetCurrentLevel_World_Offset;

	private static bool WorldSetCurrentLevel_InLevel_IsValid;

	private static FFieldAddress WorldSetCurrentLevel_InLevel_PropertyAddress;

	private static int WorldSetCurrentLevel_InLevel_Offset;

	private static bool WorldSetCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress WorldSetCurrentLevel_ReturnValue_PropertyAddress;

	private static int WorldSetCurrentLevel_ReturnValue_Offset;

	private static bool WorldGetPersistentLevel_IsValid;

	private static IntPtr WorldGetPersistentLevel_FunctionAddress;

	private static int WorldGetPersistentLevel_ParamsSize;

	private static bool WorldGetPersistentLevel_World_IsValid;

	private static FFieldAddress WorldGetPersistentLevel_World_PropertyAddress;

	private static int WorldGetPersistentLevel_World_Offset;

	private static bool WorldGetPersistentLevel_ReturnValue_IsValid;

	private static FFieldAddress WorldGetPersistentLevel_ReturnValue_PropertyAddress;

	private static int WorldGetPersistentLevel_ReturnValue_Offset;

	private static bool WorldGetCurrentLevel_IsValid;

	private static IntPtr WorldGetCurrentLevel_FunctionAddress;

	private static int WorldGetCurrentLevel_ParamsSize;

	private static bool WorldGetCurrentLevel_World_IsValid;

	private static FFieldAddress WorldGetCurrentLevel_World_PropertyAddress;

	private static int WorldGetCurrentLevel_World_Offset;

	private static bool WorldGetCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress WorldGetCurrentLevel_ReturnValue_PropertyAddress;

	private static int WorldGetCurrentLevel_ReturnValue_Offset;

	private static bool NotifyWorldSettingsMatchStart_IsValid;

	private static IntPtr NotifyWorldSettingsMatchStart_FunctionAddress;

	private static int NotifyWorldSettingsMatchStart_ParamsSize;

	private static bool NotifyWorldSettingsMatchStart_World_IsValid;

	private static FFieldAddress NotifyWorldSettingsMatchStart_World_PropertyAddress;

	private static int NotifyWorldSettingsMatchStart_World_Offset;

	private static bool NotifyWorldSettingsBeginPlay_IsValid;

	private static IntPtr NotifyWorldSettingsBeginPlay_FunctionAddress;

	private static int NotifyWorldSettingsBeginPlay_ParamsSize;

	private static bool NotifyWorldSettingsBeginPlay_World_IsValid;

	private static FFieldAddress NotifyWorldSettingsBeginPlay_World_PropertyAddress;

	private static int NotifyWorldSettingsBeginPlay_World_Offset;

	private static bool GetWorldSettings_IsValid;

	private static IntPtr GetWorldSettings_FunctionAddress;

	private static int GetWorldSettings_ParamsSize;

	private static bool GetWorldSettings_Level_IsValid;

	private static FFieldAddress GetWorldSettings_Level_PropertyAddress;

	private static int GetWorldSettings_Level_Offset;

	private static bool GetWorldSettings_bChecked_IsValid;

	private static FFieldAddress GetWorldSettings_bChecked_PropertyAddress;

	private static int GetWorldSettings_bChecked_Offset;

	private static bool GetWorldSettings_ReturnValue_IsValid;

	private static FFieldAddress GetWorldSettings_ReturnValue_PropertyAddress;

	private static int GetWorldSettings_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportForeground")]
	public unsafe static bool WorldViewportForeground(UWorld World)
	{
		if (!WorldViewportForeground_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportForeground");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldViewportForeground_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldViewportForeground_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldViewportForeground_World_Offset), 0, WorldViewportForeground_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldViewportForeground_FunctionAddress, intPtr, WorldViewportForeground_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WorldViewportForeground_ReturnValue_Offset), 0, WorldViewportForeground_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportCursorVisible")]
	public unsafe static bool WorldViewportCursorVisible(UWorld World)
	{
		if (!WorldViewportCursorVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportCursorVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldViewportCursorVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldViewportCursorVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldViewportCursorVisible_World_Offset), 0, WorldViewportCursorVisible_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldViewportCursorVisible_FunctionAddress, intPtr, WorldViewportCursorVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WorldViewportCursorVisible_ReturnValue_Offset), 0, WorldViewportCursorVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 872555521u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:WorldSetCurrentLevel")]
	public unsafe static bool WorldSetCurrentLevel(UWorld World, ULevel InLevel)
	{
		if (!WorldSetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:WorldSetCurrentLevel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldSetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldSetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldSetCurrentLevel_World_Offset), 0, WorldSetCurrentLevel_World_PropertyAddress.Address, World);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, WorldSetCurrentLevel_InLevel_Offset), 0, WorldSetCurrentLevel_InLevel_PropertyAddress.Address, InLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldSetCurrentLevel_FunctionAddress, intPtr, WorldSetCurrentLevel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WorldSetCurrentLevel_ReturnValue_Offset), 0, WorldSetCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetPersistentLevel")]
	public unsafe static ULevel WorldGetPersistentLevel(UWorld World)
	{
		if (!WorldGetPersistentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetPersistentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldGetPersistentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldGetPersistentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldGetPersistentLevel_World_Offset), 0, WorldGetPersistentLevel_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldGetPersistentLevel_FunctionAddress, intPtr, WorldGetPersistentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, WorldGetPersistentLevel_ReturnValue_Offset), 0, WorldGetPersistentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetCurrentLevel")]
	public unsafe static ULevel WorldGetCurrentLevel(UWorld World)
	{
		if (!WorldGetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetCurrentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldGetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldGetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldGetCurrentLevel_World_Offset), 0, WorldGetCurrentLevel_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldGetCurrentLevel_FunctionAddress, intPtr, WorldGetCurrentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, WorldGetCurrentLevel_ReturnValue_Offset), 0, WorldGetCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsMatchStart")]
	public unsafe static void NotifyWorldSettingsMatchStart(UWorld World)
	{
		if (!NotifyWorldSettingsMatchStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsMatchStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyWorldSettingsMatchStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyWorldSettingsMatchStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, NotifyWorldSettingsMatchStart_World_Offset), 0, NotifyWorldSettingsMatchStart_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotifyWorldSettingsMatchStart_FunctionAddress, intPtr, NotifyWorldSettingsMatchStart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsBeginPlay")]
	public unsafe static void NotifyWorldSettingsBeginPlay(UWorld World)
	{
		if (!NotifyWorldSettingsBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsBeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyWorldSettingsBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyWorldSettingsBeginPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, NotifyWorldSettingsBeginPlay_World_Offset), 0, NotifyWorldSettingsBeginPlay_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotifyWorldSettingsBeginPlay_FunctionAddress, intPtr, NotifyWorldSettingsBeginPlay_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WorldFuncLib:GetWorldSettings")]
	public unsafe static AWorldSettings GetWorldSettings(ULevel Level, bool bChecked = true)
	{
		if (!GetWorldSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WorldFuncLib:GetWorldSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GetWorldSettings_Level_Offset), 0, GetWorldSettings_Level_PropertyAddress.Address, Level);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetWorldSettings_bChecked_Offset), 0, GetWorldSettings_bChecked_PropertyAddress.Address, bChecked);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldSettings_FunctionAddress, intPtr, GetWorldSettings_ParamsSize);
		return UObjectMarshaler<AWorldSettings>.FromNative(IntPtr.Add(intPtr, GetWorldSettings_ReturnValue_Offset), 0, GetWorldSettings_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_WorldFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_WorldFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_WorldFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_WorldFuncLib");
		WorldViewportForeground_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldViewportForeground");
		WorldViewportForeground_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldViewportForeground_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldViewportForeground_World_PropertyAddress, WorldViewportForeground_FunctionAddress, "World");
		WorldViewportForeground_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldViewportForeground_FunctionAddress, "World");
		WorldViewportForeground_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldViewportForeground_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldViewportForeground_ReturnValue_PropertyAddress, WorldViewportForeground_FunctionAddress, "ReturnValue");
		WorldViewportForeground_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldViewportForeground_FunctionAddress, "ReturnValue");
		WorldViewportForeground_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldViewportForeground_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WorldViewportForeground_IsValid = WorldViewportForeground_FunctionAddress != IntPtr.Zero && WorldViewportForeground_World_IsValid && WorldViewportForeground_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportForeground", WorldViewportForeground_IsValid);
		WorldViewportCursorVisible_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldViewportCursorVisible");
		WorldViewportCursorVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldViewportCursorVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldViewportCursorVisible_World_PropertyAddress, WorldViewportCursorVisible_FunctionAddress, "World");
		WorldViewportCursorVisible_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldViewportCursorVisible_FunctionAddress, "World");
		WorldViewportCursorVisible_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldViewportCursorVisible_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldViewportCursorVisible_ReturnValue_PropertyAddress, WorldViewportCursorVisible_FunctionAddress, "ReturnValue");
		WorldViewportCursorVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldViewportCursorVisible_FunctionAddress, "ReturnValue");
		WorldViewportCursorVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldViewportCursorVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WorldViewportCursorVisible_IsValid = WorldViewportCursorVisible_FunctionAddress != IntPtr.Zero && WorldViewportCursorVisible_World_IsValid && WorldViewportCursorVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:WorldViewportCursorVisible", WorldViewportCursorVisible_IsValid);
		WorldSetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldSetCurrentLevel");
		WorldSetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldSetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldSetCurrentLevel_World_PropertyAddress, WorldSetCurrentLevel_FunctionAddress, "World");
		WorldSetCurrentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldSetCurrentLevel_FunctionAddress, "World");
		WorldSetCurrentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldSetCurrentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldSetCurrentLevel_InLevel_PropertyAddress, WorldSetCurrentLevel_FunctionAddress, "InLevel");
		WorldSetCurrentLevel_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(WorldSetCurrentLevel_FunctionAddress, "InLevel");
		WorldSetCurrentLevel_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldSetCurrentLevel_FunctionAddress, "InLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldSetCurrentLevel_ReturnValue_PropertyAddress, WorldSetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldSetCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldSetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldSetCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldSetCurrentLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WorldSetCurrentLevel_IsValid = WorldSetCurrentLevel_FunctionAddress != IntPtr.Zero && WorldSetCurrentLevel_World_IsValid && WorldSetCurrentLevel_InLevel_IsValid && WorldSetCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:WorldSetCurrentLevel", WorldSetCurrentLevel_IsValid);
		WorldGetPersistentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldGetPersistentLevel");
		WorldGetPersistentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldGetPersistentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldGetPersistentLevel_World_PropertyAddress, WorldGetPersistentLevel_FunctionAddress, "World");
		WorldGetPersistentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetPersistentLevel_FunctionAddress, "World");
		WorldGetPersistentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetPersistentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldGetPersistentLevel_ReturnValue_PropertyAddress, WorldGetPersistentLevel_FunctionAddress, "ReturnValue");
		WorldGetPersistentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetPersistentLevel_FunctionAddress, "ReturnValue");
		WorldGetPersistentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetPersistentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		WorldGetPersistentLevel_IsValid = WorldGetPersistentLevel_FunctionAddress != IntPtr.Zero && WorldGetPersistentLevel_World_IsValid && WorldGetPersistentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetPersistentLevel", WorldGetPersistentLevel_IsValid);
		WorldGetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldGetCurrentLevel");
		WorldGetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldGetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldGetCurrentLevel_World_PropertyAddress, WorldGetCurrentLevel_FunctionAddress, "World");
		WorldGetCurrentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetCurrentLevel_FunctionAddress, "World");
		WorldGetCurrentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetCurrentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldGetCurrentLevel_ReturnValue_PropertyAddress, WorldGetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldGetCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldGetCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetCurrentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		WorldGetCurrentLevel_IsValid = WorldGetCurrentLevel_FunctionAddress != IntPtr.Zero && WorldGetCurrentLevel_World_IsValid && WorldGetCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:WorldGetCurrentLevel", WorldGetCurrentLevel_IsValid);
		NotifyWorldSettingsMatchStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotifyWorldSettingsMatchStart");
		NotifyWorldSettingsMatchStart_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyWorldSettingsMatchStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyWorldSettingsMatchStart_World_PropertyAddress, NotifyWorldSettingsMatchStart_FunctionAddress, "World");
		NotifyWorldSettingsMatchStart_World_Offset = NativeReflectionCached.GetPropertyOffset(NotifyWorldSettingsMatchStart_FunctionAddress, "World");
		NotifyWorldSettingsMatchStart_World_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyWorldSettingsMatchStart_FunctionAddress, "World", Classes.FObjectProperty);
		NotifyWorldSettingsMatchStart_IsValid = NotifyWorldSettingsMatchStart_FunctionAddress != IntPtr.Zero && NotifyWorldSettingsMatchStart_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsMatchStart", NotifyWorldSettingsMatchStart_IsValid);
		NotifyWorldSettingsBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotifyWorldSettingsBeginPlay");
		NotifyWorldSettingsBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyWorldSettingsBeginPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyWorldSettingsBeginPlay_World_PropertyAddress, NotifyWorldSettingsBeginPlay_FunctionAddress, "World");
		NotifyWorldSettingsBeginPlay_World_Offset = NativeReflectionCached.GetPropertyOffset(NotifyWorldSettingsBeginPlay_FunctionAddress, "World");
		NotifyWorldSettingsBeginPlay_World_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyWorldSettingsBeginPlay_FunctionAddress, "World", Classes.FObjectProperty);
		NotifyWorldSettingsBeginPlay_IsValid = NotifyWorldSettingsBeginPlay_FunctionAddress != IntPtr.Zero && NotifyWorldSettingsBeginPlay_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:NotifyWorldSettingsBeginPlay", NotifyWorldSettingsBeginPlay_IsValid);
		GetWorldSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldSettings");
		GetWorldSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSettings_Level_PropertyAddress, GetWorldSettings_FunctionAddress, "Level");
		GetWorldSettings_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSettings_FunctionAddress, "Level");
		GetWorldSettings_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSettings_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSettings_bChecked_PropertyAddress, GetWorldSettings_FunctionAddress, "bChecked");
		GetWorldSettings_bChecked_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSettings_FunctionAddress, "bChecked");
		GetWorldSettings_bChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSettings_FunctionAddress, "bChecked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSettings_ReturnValue_PropertyAddress, GetWorldSettings_FunctionAddress, "ReturnValue");
		GetWorldSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSettings_FunctionAddress, "ReturnValue");
		GetWorldSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldSettings_IsValid = GetWorldSettings_FunctionAddress != IntPtr.Zero && GetWorldSettings_Level_IsValid && GetWorldSettings_bChecked_IsValid && GetWorldSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WorldFuncLib:GetWorldSettings", GetWorldSettings_IsValid);
	}
}
