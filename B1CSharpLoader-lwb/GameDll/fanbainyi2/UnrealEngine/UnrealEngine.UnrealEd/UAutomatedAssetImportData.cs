using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UAutomatedAssetImportData : UObject
{
	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	private static bool Filenames_IsValid;

	private static FFieldAddress Filenames_PropertyAddress;

	private static int Filenames_Offset;

	private TArrayReadWriteMarshaler<string> Filenames_MarshalerCached;

	private static bool DestinationPath_IsValid;

	private static int DestinationPath_Offset;

	private static bool FactoryName_IsValid;

	private static int FactoryName_Offset;

	private static bool ReplaceExisting_IsValid;

	private static FFieldAddress ReplaceExisting_PropertyAddress;

	private static int ReplaceExisting_Offset;

	private static bool SkipReadOnly_IsValid;

	private static FFieldAddress SkipReadOnly_PropertyAddress;

	private static int SkipReadOnly_Offset;

	private static bool Factory_IsValid;

	private static int Factory_Offset;

	private static bool LevelToLoad_IsValid;

	private static int LevelToLoad_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:GroupName")]
	public string GroupName
	{
		get
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:GroupName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GroupName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:GroupName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GroupName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:Filenames")]
	public TArrayReadWrite<string> Filenames
	{
		get
		{
			CheckDestroyed();
			if (!Filenames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:Filenames");
				return null;
			}
			if (Filenames_MarshalerCached == null)
			{
				Filenames_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, Filenames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Filenames_MarshalerCached.FromNative(IntPtr.Add(base.Address, Filenames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:DestinationPath")]
	public string DestinationPath
	{
		get
		{
			CheckDestroyed();
			if (!DestinationPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:DestinationPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DestinationPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestinationPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:DestinationPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DestinationPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:FactoryName")]
	public string FactoryName
	{
		get
		{
			CheckDestroyed();
			if (!FactoryName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:FactoryName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FactoryName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FactoryName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:FactoryName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FactoryName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:bReplaceExisting")]
	public bool ReplaceExisting
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceExisting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:bReplaceExisting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplaceExisting_Offset), 0, ReplaceExisting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceExisting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:bReplaceExisting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplaceExisting_Offset), 0, ReplaceExisting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:bSkipReadOnly")]
	public bool SkipReadOnly
	{
		get
		{
			CheckDestroyed();
			if (!SkipReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:bSkipReadOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipReadOnly_Offset), 0, SkipReadOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:bSkipReadOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipReadOnly_Offset), 0, SkipReadOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:Factory")]
	public UFactory Factory
	{
		get
		{
			CheckDestroyed();
			if (!Factory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:Factory");
				return null;
			}
			return UObjectMarshaler<UFactory>.FromNative(IntPtr.Add(base.Address, Factory_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Factory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:Factory");
			}
			else
			{
				UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(base.Address, Factory_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealEd.AutomatedAssetImportData:LevelToLoad")]
	public string LevelToLoad
	{
		get
		{
			CheckDestroyed();
			if (!LevelToLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:LevelToLoad");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LevelToLoad_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelToLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.AutomatedAssetImportData:LevelToLoad");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LevelToLoad_Offset), value);
			}
		}
	}

	static UAutomatedAssetImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomatedAssetImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomatedAssetImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.AutomatedAssetImportData");
		GroupName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroupName");
		GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroupName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Filenames_PropertyAddress, unrealStruct, "Filenames");
		Filenames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Filenames");
		Filenames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Filenames", Classes.FArrayProperty);
		DestinationPath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestinationPath");
		DestinationPath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestinationPath", Classes.FStrProperty);
		FactoryName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FactoryName");
		FactoryName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FactoryName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceExisting_PropertyAddress, unrealStruct, "bReplaceExisting");
		ReplaceExisting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReplaceExisting");
		ReplaceExisting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReplaceExisting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipReadOnly_PropertyAddress, unrealStruct, "bSkipReadOnly");
		SkipReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSkipReadOnly");
		SkipReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSkipReadOnly", Classes.FBoolProperty);
		Factory_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Factory");
		Factory_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Factory", Classes.FObjectProperty);
		LevelToLoad_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LevelToLoad");
		LevelToLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LevelToLoad", Classes.FStrProperty);
	}
}
