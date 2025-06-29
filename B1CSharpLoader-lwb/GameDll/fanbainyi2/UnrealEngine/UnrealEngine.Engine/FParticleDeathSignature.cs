using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ParticleDeathSignature__DelegateSignature")]
public class FParticleDeathSignature : FMulticastDelegate<FParticleDeathSignature.Signature>
{
	public delegate void Signature(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction);

	private static bool ParticleDeathSignature__DelegateSignature_IsValid;

	private static IntPtr ParticleDeathSignature__DelegateSignature_FunctionAddress;

	private static int ParticleDeathSignature__DelegateSignature_ParamsSize;

	private static bool ParticleDeathSignature__DelegateSignature_EventName_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_EventName_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_EventName_Offset;

	private static bool ParticleDeathSignature__DelegateSignature_EmitterTime_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_EmitterTime_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_EmitterTime_Offset;

	private static bool ParticleDeathSignature__DelegateSignature_ParticleTime_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_ParticleTime_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_ParticleTime_Offset;

	private static bool ParticleDeathSignature__DelegateSignature_Location_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_Location_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_Location_Offset;

	private static bool ParticleDeathSignature__DelegateSignature_Velocity_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_Velocity_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_Velocity_Offset;

	private static bool ParticleDeathSignature__DelegateSignature_Direction_IsValid;

	private static FFieldAddress ParticleDeathSignature__DelegateSignature_Direction_PropertyAddress;

	private static int ParticleDeathSignature__DelegateSignature_Direction_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FParticleDeathSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ParticleDeathSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ParticleDeathSignature__DelegateSignature");
		ParticleDeathSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ParticleDeathSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_EventName_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleDeathSignature__DelegateSignature_EventName_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "EventName");
		ParticleDeathSignature__DelegateSignature_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "EventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_EmitterTime_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleDeathSignature__DelegateSignature_EmitterTime_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "EmitterTime");
		ParticleDeathSignature__DelegateSignature_EmitterTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "EmitterTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_ParticleTime_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "ParticleTime");
		ParticleDeathSignature__DelegateSignature_ParticleTime_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "ParticleTime");
		ParticleDeathSignature__DelegateSignature_ParticleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "ParticleTime", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_Location_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "Location");
		ParticleDeathSignature__DelegateSignature_Location_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Location");
		ParticleDeathSignature__DelegateSignature_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_Velocity_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "Velocity");
		ParticleDeathSignature__DelegateSignature_Velocity_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Velocity");
		ParticleDeathSignature__DelegateSignature_Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Velocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleDeathSignature__DelegateSignature_Direction_PropertyAddress, ParticleDeathSignature__DelegateSignature_FunctionAddress, "Direction");
		ParticleDeathSignature__DelegateSignature_Direction_Offset = NativeReflectionCached.GetPropertyOffset(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Direction");
		ParticleDeathSignature__DelegateSignature_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleDeathSignature__DelegateSignature_FunctionAddress, "Direction", Classes.FStructProperty);
		ParticleDeathSignature__DelegateSignature_IsValid = ParticleDeathSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ParticleDeathSignature__DelegateSignature_EventName_IsValid && ParticleDeathSignature__DelegateSignature_EmitterTime_IsValid && ParticleDeathSignature__DelegateSignature_ParticleTime_IsValid && ParticleDeathSignature__DelegateSignature_Location_IsValid && ParticleDeathSignature__DelegateSignature_Velocity_IsValid && ParticleDeathSignature__DelegateSignature_Direction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleDeathSignature__DelegateSignature", ParticleDeathSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction)
	{
		if (!ParticleDeathSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleDeathSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ParticleDeathSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ParticleDeathSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_EventName_Offset), 0, ParticleDeathSignature__DelegateSignature_EventName_PropertyAddress.Address, EventName);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_EmitterTime_Offset), 0, ParticleDeathSignature__DelegateSignature_EmitterTime_PropertyAddress.Address, EmitterTime);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_ParticleTime_Offset), 0, ParticleDeathSignature__DelegateSignature_ParticleTime_PropertyAddress.Address, ParticleTime);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_Location_Offset), 0, ParticleDeathSignature__DelegateSignature_Location_PropertyAddress.Address, Location);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_Velocity_Offset), 0, ParticleDeathSignature__DelegateSignature_Velocity_PropertyAddress.Address, Velocity);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ParticleDeathSignature__DelegateSignature_Direction_Offset), 0, ParticleDeathSignature__DelegateSignature_Direction_PropertyAddress.Address, Direction);
			ProcessDelegate(intPtr);
		}
	}
}
