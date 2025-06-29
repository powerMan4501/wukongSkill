using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.ReturnResultsTerminal", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UReturnResultsTerminal : UFieldNodeBase
{
	private static bool SetReturnResultsTerminal_IsValid;

	private static IntPtr SetReturnResultsTerminal_FunctionAddress;

	private static int SetReturnResultsTerminal_ParamsSize;

	private static bool SetReturnResultsTerminal_ReturnValue_IsValid;

	private static FFieldAddress SetReturnResultsTerminal_ReturnValue_PropertyAddress;

	private static int SetReturnResultsTerminal_ReturnValue_Offset;

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.ReturnResultsTerminal:SetReturnResultsTerminal")]
	public unsafe UReturnResultsTerminal SetReturnResultsTerminal()
	{
		CheckDestroyed();
		if (!SetReturnResultsTerminal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.ReturnResultsTerminal:SetReturnResultsTerminal");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReturnResultsTerminal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReturnResultsTerminal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReturnResultsTerminal_FunctionAddress, intPtr, SetReturnResultsTerminal_ParamsSize);
		return UObjectMarshaler<UReturnResultsTerminal>.FromNative(IntPtr.Add(intPtr, SetReturnResultsTerminal_ReturnValue_Offset), 0, SetReturnResultsTerminal_ReturnValue_PropertyAddress.Address);
	}

	static UReturnResultsTerminal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UReturnResultsTerminal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UReturnResultsTerminal));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FieldSystemEngine.ReturnResultsTerminal");
		SetReturnResultsTerminal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReturnResultsTerminal");
		SetReturnResultsTerminal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReturnResultsTerminal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReturnResultsTerminal_ReturnValue_PropertyAddress, SetReturnResultsTerminal_FunctionAddress, "ReturnValue");
		SetReturnResultsTerminal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetReturnResultsTerminal_FunctionAddress, "ReturnValue");
		SetReturnResultsTerminal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReturnResultsTerminal_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetReturnResultsTerminal_IsValid = SetReturnResultsTerminal_FunctionAddress != IntPtr.Zero && SetReturnResultsTerminal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.ReturnResultsTerminal:SetReturnResultsTerminal", SetReturnResultsTerminal_IsValid);
	}
}
