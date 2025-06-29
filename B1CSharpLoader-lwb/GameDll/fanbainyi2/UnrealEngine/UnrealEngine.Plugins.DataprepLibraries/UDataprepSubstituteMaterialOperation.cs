using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSubstituteMaterialOperation : UDataprepOperation
{
	private static bool MaterialSearch_IsValid;

	private static int MaterialSearch_Offset;

	private static bool StringMatch_IsValid;

	private static FFieldAddress StringMatch_PropertyAddress;

	private static int StringMatch_Offset;

	private static bool MaterialSubstitute_IsValid;

	private static int MaterialSubstitute_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSearch")]
	public string MaterialSearch
	{
		get
		{
			CheckDestroyed();
			if (!MaterialSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSearch");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, MaterialSearch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSearch");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, MaterialSearch_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:StringMatch")]
	public EEditorScriptingStringMatchType StringMatch
	{
		get
		{
			CheckDestroyed();
			if (!StringMatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:StringMatch");
				return EEditorScriptingStringMatchType.Contains;
			}
			return EnumMarshaler<EEditorScriptingStringMatchType>.FromNative(IntPtr.Add(base.Address, StringMatch_Offset), 0, StringMatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StringMatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:StringMatch");
			}
			else
			{
				EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(base.Address, StringMatch_Offset), 0, StringMatch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSubstitute")]
	public UMaterialInterface MaterialSubstitute
	{
		get
		{
			CheckDestroyed();
			if (!MaterialSubstitute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSubstitute");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, MaterialSubstitute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialSubstitute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation:MaterialSubstitute");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, MaterialSubstitute_Offset), value);
			}
		}
	}

	static UDataprepSubstituteMaterialOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSubstituteMaterialOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSubstituteMaterialOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSubstituteMaterialOperation");
		MaterialSearch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialSearch");
		MaterialSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialSearch", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StringMatch_PropertyAddress, unrealStruct, "StringMatch");
		StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StringMatch");
		StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StringMatch", Classes.FEnumProperty);
		MaterialSubstitute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialSubstitute");
		MaterialSubstitute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialSubstitute", Classes.FObjectProperty);
	}
}
