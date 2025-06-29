using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature")]
public class FActorPerceptionInfoUpdatedDelegate : FMulticastDelegate<FActorPerceptionInfoUpdatedDelegate.Signature>
{
	public delegate void Signature(FActorPerceptionUpdateInfo UpdateInfo);

	private static bool ActorPerceptionInfoUpdatedDelegate__DelegateSignature_IsValid;

	private static IntPtr ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress;

	private static int ActorPerceptionInfoUpdatedDelegate__DelegateSignature_ParamsSize;

	private static bool ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_IsValid;

	private static FFieldAddress ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_PropertyAddress;

	private static int ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorPerceptionInfoUpdatedDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature");
		ActorPerceptionInfoUpdatedDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_PropertyAddress, ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdateInfo");
		ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_Offset = NativeReflectionCached.GetPropertyOffset(ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdateInfo");
		ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress, "UpdateInfo", Classes.FStructProperty);
		ActorPerceptionInfoUpdatedDelegate__DelegateSignature_IsValid = ActorPerceptionInfoUpdatedDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature", ActorPerceptionInfoUpdatedDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FActorPerceptionUpdateInfo UpdateInfo)
	{
		if (!ActorPerceptionInfoUpdatedDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorPerceptionInfoUpdatedDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorPerceptionInfoUpdatedDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_PropertyAddress.Address, intPtr);
			FActorPerceptionUpdateInfo.ToNative(IntPtr.Add(intPtr, ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_Offset), 0, ActorPerceptionInfoUpdatedDelegate__DelegateSignature_UpdateInfo_PropertyAddress.Address, UpdateInfo);
			ProcessDelegate(intPtr);
		}
	}
}
