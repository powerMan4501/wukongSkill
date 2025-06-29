using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSWCLODStreamingSetting", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSWCLODStreamingSetting
{
	private static bool RelativeDistance_IsValid;

	private static int RelativeDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCLODStreamingSetting:RelativeDistance")]
	public int RelativeDistance;

	private static bool LODMeshPercentage_IsValid;

	private static int LODMeshPercentage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCLODStreamingSetting:LODMeshPercentage")]
	public float LODMeshPercentage;

	private static int FGSWCLODStreamingSetting_StructSize;

	public FGSWCLODStreamingSetting Copy()
	{
		return this;
	}

	static FGSWCLODStreamingSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSWCLODStreamingSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSWCLODStreamingSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/FuncLibEditor.GSWCLODStreamingSetting");
		FGSWCLODStreamingSetting_StructSize = NativeReflection.GetStructSize(unrealStruct);
		RelativeDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RelativeDistance");
		RelativeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RelativeDistance", Classes.FIntProperty);
		LODMeshPercentage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODMeshPercentage");
		LODMeshPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODMeshPercentage", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSWCLODStreamingSetting));
	}
}
