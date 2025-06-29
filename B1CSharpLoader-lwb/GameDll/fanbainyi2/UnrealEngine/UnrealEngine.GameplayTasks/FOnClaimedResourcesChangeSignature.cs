using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UDelegate]
[UMetaPath("/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature")]
public class FOnClaimedResourcesChangeSignature : FMulticastDelegate<FOnClaimedResourcesChangeSignature.Signature>
{
	public delegate void Signature(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased);

	private static bool OnClaimedResourcesChangeSignature__DelegateSignature_IsValid;

	private static IntPtr OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress;

	private static int OnClaimedResourcesChangeSignature__DelegateSignature_ParamsSize;

	private static bool OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_IsValid;

	private static FFieldAddress OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_PropertyAddress;

	private static int OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_Offset;

	private static bool OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_IsValid;

	private static FFieldAddress OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_PropertyAddress;

	private static int OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnClaimedResourcesChangeSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature");
		OnClaimedResourcesChangeSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_PropertyAddress, OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "NewlyClaimed");
		OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_Offset = NativeReflectionCached.GetPropertyOffset(OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "NewlyClaimed");
		OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_IsValid = NativeReflectionCached.ValidatePropertyClass(OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "NewlyClaimed", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_PropertyAddress, OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "FreshlyReleased");
		OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_Offset = NativeReflectionCached.GetPropertyOffset(OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "FreshlyReleased");
		OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress, "FreshlyReleased", Classes.FStructProperty);
		OnClaimedResourcesChangeSignature__DelegateSignature_IsValid = OnClaimedResourcesChangeSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_IsValid && OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature", OnClaimedResourcesChangeSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
	{
		if (!OnClaimedResourcesChangeSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnClaimedResourcesChangeSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClaimedResourcesChangeSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_PropertyAddress.Address, intPtr);
			FGameplayResourceSet.ToNative(IntPtr.Add(intPtr, OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_Offset), 0, OnClaimedResourcesChangeSignature__DelegateSignature_NewlyClaimed_PropertyAddress.Address, NewlyClaimed);
			NativeReflection.InitializeValue_InContainer(OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_PropertyAddress.Address, intPtr);
			FGameplayResourceSet.ToNative(IntPtr.Add(intPtr, OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_Offset), 0, OnClaimedResourcesChangeSignature__DelegateSignature_FreshlyReleased_PropertyAddress.Address, FreshlyReleased);
			ProcessDelegate(intPtr);
		}
	}
}
