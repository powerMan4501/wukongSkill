using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini")]
public class DispLib_EditorExportLevelToHoudini : ABGUPlacedEditorUtilityBase
{
	public struct InstanceModeStaticMeshInfoConverBaseTypeStruct
	{
		public struct InstanceModeSMInfoOneInfo
		{
			public float[] Transform;

			public string ActorLabel;

			public string ActorName;

			public InstanceModeSMInfoOneInfo(FTransform _Tran, string _ActorLabel, string _ActorName)
			{
				Transform = new float[13];
				Transform[0] = _Tran.GetLocation().X;
				Transform[1] = _Tran.GetLocation().Y;
				Transform[2] = _Tran.GetLocation().Z;
				Transform[3] = _Tran.GetRotation().X;
				Transform[4] = _Tran.GetRotation().Y;
				Transform[5] = _Tran.GetRotation().Z;
				Transform[6] = _Tran.GetRotation().W;
				Transform[7] = _Tran.GetScale3D().X;
				Transform[8] = _Tran.GetScale3D().Y;
				Transform[9] = _Tran.GetScale3D().Z;
				Transform[10] = _Tran.GetRotation().Rotator().Roll;
				Transform[11] = _Tran.GetRotation().Rotator().Pitch;
				Transform[12] = _Tran.GetRotation().Rotator().Yaw;
				ActorLabel = _ActorLabel;
				ActorName = _ActorName;
			}
		}

		public string UEPrj_AssetPath;

		public string System_AssetPath;

		public List<L2HInstanceModeStaticMeshInfo.MatInfo> MatInfoList;

		public float[] BBox;

		public List<InstanceModeSMInfoOneInfo> InfoList;

		public InstanceModeStaticMeshInfoConverBaseTypeStruct(L2HInstanceModeStaticMeshInfo Info)
		{
			UEPrj_AssetPath = "";
			System_AssetPath = "";
			InfoList = null;
			MatInfoList = null;
			BBox = new float[6];
			if (Info == null)
			{
				return;
			}
			UEPrj_AssetPath = Info.UEPrj_AssetPath;
			System_AssetPath = Info.System_AssetPath;
			MatInfoList = Info.MatInfoList;
			Info.BBox.GetCenterAndExtents(out var center, out var extents);
			BBox[0] = center.X;
			BBox[1] = center.Y;
			BBox[2] = center.Z;
			BBox[3] = extents.X;
			BBox[4] = extents.Y;
			BBox[5] = extents.Z;
			InfoList = new List<InstanceModeSMInfoOneInfo>();
			foreach (L2HInstanceModeStaticMeshInfo.InstanceModeStaticMeshInfo info in Info.InfoList)
			{
				InfoList.Add(new InstanceModeSMInfoOneInfo(info.Transform, info.ActorLabel, info.ActorName));
			}
		}
	}

	public class L2HInstanceModeStaticMeshInfo
	{
		public struct InstanceModeStaticMeshInfo
		{
			public FTransform Transform;

			public string ActorLabel;

			public string ActorName;

			public string CompName;

			public int OwnerActorSMCompCount;

			public InstanceModeStaticMeshInfo(FTransform _Transform, string _ActorLabel, string _ActorName, string _CompName, int _OwnerActorSMCompCount)
			{
				Transform = _Transform;
				ActorLabel = _ActorLabel;
				ActorName = _ActorName;
				CompName = _CompName;
				OwnerActorSMCompCount = _OwnerActorSMCompCount;
			}
		}

		public struct MatInfo
		{
			public string AlbedoMap_DiskAssetPath;

			public string NormalMap_DiskAssetPath;

			public MatInfo(string _AlbedoMap_DiskAssetPath, string _NormalMap_DiskAssetPath)
			{
				AlbedoMap_DiskAssetPath = _AlbedoMap_DiskAssetPath;
				NormalMap_DiskAssetPath = _NormalMap_DiskAssetPath;
			}
		}

		public string UEPrj_AssetPath;

		public string System_AssetPath;

		public List<MatInfo> MatInfoList = new List<MatInfo>();

		public FBox BBox;

		public bool isNanite;

		public List<InstanceModeStaticMeshInfo> InfoList = new List<InstanceModeStaticMeshInfo>();

