using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequence", "LevelSequence", UnrealModuleType.Engine)]
public class ULevelSequence : UMovieSceneSequence, IInterface_AssetUserData, IInterface
{
	private static bool RemoveMetaDataByClass_IsValid;

	private static IntPtr RemoveMetaDataByClass_FunctionAddress;

	private static int RemoveMetaDataByClass_ParamsSize;

	private static bool RemoveMetaDataByClass_InClass_IsValid;

	private static FFieldAddress RemoveMetaDataByClass_InClass_PropertyAddress;

	private static int RemoveMetaDataByClass_InClass_Offset;

	private static bool FindOrAddMetaDataByClass_IsValid;

	private static IntPtr FindOrAddMetaDataByClass_FunctionAddress;

	private static int FindOrAddMetaDataByClass_ParamsSize;

	private static bool FindOrAddMetaDataByClass_InClass_IsValid;

	private static FFieldAddress FindOrAddMetaDataByClass_InClass_PropertyAddress;

	private static int FindOrAddMetaDataByClass_InClass_Offset;

	private static bool FindOrAddMetaDataByClass_ReturnValue_IsValid;

	private static FFieldAddress FindOrAddMetaDataByClass_ReturnValue_PropertyAddress;

	private static int FindOrAddMetaDataByClass_ReturnValue_Offset;

	private static bool FindMetaDataByClass_IsValid;

	private static IntPtr FindMetaDataByClass_FunctionAddress;

	private static int FindMetaDataByClass_ParamsSize;

	private static bool FindMetaDataByClass_InClass_IsValid;

	private static FFieldAddress FindMetaDataByClass_InClass_PropertyAddress;

	private static int FindMetaDataByClass_InClass_Offset;

	private static bool FindMetaDataByClass_ReturnValue_IsValid;

	private static FFieldAddress FindMetaDataByClass_ReturnValue_PropertyAddress;

	private static int FindMetaDataByClass_ReturnValue_Offset;

	private static bool CopyMetaData_IsValid;

	private static IntPtr CopyMetaData_FunctionAddress;

	private static int CopyMetaData_ParamsSize;

	private static bool CopyMetaData_InMetaData_IsValid;

	private static FFieldAddress CopyMetaData_InMetaData_PropertyAddress;

	private static int CopyMetaData_InMetaData_Offset;

	private static bool CopyMetaData_ReturnValue_IsValid;

	private static FFieldAddress CopyMetaData_ReturnValue_PropertyAddress;

