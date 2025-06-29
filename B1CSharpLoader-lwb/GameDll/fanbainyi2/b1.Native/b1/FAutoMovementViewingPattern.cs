using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern", "UnrealExtent", UnrealModuleType.Game)]
public struct FAutoMovementViewingPattern
{
	private static bool PathPointsFilePath_IsValid;

	private static int PathPointsFilePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:PathPointsFilePath")]
	public string PathPointsFilePath;

	private static bool UseSparseVersion_IsValid;

	private static FFieldAddress UseSparseVersion_PropertyAddress;

	private static int UseSparseVersion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:bUseSparseVersion")]
	public bool UseSparseVersion;

	private static bool VisualizeScatteredPoints_IsValid;

	private static FFieldAddress VisualizeScatteredPoints_PropertyAddress;

	private static int VisualizeScatteredPoints_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:bVisualizeScatteredPoints")]
	public bool VisualizeScatteredPoints;

	private static bool PointInstanceScale_IsValid;

	private static int PointInstanceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:PointInstanceScale")]
	public float PointInstanceScale;

	private static bool InitialRotation_IsValid;

	private static int InitialRotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:InitialRotation")]
	public FRotator InitialRotation;

	private static bool DirectionCount_IsValid;

	private static int DirectionCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:DirectionCount")]
	public FIntVector DirectionCount;

	private static bool TotalPitchDegree_IsValid;

	private static int TotalPitchDegree_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:TotalPitchDegree")]
	public float TotalPitchDegree;

	private static bool TotalYawDegree_IsValid;

	private static int TotalYawDegree_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:TotalYawDegree")]
	public float TotalYawDegree;

	private static bool DistanceCheckBias_IsValid;

	private static int DistanceCheckBias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:DistanceCheckBias")]
	public float DistanceCheckBias;

	private static bool RotationCheckBias_IsValid;

	private static int RotationCheckBias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:RotationCheckBias")]
	public float RotationCheckBias;

	private static bool PoseTickTotalCount_IsValid;

	private static int PoseTickTotalCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:PoseTickTotalCount")]
	public int PoseTickTotalCount;

	private static bool UseVirtualPlayer_IsValid;

	private static FFieldAddress UseVirtualPlayer_PropertyAddress;

	private static int UseVirtualPlayer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:bUseVirtualPlayer")]
	public bool UseVirtualPlayer;

	private static bool AttractEnemy_IsValid;

	private static FFieldAddress AttractEnemy_PropertyAddress;

	private static int AttractEnemy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementViewingPattern:bAttractEnemy")]
	public bool AttractEnemy;

	private static bool FAutoMovementViewingPattern_IsValid;

	private static int FAutoMovementViewingPattern_StructSize;

	public FAutoMovementViewingPattern Copy()
	{
		return this;
	}

