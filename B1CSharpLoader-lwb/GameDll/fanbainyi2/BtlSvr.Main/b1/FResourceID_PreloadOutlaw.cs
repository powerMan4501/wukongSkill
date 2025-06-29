using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaw")]
public struct FResourceID_PreloadOutlaw
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaw:Type")]
	public EIDType_Outlaw Type;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaw:ID")]
	public int ID;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaw:RefInfo")]
	public string RefInfo;

	private static int ResourceID_PreloadOutlaw_StructSize;

	private static int ResourceID_PreloadOutlaw_IsValid;

	private static bool Type_IsValid;

	private static int Type_Offset;

	private static FFieldAddress Type_PropertyAddress;

	private static bool ID_IsValid;

	private static int ID_Offset;

	private static bool RefInfo_IsValid;

	private static int RefInfo_Offset;

	public FResourceID_PreloadOutlaw(EIDType_Outlaw _Type, int _ID, string _RefInfo)
	{
		Type = _Type;
		ID = _ID;
		RefInfo = _RefInfo;
	}

	public FResourceID_PreloadOutlaw Copy()
	{
		return this;
	}

	public static FResourceID_PreloadOutlaw FromNative(IntPtr nativeBuffer)
	{
		return new FResourceID_PreloadOutlaw(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FResourceID_PreloadOutlaw value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FResourceID_PreloadOutlaw FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FResourceID_PreloadOutlaw(IntPtr.Add(nativeBuffer, arrayIndex * ResourceID_PreloadOutlaw_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FResourceID_PreloadOutlaw value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ResourceID_PreloadOutlaw_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ResourceID_PreloadOutlaw_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ResourceID_PreloadOutlaw");
			return;
		}
		EnumMarshaler<EIDType_Outlaw>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ID_Offset), ID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, RefInfo_Offset), RefInfo);
	}

	public FResourceID_PreloadOutlaw(IntPtr nativeStruct)
	{
		if (ResourceID_PreloadOutlaw_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ResourceID_PreloadOutlaw");
			Type = EIDType_Outlaw.Projectile;
			ID = 0;
			RefInfo = null;
		}
		else
		{
			Type = EnumMarshaler<EIDType_Outlaw>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			ID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ID_Offset));
			RefInfo = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, RefInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ResourceID_PreloadOutlaw");
		ResourceID_PreloadOutlaw_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflection.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		ID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ID");
		ID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ID", Classes.FIntProperty);
		RefInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "RefInfo");
		RefInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RefInfo", Classes.FStrProperty);
		ResourceID_PreloadOutlaw_IsValid = ((intPtr != IntPtr.Zero && Type_IsValid && ID_IsValid && RefInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ResourceID_PreloadOutlaw", (byte)ResourceID_PreloadOutlaw_IsValid != 0);
	}

	static FResourceID_PreloadOutlaw()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FResourceID_PreloadOutlaw)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FResourceID_PreloadOutlaw));
	}
}
