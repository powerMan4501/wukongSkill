using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.AssetImportTask", "UnrealEd", UnrealModuleType.Engine)]
public class UAssetImportTask : UObject
{
	private static bool Filename_IsValid;

	private static int Filename_Offset;

	private static bool DestinationPath_IsValid;

	private static int DestinationPath_Offset;

	private static bool DestinationName_IsValid;

	private static int DestinationName_Offset;

	private static bool ReplaceExisting_IsValid;

	private static FFieldAddress ReplaceExisting_PropertyAddress;

	private static int ReplaceExisting_Offset;

	private static bool ReplaceExistingSettings_IsValid;

	private static FFieldAddress ReplaceExistingSettings_PropertyAddress;

	private static int ReplaceExistingSettings_Offset;

	private static bool Automated_IsValid;

	private static FFieldAddress Automated_PropertyAddress;

	private static int Automated_Offset;

	private static bool Save_IsValid;

	private static FFieldAddress Save_PropertyAddress;

	private static int Save_Offset;

	private static bool Factory_IsValid;

	private static int Factory_Offset;

	private static bool Options_IsValid;

	private static int Options_Offset;

	private static bool ImportedObjectPaths_IsValid;

	private static FFieldAddress ImportedObjectPaths_PropertyAddress;

	private static int ImportedObjectPaths_Offset;

	private TArrayReadWriteMarshaler<string> ImportedObjectPaths_MarshalerCached;

	private static bool Result_IsValid;

	private static FFieldAddress Result_PropertyAddress;

	private static int Result_Offset;

	private TArrayReadWriteMarshaler<UObject> Result_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:Filename")]
	public string Filename
	{
		get
		{
			CheckDestroyed();
			if (!Filename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Filename");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Filename_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Filename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Filename");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Filename_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:DestinationPath")]
	public string DestinationPath
	{
		get
		{
			CheckDestroyed();
			if (!DestinationPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:DestinationPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DestinationPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestinationPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:DestinationPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DestinationPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:DestinationName")]
	public string DestinationName
	{
		get
		{
			CheckDestroyed();
			if (!DestinationName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:DestinationName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DestinationName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestinationName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:DestinationName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DestinationName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:bReplaceExisting")]
	public bool ReplaceExisting
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceExisting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bReplaceExisting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplaceExisting_Offset), 0, ReplaceExisting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceExisting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bReplaceExisting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplaceExisting_Offset), 0, ReplaceExisting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:bReplaceExistingSettings")]
	public bool ReplaceExistingSettings
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceExistingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bReplaceExistingSettings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplaceExistingSettings_Offset), 0, ReplaceExistingSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceExistingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bReplaceExistingSettings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplaceExistingSettings_Offset), 0, ReplaceExistingSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:bAutomated")]
	public bool Automated
	{
		get
		{
			CheckDestroyed();
			if (!Automated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bAutomated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Automated_Offset), 0, Automated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Automated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bAutomated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Automated_Offset), 0, Automated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:bSave")]
	public bool Save
	{
		get
		{
			CheckDestroyed();
			if (!Save_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bSave");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Save_Offset), 0, Save_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Save_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:bSave");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Save_Offset), 0, Save_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:Factory")]
	public UFactory Factory
	{
		get
		{
			CheckDestroyed();
			if (!Factory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Factory");
				return null;
			}
			return UObjectMarshaler<UFactory>.FromNative(IntPtr.Add(base.Address, Factory_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Factory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Factory");
			}
			else
			{
				UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(base.Address, Factory_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:Options")]
	public UObject Options
	{
		get
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Options");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Options_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Options");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Options_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:ImportedObjectPaths")]
	public TArrayReadWrite<string> ImportedObjectPaths
	{
		get
		{
			CheckDestroyed();
			if (!ImportedObjectPaths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:ImportedObjectPaths");
				return null;
			}
			if (ImportedObjectPaths_MarshalerCached == null)
			{
				ImportedObjectPaths_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ImportedObjectPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ImportedObjectPaths_MarshalerCached.FromNative(IntPtr.Add(base.Address, ImportedObjectPaths_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/UnrealEd.AssetImportTask:Result")]
	public TArrayReadWrite<UObject> Result
	{
		get
		{
			CheckDestroyed();
			if (!Result_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AssetImportTask:Result");
				return null;
			}
			if (Result_MarshalerCached == null)
			{
				Result_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, Result_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Result_MarshalerCached.FromNative(IntPtr.Add(base.Address, Result_Offset));
		}
	}

	static UAssetImportTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetImportTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetImportTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.AssetImportTask");
		Filename_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Filename");
		Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Filename", Classes.FStrProperty);
		DestinationPath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestinationPath");
		DestinationPath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestinationPath", Classes.FStrProperty);
		DestinationName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestinationName");
		DestinationName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestinationName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceExisting_PropertyAddress, unrealStruct, "bReplaceExisting");
		ReplaceExisting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReplaceExisting");
		ReplaceExisting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReplaceExisting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceExistingSettings_PropertyAddress, unrealStruct, "bReplaceExistingSettings");
		ReplaceExistingSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReplaceExistingSettings");
		ReplaceExistingSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReplaceExistingSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Automated_PropertyAddress, unrealStruct, "bAutomated");
		Automated_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutomated");
		Automated_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutomated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Save_PropertyAddress, unrealStruct, "bSave");
		Save_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSave");
		Save_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSave", Classes.FBoolProperty);
		Factory_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Factory");
		Factory_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Factory", Classes.FObjectProperty);
		Options_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Options");
		Options_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Options", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportedObjectPaths_PropertyAddress, unrealStruct, "ImportedObjectPaths");
		ImportedObjectPaths_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportedObjectPaths");
		ImportedObjectPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportedObjectPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Result_PropertyAddress, unrealStruct, "Result");
		Result_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Result", Classes.FArrayProperty);
	}
}
