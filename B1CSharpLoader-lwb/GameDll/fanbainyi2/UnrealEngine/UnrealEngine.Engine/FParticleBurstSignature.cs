using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ParticleBurstSignature__DelegateSignature")]
public class FParticleBurstSignature : FMulticastDelegate<FParticleBurstSignature.Signature>
{
	public delegate void Signature(FName EventName, float EmitterTime, int ParticleCount);

	private static bool ParticleBurstSignature__DelegateSignature_IsValid;

	private static IntPtr ParticleBurstSignature__DelegateSignature_FunctionAddress;

	private static int ParticleBurstSignature__DelegateSignature_ParamsSize;

	private static bool ParticleBurstSignature__DelegateSignature_EventName_IsValid;

	private static FFieldAddress ParticleBurstSignature__DelegateSignature_EventName_PropertyAddress;

	private static int ParticleBurstSignature__DelegateSignature_EventName_Offset;

	private static bool ParticleBurstSignature__DelegateSignature_EmitterTime_IsValid;

	private static FFieldAddress ParticleBurstSignature__DelegateSignature_EmitterTime_PropertyAddress;

	private static int ParticleBurstSignature__DelegateSignature_EmitterTime_Offset;

	private static bool ParticleBurstSignature__DelegateSignature_ParticleCount_IsValid;

	private static FFieldAddress ParticleBurstSignature__DelegateSignature_ParticleCount_PropertyAddress;

	private static int ParticleBurstSignature__DelegateSignature_ParticleCount_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FParticleBurstSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ParticleBurstSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ParticleBurstSignature__DelegateSignature");
		ParticleBurstSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ParticleBurstSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ParticleBurstSignature__DelegateSignature_EventName_PropertyAddress, ParticleBurstSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleBurstSignature__DelegateSignature_EventName_Offset = NativeReflectionCached.GetPropertyOffset(ParticleBurstSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleBurstSignature__DelegateSignature_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleBurstSignature__DelegateSignature_FunctionAddress, "EventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleBurstSignature__DelegateSignature_EmitterTime_PropertyAddress, ParticleBurstSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleBurstSignature__DelegateSignature_EmitterTime_Offset = NativeReflectionCached.GetPropertyOffset(ParticleBurstSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleBurstSignature__DelegateSignature_EmitterTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleBurstSignature__DelegateSignature_FunctionAddress, "EmitterTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleBurstSignature__DelegateSignature_ParticleCount_PropertyAddress, ParticleBurstSignature__DelegateSignature_FunctionAddress, "ParticleCount");
		ParticleBurstSignature__DelegateSignature_ParticleCount_Offset = NativeReflectionCached.GetPropertyOffset(ParticleBurstSignature__DelegateSignature_FunctionAddress, "ParticleCount");
		ParticleBurstSignature__DelegateSignature_ParticleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleBurstSignature__DelegateSignature_FunctionAddress, "ParticleCount", Classes.FIntProperty);
		ParticleBurstSignature__DelegateSignature_IsValid = ParticleBurstSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ParticleBurstSignature__DelegateSignature_EventName_IsValid && ParticleBurstSignature__DelegateSignature_EmitterTime_IsValid && ParticleBurstSignature__DelegateSignature_ParticleCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleBurstSignature__DelegateSignature", ParticleBurstSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName EventName, float EmitterTime, int ParticleCount)
	{
		if (!ParticleBurstSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleBurstSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ParticleBurstSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ParticleBurstSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ParticleBurstSignature__DelegateSignature_EventName_Offset), 0, ParticleBurstSignature__DelegateSignature_EventName_PropertyAddress.Address, EventName);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ParticleBurstSignature__DelegateSignature_EmitterTime_Offset), 0, ParticleBurstSignature__DelegateSignature_EmitterTime_PropertyAddress.Address, EmitterTime);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ParticleBurstSignature__DelegateSignature_ParticleCount_Offset), 0, ParticleBurstSignature__DelegateSignature_ParticleCount_PropertyAddress.Address, ParticleCount);
			ProcessDelegate(intPtr);
		}
	}
}
