using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ComponentSpacePose", "Engine", UnrealModuleType.Engine)]
public struct FComponentSpacePose
{
	private static bool Transforms_IsValid;

	private static FFieldAddress Transforms_PropertyAddress;

	private static int Transforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.ComponentSpacePose:Transforms")]
	public List<FTransform> Transforms;

	private static bool Names_IsValid;

	private static FFieldAddress Names_PropertyAddress;

	private static int Names_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.ComponentSpacePose:Names")]
	public List<FName> Names;

	private static bool FComponentSpacePose_IsValid;

	private static int FComponentSpacePose_StructSize;

	public FComponentSpacePose Copy()
	{
		FComponentSpacePose result = this;
		if (Transforms != null)
		{
			result.Transforms = new List<FTransform>(Transforms);
		}
		if (Names != null)
		{
			result.Names = new List<FName>(Names);
		}
		return result;
	}

	public static FComponentSpacePose FromNative(IntPtr nativeBuffer)
	{
		return new FComponentSpacePose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComponentSpacePose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComponentSpacePose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComponentSpacePose(nativeBuffer + arrayIndex * FComponentSpacePose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComponentSpacePose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComponentSpacePose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComponentSpacePose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSpacePose");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Transforms_Offset), Transforms);
		new TArrayCopyMarshaler<FName>(1, Names_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Names_Offset), Names);
	}

	public FComponentSpacePose(IntPtr nativeStruct)
	{
		if (!FComponentSpacePose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSpacePose");
			Transforms = null;
			Names = null;
		}
		else
		{
			Transforms = new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Transforms_Offset));
			Names = new TArrayCopyMarshaler<FName>(1, Names_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Names_Offset));
		}
	}

	static FComponentSpacePose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComponentSpacePose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComponentSpacePose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ComponentSpacePose");
		FComponentSpacePose_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Transforms_PropertyAddress, intPtr, "Transforms");
		Transforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transforms");
		Transforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transforms", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Names_PropertyAddress, intPtr, "Names");
		Names_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Names");
		Names_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Names", Classes.FArrayProperty);
		FComponentSpacePose_IsValid = intPtr != IntPtr.Zero && Transforms_IsValid && Names_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ComponentSpacePose", FComponentSpacePose_IsValid);
	}
}
