using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MobilePatchingUtils.MobileInstalledContent", "MobilePatchingUtils", UnrealModuleType.EnginePlugin)]
public class UMobileInstalledContent : UObject
{
	private static bool Mount_IsValid;

	private static IntPtr Mount_FunctionAddress;

	private static int Mount_ParamsSize;

	private static bool Mount_PakOrder_IsValid;

	private static FFieldAddress Mount_PakOrder_PropertyAddress;

	private static int Mount_PakOrder_Offset;

	private static bool Mount_MountPoint_IsValid;

	private static FFieldAddress Mount_MountPoint_PropertyAddress;

	private static int Mount_MountPoint_Offset;

	private static bool Mount_ReturnValue_IsValid;

	private static FFieldAddress Mount_ReturnValue_PropertyAddress;

	private static int Mount_ReturnValue_Offset;

	private static bool GetInstalledContentSize_IsValid;

	private static IntPtr GetInstalledContentSize_FunctionAddress;

	private static int GetInstalledContentSize_ParamsSize;

	private static bool GetInstalledContentSize_ReturnValue_IsValid;

	private static FFieldAddress GetInstalledContentSize_ReturnValue_PropertyAddress;

	private static int GetInstalledContentSize_ReturnValue_Offset;

	private static bool GetDiskFreeSpace_IsValid;

	private static IntPtr GetDiskFreeSpace_FunctionAddress;

	private static int GetDiskFreeSpace_ParamsSize;

	private static bool GetDiskFreeSpace_ReturnValue_IsValid;

	private static FFieldAddress GetDiskFreeSpace_ReturnValue_PropertyAddress;

	private static int GetDiskFreeSpace_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobileInstalledContent:Mount")]
	public unsafe bool Mount(int PakOrder, string MountPoint)
	{
		CheckDestroyed();
		if (!Mount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobileInstalledContent:Mount");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Mount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Mount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Mount_PakOrder_Offset), 0, Mount_PakOrder_PropertyAddress.Address, PakOrder);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Mount_MountPoint_Offset), 0, Mount_MountPoint_PropertyAddress.Address, MountPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, Mount_FunctionAddress, intPtr, Mount_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Mount_MountPoint_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Mount_ReturnValue_Offset), 0, Mount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobileInstalledContent:GetInstalledContentSize")]
	public unsafe float GetInstalledContentSize()
	{
		CheckDestroyed();
		if (!GetInstalledContentSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobileInstalledContent:GetInstalledContentSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstalledContentSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstalledContentSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstalledContentSize_FunctionAddress, intPtr, GetInstalledContentSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInstalledContentSize_ReturnValue_Offset), 0, GetInstalledContentSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobileInstalledContent:GetDiskFreeSpace")]
	public unsafe float GetDiskFreeSpace()
	{
		CheckDestroyed();
		if (!GetDiskFreeSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobileInstalledContent:GetDiskFreeSpace");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDiskFreeSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDiskFreeSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDiskFreeSpace_FunctionAddress, intPtr, GetDiskFreeSpace_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDiskFreeSpace_ReturnValue_Offset), 0, GetDiskFreeSpace_ReturnValue_PropertyAddress.Address);
	}

	static UMobileInstalledContent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMobileInstalledContent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMobileInstalledContent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MobilePatchingUtils.MobileInstalledContent");
		Mount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Mount");
		Mount_ParamsSize = NativeReflection.GetFunctionParamsSize(Mount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Mount_PakOrder_PropertyAddress, Mount_FunctionAddress, "PakOrder");
		Mount_PakOrder_Offset = NativeReflectionCached.GetPropertyOffset(Mount_FunctionAddress, "PakOrder");
		Mount_PakOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(Mount_FunctionAddress, "PakOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Mount_MountPoint_PropertyAddress, Mount_FunctionAddress, "MountPoint");
		Mount_MountPoint_Offset = NativeReflectionCached.GetPropertyOffset(Mount_FunctionAddress, "MountPoint");
		Mount_MountPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(Mount_FunctionAddress, "MountPoint", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Mount_ReturnValue_PropertyAddress, Mount_FunctionAddress, "ReturnValue");
		Mount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Mount_FunctionAddress, "ReturnValue");
		Mount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Mount_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Mount_IsValid = Mount_FunctionAddress != IntPtr.Zero && Mount_PakOrder_IsValid && Mount_MountPoint_IsValid && Mount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobileInstalledContent:Mount", Mount_IsValid);
		GetInstalledContentSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInstalledContentSize");
		GetInstalledContentSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstalledContentSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstalledContentSize_ReturnValue_PropertyAddress, GetInstalledContentSize_FunctionAddress, "ReturnValue");
		GetInstalledContentSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstalledContentSize_FunctionAddress, "ReturnValue");
		GetInstalledContentSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstalledContentSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInstalledContentSize_IsValid = GetInstalledContentSize_FunctionAddress != IntPtr.Zero && GetInstalledContentSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobileInstalledContent:GetInstalledContentSize", GetInstalledContentSize_IsValid);
		GetDiskFreeSpace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDiskFreeSpace");
		GetDiskFreeSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDiskFreeSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDiskFreeSpace_ReturnValue_PropertyAddress, GetDiskFreeSpace_FunctionAddress, "ReturnValue");
		GetDiskFreeSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDiskFreeSpace_FunctionAddress, "ReturnValue");
		GetDiskFreeSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDiskFreeSpace_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDiskFreeSpace_IsValid = GetDiskFreeSpace_FunctionAddress != IntPtr.Zero && GetDiskFreeSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobileInstalledContent:GetDiskFreeSpace", GetDiskFreeSpace_IsValid);
	}
}
