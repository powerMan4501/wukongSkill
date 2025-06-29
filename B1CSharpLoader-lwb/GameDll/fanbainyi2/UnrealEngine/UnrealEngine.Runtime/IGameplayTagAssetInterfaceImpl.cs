using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Runtime;

public sealed class IGameplayTagAssetInterfaceImpl : IInterfaceImpl, IGameplayTagAssetInterface, IInterface
{
	private static bool HasMatchingGameplayTag_IsValid;

	private IntPtr HasMatchingGameplayTag_InstanceFunctionAddress;

	private static IntPtr HasMatchingGameplayTag_FunctionAddress;

	private static int HasMatchingGameplayTag_ParamsSize;

	private static bool HasMatchingGameplayTag_TagToCheck_IsValid;

	private static FFieldAddress HasMatchingGameplayTag_TagToCheck_PropertyAddress;

	private static int HasMatchingGameplayTag_TagToCheck_Offset;

	private static bool HasMatchingGameplayTag_ReturnValue_IsValid;

	private static FFieldAddress HasMatchingGameplayTag_ReturnValue_PropertyAddress;

	private static int HasMatchingGameplayTag_ReturnValue_Offset;

	private static bool HasAnyMatchingGameplayTags_IsValid;

	private IntPtr HasAnyMatchingGameplayTags_InstanceFunctionAddress;

	private static IntPtr HasAnyMatchingGameplayTags_FunctionAddress;

	private static int HasAnyMatchingGameplayTags_ParamsSize;

	private static bool HasAnyMatchingGameplayTags_TagContainer_IsValid;

	private static FFieldAddress HasAnyMatchingGameplayTags_TagContainer_PropertyAddress;

	private static int HasAnyMatchingGameplayTags_TagContainer_Offset;

	private static bool HasAnyMatchingGameplayTags_ReturnValue_IsValid;

	private static FFieldAddress HasAnyMatchingGameplayTags_ReturnValue_PropertyAddress;

	private static int HasAnyMatchingGameplayTags_ReturnValue_Offset;

	private static bool HasAllMatchingGameplayTags_IsValid;

	private IntPtr HasAllMatchingGameplayTags_InstanceFunctionAddress;

	private static IntPtr HasAllMatchingGameplayTags_FunctionAddress;

	private static int HasAllMatchingGameplayTags_ParamsSize;

	private static bool HasAllMatchingGameplayTags_TagContainer_IsValid;

	private static FFieldAddress HasAllMatchingGameplayTags_TagContainer_PropertyAddress;

	private static int HasAllMatchingGameplayTags_TagContainer_Offset;

	private static bool HasAllMatchingGameplayTags_ReturnValue_IsValid;

	private static FFieldAddress HasAllMatchingGameplayTags_ReturnValue_PropertyAddress;

	private static int HasAllMatchingGameplayTags_ReturnValue_Offset;

	private static bool GetOwnedGameplayTags_IsValid;

	private IntPtr GetOwnedGameplayTags_InstanceFunctionAddress;

	private static IntPtr GetOwnedGameplayTags_FunctionAddress;

	private static int GetOwnedGameplayTags_ParamsSize;

	private static bool GetOwnedGameplayTags_TagContainer_IsValid;

	private static FFieldAddress GetOwnedGameplayTags_TagContainer_PropertyAddress;

