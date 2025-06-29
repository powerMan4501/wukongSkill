using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AssetExportTask", "Engine", UnrealModuleType.Engine)]
public class UAssetExportTask : UObject
{
	private static bool Object_IsValid;

	private static int Object_Offset;

	private static bool Exporter_IsValid;

	private static int Exporter_Offset;

	private static bool Filename_IsValid;

	private static int Filename_Offset;

	private static bool Selected_IsValid;

	private static FFieldAddress Selected_PropertyAddress;

	private static int Selected_Offset;

	private static bool ReplaceIdentical_IsValid;

	private static FFieldAddress ReplaceIdentical_PropertyAddress;

	private static int ReplaceIdentical_Offset;

	private static bool Prompt_IsValid;

	private static FFieldAddress Prompt_PropertyAddress;

	private static int Prompt_Offset;

	private static bool Automated_IsValid;

	private static FFieldAddress Automated_PropertyAddress;

	private static int Automated_Offset;

	private static bool UseFileArchive_IsValid;

	private static FFieldAddress UseFileArchive_PropertyAddress;

	private static int UseFileArchive_Offset;

	private static bool WriteEmptyFiles_IsValid;

	private static FFieldAddress WriteEmptyFiles_PropertyAddress;

	private static int WriteEmptyFiles_Offset;

	private static bool IgnoreObjectList_IsValid;

	private static FFieldAddress IgnoreObjectList_PropertyAddress;

	private static int IgnoreObjectList_Offset;

	private TArrayReadWriteMarshaler<UObject> IgnoreObjectList_MarshalerCached;

	private static bool Options_IsValid;

	private static int Options_Offset;

	private static bool Errors_IsValid;

	private static FFieldAddress Errors_PropertyAddress;

	private static int Errors_Offset;

	private TArrayReadWriteMarshaler<string> Errors_MarshalerCached;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:Object")]
	public UObject Object
	{
		get
		{
			CheckDestroyed();
			if (!Object_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Object");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Object_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Object_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Object");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Object_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:Exporter")]
	public UExporter Exporter
	{
		get
		{
			CheckDestroyed();
			if (!Exporter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Exporter");
				return null;
			}
			return UObjectMarshaler<UExporter>.FromNative(IntPtr.Add(base.Address, Exporter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Exporter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Exporter");
			}
			else
			{
				UObjectMarshaler<UExporter>.ToNative(IntPtr.Add(base.Address, Exporter_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:Filename")]
	public string Filename
	{
		get
		{
			CheckDestroyed();
			if (!Filename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Filename");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Filename_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Filename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Filename");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Filename_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bSelected")]
	public bool Selected
	{
		get
		{
			CheckDestroyed();
			if (!Selected_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bSelected");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Selected_Offset), 0, Selected_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Selected_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bSelected");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Selected_Offset), 0, Selected_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bReplaceIdentical")]
	public bool ReplaceIdentical
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceIdentical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bReplaceIdentical");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplaceIdentical_Offset), 0, ReplaceIdentical_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceIdentical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bReplaceIdentical");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplaceIdentical_Offset), 0, ReplaceIdentical_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bPrompt")]
	public bool Prompt
	{
		get
		{
			CheckDestroyed();
			if (!Prompt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bPrompt");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Prompt_Offset), 0, Prompt_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Prompt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bPrompt");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Prompt_Offset), 0, Prompt_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bAutomated")]
	public bool Automated
	{
		get
		{
			CheckDestroyed();
			if (!Automated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bAutomated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Automated_Offset), 0, Automated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Automated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bAutomated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Automated_Offset), 0, Automated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bUseFileArchive")]
	public bool UseFileArchive
	{
		get
		{
			CheckDestroyed();
			if (!UseFileArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bUseFileArchive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseFileArchive_Offset), 0, UseFileArchive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseFileArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bUseFileArchive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseFileArchive_Offset), 0, UseFileArchive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:bWriteEmptyFiles")]
	public bool WriteEmptyFiles
	{
		get
		{
			CheckDestroyed();
			if (!WriteEmptyFiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bWriteEmptyFiles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WriteEmptyFiles_Offset), 0, WriteEmptyFiles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WriteEmptyFiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:bWriteEmptyFiles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WriteEmptyFiles_Offset), 0, WriteEmptyFiles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:IgnoreObjectList")]
	public TArrayReadWrite<UObject> IgnoreObjectList
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreObjectList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:IgnoreObjectList");
				return null;
			}
			if (IgnoreObjectList_MarshalerCached == null)
			{
				IgnoreObjectList_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, IgnoreObjectList_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return IgnoreObjectList_MarshalerCached.FromNative(IntPtr.Add(base.Address, IgnoreObjectList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:Options")]
	public UObject Options
	{
		get
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Options");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Options_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Options_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Options");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Options_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Engine.AssetExportTask:Errors")]
	public TArrayReadWrite<string> Errors
	{
		get
		{
			CheckDestroyed();
			if (!Errors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AssetExportTask:Errors");
				return null;
			}
			if (Errors_MarshalerCached == null)
			{
				Errors_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, Errors_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Errors_MarshalerCached.FromNative(IntPtr.Add(base.Address, Errors_Offset));
		}
	}

	static UAssetExportTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetExportTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetExportTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AssetExportTask");
		Object_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Object");
		Object_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Object", Classes.FObjectProperty);
		Exporter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Exporter");
		Exporter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Exporter", Classes.FObjectProperty);
		Filename_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Filename");
		Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Selected_PropertyAddress, unrealStruct, "bSelected");
		Selected_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSelected");
		Selected_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceIdentical_PropertyAddress, unrealStruct, "bReplaceIdentical");
		ReplaceIdentical_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReplaceIdentical");
		ReplaceIdentical_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReplaceIdentical", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Prompt_PropertyAddress, unrealStruct, "bPrompt");
		Prompt_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPrompt");
		Prompt_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPrompt", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Automated_PropertyAddress, unrealStruct, "bAutomated");
		Automated_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutomated");
		Automated_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutomated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFileArchive_PropertyAddress, unrealStruct, "bUseFileArchive");
		UseFileArchive_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseFileArchive");
		UseFileArchive_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseFileArchive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteEmptyFiles_PropertyAddress, unrealStruct, "bWriteEmptyFiles");
		WriteEmptyFiles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWriteEmptyFiles");
		WriteEmptyFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWriteEmptyFiles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreObjectList_PropertyAddress, unrealStruct, "IgnoreObjectList");
		IgnoreObjectList_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IgnoreObjectList");
		IgnoreObjectList_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IgnoreObjectList", Classes.FArrayProperty);
		Options_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Options");
		Options_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Options", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Errors_PropertyAddress, unrealStruct, "Errors");
		Errors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Errors");
		Errors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Errors", Classes.FArrayProperty);
	}
}
