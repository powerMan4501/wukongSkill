using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel", "FuncLibEditor", UnrealModuleType.Game)]
public struct FScatterStartPointsOfEachStreamingLevel
{
	private static bool StreamingLevelPackageName_IsValid;

	private static int StreamingLevelPackageName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel:StreamingLevelPackageName")]
	public string StreamingLevelPackageName;

	private static bool StartPointArray_IsValid;

	private static FFieldAddress StartPointArray_PropertyAddress;

	private static int StartPointArray_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel:StartPointArray")]
	public List<FVector> StartPointArray;

	private static bool FScatterStartPointsOfEachStreamingLevel_IsValid;

	private static int FScatterStartPointsOfEachStreamingLevel_StructSize;

	public FScatterStartPointsOfEachStreamingLevel Copy()
	{
		FScatterStartPointsOfEachStreamingLevel result = this;
		if (StartPointArray != null)
		{
			result.StartPointArray = new List<FVector>(StartPointArray);
		}
		return result;
	}

	public static FScatterStartPointsOfEachStreamingLevel FromNative(IntPtr nativeBuffer)
	{
		return new FScatterStartPointsOfEachStreamingLevel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScatterStartPointsOfEachStreamingLevel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScatterStartPointsOfEachStreamingLevel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScatterStartPointsOfEachStreamingLevel(nativeBuffer + arrayIndex * FScatterStartPointsOfEachStreamingLevel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScatterStartPointsOfEachStreamingLevel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScatterStartPointsOfEachStreamingLevel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScatterStartPointsOfEachStreamingLevel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StreamingLevelPackageName_Offset), StreamingLevelPackageName);
		new TArrayCopyMarshaler<FVector>(1, StartPointArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StartPointArray_Offset), StartPointArray);
	}

	public FScatterStartPointsOfEachStreamingLevel(IntPtr nativeStruct)
	{
		if (!FScatterStartPointsOfEachStreamingLevel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel");
			StreamingLevelPackageName = FStringMarshaler.DefaultString;
			StartPointArray = null;
		}
		else
		{
			StreamingLevelPackageName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StreamingLevelPackageName_Offset));
			StartPointArray = new TArrayCopyMarshaler<FVector>(1, StartPointArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StartPointArray_Offset));
		}
	}

	static FScatterStartPointsOfEachStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScatterStartPointsOfEachStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScatterStartPointsOfEachStreamingLevel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel");
		FScatterStartPointsOfEachStreamingLevel_StructSize = NativeReflection.GetStructSize(intPtr);
		StreamingLevelPackageName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelPackageName");
		StreamingLevelPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelPackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartPointArray_PropertyAddress, intPtr, "StartPointArray");
		StartPointArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartPointArray");
		StartPointArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartPointArray", Classes.FArrayProperty);
		FScatterStartPointsOfEachStreamingLevel_IsValid = intPtr != IntPtr.Zero && StreamingLevelPackageName_IsValid && StartPointArray_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.ScatterStartPointsOfEachStreamingLevel", FScatterStartPointsOfEachStreamingLevel_IsValid);
	}
}
