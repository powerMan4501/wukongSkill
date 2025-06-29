using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.CLRBindingTrigger", "UnrealExtent", UnrealModuleType.Game)]
public class ACLRBindingTrigger : AActor
{
	private static bool GenerateClrBindingCode_IsValid;

	private IntPtr GenerateClrBindingCode_InstanceFunctionAddress;

	private static IntPtr GenerateClrBindingCode_FunctionAddress;

	private static int GenerateClrBindingCode_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.CLRBindingTrigger:GenerateClrBindingCode")]
	public unsafe void GenerateClrBindingCode()
	{
		CheckDestroyed();
		if (!GenerateClrBindingCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.CLRBindingTrigger:GenerateClrBindingCode");
			return;
		}
		if (GenerateClrBindingCode_InstanceFunctionAddress == IntPtr.Zero)
		{
			GenerateClrBindingCode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GenerateClrBindingCode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateClrBindingCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateClrBindingCode_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GenerateClrBindingCode_InstanceFunctionAddress, argsSize: GenerateClrBindingCode_ParamsSize);
	}

	protected unsafe virtual void GenerateClrBindingCode_Implementation()
	{
		CheckDestroyed();
		if (!GenerateClrBindingCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.CLRBindingTrigger:GenerateClrBindingCode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateClrBindingCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateClrBindingCode_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GenerateClrBindingCode_FunctionAddress, argsSize: GenerateClrBindingCode_ParamsSize);
	}

	static ACLRBindingTrigger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLRBindingTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLRBindingTrigger));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.CLRBindingTrigger");
		GenerateClrBindingCode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateClrBindingCode");
		GenerateClrBindingCode_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateClrBindingCode_FunctionAddress);
		GenerateClrBindingCode_IsValid = GenerateClrBindingCode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.CLRBindingTrigger:GenerateClrBindingCode", GenerateClrBindingCode_IsValid);
	}
}
