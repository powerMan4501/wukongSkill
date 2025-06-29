using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ProceduralMeshComponent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex", "ProceduralMeshComponent", UnrealModuleType.EnginePlugin)]
public struct FProcMeshVertex
{
	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:Position")]
	public FVector Position;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:Normal")]
	public FVector Normal;

	private static bool Tangent_IsValid;

	private static int Tangent_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:Tangent")]
	public FProcMeshTangent Tangent;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:Color")]
	public FColor Color;

	private static bool UV0_IsValid;

	private static int UV0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:UV0")]
	public FVector2D UV0;

	private static bool UV1_IsValid;

	private static int UV1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:UV1")]
	public FVector2D UV1;

	private static bool UV2_IsValid;

	private static int UV2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:UV2")]
	public FVector2D UV2;

	private static bool UV3_IsValid;

	private static int UV3_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshVertex:UV3")]
	public FVector2D UV3;

	private static bool FProcMeshVertex_IsValid;

	private static int FProcMeshVertex_StructSize;

	public FProcMeshVertex Copy()
	{
		return this;
	}

	public static FProcMeshVertex FromNative(IntPtr nativeBuffer)
	{
		return new FProcMeshVertex(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProcMeshVertex value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProcMeshVertex FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProcMeshVertex(nativeBuffer + arrayIndex * FProcMeshVertex_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProcMeshVertex value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProcMeshVertex_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProcMeshVertex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ProceduralMeshComponent.ProcMeshVertex");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		FProcMeshTangent.ToNative(IntPtr.Add(nativeStruct, Tangent_Offset), Tangent);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV0_Offset), UV0);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV1_Offset), UV1);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV2_Offset), UV2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV3_Offset), UV3);
	}

	public FProcMeshVertex(IntPtr nativeStruct)
	{
		if (!FProcMeshVertex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ProceduralMeshComponent.ProcMeshVertex");
			Position = default(FVector);
			Normal = default(FVector);
			Tangent = default(FProcMeshTangent);
			Color = default(FColor);
			UV0 = default(FVector2D);
			UV1 = default(FVector2D);
			UV2 = default(FVector2D);
			UV3 = default(FVector2D);
		}
		else
		{
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			Tangent = FProcMeshTangent.FromNative(IntPtr.Add(nativeStruct, Tangent_Offset));
			Color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			UV0 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV0_Offset));
			UV1 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV1_Offset));
			UV2 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV2_Offset));
			UV3 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV3_Offset));
		}
	}

	static FProcMeshVertex()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProcMeshVertex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProcMeshVertex));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ProceduralMeshComponent.ProcMeshVertex");
		FProcMeshVertex_StructSize = NativeReflection.GetStructSize(intPtr);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		Tangent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tangent");
		Tangent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tangent", Classes.FStructProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		UV0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV0");
		UV0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV0", Classes.FStructProperty);
		UV1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV1");
		UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV1", Classes.FStructProperty);
		UV2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV2");
		UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV2", Classes.FStructProperty);
		UV3_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV3");
		UV3_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV3", Classes.FStructProperty);
		FProcMeshVertex_IsValid = intPtr != IntPtr.Zero && Position_IsValid && Normal_IsValid && Tangent_IsValid && Color_IsValid && UV0_IsValid && UV1_IsValid && UV2_IsValid && UV3_IsValid;
		NativeReflection.LogStructIsValid("/Script/ProceduralMeshComponent.ProcMeshVertex", FProcMeshVertex_IsValid);
	}
}
