using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSimpleMeshBuffers
{
	private static bool Vertices_IsValid;

	private static FFieldAddress Vertices_PropertyAddress;

	private static int Vertices_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:Vertices")]
	public List<FVector> Vertices;

	private static bool Normals_IsValid;

	private static FFieldAddress Normals_PropertyAddress;

	private static int Normals_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:Normals")]
	public List<FVector> Normals;

	private static bool UV0_IsValid;

	private static FFieldAddress UV0_PropertyAddress;

	private static int UV0_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV0")]
	public List<FVector2D> UV0;

	private static bool UV1_IsValid;

	private static FFieldAddress UV1_PropertyAddress;

	private static int UV1_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV1")]
	public List<FVector2D> UV1;

	private static bool UV2_IsValid;

	private static FFieldAddress UV2_PropertyAddress;

	private static int UV2_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV2")]
	public List<FVector2D> UV2;

	private static bool UV3_IsValid;

	private static FFieldAddress UV3_PropertyAddress;

	private static int UV3_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV3")]
	public List<FVector2D> UV3;

	private static bool UV4_IsValid;

	private static FFieldAddress UV4_PropertyAddress;

	private static int UV4_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV4")]
	public List<FVector2D> UV4;

	private static bool UV5_IsValid;

	private static FFieldAddress UV5_PropertyAddress;

	private static int UV5_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV5")]
	public List<FVector2D> UV5;

	private static bool UV6_IsValid;

	private static FFieldAddress UV6_PropertyAddress;

	private static int UV6_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV6")]
	public List<FVector2D> UV6;

	private static bool UV7_IsValid;

	private static FFieldAddress UV7_PropertyAddress;

	private static int UV7_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:UV7")]
	public List<FVector2D> UV7;

	private static bool VertexColors_IsValid;

	private static FFieldAddress VertexColors_PropertyAddress;

	private static int VertexColors_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:VertexColors")]
	public List<FLinearColor> VertexColors;

	private static bool Triangles_IsValid;

	private static FFieldAddress Triangles_PropertyAddress;

	private static int Triangles_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:Triangles")]
	public List<FIntVector> Triangles;

	private static bool TriGroupIDs_IsValid;

	private static FFieldAddress TriGroupIDs_PropertyAddress;

	private static int TriGroupIDs_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers:TriGroupIDs")]
	public List<int> TriGroupIDs;

	private static bool FGeometryScriptSimpleMeshBuffers_IsValid;

	private static int FGeometryScriptSimpleMeshBuffers_StructSize;

	public FGeometryScriptSimpleMeshBuffers Copy()
	{
		FGeometryScriptSimpleMeshBuffers result = this;
		if (Vertices != null)
		{
			result.Vertices = new List<FVector>(Vertices);
		}
		if (Normals != null)
		{
			result.Normals = new List<FVector>(Normals);
		}
		if (UV0 != null)
		{
			result.UV0 = new List<FVector2D>(UV0);
		}
		if (UV1 != null)
		{
			result.UV1 = new List<FVector2D>(UV1);
		}
		if (UV2 != null)
		{
			result.UV2 = new List<FVector2D>(UV2);
		}
		if (UV3 != null)
		{
			result.UV3 = new List<FVector2D>(UV3);
		}
		if (UV4 != null)
		{
			result.UV4 = new List<FVector2D>(UV4);
		}
		if (UV5 != null)
		{
			result.UV5 = new List<FVector2D>(UV5);
		}
		if (UV6 != null)
		{
			result.UV6 = new List<FVector2D>(UV6);
		}
		if (UV7 != null)
		{
			result.UV7 = new List<FVector2D>(UV7);
		}
		if (VertexColors != null)
		{
			result.VertexColors = new List<FLinearColor>(VertexColors);
		}
		if (Triangles != null)
		{
			result.Triangles = new List<FIntVector>(Triangles);
		}
		if (TriGroupIDs != null)
		{
			result.TriGroupIDs = new List<int>(TriGroupIDs);
		}
		return result;
	}

	public static FGeometryScriptSimpleMeshBuffers FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSimpleMeshBuffers(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSimpleMeshBuffers value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSimpleMeshBuffers FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSimpleMeshBuffers(nativeBuffer + arrayIndex * FGeometryScriptSimpleMeshBuffers_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSimpleMeshBuffers value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSimpleMeshBuffers_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSimpleMeshBuffers_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers");
			return;
		}
		new TArrayCopyMarshaler<FVector>(1, Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Vertices_Offset), Vertices);
		new TArrayCopyMarshaler<FVector>(1, Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Normals_Offset), Normals);
		new TArrayCopyMarshaler<FVector2D>(1, UV0_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV0_Offset), UV0);
		new TArrayCopyMarshaler<FVector2D>(1, UV1_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV1_Offset), UV1);
		new TArrayCopyMarshaler<FVector2D>(1, UV2_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV2_Offset), UV2);
		new TArrayCopyMarshaler<FVector2D>(1, UV3_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV3_Offset), UV3);
		new TArrayCopyMarshaler<FVector2D>(1, UV4_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV4_Offset), UV4);
		new TArrayCopyMarshaler<FVector2D>(1, UV5_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV5_Offset), UV5);
		new TArrayCopyMarshaler<FVector2D>(1, UV6_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV6_Offset), UV6);
		new TArrayCopyMarshaler<FVector2D>(1, UV7_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UV7_Offset), UV7);
		new TArrayCopyMarshaler<FLinearColor>(1, VertexColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, VertexColors_Offset), VertexColors);
		new TArrayCopyMarshaler<FIntVector>(1, Triangles_PropertyAddress, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.FromNative, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Triangles_Offset), Triangles);
		new TArrayCopyMarshaler<int>(1, TriGroupIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriGroupIDs_Offset), TriGroupIDs);
	}

	public FGeometryScriptSimpleMeshBuffers(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSimpleMeshBuffers_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers");
			Vertices = null;
			Normals = null;
			UV0 = null;
			UV1 = null;
			UV2 = null;
			UV3 = null;
			UV4 = null;
			UV5 = null;
			UV6 = null;
			UV7 = null;
			VertexColors = null;
			Triangles = null;
			TriGroupIDs = null;
		}
		else
		{
			Vertices = new TArrayCopyMarshaler<FVector>(1, Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Vertices_Offset));
			Normals = new TArrayCopyMarshaler<FVector>(1, Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Normals_Offset));
			UV0 = new TArrayCopyMarshaler<FVector2D>(1, UV0_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV0_Offset));
			UV1 = new TArrayCopyMarshaler<FVector2D>(1, UV1_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV1_Offset));
			UV2 = new TArrayCopyMarshaler<FVector2D>(1, UV2_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV2_Offset));
			UV3 = new TArrayCopyMarshaler<FVector2D>(1, UV3_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV3_Offset));
			UV4 = new TArrayCopyMarshaler<FVector2D>(1, UV4_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV4_Offset));
			UV5 = new TArrayCopyMarshaler<FVector2D>(1, UV5_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV5_Offset));
			UV6 = new TArrayCopyMarshaler<FVector2D>(1, UV6_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV6_Offset));
			UV7 = new TArrayCopyMarshaler<FVector2D>(1, UV7_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UV7_Offset));
			VertexColors = new TArrayCopyMarshaler<FLinearColor>(1, VertexColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, VertexColors_Offset));
			Triangles = new TArrayCopyMarshaler<FIntVector>(1, Triangles_PropertyAddress, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.FromNative, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Triangles_Offset));
			TriGroupIDs = new TArrayCopyMarshaler<int>(1, TriGroupIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriGroupIDs_Offset));
		}
	}

	static FGeometryScriptSimpleMeshBuffers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSimpleMeshBuffers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSimpleMeshBuffers));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers");
		FGeometryScriptSimpleMeshBuffers_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Vertices_PropertyAddress, intPtr, "Vertices");
		Vertices_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vertices");
		Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Normals_PropertyAddress, intPtr, "Normals");
		Normals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normals");
		Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV0_PropertyAddress, intPtr, "UV0");
		UV0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV0");
		UV0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV0", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV1_PropertyAddress, intPtr, "UV1");
		UV1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV1");
		UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV1", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV2_PropertyAddress, intPtr, "UV2");
		UV2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV2");
		UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV2", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV3_PropertyAddress, intPtr, "UV3");
		UV3_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV3");
		UV3_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV3", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV4_PropertyAddress, intPtr, "UV4");
		UV4_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV4");
		UV4_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV4", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV5_PropertyAddress, intPtr, "UV5");
		UV5_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV5");
		UV5_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV5", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV6_PropertyAddress, intPtr, "UV6");
		UV6_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV6");
		UV6_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV6", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UV7_PropertyAddress, intPtr, "UV7");
		UV7_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV7");
		UV7_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV7", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColors_PropertyAddress, intPtr, "VertexColors");
		VertexColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertexColors");
		VertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertexColors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Triangles_PropertyAddress, intPtr, "Triangles");
		Triangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Triangles");
		Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TriGroupIDs_PropertyAddress, intPtr, "TriGroupIDs");
		TriGroupIDs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TriGroupIDs");
		TriGroupIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TriGroupIDs", Classes.FArrayProperty);
		FGeometryScriptSimpleMeshBuffers_IsValid = intPtr != IntPtr.Zero && Vertices_IsValid && Normals_IsValid && UV0_IsValid && UV1_IsValid && UV2_IsValid && UV3_IsValid && UV4_IsValid && UV5_IsValid && UV6_IsValid && UV7_IsValid && VertexColors_IsValid && Triangles_IsValid && TriGroupIDs_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSimpleMeshBuffers", FGeometryScriptSimpleMeshBuffers_IsValid);
	}
}
