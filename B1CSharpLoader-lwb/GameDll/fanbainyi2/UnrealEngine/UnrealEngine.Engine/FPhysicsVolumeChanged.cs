using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PhysicsVolumeChanged__DelegateSignature")]
public class FPhysicsVolumeChanged : FMulticastDelegate<FPhysicsVolumeChanged.Signature>
{
	public delegate void Signature(APhysicsVolume NewVolume);

	private static bool PhysicsVolumeChanged__DelegateSignature_IsValid;

	private static IntPtr PhysicsVolumeChanged__DelegateSignature_FunctionAddress;

	private static int PhysicsVolumeChanged__DelegateSignature_ParamsSize;

	private static bool PhysicsVolumeChanged__DelegateSignature_NewVolume_IsValid;

	private static FFieldAddress PhysicsVolumeChanged__DelegateSignature_NewVolume_PropertyAddress;

	private static int PhysicsVolumeChanged__DelegateSignature_NewVolume_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPhysicsVolumeChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PhysicsVolumeChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PhysicsVolumeChanged__DelegateSignature");
		PhysicsVolumeChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PhysicsVolumeChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PhysicsVolumeChanged__DelegateSignature_NewVolume_PropertyAddress, PhysicsVolumeChanged__DelegateSignature_FunctionAddress, "NewVolume");
		PhysicsVolumeChanged__DelegateSignature_NewVolume_Offset = NativeReflectionCached.GetPropertyOffset(PhysicsVolumeChanged__DelegateSignature_FunctionAddress, "NewVolume");
		PhysicsVolumeChanged__DelegateSignature_NewVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(PhysicsVolumeChanged__DelegateSignature_FunctionAddress, "NewVolume", Classes.FObjectProperty);
		PhysicsVolumeChanged__DelegateSignature_IsValid = PhysicsVolumeChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && PhysicsVolumeChanged__DelegateSignature_NewVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsVolumeChanged__DelegateSignature", PhysicsVolumeChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APhysicsVolume NewVolume)
	{
		if (!PhysicsVolumeChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsVolumeChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PhysicsVolumeChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PhysicsVolumeChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APhysicsVolume>.ToNative(IntPtr.Add(intPtr, PhysicsVolumeChanged__DelegateSignature_NewVolume_Offset), 0, PhysicsVolumeChanged__DelegateSignature_NewVolume_PropertyAddress.Address, NewVolume);
			ProcessDelegate(intPtr);
		}
	}
}
