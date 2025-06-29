using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ComponentSync", "Engine", UnrealModuleType.Engine)]
public struct FComponentSync
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ComponentSync:Name")]
	public FName Name;

	private static bool SyncOption_IsValid;

	private static FFieldAddress SyncOption_PropertyAddress;

	private static int SyncOption_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ComponentSync:SyncOption")]
	public ESyncOption SyncOption;

	private static bool FComponentSync_IsValid;

	private static int FComponentSync_StructSize;

	public FComponentSync Copy()
	{
		return this;
	}

	public static FComponentSync FromNative(IntPtr nativeBuffer)
	{
		return new FComponentSync(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComponentSync value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComponentSync FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComponentSync(nativeBuffer + arrayIndex * FComponentSync_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComponentSync value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComponentSync_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComponentSync_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSync");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<ESyncOption>.ToNative(IntPtr.Add(nativeStruct, SyncOption_Offset), 0, SyncOption_PropertyAddress.Address, SyncOption);
	}

	public FComponentSync(IntPtr nativeStruct)
	{
		if (!FComponentSync_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSync");
			Name = default(FName);
			SyncOption = ESyncOption.Drive;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			SyncOption = EnumMarshaler<ESyncOption>.FromNative(IntPtr.Add(nativeStruct, SyncOption_Offset), 0, SyncOption_PropertyAddress.Address);
		}
	}

	static FComponentSync()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComponentSync)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComponentSync));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ComponentSync");
		FComponentSync_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncOption_PropertyAddress, intPtr, "SyncOption");
		SyncOption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SyncOption");
		SyncOption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SyncOption", Classes.FEnumProperty);
		FComponentSync_IsValid = intPtr != IntPtr.Zero && Name_IsValid && SyncOption_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ComponentSync", FComponentSync_IsValid);
	}
}
