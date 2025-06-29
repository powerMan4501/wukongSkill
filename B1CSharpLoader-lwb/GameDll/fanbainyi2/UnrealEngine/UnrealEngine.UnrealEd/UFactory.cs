using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[UMetaPath("/Script/UnrealEd.Factory", "UnrealEd", UnrealModuleType.Engine)]
public class UFactory : UObject
{
	private static bool CreateNew_IsValid;

	private static FFieldAddress CreateNew_PropertyAddress;

	private static int CreateNew_Offset;

	private static bool SupportedClass_IsValid;

	private static int SupportedClass_Offset;

	private static bool ContextClass_IsValid;

	private static int ContextClass_Offset;

	private static bool Formats_IsValid;

	private static FFieldAddress Formats_PropertyAddress;

	private static int Formats_Offset;

	private TArrayReadWriteMarshaler<string> Formats_MarshalerCached;

	private static bool EditAfterNew_IsValid;

	private static FFieldAddress EditAfterNew_PropertyAddress;

	private static int EditAfterNew_Offset;

	private static bool EditorImport_IsValid;

	private static FFieldAddress EditorImport_PropertyAddress;

	private static int EditorImport_Offset;

	private static bool Text_IsValid;

	private static FFieldAddress Text_PropertyAddress;

	private static int Text_Offset;

	private static bool AutomatedImportData_IsValid;

	private static int AutomatedImportData_Offset;

	private static bool AssetImportTask_IsValid;

	private static int AssetImportTask_Offset;

	private static bool ScriptFactoryCreateFile_IsValid;

	private IntPtr ScriptFactoryCreateFile_InstanceFunctionAddress;

	private static IntPtr ScriptFactoryCreateFile_FunctionAddress;

	private static int ScriptFactoryCreateFile_ParamsSize;

	private static bool ScriptFactoryCreateFile_InTask_IsValid;

	private static FFieldAddress ScriptFactoryCreateFile_InTask_PropertyAddress;

	private static int ScriptFactoryCreateFile_InTask_Offset;

	private static bool ScriptFactoryCreateFile_ReturnValue_IsValid;

	private static FFieldAddress ScriptFactoryCreateFile_ReturnValue_PropertyAddress;

	private static int ScriptFactoryCreateFile_ReturnValue_Offset;

	private static bool ScriptFactoryCanImport_IsValid;

	private IntPtr ScriptFactoryCanImport_InstanceFunctionAddress;

	private static IntPtr ScriptFactoryCanImport_FunctionAddress;

	private static int ScriptFactoryCanImport_ParamsSize;

	private static bool ScriptFactoryCanImport_Filename_IsValid;

	private static FFieldAddress ScriptFactoryCanImport_Filename_PropertyAddress;

	private static int ScriptFactoryCanImport_Filename_Offset;

	private static bool ScriptFactoryCanImport_ReturnValue_IsValid;

	private static FFieldAddress ScriptFactoryCanImport_ReturnValue_PropertyAddress;

