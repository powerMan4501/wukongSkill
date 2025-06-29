using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.InterpToMovementComponent", "Engine", UnrealModuleType.Engine)]
public class UInterpToMovementComponent : UMovementComponent
{
	[UDelegate]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature")]
	public class FOnInterpToWaitEndDelegate : FMulticastDelegate<FOnInterpToWaitEndDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, float Time);

		private static bool OnInterpToWaitEndDelegate__DelegateSignature_IsValid;

		private static IntPtr OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress;

		private static int OnInterpToWaitEndDelegate__DelegateSignature_ParamsSize;

		private static bool OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnInterpToWaitEndDelegate__DelegateSignature_Time_IsValid;

		private static FFieldAddress OnInterpToWaitEndDelegate__DelegateSignature_Time_PropertyAddress;

		private static int OnInterpToWaitEndDelegate__DelegateSignature_Time_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInterpToWaitEndDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature");
			OnInterpToWaitEndDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToWaitEndDelegate__DelegateSignature_Time_PropertyAddress, OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToWaitEndDelegate__DelegateSignature_Time_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToWaitEndDelegate__DelegateSignature_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress, "Time", Classes.FFloatProperty);
			OnInterpToWaitEndDelegate__DelegateSignature_IsValid = OnInterpToWaitEndDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_IsValid && OnInterpToWaitEndDelegate__DelegateSignature_Time_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature", OnInterpToWaitEndDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, float Time)
		{
			if (!OnInterpToWaitEndDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInterpToWaitEndDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToWaitEndDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_Offset), 0, OnInterpToWaitEndDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInterpToWaitEndDelegate__DelegateSignature_Time_Offset), 0, OnInterpToWaitEndDelegate__DelegateSignature_Time_PropertyAddress.Address, Time);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature")]
	public class FOnInterpToWaitBeginDelegate : FMulticastDelegate<FOnInterpToWaitBeginDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, float Time);

		private static bool OnInterpToWaitBeginDelegate__DelegateSignature_IsValid;

		private static IntPtr OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress;

		private static int OnInterpToWaitBeginDelegate__DelegateSignature_ParamsSize;

		private static bool OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnInterpToWaitBeginDelegate__DelegateSignature_Time_IsValid;

		private static FFieldAddress OnInterpToWaitBeginDelegate__DelegateSignature_Time_PropertyAddress;

		private static int OnInterpToWaitBeginDelegate__DelegateSignature_Time_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInterpToWaitBeginDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature");
			OnInterpToWaitBeginDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToWaitBeginDelegate__DelegateSignature_Time_PropertyAddress, OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToWaitBeginDelegate__DelegateSignature_Time_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToWaitBeginDelegate__DelegateSignature_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress, "Time", Classes.FFloatProperty);
			OnInterpToWaitBeginDelegate__DelegateSignature_IsValid = OnInterpToWaitBeginDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_IsValid && OnInterpToWaitBeginDelegate__DelegateSignature_Time_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature", OnInterpToWaitBeginDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, float Time)
		{
			if (!OnInterpToWaitBeginDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInterpToWaitBeginDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToWaitBeginDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_Offset), 0, OnInterpToWaitBeginDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInterpToWaitBeginDelegate__DelegateSignature_Time_Offset), 0, OnInterpToWaitBeginDelegate__DelegateSignature_Time_PropertyAddress.Address, Time);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature")]
	public class FOnInterpToStopDelegate : FMulticastDelegate<FOnInterpToStopDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, float Time);

		private static bool OnInterpToStopDelegate__DelegateSignature_IsValid;

		private static IntPtr OnInterpToStopDelegate__DelegateSignature_FunctionAddress;

		private static int OnInterpToStopDelegate__DelegateSignature_ParamsSize;

		private static bool OnInterpToStopDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnInterpToStopDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnInterpToStopDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnInterpToStopDelegate__DelegateSignature_Time_IsValid;

		private static FFieldAddress OnInterpToStopDelegate__DelegateSignature_Time_PropertyAddress;

		private static int OnInterpToStopDelegate__DelegateSignature_Time_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInterpToStopDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInterpToStopDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature");
			OnInterpToStopDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToStopDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToStopDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToStopDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToStopDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToStopDelegate__DelegateSignature_Time_PropertyAddress, OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToStopDelegate__DelegateSignature_Time_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToStopDelegate__DelegateSignature_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToStopDelegate__DelegateSignature_FunctionAddress, "Time", Classes.FFloatProperty);
			OnInterpToStopDelegate__DelegateSignature_IsValid = OnInterpToStopDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInterpToStopDelegate__DelegateSignature_ImpactResult_IsValid && OnInterpToStopDelegate__DelegateSignature_Time_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature", OnInterpToStopDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, float Time)
		{
			if (!OnInterpToStopDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInterpToStopDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToStopDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnInterpToStopDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnInterpToStopDelegate__DelegateSignature_ImpactResult_Offset), 0, OnInterpToStopDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInterpToStopDelegate__DelegateSignature_Time_Offset), 0, OnInterpToStopDelegate__DelegateSignature_Time_PropertyAddress.Address, Time);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature")]
	public class FOnInterpToReverseDelegate : FMulticastDelegate<FOnInterpToReverseDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, float Time);

		private static bool OnInterpToReverseDelegate__DelegateSignature_IsValid;

		private static IntPtr OnInterpToReverseDelegate__DelegateSignature_FunctionAddress;

		private static int OnInterpToReverseDelegate__DelegateSignature_ParamsSize;

		private static bool OnInterpToReverseDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnInterpToReverseDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnInterpToReverseDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnInterpToReverseDelegate__DelegateSignature_Time_IsValid;

		private static FFieldAddress OnInterpToReverseDelegate__DelegateSignature_Time_PropertyAddress;

		private static int OnInterpToReverseDelegate__DelegateSignature_Time_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInterpToReverseDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInterpToReverseDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature");
			OnInterpToReverseDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToReverseDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToReverseDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToReverseDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToReverseDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToReverseDelegate__DelegateSignature_Time_PropertyAddress, OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToReverseDelegate__DelegateSignature_Time_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToReverseDelegate__DelegateSignature_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToReverseDelegate__DelegateSignature_FunctionAddress, "Time", Classes.FFloatProperty);
			OnInterpToReverseDelegate__DelegateSignature_IsValid = OnInterpToReverseDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInterpToReverseDelegate__DelegateSignature_ImpactResult_IsValid && OnInterpToReverseDelegate__DelegateSignature_Time_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature", OnInterpToReverseDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, float Time)
		{
			if (!OnInterpToReverseDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInterpToReverseDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToReverseDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnInterpToReverseDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnInterpToReverseDelegate__DelegateSignature_ImpactResult_Offset), 0, OnInterpToReverseDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInterpToReverseDelegate__DelegateSignature_Time_Offset), 0, OnInterpToReverseDelegate__DelegateSignature_Time_PropertyAddress.Address, Time);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature")]
	public class FOnInterpToResetDelegate : FMulticastDelegate<FOnInterpToResetDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, float Time);

		private static bool OnInterpToResetDelegate__DelegateSignature_IsValid;

		private static IntPtr OnInterpToResetDelegate__DelegateSignature_FunctionAddress;

		private static int OnInterpToResetDelegate__DelegateSignature_ParamsSize;

		private static bool OnInterpToResetDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnInterpToResetDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnInterpToResetDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnInterpToResetDelegate__DelegateSignature_Time_IsValid;

		private static FFieldAddress OnInterpToResetDelegate__DelegateSignature_Time_PropertyAddress;

		private static int OnInterpToResetDelegate__DelegateSignature_Time_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInterpToResetDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInterpToResetDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature");
			OnInterpToResetDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToResetDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToResetDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToResetDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnInterpToResetDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInterpToResetDelegate__DelegateSignature_Time_PropertyAddress, OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToResetDelegate__DelegateSignature_Time_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "Time");
			OnInterpToResetDelegate__DelegateSignature_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToResetDelegate__DelegateSignature_FunctionAddress, "Time", Classes.FFloatProperty);
			OnInterpToResetDelegate__DelegateSignature_IsValid = OnInterpToResetDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInterpToResetDelegate__DelegateSignature_ImpactResult_IsValid && OnInterpToResetDelegate__DelegateSignature_Time_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature", OnInterpToResetDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, float Time)
		{
			if (!OnInterpToResetDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInterpToResetDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToResetDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnInterpToResetDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnInterpToResetDelegate__DelegateSignature_ImpactResult_Offset), 0, OnInterpToResetDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInterpToResetDelegate__DelegateSignature_Time_Offset), 0, OnInterpToResetDelegate__DelegateSignature_Time_PropertyAddress.Address, Time);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool PauseOnImpact_IsValid;

	private static FFieldAddress PauseOnImpact_PropertyAddress;

	private static int PauseOnImpact_Offset;

	private static bool Sweep_IsValid;

	private static FFieldAddress Sweep_PropertyAddress;

	private static int Sweep_Offset;

	private static bool TeleportType_IsValid;

	private static FFieldAddress TeleportType_PropertyAddress;

	private static int TeleportType_Offset;

	private static bool BehaviourType_IsValid;

	private static FFieldAddress BehaviourType_PropertyAddress;

	private static int BehaviourType_Offset;

	private static bool CheckIfStillInWorld_IsValid;

	private static FFieldAddress CheckIfStillInWorld_PropertyAddress;

	private static int CheckIfStillInWorld_Offset;

	private static bool ForceSubStepping_IsValid;

	private static FFieldAddress ForceSubStepping_PropertyAddress;

	private static int ForceSubStepping_Offset;

	private static bool OnInterpToReverse_IsValid;

	private static int OnInterpToReverse_Offset;

	private FOnInterpToReverseDelegate OnInterpToReverse_DelegateCached;

	private static bool OnInterpToStop_IsValid;

	private static int OnInterpToStop_Offset;

	private FOnInterpToStopDelegate OnInterpToStop_DelegateCached;

	private static bool OnWaitBeginDelegate_IsValid;

	private static int OnWaitBeginDelegate_Offset;

	private FOnInterpToWaitBeginDelegate OnWaitBeginDelegate_DelegateCached;

	private static bool OnWaitEndDelegate_IsValid;

	private static int OnWaitEndDelegate_Offset;

	private FOnInterpToWaitEndDelegate OnWaitEndDelegate_DelegateCached;

	private static bool OnResetDelegate_IsValid;

	private static int OnResetDelegate_Offset;

	private FOnInterpToResetDelegate OnResetDelegate_DelegateCached;

	private static bool MaxSimulationTimeStep_IsValid;

	private static int MaxSimulationTimeStep_Offset;

	private static bool MaxSimulationIterations_IsValid;

	private static int MaxSimulationIterations_Offset;

	private static bool ControlPoints_IsValid;

	private static FFieldAddress ControlPoints_PropertyAddress;

	private static int ControlPoints_Offset;

	private TArrayReadWriteMarshaler<FInterpControlPoint> ControlPoints_MarshalerCached;

	private static bool StopSimulating_IsValid;

	private static IntPtr StopSimulating_FunctionAddress;

	private static int StopSimulating_ParamsSize;

	private static bool StopSimulating_HitResult_IsValid;

	private static FFieldAddress StopSimulating_HitResult_PropertyAddress;

	private static int StopSimulating_HitResult_Offset;

	private static bool RestartMovement_IsValid;

	private static IntPtr RestartMovement_FunctionAddress;

	private static int RestartMovement_ParamsSize;

	private static bool RestartMovement_InitialDirection_IsValid;

	private static FFieldAddress RestartMovement_InitialDirection_PropertyAddress;

	private static int RestartMovement_InitialDirection_Offset;

	private static bool ResetControlPoints_IsValid;

	private static IntPtr ResetControlPoints_FunctionAddress;

	private static int ResetControlPoints_ParamsSize;

	private static bool FinaliseControlPoints_IsValid;

	private static IntPtr FinaliseControlPoints_FunctionAddress;

	private static int FinaliseControlPoints_ParamsSize;

	private static bool AddControlPointPosition_IsValid;

	private static IntPtr AddControlPointPosition_FunctionAddress;

	private static int AddControlPointPosition_ParamsSize;

	private static bool AddControlPointPosition_Pos_IsValid;

	private static FFieldAddress AddControlPointPosition_Pos_PropertyAddress;

	private static int AddControlPointPosition_Pos_Offset;

	private static bool AddControlPointPosition_bPositionIsRelative_IsValid;

	private static FFieldAddress AddControlPointPosition_bPositionIsRelative_PropertyAddress;

	private static int AddControlPointPosition_bPositionIsRelative_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:bPauseOnImpact")]
	public bool PauseOnImpact
	{
		get
		{
			CheckDestroyed();
			if (!PauseOnImpact_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bPauseOnImpact");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PauseOnImpact_Offset), 0, PauseOnImpact_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PauseOnImpact_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bPauseOnImpact");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PauseOnImpact_Offset), 0, PauseOnImpact_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:bSweep")]
	public bool Sweep
	{
		get
		{
			CheckDestroyed();
			if (!Sweep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bSweep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Sweep_Offset), 0, Sweep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Sweep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bSweep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Sweep_Offset), 0, Sweep_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:TeleportType")]
	public ETeleportType TeleportType
	{
		get
		{
			CheckDestroyed();
			if (!TeleportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:TeleportType");
				return ETeleportType.None;
			}
			return EnumMarshaler<ETeleportType>.FromNative(IntPtr.Add(base.Address, TeleportType_Offset), 0, TeleportType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TeleportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:TeleportType");
			}
			else
			{
				EnumMarshaler<ETeleportType>.ToNative(IntPtr.Add(base.Address, TeleportType_Offset), 0, TeleportType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:BehaviourType")]
	public EInterpToBehaviourType BehaviourType
	{
		get
		{
			CheckDestroyed();
			if (!BehaviourType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:BehaviourType");
				return EInterpToBehaviourType.OneShot;
			}
			return EnumMarshaler<EInterpToBehaviourType>.FromNative(IntPtr.Add(base.Address, BehaviourType_Offset), 0, BehaviourType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BehaviourType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:BehaviourType");
			}
			else
			{
				EnumMarshaler<EInterpToBehaviourType>.ToNative(IntPtr.Add(base.Address, BehaviourType_Offset), 0, BehaviourType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:bCheckIfStillInWorld")]
	public bool CheckIfStillInWorld
	{
		get
		{
			CheckDestroyed();
			if (!CheckIfStillInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bCheckIfStillInWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CheckIfStillInWorld_Offset), 0, CheckIfStillInWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckIfStillInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bCheckIfStillInWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CheckIfStillInWorld_Offset), 0, CheckIfStillInWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:bForceSubStepping")]
	public bool ForceSubStepping
	{
		get
		{
			CheckDestroyed();
			if (!ForceSubStepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bForceSubStepping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceSubStepping_Offset), 0, ForceSubStepping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceSubStepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:bForceSubStepping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceSubStepping_Offset), 0, ForceSubStepping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToReverse")]
	public FOnInterpToReverseDelegate OnInterpToReverse
	{
		get
		{
			CheckDestroyed();
			if (!OnInterpToReverse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToReverse");
				return new FOnInterpToReverseDelegate();
			}
			if (OnInterpToReverse_DelegateCached == null)
			{
				OnInterpToReverse_DelegateCached = new FOnInterpToReverseDelegate();
				OnInterpToReverse_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInterpToReverse_Offset));
			}
			return OnInterpToReverse_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnInterpToStop")]
	public FOnInterpToStopDelegate OnInterpToStop
	{
		get
		{
			CheckDestroyed();
			if (!OnInterpToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:OnInterpToStop");
				return new FOnInterpToStopDelegate();
			}
			if (OnInterpToStop_DelegateCached == null)
			{
				OnInterpToStop_DelegateCached = new FOnInterpToStopDelegate();
				OnInterpToStop_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInterpToStop_Offset));
			}
			return OnInterpToStop_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnWaitBeginDelegate")]
	public FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnWaitBeginDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:OnWaitBeginDelegate");
				return new FOnInterpToWaitBeginDelegate();
			}
			if (OnWaitBeginDelegate_DelegateCached == null)
			{
				OnWaitBeginDelegate_DelegateCached = new FOnInterpToWaitBeginDelegate();
				OnWaitBeginDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnWaitBeginDelegate_Offset));
			}
			return OnWaitBeginDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnWaitEndDelegate")]
	public FOnInterpToWaitEndDelegate OnWaitEndDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnWaitEndDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:OnWaitEndDelegate");
				return new FOnInterpToWaitEndDelegate();
			}
			if (OnWaitEndDelegate_DelegateCached == null)
			{
				OnWaitEndDelegate_DelegateCached = new FOnInterpToWaitEndDelegate();
				OnWaitEndDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnWaitEndDelegate_Offset));
			}
			return OnWaitEndDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:OnResetDelegate")]
	public FOnInterpToResetDelegate OnResetDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnResetDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:OnResetDelegate");
				return new FOnInterpToResetDelegate();
			}
			if (OnResetDelegate_DelegateCached == null)
			{
				OnResetDelegate_DelegateCached = new FOnInterpToResetDelegate();
				OnResetDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnResetDelegate_Offset));
			}
			return OnResetDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:MaxSimulationTimeStep")]
	public float MaxSimulationTimeStep
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:MaxSimulationTimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:MaxSimulationTimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:MaxSimulationIterations")]
	public int MaxSimulationIterations
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:MaxSimulationIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:MaxSimulationIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:ControlPoints")]
	public TArrayReadWrite<FInterpControlPoint> ControlPoints
	{
		get
		{
			CheckDestroyed();
			if (!ControlPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpToMovementComponent:ControlPoints");
				return null;
			}
			if (ControlPoints_MarshalerCached == null)
			{
				ControlPoints_MarshalerCached = new TArrayReadWriteMarshaler<FInterpControlPoint>(1, ControlPoints_PropertyAddress, CachedMarshalingDelegates<FInterpControlPoint, FInterpControlPoint>.FromNative, CachedMarshalingDelegates<FInterpControlPoint, FInterpControlPoint>.ToNative);
			}
			return ControlPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, ControlPoints_Offset));
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:StopSimulating")]
	public unsafe void StopSimulating(FHitResult HitResult)
	{
		CheckDestroyed();
		if (!StopSimulating_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:StopSimulating");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopSimulating_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopSimulating_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StopSimulating_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, StopSimulating_HitResult_Offset), 0, StopSimulating_HitResult_PropertyAddress.Address, HitResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopSimulating_FunctionAddress, intPtr, StopSimulating_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:RestartMovement")]
	public unsafe void RestartMovement(float InitialDirection = 1f)
	{
		CheckDestroyed();
		if (!RestartMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:RestartMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RestartMovement_InitialDirection_Offset), 0, RestartMovement_InitialDirection_PropertyAddress.Address, InitialDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartMovement_FunctionAddress, intPtr, RestartMovement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:ResetControlPoints")]
	public unsafe void ResetControlPoints()
	{
		CheckDestroyed();
		if (!ResetControlPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:ResetControlPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetControlPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetControlPoints_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetControlPoints_FunctionAddress, argsSize: ResetControlPoints_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:FinaliseControlPoints")]
	public unsafe void FinaliseControlPoints()
	{
		CheckDestroyed();
		if (!FinaliseControlPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:FinaliseControlPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinaliseControlPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinaliseControlPoints_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FinaliseControlPoints_FunctionAddress, argsSize: FinaliseControlPoints_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.InterpToMovementComponent:AddControlPointPosition")]
	public unsafe void AddControlPointPosition(FVector Pos, bool bPositionIsRelative = true)
	{
		CheckDestroyed();
		if (!AddControlPointPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InterpToMovementComponent:AddControlPointPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddControlPointPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddControlPointPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddControlPointPosition_Pos_Offset), 0, AddControlPointPosition_Pos_PropertyAddress.Address, Pos);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddControlPointPosition_bPositionIsRelative_Offset), 0, AddControlPointPosition_bPositionIsRelative_PropertyAddress.Address, bPositionIsRelative);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddControlPointPosition_FunctionAddress, intPtr, AddControlPointPosition_ParamsSize);
	}

	static UInterpToMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterpToMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterpToMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.InterpToMovementComponent");
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseOnImpact_PropertyAddress, intPtr, "bPauseOnImpact");
		PauseOnImpact_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPauseOnImpact");
		PauseOnImpact_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPauseOnImpact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Sweep_PropertyAddress, intPtr, "bSweep");
		Sweep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSweep");
		Sweep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TeleportType_PropertyAddress, intPtr, "TeleportType");
		TeleportType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeleportType");
		TeleportType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeleportType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BehaviourType_PropertyAddress, intPtr, "BehaviourType");
		BehaviourType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BehaviourType");
		BehaviourType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BehaviourType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIfStillInWorld_PropertyAddress, intPtr, "bCheckIfStillInWorld");
		CheckIfStillInWorld_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckIfStillInWorld");
		CheckIfStillInWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckIfStillInWorld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceSubStepping_PropertyAddress, intPtr, "bForceSubStepping");
		ForceSubStepping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceSubStepping");
		ForceSubStepping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceSubStepping", Classes.FBoolProperty);
		OnInterpToReverse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInterpToReverse");
		OnInterpToReverse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInterpToReverse", Classes.FMulticastDelegateProperty);
		OnInterpToStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInterpToStop");
		OnInterpToStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInterpToStop", Classes.FMulticastDelegateProperty);
		OnWaitBeginDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnWaitBeginDelegate");
		OnWaitBeginDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnWaitBeginDelegate", Classes.FMulticastDelegateProperty);
		OnWaitEndDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnWaitEndDelegate");
		OnWaitEndDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnWaitEndDelegate", Classes.FMulticastDelegateProperty);
		OnResetDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnResetDelegate");
		OnResetDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnResetDelegate", Classes.FMulticastDelegateProperty);
		MaxSimulationTimeStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationTimeStep");
		MaxSimulationTimeStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationTimeStep", Classes.FFloatProperty);
		MaxSimulationIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationIterations");
		MaxSimulationIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationIterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ControlPoints_PropertyAddress, intPtr, "ControlPoints");
		ControlPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlPoints");
		ControlPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlPoints", Classes.FArrayProperty);
		StopSimulating_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopSimulating");
		StopSimulating_ParamsSize = NativeReflection.GetFunctionParamsSize(StopSimulating_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopSimulating_HitResult_PropertyAddress, StopSimulating_FunctionAddress, "HitResult");
		StopSimulating_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(StopSimulating_FunctionAddress, "HitResult");
		StopSimulating_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(StopSimulating_FunctionAddress, "HitResult", Classes.FStructProperty);
		StopSimulating_IsValid = StopSimulating_FunctionAddress != IntPtr.Zero && StopSimulating_HitResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:StopSimulating", StopSimulating_IsValid);
		RestartMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestartMovement");
		RestartMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartMovement_InitialDirection_PropertyAddress, RestartMovement_FunctionAddress, "InitialDirection");
		RestartMovement_InitialDirection_Offset = NativeReflectionCached.GetPropertyOffset(RestartMovement_FunctionAddress, "InitialDirection");
		RestartMovement_InitialDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartMovement_FunctionAddress, "InitialDirection", Classes.FFloatProperty);
		RestartMovement_IsValid = RestartMovement_FunctionAddress != IntPtr.Zero && RestartMovement_InitialDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:RestartMovement", RestartMovement_IsValid);
		ResetControlPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetControlPoints");
		ResetControlPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetControlPoints_FunctionAddress);
		ResetControlPoints_IsValid = ResetControlPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:ResetControlPoints", ResetControlPoints_IsValid);
		FinaliseControlPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinaliseControlPoints");
		FinaliseControlPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(FinaliseControlPoints_FunctionAddress);
		FinaliseControlPoints_IsValid = FinaliseControlPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:FinaliseControlPoints", FinaliseControlPoints_IsValid);
		AddControlPointPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddControlPointPosition");
		AddControlPointPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(AddControlPointPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddControlPointPosition_Pos_PropertyAddress, AddControlPointPosition_FunctionAddress, "Pos");
		AddControlPointPosition_Pos_Offset = NativeReflectionCached.GetPropertyOffset(AddControlPointPosition_FunctionAddress, "Pos");
		AddControlPointPosition_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControlPointPosition_FunctionAddress, "Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControlPointPosition_bPositionIsRelative_PropertyAddress, AddControlPointPosition_FunctionAddress, "bPositionIsRelative");
		AddControlPointPosition_bPositionIsRelative_Offset = NativeReflectionCached.GetPropertyOffset(AddControlPointPosition_FunctionAddress, "bPositionIsRelative");
		AddControlPointPosition_bPositionIsRelative_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControlPointPosition_FunctionAddress, "bPositionIsRelative", Classes.FBoolProperty);
		AddControlPointPosition_IsValid = AddControlPointPosition_FunctionAddress != IntPtr.Zero && AddControlPointPosition_Pos_IsValid && AddControlPointPosition_bPositionIsRelative_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InterpToMovementComponent:AddControlPointPosition", AddControlPointPosition_IsValid);
	}
}
