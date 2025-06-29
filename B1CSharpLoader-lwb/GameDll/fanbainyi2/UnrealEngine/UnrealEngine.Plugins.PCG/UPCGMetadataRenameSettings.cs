using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataRenameSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataRenameSettings : UPCGSettings
{
	private static bool AttributeToRename_IsValid;

	private static int AttributeToRename_Offset;

	private static bool NewAttributeName_IsValid;

	private static int NewAttributeName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataRenameSettings:AttributeToRename")]
	public FName AttributeToRename
	{
		get
		{
			CheckDestroyed();
			if (!AttributeToRename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataRenameSettings:AttributeToRename");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttributeToRename_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeToRename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataRenameSettings:AttributeToRename");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttributeToRename_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataRenameSettings:NewAttributeName")]
	public FName NewAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!NewAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataRenameSettings:NewAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NewAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataRenameSettings:NewAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NewAttributeName_Offset), value);
			}
		}
	}

	static UPCGMetadataRenameSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataRenameSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataRenameSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataRenameSettings");
		AttributeToRename_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeToRename");
		AttributeToRename_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeToRename", Classes.FNameProperty);
		NewAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NewAttributeName");
		NewAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NewAttributeName", Classes.FNameProperty);
	}
}
