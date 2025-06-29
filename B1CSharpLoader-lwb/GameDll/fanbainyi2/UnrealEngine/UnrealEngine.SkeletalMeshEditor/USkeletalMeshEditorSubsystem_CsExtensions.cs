using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SkeletalMeshEditor;

public static class USkeletalMeshEditorSubsystem_CsExtensions
{
	public static bool SetOverrideLODStreaming(this USkeletalMesh SkeletalMesh, bool Override = false, bool StreamLODs = true, int MaxNumStreamedLODs = 0, int MaxNumOptionalLODs = 0)
	{
		return USkeletalMeshEditorSubsystem.SetOverrideLODStreaming(SkeletalMesh, Override, StreamLODs, MaxNumStreamedLODs, MaxNumOptionalLODs);
	}

	public static bool RenameSocket(this USkeletalMesh SkeletalMesh, FName OldName, FName NewName)
	{
		return USkeletalMeshEditorSubsystem.RenameSocket(SkeletalMesh, OldName, NewName);
	}

	public static bool RegenerateLOD(this USkeletalMesh SkeletalMesh, int NewLODCount = 0, bool bRegenerateEvenIfImported = false, bool bGenerateBaseLOD = false)
	{
		return USkeletalMeshEditorSubsystem.RegenerateLOD(SkeletalMesh, NewLODCount, bRegenerateEvenIfImported, bGenerateBaseLOD);
	}
}
