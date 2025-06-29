using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioTriggerConfigComp")]
internal class BUS_AudioTriggerConfigComp : UActorEditCompBase
{
	private static bool AudioList_IsValid;

	private static int AudioList_Offset;

	private static FFieldAddress AudioList_PropertyAddress;

	private TArrayReadWriteMarshaler<FAudioConfig> AudioList_Marshaler;

	[Category("AudioTrigger Config")]
	[EditAnywhere]
	[Tooltip("音效列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AudioTriggerConfigComp:AudioList")]
	public TArrayReadWrite<FAudioConfig> AudioList
	{
		get
		{
			CheckDestroyed();
			if (!AudioList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioTriggerConfigComp:AudioList");
				return null;
			}
			if (AudioList_Marshaler == null)
			{
				AudioList_Marshaler = new TArrayReadWriteMarshaler<FAudioConfig>(1, AudioList_PropertyAddress, CachedMarshalingDelegates<FAudioConfig, FAudioConfig>.FromNative, CachedMarshalingDelegates<FAudioConfig, FAudioConfig>.ToNative);
			}
			return AudioList_Marshaler.FromNative(IntPtr.Add(base.Address, AudioList_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_AudioTriggerConfigData bUC_AudioTriggerConfigData = RequireWritableData<b1.BUC_AudioTriggerConfigData>();
		foreach (FAudioConfig audio in AudioList)
		{
			bUC_AudioTriggerConfigData.AudioList.Add(audio);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref AudioList_PropertyAddress, unrealStruct, "AudioList");
		AudioList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AudioList");
		AudioList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AudioList", Classes.FArrayProperty);
	}

	static BUS_AudioTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AudioTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AudioTriggerConfigComp));
	}
}
