using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibMove", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibMove : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BGUMovementForceSaveBaseLocation_IsValid;

	private static IntPtr BGUMovementForceSaveBaseLocation_FunctionAddress;

	private static int BGUMovementForceSaveBaseLocation_ParamsSize;

	private static bool BGUMovementForceSaveBaseLocation_MoveComp_IsValid;

	private static FFieldAddress BGUMovementForceSaveBaseLocation_MoveComp_PropertyAddress;

	private static int BGUMovementForceSaveBaseLocation_MoveComp_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibMove:BGUMovementForceSaveBaseLocation")]
	public unsafe static void BGUMovementForceSaveBaseLocation(UCharacterMovementComponent MoveComp)
	{
		if (!BGUMovementForceSaveBaseLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibMove:BGUMovementForceSaveBaseLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUMovementForceSaveBaseLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUMovementForceSaveBaseLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCharacterMovementComponent>.ToNative(IntPtr.Add(intPtr, BGUMovementForceSaveBaseLocation_MoveComp_Offset), 0, BGUMovementForceSaveBaseLocation_MoveComp_PropertyAddress.Address, MoveComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUMovementForceSaveBaseLocation_FunctionAddress, intPtr, BGUMovementForceSaveBaseLocation_ParamsSize);
	}

	static UBGUFuncLibMove()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibMove));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibMove");
		BGUMovementForceSaveBaseLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUMovementForceSaveBaseLocation");
		BGUMovementForceSaveBaseLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMovementForceSaveBaseLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUMovementForceSaveBaseLocation_MoveComp_PropertyAddress, BGUMovementForceSaveBaseLocation_FunctionAddress, "MoveComp");
		BGUMovementForceSaveBaseLocation_MoveComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUMovementForceSaveBaseLocation_FunctionAddress, "MoveComp");
		BGUMovementForceSaveBaseLocation_MoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMovementForceSaveBaseLocation_FunctionAddress, "MoveComp", Classes.FObjectProperty);
		BGUMovementForceSaveBaseLocation_IsValid = BGUMovementForceSaveBaseLocation_FunctionAddress != IntPtr.Zero && BGUMovementForceSaveBaseLocation_MoveComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibMove:BGUMovementForceSaveBaseLocation", BGUMovementForceSaveBaseLocation_IsValid);
	}
}
