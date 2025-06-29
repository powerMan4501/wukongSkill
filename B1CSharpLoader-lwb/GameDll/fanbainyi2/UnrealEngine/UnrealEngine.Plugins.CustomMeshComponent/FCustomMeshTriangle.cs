using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CustomMeshComponent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomMeshComponent.CustomMeshTriangle", "CustomMeshComponent", UnrealModuleType.EnginePlugin)]
public struct FCustomMeshTriangle
{
	private static bool Vertex0_IsValid;

	private static int Vertex0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshTriangle:Vertex0")]
	public FVector Vertex0;

	private static bool Vertex1_IsValid;

	private static int Vertex1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshTriangle:Vertex1")]
	public FVector Vertex1;

	private static bool Vertex2_IsValid;

	private static int Vertex2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshTriangle:Vertex2")]
	public FVector Vertex2;

	private static bool FCustomMeshTriangle_IsValid;

	private static int FCustomMeshTriangle_StructSize;

	public FCustomMeshTriangle Copy()
	{
		return this;
	}

	public static FCustomMeshTriangle FromNative(IntPtr nativeBuffer)
	{
		return new FCustomMeshTriangle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCustomMeshTriangle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCustomMeshTriangle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCustomMeshTriangle(nativeBuffer + arrayIndex * FCustomMeshTriangle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCustomMeshTriangle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCustomMeshTriangle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCustomMeshTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomMeshComponent.CustomMeshTriangle");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vertex0_Offset), Vertex0);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vertex1_Offset), Vertex1);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vertex2_Offset), Vertex2);
	}

	public FCustomMeshTriangle(IntPtr nativeStruct)
	{
		if (!FCustomMeshTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomMeshComponent.CustomMeshTriangle");
			Vertex0 = default(FVector);
			Vertex1 = default(FVector);
			Vertex2 = default(FVector);
		}
		else
		{
			Vertex0 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vertex0_Offset));
			Vertex1 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vertex1_Offset));
			Vertex2 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vertex2_Offset));
		}
	}

	static FCustomMeshTriangle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCustomMeshTriangle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCustomMeshTriangle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomMeshComponent.CustomMeshTriangle");
		FCustomMeshTriangle_StructSize = NativeReflection.GetStructSize(intPtr);
		Vertex0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vertex0");
		Vertex0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vertex0", Classes.FStructProperty);
		Vertex1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vertex1");
		Vertex1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vertex1", Classes.FStructProperty);
		Vertex2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vertex2");
		Vertex2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vertex2", Classes.FStructProperty);
		FCustomMeshTriangle_IsValid = intPtr != IntPtr.Zero && Vertex0_IsValid && Vertex1_IsValid && Vertex2_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomMeshComponent.CustomMeshTriangle", FCustomMeshTriangle_IsValid);
	}
}
