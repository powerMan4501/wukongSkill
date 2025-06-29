using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTask_TimeLimitedExecution : UGameplayTask
{
	[UDelegate]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature")]
	public class FTaskFinishDelegate : FMulticastDelegate<FTaskFinishDelegate.Signature>
	{
		public delegate void Signature();

		private static bool TaskFinishDelegate__DelegateSignature_IsValid;

		private static IntPtr TaskFinishDelegate__DelegateSignature_FunctionAddress;

		private static int TaskFinishDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FTaskFinishDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			TaskFinishDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature");
			TaskFinishDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TaskFinishDelegate__DelegateSignature_FunctionAddress);
			TaskFinishDelegate__DelegateSignature_IsValid = TaskFinishDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature", TaskFinishDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!TaskFinishDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(TaskFinishDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TaskFinishDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool OnFinished_IsValid;

	private static int OnFinished_Offset;

	private FTaskFinishDelegate OnFinished_DelegateCached;

	private static bool OnTimeExpired_IsValid;

	private static int OnTimeExpired_Offset;

	private FTaskFinishDelegate OnTimeExpired_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:OnFinished")]
	public FTaskFinishDelegate OnFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:OnFinished");
				return new FTaskFinishDelegate();
			}
			if (OnFinished_DelegateCached == null)
			{
				OnFinished_DelegateCached = new FTaskFinishDelegate();
				OnFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnFinished_Offset));
			}
			return OnFinished_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:OnTimeExpired")]
	public FTaskFinishDelegate OnTimeExpired
	{
		get
		{
			CheckDestroyed();
			if (!OnTimeExpired_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:OnTimeExpired");
				return new FTaskFinishDelegate();
			}
			if (OnTimeExpired_DelegateCached == null)
			{
				OnTimeExpired_DelegateCached = new FTaskFinishDelegate();
				OnTimeExpired_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTimeExpired_Offset));
			}
			return OnTimeExpired_DelegateCached;
		}
	}

	static UGameplayTask_TimeLimitedExecution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTask_TimeLimitedExecution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTask_TimeLimitedExecution));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution");
		OnFinished_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnFinished");
		OnFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnFinished", Classes.FMulticastDelegateProperty);
		OnTimeExpired_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnTimeExpired");
		OnTimeExpired_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnTimeExpired", Classes.FMulticastDelegateProperty);
	}
}
