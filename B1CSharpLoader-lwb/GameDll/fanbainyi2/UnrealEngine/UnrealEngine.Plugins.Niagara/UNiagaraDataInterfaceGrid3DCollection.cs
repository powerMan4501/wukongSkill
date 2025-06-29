using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceGrid3DCollection : UNiagaraDataInterfaceGrid3D
{
	private static bool GetTextureSize_IsValid;

	private static IntPtr GetTextureSize_FunctionAddress;

	private static int GetTextureSize_ParamsSize;

	private static bool GetTextureSize_Component_IsValid;

	private static FFieldAddress GetTextureSize_Component_PropertyAddress;

	private static int GetTextureSize_Component_Offset;

	private static bool GetTextureSize_SizeX_IsValid;

	private static FFieldAddress GetTextureSize_SizeX_PropertyAddress;

	private static int GetTextureSize_SizeX_Offset;

	private static bool GetTextureSize_SizeY_IsValid;

	private static FFieldAddress GetTextureSize_SizeY_PropertyAddress;

	private static int GetTextureSize_SizeY_Offset;

	private static bool GetTextureSize_SizeZ_IsValid;

	private static FFieldAddress GetTextureSize_SizeZ_PropertyAddress;

	private static int GetTextureSize_SizeZ_Offset;

	private static bool GetRawTextureSize_IsValid;

	private static IntPtr GetRawTextureSize_FunctionAddress;

	private static int GetRawTextureSize_ParamsSize;

	private static bool GetRawTextureSize_Component_IsValid;

	private static FFieldAddress GetRawTextureSize_Component_PropertyAddress;

	private static int GetRawTextureSize_Component_Offset;

	private static bool GetRawTextureSize_SizeX_IsValid;

	private static FFieldAddress GetRawTextureSize_SizeX_PropertyAddress;

	private static int GetRawTextureSize_SizeX_Offset;

	private static bool GetRawTextureSize_SizeY_IsValid;

	private static FFieldAddress GetRawTextureSize_SizeY_PropertyAddress;

	private static int GetRawTextureSize_SizeY_Offset;

	private static bool GetRawTextureSize_SizeZ_IsValid;

	private static FFieldAddress GetRawTextureSize_SizeZ_PropertyAddress;

	private static int GetRawTextureSize_SizeZ_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetTextureSize")]
	public unsafe void GetTextureSize(UNiagaraComponent Component, out int SizeX, out int SizeY, out int SizeZ)
	{
		CheckDestroyed();
		if (!GetTextureSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetTextureSize");
			SizeX = 0;
			SizeY = 0;
			SizeZ = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetTextureSize_Component_Offset), 0, GetTextureSize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureSize_FunctionAddress, intPtr, GetTextureSize_ParamsSize);
		SizeX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureSize_SizeX_Offset), 0, GetTextureSize_SizeX_PropertyAddress.Address);
		SizeY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureSize_SizeY_Offset), 0, GetTextureSize_SizeY_PropertyAddress.Address);
		SizeZ = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureSize_SizeZ_Offset), 0, GetTextureSize_SizeZ_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetRawTextureSize")]
	public unsafe void GetRawTextureSize(UNiagaraComponent Component, out int SizeX, out int SizeY, out int SizeZ)
	{
		CheckDestroyed();
		if (!GetRawTextureSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetRawTextureSize");
			SizeX = 0;
			SizeY = 0;
			SizeZ = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRawTextureSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRawTextureSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetRawTextureSize_Component_Offset), 0, GetRawTextureSize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRawTextureSize_FunctionAddress, intPtr, GetRawTextureSize_ParamsSize);
		SizeX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRawTextureSize_SizeX_Offset), 0, GetRawTextureSize_SizeX_PropertyAddress.Address);
		SizeY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRawTextureSize_SizeY_Offset), 0, GetRawTextureSize_SizeY_PropertyAddress.Address);
		SizeZ = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRawTextureSize_SizeZ_Offset), 0, GetRawTextureSize_SizeZ_PropertyAddress.Address);
	}

	static UNiagaraDataInterfaceGrid3DCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceGrid3DCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceGrid3DCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection");
		GetTextureSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureSize");
		GetTextureSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureSize_Component_PropertyAddress, GetTextureSize_FunctionAddress, "Component");
		GetTextureSize_Component_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureSize_FunctionAddress, "Component");
		GetTextureSize_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureSize_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureSize_SizeX_PropertyAddress, GetTextureSize_FunctionAddress, "SizeX");
		GetTextureSize_SizeX_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureSize_FunctionAddress, "SizeX");
		GetTextureSize_SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureSize_FunctionAddress, "SizeX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureSize_SizeY_PropertyAddress, GetTextureSize_FunctionAddress, "SizeY");
		GetTextureSize_SizeY_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureSize_FunctionAddress, "SizeY");
		GetTextureSize_SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureSize_FunctionAddress, "SizeY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureSize_SizeZ_PropertyAddress, GetTextureSize_FunctionAddress, "SizeZ");
		GetTextureSize_SizeZ_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureSize_FunctionAddress, "SizeZ");
		GetTextureSize_SizeZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureSize_FunctionAddress, "SizeZ", Classes.FIntProperty);
		GetTextureSize_IsValid = GetTextureSize_FunctionAddress != IntPtr.Zero && GetTextureSize_Component_IsValid && GetTextureSize_SizeX_IsValid && GetTextureSize_SizeY_IsValid && GetTextureSize_SizeZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetTextureSize", GetTextureSize_IsValid);
		GetRawTextureSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRawTextureSize");
		GetRawTextureSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRawTextureSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRawTextureSize_Component_PropertyAddress, GetRawTextureSize_FunctionAddress, "Component");
		GetRawTextureSize_Component_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTextureSize_FunctionAddress, "Component");
		GetRawTextureSize_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTextureSize_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTextureSize_SizeX_PropertyAddress, GetRawTextureSize_FunctionAddress, "SizeX");
		GetRawTextureSize_SizeX_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTextureSize_FunctionAddress, "SizeX");
		GetRawTextureSize_SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTextureSize_FunctionAddress, "SizeX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTextureSize_SizeY_PropertyAddress, GetRawTextureSize_FunctionAddress, "SizeY");
		GetRawTextureSize_SizeY_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTextureSize_FunctionAddress, "SizeY");
		GetRawTextureSize_SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTextureSize_FunctionAddress, "SizeY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTextureSize_SizeZ_PropertyAddress, GetRawTextureSize_FunctionAddress, "SizeZ");
		GetRawTextureSize_SizeZ_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTextureSize_FunctionAddress, "SizeZ");
		GetRawTextureSize_SizeZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTextureSize_FunctionAddress, "SizeZ", Classes.FIntProperty);
		GetRawTextureSize_IsValid = GetRawTextureSize_FunctionAddress != IntPtr.Zero && GetRawTextureSize_Component_IsValid && GetRawTextureSize_SizeX_IsValid && GetRawTextureSize_SizeY_IsValid && GetRawTextureSize_SizeZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection:GetRawTextureSize", GetRawTextureSize_IsValid);
	}
}
