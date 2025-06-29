using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraID", "Niagara", UnrealModuleType.EnginePlugin)]
public struct FNiagaraID
{
	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraID:Index")]
	public int Index;

	private static bool AcquireTag_IsValid;

	private static int AcquireTag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraID:AcquireTag")]
	public int AcquireTag;

	private static bool FNiagaraID_IsValid;

	private static int FNiagaraID_StructSize;

	public FNiagaraID Copy()
	{
		return this;
	}

	public static FNiagaraID FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraID(nativeBuffer + arrayIndex * FNiagaraID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AcquireTag_Offset), AcquireTag);
	}

	public FNiagaraID(IntPtr nativeStruct)
	{
		if (!FNiagaraID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraID");
			Index = 0;
			AcquireTag = 0;
		}
		else
		{
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
			AcquireTag = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AcquireTag_Offset));
		}
	}

	static FNiagaraID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Niagara.NiagaraID");
		FNiagaraID_StructSize = NativeReflection.GetStructSize(intPtr);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		AcquireTag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AcquireTag");
		AcquireTag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AcquireTag", Classes.FIntProperty);
		FNiagaraID_IsValid = intPtr != IntPtr.Zero && Index_IsValid && AcquireTag_IsValid;
		NativeReflection.LogStructIsValid("/Script/Niagara.NiagaraID", FNiagaraID_IsValid);
	}
}
