using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSESceneProcFuncLib", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSESceneProcFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetLandscapeManager_IsValid;

	private static IntPtr GetLandscapeManager_FunctionAddress;

	private static int GetLandscapeManager_ParamsSize;

	private static bool GetLandscapeManager_WorldContextObject_IsValid;

	private static FFieldAddress GetLandscapeManager_WorldContextObject_PropertyAddress;

	private static int GetLandscapeManager_WorldContextObject_Offset;

	private static bool GetLandscapeManager_LandscapeProxy_IsValid;

	private static FFieldAddress GetLandscapeManager_LandscapeProxy_PropertyAddress;

	private static int GetLandscapeManager_LandscapeProxy_Offset;

	private static bool GetLandscapeManager_ReturnValue_IsValid;

	private static FFieldAddress GetLandscapeManager_ReturnValue_PropertyAddress;

	private static int GetLandscapeManager_ReturnValue_Offset;

	private static bool GenGrayBoxLandscapes_IsValid;

	private static IntPtr GenGrayBoxLandscapes_FunctionAddress;

	private static int GenGrayBoxLandscapes_ParamsSize;

	private static bool GenGrayBoxLandscapes_InPersistentLevelFolder_IsValid;

	private static FFieldAddress GenGrayBoxLandscapes_InPersistentLevelFolder_PropertyAddress;

	private static int GenGrayBoxLandscapes_InPersistentLevelFolder_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSESceneProcFuncLib:GetLandscapeManager")]
	public unsafe static AGSEditorLandscapeManager GetLandscapeManager(UObject WorldContextObject, ALandscapeProxy LandscapeProxy)
	{
		if (!GetLandscapeManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSESceneProcFuncLib:GetLandscapeManager");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLandscapeManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLandscapeManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLandscapeManager_WorldContextObject_Offset), 0, GetLandscapeManager_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(intPtr, GetLandscapeManager_LandscapeProxy_Offset), 0, GetLandscapeManager_LandscapeProxy_PropertyAddress.Address, LandscapeProxy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLandscapeManager_FunctionAddress, intPtr, GetLandscapeManager_ParamsSize);
		return UObjectMarshaler<AGSEditorLandscapeManager>.FromNative(IntPtr.Add(intPtr, GetLandscapeManager_ReturnValue_Offset), 0, GetLandscapeManager_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSESceneProcFuncLib:GenGrayBoxLandscapes")]
	public unsafe static void GenGrayBoxLandscapes(string InPersistentLevelFolder)
	{
		if (!GenGrayBoxLandscapes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSESceneProcFuncLib:GenGrayBoxLandscapes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenGrayBoxLandscapes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenGrayBoxLandscapes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenGrayBoxLandscapes_InPersistentLevelFolder_Offset), 0, GenGrayBoxLandscapes_InPersistentLevelFolder_PropertyAddress.Address, InPersistentLevelFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenGrayBoxLandscapes_FunctionAddress, intPtr, GenGrayBoxLandscapes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenGrayBoxLandscapes_InPersistentLevelFolder_PropertyAddress.Address, intPtr);
	}

	static UGSESceneProcFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSESceneProcFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSESceneProcFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSESceneProcFuncLib");
		GetLandscapeManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLandscapeManager");
		GetLandscapeManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLandscapeManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeManager_WorldContextObject_PropertyAddress, GetLandscapeManager_FunctionAddress, "WorldContextObject");
		GetLandscapeManager_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeManager_FunctionAddress, "WorldContextObject");
		GetLandscapeManager_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeManager_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeManager_LandscapeProxy_PropertyAddress, GetLandscapeManager_FunctionAddress, "LandscapeProxy");
		GetLandscapeManager_LandscapeProxy_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeManager_FunctionAddress, "LandscapeProxy");
		GetLandscapeManager_LandscapeProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeManager_FunctionAddress, "LandscapeProxy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeManager_ReturnValue_PropertyAddress, GetLandscapeManager_FunctionAddress, "ReturnValue");
		GetLandscapeManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeManager_FunctionAddress, "ReturnValue");
		GetLandscapeManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeManager_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLandscapeManager_IsValid = GetLandscapeManager_FunctionAddress != IntPtr.Zero && GetLandscapeManager_WorldContextObject_IsValid && GetLandscapeManager_LandscapeProxy_IsValid && GetLandscapeManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSESceneProcFuncLib:GetLandscapeManager", GetLandscapeManager_IsValid);
		GenGrayBoxLandscapes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenGrayBoxLandscapes");
		GenGrayBoxLandscapes_ParamsSize = NativeReflection.GetFunctionParamsSize(GenGrayBoxLandscapes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenGrayBoxLandscapes_InPersistentLevelFolder_PropertyAddress, GenGrayBoxLandscapes_FunctionAddress, "InPersistentLevelFolder");
		GenGrayBoxLandscapes_InPersistentLevelFolder_Offset = NativeReflectionCached.GetPropertyOffset(GenGrayBoxLandscapes_FunctionAddress, "InPersistentLevelFolder");
		GenGrayBoxLandscapes_InPersistentLevelFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(GenGrayBoxLandscapes_FunctionAddress, "InPersistentLevelFolder", Classes.FStrProperty);
		GenGrayBoxLandscapes_IsValid = GenGrayBoxLandscapes_FunctionAddress != IntPtr.Zero && GenGrayBoxLandscapes_InPersistentLevelFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSESceneProcFuncLib:GenGrayBoxLandscapes", GenGrayBoxLandscapes_IsValid);
	}
}
