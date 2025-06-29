using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectKey", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkSubjectKey
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectKey:Source")]
	public Guid Source;

	private static bool SubjectName_IsValid;

	private static int SubjectName_Offset;

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSubjectKey:SubjectName")]
	public FLiveLinkSubjectName SubjectName;

	private static bool FLiveLinkSubjectKey_IsValid;

	private static int FLiveLinkSubjectKey_StructSize;

	public FLiveLinkSubjectKey Copy()
	{
		return this;
	}

	public static FLiveLinkSubjectKey FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkSubjectKey(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkSubjectKey value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkSubjectKey FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkSubjectKey(nativeBuffer + arrayIndex * FLiveLinkSubjectKey_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkSubjectKey value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkSubjectKey_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectKey");
			return;
		}
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, Source_Offset), Source);
		FLiveLinkSubjectName.ToNative(IntPtr.Add(nativeStruct, SubjectName_Offset), SubjectName);
	}

	public FLiveLinkSubjectKey(IntPtr nativeStruct)
	{
		if (!FLiveLinkSubjectKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSubjectKey");
			Source = default(Guid);
			SubjectName = default(FLiveLinkSubjectName);
		}
		else
		{
			Source = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, Source_Offset));
			SubjectName = FLiveLinkSubjectName.FromNative(IntPtr.Add(nativeStruct, SubjectName_Offset));
		}
	}

	static FLiveLinkSubjectKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkSubjectKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkSubjectKey));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkSubjectKey");
		FLiveLinkSubjectKey_StructSize = NativeReflection.GetStructSize(intPtr);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FStructProperty);
		SubjectName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubjectName");
		SubjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubjectName", Classes.FStructProperty);
		FLiveLinkSubjectKey_IsValid = intPtr != IntPtr.Zero && Source_IsValid && SubjectName_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkSubjectKey", FLiveLinkSubjectKey_IsValid);
	}
}
