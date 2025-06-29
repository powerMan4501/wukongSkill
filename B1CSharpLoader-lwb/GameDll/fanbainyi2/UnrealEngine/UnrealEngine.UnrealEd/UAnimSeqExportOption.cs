using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/UnrealEd.AnimSeqExportOption", "UnrealEd", UnrealModuleType.Engine)]
public class UAnimSeqExportOption : UObject
{
	private static bool ExportTransforms_IsValid;

	private static FFieldAddress ExportTransforms_PropertyAddress;

	private static int ExportTransforms_Offset;

	private static bool ExportMorphTargets_IsValid;

	private static FFieldAddress ExportMorphTargets_PropertyAddress;

	private static int ExportMorphTargets_Offset;

	private static bool ExportAttributeCurves_IsValid;

	private static FFieldAddress ExportAttributeCurves_PropertyAddress;

	private static int ExportAttributeCurves_Offset;

	private static bool ExportMaterialCurves_IsValid;

	private static FFieldAddress ExportMaterialCurves_PropertyAddress;

	private static int ExportMaterialCurves_Offset;

	private static bool RecordInWorldSpace_IsValid;

	private static FFieldAddress RecordInWorldSpace_PropertyAddress;

	private static int RecordInWorldSpace_Offset;

	private static bool EvaluateAllSkeletalMeshComponents_IsValid;

	private static FFieldAddress EvaluateAllSkeletalMeshComponents_PropertyAddress;

	private static int EvaluateAllSkeletalMeshComponents_Offset;

	private static bool WarmUpFrames_IsValid;

	private static int WarmUpFrames_Offset;

	private static bool DelayBeforeStart_IsValid;

	private static int DelayBeforeStart_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bExportTransforms")]
	public bool ExportTransforms
	{
		get
		{
			CheckDestroyed();
			if (!ExportTransforms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportTransforms");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportTransforms_Offset), 0, ExportTransforms_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportTransforms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportTransforms");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportTransforms_Offset), 0, ExportTransforms_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bExportMorphTargets")]
	public bool ExportMorphTargets
	{
		get
		{
			CheckDestroyed();
			if (!ExportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportMorphTargets");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportMorphTargets_Offset), 0, ExportMorphTargets_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportMorphTargets");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportMorphTargets_Offset), 0, ExportMorphTargets_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bExportAttributeCurves")]
	public bool ExportAttributeCurves
	{
		get
		{
			CheckDestroyed();
			if (!ExportAttributeCurves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportAttributeCurves");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportAttributeCurves_Offset), 0, ExportAttributeCurves_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportAttributeCurves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportAttributeCurves");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportAttributeCurves_Offset), 0, ExportAttributeCurves_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bExportMaterialCurves")]
	public bool ExportMaterialCurves
	{
		get
		{
			CheckDestroyed();
			if (!ExportMaterialCurves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportMaterialCurves");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportMaterialCurves_Offset), 0, ExportMaterialCurves_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportMaterialCurves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bExportMaterialCurves");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportMaterialCurves_Offset), 0, ExportMaterialCurves_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bRecordInWorldSpace")]
	public bool RecordInWorldSpace
	{
		get
		{
			CheckDestroyed();
			if (!RecordInWorldSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bRecordInWorldSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RecordInWorldSpace_Offset), 0, RecordInWorldSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RecordInWorldSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bRecordInWorldSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RecordInWorldSpace_Offset), 0, RecordInWorldSpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:bEvaluateAllSkeletalMeshComponents")]
	public bool EvaluateAllSkeletalMeshComponents
	{
		get
		{
			CheckDestroyed();
			if (!EvaluateAllSkeletalMeshComponents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bEvaluateAllSkeletalMeshComponents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EvaluateAllSkeletalMeshComponents_Offset), 0, EvaluateAllSkeletalMeshComponents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EvaluateAllSkeletalMeshComponents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:bEvaluateAllSkeletalMeshComponents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EvaluateAllSkeletalMeshComponents_Offset), 0, EvaluateAllSkeletalMeshComponents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:WarmUpFrames")]
	public FFrameNumber WarmUpFrames
	{
		get
		{
			CheckDestroyed();
			if (!WarmUpFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:WarmUpFrames");
				return default(FFrameNumber);
			}
			return FFrameNumber.FromNative(IntPtr.Add(base.Address, WarmUpFrames_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarmUpFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:WarmUpFrames");
			}
			else
			{
				FFrameNumber.ToNative(IntPtr.Add(base.Address, WarmUpFrames_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/UnrealEd.AnimSeqExportOption:DelayBeforeStart")]
	public FFrameNumber DelayBeforeStart
	{
		get
		{
			CheckDestroyed();
			if (!DelayBeforeStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:DelayBeforeStart");
				return default(FFrameNumber);
			}
			return FFrameNumber.FromNative(IntPtr.Add(base.Address, DelayBeforeStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayBeforeStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AnimSeqExportOption:DelayBeforeStart");
			}
			else
			{
				FFrameNumber.ToNative(IntPtr.Add(base.Address, DelayBeforeStart_Offset), value);
			}
		}
	}

	static UAnimSeqExportOption()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSeqExportOption)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSeqExportOption));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.AnimSeqExportOption");
		NativeReflectionCached.GetPropertyRef(ref ExportTransforms_PropertyAddress, unrealStruct, "bExportTransforms");
		ExportTransforms_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportTransforms");
		ExportTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportTransforms", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportMorphTargets_PropertyAddress, unrealStruct, "bExportMorphTargets");
		ExportMorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportMorphTargets");
		ExportMorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportMorphTargets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAttributeCurves_PropertyAddress, unrealStruct, "bExportAttributeCurves");
		ExportAttributeCurves_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportAttributeCurves");
		ExportAttributeCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportAttributeCurves", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportMaterialCurves_PropertyAddress, unrealStruct, "bExportMaterialCurves");
		ExportMaterialCurves_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExportMaterialCurves");
		ExportMaterialCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExportMaterialCurves", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordInWorldSpace_PropertyAddress, unrealStruct, "bRecordInWorldSpace");
		RecordInWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRecordInWorldSpace");
		RecordInWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRecordInWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateAllSkeletalMeshComponents_PropertyAddress, unrealStruct, "bEvaluateAllSkeletalMeshComponents");
		EvaluateAllSkeletalMeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEvaluateAllSkeletalMeshComponents");
		EvaluateAllSkeletalMeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEvaluateAllSkeletalMeshComponents", Classes.FBoolProperty);
		WarmUpFrames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WarmUpFrames");
		WarmUpFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WarmUpFrames", Classes.FStructProperty);
		DelayBeforeStart_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DelayBeforeStart");
		DelayBeforeStart_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DelayBeforeStart", Classes.FStructProperty);
	}
}
