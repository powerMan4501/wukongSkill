using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CancellableAsyncAction", "Engine", UnrealModuleType.Engine)]
public class UCancellableAsyncAction : UBlueprintAsyncActionBase
{
	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool Cancel_IsValid;

	private static IntPtr Cancel_FunctionAddress;

	private static int Cancel_ParamsSize;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CancellableAsyncAction:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CancellableAsyncAction:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CancellableAsyncAction:Cancel")]
	public unsafe void Cancel()
	{
		CheckDestroyed();
		if (!Cancel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CancellableAsyncAction:Cancel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cancel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cancel_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Cancel_FunctionAddress, argsSize: Cancel_ParamsSize);
	}

	static UCancellableAsyncAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCancellableAsyncAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCancellableAsyncAction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CancellableAsyncAction");
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CancellableAsyncAction:IsActive", IsActive_IsValid);
		Cancel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Cancel");
		Cancel_ParamsSize = NativeReflection.GetFunctionParamsSize(Cancel_FunctionAddress);
		Cancel_IsValid = Cancel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CancellableAsyncAction:Cancel", Cancel_IsValid);
	}
}
