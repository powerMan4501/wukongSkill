using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkSubjectRepresentation
{
	private static bool Subject_IsValid;

	private static int Subject_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation:Subject")]
	public FLiveLinkSubjectName Subject;

	private static bool Role_IsValid;

	private static int Role_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation:Role")]
	public TSubclassOf<ULiveLinkRole> Role;

	private static bool FLiveLinkSubjectRepresentation_IsValid;

	private static int FLiveLinkSubjectRepresentation_StructSize;

	public FLiveLinkSubjectRepresentation Copy()
	{
		return this;
	}

	public static FLiveLinkSubjectRepresentation FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkSubjectRepresentation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkSubjectRepresentation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkSubjectRepresentation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkSubjectRepresentation(nativeBuffer + arrayIndex * FLiveLinkSubjectRepresentation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkSubjectRepresentation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkSubjectRepresentation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectRepresentation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation");
			return;
		}
		FLiveLinkSubjectName.ToNative(IntPtr.Add(nativeStruct, Subject_Offset), Subject);
		TSubclassOfMarshaler<ULiveLinkRole>.ToNative(IntPtr.Add(nativeStruct, Role_Offset), Role);
	}

	public FLiveLinkSubjectRepresentation(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectRepresentation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation");
			Subject = default(FLiveLinkSubjectName);
			Role = default(TSubclassOf<ULiveLinkRole>);
		}
		else
		{
			Subject = FLiveLinkSubjectName.FromNative(IntPtr.Add(nativeStruct, Subject_Offset));
			Role = TSubclassOfMarshaler<ULiveLinkRole>.FromNative(IntPtr.Add(nativeStruct, Role_Offset));
		}
	}

	static FLiveLinkSubjectRepresentation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkSubjectRepresentation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkSubjectRepresentation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation");
		FLiveLinkSubjectRepresentation_StructSize = NativeReflection.GetStructSize(intPtr);
		Subject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Subject");
		Subject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Subject", Classes.FStructProperty);
		Role_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Role");
		Role_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Role", Classes.FClassProperty);
		FLiveLinkSubjectRepresentation_IsValid = intPtr != IntPtr.Zero && Subject_IsValid && Role_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation", FLiveLinkSubjectRepresentation_IsValid);
	}
}
