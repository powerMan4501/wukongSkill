using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUC_ProceduralSpawnSceneItemData")]
public class BUC_ProceduralSpawnSceneItemData : UObject, IBUC_ProceduralSpawnSceneItemData
{
	public List<ProceduralSpawnSceneItemInfo> ProceduralSpawnList { get; set; }

	public bool EnableEditorPreview { get; set; }

	public float SpawnRadius { get; set; }

	public bool IsEditorPreviewEnabled()
	{
		return EnableEditorPreview;
	}

	public float GetSpawnRadius()
	{
		return SpawnRadius;
	}

	public List<ProceduralSpawnSceneItemInfo> GetSpawnList()
	{
		return ProceduralSpawnList;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUC_ProceduralSpawnSceneItemData");
	}

	static BUC_ProceduralSpawnSceneItemData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_ProceduralSpawnSceneItemData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_ProceduralSpawnSceneItemData));
	}
}
