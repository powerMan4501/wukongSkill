using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SaveGameFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SaveGameFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SaveDataToSlot_IsValid;

	private static IntPtr SaveDataToSlot_FunctionAddress;

	private static int SaveDataToSlot_ParamsSize;

	private static bool SaveDataToSlot_InSaveData_IsValid;

	private static FFieldAddress SaveDataToSlot_InSaveData_PropertyAddress;

	private static int SaveDataToSlot_InSaveData_Offset;

	private static bool SaveDataToSlot_SlotName_IsValid;

	private static FFieldAddress SaveDataToSlot_SlotName_PropertyAddress;

	private static int SaveDataToSlot_SlotName_Offset;

	private static bool SaveDataToSlot_UserIndex_IsValid;

	private static FFieldAddress SaveDataToSlot_UserIndex_PropertyAddress;

	private static int SaveDataToSlot_UserIndex_Offset;

	private static bool SaveDataToSlot_ReturnValue_IsValid;

	private static FFieldAddress SaveDataToSlot_ReturnValue_PropertyAddress;

	private static int SaveDataToSlot_ReturnValue_Offset;

	private static bool LoadDataFromSlot_IsValid;

	private static IntPtr LoadDataFromSlot_FunctionAddress;

	private static int LoadDataFromSlot_ParamsSize;

	private static bool LoadDataFromSlot_OutSaveData_IsValid;

	private static FFieldAddress LoadDataFromSlot_OutSaveData_PropertyAddress;

	private static int LoadDataFromSlot_OutSaveData_Offset;

	private static bool LoadDataFromSlot_SlotName_IsValid;

	private static FFieldAddress LoadDataFromSlot_SlotName_PropertyAddress;

	private static int LoadDataFromSlot_SlotName_Offset;

	private static bool LoadDataFromSlot_UserIndex_IsValid;

	private static FFieldAddress LoadDataFromSlot_UserIndex_PropertyAddress;

	private static int LoadDataFromSlot_UserIndex_Offset;

	private static bool LoadDataFromSlot_ReturnValue_IsValid;

	private static FFieldAddress LoadDataFromSlot_ReturnValue_PropertyAddress;

	private static int LoadDataFromSlot_ReturnValue_Offset;

	private static bool GetAllSaveGameSlotNames_IsValid;

	private static IntPtr GetAllSaveGameSlotNames_FunctionAddress;

	private static int GetAllSaveGameSlotNames_ParamsSize;

	private static bool GetAllSaveGameSlotNames_ReturnValue_IsValid;

	private static FFieldAddress GetAllSaveGameSlotNames_ReturnValue_PropertyAddress;

	private static int GetAllSaveGameSlotNames_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SaveGameFuncLib:SaveDataToSlot")]
	public unsafe static bool SaveDataToSlot(List<byte> InSaveData, string SlotName, int UserIndex)
	{
		if (!SaveDataToSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SaveGameFuncLib:SaveDataToSlot");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveDataToSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveDataToSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<byte>(1, SaveDataToSlot_InSaveData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveDataToSlot_InSaveData_Offset), InSaveData);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveDataToSlot_SlotName_Offset), 0, SaveDataToSlot_SlotName_PropertyAddress.Address, SlotName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveDataToSlot_UserIndex_Offset), 0, SaveDataToSlot_UserIndex_PropertyAddress.Address, UserIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveDataToSlot_FunctionAddress, intPtr, SaveDataToSlot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveDataToSlot_InSaveData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveDataToSlot_SlotName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveDataToSlot_ReturnValue_Offset), 0, SaveDataToSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SaveGameFuncLib:LoadDataFromSlot")]
	public unsafe static bool LoadDataFromSlot(out List<byte> OutSaveData, string SlotName, int UserIndex)
	{
		if (!LoadDataFromSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SaveGameFuncLib:LoadDataFromSlot");
			OutSaveData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadDataFromSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadDataFromSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadDataFromSlot_SlotName_Offset), 0, LoadDataFromSlot_SlotName_PropertyAddress.Address, SlotName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LoadDataFromSlot_UserIndex_Offset), 0, LoadDataFromSlot_UserIndex_PropertyAddress.Address, UserIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadDataFromSlot_FunctionAddress, intPtr, LoadDataFromSlot_ParamsSize);
		OutSaveData = new TArrayCopyMarshaler<byte>(1, LoadDataFromSlot_OutSaveData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadDataFromSlot_OutSaveData_Offset));
		NativeReflection.DestroyValue_InContainer(LoadDataFromSlot_OutSaveData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(LoadDataFromSlot_SlotName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadDataFromSlot_ReturnValue_Offset), 0, LoadDataFromSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SaveGameFuncLib:GetAllSaveGameSlotNames")]
	public unsafe static List<string> GetAllSaveGameSlotNames()
	{
		if (!GetAllSaveGameSlotNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SaveGameFuncLib:GetAllSaveGameSlotNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSaveGameSlotNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSaveGameSlotNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllSaveGameSlotNames_FunctionAddress, intPtr, GetAllSaveGameSlotNames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAllSaveGameSlotNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSaveGameSlotNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSaveGameSlotNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_SaveGameFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SaveGameFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SaveGameFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SaveGameFuncLib");
		SaveDataToSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveDataToSlot");
		SaveDataToSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveDataToSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveDataToSlot_InSaveData_PropertyAddress, SaveDataToSlot_FunctionAddress, "InSaveData");
		SaveDataToSlot_InSaveData_Offset = NativeReflectionCached.GetPropertyOffset(SaveDataToSlot_FunctionAddress, "InSaveData");
		SaveDataToSlot_InSaveData_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDataToSlot_FunctionAddress, "InSaveData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDataToSlot_SlotName_PropertyAddress, SaveDataToSlot_FunctionAddress, "SlotName");
		SaveDataToSlot_SlotName_Offset = NativeReflectionCached.GetPropertyOffset(SaveDataToSlot_FunctionAddress, "SlotName");
		SaveDataToSlot_SlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDataToSlot_FunctionAddress, "SlotName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDataToSlot_UserIndex_PropertyAddress, SaveDataToSlot_FunctionAddress, "UserIndex");
		SaveDataToSlot_UserIndex_Offset = NativeReflectionCached.GetPropertyOffset(SaveDataToSlot_FunctionAddress, "UserIndex");
		SaveDataToSlot_UserIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDataToSlot_FunctionAddress, "UserIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDataToSlot_ReturnValue_PropertyAddress, SaveDataToSlot_FunctionAddress, "ReturnValue");
		SaveDataToSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveDataToSlot_FunctionAddress, "ReturnValue");
		SaveDataToSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDataToSlot_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveDataToSlot_IsValid = SaveDataToSlot_FunctionAddress != IntPtr.Zero && SaveDataToSlot_InSaveData_IsValid && SaveDataToSlot_SlotName_IsValid && SaveDataToSlot_UserIndex_IsValid && SaveDataToSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SaveGameFuncLib:SaveDataToSlot", SaveDataToSlot_IsValid);
		LoadDataFromSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadDataFromSlot");
		LoadDataFromSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadDataFromSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadDataFromSlot_OutSaveData_PropertyAddress, LoadDataFromSlot_FunctionAddress, "OutSaveData");
		LoadDataFromSlot_OutSaveData_Offset = NativeReflectionCached.GetPropertyOffset(LoadDataFromSlot_FunctionAddress, "OutSaveData");
		LoadDataFromSlot_OutSaveData_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadDataFromSlot_FunctionAddress, "OutSaveData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadDataFromSlot_SlotName_PropertyAddress, LoadDataFromSlot_FunctionAddress, "SlotName");
		LoadDataFromSlot_SlotName_Offset = NativeReflectionCached.GetPropertyOffset(LoadDataFromSlot_FunctionAddress, "SlotName");
		LoadDataFromSlot_SlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadDataFromSlot_FunctionAddress, "SlotName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadDataFromSlot_UserIndex_PropertyAddress, LoadDataFromSlot_FunctionAddress, "UserIndex");
		LoadDataFromSlot_UserIndex_Offset = NativeReflectionCached.GetPropertyOffset(LoadDataFromSlot_FunctionAddress, "UserIndex");
		LoadDataFromSlot_UserIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadDataFromSlot_FunctionAddress, "UserIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadDataFromSlot_ReturnValue_PropertyAddress, LoadDataFromSlot_FunctionAddress, "ReturnValue");
		LoadDataFromSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadDataFromSlot_FunctionAddress, "ReturnValue");
		LoadDataFromSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadDataFromSlot_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadDataFromSlot_IsValid = LoadDataFromSlot_FunctionAddress != IntPtr.Zero && LoadDataFromSlot_OutSaveData_IsValid && LoadDataFromSlot_SlotName_IsValid && LoadDataFromSlot_UserIndex_IsValid && LoadDataFromSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SaveGameFuncLib:LoadDataFromSlot", LoadDataFromSlot_IsValid);
		GetAllSaveGameSlotNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllSaveGameSlotNames");
		GetAllSaveGameSlotNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSaveGameSlotNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSaveGameSlotNames_ReturnValue_PropertyAddress, GetAllSaveGameSlotNames_FunctionAddress, "ReturnValue");
		GetAllSaveGameSlotNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSaveGameSlotNames_FunctionAddress, "ReturnValue");
		GetAllSaveGameSlotNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSaveGameSlotNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSaveGameSlotNames_IsValid = GetAllSaveGameSlotNames_FunctionAddress != IntPtr.Zero && GetAllSaveGameSlotNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SaveGameFuncLib:GetAllSaveGameSlotNames", GetAllSaveGameSlotNames_IsValid);
	}
}
