using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SparseVolumeTexture", "Engine", UnrealModuleType.Engine)]
public class USparseVolumeTexture : UObject
{
	private static bool GetSizeZ_IsValid;

	private static IntPtr GetSizeZ_FunctionAddress;

	private static int GetSizeZ_ParamsSize;

	private static bool GetSizeZ_ReturnValue_IsValid;

	private static FFieldAddress GetSizeZ_ReturnValue_PropertyAddress;

	private static int GetSizeZ_ReturnValue_Offset;

	private static bool GetSizeY_IsValid;

	private static IntPtr GetSizeY_FunctionAddress;

	private static int GetSizeY_ParamsSize;

	private static bool GetSizeY_ReturnValue_IsValid;

	private static FFieldAddress GetSizeY_ReturnValue_PropertyAddress;

	private static int GetSizeY_ReturnValue_Offset;

	private static bool GetSizeX_IsValid;

	private static IntPtr GetSizeX_FunctionAddress;

	private static int GetSizeX_ParamsSize;

	private static bool GetSizeX_ReturnValue_IsValid;

	private static FFieldAddress GetSizeX_ReturnValue_PropertyAddress;

	private static int GetSizeX_ReturnValue_Offset;

	private static bool GetNumMipLevels_IsValid;

	private static IntPtr GetNumMipLevels_FunctionAddress;

	private static int GetNumMipLevels_ParamsSize;

	private static bool GetNumMipLevels_ReturnValue_IsValid;

	private static FFieldAddress GetNumMipLevels_ReturnValue_PropertyAddress;

	private static int GetNumMipLevels_ReturnValue_Offset;

	private static bool GetNumFrames_IsValid;

	private static IntPtr GetNumFrames_FunctionAddress;

	private static int GetNumFrames_ParamsSize;

	private static bool GetNumFrames_ReturnValue_IsValid;

	private static FFieldAddress GetNumFrames_ReturnValue_PropertyAddress;

	private static int GetNumFrames_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SparseVolumeTexture:GetSizeZ")]
	public unsafe int GetSizeZ()
	{
		CheckDestroyed();
		if (!GetSizeZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SparseVolumeTexture:GetSizeZ");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSizeZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSizeZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSizeZ_FunctionAddress, intPtr, GetSizeZ_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSizeZ_ReturnValue_Offset), 0, GetSizeZ_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SparseVolumeTexture:GetSizeY")]
	public unsafe int GetSizeY()
	{
		CheckDestroyed();
		if (!GetSizeY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SparseVolumeTexture:GetSizeY");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSizeY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSizeY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSizeY_FunctionAddress, intPtr, GetSizeY_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSizeY_ReturnValue_Offset), 0, GetSizeY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SparseVolumeTexture:GetSizeX")]
	public unsafe int GetSizeX()
	{
		CheckDestroyed();
		if (!GetSizeX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SparseVolumeTexture:GetSizeX");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSizeX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSizeX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSizeX_FunctionAddress, intPtr, GetSizeX_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSizeX_ReturnValue_Offset), 0, GetSizeX_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SparseVolumeTexture:GetNumMipLevels")]
	public unsafe int GetNumMipLevels()
	{
		CheckDestroyed();
		if (!GetNumMipLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SparseVolumeTexture:GetNumMipLevels");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumMipLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumMipLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumMipLevels_FunctionAddress, intPtr, GetNumMipLevels_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumMipLevels_ReturnValue_Offset), 0, GetNumMipLevels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SparseVolumeTexture:GetNumFrames")]
	public unsafe int GetNumFrames()
	{
		CheckDestroyed();
		if (!GetNumFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SparseVolumeTexture:GetNumFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumFrames_FunctionAddress, intPtr, GetNumFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumFrames_ReturnValue_Offset), 0, GetNumFrames_ReturnValue_PropertyAddress.Address);
	}

	static USparseVolumeTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USparseVolumeTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USparseVolumeTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.SparseVolumeTexture");
		GetSizeZ_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSizeZ");
		GetSizeZ_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSizeZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSizeZ_ReturnValue_PropertyAddress, GetSizeZ_FunctionAddress, "ReturnValue");
		GetSizeZ_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSizeZ_FunctionAddress, "ReturnValue");
		GetSizeZ_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSizeZ_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSizeZ_IsValid = GetSizeZ_FunctionAddress != IntPtr.Zero && GetSizeZ_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SparseVolumeTexture:GetSizeZ", GetSizeZ_IsValid);
		GetSizeY_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSizeY");
		GetSizeY_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSizeY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSizeY_ReturnValue_PropertyAddress, GetSizeY_FunctionAddress, "ReturnValue");
		GetSizeY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSizeY_FunctionAddress, "ReturnValue");
		GetSizeY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSizeY_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSizeY_IsValid = GetSizeY_FunctionAddress != IntPtr.Zero && GetSizeY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SparseVolumeTexture:GetSizeY", GetSizeY_IsValid);
		GetSizeX_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSizeX");
		GetSizeX_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSizeX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSizeX_ReturnValue_PropertyAddress, GetSizeX_FunctionAddress, "ReturnValue");
		GetSizeX_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSizeX_FunctionAddress, "ReturnValue");
		GetSizeX_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSizeX_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSizeX_IsValid = GetSizeX_FunctionAddress != IntPtr.Zero && GetSizeX_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SparseVolumeTexture:GetSizeX", GetSizeX_IsValid);
		GetNumMipLevels_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumMipLevels");
		GetNumMipLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumMipLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumMipLevels_ReturnValue_PropertyAddress, GetNumMipLevels_FunctionAddress, "ReturnValue");
		GetNumMipLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumMipLevels_FunctionAddress, "ReturnValue");
		GetNumMipLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumMipLevels_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumMipLevels_IsValid = GetNumMipLevels_FunctionAddress != IntPtr.Zero && GetNumMipLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SparseVolumeTexture:GetNumMipLevels", GetNumMipLevels_IsValid);
		GetNumFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumFrames");
		GetNumFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumFrames_ReturnValue_PropertyAddress, GetNumFrames_FunctionAddress, "ReturnValue");
		GetNumFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumFrames_FunctionAddress, "ReturnValue");
		GetNumFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumFrames_IsValid = GetNumFrames_FunctionAddress != IntPtr.Zero && GetNumFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SparseVolumeTexture:GetNumFrames", GetNumFrames_IsValid);
	}
}
