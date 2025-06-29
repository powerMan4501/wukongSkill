using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTask_WaitDelay", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTask_WaitDelay : UGameplayTask
{
	[UDelegate]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature")]
	public class FTaskDelayDelegate : FMulticastDelegate<FTaskDelayDelegate.Signature>
	{
		public delegate void Signature();

		private static bool TaskDelayDelegate__DelegateSignature_IsValid;

		private static IntPtr TaskDelayDelegate__DelegateSignature_FunctionAddress;

		private static int TaskDelayDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FTaskDelayDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			TaskDelayDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature");
			TaskDelayDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TaskDelayDelegate__DelegateSignature_FunctionAddress);
			TaskDelayDelegate__DelegateSignature_IsValid = TaskDelayDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature", TaskDelayDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!TaskDelayDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(TaskDelayDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TaskDelayDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool OnFinish_IsValid;

	private static int OnFinish_Offset;

	private FTaskDelayDelegate OnFinish_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_WaitDelay:OnFinish")]
	public FTaskDelayDelegate OnFinish
	{
		get
		{
			CheckDestroyed();
			if (!OnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTask_WaitDelay:OnFinish");
				return new FTaskDelayDelegate();
			}
			if (OnFinish_DelegateCached == null)
			{
				OnFinish_DelegateCached = new FTaskDelayDelegate();
				OnFinish_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnFinish_Offset));
			}
			return OnFinish_DelegateCached;
		}
	}

	static UGameplayTask_WaitDelay()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTask_WaitDelay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTask_WaitDelay));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTask_WaitDelay");
		OnFinish_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnFinish");
		OnFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnFinish", Classes.FMulticastDelegateProperty);
	}
}
