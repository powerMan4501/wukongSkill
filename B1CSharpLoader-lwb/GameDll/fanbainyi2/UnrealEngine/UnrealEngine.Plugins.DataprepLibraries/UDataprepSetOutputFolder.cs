using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetOutputFolder", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetOutputFolder : UDataprepOperation
{
	private static bool FolderName_IsValid;

	private static int FolderName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetOutputFolder:FolderName")]
	public string FolderName
	{
		get
		{
			CheckDestroyed();
			if (!FolderName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetOutputFolder:FolderName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FolderName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FolderName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetOutputFolder:FolderName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FolderName_Offset), value);
			}
		}
	}

	static UDataprepSetOutputFolder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetOutputFolder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetOutputFolder));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetOutputFolder");
		FolderName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FolderName");
		FolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FolderName", Classes.FStrProperty);
	}
}
