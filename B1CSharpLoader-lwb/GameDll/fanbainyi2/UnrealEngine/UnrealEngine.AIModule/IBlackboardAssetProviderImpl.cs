using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class IBlackboardAssetProviderImpl : IInterfaceImpl, IBlackboardAssetProvider, IInterface
{
	private static bool GetBlackboardAsset_IsValid;

	private IntPtr GetBlackboardAsset_InstanceFunctionAddress;

	private static IntPtr GetBlackboardAsset_FunctionAddress;

	private static int GetBlackboardAsset_ParamsSize;

	private static bool GetBlackboardAsset_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardAsset_ReturnValue_PropertyAddress;

	private static int GetBlackboardAsset_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AIModule.BlackboardAssetProvider:GetBlackboardAsset")]
	public unsafe UBlackboardData GetBlackboardAsset()
	{
		CheckDestroyed();
		if (!GetBlackboardAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardAssetProvider:GetBlackboardAsset");
			return null;
		}
		if (GetBlackboardAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetBlackboardAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetBlackboardAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlackboardAsset_InstanceFunctionAddress, intPtr, GetBlackboardAsset_ParamsSize);
		return UObjectMarshaler<UBlackboardData>.FromNative(IntPtr.Add(intPtr, GetBlackboardAsset_ReturnValue_Offset), 0, GetBlackboardAsset_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetBlackboardAsset_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IBlackboardAssetProviderImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IBlackboardAssetProviderImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IBlackboardAssetProviderImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.BlackboardAssetProvider");
		GetBlackboardAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBlackboardAsset");
		GetBlackboardAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardAsset_ReturnValue_PropertyAddress, GetBlackboardAsset_FunctionAddress, "ReturnValue");
		GetBlackboardAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardAsset_FunctionAddress, "ReturnValue");
		GetBlackboardAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlackboardAsset_IsValid = GetBlackboardAsset_FunctionAddress != IntPtr.Zero && GetBlackboardAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardAssetProvider:GetBlackboardAsset", GetBlackboardAsset_IsValid);
	}
}
