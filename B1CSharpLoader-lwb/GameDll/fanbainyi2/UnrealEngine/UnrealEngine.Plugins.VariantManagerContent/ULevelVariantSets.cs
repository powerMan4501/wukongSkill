using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContent.LevelVariantSets", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class ULevelVariantSets : UObject
{
	private static bool GetVariantSetByName_IsValid;

	private static IntPtr GetVariantSetByName_FunctionAddress;

	private static int GetVariantSetByName_ParamsSize;

	private static bool GetVariantSetByName_VariantSetName_IsValid;

	private static FFieldAddress GetVariantSetByName_VariantSetName_PropertyAddress;

	private static int GetVariantSetByName_VariantSetName_Offset;

	private static bool GetVariantSetByName_ReturnValue_IsValid;

	private static FFieldAddress GetVariantSetByName_ReturnValue_PropertyAddress;

	private static int GetVariantSetByName_ReturnValue_Offset;

	private static bool GetVariantSet_IsValid;

	private static IntPtr GetVariantSet_FunctionAddress;

	private static int GetVariantSet_ParamsSize;

	private static bool GetVariantSet_VariantSetIndex_IsValid;

	private static FFieldAddress GetVariantSet_VariantSetIndex_PropertyAddress;

	private static int GetVariantSet_VariantSetIndex_Offset;

	private static bool GetVariantSet_ReturnValue_IsValid;

	private static FFieldAddress GetVariantSet_ReturnValue_PropertyAddress;

	private static int GetVariantSet_ReturnValue_Offset;

	private static bool GetNumVariantSets_IsValid;

	private static IntPtr GetNumVariantSets_FunctionAddress;

	private static int GetNumVariantSets_ParamsSize;

	private static bool GetNumVariantSets_ReturnValue_IsValid;

	private static FFieldAddress GetNumVariantSets_ReturnValue_PropertyAddress;

	private static int GetNumVariantSets_ReturnValue_Offset;

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSets:GetVariantSetByName")]
	public unsafe UVariantSet GetVariantSetByName(string VariantSetName)
	{
		CheckDestroyed();
		if (!GetVariantSetByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSets:GetVariantSetByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariantSetByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariantSetByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVariantSetByName_VariantSetName_Offset), 0, GetVariantSetByName_VariantSetName_PropertyAddress.Address, VariantSetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariantSetByName_FunctionAddress, intPtr, GetVariantSetByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVariantSetByName_VariantSetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UVariantSet>.FromNative(IntPtr.Add(intPtr, GetVariantSetByName_ReturnValue_Offset), 0, GetVariantSetByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSets:GetVariantSet")]
	public unsafe UVariantSet GetVariantSet(int VariantSetIndex)
	{
		CheckDestroyed();
		if (!GetVariantSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSets:GetVariantSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariantSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariantSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVariantSet_VariantSetIndex_Offset), 0, GetVariantSet_VariantSetIndex_PropertyAddress.Address, VariantSetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariantSet_FunctionAddress, intPtr, GetVariantSet_ParamsSize);
		return UObjectMarshaler<UVariantSet>.FromNative(IntPtr.Add(intPtr, GetVariantSet_ReturnValue_Offset), 0, GetVariantSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSets:GetNumVariantSets")]
	public unsafe int GetNumVariantSets()
	{
		CheckDestroyed();
		if (!GetNumVariantSets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSets:GetNumVariantSets");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVariantSets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVariantSets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVariantSets_FunctionAddress, intPtr, GetNumVariantSets_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVariantSets_ReturnValue_Offset), 0, GetNumVariantSets_ReturnValue_PropertyAddress.Address);
	}

	static ULevelVariantSets()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelVariantSets)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelVariantSets));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/VariantManagerContent.LevelVariantSets");
		GetVariantSetByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariantSetByName");
		GetVariantSetByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariantSetByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariantSetByName_VariantSetName_PropertyAddress, GetVariantSetByName_FunctionAddress, "VariantSetName");
		GetVariantSetByName_VariantSetName_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantSetByName_FunctionAddress, "VariantSetName");
		GetVariantSetByName_VariantSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantSetByName_FunctionAddress, "VariantSetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariantSetByName_ReturnValue_PropertyAddress, GetVariantSetByName_FunctionAddress, "ReturnValue");
		GetVariantSetByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantSetByName_FunctionAddress, "ReturnValue");
		GetVariantSetByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantSetByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVariantSetByName_IsValid = GetVariantSetByName_FunctionAddress != IntPtr.Zero && GetVariantSetByName_VariantSetName_IsValid && GetVariantSetByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSets:GetVariantSetByName", GetVariantSetByName_IsValid);
		GetVariantSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariantSet");
		GetVariantSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariantSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariantSet_VariantSetIndex_PropertyAddress, GetVariantSet_FunctionAddress, "VariantSetIndex");
		GetVariantSet_VariantSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantSet_FunctionAddress, "VariantSetIndex");
		GetVariantSet_VariantSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantSet_FunctionAddress, "VariantSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariantSet_ReturnValue_PropertyAddress, GetVariantSet_FunctionAddress, "ReturnValue");
		GetVariantSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantSet_FunctionAddress, "ReturnValue");
		GetVariantSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantSet_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVariantSet_IsValid = GetVariantSet_FunctionAddress != IntPtr.Zero && GetVariantSet_VariantSetIndex_IsValid && GetVariantSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSets:GetVariantSet", GetVariantSet_IsValid);
		GetNumVariantSets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVariantSets");
		GetNumVariantSets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVariantSets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVariantSets_ReturnValue_PropertyAddress, GetNumVariantSets_FunctionAddress, "ReturnValue");
		GetNumVariantSets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVariantSets_FunctionAddress, "ReturnValue");
		GetNumVariantSets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVariantSets_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVariantSets_IsValid = GetNumVariantSets_FunctionAddress != IntPtr.Zero && GetNumVariantSets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSets:GetNumVariantSets", GetNumVariantSets_IsValid);
	}
}