		public L2HInstanceModeStaticMeshInfo(UStaticMesh MeshAsset, string _System_AssetPath, List<MatInfo> _MatInfoList)
		{
			if (!MeshAsset.IsNullOrDestroyed())
			{
				UEPrj_AssetPath = MeshAsset.GetPathName();
				System_AssetPath = _System_AssetPath;
				MatInfoList = _MatInfoList;
				isNanite = MeshAsset.IsNative;
				BBox = MeshAsset.GetBoundingBox();
			}
		}

		public void AddOneData(UStaticMeshComponent Comp)
		{
			if (!Comp.IsNullOrDestroyed())
			{
				AActor owner = Comp.GetOwner();
				int count = owner.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>()).Count;
				InfoList.Add(new InstanceModeStaticMeshInfo(Comp.GetWorldTransform(), owner.GetActorLabel(), owner.GetName(), Comp.GetName(), count));
			}
		}

		public InstanceModeStaticMeshInfoConverBaseTypeStruct ConverToBaseTypeStruct()
		{
			return new InstanceModeStaticMeshInfoConverBaseTypeStruct(this);
		}
	}

	public struct ActorModeActorInfoConverBaseTypeStruct
	{
		public string ActorLabel;

		public string ActorName;

		public float[] Transform;

		public float[] BBox;

		public ActorModeActorInfoConverBaseTypeStruct(L2HActorModeActorInfo Info)
		{
			ActorLabel = "";
			ActorName = "";
			BBox = new float[6];
			Transform = new float[13];
			if (Info != null)
			{
				ActorLabel = Info.ActorLabel;
				ActorName = Info.ActorName;
				FTransform transform = Info.Transform;
				Transform[0] = transform.GetLocation().X;
				Transform[1] = transform.GetLocation().Y;
				Transform[2] = transform.GetLocation().Z;
				Transform[3] = transform.GetRotation().X;
				Transform[4] = transform.GetRotation().Y;
				Transform[5] = transform.GetRotation().Z;
				Transform[6] = transform.GetRotation().W;
				Transform[7] = transform.GetScale3D().X;
				Transform[8] = transform.GetScale3D().Y;
				Transform[9] = transform.GetScale3D().Z;
				Transform[10] = transform.GetRotation().Rotator().Roll;
				Transform[11] = transform.GetRotation().Rotator().Pitch;
				Transform[12] = transform.GetRotation().Rotator().Yaw;
				BBox[0] = Info.BoundOrigin.X;
				BBox[1] = Info.BoundOrigin.Y;
				BBox[2] = Info.BoundOrigin.Z;
				BBox[3] = Info.BoundBoxExtent.X;
				BBox[4] = Info.BoundBoxExtent.Y;
				BBox[5] = Info.BoundBoxExtent.Z;
			}
		}
	}

	public class L2HActorModeActorInfo
	{
		public string ActorLabel;

		public string ActorName;

		public FTransform Transform;

		public FVector BoundOrigin;

		public FVector BoundBoxExtent;

		public L2HActorModeActorInfo(AActor Actor)
		{
			ActorLabel = Actor.GetActorLabel();
			ActorName = Actor.GetName();
			Transform = Actor.GetActorTransform();
			Actor.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var _);
		}

		public ActorModeActorInfoConverBaseTypeStruct ConverToBaseTypeStruct()
		{
			return new ActorModeActorInfoConverBaseTypeStruct(this);
		}
	}

	public struct L2HSplineInfoConverBaseTypeStruct
	{
		public List<float[]> Transforms;

		public L2HSplineInfoConverBaseTypeStruct(L2HSplineInfo Info)
		{
			Transforms = null;
			if (Info == null)
			{
				return;
			}
			Transforms = new List<float[]>();
			foreach (FVector pointsPo in Info.PointsPos)
			{
				float[] item = new float[13]
				{
					pointsPo.X, pointsPo.Y, pointsPo.Z, 0f, 0f, 0f, 1f, 1f, 1f, 1f,
					0f, 0f, 0f
				};
				Transforms.Add(item);
			}
		}
	}

	public class L2HSplineInfo
	{
		public List<FVector> PointsPos = new List<FVector>();

		public L2HSplineInfo(List<FVector> _PointsPos)
		{
			PointsPos = _PointsPos;
		}

		public L2HSplineInfoConverBaseTypeStruct ConverToBaseTypeStruct()
		{
			return new L2HSplineInfoConverBaseTypeStruct(this);
		}
	}

	public static string fileName;

	public static string SplineFileName;

	private static bool FilterByTag_IsValid;

	private static int FilterByTag_Offset;

	private static bool UseExcludedObjects_IsValid;

	private static int UseExcludedObjects_Offset;

	private static FFieldAddress UseExcludedObjects_PropertyAddress;

	private static bool ExcludedObjects_IsValid;

	private static int ExcludedObjects_Offset;

	private static FFieldAddress ExcludedObjects_PropertyAddress;

	private TArrayReadWriteMarshaler<UStaticMesh> ExcludedObjects_Marshaler;

	private static bool LevelJsonFileExportPath_IsValid;

	private static int LevelJsonFileExportPath_Offset;

	private static bool LevelJsonFileName_IsValid;

	private static int LevelJsonFileName_Offset;

	private static bool FileNameAutoIndexSuffix_IsValid;

	private static int FileNameAutoIndexSuffix_Offset;

	private static FFieldAddress FileNameAutoIndexSuffix_PropertyAddress;

	private static bool UnrealAssetsExportPath_IsValid;

	private static int UnrealAssetsExportPath_Offset;

	private static bool NaniteFallbackMeshExportPath_IsValid;

	private static int NaniteFallbackMeshExportPath_Offset;

	private static bool MeshExportMode_IsValid;

	private static int MeshExportMode_Offset;

	private static FFieldAddress MeshExportMode_PropertyAddress;

	private static bool TextureExportMode_IsValid;

	private static int TextureExportMode_Offset;

	private static FFieldAddress TextureExportMode_PropertyAddress;

	private static bool AutoDisableNanite_IsValid;

	private static int AutoDisableNanite_Offset;

	private static FFieldAddress AutoDisableNanite_PropertyAddress;

	private static bool NotMeragedActorsJsonFilePath_IsValid;

	private static int NotMeragedActorsJsonFilePath_Offset;

	private static bool LimitBoxJsonFilePath_IsValid;

	private static int LimitBoxJsonFilePath_Offset;

	private static bool PerUnitCellSize_IsValid;

	private static int PerUnitCellSize_Offset;

	private static bool LimitBoxCenterPosArray_IsValid;

	private static int LimitBoxCenterPosArray_Offset;

	private static FFieldAddress LimitBoxCenterPosArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LimitBoxCenterPosArray_Marshaler;

	private static bool LimitBoxStartEndIndexInfo_IsValid;

	private static int LimitBoxStartEndIndexInfo_Offset;

	private static FFieldAddress LimitBoxStartEndIndexInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LimitBoxStartEndIndexInfo_Marshaler;

	private static bool MergedChunkIndex_IsValid;

	private static int MergedChunkIndex_Offset;

	private static bool HeightLimit_IsValid;

	private static int HeightLimit_Offset;

	private static bool ExportMeshAssets_IsValid;

	private static IntPtr ExportMeshAssets_FunctionAddress;

	private static int ExportMeshAssets_ParamsSize;

	private static bool ImportLimitBoxInfo_IsValid;

	private static IntPtr ImportLimitBoxInfo_FunctionAddress;

	private static int ImportLimitBoxInfo_ParamsSize;

	private static bool ExportLevelToHoudini_IsValid;

	private static IntPtr ExportLevelToHoudini_FunctionAddress;

	private static int ExportLevelToHoudini_ParamsSize;

	private static bool SelectActorsInLimitBox_IsValid;

	private static IntPtr SelectActorsInLimitBox_FunctionAddress;

	private static int SelectActorsInLimitBox_ParamsSize;

	private static bool SelectActorsByHeightLimit_IsValid;

	private static IntPtr SelectActorsByHeightLimit_FunctionAddress;

	private static int SelectActorsByHeightLimit_ParamsSize;

	private static bool ExportLevelDescriptionJson_IsValid;

	private static IntPtr ExportLevelDescriptionJson_FunctionAddress;

	private static int ExportLevelDescriptionJson_ParamsSize;

	private static bool ExportSplineDescriptionJson_IsValid;

	private static IntPtr ExportSplineDescriptionJson_FunctionAddress;

	private static int ExportSplineDescriptionJson_ParamsSize;

	private static bool ExportActorBoundsDescriptionJson_IsValid;

	private static IntPtr ExportActorBoundsDescriptionJson_FunctionAddress;

	private static int ExportActorBoundsDescriptionJson_ParamsSize;

	private static bool SelectActorsByNotMeragedActorsJson_IsValid;

	private static IntPtr SelectActorsByNotMeragedActorsJson_FunctionAddress;

	private static int SelectActorsByNotMeragedActorsJson_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Select Filter")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FilterByTag")]
	public FName FilterByTag
	{
		get
		{
			CheckDestroyed();
			if (!FilterByTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FilterByTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FilterByTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilterByTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FilterByTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FilterByTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Select Filter")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UseExcludedObjects")]
	public bool UseExcludedObjects
	{
		get
		{
			CheckDestroyed();
			if (!UseExcludedObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UseExcludedObjects");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseExcludedObjects_Offset), 0, UseExcludedObjects_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseExcludedObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UseExcludedObjects");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseExcludedObjects_Offset), 0, UseExcludedObjects_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Export|Select Filter")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExcludedObjects")]
	public TArrayReadWrite<UStaticMesh> ExcludedObjects
	{
		get
		{
			CheckDestroyed();
			if (!ExcludedObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExcludedObjects");
				return null;
			}
			if (ExcludedObjects_Marshaler == null)
			{
				ExcludedObjects_Marshaler = new TArrayReadWriteMarshaler<UStaticMesh>(1, ExcludedObjects_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative);
			}
			return ExcludedObjects_Marshaler.FromNative(IntPtr.Add(base.Address, ExcludedObjects_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileExportPath")]
	public FName LevelJsonFileExportPath
	{
		get
		{
			CheckDestroyed();
			if (!LevelJsonFileExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileExportPath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LevelJsonFileExportPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelJsonFileExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileExportPath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LevelJsonFileExportPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileName")]
	public FName LevelJsonFileName
	{
		get
		{
			CheckDestroyed();
			if (!LevelJsonFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LevelJsonFileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelJsonFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LevelJsonFileName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LevelJsonFileName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FileNameAutoIndexSuffix")]
	public bool FileNameAutoIndexSuffix
	{
		get
		{
			CheckDestroyed();
			if (!FileNameAutoIndexSuffix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FileNameAutoIndexSuffix");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FileNameAutoIndexSuffix_Offset), 0, FileNameAutoIndexSuffix_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FileNameAutoIndexSuffix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:FileNameAutoIndexSuffix");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FileNameAutoIndexSuffix_Offset), 0, FileNameAutoIndexSuffix_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UnrealAssetsExportPath")]
	public FName UnrealAssetsExportPath
	{
		get
		{
			CheckDestroyed();
			if (!UnrealAssetsExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UnrealAssetsExportPath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UnrealAssetsExportPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnrealAssetsExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:UnrealAssetsExportPath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UnrealAssetsExportPath_Offset), value);
			}
		}
	}

	[Category("Export|Instance Mode")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NaniteFallbackMeshExportPath")]
	public FName NaniteFallbackMeshExportPath
	{
		get
		{
			CheckDestroyed();
			if (!NaniteFallbackMeshExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NaniteFallbackMeshExportPath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NaniteFallbackMeshExportPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NaniteFallbackMeshExportPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NaniteFallbackMeshExportPath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NaniteFallbackMeshExportPath_Offset), value);
			}
		}
	}

	[Category("Export|Instance Mode")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MeshExportMode")]
	public AssetExportMode MeshExportMode
	{
		get
		{
			CheckDestroyed();
			if (!MeshExportMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MeshExportMode");
				return AssetExportMode.INCREMENT;
			}
			return EnumMarshaler<AssetExportMode>.FromNative(IntPtr.Add(base.Address, MeshExportMode_Offset), 0, MeshExportMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MeshExportMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MeshExportMode");
			}
			else
			{
				EnumMarshaler<AssetExportMode>.ToNative(IntPtr.Add(base.Address, MeshExportMode_Offset), 0, MeshExportMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:TextureExportMode")]
	public AssetExportMode TextureExportMode
	{
		get
		{
			CheckDestroyed();
			if (!TextureExportMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:TextureExportMode");
				return AssetExportMode.INCREMENT;
			}
			return EnumMarshaler<AssetExportMode>.FromNative(IntPtr.Add(base.Address, TextureExportMode_Offset), 0, TextureExportMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextureExportMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:TextureExportMode");
			}
			else
			{
				EnumMarshaler<AssetExportMode>.ToNative(IntPtr.Add(base.Address, TextureExportMode_Offset), 0, TextureExportMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Export|Instance Mode")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:AutoDisableNanite")]
	public bool AutoDisableNanite
	{
		get
		{
			CheckDestroyed();
			if (!AutoDisableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:AutoDisableNanite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoDisableNanite_Offset), 0, AutoDisableNanite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoDisableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:AutoDisableNanite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoDisableNanite_Offset), 0, AutoDisableNanite_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Import|NotMeragedActors")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NotMeragedActorsJsonFilePath")]
	public FName NotMeragedActorsJsonFilePath
	{
		get
		{
			CheckDestroyed();
			if (!NotMeragedActorsJsonFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NotMeragedActorsJsonFilePath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotMeragedActorsJsonFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotMeragedActorsJsonFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:NotMeragedActorsJsonFilePath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotMeragedActorsJsonFilePath_Offset), value);
			}
		}
	}

	[Category("Import|LimitBox")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxJsonFilePath")]
	public FName LimitBoxJsonFilePath
	{
		get
		{
			CheckDestroyed();
			if (!LimitBoxJsonFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxJsonFilePath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LimitBoxJsonFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LimitBoxJsonFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxJsonFilePath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LimitBoxJsonFilePath_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Import|LimitBox")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:PerUnitCellSize")]
	public FVector PerUnitCellSize
	{
		get
		{
			CheckDestroyed();
			if (!PerUnitCellSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:PerUnitCellSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PerUnitCellSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerUnitCellSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:PerUnitCellSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PerUnitCellSize_Offset), value);
			}
		}
	}

	[Category("Import|LimitBox")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxCenterPosArray")]
	public TArrayReadWrite<FVector> LimitBoxCenterPosArray
	{
		get
		{
			CheckDestroyed();
			if (!LimitBoxCenterPosArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxCenterPosArray");
				return null;
			}
			if (LimitBoxCenterPosArray_Marshaler == null)
			{
				LimitBoxCenterPosArray_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LimitBoxCenterPosArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LimitBoxCenterPosArray_Marshaler.FromNative(IntPtr.Add(base.Address, LimitBoxCenterPosArray_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Import|LimitBox")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxStartEndIndexInfo")]
	public TArrayReadWrite<FVector> LimitBoxStartEndIndexInfo
	{
		get
		{
			CheckDestroyed();
			if (!LimitBoxStartEndIndexInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:LimitBoxStartEndIndexInfo");
				return null;
			}
			if (LimitBoxStartEndIndexInfo_Marshaler == null)
			{
				LimitBoxStartEndIndexInfo_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LimitBoxStartEndIndexInfo_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LimitBoxStartEndIndexInfo_Marshaler.FromNative(IntPtr.Add(base.Address, LimitBoxStartEndIndexInfo_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Ctrl|LimitBox")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MergedChunkIndex")]
	public int MergedChunkIndex
	{
		get
		{
			CheckDestroyed();
			if (!MergedChunkIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MergedChunkIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MergedChunkIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MergedChunkIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:MergedChunkIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MergedChunkIndex_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Ctrl|LimitHeight")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:HeightLimit")]
	public float HeightLimit
	{
		get
		{
			CheckDestroyed();
			if (!HeightLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:HeightLimit");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeightLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:HeightLimit");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeightLimit_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelDescriptionJson")]
	public void ExportLevelDescriptionJson()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportActorBoundsDescriptionJson")]
	public void ExportActorBoundsDescriptionJson()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportSplineDescriptionJson")]
	public void ExportSplineDescriptionJson()
	{
	}

	private List<UStaticMeshComponent> InteriorGetSelectedStaticMeshComponentList()
	{
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportMeshAssets")]
	public void ExportMeshAssets()
	{
	}

	private void InteriorExportMeshAssets(List<UStaticMeshComponent> SMCList, out Dictionary<UStaticMesh, UStaticMeshComponent> UniqueStaticMesh2SMComp, out Dictionary<UStaticMesh, List<L2HInstanceModeStaticMeshInfo.MatInfo>> MatInfoDict)
	{
		UniqueStaticMesh2SMComp = null;
		MatInfoDict = null;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelToHoudini")]
	public void ExportLevelToHoudini()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ImportLimitBoxInfo")]
	public void ImportLimitBoxInfo()
	{
	}

	private void InteriorImportNotMeragedActorsInfo(out List<string> ActorLabel, out List<string> ActorName)
	{
		ActorLabel = null;
		ActorName = null;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByNotMeragedActorsJson")]
	public void SelectActorsByNotMeragedActorsJson()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsInLimitBox")]
	public void SelectActorsInLimitBox()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByHeightLimit")]
	public void SelectActorsByHeightLimit()
	{
	}

	static DispLib_EditorExportLevelToHoudini()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorExportLevelToHoudini)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorExportLevelToHoudini));
		fileName = "GSLevelDescriptionJson";
		SplineFileName = "GSLevel_Spline_DescriptionJson.json";
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportMeshAssets")]
	private static void ExportMeshAssets__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ExportMeshAssets();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ImportLimitBoxInfo")]
	private static void ImportLimitBoxInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ImportLimitBoxInfo();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelToHoudini")]
	private static void ExportLevelToHoudini__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ExportLevelToHoudini();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsInLimitBox")]
	private static void SelectActorsInLimitBox__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.SelectActorsInLimitBox();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByHeightLimit")]
	private static void SelectActorsByHeightLimit__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.SelectActorsByHeightLimit();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelDescriptionJson")]
	private static void ExportLevelDescriptionJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ExportLevelDescriptionJson();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportSplineDescriptionJson")]
	private static void ExportSplineDescriptionJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ExportSplineDescriptionJson();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportActorBoundsDescriptionJson")]
	private static void ExportActorBoundsDescriptionJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.ExportActorBoundsDescriptionJson();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByNotMeragedActorsJson")]
	private static void SelectActorsByNotMeragedActorsJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorExportLevelToHoudini dispLib_EditorExportLevelToHoudini = GCHelper.Find<DispLib_EditorExportLevelToHoudini>(obj);
		dispLib_EditorExportLevelToHoudini.SelectActorsByNotMeragedActorsJson();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini");
		FilterByTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterByTag");
		FilterByTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterByTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref UseExcludedObjects_PropertyAddress, intPtr, "UseExcludedObjects");
		UseExcludedObjects_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseExcludedObjects");
		UseExcludedObjects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseExcludedObjects", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ExcludedObjects_PropertyAddress, intPtr, "ExcludedObjects");
		ExcludedObjects_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExcludedObjects");
		ExcludedObjects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExcludedObjects", Classes.FArrayProperty);
		LevelJsonFileExportPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelJsonFileExportPath");
		LevelJsonFileExportPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelJsonFileExportPath", Classes.FNameProperty);
		LevelJsonFileName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelJsonFileName");
		LevelJsonFileName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelJsonFileName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref FileNameAutoIndexSuffix_PropertyAddress, intPtr, "FileNameAutoIndexSuffix");
		FileNameAutoIndexSuffix_Offset = NativeReflection.GetPropertyOffset(intPtr, "FileNameAutoIndexSuffix");
		FileNameAutoIndexSuffix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FileNameAutoIndexSuffix", Classes.FBoolProperty);
		UnrealAssetsExportPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnrealAssetsExportPath");
		UnrealAssetsExportPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnrealAssetsExportPath", Classes.FNameProperty);
		NaniteFallbackMeshExportPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "NaniteFallbackMeshExportPath");
		NaniteFallbackMeshExportPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NaniteFallbackMeshExportPath", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref MeshExportMode_PropertyAddress, intPtr, "MeshExportMode");
		MeshExportMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeshExportMode");
		MeshExportMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeshExportMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TextureExportMode_PropertyAddress, intPtr, "TextureExportMode");
		TextureExportMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextureExportMode");
		TextureExportMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextureExportMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AutoDisableNanite_PropertyAddress, intPtr, "AutoDisableNanite");
		AutoDisableNanite_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoDisableNanite");
		AutoDisableNanite_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoDisableNanite", Classes.FBoolProperty);
		NotMeragedActorsJsonFilePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotMeragedActorsJsonFilePath");
		NotMeragedActorsJsonFilePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotMeragedActorsJsonFilePath", Classes.FNameProperty);
		LimitBoxJsonFilePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimitBoxJsonFilePath");
		LimitBoxJsonFilePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimitBoxJsonFilePath", Classes.FNameProperty);
		PerUnitCellSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerUnitCellSize");
		PerUnitCellSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerUnitCellSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref LimitBoxCenterPosArray_PropertyAddress, intPtr, "LimitBoxCenterPosArray");
		LimitBoxCenterPosArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimitBoxCenterPosArray");
		LimitBoxCenterPosArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimitBoxCenterPosArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LimitBoxStartEndIndexInfo_PropertyAddress, intPtr, "LimitBoxStartEndIndexInfo");
		LimitBoxStartEndIndexInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimitBoxStartEndIndexInfo");
		LimitBoxStartEndIndexInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimitBoxStartEndIndexInfo", Classes.FArrayProperty);
		MergedChunkIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "MergedChunkIndex");
		MergedChunkIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MergedChunkIndex", Classes.FIntProperty);
		HeightLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightLimit");
		HeightLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightLimit", Classes.FFloatProperty);
		ExportMeshAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportMeshAssets");
		ExportMeshAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportMeshAssets_FunctionAddress);
		ExportMeshAssets_IsValid = ExportMeshAssets_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportMeshAssets", ExportMeshAssets_IsValid);
		ImportLimitBoxInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ImportLimitBoxInfo");
		ImportLimitBoxInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportLimitBoxInfo_FunctionAddress);
		ImportLimitBoxInfo_IsValid = ImportLimitBoxInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ImportLimitBoxInfo", ImportLimitBoxInfo_IsValid);
		ExportLevelToHoudini_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportLevelToHoudini");
		ExportLevelToHoudini_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportLevelToHoudini_FunctionAddress);
		ExportLevelToHoudini_IsValid = ExportLevelToHoudini_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelToHoudini", ExportLevelToHoudini_IsValid);
		SelectActorsInLimitBox_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectActorsInLimitBox");
		SelectActorsInLimitBox_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectActorsInLimitBox_FunctionAddress);
		SelectActorsInLimitBox_IsValid = SelectActorsInLimitBox_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsInLimitBox", SelectActorsInLimitBox_IsValid);
		SelectActorsByHeightLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectActorsByHeightLimit");
		SelectActorsByHeightLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectActorsByHeightLimit_FunctionAddress);
		SelectActorsByHeightLimit_IsValid = SelectActorsByHeightLimit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByHeightLimit", SelectActorsByHeightLimit_IsValid);
		ExportLevelDescriptionJson_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportLevelDescriptionJson");
		ExportLevelDescriptionJson_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportLevelDescriptionJson_FunctionAddress);
		ExportLevelDescriptionJson_IsValid = ExportLevelDescriptionJson_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportLevelDescriptionJson", ExportLevelDescriptionJson_IsValid);
		ExportSplineDescriptionJson_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportSplineDescriptionJson");
		ExportSplineDescriptionJson_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportSplineDescriptionJson_FunctionAddress);
		ExportSplineDescriptionJson_IsValid = ExportSplineDescriptionJson_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportSplineDescriptionJson", ExportSplineDescriptionJson_IsValid);
		ExportActorBoundsDescriptionJson_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportActorBoundsDescriptionJson");
		ExportActorBoundsDescriptionJson_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportActorBoundsDescriptionJson_FunctionAddress);
		ExportActorBoundsDescriptionJson_IsValid = ExportActorBoundsDescriptionJson_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:ExportActorBoundsDescriptionJson", ExportActorBoundsDescriptionJson_IsValid);
		SelectActorsByNotMeragedActorsJson_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectActorsByNotMeragedActorsJson");
		SelectActorsByNotMeragedActorsJson_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectActorsByNotMeragedActorsJson_FunctionAddress);
		SelectActorsByNotMeragedActorsJson_IsValid = SelectActorsByNotMeragedActorsJson_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorExportLevelToHoudini:SelectActorsByNotMeragedActorsJson", SelectActorsByNotMeragedActorsJson_IsValid);
	}
}
