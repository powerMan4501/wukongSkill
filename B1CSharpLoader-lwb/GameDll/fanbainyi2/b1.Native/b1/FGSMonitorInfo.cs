using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSMonitorInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSMonitorInfo
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.GSMonitorInfo:Name")]
	public string Name;

	private static bool ID_IsValid;

	private static int ID_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.GSMonitorInfo:ID")]
	public string ID;

	private static bool IsPrimary_IsValid;

	private static FFieldAddress IsPrimary_PropertyAddress;

	private static int IsPrimary_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSMonitorInfo:bIsPrimary")]
	public bool IsPrimary;

	private static bool NativeResolution_IsValid;

	private static int NativeResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSMonitorInfo:NativeResolution")]
	public FIntPoint NativeResolution;

	private static bool DisplayResolution_IsValid;

	private static int DisplayResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSMonitorInfo:DisplayResolution")]
	public FIntPoint DisplayResolution;

	private static bool FGSMonitorInfo_IsValid;

	private static int FGSMonitorInfo_StructSize;

	public FGSMonitorInfo Copy()
	{
		return this;
	}

	public static FGSMonitorInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSMonitorInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMonitorInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMonitorInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMonitorInfo(nativeBuffer + arrayIndex * FGSMonitorInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMonitorInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSMonitorInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSMonitorInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSMonitorInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ID_Offset), ID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPrimary_Offset), 0, IsPrimary_PropertyAddress.Address, IsPrimary);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, NativeResolution_Offset), NativeResolution);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, DisplayResolution_Offset), DisplayResolution);
	}

	public FGSMonitorInfo(IntPtr nativeStruct)
	{
		if (!FGSMonitorInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSMonitorInfo");
			Name = FStringMarshaler.DefaultString;
			ID = FStringMarshaler.DefaultString;
			IsPrimary = false;
			NativeResolution = default(FIntPoint);
			DisplayResolution = default(FIntPoint);
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			ID = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ID_Offset));
			IsPrimary = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPrimary_Offset), 0, IsPrimary_PropertyAddress.Address);
			NativeResolution = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, NativeResolution_Offset));
			DisplayResolution = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, DisplayResolution_Offset));
		}
	}

	static FGSMonitorInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSMonitorInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMonitorInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSMonitorInfo");
		FGSMonitorInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		ID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ID");
		ID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPrimary_PropertyAddress, intPtr, "bIsPrimary");
		IsPrimary_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPrimary");
		IsPrimary_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPrimary", Classes.FBoolProperty);
		NativeResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NativeResolution");
		NativeResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NativeResolution", Classes.FStructProperty);
		DisplayResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayResolution");
		DisplayResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayResolution", Classes.FStructProperty);
		FGSMonitorInfo_IsValid = intPtr != IntPtr.Zero && Name_IsValid && ID_IsValid && IsPrimary_IsValid && NativeResolution_IsValid && DisplayResolution_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSMonitorInfo", FGSMonitorInfo_IsValid);
	}
}
