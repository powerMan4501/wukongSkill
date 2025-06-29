using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.EditorUtilityObject", "Blutility", UnrealModuleType.Engine)]
public class UEditorUtilityObject : UObject
{
	private static bool Run_IsValid;

	private IntPtr Run_InstanceFunctionAddress;

	private static IntPtr Run_FunctionAddress;

	private static int Run_ParamsSize;

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/Blutility.EditorUtilityObject:Run")]
	public unsafe void Run()
	{
		CheckDestroyed();
		if (!Run_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityObject:Run");
			return;
		}
		if (Run_InstanceFunctionAddress == IntPtr.Zero)
		{
			Run_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Run");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Run_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Run_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Run_InstanceFunctionAddress, argsSize: Run_ParamsSize);
	}

	protected unsafe virtual void Run_Implementation()
	{
		CheckDestroyed();
		if (!Run_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityObject:Run");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Run_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Run_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Run_FunctionAddress, argsSize: Run_ParamsSize);
	}

	static UEditorUtilityObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorUtilityObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorUtilityObject));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Blutility.EditorUtilityObject");
		Run_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Run");
		Run_ParamsSize = NativeReflection.GetFunctionParamsSize(Run_FunctionAddress);
		Run_IsValid = Run_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityObject:Run", Run_IsValid);
	}
}
