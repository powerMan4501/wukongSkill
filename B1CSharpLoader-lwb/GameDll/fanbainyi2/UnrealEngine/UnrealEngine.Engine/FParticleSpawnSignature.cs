using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ParticleSpawnSignature__DelegateSignature")]
public class FParticleSpawnSignature : FMulticastDelegate<FParticleSpawnSignature.Signature>
{
	public delegate void Signature(FName EventName, float EmitterTime, FVector Location, FVector Velocity);

	private static bool ParticleSpawnSignature__DelegateSignature_IsValid;

	private static IntPtr ParticleSpawnSignature__DelegateSignature_FunctionAddress;

	private static int ParticleSpawnSignature__DelegateSignature_ParamsSize;

	private static bool ParticleSpawnSignature__DelegateSignature_EventName_IsValid;

	private static FFieldAddress ParticleSpawnSignature__DelegateSignature_EventName_PropertyAddress;

	private static int ParticleSpawnSignature__DelegateSignature_EventName_Offset;

	private static bool ParticleSpawnSignature__DelegateSignature_EmitterTime_IsValid;

	private static FFieldAddress ParticleSpawnSignature__DelegateSignature_EmitterTime_PropertyAddress;

	private static int ParticleSpawnSignature__DelegateSignature_EmitterTime_Offset;

	private static bool ParticleSpawnSignature__DelegateSignature_Location_IsValid;

	private static FFieldAddress ParticleSpawnSignature__DelegateSignature_Location_PropertyAddress;

	private static int ParticleSpawnSignature__DelegateSignature_Location_Offset;

	private static bool ParticleSpawnSignature__DelegateSignature_Velocity_IsValid;

	private static FFieldAddress ParticleSpawnSignature__DelegateSignature_Velocity_PropertyAddress;

	private static int ParticleSpawnSignature__DelegateSignature_Velocity_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FParticleSpawnSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ParticleSpawnSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ParticleSpawnSignature__DelegateSignature");
		ParticleSpawnSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ParticleSpawnSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ParticleSpawnSignature__DelegateSignature_EventName_PropertyAddress, ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleSpawnSignature__DelegateSignature_EventName_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleSpawnSignature__DelegateSignature_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleSpawnSignature__DelegateSignature_EmitterTime_PropertyAddress, ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleSpawnSignature__DelegateSignature_EmitterTime_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleSpawnSignature__DelegateSignature_EmitterTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "EmitterTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleSpawnSignature__DelegateSignature_Location_PropertyAddress, ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Location");
		ParticleSpawnSignature__DelegateSignature_Location_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Location");
		ParticleSpawnSignature__DelegateSignature_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleSpawnSignature__DelegateSignature_Velocity_PropertyAddress, ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Velocity");
		ParticleSpawnSignature__DelegateSignature_Velocity_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Velocity");
		ParticleSpawnSignature__DelegateSignature_Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSpawnSignature__DelegateSignature_FunctionAddress, "Velocity", Classes.FStructProperty);
		ParticleSpawnSignature__DelegateSignature_IsValid = ParticleSpawnSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ParticleSpawnSignature__DelegateSignature_EventName_IsValid && ParticleSpawnSignature__DelegateSignature_EmitterTime_IsValid && ParticleSpawnSignature__DelegateSignature_Location_IsValid && ParticleSpawnSignature__DelegateSignature_Velocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSpawnSignature__DelegateSignature", ParticleSpawnSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName EventName, float EmitterTime, FVector Location, FVector Velocity)
	{
		if (!ParticleSpawnSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSpawnSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ParticleSpawnSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ParticleSpawnSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ParticleSpawnSignature__DelegateSignature_EventName_Offset), 0, ParticleSpawnSignature__DelegateSignature_EventName_PropertyAddress.Address, EventName);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ParticleSpawnSignature__DelegateSignature_EmitterTime_Offset), 0, ParticleSpawnSignature__DelegateSignature_EmitterTime_PropertyAddress.Address, EmitterTime);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ParticleSpawnSignature__DelegateSignature_Location_Offset), 0, ParticleSpawnSignature__DelegateSignature_Location_PropertyAddress.Address, Location);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ParticleSpawnSignature__DelegateSignature_Velocity_Offset), 0, ParticleSpawnSignature__DelegateSignature_Velocity_PropertyAddress.Address, Velocity);
			ProcessDelegate(intPtr);
		}
	}
}
