using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Texture2D", "Engine", UnrealModuleType.Engine)]
public class UTexture2D : UTexture
{
	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	private static bool Blueprint_GetSizeY_IsValid;

	private static IntPtr Blueprint_GetSizeY_FunctionAddress;

	private static int Blueprint_GetSizeY_ParamsSize;

	private static bool Blueprint_GetSizeY_ReturnValue_IsValid;

	private static FFieldAddress Blueprint_GetSizeY_ReturnValue_PropertyAddress;

	private static int Blueprint_GetSizeY_ReturnValue_Offset;

	private static bool Blueprint_GetSizeX_IsValid;

	private static IntPtr Blueprint_GetSizeX_FunctionAddress;

	private static int Blueprint_GetSizeX_ParamsSize;

	private static bool Blueprint_GetSizeX_ReturnValue_IsValid;

	private static FFieldAddress Blueprint_GetSizeX_ReturnValue_PropertyAddress;

	private static int Blueprint_GetSizeX_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.Texture2D:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture2D:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture2D:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.Texture2D:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture2D:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture2D:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Texture2D:Blueprint_GetSizeY")]
	public unsafe int Blueprint_GetSizeY()
	{
		CheckDestroyed();
		if (!Blueprint_GetSizeY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Texture2D:Blueprint_GetSizeY");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Blueprint_GetSizeY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Blueprint_GetSizeY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Blueprint_GetSizeY_FunctionAddress, intPtr, Blueprint_GetSizeY_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Blueprint_GetSizeY_ReturnValue_Offset), 0, Blueprint_GetSizeY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Texture2D:Blueprint_GetSizeX")]
	public unsafe int Blueprint_GetSizeX()
	{
		CheckDestroyed();
		if (!Blueprint_GetSizeX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Texture2D:Blueprint_GetSizeX");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Blueprint_GetSizeX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Blueprint_GetSizeX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Blueprint_GetSizeX_FunctionAddress, intPtr, Blueprint_GetSizeX_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Blueprint_GetSizeX_ReturnValue_Offset), 0, Blueprint_GetSizeX_ReturnValue_PropertyAddress.Address);
	}

	static UTexture2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTexture2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTexture2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Texture2D");
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, intPtr, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, intPtr, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressY", Classes.FByteProperty);
		Blueprint_GetSizeY_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Blueprint_GetSizeY");
		Blueprint_GetSizeY_ParamsSize = NativeReflection.GetFunctionParamsSize(Blueprint_GetSizeY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Blueprint_GetSizeY_ReturnValue_PropertyAddress, Blueprint_GetSizeY_FunctionAddress, "ReturnValue");
		Blueprint_GetSizeY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Blueprint_GetSizeY_FunctionAddress, "ReturnValue");
		Blueprint_GetSizeY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Blueprint_GetSizeY_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Blueprint_GetSizeY_IsValid = Blueprint_GetSizeY_FunctionAddress != IntPtr.Zero && Blueprint_GetSizeY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Texture2D:Blueprint_GetSizeY", Blueprint_GetSizeY_IsValid);
		Blueprint_GetSizeX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Blueprint_GetSizeX");
		Blueprint_GetSizeX_ParamsSize = NativeReflection.GetFunctionParamsSize(Blueprint_GetSizeX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Blueprint_GetSizeX_ReturnValue_PropertyAddress, Blueprint_GetSizeX_FunctionAddress, "ReturnValue");
		Blueprint_GetSizeX_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Blueprint_GetSizeX_FunctionAddress, "ReturnValue");
		Blueprint_GetSizeX_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Blueprint_GetSizeX_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Blueprint_GetSizeX_IsValid = Blueprint_GetSizeX_FunctionAddress != IntPtr.Zero && Blueprint_GetSizeX_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Texture2D:Blueprint_GetSizeX", Blueprint_GetSizeX_IsValid);
	}
}