	private static int CopyMetaData_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequence:RemoveMetaDataByClass")]
	public unsafe void RemoveMetaDataByClass(TSubclassOf<UObject> InClass)
	{
		CheckDestroyed();
		if (!RemoveMetaDataByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequence:RemoveMetaDataByClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMetaDataByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMetaDataByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveMetaDataByClass_InClass_Offset), 0, RemoveMetaDataByClass_InClass_PropertyAddress.Address, InClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMetaDataByClass_FunctionAddress, intPtr, RemoveMetaDataByClass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequence:FindOrAddMetaDataByClass")]
	public unsafe UObject FindOrAddMetaDataByClass(TSubclassOf<UObject> InClass)
	{
		CheckDestroyed();
		if (!FindOrAddMetaDataByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequence:FindOrAddMetaDataByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOrAddMetaDataByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOrAddMetaDataByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindOrAddMetaDataByClass_InClass_Offset), 0, FindOrAddMetaDataByClass_InClass_PropertyAddress.Address, InClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindOrAddMetaDataByClass_FunctionAddress, intPtr, FindOrAddMetaDataByClass_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FindOrAddMetaDataByClass_ReturnValue_Offset), 0, FindOrAddMetaDataByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequence:FindMetaDataByClass")]
	public unsafe UObject FindMetaDataByClass(TSubclassOf<UObject> InClass)
	{
		CheckDestroyed();
		if (!FindMetaDataByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequence:FindMetaDataByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMetaDataByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMetaDataByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindMetaDataByClass_InClass_Offset), 0, FindMetaDataByClass_InClass_PropertyAddress.Address, InClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindMetaDataByClass_FunctionAddress, intPtr, FindMetaDataByClass_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FindMetaDataByClass_ReturnValue_Offset), 0, FindMetaDataByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequence:CopyMetaData")]
	public unsafe UObject CopyMetaData(UObject InMetaData)
	{
		CheckDestroyed();
		if (!CopyMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequence:CopyMetaData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CopyMetaData_InMetaData_Offset), 0, CopyMetaData_InMetaData_PropertyAddress.Address, InMetaData);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyMetaData_FunctionAddress, intPtr, CopyMetaData_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CopyMetaData_ReturnValue_Offset), 0, CopyMetaData_ReturnValue_PropertyAddress.Address);
	}

	static ULevelSequence()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequence));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/LevelSequence.LevelSequence");
		RemoveMetaDataByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveMetaDataByClass");
		RemoveMetaDataByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMetaDataByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetaDataByClass_InClass_PropertyAddress, RemoveMetaDataByClass_FunctionAddress, "InClass");
		RemoveMetaDataByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetaDataByClass_FunctionAddress, "InClass");
		RemoveMetaDataByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetaDataByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		RemoveMetaDataByClass_IsValid = RemoveMetaDataByClass_FunctionAddress != IntPtr.Zero && RemoveMetaDataByClass_InClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequence:RemoveMetaDataByClass", RemoveMetaDataByClass_IsValid);
		FindOrAddMetaDataByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindOrAddMetaDataByClass");
		FindOrAddMetaDataByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrAddMetaDataByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddMetaDataByClass_InClass_PropertyAddress, FindOrAddMetaDataByClass_FunctionAddress, "InClass");
		FindOrAddMetaDataByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddMetaDataByClass_FunctionAddress, "InClass");
		FindOrAddMetaDataByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddMetaDataByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddMetaDataByClass_ReturnValue_PropertyAddress, FindOrAddMetaDataByClass_FunctionAddress, "ReturnValue");
		FindOrAddMetaDataByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddMetaDataByClass_FunctionAddress, "ReturnValue");
		FindOrAddMetaDataByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddMetaDataByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindOrAddMetaDataByClass_IsValid = FindOrAddMetaDataByClass_FunctionAddress != IntPtr.Zero && FindOrAddMetaDataByClass_InClass_IsValid && FindOrAddMetaDataByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequence:FindOrAddMetaDataByClass", FindOrAddMetaDataByClass_IsValid);
		FindMetaDataByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindMetaDataByClass");
		FindMetaDataByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMetaDataByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMetaDataByClass_InClass_PropertyAddress, FindMetaDataByClass_FunctionAddress, "InClass");
		FindMetaDataByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(FindMetaDataByClass_FunctionAddress, "InClass");
		FindMetaDataByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMetaDataByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMetaDataByClass_ReturnValue_PropertyAddress, FindMetaDataByClass_FunctionAddress, "ReturnValue");
		FindMetaDataByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMetaDataByClass_FunctionAddress, "ReturnValue");
		FindMetaDataByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMetaDataByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindMetaDataByClass_IsValid = FindMetaDataByClass_FunctionAddress != IntPtr.Zero && FindMetaDataByClass_InClass_IsValid && FindMetaDataByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequence:FindMetaDataByClass", FindMetaDataByClass_IsValid);
		CopyMetaData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyMetaData");
		CopyMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMetaData_InMetaData_PropertyAddress, CopyMetaData_FunctionAddress, "InMetaData");
		CopyMetaData_InMetaData_Offset = NativeReflectionCached.GetPropertyOffset(CopyMetaData_FunctionAddress, "InMetaData");
		CopyMetaData_InMetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMetaData_FunctionAddress, "InMetaData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMetaData_ReturnValue_PropertyAddress, CopyMetaData_FunctionAddress, "ReturnValue");
		CopyMetaData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyMetaData_FunctionAddress, "ReturnValue");
		CopyMetaData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMetaData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyMetaData_IsValid = CopyMetaData_FunctionAddress != IntPtr.Zero && CopyMetaData_InMetaData_IsValid && CopyMetaData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequence:CopyMetaData", CopyMetaData_IsValid);
	}
}
