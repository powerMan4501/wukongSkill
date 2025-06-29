using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UDelegate]
[UMetaPath("/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature")]
public class FOnChaosPhysicsCollision : FMulticastDelegate<FOnChaosPhysicsCollision.Signature>
{
	public delegate void Signature(FChaosPhysicsCollisionInfo CollisionInfo);

	private static bool OnChaosPhysicsCollision__DelegateSignature_IsValid;

	private static IntPtr OnChaosPhysicsCollision__DelegateSignature_FunctionAddress;

	private static int OnChaosPhysicsCollision__DelegateSignature_ParamsSize;

	private static bool OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_IsValid;

	private static FFieldAddress OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_PropertyAddress;

	private static int OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnChaosPhysicsCollision()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnChaosPhysicsCollision__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature");
		OnChaosPhysicsCollision__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChaosPhysicsCollision__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_PropertyAddress, OnChaosPhysicsCollision__DelegateSignature_FunctionAddress, "CollisionInfo");
		OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_Offset = NativeReflectionCached.GetPropertyOffset(OnChaosPhysicsCollision__DelegateSignature_FunctionAddress, "CollisionInfo");
		OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChaosPhysicsCollision__DelegateSignature_FunctionAddress, "CollisionInfo", Classes.FStructProperty);
		OnChaosPhysicsCollision__DelegateSignature_IsValid = OnChaosPhysicsCollision__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature", OnChaosPhysicsCollision__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FChaosPhysicsCollisionInfo CollisionInfo)
	{
		if (!OnChaosPhysicsCollision__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnChaosPhysicsCollision__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChaosPhysicsCollision__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_PropertyAddress.Address, intPtr);
			FChaosPhysicsCollisionInfo.ToNative(IntPtr.Add(intPtr, OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_Offset), 0, OnChaosPhysicsCollision__DelegateSignature_CollisionInfo_PropertyAddress.Address, CollisionInfo);
			ProcessDelegate(intPtr);
		}
	}
}
