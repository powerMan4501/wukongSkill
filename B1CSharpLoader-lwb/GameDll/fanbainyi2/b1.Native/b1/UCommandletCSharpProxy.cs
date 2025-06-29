using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.CommandletCSharpProxy", "FuncLibEditor", UnrealModuleType.Game)]
public class UCommandletCSharpProxy : UObject
{
	private static bool ExecuteEvent_IsValid;

	private static IntPtr ExecuteEvent_FunctionAddress;

	private static int ExecuteEvent_ParamsSize;

	private static bool ExecuteEvent_args_IsValid;

	private static FFieldAddress ExecuteEvent_args_PropertyAddress;

	private static int ExecuteEvent_args_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.CommandletCSharpProxy:ExecuteEvent")]
	public unsafe void ExecuteEvent(string args)
	{
		CheckDestroyed();
		if (!ExecuteEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.CommandletCSharpProxy:ExecuteEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExecuteEvent_args_Offset), 0, ExecuteEvent_args_PropertyAddress.Address, args);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteEvent_FunctionAddress, intPtr, ExecuteEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExecuteEvent_args_PropertyAddress.Address, intPtr);
	}

	static UCommandletCSharpProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCommandletCSharpProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCommandletCSharpProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.CommandletCSharpProxy");
		ExecuteEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExecuteEvent");
		ExecuteEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteEvent_args_PropertyAddress, ExecuteEvent_FunctionAddress, "args");
		ExecuteEvent_args_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteEvent_FunctionAddress, "args");
		ExecuteEvent_args_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteEvent_FunctionAddress, "args", Classes.FStrProperty);
		ExecuteEvent_IsValid = ExecuteEvent_FunctionAddress != IntPtr.Zero && ExecuteEvent_args_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.CommandletCSharpProxy:ExecuteEvent", ExecuteEvent_IsValid);
	}
}
