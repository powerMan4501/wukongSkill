using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.CommandletCSharpProcessor", "FuncLibEditor", UnrealModuleType.Game)]
public class UCommandletCSharpProcessor : UObject
{
	private static bool DoProcess_IsValid;

	private IntPtr DoProcess_InstanceFunctionAddress;

	private static IntPtr DoProcess_FunctionAddress;

	private static int DoProcess_ParamsSize;

	private static bool DoProcess_args_IsValid;

	private static FFieldAddress DoProcess_args_PropertyAddress;

	private static int DoProcess_args_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/FuncLibEditor.CommandletCSharpProcessor:DoProcess")]
	public unsafe void DoProcess(string args)
	{
		CheckDestroyed();
		if (!DoProcess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.CommandletCSharpProcessor:DoProcess");
			return;
		}
		if (DoProcess_InstanceFunctionAddress == IntPtr.Zero)
		{
			DoProcess_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DoProcess");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoProcess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoProcess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DoProcess_args_Offset), 0, DoProcess_args_PropertyAddress.Address, args);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoProcess_InstanceFunctionAddress, intPtr, DoProcess_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoProcess_args_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void DoProcess_Implementation(string args)
	{
		CheckDestroyed();
		if (!DoProcess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.CommandletCSharpProcessor:DoProcess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoProcess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoProcess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DoProcess_args_Offset), 0, DoProcess_args_PropertyAddress.Address, args);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoProcess_FunctionAddress, intPtr, DoProcess_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoProcess_args_PropertyAddress.Address, intPtr);
	}

	static UCommandletCSharpProcessor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCommandletCSharpProcessor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCommandletCSharpProcessor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.CommandletCSharpProcessor");
		DoProcess_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoProcess");
		DoProcess_ParamsSize = NativeReflection.GetFunctionParamsSize(DoProcess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoProcess_args_PropertyAddress, DoProcess_FunctionAddress, "args");
		DoProcess_args_Offset = NativeReflectionCached.GetPropertyOffset(DoProcess_FunctionAddress, "args");
		DoProcess_args_IsValid = NativeReflectionCached.ValidatePropertyClass(DoProcess_FunctionAddress, "args", Classes.FStrProperty);
		DoProcess_IsValid = DoProcess_FunctionAddress != IntPtr.Zero && DoProcess_args_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.CommandletCSharpProcessor:DoProcess", DoProcess_IsValid);
	}
}