	public static FAutoMovementViewingPattern FromNative(IntPtr nativeBuffer)
	{
		return new FAutoMovementViewingPattern(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutoMovementViewingPattern value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutoMovementViewingPattern FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutoMovementViewingPattern(nativeBuffer + arrayIndex * FAutoMovementViewingPattern_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutoMovementViewingPattern value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAutoMovementViewingPattern_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAutoMovementViewingPattern_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AutoMovementViewingPattern");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, PathPointsFilePath_Offset), PathPointsFilePath);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSparseVersion_Offset), 0, UseSparseVersion_PropertyAddress.Address, UseSparseVersion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeScatteredPoints_Offset), 0, VisualizeScatteredPoints_PropertyAddress.Address, VisualizeScatteredPoints);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PointInstanceScale_Offset), PointInstanceScale);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, InitialRotation_Offset), InitialRotation);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(nativeStruct, DirectionCount_Offset), DirectionCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalPitchDegree_Offset), TotalPitchDegree);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalYawDegree_Offset), TotalYawDegree);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceCheckBias_Offset), DistanceCheckBias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationCheckBias_Offset), RotationCheckBias);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PoseTickTotalCount_Offset), PoseTickTotalCount);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseVirtualPlayer_Offset), 0, UseVirtualPlayer_PropertyAddress.Address, UseVirtualPlayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttractEnemy_Offset), 0, AttractEnemy_PropertyAddress.Address, AttractEnemy);
	}

	public FAutoMovementViewingPattern(IntPtr nativeStruct)
	{
		if (!FAutoMovementViewingPattern_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AutoMovementViewingPattern");
			PathPointsFilePath = FStringMarshaler.DefaultString;
			UseSparseVersion = false;
			VisualizeScatteredPoints = false;
			PointInstanceScale = 0f;
			InitialRotation = default(FRotator);
			DirectionCount = default(FIntVector);
			TotalPitchDegree = 0f;
			TotalYawDegree = 0f;
			DistanceCheckBias = 0f;
			RotationCheckBias = 0f;
			PoseTickTotalCount = 0;
			UseVirtualPlayer = false;
			AttractEnemy = false;
		}
		else
		{
			PathPointsFilePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, PathPointsFilePath_Offset));
			UseSparseVersion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSparseVersion_Offset), 0, UseSparseVersion_PropertyAddress.Address);
			VisualizeScatteredPoints = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeScatteredPoints_Offset), 0, VisualizeScatteredPoints_PropertyAddress.Address);
			PointInstanceScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PointInstanceScale_Offset));
			InitialRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, InitialRotation_Offset));
			DirectionCount = BlittableTypeMarshaler<FIntVector>.FromNative(IntPtr.Add(nativeStruct, DirectionCount_Offset));
			TotalPitchDegree = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalPitchDegree_Offset));
			TotalYawDegree = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalYawDegree_Offset));
			DistanceCheckBias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceCheckBias_Offset));
			RotationCheckBias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationCheckBias_Offset));
			PoseTickTotalCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PoseTickTotalCount_Offset));
			UseVirtualPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseVirtualPlayer_Offset), 0, UseVirtualPlayer_PropertyAddress.Address);
			AttractEnemy = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttractEnemy_Offset), 0, AttractEnemy_PropertyAddress.Address);
		}
	}

	static FAutoMovementViewingPattern()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAutoMovementViewingPattern)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutoMovementViewingPattern));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AutoMovementViewingPattern");
		FAutoMovementViewingPattern_StructSize = NativeReflection.GetStructSize(intPtr);
		PathPointsFilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathPointsFilePath");
		PathPointsFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathPointsFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSparseVersion_PropertyAddress, intPtr, "bUseSparseVersion");
		UseSparseVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSparseVersion");
		UseSparseVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSparseVersion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeScatteredPoints_PropertyAddress, intPtr, "bVisualizeScatteredPoints");
		VisualizeScatteredPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisualizeScatteredPoints");
		VisualizeScatteredPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisualizeScatteredPoints", Classes.FBoolProperty);
		PointInstanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointInstanceScale");
		PointInstanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointInstanceScale", Classes.FFloatProperty);
		InitialRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialRotation");
		InitialRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialRotation", Classes.FStructProperty);
		DirectionCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionCount");
		DirectionCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionCount", Classes.FStructProperty);
		TotalPitchDegree_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalPitchDegree");
		TotalPitchDegree_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalPitchDegree", Classes.FFloatProperty);
		TotalYawDegree_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalYawDegree");
		TotalYawDegree_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalYawDegree", Classes.FFloatProperty);
		DistanceCheckBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceCheckBias");
		DistanceCheckBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceCheckBias", Classes.FFloatProperty);
		RotationCheckBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationCheckBias");
		RotationCheckBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationCheckBias", Classes.FFloatProperty);
		PoseTickTotalCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseTickTotalCount");
		PoseTickTotalCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseTickTotalCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UseVirtualPlayer_PropertyAddress, intPtr, "bUseVirtualPlayer");
		UseVirtualPlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseVirtualPlayer");
		UseVirtualPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseVirtualPlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AttractEnemy_PropertyAddress, intPtr, "bAttractEnemy");
		AttractEnemy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttractEnemy");
		AttractEnemy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttractEnemy", Classes.FBoolProperty);
		FAutoMovementViewingPattern_IsValid = intPtr != IntPtr.Zero && PathPointsFilePath_IsValid && UseSparseVersion_IsValid && VisualizeScatteredPoints_IsValid && PointInstanceScale_IsValid && InitialRotation_IsValid && DirectionCount_IsValid && TotalPitchDegree_IsValid && TotalYawDegree_IsValid && DistanceCheckBias_IsValid && RotationCheckBias_IsValid && PoseTickTotalCount_IsValid && UseVirtualPlayer_IsValid && AttractEnemy_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AutoMovementViewingPattern", FAutoMovementViewingPattern_IsValid);
	}
}
