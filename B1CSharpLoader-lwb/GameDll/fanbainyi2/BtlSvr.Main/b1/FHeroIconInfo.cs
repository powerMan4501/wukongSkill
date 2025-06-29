using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.HeroIconInfo")]
public struct FHeroIconInfo
{
	[DisplayName("角色ID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HeroIconInfo:ResID")]
	public int ResID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("头像图片")]
	[USharpPath("/Script/b1-Managed.HeroIconInfo:IconTexture")]
	public UTexture2D IconTexture;

	private static int HeroIconInfo_StructSize;

	private static int HeroIconInfo_IsValid;

	private static bool ResID_IsValid;

	private static int ResID_Offset;

	private static bool IconTexture_IsValid;

	private static int IconTexture_Offset;

	public FHeroIconInfo Copy()
	{
		return this;
	}

	public static FHeroIconInfo FromNative(IntPtr nativeBuffer)
	{
		return new FHeroIconInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHeroIconInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHeroIconInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHeroIconInfo(IntPtr.Add(nativeBuffer, arrayIndex * HeroIconInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHeroIconInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HeroIconInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HeroIconInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HeroIconInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResID_Offset), ResID);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, IconTexture_Offset), IconTexture);
	}

	public FHeroIconInfo(IntPtr nativeStruct)
	{
		if (HeroIconInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HeroIconInfo");
			ResID = 0;
			IconTexture = null;
		}
		else
		{
			ResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResID_Offset));
			IconTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, IconTexture_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HeroIconInfo");
		HeroIconInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
		IconTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "IconTexture");
		IconTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IconTexture", Classes.FObjectProperty);
		HeroIconInfo_IsValid = ((intPtr != IntPtr.Zero && ResID_IsValid && IconTexture_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HeroIconInfo", (byte)HeroIconInfo_IsValid != 0);
	}

	static FHeroIconInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHeroIconInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHeroIconInfo));
	}
}
