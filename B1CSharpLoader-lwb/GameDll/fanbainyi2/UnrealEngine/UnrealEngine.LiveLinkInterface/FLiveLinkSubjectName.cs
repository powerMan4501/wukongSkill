using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectName", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkSubjectName
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectName:Name")]
	public FName Name;

	private static bool FLiveLinkSubjectName_IsValid;

	private static int FLiveLinkSubjectName_StructSize;

	public FLiveLinkSubjectName Copy()
	{
		return this;
	}

	public static FLiveLinkSubjectName FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkSubjectName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkSubjectName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkSubjectName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkSubjectName(nativeBuffer + arrayIndex * FLiveLinkSubjectName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkSubjectName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkSubjectName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectName");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FLiveLinkSubjectName(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectName");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FLiveLinkSubjectName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkSubjectName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkSubjectName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkSubjectName");
		FLiveLinkSubjectName_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FLiveLinkSubjectName_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkSubjectName", FLiveLinkSubjectName_IsValid);
	}
}
