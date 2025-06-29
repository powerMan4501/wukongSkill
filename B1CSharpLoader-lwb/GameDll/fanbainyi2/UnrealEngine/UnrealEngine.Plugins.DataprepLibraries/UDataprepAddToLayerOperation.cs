using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepAddToLayerOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepAddToLayerOperation : UDataprepOperation
{
	private static bool LayerName_IsValid;

	private static int LayerName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepAddToLayerOperation:LayerName")]
	public FName LayerName
	{
		get
		{
			CheckDestroyed();
			if (!LayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepAddToLayerOperation:LayerName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LayerName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepAddToLayerOperation:LayerName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LayerName_Offset), value);
			}
		}
	}

	static UDataprepAddToLayerOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepAddToLayerOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepAddToLayerOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepAddToLayerOperation");
		LayerName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayerName");
		LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayerName", Classes.FNameProperty);
	}
}