	private static int GetOwnedGameplayTags_TagContainer_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasMatchingGameplayTag")]
	public unsafe bool HasMatchingGameplayTag(FGameplayTag TagToCheck)
	{
		CheckDestroyed();
		if (!HasMatchingGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.GameplayTagAssetInterface:HasMatchingGameplayTag");
			return false;
		}
		if (HasMatchingGameplayTag_InstanceFunctionAddress == IntPtr.Zero)
		{
			HasMatchingGameplayTag_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HasMatchingGameplayTag");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMatchingGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMatchingGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasMatchingGameplayTag_TagToCheck_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, HasMatchingGameplayTag_TagToCheck_Offset), 0, HasMatchingGameplayTag_TagToCheck_PropertyAddress.Address, TagToCheck);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMatchingGameplayTag_InstanceFunctionAddress, intPtr, HasMatchingGameplayTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMatchingGameplayTag_ReturnValue_Offset), 0, HasMatchingGameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasAnyMatchingGameplayTags")]
	public unsafe bool HasAnyMatchingGameplayTags(FGameplayTagContainer TagContainer)
	{
		CheckDestroyed();
		if (!HasAnyMatchingGameplayTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.GameplayTagAssetInterface:HasAnyMatchingGameplayTags");
			return false;
		}
		if (HasAnyMatchingGameplayTags_InstanceFunctionAddress == IntPtr.Zero)
		{
			HasAnyMatchingGameplayTags_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HasAnyMatchingGameplayTags");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnyMatchingGameplayTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnyMatchingGameplayTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasAnyMatchingGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAnyMatchingGameplayTags_TagContainer_Offset), 0, HasAnyMatchingGameplayTags_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAnyMatchingGameplayTags_InstanceFunctionAddress, intPtr, HasAnyMatchingGameplayTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasAnyMatchingGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnyMatchingGameplayTags_ReturnValue_Offset), 0, HasAnyMatchingGameplayTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasAllMatchingGameplayTags")]
	public unsafe bool HasAllMatchingGameplayTags(FGameplayTagContainer TagContainer)
	{
		CheckDestroyed();
		if (!HasAllMatchingGameplayTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.GameplayTagAssetInterface:HasAllMatchingGameplayTags");
			return false;
		}
		if (HasAllMatchingGameplayTags_InstanceFunctionAddress == IntPtr.Zero)
		{
			HasAllMatchingGameplayTags_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HasAllMatchingGameplayTags");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAllMatchingGameplayTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAllMatchingGameplayTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasAllMatchingGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAllMatchingGameplayTags_TagContainer_Offset), 0, HasAllMatchingGameplayTags_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAllMatchingGameplayTags_InstanceFunctionAddress, intPtr, HasAllMatchingGameplayTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasAllMatchingGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAllMatchingGameplayTags_ReturnValue_Offset), 0, HasAllMatchingGameplayTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:GetOwnedGameplayTags")]
	public unsafe void GetOwnedGameplayTags(out FGameplayTagContainer TagContainer)
	{
		CheckDestroyed();
		if (!GetOwnedGameplayTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.GameplayTagAssetInterface:GetOwnedGameplayTags");
			TagContainer = default(FGameplayTagContainer);
			return;
		}
		if (GetOwnedGameplayTags_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetOwnedGameplayTags_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetOwnedGameplayTags");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnedGameplayTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnedGameplayTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOwnedGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwnedGameplayTags_InstanceFunctionAddress, intPtr, GetOwnedGameplayTags_ParamsSize);
		TagContainer = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, GetOwnedGameplayTags_TagContainer_Offset), 0, GetOwnedGameplayTags_TagContainer_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOwnedGameplayTags_TagContainer_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		HasMatchingGameplayTag_InstanceFunctionAddress = IntPtr.Zero;
		HasAnyMatchingGameplayTags_InstanceFunctionAddress = IntPtr.Zero;
		HasAllMatchingGameplayTags_InstanceFunctionAddress = IntPtr.Zero;
		GetOwnedGameplayTags_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IGameplayTagAssetInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IGameplayTagAssetInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IGameplayTagAssetInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GameplayTags.GameplayTagAssetInterface");
		HasMatchingGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasMatchingGameplayTag");
		HasMatchingGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMatchingGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMatchingGameplayTag_TagToCheck_PropertyAddress, HasMatchingGameplayTag_FunctionAddress, "TagToCheck");
		HasMatchingGameplayTag_TagToCheck_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchingGameplayTag_FunctionAddress, "TagToCheck");
		HasMatchingGameplayTag_TagToCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchingGameplayTag_FunctionAddress, "TagToCheck", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasMatchingGameplayTag_ReturnValue_PropertyAddress, HasMatchingGameplayTag_FunctionAddress, "ReturnValue");
		HasMatchingGameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchingGameplayTag_FunctionAddress, "ReturnValue");
		HasMatchingGameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchingGameplayTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMatchingGameplayTag_IsValid = HasMatchingGameplayTag_FunctionAddress != IntPtr.Zero && HasMatchingGameplayTag_TagToCheck_IsValid && HasMatchingGameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.GameplayTagAssetInterface:HasMatchingGameplayTag", HasMatchingGameplayTag_IsValid);
		HasAnyMatchingGameplayTags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasAnyMatchingGameplayTags");
		HasAnyMatchingGameplayTags_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnyMatchingGameplayTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnyMatchingGameplayTags_TagContainer_PropertyAddress, HasAnyMatchingGameplayTags_FunctionAddress, "TagContainer");
		HasAnyMatchingGameplayTags_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyMatchingGameplayTags_FunctionAddress, "TagContainer");
		HasAnyMatchingGameplayTags_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyMatchingGameplayTags_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAnyMatchingGameplayTags_ReturnValue_PropertyAddress, HasAnyMatchingGameplayTags_FunctionAddress, "ReturnValue");
		HasAnyMatchingGameplayTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyMatchingGameplayTags_FunctionAddress, "ReturnValue");
		HasAnyMatchingGameplayTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyMatchingGameplayTags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnyMatchingGameplayTags_IsValid = HasAnyMatchingGameplayTags_FunctionAddress != IntPtr.Zero && HasAnyMatchingGameplayTags_TagContainer_IsValid && HasAnyMatchingGameplayTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.GameplayTagAssetInterface:HasAnyMatchingGameplayTags", HasAnyMatchingGameplayTags_IsValid);
		HasAllMatchingGameplayTags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasAllMatchingGameplayTags");
		HasAllMatchingGameplayTags_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAllMatchingGameplayTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAllMatchingGameplayTags_TagContainer_PropertyAddress, HasAllMatchingGameplayTags_FunctionAddress, "TagContainer");
		HasAllMatchingGameplayTags_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAllMatchingGameplayTags_FunctionAddress, "TagContainer");
		HasAllMatchingGameplayTags_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllMatchingGameplayTags_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAllMatchingGameplayTags_ReturnValue_PropertyAddress, HasAllMatchingGameplayTags_FunctionAddress, "ReturnValue");
		HasAllMatchingGameplayTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAllMatchingGameplayTags_FunctionAddress, "ReturnValue");
		HasAllMatchingGameplayTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllMatchingGameplayTags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAllMatchingGameplayTags_IsValid = HasAllMatchingGameplayTags_FunctionAddress != IntPtr.Zero && HasAllMatchingGameplayTags_TagContainer_IsValid && HasAllMatchingGameplayTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.GameplayTagAssetInterface:HasAllMatchingGameplayTags", HasAllMatchingGameplayTags_IsValid);
		GetOwnedGameplayTags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOwnedGameplayTags");
		GetOwnedGameplayTags_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnedGameplayTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnedGameplayTags_TagContainer_PropertyAddress, GetOwnedGameplayTags_FunctionAddress, "TagContainer");
		GetOwnedGameplayTags_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnedGameplayTags_FunctionAddress, "TagContainer");
		GetOwnedGameplayTags_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnedGameplayTags_FunctionAddress, "TagContainer", Classes.FStructProperty);
		GetOwnedGameplayTags_IsValid = GetOwnedGameplayTags_FunctionAddress != IntPtr.Zero && GetOwnedGameplayTags_TagContainer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.GameplayTagAssetInterface:GetOwnedGameplayTags", GetOwnedGameplayTags_IsValid);
	}
}
