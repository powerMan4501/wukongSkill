using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptTrianglePoint
{
	private static bool Valid_IsValid;

	private static FFieldAddress Valid_PropertyAddress;

	private static int Valid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint:bValid")]
	public bool Valid;

	private static bool TriangleID_IsValid;

	private static int TriangleID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint:TriangleID")]
	public int TriangleID;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint:Position")]
	public FVector Position;

	private static bool BaryCoords_IsValid;

	private static int BaryCoords_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint:BaryCoords")]
	public FVector BaryCoords;

	private static bool FGeometryScriptTrianglePoint_IsValid;

	private static int FGeometryScriptTrianglePoint_StructSize;

	public FGeometryScriptTrianglePoint Copy()
	{
		return this;
	}

	public static FGeometryScriptTrianglePoint FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptTrianglePoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptTrianglePoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptTrianglePoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptTrianglePoint(nativeBuffer + arrayIndex * FGeometryScriptTrianglePoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptTrianglePoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptTrianglePoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTrianglePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Valid_Offset), 0, Valid_PropertyAddress.Address, Valid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriangleID_Offset), TriangleID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BaryCoords_Offset), BaryCoords);
	}

	public FGeometryScriptTrianglePoint(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTrianglePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint");
			Valid = false;
			TriangleID = 0;
			Position = default(FVector);
			BaryCoords = default(FVector);
		}
		else
		{
			Valid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Valid_Offset), 0, Valid_PropertyAddress.Address);
			TriangleID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriangleID_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			BaryCoords = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BaryCoords_Offset));
		}
	}

	static FGeometryScriptTrianglePoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptTrianglePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptTrianglePoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint");
		FGeometryScriptTrianglePoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Valid_PropertyAddress, intPtr, "bValid");
		Valid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bValid");
		Valid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bValid", Classes.FBoolProperty);
		TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TriangleID");
		TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TriangleID", Classes.FIntProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		BaryCoords_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaryCoords");
		BaryCoords_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaryCoords", Classes.FStructProperty);
		FGeometryScriptTrianglePoint_IsValid = intPtr != IntPtr.Zero && Valid_IsValid && TriangleID_IsValid && Position_IsValid && BaryCoords_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptTrianglePoint", FGeometryScriptTrianglePoint_IsValid);
	}
}
