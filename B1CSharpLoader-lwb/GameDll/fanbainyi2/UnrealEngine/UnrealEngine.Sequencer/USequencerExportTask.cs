using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UClass(Flags = (ClassFlags)809500840uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Sequencer.SequencerExportTask", "Sequencer", UnrealModuleType.Engine)]
public class USequencerExportTask : UAssetExportTask
{
	private static bool SequencerContext_IsValid;

	private static int SequencerContext_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Sequencer.SequencerExportTask:SequencerContext")]
	public UObject SequencerContext
	{
		get
		{
			CheckDestroyed();
			if (!SequencerContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Sequencer.SequencerExportTask:SequencerContext");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, SequencerContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequencerContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Sequencer.SequencerExportTask:SequencerContext");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, SequencerContext_Offset), value);
			}
		}
	}

	static USequencerExportTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequencerExportTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequencerExportTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Sequencer.SequencerExportTask");
		SequencerContext_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SequencerContext");
		SequencerContext_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SequencerContext", Classes.FObjectProperty);
	}
}
