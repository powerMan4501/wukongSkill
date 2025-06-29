using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GSEngineExtent.EditorFuncLibCommon", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public class UEditorFuncLibCommon : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UMGTemplate_GetLearnID_IsValid;

	private static IntPtr UMGTemplate_GetLearnID_FunctionAddress;

	private static int UMGTemplate_GetLearnID_ParamsSize;

	private static bool UMGTemplate_GetLearnID_UnitID_IsValid;

	private static FFieldAddress UMGTemplate_GetLearnID_UnitID_PropertyAddress;

	private static int UMGTemplate_GetLearnID_UnitID_Offset;

	private static bool UMGTemplate_GetLearnID_LearnID_IsValid;

	private static FFieldAddress UMGTemplate_GetLearnID_LearnID_PropertyAddress;

	private static int UMGTemplate_GetLearnID_LearnID_Offset;

	private static bool UMGTemplate_GetLearnID_ReturnValue_IsValid;

	private static FFieldAddress UMGTemplate_GetLearnID_ReturnValue_PropertyAddress;

	private static int UMGTemplate_GetLearnID_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEngineExtent.EditorFuncLibCommon:UMGTemplate_GetLearnID")]
	public unsafe static int UMGTemplate_GetLearnID(int UnitID, int LearnID)
	{
		if (!UMGTemplate_GetLearnID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.EditorFuncLibCommon:UMGTemplate_GetLearnID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UMGTemplate_GetLearnID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UMGTemplate_GetLearnID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UMGTemplate_GetLearnID_UnitID_Offset), 0, UMGTemplate_GetLearnID_UnitID_PropertyAddress.Address, UnitID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UMGTemplate_GetLearnID_LearnID_Offset), 0, UMGTemplate_GetLearnID_LearnID_PropertyAddress.Address, LearnID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UMGTemplate_GetLearnID_FunctionAddress, intPtr, UMGTemplate_GetLearnID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, UMGTemplate_GetLearnID_ReturnValue_Offset), 0, UMGTemplate_GetLearnID_ReturnValue_PropertyAddress.Address);
	}

	static UEditorFuncLibCommon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorFuncLibCommon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorFuncLibCommon));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSEngineExtent.EditorFuncLibCommon");
		UMGTemplate_GetLearnID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UMGTemplate_GetLearnID");
		UMGTemplate_GetLearnID_ParamsSize = NativeReflection.GetFunctionParamsSize(UMGTemplate_GetLearnID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UMGTemplate_GetLearnID_UnitID_PropertyAddress, UMGTemplate_GetLearnID_FunctionAddress, "UnitID");
		UMGTemplate_GetLearnID_UnitID_Offset = NativeReflectionCached.GetPropertyOffset(UMGTemplate_GetLearnID_FunctionAddress, "UnitID");
		UMGTemplate_GetLearnID_UnitID_IsValid = NativeReflectionCached.ValidatePropertyClass(UMGTemplate_GetLearnID_FunctionAddress, "UnitID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UMGTemplate_GetLearnID_LearnID_PropertyAddress, UMGTemplate_GetLearnID_FunctionAddress, "LearnID");
		UMGTemplate_GetLearnID_LearnID_Offset = NativeReflectionCached.GetPropertyOffset(UMGTemplate_GetLearnID_FunctionAddress, "LearnID");
		UMGTemplate_GetLearnID_LearnID_IsValid = NativeReflectionCached.ValidatePropertyClass(UMGTemplate_GetLearnID_FunctionAddress, "LearnID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UMGTemplate_GetLearnID_ReturnValue_PropertyAddress, UMGTemplate_GetLearnID_FunctionAddress, "ReturnValue");
		UMGTemplate_GetLearnID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UMGTemplate_GetLearnID_FunctionAddress, "ReturnValue");
		UMGTemplate_GetLearnID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UMGTemplate_GetLearnID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		UMGTemplate_GetLearnID_IsValid = UMGTemplate_GetLearnID_FunctionAddress != IntPtr.Zero && UMGTemplate_GetLearnID_UnitID_IsValid && UMGTemplate_GetLearnID_LearnID_IsValid && UMGTemplate_GetLearnID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.EditorFuncLibCommon:UMGTemplate_GetLearnID", UMGTemplate_GetLearnID_IsValid);
	}
}
