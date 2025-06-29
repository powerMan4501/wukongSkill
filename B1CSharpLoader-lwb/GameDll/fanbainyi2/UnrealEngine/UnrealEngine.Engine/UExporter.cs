using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810025129uL, Config = "Engine")]
[UMetaPath("/Script/Engine.Exporter", "Engine", UnrealModuleType.Engine)]
public class UExporter : UObject
{
	private static IntPtr classAddress;

	private static bool SupportedClass_IsValid;

	private static int SupportedClass_Offset;

	private static bool FormatExtension_IsValid;

	private static FFieldAddress FormatExtension_PropertyAddress;

	private static int FormatExtension_Offset;

	private TArrayReadWriteMarshaler<string> FormatExtension_MarshalerCached;

	private static bool FormatDescription_IsValid;

	private static FFieldAddress FormatDescription_PropertyAddress;

	private static int FormatDescription_Offset;

	private TArrayReadWriteMarshaler<string> FormatDescription_MarshalerCached;

	private static bool Text_IsValid;

	private static FFieldAddress Text_PropertyAddress;

	private static int Text_Offset;

	private static bool ExportTask_IsValid;

	private static int ExportTask_Offset;

	private static bool ScriptRunAssetExportTask_IsValid;

	private IntPtr ScriptRunAssetExportTask_InstanceFunctionAddress;

	private static IntPtr ScriptRunAssetExportTask_FunctionAddress;

	private static int ScriptRunAssetExportTask_ParamsSize;

	private static bool ScriptRunAssetExportTask_Task_IsValid;

	private static FFieldAddress ScriptRunAssetExportTask_Task_PropertyAddress;

	private static int ScriptRunAssetExportTask_Task_Offset;

	private static bool ScriptRunAssetExportTask_ReturnValue_IsValid;

	private static FFieldAddress ScriptRunAssetExportTask_ReturnValue_PropertyAddress;

	private static int ScriptRunAssetExportTask_ReturnValue_Offset;

	private static bool RunAssetExportTasks_IsValid;

	private static IntPtr RunAssetExportTasks_FunctionAddress;

	private static int RunAssetExportTasks_ParamsSize;

	private static bool RunAssetExportTasks_ExportTasks_IsValid;

	private static FFieldAddress RunAssetExportTasks_ExportTasks_PropertyAddress;

	private static int RunAssetExportTasks_ExportTasks_Offset;

	private static bool RunAssetExportTasks_ReturnValue_IsValid;

	private static FFieldAddress RunAssetExportTasks_ReturnValue_PropertyAddress;

	private static int RunAssetExportTasks_ReturnValue_Offset;

	private static bool RunAssetExportTask_IsValid;

	private static IntPtr RunAssetExportTask_FunctionAddress;

	private static int RunAssetExportTask_ParamsSize;

	private static bool RunAssetExportTask_Task_IsValid;

	private static FFieldAddress RunAssetExportTask_Task_PropertyAddress;

	private static int RunAssetExportTask_Task_Offset;

	private static bool RunAssetExportTask_ReturnValue_IsValid;

	private static FFieldAddress RunAssetExportTask_ReturnValue_PropertyAddress;

