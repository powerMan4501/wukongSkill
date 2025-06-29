using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810025124uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxExportOption", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxExportOption : UObject
{
	private static bool FbxExportCompatibility_IsValid;

	private static FFieldAddress FbxExportCompatibility_PropertyAddress;

	private static int FbxExportCompatibility_Offset;

	private static bool ASCII_IsValid;

	private static FFieldAddress ASCII_PropertyAddress;

	private static int ASCII_Offset;

	private static bool ForceFrontXAxis_IsValid;

	private static FFieldAddress ForceFrontXAxis_PropertyAddress;

	private static int ForceFrontXAxis_Offset;

	private static bool VertexColor_IsValid;

	private static FFieldAddress VertexColor_PropertyAddress;

	private static int VertexColor_Offset;

	private static bool LevelOfDetail_IsValid;

	private static FFieldAddress LevelOfDetail_PropertyAddress;

	private static int LevelOfDetail_Offset;

	private static bool Collision_IsValid;

	private static FFieldAddress Collision_PropertyAddress;

	private static int Collision_Offset;

	private static bool ExportMorphTargets_IsValid;

	private static FFieldAddress ExportMorphTargets_PropertyAddress;

	private static int ExportMorphTargets_Offset;

	private static bool ExportPreviewMesh_IsValid;

	private static FFieldAddress ExportPreviewMesh_PropertyAddress;

	private static int ExportPreviewMesh_Offset;

	private static bool MapSkeletalMotionToRoot_IsValid;

	private static FFieldAddress MapSkeletalMotionToRoot_PropertyAddress;

	private static int MapSkeletalMotionToRoot_Offset;

	private static bool ExportLocalTime_IsValid;

	private static FFieldAddress ExportLocalTime_PropertyAddress;

	private static int ExportLocalTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:FbxExportCompatibility")]
	public EFbxExportCompatibility FbxExportCompatibility
	{
		get
		{
			CheckDestroyed();
			if (!FbxExportCompatibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:FbxExportCompatibility");
				return EFbxExportCompatibility.FBX_2011;
			}
			return EnumMarshaler<EFbxExportCompatibility>.FromNative(IntPtr.Add(base.Address, FbxExportCompatibility_Offset), 0, FbxExportCompatibility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FbxExportCompatibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:FbxExportCompatibility");
			}
			else
			{
				EnumMarshaler<EFbxExportCompatibility>.ToNative(IntPtr.Add(base.Address, FbxExportCompatibility_Offset), 0, FbxExportCompatibility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:bASCII")]
	public bool ASCII
	{
		get
		{
			CheckDestroyed();
			if (!ASCII_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bASCII");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ASCII_Offset), 0, ASCII_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ASCII_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bASCII");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ASCII_Offset), 0, ASCII_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:bForceFrontXAxis")]
	public bool ForceFrontXAxis
	{
		get
		{
			CheckDestroyed();
			if (!ForceFrontXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bForceFrontXAxis");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceFrontXAxis_Offset), 0, ForceFrontXAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceFrontXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bForceFrontXAxis");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceFrontXAxis_Offset), 0, ForceFrontXAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:VertexColor")]
	public bool VertexColor
	{
		get
		{
			CheckDestroyed();
			if (!VertexColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:VertexColor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VertexColor_Offset), 0, VertexColor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VertexColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:VertexColor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VertexColor_Offset), 0, VertexColor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:LevelOfDetail")]
	public bool LevelOfDetail
	{
		get
		{
			CheckDestroyed();
			if (!LevelOfDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:LevelOfDetail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LevelOfDetail_Offset), 0, LevelOfDetail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LevelOfDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:LevelOfDetail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LevelOfDetail_Offset), 0, LevelOfDetail_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:Collision")]
	public bool Collision
	{
		get
		{
			CheckDestroyed();
			if (!Collision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:Collision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Collision_Offset), 0, Collision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Collision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:Collision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Collision_Offset), 0, Collision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:bExportMorphTargets")]
	public bool ExportMorphTargets
	{
		get
		{
			CheckDestroyed();
			if (!ExportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportMorphTargets");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportMorphTargets_Offset), 0, ExportMorphTargets_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportMorphTargets");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportMorphTargets_Offset), 0, ExportMorphTargets_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:bExportPreviewMesh")]
	public bool ExportPreviewMesh
	{
		get
		{
			CheckDestroyed();
			if (!ExportPreviewMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportPreviewMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportPreviewMesh_Offset), 0, ExportPreviewMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportPreviewMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportPreviewMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportPreviewMesh_Offset), 0, ExportPreviewMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:MapSkeletalMotionToRoot")]
	public bool MapSkeletalMotionToRoot
	{
		get
		{
			CheckDestroyed();
			if (!MapSkeletalMotionToRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:MapSkeletalMotionToRoot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MapSkeletalMotionToRoot_Offset), 0, MapSkeletalMotionToRoot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MapSkeletalMotionToRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:MapSkeletalMotionToRoot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MapSkeletalMotionToRoot_Offset), 0, MapSkeletalMotionToRoot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160548869uL)]
	[UMetaPath("/Script/UnrealEd.FbxExportOption:bExportLocalTime")]
	public bool ExportLocalTime
	{
		get
		{
			CheckDestroyed();
			if (!ExportLocalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportLocalTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportLocalTime_Offset), 0, ExportLocalTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportLocalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxExportOption:bExportLocalTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportLocalTime_Offset), 0, ExportLocalTime_PropertyAddress.Address, value);
			}
		}
	}

	static UFbxExportOption()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxExportOption)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxExportOption));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxExportOption");
		NativeReflectionCached.GetPropertyRef(ref FbxExportCompatibility_PropertyAddress, unrealStruct, "FbxExportCompatibility");
		FbxExportCompatibility_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FbxExportCompatibility");
		FbxExportCompatibility_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FbxExportCompatibility", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ASCII_PropertyAddress, unrealStruct, "bASCII");
		ASCII_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bASCII");
		ASCII_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bASCII", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceFrontXAxis_PropertyAddress, unrealStruct, "bForceFrontXAxis");
		ForceFrontXAxis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForceFrontXAxis");
		ForceFrontXAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForceFrontXAxis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColor_PropertyAddress, unrealStruct, "VertexColor");
		VertexColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexColor");
		VertexColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LevelOfDetail_PropertyAddress, unrealStruct, "LevelOfDetail");
		LevelOfDetail_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LevelOfDetail");
		LevelOfDetail_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LevelOfDetail", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Collision_PropertyAddress, unrealStruct, "Collision");
		Collision_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Collision");
		Collision_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Collision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportMorphTargets_PropertyAddress, unrealStruct, "bExportMorphTargets");
		ExportMorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportMorphTargets");
		ExportMorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportMorphTargets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportPreviewMesh_PropertyAddress, unrealStruct, "bExportPreviewMesh");
		ExportPreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportPreviewMesh");
		ExportPreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportPreviewMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MapSkeletalMotionToRoot_PropertyAddress, unrealStruct, "MapSkeletalMotionToRoot");
		MapSkeletalMotionToRoot_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MapSkeletalMotionToRoot");
		MapSkeletalMotionToRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MapSkeletalMotionToRoot", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLocalTime_PropertyAddress, unrealStruct, "bExportLocalTime");
		ExportLocalTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportLocalTime");
		ExportLocalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportLocalTime", Classes.FBoolProperty);
	}
}
