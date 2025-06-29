using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeParameterMappingGroup", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopeParameterMappingGroup
{
	private static bool GroupGuid_IsValid;

	private static int GroupGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingGroup:GroupGuid")]
	public Guid GroupGuid;

	private static bool Mappings_IsValid;

	private static FFieldAddress Mappings_PropertyAddress;

	private static int Mappings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingGroup:Mappings")]
	public List<FCalliopeParameterMapping> Mappings;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingGroup:Comment")]
	public string Comment;

	private static bool FCalliopeParameterMappingGroup_IsValid;

	private static int FCalliopeParameterMappingGroup_StructSize;

	public FCalliopeParameterMappingGroup Copy()
	{
		FCalliopeParameterMappingGroup result = this;
		if (Mappings != null)
		{
			result.Mappings = new List<FCalliopeParameterMapping>(Mappings);
		}
		return result;
	}

	public static FCalliopeParameterMappingGroup FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopeParameterMappingGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopeParameterMappingGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopeParameterMappingGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopeParameterMappingGroup(nativeBuffer + arrayIndex * FCalliopeParameterMappingGroup_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopeParameterMappingGroup value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopeParameterMappingGroup_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopeParameterMappingGroup_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameterMappingGroup");
			return;
		}
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, GroupGuid_Offset), GroupGuid);
		new TArrayCopyMarshaler<FCalliopeParameterMapping>(1, Mappings_PropertyAddress, CachedMarshalingDelegates<FCalliopeParameterMapping, FCalliopeParameterMapping>.FromNative, CachedMarshalingDelegates<FCalliopeParameterMapping, FCalliopeParameterMapping>.ToNative).ToNative(IntPtr.Add(nativeStruct, Mappings_Offset), Mappings);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FCalliopeParameterMappingGroup(IntPtr nativeStruct)
	{
		if (!FCalliopeParameterMappingGroup_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameterMappingGroup");
			GroupGuid = default(Guid);
			Mappings = null;
			Comment = FStringMarshaler.DefaultString;
		}
		else
		{
			GroupGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, GroupGuid_Offset));
			Mappings = new TArrayCopyMarshaler<FCalliopeParameterMapping>(1, Mappings_PropertyAddress, CachedMarshalingDelegates<FCalliopeParameterMapping, FCalliopeParameterMapping>.FromNative, CachedMarshalingDelegates<FCalliopeParameterMapping, FCalliopeParameterMapping>.ToNative).FromNative(IntPtr.Add(nativeStruct, Mappings_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	static FCalliopeParameterMappingGroup()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopeParameterMappingGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopeParameterMappingGroup));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopeParameterMappingGroup");
		FCalliopeParameterMappingGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		GroupGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupGuid");
		GroupGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mappings_PropertyAddress, intPtr, "Mappings");
		Mappings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mappings");
		Mappings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mappings", Classes.FArrayProperty);
		Comment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		FCalliopeParameterMappingGroup_IsValid = intPtr != IntPtr.Zero && GroupGuid_IsValid && Mappings_IsValid && Comment_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopeParameterMappingGroup", FCalliopeParameterMappingGroup_IsValid);
	}
}
