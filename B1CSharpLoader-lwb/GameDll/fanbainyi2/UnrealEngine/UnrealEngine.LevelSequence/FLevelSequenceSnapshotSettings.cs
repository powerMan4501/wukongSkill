using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequenceSnapshotSettings", "LevelSequence", UnrealModuleType.Engine)]
public struct FLevelSequenceSnapshotSettings
{
	private static int FLevelSequenceSnapshotSettings_StructSize;

	public FLevelSequenceSnapshotSettings Copy()
	{
		return this;
	}

	static FLevelSequenceSnapshotSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLevelSequenceSnapshotSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSequenceSnapshotSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/LevelSequence.LevelSequenceSnapshotSettings");
		FLevelSequenceSnapshotSettings_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FLevelSequenceSnapshotSettings));
	}
}
