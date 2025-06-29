using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D
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

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection:GetTextureSize")]
	public unsafe void GetTextureSize(UNiagaraComponent Component, out int SizeX, out int SizeY)
	{
		CheckDestroyed();
		if (!GetTextureSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection:GetTextureSize");
			SizeX = 0;
			SizeY = 0;
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
	}

	static UNiagaraDataInterfaceGrid2DCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceGrid2DCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceGrid2DCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection");
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
		GetTextureSize_IsValid = GetTextureSize_FunctionAddress != IntPtr.Zero && GetTextureSize_Component_IsValid && GetTextureSize_SizeX_IsValid && GetTextureSize_SizeY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection:GetTextureSize", GetTextureSize_IsValid);
	}
}
