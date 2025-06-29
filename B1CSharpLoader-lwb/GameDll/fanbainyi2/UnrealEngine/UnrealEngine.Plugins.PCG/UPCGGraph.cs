using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGGraph", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGraph : UPCGGraphInterface
{
	private static bool ExposeToLibrary_IsValid;

	private static FFieldAddress ExposeToLibrary_PropertyAddress;

	private static int ExposeToLibrary_Offset;

	private static bool Category_IsValid;

	private static int Category_Offset;

	private FText Category_TextCached;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private FText Description_TextCached;

	private static bool Nodes_IsValid;

	private static FFieldAddress Nodes_PropertyAddress;

	private static int Nodes_Offset;

	private TArrayReadOnlyMarshaler<UPCGNode> Nodes_MarshalerCached;

	private static bool InputNode_IsValid;

	private static int InputNode_Offset;

	private static bool OutputNode_IsValid;

	private static int OutputNode_Offset;

	private static bool RemoveNode_IsValid;

	private static IntPtr RemoveNode_FunctionAddress;

	private static int RemoveNode_ParamsSize;

	private static bool RemoveNode_InNode_IsValid;

	private static FFieldAddress RemoveNode_InNode_PropertyAddress;

	private static int RemoveNode_InNode_Offset;

	private static bool RemoveEdge_IsValid;

	private static IntPtr RemoveEdge_FunctionAddress;

	private static int RemoveEdge_ParamsSize;

	private static bool RemoveEdge_From_IsValid;

	private static FFieldAddress RemoveEdge_From_PropertyAddress;

	private static int RemoveEdge_From_Offset;

	private static bool RemoveEdge_FromLabel_IsValid;

	private static FFieldAddress RemoveEdge_FromLabel_PropertyAddress;

	private static int RemoveEdge_FromLabel_Offset;

	private static bool RemoveEdge_To_IsValid;

	private static FFieldAddress RemoveEdge_To_PropertyAddress;

	private static int RemoveEdge_To_Offset;

	private static bool RemoveEdge_ToLabel_IsValid;

	private static FFieldAddress RemoveEdge_ToLabel_PropertyAddress;

	private static int RemoveEdge_ToLabel_Offset;

	private static bool RemoveEdge_ReturnValue_IsValid;

	private static FFieldAddress RemoveEdge_ReturnValue_PropertyAddress;

	private static int RemoveEdge_ReturnValue_Offset;

	private static bool GetOutputNode_IsValid;

	private static IntPtr GetOutputNode_FunctionAddress;

	private static int GetOutputNode_ParamsSize;

	private static bool GetOutputNode_ReturnValue_IsValid;

	private static FFieldAddress GetOutputNode_ReturnValue_PropertyAddress;

	private static int GetOutputNode_ReturnValue_Offset;

	private static bool GetInputNode_IsValid;

	private static IntPtr GetInputNode_FunctionAddress;

	private static int GetInputNode_ParamsSize;

	private static bool GetInputNode_ReturnValue_IsValid;

	private static FFieldAddress GetInputNode_ReturnValue_PropertyAddress;

	private static int GetInputNode_ReturnValue_Offset;

	private static bool ForceNotificationForEditor_IsValid;

	private static IntPtr ForceNotificationForEditor_FunctionAddress;

	private static int ForceNotificationForEditor_ParamsSize;

	private static bool AddNodeOfType_IsValid;

	private static IntPtr AddNodeOfType_FunctionAddress;

	private static int AddNodeOfType_ParamsSize;

	private static bool AddNodeOfType_InSettingsClass_IsValid;

	private static FFieldAddress AddNodeOfType_InSettingsClass_PropertyAddress;

	private static int AddNodeOfType_InSettingsClass_Offset;

	private static bool AddNodeOfType_DefaultNodeSettings_IsValid;

	private static FFieldAddress AddNodeOfType_DefaultNodeSettings_PropertyAddress;

	private static int AddNodeOfType_DefaultNodeSettings_Offset;

	private static bool AddNodeOfType_ReturnValue_IsValid;

	private static FFieldAddress AddNodeOfType_ReturnValue_PropertyAddress;

	private static int AddNodeOfType_ReturnValue_Offset;

	private static bool AddNodeInstance_IsValid;

	private static IntPtr AddNodeInstance_FunctionAddress;

	private static int AddNodeInstance_ParamsSize;

	private static bool AddNodeInstance_InSettings_IsValid;

	private static FFieldAddress AddNodeInstance_InSettings_PropertyAddress;

	private static int AddNodeInstance_InSettings_Offset;

	private static bool AddNodeInstance_ReturnValue_IsValid;

	private static FFieldAddress AddNodeInstance_ReturnValue_PropertyAddress;

	private static int AddNodeInstance_ReturnValue_Offset;

	private static bool AddNodeCopy_IsValid;

	private static IntPtr AddNodeCopy_FunctionAddress;

	private static int AddNodeCopy_ParamsSize;

	private static bool AddNodeCopy_InSettings_IsValid;

	private static FFieldAddress AddNodeCopy_InSettings_PropertyAddress;

	private static int AddNodeCopy_InSettings_Offset;

	private static bool AddNodeCopy_DefaultNodeSettings_IsValid;

	private static FFieldAddress AddNodeCopy_DefaultNodeSettings_PropertyAddress;

	private static int AddNodeCopy_DefaultNodeSettings_Offset;

	private static bool AddNodeCopy_ReturnValue_IsValid;

	private static FFieldAddress AddNodeCopy_ReturnValue_PropertyAddress;

	private static int AddNodeCopy_ReturnValue_Offset;

	private static bool AddEdge_IsValid;

	private static IntPtr AddEdge_FunctionAddress;

	private static int AddEdge_ParamsSize;

	private static bool AddEdge_From_IsValid;

	private static FFieldAddress AddEdge_From_PropertyAddress;

	private static int AddEdge_From_Offset;

	private static bool AddEdge_FromPinLabel_IsValid;

	private static FFieldAddress AddEdge_FromPinLabel_PropertyAddress;

	private static int AddEdge_FromPinLabel_Offset;

	private static bool AddEdge_To_IsValid;

	private static FFieldAddress AddEdge_To_PropertyAddress;

	private static int AddEdge_To_Offset;

	private static bool AddEdge_ToPinLabel_IsValid;

	private static FFieldAddress AddEdge_ToPinLabel_PropertyAddress;

	private static int AddEdge_ToPinLabel_Offset;

	private static bool AddEdge_ReturnValue_IsValid;

	private static FFieldAddress AddEdge_ReturnValue_PropertyAddress;

	private static int AddEdge_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6756603105640965uL)]
	[UMetaPath("/Script/PCG.PCGGraph:bExposeToLibrary")]
	public bool ExposeToLibrary
	{
		get
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:bExposeToLibrary");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:bExposeToLibrary");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504733498736645uL)]
	[UMetaPath("/Script/PCG.PCGGraph:Category")]
	public FText Category
	{
		get
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:Category");
				return null;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			return Category_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:Category");
				return;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			Category_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4504733498736645uL)]
	[UMetaPath("/Script/PCG.PCGGraph:Description")]
	public FText Description
	{
		get
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:Description");
				return null;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			return Description_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:Description");
				return;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			Description_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)10141895254737429uL)]
	[UMetaPath("/Script/PCG.PCGGraph:Nodes")]
	protected TArrayReadOnly<UPCGNode> Nodes
	{
		get
		{
			CheckDestroyed();
			if (!Nodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:Nodes");
				return null;
			}
			if (Nodes_MarshalerCached == null)
			{
				Nodes_MarshalerCached = new TArrayReadOnlyMarshaler<UPCGNode>(1, Nodes_PropertyAddress, CachedMarshalingDelegates<UPCGNode, UObjectMarshaler<UPCGNode>>.FromNative, CachedMarshalingDelegates<UPCGNode, UObjectMarshaler<UPCGNode>>.ToNative);
			}
			return Nodes_MarshalerCached.FromNative(IntPtr.Add(base.Address, Nodes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGGraph:InputNode")]
	protected UPCGNode InputNode
	{
		get
		{
			CheckDestroyed();
			if (!InputNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:InputNode");
				return null;
			}
			return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(base.Address, InputNode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:InputNode");
			}
			else
			{
				UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(base.Address, InputNode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGGraph:OutputNode")]
	protected UPCGNode OutputNode
	{
		get
		{
			CheckDestroyed();
			if (!OutputNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:OutputNode");
				return null;
			}
			return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(base.Address, OutputNode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraph:OutputNode");
			}
			else
			{
				UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(base.Address, OutputNode_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGGraph:RemoveNode")]
	public unsafe void RemoveNode(UPCGNode InNode)
	{
		CheckDestroyed();
		if (!RemoveNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:RemoveNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, RemoveNode_InNode_Offset), 0, RemoveNode_InNode_PropertyAddress.Address, InNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveNode_FunctionAddress, intPtr, RemoveNode_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGGraph:RemoveEdge")]
	public unsafe bool RemoveEdge(UPCGNode From, FName FromLabel, UPCGNode To, FName ToLabel)
	{
		CheckDestroyed();
		if (!RemoveEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:RemoveEdge");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, RemoveEdge_From_Offset), 0, RemoveEdge_From_PropertyAddress.Address, From);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveEdge_FromLabel_Offset), 0, RemoveEdge_FromLabel_PropertyAddress.Address, FromLabel);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, RemoveEdge_To_Offset), 0, RemoveEdge_To_PropertyAddress.Address, To);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveEdge_ToLabel_Offset), 0, RemoveEdge_ToLabel_PropertyAddress.Address, ToLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveEdge_FunctionAddress, intPtr, RemoveEdge_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveEdge_ReturnValue_Offset), 0, RemoveEdge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGGraph:GetOutputNode")]
	public unsafe UPCGNode GetOutputNode()
	{
		CheckDestroyed();
		if (!GetOutputNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:GetOutputNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputNode_FunctionAddress, intPtr, GetOutputNode_ParamsSize);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, GetOutputNode_ReturnValue_Offset), 0, GetOutputNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGGraph:GetInputNode")]
	public unsafe UPCGNode GetInputNode()
	{
		CheckDestroyed();
		if (!GetInputNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:GetInputNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputNode_FunctionAddress, intPtr, GetInputNode_ParamsSize);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, GetInputNode_ReturnValue_Offset), 0, GetInputNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/PCG.PCGGraph:ForceNotificationForEditor")]
	public unsafe void ForceNotificationForEditor()
	{
		CheckDestroyed();
		if (!ForceNotificationForEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:ForceNotificationForEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceNotificationForEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceNotificationForEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceNotificationForEditor_FunctionAddress, argsSize: ForceNotificationForEditor_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGGraph:AddNodeOfType")]
	public unsafe UPCGNode AddNodeOfType(TSubclassOf<UPCGSettings> InSettingsClass, out UPCGSettings DefaultNodeSettings)
	{
		CheckDestroyed();
		if (!AddNodeOfType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:AddNodeOfType");
			DefaultNodeSettings = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNodeOfType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNodeOfType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UPCGSettings>.ToNative(IntPtr.Add(intPtr, AddNodeOfType_InSettingsClass_Offset), 0, AddNodeOfType_InSettingsClass_PropertyAddress.Address, InSettingsClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNodeOfType_FunctionAddress, intPtr, AddNodeOfType_ParamsSize);
		DefaultNodeSettings = UObjectMarshaler<UPCGSettings>.FromNative(IntPtr.Add(intPtr, AddNodeOfType_DefaultNodeSettings_Offset), 0, AddNodeOfType_DefaultNodeSettings_PropertyAddress.Address);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, AddNodeOfType_ReturnValue_Offset), 0, AddNodeOfType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGGraph:AddNodeInstance")]
	public unsafe UPCGNode AddNodeInstance(UPCGSettings InSettings)
	{
		CheckDestroyed();
		if (!AddNodeInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:AddNodeInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNodeInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNodeInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSettings>.ToNative(IntPtr.Add(intPtr, AddNodeInstance_InSettings_Offset), 0, AddNodeInstance_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNodeInstance_FunctionAddress, intPtr, AddNodeInstance_ParamsSize);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, AddNodeInstance_ReturnValue_Offset), 0, AddNodeInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGGraph:AddNodeCopy")]
	public unsafe UPCGNode AddNodeCopy(UPCGSettings InSettings, out UPCGSettings DefaultNodeSettings)
	{
		CheckDestroyed();
		if (!AddNodeCopy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:AddNodeCopy");
			DefaultNodeSettings = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNodeCopy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNodeCopy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSettings>.ToNative(IntPtr.Add(intPtr, AddNodeCopy_InSettings_Offset), 0, AddNodeCopy_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNodeCopy_FunctionAddress, intPtr, AddNodeCopy_ParamsSize);
		DefaultNodeSettings = UObjectMarshaler<UPCGSettings>.FromNative(IntPtr.Add(intPtr, AddNodeCopy_DefaultNodeSettings_Offset), 0, AddNodeCopy_DefaultNodeSettings_PropertyAddress.Address);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, AddNodeCopy_ReturnValue_Offset), 0, AddNodeCopy_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGGraph:AddEdge")]
	public unsafe UPCGNode AddEdge(UPCGNode From, FName FromPinLabel, UPCGNode To, FName ToPinLabel)
	{
		CheckDestroyed();
		if (!AddEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraph:AddEdge");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, AddEdge_From_Offset), 0, AddEdge_From_PropertyAddress.Address, From);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddEdge_FromPinLabel_Offset), 0, AddEdge_FromPinLabel_PropertyAddress.Address, FromPinLabel);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, AddEdge_To_Offset), 0, AddEdge_To_PropertyAddress.Address, To);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddEdge_ToPinLabel_Offset), 0, AddEdge_ToPinLabel_PropertyAddress.Address, ToPinLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEdge_FunctionAddress, intPtr, AddEdge_ParamsSize);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, AddEdge_ReturnValue_Offset), 0, AddEdge_ReturnValue_PropertyAddress.Address);
	}

	static UPCGGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGGraph");
		NativeReflectionCached.GetPropertyRef(ref ExposeToLibrary_PropertyAddress, intPtr, "bExposeToLibrary");
		ExposeToLibrary_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExposeToLibrary");
		ExposeToLibrary_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExposeToLibrary", Classes.FBoolProperty);
		Category_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Category");
		Category_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Category", Classes.FTextProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref Nodes_PropertyAddress, intPtr, "Nodes");
		Nodes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Nodes");
		Nodes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Nodes", Classes.FArrayProperty);
		InputNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputNode");
		InputNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputNode", Classes.FObjectProperty);
		OutputNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputNode");
		OutputNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputNode", Classes.FObjectProperty);
		RemoveNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveNode");
		RemoveNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_InNode_PropertyAddress, RemoveNode_FunctionAddress, "InNode");
		RemoveNode_InNode_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "InNode");
		RemoveNode_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "InNode", Classes.FObjectProperty);
		RemoveNode_IsValid = RemoveNode_FunctionAddress != IntPtr.Zero && RemoveNode_InNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:RemoveNode", RemoveNode_IsValid);
		RemoveEdge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveEdge");
		RemoveEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdge_From_PropertyAddress, RemoveEdge_FunctionAddress, "From");
		RemoveEdge_From_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdge_FunctionAddress, "From");
		RemoveEdge_From_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdge_FunctionAddress, "From", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdge_FromLabel_PropertyAddress, RemoveEdge_FunctionAddress, "FromLabel");
		RemoveEdge_FromLabel_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdge_FunctionAddress, "FromLabel");
		RemoveEdge_FromLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdge_FunctionAddress, "FromLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdge_To_PropertyAddress, RemoveEdge_FunctionAddress, "To");
		RemoveEdge_To_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdge_FunctionAddress, "To");
		RemoveEdge_To_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdge_FunctionAddress, "To", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdge_ToLabel_PropertyAddress, RemoveEdge_FunctionAddress, "ToLabel");
		RemoveEdge_ToLabel_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdge_FunctionAddress, "ToLabel");
		RemoveEdge_ToLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdge_FunctionAddress, "ToLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdge_ReturnValue_PropertyAddress, RemoveEdge_FunctionAddress, "ReturnValue");
		RemoveEdge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdge_FunctionAddress, "ReturnValue");
		RemoveEdge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdge_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveEdge_IsValid = RemoveEdge_FunctionAddress != IntPtr.Zero && RemoveEdge_From_IsValid && RemoveEdge_FromLabel_IsValid && RemoveEdge_To_IsValid && RemoveEdge_ToLabel_IsValid && RemoveEdge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:RemoveEdge", RemoveEdge_IsValid);
		GetOutputNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOutputNode");
		GetOutputNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputNode_ReturnValue_PropertyAddress, GetOutputNode_FunctionAddress, "ReturnValue");
		GetOutputNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputNode_FunctionAddress, "ReturnValue");
		GetOutputNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOutputNode_IsValid = GetOutputNode_FunctionAddress != IntPtr.Zero && GetOutputNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:GetOutputNode", GetOutputNode_IsValid);
		GetInputNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputNode");
		GetInputNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputNode_ReturnValue_PropertyAddress, GetInputNode_FunctionAddress, "ReturnValue");
		GetInputNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputNode_FunctionAddress, "ReturnValue");
		GetInputNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInputNode_IsValid = GetInputNode_FunctionAddress != IntPtr.Zero && GetInputNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:GetInputNode", GetInputNode_IsValid);
		ForceNotificationForEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceNotificationForEditor");
		ForceNotificationForEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceNotificationForEditor_FunctionAddress);
		ForceNotificationForEditor_IsValid = ForceNotificationForEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:ForceNotificationForEditor", ForceNotificationForEditor_IsValid);
		AddNodeOfType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddNodeOfType");
		AddNodeOfType_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNodeOfType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNodeOfType_InSettingsClass_PropertyAddress, AddNodeOfType_FunctionAddress, "InSettingsClass");
		AddNodeOfType_InSettingsClass_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeOfType_FunctionAddress, "InSettingsClass");
		AddNodeOfType_InSettingsClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeOfType_FunctionAddress, "InSettingsClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNodeOfType_DefaultNodeSettings_PropertyAddress, AddNodeOfType_FunctionAddress, "DefaultNodeSettings");
		AddNodeOfType_DefaultNodeSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeOfType_FunctionAddress, "DefaultNodeSettings");
		AddNodeOfType_DefaultNodeSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeOfType_FunctionAddress, "DefaultNodeSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNodeOfType_ReturnValue_PropertyAddress, AddNodeOfType_FunctionAddress, "ReturnValue");
		AddNodeOfType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeOfType_FunctionAddress, "ReturnValue");
		AddNodeOfType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeOfType_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNodeOfType_IsValid = AddNodeOfType_FunctionAddress != IntPtr.Zero && AddNodeOfType_InSettingsClass_IsValid && AddNodeOfType_DefaultNodeSettings_IsValid && AddNodeOfType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:AddNodeOfType", AddNodeOfType_IsValid);
		AddNodeInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddNodeInstance");
		AddNodeInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNodeInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNodeInstance_InSettings_PropertyAddress, AddNodeInstance_FunctionAddress, "InSettings");
		AddNodeInstance_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeInstance_FunctionAddress, "InSettings");
		AddNodeInstance_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeInstance_FunctionAddress, "InSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNodeInstance_ReturnValue_PropertyAddress, AddNodeInstance_FunctionAddress, "ReturnValue");
		AddNodeInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeInstance_FunctionAddress, "ReturnValue");
		AddNodeInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNodeInstance_IsValid = AddNodeInstance_FunctionAddress != IntPtr.Zero && AddNodeInstance_InSettings_IsValid && AddNodeInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:AddNodeInstance", AddNodeInstance_IsValid);
		AddNodeCopy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddNodeCopy");
		AddNodeCopy_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNodeCopy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNodeCopy_InSettings_PropertyAddress, AddNodeCopy_FunctionAddress, "InSettings");
		AddNodeCopy_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeCopy_FunctionAddress, "InSettings");
		AddNodeCopy_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeCopy_FunctionAddress, "InSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNodeCopy_DefaultNodeSettings_PropertyAddress, AddNodeCopy_FunctionAddress, "DefaultNodeSettings");
		AddNodeCopy_DefaultNodeSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeCopy_FunctionAddress, "DefaultNodeSettings");
		AddNodeCopy_DefaultNodeSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeCopy_FunctionAddress, "DefaultNodeSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNodeCopy_ReturnValue_PropertyAddress, AddNodeCopy_FunctionAddress, "ReturnValue");
		AddNodeCopy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNodeCopy_FunctionAddress, "ReturnValue");
		AddNodeCopy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNodeCopy_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNodeCopy_IsValid = AddNodeCopy_FunctionAddress != IntPtr.Zero && AddNodeCopy_InSettings_IsValid && AddNodeCopy_DefaultNodeSettings_IsValid && AddNodeCopy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:AddNodeCopy", AddNodeCopy_IsValid);
		AddEdge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddEdge");
		AddEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEdge_From_PropertyAddress, AddEdge_FunctionAddress, "From");
		AddEdge_From_Offset = NativeReflectionCached.GetPropertyOffset(AddEdge_FunctionAddress, "From");
		AddEdge_From_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdge_FunctionAddress, "From", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdge_FromPinLabel_PropertyAddress, AddEdge_FunctionAddress, "FromPinLabel");
		AddEdge_FromPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddEdge_FunctionAddress, "FromPinLabel");
		AddEdge_FromPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdge_FunctionAddress, "FromPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdge_To_PropertyAddress, AddEdge_FunctionAddress, "To");
		AddEdge_To_Offset = NativeReflectionCached.GetPropertyOffset(AddEdge_FunctionAddress, "To");
		AddEdge_To_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdge_FunctionAddress, "To", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdge_ToPinLabel_PropertyAddress, AddEdge_FunctionAddress, "ToPinLabel");
		AddEdge_ToPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddEdge_FunctionAddress, "ToPinLabel");
		AddEdge_ToPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdge_FunctionAddress, "ToPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdge_ReturnValue_PropertyAddress, AddEdge_FunctionAddress, "ReturnValue");
		AddEdge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEdge_FunctionAddress, "ReturnValue");
		AddEdge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdge_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddEdge_IsValid = AddEdge_FunctionAddress != IntPtr.Zero && AddEdge_From_IsValid && AddEdge_FromPinLabel_IsValid && AddEdge_To_IsValid && AddEdge_ToPinLabel_IsValid && AddEdge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraph:AddEdge", AddEdge_IsValid);
	}
}
