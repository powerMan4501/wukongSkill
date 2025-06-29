using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[Abstract]
[UClass(Flags = (ClassFlags)810549413uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTask", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTask : UObject, IGameplayTaskOwnerInterface, IInterface
{
	[UDelegate]
	[UMetaPath("/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature")]
	public class FGenericGameplayTaskDelegate : FMulticastDelegate<FGenericGameplayTaskDelegate.Signature>
	{
		public delegate void Signature();

		private static bool GenericGameplayTaskDelegate__DelegateSignature_IsValid;

		private static IntPtr GenericGameplayTaskDelegate__DelegateSignature_FunctionAddress;

		private static int GenericGameplayTaskDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGenericGameplayTaskDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GenericGameplayTaskDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature");
			GenericGameplayTaskDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GenericGameplayTaskDelegate__DelegateSignature_FunctionAddress);
			GenericGameplayTaskDelegate__DelegateSignature_IsValid = GenericGameplayTaskDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature", GenericGameplayTaskDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!GenericGameplayTaskDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GenericGameplayTaskDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenericGameplayTaskDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool EndTask_IsValid;

	private static IntPtr EndTask_FunctionAddress;

	private static int EndTask_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask:EndTask")]
	public unsafe void EndTask()
	{
		CheckDestroyed();
		if (!EndTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask:EndTask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndTask_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndTask_FunctionAddress, argsSize: EndTask_ParamsSize);
	}

	static UGameplayTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTask");
		EndTask_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndTask");
		EndTask_ParamsSize = NativeReflection.GetFunctionParamsSize(EndTask_FunctionAddress);
		EndTask_IsValid = EndTask_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask:EndTask", EndTask_IsValid);
	}
}
