using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

public sealed class INiagaraParticleCallbackHandlerImpl : IInterfaceImpl, INiagaraParticleCallbackHandler, IInterface
{
	private static bool ReceiveParticleData_IsValid;

	private IntPtr ReceiveParticleData_InstanceFunctionAddress;

	private static IntPtr ReceiveParticleData_FunctionAddress;

	private static int ReceiveParticleData_ParamsSize;

	private static bool ReceiveParticleData_Data_IsValid;

	private static FFieldAddress ReceiveParticleData_Data_PropertyAddress;

	private static int ReceiveParticleData_Data_Offset;

	private static bool ReceiveParticleData_NiagaraSystem_IsValid;

	private static FFieldAddress ReceiveParticleData_NiagaraSystem_PropertyAddress;

	private static int ReceiveParticleData_NiagaraSystem_Offset;

	private static bool ReceiveParticleData_SimulationPositionOffset_IsValid;

	private static FFieldAddress ReceiveParticleData_SimulationPositionOffset_PropertyAddress;

	private static int ReceiveParticleData_SimulationPositionOffset_Offset;

	[UFunction(Flags = 214043648u)]
	[UMetaPath("/Script/Niagara.NiagaraParticleCallbackHandler:ReceiveParticleData")]
	public unsafe void ReceiveParticleData(List<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem, FVector SimulationPositionOffset)
	{
		CheckDestroyed();
		if (!ReceiveParticleData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParticleCallbackHandler:ReceiveParticleData");
			return;
		}
		if (ReceiveParticleData_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveParticleData_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveParticleData");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveParticleData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveParticleData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FBasicParticleData>(1, ReceiveParticleData_Data_PropertyAddress, CachedMarshalingDelegates<FBasicParticleData, FBasicParticleData>.FromNative, CachedMarshalingDelegates<FBasicParticleData, FBasicParticleData>.ToNative).ToNative(IntPtr.Add(intPtr, ReceiveParticleData_Data_Offset), Data);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, ReceiveParticleData_NiagaraSystem_Offset), 0, ReceiveParticleData_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveParticleData_SimulationPositionOffset_Offset), 0, ReceiveParticleData_SimulationPositionOffset_PropertyAddress.Address, SimulationPositionOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveParticleData_InstanceFunctionAddress, intPtr, ReceiveParticleData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReceiveParticleData_Data_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		ReceiveParticleData_InstanceFunctionAddress = IntPtr.Zero;
	}

	static INiagaraParticleCallbackHandlerImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INiagaraParticleCallbackHandlerImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INiagaraParticleCallbackHandlerImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraParticleCallbackHandler");
		ReceiveParticleData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveParticleData");
		ReceiveParticleData_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveParticleData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveParticleData_Data_PropertyAddress, ReceiveParticleData_FunctionAddress, "Data");
		ReceiveParticleData_Data_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveParticleData_FunctionAddress, "Data");
		ReceiveParticleData_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveParticleData_FunctionAddress, "Data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveParticleData_NiagaraSystem_PropertyAddress, ReceiveParticleData_FunctionAddress, "NiagaraSystem");
		ReceiveParticleData_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveParticleData_FunctionAddress, "NiagaraSystem");
		ReceiveParticleData_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveParticleData_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveParticleData_SimulationPositionOffset_PropertyAddress, ReceiveParticleData_FunctionAddress, "SimulationPositionOffset");
		ReceiveParticleData_SimulationPositionOffset_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveParticleData_FunctionAddress, "SimulationPositionOffset");
		ReceiveParticleData_SimulationPositionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveParticleData_FunctionAddress, "SimulationPositionOffset", Classes.FStructProperty);
		ReceiveParticleData_IsValid = ReceiveParticleData_FunctionAddress != IntPtr.Zero && ReceiveParticleData_Data_IsValid && ReceiveParticleData_NiagaraSystem_IsValid && ReceiveParticleData_SimulationPositionOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParticleCallbackHandler:ReceiveParticleData", ReceiveParticleData_IsValid);
	}
}
