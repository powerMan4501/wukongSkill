using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionMaterialFunctionCall", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionMaterialFunctionCall : UMaterialExpression
{
	private static bool SetMaterialFunction_IsValid;

	private static IntPtr SetMaterialFunction_FunctionAddress;

	private static int SetMaterialFunction_ParamsSize;

	private static bool SetMaterialFunction_NewMaterialFunction_IsValid;

	private static FFieldAddress SetMaterialFunction_NewMaterialFunction_PropertyAddress;

	private static int SetMaterialFunction_NewMaterialFunction_Offset;

	private static bool SetMaterialFunction_ReturnValue_IsValid;

	private static FFieldAddress SetMaterialFunction_ReturnValue_PropertyAddress;

	private static int SetMaterialFunction_ReturnValue_Offset;

	[UFunction(Flags = 604111875u)]
	[UMetaPath("/Script/Engine.MaterialExpressionMaterialFunctionCall:SetMaterialFunction")]
	public unsafe bool SetMaterialFunction(UMaterialFunctionInterface NewMaterialFunction)
	{
		CheckDestroyed();
		if (!SetMaterialFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialExpressionMaterialFunctionCall:SetMaterialFunction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(intPtr, SetMaterialFunction_NewMaterialFunction_Offset), 0, SetMaterialFunction_NewMaterialFunction_PropertyAddress.Address, NewMaterialFunction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterialFunction_FunctionAddress, intPtr, SetMaterialFunction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMaterialFunction_ReturnValue_Offset), 0, SetMaterialFunction_ReturnValue_PropertyAddress.Address);
	}

	static UMaterialExpressionMaterialFunctionCall()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionMaterialFunctionCall)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionMaterialFunctionCall));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.MaterialExpressionMaterialFunctionCall");
		SetMaterialFunction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaterialFunction");
		SetMaterialFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialFunction_NewMaterialFunction_PropertyAddress, SetMaterialFunction_FunctionAddress, "NewMaterialFunction");
		SetMaterialFunction_NewMaterialFunction_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialFunction_FunctionAddress, "NewMaterialFunction");
		SetMaterialFunction_NewMaterialFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialFunction_FunctionAddress, "NewMaterialFunction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialFunction_ReturnValue_PropertyAddress, SetMaterialFunction_FunctionAddress, "ReturnValue");
		SetMaterialFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialFunction_FunctionAddress, "ReturnValue");
		SetMaterialFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialFunction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMaterialFunction_IsValid = SetMaterialFunction_FunctionAddress != IntPtr.Zero && SetMaterialFunction_NewMaterialFunction_IsValid && SetMaterialFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialExpressionMaterialFunctionCall:SetMaterialFunction", SetMaterialFunction_IsValid);
	}
}