	private static int ScriptFactoryCanImport_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267863880925188uL)]
	[UMetaPath("/Script/UnrealEd.Factory:bCreateNew")]
	protected bool CreateNew
	{
		get
		{
			CheckDestroyed();
			if (!CreateNew_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bCreateNew");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CreateNew_Offset), 0, CreateNew_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CreateNew_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bCreateNew");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CreateNew_Offset), 0, CreateNew_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.Factory:SupportedClass")]
	public TSubclassOf<UObject> SupportedClass
	{
		get
		{
			CheckDestroyed();
			if (!SupportedClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:SupportedClass");
				return default(TSubclassOf<UObject>);
			}
			return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, SupportedClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SupportedClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:SupportedClass");
			}
			else
			{
				TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, SupportedClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.Factory:ContextClass")]
	public TSubclassOf<UObject> ContextClass
	{
		get
		{
			CheckDestroyed();
			if (!ContextClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:ContextClass");
				return default(TSubclassOf<UObject>);
			}
			return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, ContextClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContextClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:ContextClass");
			}
			else
			{
				TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, ContextClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealEd.Factory:Formats")]
	public TArrayReadWrite<string> Formats
	{
		get
		{
			CheckDestroyed();
			if (!Formats_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:Formats");
				return null;
			}
			if (Formats_MarshalerCached == null)
			{
				Formats_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, Formats_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Formats_MarshalerCached.FromNative(IntPtr.Add(base.Address, Formats_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/UnrealEd.Factory:bEditAfterNew")]
	public bool EditAfterNew
	{
		get
		{
			CheckDestroyed();
			if (!EditAfterNew_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bEditAfterNew");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditAfterNew_Offset), 0, EditAfterNew_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditAfterNew_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bEditAfterNew");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditAfterNew_Offset), 0, EditAfterNew_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/UnrealEd.Factory:bEditorImport")]
	public bool EditorImport
	{
		get
		{
			CheckDestroyed();
			if (!EditorImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bEditorImport");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorImport_Offset), 0, EditorImport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorImport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bEditorImport");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorImport_Offset), 0, EditorImport_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/UnrealEd.Factory:bText")]
	public bool Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Text_Offset), 0, Text_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:bText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Text_Offset), 0, Text_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.Factory:AutomatedImportData")]
	public UAutomatedAssetImportData AutomatedImportData
	{
		get
		{
			CheckDestroyed();
			if (!AutomatedImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:AutomatedImportData");
				return null;
			}
			return UObjectMarshaler<UAutomatedAssetImportData>.FromNative(IntPtr.Add(base.Address, AutomatedImportData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutomatedImportData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:AutomatedImportData");
			}
			else
			{
				UObjectMarshaler<UAutomatedAssetImportData>.ToNative(IntPtr.Add(base.Address, AutomatedImportData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.Factory:AssetImportTask")]
	public UAssetImportTask AssetImportTask
	{
		get
		{
			CheckDestroyed();
			if (!AssetImportTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:AssetImportTask");
				return null;
			}
			return UObjectMarshaler<UAssetImportTask>.FromNative(IntPtr.Add(base.Address, AssetImportTask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssetImportTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.Factory:AssetImportTask");
			}
			else
			{
				UObjectMarshaler<UAssetImportTask>.ToNative(IntPtr.Add(base.Address, AssetImportTask_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealEd.Factory:ScriptFactoryCreateFile")]
	public unsafe bool ScriptFactoryCreateFile(UAssetImportTask InTask)
	{
		CheckDestroyed();
		if (!ScriptFactoryCreateFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.Factory:ScriptFactoryCreateFile");
			return false;
		}
		if (ScriptFactoryCreateFile_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptFactoryCreateFile_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptFactoryCreateFile");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptFactoryCreateFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptFactoryCreateFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetImportTask>.ToNative(IntPtr.Add(intPtr, ScriptFactoryCreateFile_InTask_Offset), 0, ScriptFactoryCreateFile_InTask_PropertyAddress.Address, InTask);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptFactoryCreateFile_InstanceFunctionAddress, intPtr, ScriptFactoryCreateFile_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptFactoryCreateFile_ReturnValue_Offset), 0, ScriptFactoryCreateFile_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptFactoryCreateFile_Implementation(UAssetImportTask InTask)
	{
		CheckDestroyed();
		if (!ScriptFactoryCreateFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.Factory:ScriptFactoryCreateFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptFactoryCreateFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptFactoryCreateFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetImportTask>.ToNative(IntPtr.Add(intPtr, ScriptFactoryCreateFile_InTask_Offset), 0, ScriptFactoryCreateFile_InTask_PropertyAddress.Address, InTask);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptFactoryCreateFile_FunctionAddress, intPtr, ScriptFactoryCreateFile_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptFactoryCreateFile_ReturnValue_Offset), 0, ScriptFactoryCreateFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealEd.Factory:ScriptFactoryCanImport")]
	public unsafe bool ScriptFactoryCanImport(string Filename)
	{
		CheckDestroyed();
		if (!ScriptFactoryCanImport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.Factory:ScriptFactoryCanImport");
			return false;
		}
		if (ScriptFactoryCanImport_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptFactoryCanImport_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptFactoryCanImport");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptFactoryCanImport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptFactoryCanImport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptFactoryCanImport_Filename_Offset), 0, ScriptFactoryCanImport_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptFactoryCanImport_InstanceFunctionAddress, intPtr, ScriptFactoryCanImport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptFactoryCanImport_Filename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptFactoryCanImport_ReturnValue_Offset), 0, ScriptFactoryCanImport_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptFactoryCanImport_Implementation(string Filename)
	{
		CheckDestroyed();
		if (!ScriptFactoryCanImport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.Factory:ScriptFactoryCanImport");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptFactoryCanImport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptFactoryCanImport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptFactoryCanImport_Filename_Offset), 0, ScriptFactoryCanImport_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptFactoryCanImport_FunctionAddress, intPtr, ScriptFactoryCanImport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptFactoryCanImport_Filename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptFactoryCanImport_ReturnValue_Offset), 0, ScriptFactoryCanImport_ReturnValue_PropertyAddress.Address);
	}

	static UFactory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFactory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFactory));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealEd.Factory");
		NativeReflectionCached.GetPropertyRef(ref CreateNew_PropertyAddress, intPtr, "bCreateNew");
		CreateNew_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCreateNew");
		CreateNew_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCreateNew", Classes.FBoolProperty);
		SupportedClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SupportedClass");
		SupportedClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SupportedClass", Classes.FClassProperty);
		ContextClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContextClass");
		ContextClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContextClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref Formats_PropertyAddress, intPtr, "Formats");
		Formats_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Formats");
		Formats_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Formats", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EditAfterNew_PropertyAddress, intPtr, "bEditAfterNew");
		EditAfterNew_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEditAfterNew");
		EditAfterNew_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEditAfterNew", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorImport_PropertyAddress, intPtr, "bEditorImport");
		EditorImport_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEditorImport");
		EditorImport_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEditorImport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Text_PropertyAddress, intPtr, "bText");
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bText");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bText", Classes.FBoolProperty);
		AutomatedImportData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutomatedImportData");
		AutomatedImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutomatedImportData", Classes.FObjectProperty);
		AssetImportTask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetImportTask");
		AssetImportTask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetImportTask", Classes.FObjectProperty);
		ScriptFactoryCreateFile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScriptFactoryCreateFile");
		ScriptFactoryCreateFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptFactoryCreateFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptFactoryCreateFile_InTask_PropertyAddress, ScriptFactoryCreateFile_FunctionAddress, "InTask");
		ScriptFactoryCreateFile_InTask_Offset = NativeReflectionCached.GetPropertyOffset(ScriptFactoryCreateFile_FunctionAddress, "InTask");
		ScriptFactoryCreateFile_InTask_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptFactoryCreateFile_FunctionAddress, "InTask", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptFactoryCreateFile_ReturnValue_PropertyAddress, ScriptFactoryCreateFile_FunctionAddress, "ReturnValue");
		ScriptFactoryCreateFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptFactoryCreateFile_FunctionAddress, "ReturnValue");
		ScriptFactoryCreateFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptFactoryCreateFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptFactoryCreateFile_IsValid = ScriptFactoryCreateFile_FunctionAddress != IntPtr.Zero && ScriptFactoryCreateFile_InTask_IsValid && ScriptFactoryCreateFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.Factory:ScriptFactoryCreateFile", ScriptFactoryCreateFile_IsValid);
		ScriptFactoryCanImport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScriptFactoryCanImport");
		ScriptFactoryCanImport_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptFactoryCanImport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptFactoryCanImport_Filename_PropertyAddress, ScriptFactoryCanImport_FunctionAddress, "Filename");
		ScriptFactoryCanImport_Filename_Offset = NativeReflectionCached.GetPropertyOffset(ScriptFactoryCanImport_FunctionAddress, "Filename");
		ScriptFactoryCanImport_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptFactoryCanImport_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptFactoryCanImport_ReturnValue_PropertyAddress, ScriptFactoryCanImport_FunctionAddress, "ReturnValue");
		ScriptFactoryCanImport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptFactoryCanImport_FunctionAddress, "ReturnValue");
		ScriptFactoryCanImport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptFactoryCanImport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptFactoryCanImport_IsValid = ScriptFactoryCanImport_FunctionAddress != IntPtr.Zero && ScriptFactoryCanImport_Filename_IsValid && ScriptFactoryCanImport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.Factory:ScriptFactoryCanImport", ScriptFactoryCanImport_IsValid);
	}
}