	private static int RunAssetExportTask_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.Exporter:SupportedClass")]
	public TSubclassOf<UObject> SupportedClass
	{
		get
		{
			CheckDestroyed();
			if (!SupportedClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:SupportedClass");
				return default(TSubclassOf<UObject>);
			}
			return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, SupportedClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SupportedClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:SupportedClass");
			}
			else
			{
				TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, SupportedClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Engine.Exporter:FormatExtension")]
	public TArrayReadWrite<string> FormatExtension
	{
		get
		{
			CheckDestroyed();
			if (!FormatExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:FormatExtension");
				return null;
			}
			if (FormatExtension_MarshalerCached == null)
			{
				FormatExtension_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, FormatExtension_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return FormatExtension_MarshalerCached.FromNative(IntPtr.Add(base.Address, FormatExtension_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Engine.Exporter:FormatDescription")]
	public TArrayReadWrite<string> FormatDescription
	{
		get
		{
			CheckDestroyed();
			if (!FormatDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:FormatDescription");
				return null;
			}
			if (FormatDescription_MarshalerCached == null)
			{
				FormatDescription_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, FormatDescription_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return FormatDescription_MarshalerCached.FromNative(IntPtr.Add(base.Address, FormatDescription_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.Exporter:bText")]
	public bool Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:bText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Text_Offset), 0, Text_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:bText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Text_Offset), 0, Text_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.Exporter:ExportTask")]
	public UAssetExportTask ExportTask
	{
		get
		{
			CheckDestroyed();
			if (!ExportTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:ExportTask");
				return null;
			}
			return UObjectMarshaler<UAssetExportTask>.FromNative(IntPtr.Add(base.Address, ExportTask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExportTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Exporter:ExportTask");
			}
			else
			{
				UObjectMarshaler<UAssetExportTask>.ToNative(IntPtr.Add(base.Address, ExportTask_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Exporter:ScriptRunAssetExportTask")]
	public unsafe bool ScriptRunAssetExportTask(UAssetExportTask Task)
	{
		CheckDestroyed();
		if (!ScriptRunAssetExportTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Exporter:ScriptRunAssetExportTask");
			return false;
		}
		if (ScriptRunAssetExportTask_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptRunAssetExportTask_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptRunAssetExportTask");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptRunAssetExportTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptRunAssetExportTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetExportTask>.ToNative(IntPtr.Add(intPtr, ScriptRunAssetExportTask_Task_Offset), 0, ScriptRunAssetExportTask_Task_PropertyAddress.Address, Task);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptRunAssetExportTask_InstanceFunctionAddress, intPtr, ScriptRunAssetExportTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptRunAssetExportTask_ReturnValue_Offset), 0, ScriptRunAssetExportTask_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptRunAssetExportTask_Implementation(UAssetExportTask Task)
	{
		CheckDestroyed();
		if (!ScriptRunAssetExportTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Exporter:ScriptRunAssetExportTask");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptRunAssetExportTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptRunAssetExportTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetExportTask>.ToNative(IntPtr.Add(intPtr, ScriptRunAssetExportTask_Task_Offset), 0, ScriptRunAssetExportTask_Task_PropertyAddress.Address, Task);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptRunAssetExportTask_FunctionAddress, intPtr, ScriptRunAssetExportTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptRunAssetExportTask_ReturnValue_Offset), 0, ScriptRunAssetExportTask_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.Exporter:RunAssetExportTasks")]
	public unsafe static bool RunAssetExportTasks(List<UAssetExportTask> ExportTasks)
	{
		if (!RunAssetExportTasks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Exporter:RunAssetExportTasks");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunAssetExportTasks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunAssetExportTasks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAssetExportTask>(1, RunAssetExportTasks_ExportTasks_PropertyAddress, CachedMarshalingDelegates<UAssetExportTask, UObjectMarshaler<UAssetExportTask>>.FromNative, CachedMarshalingDelegates<UAssetExportTask, UObjectMarshaler<UAssetExportTask>>.ToNative).ToNative(IntPtr.Add(intPtr, RunAssetExportTasks_ExportTasks_Offset), ExportTasks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunAssetExportTasks_FunctionAddress, intPtr, RunAssetExportTasks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunAssetExportTasks_ExportTasks_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RunAssetExportTasks_ReturnValue_Offset), 0, RunAssetExportTasks_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.Exporter:RunAssetExportTask")]
	public unsafe static bool RunAssetExportTask(UAssetExportTask Task)
	{
		if (!RunAssetExportTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Exporter:RunAssetExportTask");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunAssetExportTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunAssetExportTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetExportTask>.ToNative(IntPtr.Add(intPtr, RunAssetExportTask_Task_Offset), 0, RunAssetExportTask_Task_PropertyAddress.Address, Task);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunAssetExportTask_FunctionAddress, intPtr, RunAssetExportTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RunAssetExportTask_ReturnValue_Offset), 0, RunAssetExportTask_ReturnValue_PropertyAddress.Address);
	}

	static UExporter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UExporter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UExporter));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.Exporter");
		SupportedClass_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "SupportedClass");
		SupportedClass_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "SupportedClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FormatExtension_PropertyAddress, classAddress, "FormatExtension");
		FormatExtension_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "FormatExtension");
		FormatExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "FormatExtension", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FormatDescription_PropertyAddress, classAddress, "FormatDescription");
		FormatDescription_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "FormatDescription");
		FormatDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "FormatDescription", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Text_PropertyAddress, classAddress, "bText");
		Text_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bText");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bText", Classes.FBoolProperty);
		ExportTask_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ExportTask");
		ExportTask_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ExportTask", Classes.FObjectProperty);
		ScriptRunAssetExportTask_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScriptRunAssetExportTask");
		ScriptRunAssetExportTask_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptRunAssetExportTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptRunAssetExportTask_Task_PropertyAddress, ScriptRunAssetExportTask_FunctionAddress, "Task");
		ScriptRunAssetExportTask_Task_Offset = NativeReflectionCached.GetPropertyOffset(ScriptRunAssetExportTask_FunctionAddress, "Task");
		ScriptRunAssetExportTask_Task_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptRunAssetExportTask_FunctionAddress, "Task", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptRunAssetExportTask_ReturnValue_PropertyAddress, ScriptRunAssetExportTask_FunctionAddress, "ReturnValue");
		ScriptRunAssetExportTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptRunAssetExportTask_FunctionAddress, "ReturnValue");
		ScriptRunAssetExportTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptRunAssetExportTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptRunAssetExportTask_IsValid = ScriptRunAssetExportTask_FunctionAddress != IntPtr.Zero && ScriptRunAssetExportTask_Task_IsValid && ScriptRunAssetExportTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Exporter:ScriptRunAssetExportTask", ScriptRunAssetExportTask_IsValid);
		RunAssetExportTasks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunAssetExportTasks");
		RunAssetExportTasks_ParamsSize = NativeReflection.GetFunctionParamsSize(RunAssetExportTasks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunAssetExportTasks_ExportTasks_PropertyAddress, RunAssetExportTasks_FunctionAddress, "ExportTasks");
		RunAssetExportTasks_ExportTasks_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetExportTasks_FunctionAddress, "ExportTasks");
		RunAssetExportTasks_ExportTasks_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetExportTasks_FunctionAddress, "ExportTasks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAssetExportTasks_ReturnValue_PropertyAddress, RunAssetExportTasks_FunctionAddress, "ReturnValue");
		RunAssetExportTasks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetExportTasks_FunctionAddress, "ReturnValue");
		RunAssetExportTasks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetExportTasks_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunAssetExportTasks_IsValid = RunAssetExportTasks_FunctionAddress != IntPtr.Zero && RunAssetExportTasks_ExportTasks_IsValid && RunAssetExportTasks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Exporter:RunAssetExportTasks", RunAssetExportTasks_IsValid);
		RunAssetExportTask_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunAssetExportTask");
		RunAssetExportTask_ParamsSize = NativeReflection.GetFunctionParamsSize(RunAssetExportTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunAssetExportTask_Task_PropertyAddress, RunAssetExportTask_FunctionAddress, "Task");
		RunAssetExportTask_Task_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetExportTask_FunctionAddress, "Task");
		RunAssetExportTask_Task_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetExportTask_FunctionAddress, "Task", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAssetExportTask_ReturnValue_PropertyAddress, RunAssetExportTask_FunctionAddress, "ReturnValue");
		RunAssetExportTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetExportTask_FunctionAddress, "ReturnValue");
		RunAssetExportTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetExportTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunAssetExportTask_IsValid = RunAssetExportTask_FunctionAddress != IntPtr.Zero && RunAssetExportTask_Task_IsValid && RunAssetExportTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Exporter:RunAssetExportTask", RunAssetExportTask_IsValid);
	}
}
