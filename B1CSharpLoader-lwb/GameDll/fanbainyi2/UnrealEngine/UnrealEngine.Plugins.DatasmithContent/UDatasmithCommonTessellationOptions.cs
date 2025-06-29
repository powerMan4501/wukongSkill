using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UClass(Flags = (ClassFlags)810549412uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithCommonTessellationOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public class UDatasmithCommonTessellationOptions : UDatasmithOptionsBase
{
	private static bool Options_IsValid;

	private static int Options_Offset;

	[UProperty(Flags = (PropFlags)4503668346863621uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithCommonTessellationOptions:Options")]
	public FDatasmithTessellationOptions Options
	{
		get
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithCommonTessellationOptions:Options");
				return default(FDatasmithTessellationOptions);
			}
			return FDatasmithTessellationOptions.FromNative(IntPtr.Add(base.Address, Options_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithCommonTessellationOptions:Options");
			}
			else
			{
				FDatasmithTessellationOptions.ToNative(IntPtr.Add(base.Address, Options_Offset), value);
			}
		}
	}

	static UDatasmithCommonTessellationOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDatasmithCommonTessellationOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDatasmithCommonTessellationOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DatasmithContent.DatasmithCommonTessellationOptions");
		Options_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Options");
		Options_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Options", Classes.FStructProperty);
	}
}
