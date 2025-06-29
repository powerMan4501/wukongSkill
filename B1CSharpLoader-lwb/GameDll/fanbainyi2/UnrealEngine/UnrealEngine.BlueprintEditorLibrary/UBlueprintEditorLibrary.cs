using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintEditorLibrary;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary", "BlueprintEditorLibrary", UnrealModuleType.Engine)]
public class UBlueprintEditorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpgradeOperatorNodes_IsValid;

	private static IntPtr UpgradeOperatorNodes_FunctionAddress;

	private static int UpgradeOperatorNodes_ParamsSize;

	private static bool UpgradeOperatorNodes_Blueprint_IsValid;

	private static FFieldAddress UpgradeOperatorNodes_Blueprint_PropertyAddress;

	private static int UpgradeOperatorNodes_Blueprint_Offset;

	private static bool ReplaceVariableReferences_IsValid;

	private static IntPtr ReplaceVariableReferences_FunctionAddress;

	private static int ReplaceVariableReferences_ParamsSize;

	private static bool ReplaceVariableReferences_Blueprint_IsValid;

	private static FFieldAddress ReplaceVariableReferences_Blueprint_PropertyAddress;

	private static int ReplaceVariableReferences_Blueprint_Offset;

	private static bool ReplaceVariableReferences_OldVarName_IsValid;

	private static FFieldAddress ReplaceVariableReferences_OldVarName_PropertyAddress;

	private static int ReplaceVariableReferences_OldVarName_Offset;

	private static bool ReplaceVariableReferences_NewVarName_IsValid;

	private static FFieldAddress ReplaceVariableReferences_NewVarName_PropertyAddress;

	private static int ReplaceVariableReferences_NewVarName_Offset;

	private static bool ReparentBlueprint_IsValid;

	private static IntPtr ReparentBlueprint_FunctionAddress;

	private static int ReparentBlueprint_ParamsSize;

	private static bool ReparentBlueprint_Blueprint_IsValid;

	private static FFieldAddress ReparentBlueprint_Blueprint_PropertyAddress;

	private static int ReparentBlueprint_Blueprint_Offset;

	private static bool ReparentBlueprint_NewParentClass_IsValid;

	private static FFieldAddress ReparentBlueprint_NewParentClass_PropertyAddress;

	private static int ReparentBlueprint_NewParentClass_Offset;

	private static bool RenameGraph_IsValid;

	private static IntPtr RenameGraph_FunctionAddress;

	private static int RenameGraph_ParamsSize;

	private static bool RenameGraph_Graph_IsValid;

	private static FFieldAddress RenameGraph_Graph_PropertyAddress;

	private static int RenameGraph_Graph_Offset;

	private static bool RenameGraph_NewNameStr_IsValid;

	private static FFieldAddress RenameGraph_NewNameStr_PropertyAddress;

	private static int RenameGraph_NewNameStr_Offset;

	private static bool RemoveUnusedVariables_IsValid;

	private static IntPtr RemoveUnusedVariables_FunctionAddress;

	private static int RemoveUnusedVariables_ParamsSize;

	private static bool RemoveUnusedVariables_Blueprint_IsValid;

	private static FFieldAddress RemoveUnusedVariables_Blueprint_PropertyAddress;

	private static int RemoveUnusedVariables_Blueprint_Offset;

	private static bool RemoveUnusedVariables_ReturnValue_IsValid;

	private static FFieldAddress RemoveUnusedVariables_ReturnValue_PropertyAddress;

	private static int RemoveUnusedVariables_ReturnValue_Offset;

	private static bool RemoveUnusedNodes_IsValid;

	private static IntPtr RemoveUnusedNodes_FunctionAddress;

	private static int RemoveUnusedNodes_ParamsSize;

	private static bool RemoveUnusedNodes_Blueprint_IsValid;

	private static FFieldAddress RemoveUnusedNodes_Blueprint_PropertyAddress;

	private static int RemoveUnusedNodes_Blueprint_Offset;

	private static bool RemoveGraph_IsValid;

	private static IntPtr RemoveGraph_FunctionAddress;

	private static int RemoveGraph_ParamsSize;

	private static bool RemoveGraph_Blueprint_IsValid;

	private static FFieldAddress RemoveGraph_Blueprint_PropertyAddress;

	private static int RemoveGraph_Blueprint_Offset;

	private static bool RemoveGraph_Graph_IsValid;

	private static FFieldAddress RemoveGraph_Graph_PropertyAddress;

	private static int RemoveGraph_Graph_Offset;

	private static bool RemoveFunctionGraph_IsValid;

	private static IntPtr RemoveFunctionGraph_FunctionAddress;

	private static int RemoveFunctionGraph_ParamsSize;

	private static bool RemoveFunctionGraph_Blueprint_IsValid;

	private static FFieldAddress RemoveFunctionGraph_Blueprint_PropertyAddress;

	private static int RemoveFunctionGraph_Blueprint_Offset;

	private static bool RemoveFunctionGraph_FuncName_IsValid;

	private static FFieldAddress RemoveFunctionGraph_FuncName_PropertyAddress;

	private static int RemoveFunctionGraph_FuncName_Offset;

	private static bool GetBlueprintAsset_IsValid;

	private static IntPtr GetBlueprintAsset_FunctionAddress;

	private static int GetBlueprintAsset_ParamsSize;

	private static bool GetBlueprintAsset_Object_IsValid;

	private static FFieldAddress GetBlueprintAsset_Object_PropertyAddress;

	private static int GetBlueprintAsset_Object_Offset;

	private static bool GetBlueprintAsset_ReturnValue_IsValid;

	private static FFieldAddress GetBlueprintAsset_ReturnValue_PropertyAddress;

	private static int GetBlueprintAsset_ReturnValue_Offset;

	private static bool GeneratedClass_IsValid;

	private static IntPtr GeneratedClass_FunctionAddress;

	private static int GeneratedClass_ParamsSize;

	private static bool GeneratedClass_BlueprintObj_IsValid;

	private static FFieldAddress GeneratedClass_BlueprintObj_PropertyAddress;

	private static int GeneratedClass_BlueprintObj_Offset;

	private static bool GeneratedClass_ReturnValue_IsValid;

	private static FFieldAddress GeneratedClass_ReturnValue_PropertyAddress;

	private static int GeneratedClass_ReturnValue_Offset;

	private static bool FindGraph_IsValid;

	private static IntPtr FindGraph_FunctionAddress;

	private static int FindGraph_ParamsSize;

	private static bool FindGraph_Blueprint_IsValid;

	private static FFieldAddress FindGraph_Blueprint_PropertyAddress;

	private static int FindGraph_Blueprint_Offset;

	private static bool FindGraph_GraphName_IsValid;

	private static FFieldAddress FindGraph_GraphName_PropertyAddress;

	private static int FindGraph_GraphName_Offset;

	private static bool FindGraph_ReturnValue_IsValid;

	private static FFieldAddress FindGraph_ReturnValue_PropertyAddress;

	private static int FindGraph_ReturnValue_Offset;

	private static bool FindEventGraph_IsValid;

	private static IntPtr FindEventGraph_FunctionAddress;

	private static int FindEventGraph_ParamsSize;

	private static bool FindEventGraph_Blueprint_IsValid;

	private static FFieldAddress FindEventGraph_Blueprint_PropertyAddress;

	private static int FindEventGraph_Blueprint_Offset;

	private static bool FindEventGraph_ReturnValue_IsValid;

	private static FFieldAddress FindEventGraph_ReturnValue_PropertyAddress;

	private static int FindEventGraph_ReturnValue_Offset;

	private static bool CompileBlueprint_IsValid;

	private static IntPtr CompileBlueprint_FunctionAddress;

	private static int CompileBlueprint_ParamsSize;

	private static bool CompileBlueprint_Blueprint_IsValid;

	private static FFieldAddress CompileBlueprint_Blueprint_PropertyAddress;

	private static int CompileBlueprint_Blueprint_Offset;

	private static bool AddFunctionGraph_IsValid;

	private static IntPtr AddFunctionGraph_FunctionAddress;

	private static int AddFunctionGraph_ParamsSize;

	private static bool AddFunctionGraph_Blueprint_IsValid;

	private static FFieldAddress AddFunctionGraph_Blueprint_PropertyAddress;

	private static int AddFunctionGraph_Blueprint_Offset;

	private static bool AddFunctionGraph_FuncName_IsValid;

	private static FFieldAddress AddFunctionGraph_FuncName_PropertyAddress;

	private static int AddFunctionGraph_FuncName_Offset;

	private static bool AddFunctionGraph_ReturnValue_IsValid;

	private static FFieldAddress AddFunctionGraph_ReturnValue_PropertyAddress;

	private static int AddFunctionGraph_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:UpgradeOperatorNodes")]
	public unsafe static void UpgradeOperatorNodes(UBlueprint Blueprint)
	{
		if (!UpgradeOperatorNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:UpgradeOperatorNodes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpgradeOperatorNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpgradeOperatorNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, UpgradeOperatorNodes_Blueprint_Offset), 0, UpgradeOperatorNodes_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpgradeOperatorNodes_FunctionAddress, intPtr, UpgradeOperatorNodes_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReplaceVariableReferences")]
	public unsafe static void ReplaceVariableReferences(UBlueprint Blueprint, FName OldVarName, FName NewVarName)
	{
		if (!ReplaceVariableReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReplaceVariableReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceVariableReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceVariableReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, ReplaceVariableReferences_Blueprint_Offset), 0, ReplaceVariableReferences_Blueprint_PropertyAddress.Address, Blueprint);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceVariableReferences_OldVarName_Offset), 0, ReplaceVariableReferences_OldVarName_PropertyAddress.Address, OldVarName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceVariableReferences_NewVarName_Offset), 0, ReplaceVariableReferences_NewVarName_PropertyAddress.Address, NewVarName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceVariableReferences_FunctionAddress, intPtr, ReplaceVariableReferences_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReparentBlueprint")]
	public unsafe static void ReparentBlueprint(UBlueprint Blueprint, TSubclassOf<UObject> NewParentClass)
	{
		if (!ReparentBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReparentBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReparentBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReparentBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, ReparentBlueprint_Blueprint_Offset), 0, ReparentBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReparentBlueprint_NewParentClass_Offset), 0, ReparentBlueprint_NewParentClass_PropertyAddress.Address, NewParentClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReparentBlueprint_FunctionAddress, intPtr, ReparentBlueprint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RenameGraph")]
	public unsafe static void RenameGraph(UEdGraph Graph, string NewNameStr = "NewGraph")
	{
		if (!RenameGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RenameGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraph>.ToNative(IntPtr.Add(intPtr, RenameGraph_Graph_Offset), 0, RenameGraph_Graph_PropertyAddress.Address, Graph);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameGraph_NewNameStr_Offset), 0, RenameGraph_NewNameStr_PropertyAddress.Address, NewNameStr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameGraph_FunctionAddress, intPtr, RenameGraph_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameGraph_NewNameStr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedVariables")]
	public unsafe static int RemoveUnusedVariables(UBlueprint Blueprint)
	{
		if (!RemoveUnusedVariables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedVariables");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveUnusedVariables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveUnusedVariables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, RemoveUnusedVariables_Blueprint_Offset), 0, RemoveUnusedVariables_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveUnusedVariables_FunctionAddress, intPtr, RemoveUnusedVariables_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveUnusedVariables_ReturnValue_Offset), 0, RemoveUnusedVariables_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedNodes")]
	public unsafe static void RemoveUnusedNodes(UBlueprint Blueprint)
	{
		if (!RemoveUnusedNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedNodes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveUnusedNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveUnusedNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, RemoveUnusedNodes_Blueprint_Offset), 0, RemoveUnusedNodes_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveUnusedNodes_FunctionAddress, intPtr, RemoveUnusedNodes_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveGraph")]
	public unsafe static void RemoveGraph(UBlueprint Blueprint, UEdGraph Graph)
	{
		if (!RemoveGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, RemoveGraph_Blueprint_Offset), 0, RemoveGraph_Blueprint_PropertyAddress.Address, Blueprint);
		UObjectMarshaler<UEdGraph>.ToNative(IntPtr.Add(intPtr, RemoveGraph_Graph_Offset), 0, RemoveGraph_Graph_PropertyAddress.Address, Graph);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveGraph_FunctionAddress, intPtr, RemoveGraph_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveFunctionGraph")]
	public unsafe static void RemoveFunctionGraph(UBlueprint Blueprint, FName FuncName)
	{
		if (!RemoveFunctionGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveFunctionGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFunctionGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFunctionGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, RemoveFunctionGraph_Blueprint_Offset), 0, RemoveFunctionGraph_Blueprint_PropertyAddress.Address, Blueprint);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveFunctionGraph_FuncName_Offset), 0, RemoveFunctionGraph_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveFunctionGraph_FunctionAddress, intPtr, RemoveFunctionGraph_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GetBlueprintAsset")]
	public unsafe static UBlueprint GetBlueprintAsset(UObject Object)
	{
		if (!GetBlueprintAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GetBlueprintAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprintAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprintAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetBlueprintAsset_Object_Offset), 0, GetBlueprintAsset_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlueprintAsset_FunctionAddress, intPtr, GetBlueprintAsset_ParamsSize);
		return UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(intPtr, GetBlueprintAsset_ReturnValue_Offset), 0, GetBlueprintAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GeneratedClass")]
	public unsafe static TSubclassOf<UObject> GeneratedClass(UBlueprint BlueprintObj)
	{
		if (!GeneratedClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GeneratedClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratedClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratedClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GeneratedClass_BlueprintObj_Offset), 0, GeneratedClass_BlueprintObj_PropertyAddress.Address, BlueprintObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GeneratedClass_FunctionAddress, intPtr, GeneratedClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GeneratedClass_ReturnValue_Offset), 0, GeneratedClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindGraph")]
	public unsafe static UEdGraph FindGraph(UBlueprint Blueprint, FName GraphName)
	{
		if (!FindGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, FindGraph_Blueprint_Offset), 0, FindGraph_Blueprint_PropertyAddress.Address, Blueprint);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindGraph_GraphName_Offset), 0, FindGraph_GraphName_PropertyAddress.Address, GraphName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindGraph_FunctionAddress, intPtr, FindGraph_ParamsSize);
		return UObjectMarshaler<UEdGraph>.FromNative(IntPtr.Add(intPtr, FindGraph_ReturnValue_Offset), 0, FindGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindEventGraph")]
	public unsafe static UEdGraph FindEventGraph(UBlueprint Blueprint)
	{
		if (!FindEventGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindEventGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindEventGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindEventGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, FindEventGraph_Blueprint_Offset), 0, FindEventGraph_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindEventGraph_FunctionAddress, intPtr, FindEventGraph_ParamsSize);
		return UObjectMarshaler<UEdGraph>.FromNative(IntPtr.Add(intPtr, FindEventGraph_ReturnValue_Offset), 0, FindEventGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:CompileBlueprint")]
	public unsafe static void CompileBlueprint(UBlueprint Blueprint)
	{
		if (!CompileBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:CompileBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompileBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompileBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, CompileBlueprint_Blueprint_Offset), 0, CompileBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompileBlueprint_FunctionAddress, intPtr, CompileBlueprint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:AddFunctionGraph")]
	public unsafe static UEdGraph AddFunctionGraph(UBlueprint Blueprint, string FuncName = "NewFunction")
	{
		if (!AddFunctionGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:AddFunctionGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFunctionGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFunctionGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, AddFunctionGraph_Blueprint_Offset), 0, AddFunctionGraph_Blueprint_PropertyAddress.Address, Blueprint);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionGraph_FuncName_Offset), 0, AddFunctionGraph_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFunctionGraph_FunctionAddress, intPtr, AddFunctionGraph_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFunctionGraph_FuncName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UEdGraph>.FromNative(IntPtr.Add(intPtr, AddFunctionGraph_ReturnValue_Offset), 0, AddFunctionGraph_ReturnValue_PropertyAddress.Address);
	}

	static UBlueprintEditorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBlueprintEditorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBlueprintEditorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary");
		UpgradeOperatorNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpgradeOperatorNodes");
		UpgradeOperatorNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(UpgradeOperatorNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpgradeOperatorNodes_Blueprint_PropertyAddress, UpgradeOperatorNodes_FunctionAddress, "Blueprint");
		UpgradeOperatorNodes_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(UpgradeOperatorNodes_FunctionAddress, "Blueprint");
		UpgradeOperatorNodes_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(UpgradeOperatorNodes_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		UpgradeOperatorNodes_IsValid = UpgradeOperatorNodes_FunctionAddress != IntPtr.Zero && UpgradeOperatorNodes_Blueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:UpgradeOperatorNodes", UpgradeOperatorNodes_IsValid);
		ReplaceVariableReferences_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceVariableReferences");
		ReplaceVariableReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceVariableReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceVariableReferences_Blueprint_PropertyAddress, ReplaceVariableReferences_FunctionAddress, "Blueprint");
		ReplaceVariableReferences_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceVariableReferences_FunctionAddress, "Blueprint");
		ReplaceVariableReferences_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceVariableReferences_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceVariableReferences_OldVarName_PropertyAddress, ReplaceVariableReferences_FunctionAddress, "OldVarName");
		ReplaceVariableReferences_OldVarName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceVariableReferences_FunctionAddress, "OldVarName");
		ReplaceVariableReferences_OldVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceVariableReferences_FunctionAddress, "OldVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceVariableReferences_NewVarName_PropertyAddress, ReplaceVariableReferences_FunctionAddress, "NewVarName");
		ReplaceVariableReferences_NewVarName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceVariableReferences_FunctionAddress, "NewVarName");
		ReplaceVariableReferences_NewVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceVariableReferences_FunctionAddress, "NewVarName", Classes.FNameProperty);
		ReplaceVariableReferences_IsValid = ReplaceVariableReferences_FunctionAddress != IntPtr.Zero && ReplaceVariableReferences_Blueprint_IsValid && ReplaceVariableReferences_OldVarName_IsValid && ReplaceVariableReferences_NewVarName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReplaceVariableReferences", ReplaceVariableReferences_IsValid);
		ReparentBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReparentBlueprint");
		ReparentBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(ReparentBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReparentBlueprint_Blueprint_PropertyAddress, ReparentBlueprint_FunctionAddress, "Blueprint");
		ReparentBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(ReparentBlueprint_FunctionAddress, "Blueprint");
		ReparentBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(ReparentBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReparentBlueprint_NewParentClass_PropertyAddress, ReparentBlueprint_FunctionAddress, "NewParentClass");
		ReparentBlueprint_NewParentClass_Offset = NativeReflectionCached.GetPropertyOffset(ReparentBlueprint_FunctionAddress, "NewParentClass");
		ReparentBlueprint_NewParentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReparentBlueprint_FunctionAddress, "NewParentClass", Classes.FClassProperty);
		ReparentBlueprint_IsValid = ReparentBlueprint_FunctionAddress != IntPtr.Zero && ReparentBlueprint_Blueprint_IsValid && ReparentBlueprint_NewParentClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:ReparentBlueprint", ReparentBlueprint_IsValid);
		RenameGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameGraph");
		RenameGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameGraph_Graph_PropertyAddress, RenameGraph_FunctionAddress, "Graph");
		RenameGraph_Graph_Offset = NativeReflectionCached.GetPropertyOffset(RenameGraph_FunctionAddress, "Graph");
		RenameGraph_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameGraph_FunctionAddress, "Graph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameGraph_NewNameStr_PropertyAddress, RenameGraph_FunctionAddress, "NewNameStr");
		RenameGraph_NewNameStr_Offset = NativeReflectionCached.GetPropertyOffset(RenameGraph_FunctionAddress, "NewNameStr");
		RenameGraph_NewNameStr_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameGraph_FunctionAddress, "NewNameStr", Classes.FStrProperty);
		RenameGraph_IsValid = RenameGraph_FunctionAddress != IntPtr.Zero && RenameGraph_Graph_IsValid && RenameGraph_NewNameStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RenameGraph", RenameGraph_IsValid);
		RemoveUnusedVariables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveUnusedVariables");
		RemoveUnusedVariables_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveUnusedVariables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveUnusedVariables_Blueprint_PropertyAddress, RemoveUnusedVariables_FunctionAddress, "Blueprint");
		RemoveUnusedVariables_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUnusedVariables_FunctionAddress, "Blueprint");
		RemoveUnusedVariables_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUnusedVariables_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveUnusedVariables_ReturnValue_PropertyAddress, RemoveUnusedVariables_FunctionAddress, "ReturnValue");
		RemoveUnusedVariables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUnusedVariables_FunctionAddress, "ReturnValue");
		RemoveUnusedVariables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUnusedVariables_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveUnusedVariables_IsValid = RemoveUnusedVariables_FunctionAddress != IntPtr.Zero && RemoveUnusedVariables_Blueprint_IsValid && RemoveUnusedVariables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedVariables", RemoveUnusedVariables_IsValid);
		RemoveUnusedNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveUnusedNodes");
		RemoveUnusedNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveUnusedNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveUnusedNodes_Blueprint_PropertyAddress, RemoveUnusedNodes_FunctionAddress, "Blueprint");
		RemoveUnusedNodes_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUnusedNodes_FunctionAddress, "Blueprint");
		RemoveUnusedNodes_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUnusedNodes_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		RemoveUnusedNodes_IsValid = RemoveUnusedNodes_FunctionAddress != IntPtr.Zero && RemoveUnusedNodes_Blueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveUnusedNodes", RemoveUnusedNodes_IsValid);
		RemoveGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveGraph");
		RemoveGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveGraph_Blueprint_PropertyAddress, RemoveGraph_FunctionAddress, "Blueprint");
		RemoveGraph_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGraph_FunctionAddress, "Blueprint");
		RemoveGraph_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGraph_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveGraph_Graph_PropertyAddress, RemoveGraph_FunctionAddress, "Graph");
		RemoveGraph_Graph_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGraph_FunctionAddress, "Graph");
		RemoveGraph_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGraph_FunctionAddress, "Graph", Classes.FObjectProperty);
		RemoveGraph_IsValid = RemoveGraph_FunctionAddress != IntPtr.Zero && RemoveGraph_Blueprint_IsValid && RemoveGraph_Graph_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveGraph", RemoveGraph_IsValid);
		RemoveFunctionGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveFunctionGraph");
		RemoveFunctionGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFunctionGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFunctionGraph_Blueprint_PropertyAddress, RemoveFunctionGraph_FunctionAddress, "Blueprint");
		RemoveFunctionGraph_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFunctionGraph_FunctionAddress, "Blueprint");
		RemoveFunctionGraph_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFunctionGraph_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFunctionGraph_FuncName_PropertyAddress, RemoveFunctionGraph_FunctionAddress, "FuncName");
		RemoveFunctionGraph_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFunctionGraph_FunctionAddress, "FuncName");
		RemoveFunctionGraph_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFunctionGraph_FunctionAddress, "FuncName", Classes.FNameProperty);
		RemoveFunctionGraph_IsValid = RemoveFunctionGraph_FunctionAddress != IntPtr.Zero && RemoveFunctionGraph_Blueprint_IsValid && RemoveFunctionGraph_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:RemoveFunctionGraph", RemoveFunctionGraph_IsValid);
		GetBlueprintAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlueprintAsset");
		GetBlueprintAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlueprintAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintAsset_Object_PropertyAddress, GetBlueprintAsset_FunctionAddress, "Object");
		GetBlueprintAsset_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintAsset_FunctionAddress, "Object");
		GetBlueprintAsset_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintAsset_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintAsset_ReturnValue_PropertyAddress, GetBlueprintAsset_FunctionAddress, "ReturnValue");
		GetBlueprintAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintAsset_FunctionAddress, "ReturnValue");
		GetBlueprintAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlueprintAsset_IsValid = GetBlueprintAsset_FunctionAddress != IntPtr.Zero && GetBlueprintAsset_Object_IsValid && GetBlueprintAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GetBlueprintAsset", GetBlueprintAsset_IsValid);
		GeneratedClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GeneratedClass");
		GeneratedClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratedClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratedClass_BlueprintObj_PropertyAddress, GeneratedClass_FunctionAddress, "BlueprintObj");
		GeneratedClass_BlueprintObj_Offset = NativeReflectionCached.GetPropertyOffset(GeneratedClass_FunctionAddress, "BlueprintObj");
		GeneratedClass_BlueprintObj_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratedClass_FunctionAddress, "BlueprintObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratedClass_ReturnValue_PropertyAddress, GeneratedClass_FunctionAddress, "ReturnValue");
		GeneratedClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratedClass_FunctionAddress, "ReturnValue");
		GeneratedClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratedClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GeneratedClass_IsValid = GeneratedClass_FunctionAddress != IntPtr.Zero && GeneratedClass_BlueprintObj_IsValid && GeneratedClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:GeneratedClass", GeneratedClass_IsValid);
		FindGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindGraph");
		FindGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(FindGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindGraph_Blueprint_PropertyAddress, FindGraph_FunctionAddress, "Blueprint");
		FindGraph_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(FindGraph_FunctionAddress, "Blueprint");
		FindGraph_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(FindGraph_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindGraph_GraphName_PropertyAddress, FindGraph_FunctionAddress, "GraphName");
		FindGraph_GraphName_Offset = NativeReflectionCached.GetPropertyOffset(FindGraph_FunctionAddress, "GraphName");
		FindGraph_GraphName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindGraph_FunctionAddress, "GraphName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindGraph_ReturnValue_PropertyAddress, FindGraph_FunctionAddress, "ReturnValue");
		FindGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindGraph_FunctionAddress, "ReturnValue");
		FindGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindGraph_IsValid = FindGraph_FunctionAddress != IntPtr.Zero && FindGraph_Blueprint_IsValid && FindGraph_GraphName_IsValid && FindGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindGraph", FindGraph_IsValid);
		FindEventGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindEventGraph");
		FindEventGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(FindEventGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindEventGraph_Blueprint_PropertyAddress, FindEventGraph_FunctionAddress, "Blueprint");
		FindEventGraph_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(FindEventGraph_FunctionAddress, "Blueprint");
		FindEventGraph_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEventGraph_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEventGraph_ReturnValue_PropertyAddress, FindEventGraph_FunctionAddress, "ReturnValue");
		FindEventGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindEventGraph_FunctionAddress, "ReturnValue");
		FindEventGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEventGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindEventGraph_IsValid = FindEventGraph_FunctionAddress != IntPtr.Zero && FindEventGraph_Blueprint_IsValid && FindEventGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:FindEventGraph", FindEventGraph_IsValid);
		CompileBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompileBlueprint");
		CompileBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(CompileBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompileBlueprint_Blueprint_PropertyAddress, CompileBlueprint_FunctionAddress, "Blueprint");
		CompileBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(CompileBlueprint_FunctionAddress, "Blueprint");
		CompileBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(CompileBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		CompileBlueprint_IsValid = CompileBlueprint_FunctionAddress != IntPtr.Zero && CompileBlueprint_Blueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:CompileBlueprint", CompileBlueprint_IsValid);
		AddFunctionGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFunctionGraph");
		AddFunctionGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFunctionGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionGraph_Blueprint_PropertyAddress, AddFunctionGraph_FunctionAddress, "Blueprint");
		AddFunctionGraph_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionGraph_FunctionAddress, "Blueprint");
		AddFunctionGraph_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionGraph_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionGraph_FuncName_PropertyAddress, AddFunctionGraph_FunctionAddress, "FuncName");
		AddFunctionGraph_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionGraph_FunctionAddress, "FuncName");
		AddFunctionGraph_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionGraph_FunctionAddress, "FuncName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionGraph_ReturnValue_PropertyAddress, AddFunctionGraph_FunctionAddress, "ReturnValue");
		AddFunctionGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionGraph_FunctionAddress, "ReturnValue");
		AddFunctionGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFunctionGraph_IsValid = AddFunctionGraph_FunctionAddress != IntPtr.Zero && AddFunctionGraph_Blueprint_IsValid && AddFunctionGraph_FuncName_IsValid && AddFunctionGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary:AddFunctionGraph", AddFunctionGraph_IsValid);
	}
}
