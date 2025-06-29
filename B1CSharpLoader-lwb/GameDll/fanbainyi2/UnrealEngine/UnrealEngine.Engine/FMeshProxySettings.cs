using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshProxySettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshProxySettings
{
	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:ScreenSize")]
	public int ScreenSize;

	private static bool VoxelSize_IsValid;

	private static int VoxelSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:VoxelSize")]
	public float VoxelSize;

	private static bool MaterialSettings_IsValid;

	private static int MaterialSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:MaterialSettings")]
	public FMaterialProxySettings MaterialSettings;

	private static bool MergeDistance_IsValid;

	private static int MergeDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:MergeDistance")]
	public float MergeDistance;

	private static bool UnresolvedGeometryColor_IsValid;

	private static int UnresolvedGeometryColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:UnresolvedGeometryColor")]
	public FColor UnresolvedGeometryColor;

	private static bool MaxRayCastDist_IsValid;

	private static int MaxRayCastDist_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:MaxRayCastDist")]
	public float MaxRayCastDist;

	private static bool HardAngleThreshold_IsValid;

	private static int HardAngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:HardAngleThreshold")]
	public float HardAngleThreshold;

	private static bool LightMapResolution_IsValid;

	private static int LightMapResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:LightMapResolution")]
	public int LightMapResolution;

	private static bool NormalCalculationMethod_IsValid;

	private static FFieldAddress NormalCalculationMethod_PropertyAddress;

	private static int NormalCalculationMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:NormalCalculationMethod")]
	public EProxyNormalComputationMethod NormalCalculationMethod;

	private static bool LandscapeCullingPrecision_IsValid;

	private static FFieldAddress LandscapeCullingPrecision_PropertyAddress;

	private static int LandscapeCullingPrecision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:LandscapeCullingPrecision")]
	public ELandscapeCullingPrecision LandscapeCullingPrecision;

	private static bool CalculateCorrectLODModel_IsValid;

	private static FFieldAddress CalculateCorrectLODModel_PropertyAddress;

	private static int CalculateCorrectLODModel_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bCalculateCorrectLODModel")]
	public bool CalculateCorrectLODModel;

	private static bool OverrideVoxelSize_IsValid;

	private static FFieldAddress OverrideVoxelSize_PropertyAddress;

	private static int OverrideVoxelSize_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bOverrideVoxelSize")]
	public bool OverrideVoxelSize;

	private static bool OverrideTransferDistance_IsValid;

	private static FFieldAddress OverrideTransferDistance_PropertyAddress;

	private static int OverrideTransferDistance_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bOverrideTransferDistance")]
	public bool OverrideTransferDistance;

	private static bool UseHardAngleThreshold_IsValid;

	private static FFieldAddress UseHardAngleThreshold_PropertyAddress;

	private static int UseHardAngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bUseHardAngleThreshold")]
	public bool UseHardAngleThreshold;

	private static bool ComputeLightMapResolution_IsValid;

	private static FFieldAddress ComputeLightMapResolution_PropertyAddress;

	private static int ComputeLightMapResolution_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bComputeLightMapResolution")]
	public bool ComputeLightMapResolution;

	private static bool RecalculateNormals_IsValid;

	private static FFieldAddress RecalculateNormals_PropertyAddress;

	private static int RecalculateNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bRecalculateNormals")]
	public bool RecalculateNormals;

	private static bool UseLandscapeCulling_IsValid;

	private static FFieldAddress UseLandscapeCulling_PropertyAddress;

	private static int UseLandscapeCulling_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bUseLandscapeCulling")]
	public bool UseLandscapeCulling;

	private static bool AllowDistanceField_IsValid;

	private static FFieldAddress AllowDistanceField_PropertyAddress;

	private static int AllowDistanceField_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bAllowDistanceField")]
	public bool AllowDistanceField;

	private static bool ReuseMeshLightmapUVs_IsValid;

	private static FFieldAddress ReuseMeshLightmapUVs_PropertyAddress;

	private static int ReuseMeshLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bReuseMeshLightmapUVs")]
	public bool ReuseMeshLightmapUVs;

	private static bool GroupIdenticalMeshesForBaking_IsValid;

	private static FFieldAddress GroupIdenticalMeshesForBaking_PropertyAddress;

	private static int GroupIdenticalMeshesForBaking_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bGroupIdenticalMeshesForBaking")]
	public bool GroupIdenticalMeshesForBaking;

	private static bool CreateCollision_IsValid;

	private static FFieldAddress CreateCollision_PropertyAddress;

	private static int CreateCollision_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bCreateCollision")]
	public bool CreateCollision;

	private static bool AllowVertexColors_IsValid;

	private static FFieldAddress AllowVertexColors_PropertyAddress;

	private static int AllowVertexColors_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bAllowVertexColors")]
	public bool AllowVertexColors;

	private static bool GenerateLightmapUVs_IsValid;

	private static FFieldAddress GenerateLightmapUVs_PropertyAddress;

	private static int GenerateLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bGenerateLightmapUVs")]
	public bool GenerateLightmapUVs;

	private static bool GenerateNaniteEnabledMesh_IsValid;

	private static FFieldAddress GenerateNaniteEnabledMesh_PropertyAddress;

	private static int GenerateNaniteEnabledMesh_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:bGenerateNaniteEnabledMesh")]
	public bool GenerateNaniteEnabledMesh;

	private static bool NaniteProxyTrianglePercent_IsValid;

	private static int NaniteProxyTrianglePercent_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshProxySettings:NaniteProxyTrianglePercent")]
	public float NaniteProxyTrianglePercent;

	private static bool FMeshProxySettings_IsValid;

	private static int FMeshProxySettings_StructSize;

	public FMeshProxySettings Copy()
	{
		return this;
	}

	public static FMeshProxySettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshProxySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshProxySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshProxySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshProxySettings(nativeBuffer + arrayIndex * FMeshProxySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshProxySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshProxySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshProxySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshProxySettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ScreenSize_Offset), ScreenSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VoxelSize_Offset), VoxelSize);
		FMaterialProxySettings.ToNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset), MaterialSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MergeDistance_Offset), MergeDistance);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, UnresolvedGeometryColor_Offset), UnresolvedGeometryColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxRayCastDist_Offset), MaxRayCastDist);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HardAngleThreshold_Offset), HardAngleThreshold);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LightMapResolution_Offset), LightMapResolution);
		EnumMarshaler<EProxyNormalComputationMethod>.ToNative(IntPtr.Add(nativeStruct, NormalCalculationMethod_Offset), 0, NormalCalculationMethod_PropertyAddress.Address, NormalCalculationMethod);
		EnumMarshaler<ELandscapeCullingPrecision>.ToNative(IntPtr.Add(nativeStruct, LandscapeCullingPrecision_Offset), 0, LandscapeCullingPrecision_PropertyAddress.Address, LandscapeCullingPrecision);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CalculateCorrectLODModel_Offset), 0, CalculateCorrectLODModel_PropertyAddress.Address, CalculateCorrectLODModel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideVoxelSize_Offset), 0, OverrideVoxelSize_PropertyAddress.Address, OverrideVoxelSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideTransferDistance_Offset), 0, OverrideTransferDistance_PropertyAddress.Address, OverrideTransferDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHardAngleThreshold_Offset), 0, UseHardAngleThreshold_PropertyAddress.Address, UseHardAngleThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputeLightMapResolution_Offset), 0, ComputeLightMapResolution_PropertyAddress.Address, ComputeLightMapResolution);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecalculateNormals_Offset), 0, RecalculateNormals_PropertyAddress.Address, RecalculateNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseLandscapeCulling_Offset), 0, UseLandscapeCulling_PropertyAddress.Address, UseLandscapeCulling);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowDistanceField_Offset), 0, AllowDistanceField_PropertyAddress.Address, AllowDistanceField);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReuseMeshLightmapUVs_Offset), 0, ReuseMeshLightmapUVs_PropertyAddress.Address, ReuseMeshLightmapUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GroupIdenticalMeshesForBaking_Offset), 0, GroupIdenticalMeshesForBaking_PropertyAddress.Address, GroupIdenticalMeshesForBaking);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CreateCollision_Offset), 0, CreateCollision_PropertyAddress.Address, CreateCollision);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowVertexColors_Offset), 0, AllowVertexColors_PropertyAddress.Address, AllowVertexColors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address, GenerateLightmapUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address, GenerateNaniteEnabledMesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset), NaniteProxyTrianglePercent);
	}

	public FMeshProxySettings(IntPtr nativeStruct)
	{
		if (!FMeshProxySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshProxySettings");
			ScreenSize = 0;
			VoxelSize = 0f;
			MaterialSettings = default(FMaterialProxySettings);
			MergeDistance = 0f;
			UnresolvedGeometryColor = default(FColor);
			MaxRayCastDist = 0f;
			HardAngleThreshold = 0f;
			LightMapResolution = 0;
			NormalCalculationMethod = EProxyNormalComputationMethod.AngleWeighted;
			LandscapeCullingPrecision = ELandscapeCullingPrecision.High;
			CalculateCorrectLODModel = false;
			OverrideVoxelSize = false;
			OverrideTransferDistance = false;
			UseHardAngleThreshold = false;
			ComputeLightMapResolution = false;
			RecalculateNormals = false;
			UseLandscapeCulling = false;
			AllowDistanceField = false;
			ReuseMeshLightmapUVs = false;
			GroupIdenticalMeshesForBaking = false;
			CreateCollision = false;
			AllowVertexColors = false;
			GenerateLightmapUVs = false;
			GenerateNaniteEnabledMesh = false;
			NaniteProxyTrianglePercent = 0f;
		}
		else
		{
			ScreenSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ScreenSize_Offset));
			VoxelSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VoxelSize_Offset));
			MaterialSettings = FMaterialProxySettings.FromNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset));
			MergeDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MergeDistance_Offset));
			UnresolvedGeometryColor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, UnresolvedGeometryColor_Offset));
			MaxRayCastDist = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxRayCastDist_Offset));
			HardAngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HardAngleThreshold_Offset));
			LightMapResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LightMapResolution_Offset));
			NormalCalculationMethod = EnumMarshaler<EProxyNormalComputationMethod>.FromNative(IntPtr.Add(nativeStruct, NormalCalculationMethod_Offset), 0, NormalCalculationMethod_PropertyAddress.Address);
			LandscapeCullingPrecision = EnumMarshaler<ELandscapeCullingPrecision>.FromNative(IntPtr.Add(nativeStruct, LandscapeCullingPrecision_Offset), 0, LandscapeCullingPrecision_PropertyAddress.Address);
			CalculateCorrectLODModel = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CalculateCorrectLODModel_Offset), 0, CalculateCorrectLODModel_PropertyAddress.Address);
			OverrideVoxelSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideVoxelSize_Offset), 0, OverrideVoxelSize_PropertyAddress.Address);
			OverrideTransferDistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideTransferDistance_Offset), 0, OverrideTransferDistance_PropertyAddress.Address);
			UseHardAngleThreshold = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHardAngleThreshold_Offset), 0, UseHardAngleThreshold_PropertyAddress.Address);
			ComputeLightMapResolution = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputeLightMapResolution_Offset), 0, ComputeLightMapResolution_PropertyAddress.Address);
			RecalculateNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecalculateNormals_Offset), 0, RecalculateNormals_PropertyAddress.Address);
			UseLandscapeCulling = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseLandscapeCulling_Offset), 0, UseLandscapeCulling_PropertyAddress.Address);
			AllowDistanceField = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowDistanceField_Offset), 0, AllowDistanceField_PropertyAddress.Address);
			ReuseMeshLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReuseMeshLightmapUVs_Offset), 0, ReuseMeshLightmapUVs_PropertyAddress.Address);
			GroupIdenticalMeshesForBaking = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GroupIdenticalMeshesForBaking_Offset), 0, GroupIdenticalMeshesForBaking_PropertyAddress.Address);
			CreateCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CreateCollision_Offset), 0, CreateCollision_PropertyAddress.Address);
			AllowVertexColors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowVertexColors_Offset), 0, AllowVertexColors_PropertyAddress.Address);
			GenerateLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address);
			GenerateNaniteEnabledMesh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address);
			NaniteProxyTrianglePercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset));
		}
	}

	static FMeshProxySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshProxySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshProxySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshProxySettings");
		FMeshProxySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FIntProperty);
		VoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoxelSize");
		VoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoxelSize", Classes.FFloatProperty);
		MaterialSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialSettings");
		MaterialSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialSettings", Classes.FStructProperty);
		MergeDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MergeDistance");
		MergeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MergeDistance", Classes.FFloatProperty);
		UnresolvedGeometryColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnresolvedGeometryColor");
		UnresolvedGeometryColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnresolvedGeometryColor", Classes.FStructProperty);
		MaxRayCastDist_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRayCastDist");
		MaxRayCastDist_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRayCastDist", Classes.FFloatProperty);
		HardAngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HardAngleThreshold");
		HardAngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HardAngleThreshold", Classes.FFloatProperty);
		LightMapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightMapResolution");
		LightMapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightMapResolution", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalCalculationMethod_PropertyAddress, intPtr, "NormalCalculationMethod");
		NormalCalculationMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalCalculationMethod");
		NormalCalculationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalCalculationMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeCullingPrecision_PropertyAddress, intPtr, "LandscapeCullingPrecision");
		LandscapeCullingPrecision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeCullingPrecision");
		LandscapeCullingPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeCullingPrecision", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateCorrectLODModel_PropertyAddress, intPtr, "bCalculateCorrectLODModel");
		CalculateCorrectLODModel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCalculateCorrectLODModel");
		CalculateCorrectLODModel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCalculateCorrectLODModel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideVoxelSize_PropertyAddress, intPtr, "bOverrideVoxelSize");
		OverrideVoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideVoxelSize");
		OverrideVoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideVoxelSize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideTransferDistance_PropertyAddress, intPtr, "bOverrideTransferDistance");
		OverrideTransferDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideTransferDistance");
		OverrideTransferDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideTransferDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHardAngleThreshold_PropertyAddress, intPtr, "bUseHardAngleThreshold");
		UseHardAngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHardAngleThreshold");
		UseHardAngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHardAngleThreshold", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeLightMapResolution_PropertyAddress, intPtr, "bComputeLightMapResolution");
		ComputeLightMapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeLightMapResolution");
		ComputeLightMapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeLightMapResolution", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecalculateNormals_PropertyAddress, intPtr, "bRecalculateNormals");
		RecalculateNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecalculateNormals");
		RecalculateNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecalculateNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLandscapeCulling_PropertyAddress, intPtr, "bUseLandscapeCulling");
		UseLandscapeCulling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseLandscapeCulling");
		UseLandscapeCulling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseLandscapeCulling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowDistanceField_PropertyAddress, intPtr, "bAllowDistanceField");
		AllowDistanceField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowDistanceField");
		AllowDistanceField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowDistanceField", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReuseMeshLightmapUVs_PropertyAddress, intPtr, "bReuseMeshLightmapUVs");
		ReuseMeshLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReuseMeshLightmapUVs");
		ReuseMeshLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReuseMeshLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupIdenticalMeshesForBaking_PropertyAddress, intPtr, "bGroupIdenticalMeshesForBaking");
		GroupIdenticalMeshesForBaking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGroupIdenticalMeshesForBaking");
		GroupIdenticalMeshesForBaking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGroupIdenticalMeshesForBaking", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCollision_PropertyAddress, intPtr, "bCreateCollision");
		CreateCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCreateCollision");
		CreateCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCreateCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowVertexColors_PropertyAddress, intPtr, "bAllowVertexColors");
		AllowVertexColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowVertexColors");
		AllowVertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowVertexColors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightmapUVs_PropertyAddress, intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaniteEnabledMesh_PropertyAddress, intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateNaniteEnabledMesh", Classes.FBoolProperty);
		NaniteProxyTrianglePercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NaniteProxyTrianglePercent");
		NaniteProxyTrianglePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NaniteProxyTrianglePercent", Classes.FFloatProperty);
		FMeshProxySettings_IsValid = intPtr != IntPtr.Zero && ScreenSize_IsValid && VoxelSize_IsValid && MaterialSettings_IsValid && MergeDistance_IsValid && UnresolvedGeometryColor_IsValid && MaxRayCastDist_IsValid && HardAngleThreshold_IsValid && LightMapResolution_IsValid && NormalCalculationMethod_IsValid && LandscapeCullingPrecision_IsValid && CalculateCorrectLODModel_IsValid && OverrideVoxelSize_IsValid && OverrideTransferDistance_IsValid && UseHardAngleThreshold_IsValid && ComputeLightMapResolution_IsValid && RecalculateNormals_IsValid && UseLandscapeCulling_IsValid && AllowDistanceField_IsValid && ReuseMeshLightmapUVs_IsValid && GroupIdenticalMeshesForBaking_IsValid && CreateCollision_IsValid && AllowVertexColors_IsValid && GenerateLightmapUVs_IsValid && GenerateNaniteEnabledMesh_IsValid && NaniteProxyTrianglePercent_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshProxySettings", FMeshProxySettings_IsValid);
	}
}
