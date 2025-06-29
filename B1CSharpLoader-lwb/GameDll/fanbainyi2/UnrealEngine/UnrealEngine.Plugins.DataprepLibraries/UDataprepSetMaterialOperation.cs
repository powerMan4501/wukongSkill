using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetMaterialOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetMaterialOperation : UDataprepOperation
{
	private static bool Material_IsValid;

	private static int Material_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetMaterialOperation:Material")]
	public UMaterialInterface Material
	{
		get
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaterialOperation:Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaterialOperation:Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Material_Offset), value);
			}
		}
	}

	static UDataprepSetMaterialOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetMaterialOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetMaterialOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetMaterialOperation");
		Material_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Material", Classes.FObjectProperty);
	}
}
