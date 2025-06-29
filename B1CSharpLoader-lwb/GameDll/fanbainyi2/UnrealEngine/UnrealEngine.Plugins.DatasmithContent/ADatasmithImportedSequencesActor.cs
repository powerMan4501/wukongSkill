using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DatasmithContent.DatasmithImportedSequencesActor", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public class ADatasmithImportedSequencesActor : AActor
{
	private static bool ImportedSequences_IsValid;

	private static FFieldAddress ImportedSequences_PropertyAddress;

	private static int ImportedSequences_Offset;

	private TArrayReadWriteMarshaler<ULevelSequence> ImportedSequences_MarshalerCached;

	private static bool PlayLevelSequence_IsValid;

	private static IntPtr PlayLevelSequence_FunctionAddress;

	private static int PlayLevelSequence_ParamsSize;

	private static bool PlayLevelSequence_SequenceToPlay_IsValid;

	private static FFieldAddress PlayLevelSequence_SequenceToPlay_PropertyAddress;

	private static int PlayLevelSequence_SequenceToPlay_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportedSequencesActor:ImportedSequences")]
	public TArrayReadWrite<ULevelSequence> ImportedSequences
	{
		get
		{
			CheckDestroyed();
			if (!ImportedSequences_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithImportedSequencesActor:ImportedSequences");
				return null;
			}
			if (ImportedSequences_MarshalerCached == null)
			{
				ImportedSequences_MarshalerCached = new TArrayReadWriteMarshaler<ULevelSequence>(1, ImportedSequences_PropertyAddress, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.FromNative, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.ToNative);
			}
			return ImportedSequences_MarshalerCached.FromNative(IntPtr.Add(base.Address, ImportedSequences_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportedSequencesActor:PlayLevelSequence")]
	public unsafe void PlayLevelSequence(ULevelSequence SequenceToPlay)
	{
		CheckDestroyed();
		if (!PlayLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithImportedSequencesActor:PlayLevelSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, PlayLevelSequence_SequenceToPlay_Offset), 0, PlayLevelSequence_SequenceToPlay_PropertyAddress.Address, SequenceToPlay);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayLevelSequence_FunctionAddress, intPtr, PlayLevelSequence_ParamsSize);
	}

	static ADatasmithImportedSequencesActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADatasmithImportedSequencesActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADatasmithImportedSequencesActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/DatasmithContent.DatasmithImportedSequencesActor");
		NativeReflectionCached.GetPropertyRef(ref ImportedSequences_PropertyAddress, intPtr, "ImportedSequences");
		ImportedSequences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImportedSequences");
		ImportedSequences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImportedSequences", Classes.FArrayProperty);
		PlayLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayLevelSequence");
		PlayLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayLevelSequence_SequenceToPlay_PropertyAddress, PlayLevelSequence_FunctionAddress, "SequenceToPlay");
		PlayLevelSequence_SequenceToPlay_Offset = NativeReflectionCached.GetPropertyOffset(PlayLevelSequence_FunctionAddress, "SequenceToPlay");
		PlayLevelSequence_SequenceToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayLevelSequence_FunctionAddress, "SequenceToPlay", Classes.FObjectProperty);
		PlayLevelSequence_IsValid = PlayLevelSequence_FunctionAddress != IntPtr.Zero && PlayLevelSequence_SequenceToPlay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithImportedSequencesActor:PlayLevelSequence", PlayLevelSequence_IsValid);
	}
}
