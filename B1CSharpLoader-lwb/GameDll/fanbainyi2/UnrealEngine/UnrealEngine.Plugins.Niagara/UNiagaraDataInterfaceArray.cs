using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArray", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArray : UNiagaraDataInterfaceRWBase
{
	private static bool GpuSyncMode_IsValid;

	private static FFieldAddress GpuSyncMode_PropertyAddress;

	private static int GpuSyncMode_Offset;

	private static bool MaxElements_IsValid;

	private static int MaxElements_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArray:GpuSyncMode")]
	public ENiagaraGpuSyncMode GpuSyncMode
	{
		get
		{
			CheckDestroyed();
			if (!GpuSyncMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArray:GpuSyncMode");
				return ENiagaraGpuSyncMode.None;
			}
			return EnumMarshaler<ENiagaraGpuSyncMode>.FromNative(IntPtr.Add(base.Address, GpuSyncMode_Offset), 0, GpuSyncMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GpuSyncMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArray:GpuSyncMode");
			}
			else
			{
				EnumMarshaler<ENiagaraGpuSyncMode>.ToNative(IntPtr.Add(base.Address, GpuSyncMode_Offset), 0, GpuSyncMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArray:MaxElements")]
	public int MaxElements
	{
		get
		{
			CheckDestroyed();
			if (!MaxElements_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArray:MaxElements");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxElements_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxElements_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArray:MaxElements");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxElements_Offset), value);
			}
		}
	}

	static UNiagaraDataInterfaceArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArray));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArray");
		NativeReflectionCached.GetPropertyRef(ref GpuSyncMode_PropertyAddress, unrealStruct, "GpuSyncMode");
		GpuSyncMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GpuSyncMode");
		GpuSyncMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GpuSyncMode", Classes.FEnumProperty);
		MaxElements_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxElements");
		MaxElements_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxElements", Classes.FIntProperty);
	}
}
