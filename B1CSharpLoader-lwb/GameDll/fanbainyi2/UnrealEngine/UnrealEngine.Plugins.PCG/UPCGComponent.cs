using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGComponent", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGComponent : UActorComponent
{
	private static bool InputType_IsValid;

	private static FFieldAddress InputType_PropertyAddress;

	private static int InputType_Offset;

	private static bool ParseActorComponents_IsValid;

	private static FFieldAddress ParseActorComponents_PropertyAddress;

	private static int ParseActorComponents_Offset;

	private static bool Seed_IsValid;

	private static int Seed_Offset;

	private static bool Activated_IsValid;

	private static FFieldAddress Activated_PropertyAddress;

	private static int Activated_Offset;

	private static bool IsComponentPartitioned_IsValid;

	private static FFieldAddress IsComponentPartitioned_PropertyAddress;

	private static int IsComponentPartitioned_Offset;

	private static bool GenerationTrigger_IsValid;

	private static FFieldAddress GenerationTrigger_PropertyAddress;

	private static int GenerationTrigger_Offset;

	private static bool Generated_IsValid;

	private static FFieldAddress Generated_PropertyAddress;

	private static int Generated_Offset;

	private static bool RegenerateInEditor_IsValid;

	private static FFieldAddress RegenerateInEditor_PropertyAddress;

	private static int RegenerateInEditor_Offset;

	private static bool DirtyGenerated_IsValid;

	private static FFieldAddress DirtyGenerated_PropertyAddress;

	private static int DirtyGenerated_Offset;

	private static bool PostGenerateFunctionNames_IsValid;

	private static FFieldAddress PostGenerateFunctionNames_PropertyAddress;

	private static int PostGenerateFunctionNames_Offset;

	private TArrayReadWriteMarshaler<FName> PostGenerateFunctionNames_MarshalerCached;

	private static bool GraphInstance_IsValid;

	private static int GraphInstance_Offset;

	private static bool SetGraph_IsValid;

	private static IntPtr SetGraph_FunctionAddress;

	private static int SetGraph_ParamsSize;

	private static bool SetGraph_InGraph_IsValid;

	private static FFieldAddress SetGraph_InGraph_PropertyAddress;

	private static int SetGraph_InGraph_Offset;

	private static bool NotifyPropertiesChangedFromBlueprint_IsValid;

	private static IntPtr NotifyPropertiesChangedFromBlueprint_FunctionAddress;

	private static int NotifyPropertiesChangedFromBlueprint_ParamsSize;

	private static bool GetGeneratedGraphOutput_IsValid;

	private static IntPtr GetGeneratedGraphOutput_FunctionAddress;

	private static int GetGeneratedGraphOutput_ParamsSize;

	private static bool GetGeneratedGraphOutput_ReturnValue_IsValid;

	private static FFieldAddress GetGeneratedGraphOutput_ReturnValue_PropertyAddress;

	private static int GetGeneratedGraphOutput_ReturnValue_Offset;

	private static bool GenerateLocal_IsValid;

	private static IntPtr GenerateLocal_FunctionAddress;

	private static int GenerateLocal_ParamsSize;

	private static bool GenerateLocal_bForce_IsValid;

	private static FFieldAddress GenerateLocal_bForce_PropertyAddress;

	private static int GenerateLocal_bForce_Offset;

	private static bool Generate_IsValid;

	private static IntPtr Generate_FunctionAddress;

	private static int Generate_ParamsSize;

	private static bool Generate_bForce_IsValid;

	private static FFieldAddress Generate_bForce_PropertyAddress;

	private static int Generate_bForce_Offset;

	private static bool ClearPCGLink_IsValid;

	private static IntPtr ClearPCGLink_FunctionAddress;

	private static int ClearPCGLink_ParamsSize;

	private static bool ClearPCGLink_TemplateActor_IsValid;

	private static FFieldAddress ClearPCGLink_TemplateActor_PropertyAddress;

	private static int ClearPCGLink_TemplateActor_Offset;

	private static bool ClearPCGLink_ReturnValue_IsValid;

	private static FFieldAddress ClearPCGLink_ReturnValue_PropertyAddress;

	private static int ClearPCGLink_ReturnValue_Offset;

	private static bool CleanupLocal_IsValid;

	private static IntPtr CleanupLocal_FunctionAddress;

	private static int CleanupLocal_ParamsSize;

	private static bool CleanupLocal_bRemoveComponents_IsValid;

	private static FFieldAddress CleanupLocal_bRemoveComponents_PropertyAddress;

	private static int CleanupLocal_bRemoveComponents_Offset;

	private static bool CleanupLocal_bSave_IsValid;

	private static FFieldAddress CleanupLocal_bSave_PropertyAddress;

	private static int CleanupLocal_bSave_Offset;

	private static bool Cleanup_IsValid;

	private static IntPtr Cleanup_FunctionAddress;

	private static int Cleanup_ParamsSize;

	private static bool Cleanup_bRemoveComponents_IsValid;

	private static FFieldAddress Cleanup_bRemoveComponents_PropertyAddress;

	private static int Cleanup_bRemoveComponents_Offset;

	private static bool Cleanup_bSave_IsValid;

	private static FFieldAddress Cleanup_bSave_PropertyAddress;

	private static int Cleanup_bSave_Offset;

	private static bool AddToManagedResources_IsValid;

	private static IntPtr AddToManagedResources_FunctionAddress;

	private static int AddToManagedResources_ParamsSize;

	private static bool AddToManagedResources_InResource_IsValid;

	private static FFieldAddress AddToManagedResources_InResource_PropertyAddress;

	private static int AddToManagedResources_InResource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGComponent:InputType")]
	public EPCGComponentInput InputType
	{
		get
		{
			CheckDestroyed();
			if (!InputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:InputType");
				return EPCGComponentInput.Actor;
			}
			return EnumMarshaler<EPCGComponentInput>.FromNative(IntPtr.Add(base.Address, InputType_Offset), 0, InputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:InputType");
			}
			else
			{
				EnumMarshaler<EPCGComponentInput>.ToNative(IntPtr.Add(base.Address, InputType_Offset), 0, InputType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bParseActorComponents")]
	public bool ParseActorComponents
	{
		get
		{
			CheckDestroyed();
			if (!ParseActorComponents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bParseActorComponents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ParseActorComponents_Offset), 0, ParseActorComponents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ParseActorComponents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bParseActorComponents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ParseActorComponents_Offset), 0, ParseActorComponents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGComponent:Seed")]
	public int Seed
	{
		get
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:Seed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Seed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:Seed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Seed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bActivated")]
	public bool Activated
	{
		get
		{
			CheckDestroyed();
			if (!Activated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bActivated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Activated_Offset), 0, Activated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Activated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bActivated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Activated_Offset), 0, Activated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bIsComponentPartitioned")]
	public bool IsComponentPartitioned
	{
		get
		{
			CheckDestroyed();
			if (!IsComponentPartitioned_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bIsComponentPartitioned");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsComponentPartitioned_Offset), 0, IsComponentPartitioned_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsComponentPartitioned_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bIsComponentPartitioned");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsComponentPartitioned_Offset), 0, IsComponentPartitioned_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/PCG.PCGComponent:GenerationTrigger")]
	public EPCGComponentGenerationTrigger GenerationTrigger
	{
		get
		{
			CheckDestroyed();
			if (!GenerationTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:GenerationTrigger");
				return EPCGComponentGenerationTrigger.GenerateOnLoad;
			}
			return EnumMarshaler<EPCGComponentGenerationTrigger>.FromNative(IntPtr.Add(base.Address, GenerationTrigger_Offset), 0, GenerationTrigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerationTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:GenerationTrigger");
			}
			else
			{
				EnumMarshaler<EPCGComponentGenerationTrigger>.ToNative(IntPtr.Add(base.Address, GenerationTrigger_Offset), 0, GenerationTrigger_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280917013uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bGenerated")]
	public bool Generated
	{
		get
		{
			CheckDestroyed();
			if (!Generated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bGenerated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Generated_Offset), 0, Generated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Generated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bGenerated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Generated_Offset), 0, Generated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bRegenerateInEditor")]
	public bool RegenerateInEditor
	{
		get
		{
			CheckDestroyed();
			if (!RegenerateInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bRegenerateInEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RegenerateInEditor_Offset), 0, RegenerateInEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RegenerateInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bRegenerateInEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RegenerateInEditor_Offset), 0, RegenerateInEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640663573uL)]
	[UMetaPath("/Script/PCG.PCGComponent:bDirtyGenerated")]
	public bool DirtyGenerated
	{
		get
		{
			CheckDestroyed();
			if (!DirtyGenerated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bDirtyGenerated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DirtyGenerated_Offset), 0, DirtyGenerated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirtyGenerated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:bDirtyGenerated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DirtyGenerated_Offset), 0, DirtyGenerated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4507997673882117uL)]
	[UMetaPath("/Script/PCG.PCGComponent:PostGenerateFunctionNames")]
	public TArrayReadWrite<FName> PostGenerateFunctionNames
	{
		get
		{
			CheckDestroyed();
			if (!PostGenerateFunctionNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:PostGenerateFunctionNames");
				return null;
			}
			if (PostGenerateFunctionNames_MarshalerCached == null)
			{
				PostGenerateFunctionNames_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, PostGenerateFunctionNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return PostGenerateFunctionNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, PostGenerateFunctionNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)12956714815586845uL)]
	[UMetaPath("/Script/PCG.PCGComponent:GraphInstance")]
	protected UPCGGraphInstance GraphInstance
	{
		get
		{
			CheckDestroyed();
			if (!GraphInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:GraphInstance");
				return null;
			}
			return UObjectMarshaler<UPCGGraphInstance>.FromNative(IntPtr.Add(base.Address, GraphInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GraphInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGComponent:GraphInstance");
			}
			else
			{
				UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(base.Address, GraphInstance_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67259584u)]
	[UMetaPath("/Script/PCG.PCGComponent:SetGraph")]
	public unsafe void SetGraph(UPCGGraphInterface InGraph)
	{
		CheckDestroyed();
		if (!SetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:SetGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInterface>.ToNative(IntPtr.Add(intPtr, SetGraph_InGraph_Offset), 0, SetGraph_InGraph_PropertyAddress.Address, InGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGraph_FunctionAddress, intPtr, SetGraph_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGComponent:NotifyPropertiesChangedFromBlueprint")]
	public unsafe void NotifyPropertiesChangedFromBlueprint()
	{
		CheckDestroyed();
		if (!NotifyPropertiesChangedFromBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:NotifyPropertiesChangedFromBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyPropertiesChangedFromBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyPropertiesChangedFromBlueprint_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: NotifyPropertiesChangedFromBlueprint_FunctionAddress, argsSize: NotifyPropertiesChangedFromBlueprint_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGComponent:GetGeneratedGraphOutput")]
	public unsafe FPCGDataCollection GetGeneratedGraphOutput()
	{
		CheckDestroyed();
		if (!GetGeneratedGraphOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:GetGeneratedGraphOutput");
			return default(FPCGDataCollection);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGeneratedGraphOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGeneratedGraphOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGeneratedGraphOutput_FunctionAddress, intPtr, GetGeneratedGraphOutput_ParamsSize);
		FPCGDataCollection result = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, GetGeneratedGraphOutput_ReturnValue_Offset), 0, GetGeneratedGraphOutput_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGeneratedGraphOutput_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGComponent:GenerateLocal")]
	public unsafe void GenerateLocal(bool bForce)
	{
		CheckDestroyed();
		if (!GenerateLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:GenerateLocal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GenerateLocal_bForce_Offset), 0, GenerateLocal_bForce_PropertyAddress.Address, bForce);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateLocal_FunctionAddress, intPtr, GenerateLocal_ParamsSize);
	}

	[UFunction(Flags = 67259584u)]
	[UMetaPath("/Script/PCG.PCGComponent:Generate")]
	public unsafe void Generate(bool bForce)
	{
		CheckDestroyed();
		if (!Generate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:Generate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Generate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Generate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Generate_bForce_Offset), 0, Generate_bForce_PropertyAddress.Address, bForce);
		NativeReflection.InvokeFunctionOptimized(base.Address, Generate_FunctionAddress, intPtr, Generate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGComponent:ClearPCGLink")]
	public unsafe AActor ClearPCGLink(TSubclassOf<UObject> TemplateActor)
	{
		CheckDestroyed();
		if (!ClearPCGLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:ClearPCGLink");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearPCGLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearPCGLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ClearPCGLink_TemplateActor_Offset), 0, ClearPCGLink_TemplateActor_PropertyAddress.Address, TemplateActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearPCGLink_FunctionAddress, intPtr, ClearPCGLink_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ClearPCGLink_ReturnValue_Offset), 0, ClearPCGLink_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGComponent:CleanupLocal")]
	public unsafe void CleanupLocal(bool bRemoveComponents, bool bSave = false)
	{
		CheckDestroyed();
		if (!CleanupLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:CleanupLocal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanupLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanupLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CleanupLocal_bRemoveComponents_Offset), 0, CleanupLocal_bRemoveComponents_PropertyAddress.Address, bRemoveComponents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CleanupLocal_bSave_Offset), 0, CleanupLocal_bSave_PropertyAddress.Address, bSave);
		NativeReflection.InvokeFunctionOptimized(base.Address, CleanupLocal_FunctionAddress, intPtr, CleanupLocal_ParamsSize);
	}

	[UFunction(Flags = 67259584u)]
	[UMetaPath("/Script/PCG.PCGComponent:Cleanup")]
	public unsafe void Cleanup(bool bRemoveComponents, bool bSave = false)
	{
		CheckDestroyed();
		if (!Cleanup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:Cleanup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cleanup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cleanup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Cleanup_bRemoveComponents_Offset), 0, Cleanup_bRemoveComponents_PropertyAddress.Address, bRemoveComponents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Cleanup_bSave_Offset), 0, Cleanup_bSave_PropertyAddress.Address, bSave);
		NativeReflection.InvokeFunctionOptimized(base.Address, Cleanup_FunctionAddress, intPtr, Cleanup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGComponent:AddToManagedResources")]
	public unsafe void AddToManagedResources(UPCGManagedResource InResource)
	{
		CheckDestroyed();
		if (!AddToManagedResources_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGComponent:AddToManagedResources");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToManagedResources_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToManagedResources_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGManagedResource>.ToNative(IntPtr.Add(intPtr, AddToManagedResources_InResource_Offset), 0, AddToManagedResources_InResource_PropertyAddress.Address, InResource);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddToManagedResources_FunctionAddress, intPtr, AddToManagedResources_ParamsSize);
	}

	static UPCGComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGComponent");
		NativeReflectionCached.GetPropertyRef(ref InputType_PropertyAddress, intPtr, "InputType");
		InputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputType");
		InputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ParseActorComponents_PropertyAddress, intPtr, "bParseActorComponents");
		ParseActorComponents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bParseActorComponents");
		ParseActorComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bParseActorComponents", Classes.FBoolProperty);
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Activated_PropertyAddress, intPtr, "bActivated");
		Activated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bActivated");
		Activated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bActivated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsComponentPartitioned_PropertyAddress, intPtr, "bIsComponentPartitioned");
		IsComponentPartitioned_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsComponentPartitioned");
		IsComponentPartitioned_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsComponentPartitioned", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerationTrigger_PropertyAddress, intPtr, "GenerationTrigger");
		GenerationTrigger_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GenerationTrigger");
		GenerationTrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GenerationTrigger", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Generated_PropertyAddress, intPtr, "bGenerated");
		Generated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerated");
		Generated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RegenerateInEditor_PropertyAddress, intPtr, "bRegenerateInEditor");
		RegenerateInEditor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRegenerateInEditor");
		RegenerateInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRegenerateInEditor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DirtyGenerated_PropertyAddress, intPtr, "bDirtyGenerated");
		DirtyGenerated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDirtyGenerated");
		DirtyGenerated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDirtyGenerated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostGenerateFunctionNames_PropertyAddress, intPtr, "PostGenerateFunctionNames");
		PostGenerateFunctionNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostGenerateFunctionNames");
		PostGenerateFunctionNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostGenerateFunctionNames", Classes.FArrayProperty);
		GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GraphInstance");
		GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GraphInstance", Classes.FObjectProperty);
		SetGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGraph");
		SetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGraph_InGraph_PropertyAddress, SetGraph_FunctionAddress, "InGraph");
		SetGraph_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(SetGraph_FunctionAddress, "InGraph");
		SetGraph_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGraph_FunctionAddress, "InGraph", Classes.FObjectProperty);
		SetGraph_IsValid = SetGraph_FunctionAddress != IntPtr.Zero && SetGraph_InGraph_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:SetGraph", SetGraph_IsValid);
		NotifyPropertiesChangedFromBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NotifyPropertiesChangedFromBlueprint");
		NotifyPropertiesChangedFromBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyPropertiesChangedFromBlueprint_FunctionAddress);
		NotifyPropertiesChangedFromBlueprint_IsValid = NotifyPropertiesChangedFromBlueprint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:NotifyPropertiesChangedFromBlueprint", NotifyPropertiesChangedFromBlueprint_IsValid);
		GetGeneratedGraphOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGeneratedGraphOutput");
		GetGeneratedGraphOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGeneratedGraphOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGeneratedGraphOutput_ReturnValue_PropertyAddress, GetGeneratedGraphOutput_FunctionAddress, "ReturnValue");
		GetGeneratedGraphOutput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGeneratedGraphOutput_FunctionAddress, "ReturnValue");
		GetGeneratedGraphOutput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGeneratedGraphOutput_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGeneratedGraphOutput_IsValid = GetGeneratedGraphOutput_FunctionAddress != IntPtr.Zero && GetGeneratedGraphOutput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:GetGeneratedGraphOutput", GetGeneratedGraphOutput_IsValid);
		GenerateLocal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateLocal");
		GenerateLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateLocal_bForce_PropertyAddress, GenerateLocal_FunctionAddress, "bForce");
		GenerateLocal_bForce_Offset = NativeReflectionCached.GetPropertyOffset(GenerateLocal_FunctionAddress, "bForce");
		GenerateLocal_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateLocal_FunctionAddress, "bForce", Classes.FBoolProperty);
		GenerateLocal_IsValid = GenerateLocal_FunctionAddress != IntPtr.Zero && GenerateLocal_bForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:GenerateLocal", GenerateLocal_IsValid);
		Generate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Generate");
		Generate_ParamsSize = NativeReflection.GetFunctionParamsSize(Generate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Generate_bForce_PropertyAddress, Generate_FunctionAddress, "bForce");
		Generate_bForce_Offset = NativeReflectionCached.GetPropertyOffset(Generate_FunctionAddress, "bForce");
		Generate_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(Generate_FunctionAddress, "bForce", Classes.FBoolProperty);
		Generate_IsValid = Generate_FunctionAddress != IntPtr.Zero && Generate_bForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:Generate", Generate_IsValid);
		ClearPCGLink_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearPCGLink");
		ClearPCGLink_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearPCGLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearPCGLink_TemplateActor_PropertyAddress, ClearPCGLink_FunctionAddress, "TemplateActor");
		ClearPCGLink_TemplateActor_Offset = NativeReflectionCached.GetPropertyOffset(ClearPCGLink_FunctionAddress, "TemplateActor");
		ClearPCGLink_TemplateActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPCGLink_FunctionAddress, "TemplateActor", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearPCGLink_ReturnValue_PropertyAddress, ClearPCGLink_FunctionAddress, "ReturnValue");
		ClearPCGLink_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearPCGLink_FunctionAddress, "ReturnValue");
		ClearPCGLink_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPCGLink_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ClearPCGLink_IsValid = ClearPCGLink_FunctionAddress != IntPtr.Zero && ClearPCGLink_TemplateActor_IsValid && ClearPCGLink_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:ClearPCGLink", ClearPCGLink_IsValid);
		CleanupLocal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanupLocal");
		CleanupLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanupLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanupLocal_bRemoveComponents_PropertyAddress, CleanupLocal_FunctionAddress, "bRemoveComponents");
		CleanupLocal_bRemoveComponents_Offset = NativeReflectionCached.GetPropertyOffset(CleanupLocal_FunctionAddress, "bRemoveComponents");
		CleanupLocal_bRemoveComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanupLocal_FunctionAddress, "bRemoveComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CleanupLocal_bSave_PropertyAddress, CleanupLocal_FunctionAddress, "bSave");
		CleanupLocal_bSave_Offset = NativeReflectionCached.GetPropertyOffset(CleanupLocal_FunctionAddress, "bSave");
		CleanupLocal_bSave_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanupLocal_FunctionAddress, "bSave", Classes.FBoolProperty);
		CleanupLocal_IsValid = CleanupLocal_FunctionAddress != IntPtr.Zero && CleanupLocal_bRemoveComponents_IsValid && CleanupLocal_bSave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:CleanupLocal", CleanupLocal_IsValid);
		Cleanup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Cleanup");
		Cleanup_ParamsSize = NativeReflection.GetFunctionParamsSize(Cleanup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Cleanup_bRemoveComponents_PropertyAddress, Cleanup_FunctionAddress, "bRemoveComponents");
		Cleanup_bRemoveComponents_Offset = NativeReflectionCached.GetPropertyOffset(Cleanup_FunctionAddress, "bRemoveComponents");
		Cleanup_bRemoveComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(Cleanup_FunctionAddress, "bRemoveComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Cleanup_bSave_PropertyAddress, Cleanup_FunctionAddress, "bSave");
		Cleanup_bSave_Offset = NativeReflectionCached.GetPropertyOffset(Cleanup_FunctionAddress, "bSave");
		Cleanup_bSave_IsValid = NativeReflectionCached.ValidatePropertyClass(Cleanup_FunctionAddress, "bSave", Classes.FBoolProperty);
		Cleanup_IsValid = Cleanup_FunctionAddress != IntPtr.Zero && Cleanup_bRemoveComponents_IsValid && Cleanup_bSave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:Cleanup", Cleanup_IsValid);
		AddToManagedResources_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddToManagedResources");
		AddToManagedResources_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToManagedResources_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToManagedResources_InResource_PropertyAddress, AddToManagedResources_FunctionAddress, "InResource");
		AddToManagedResources_InResource_Offset = NativeReflectionCached.GetPropertyOffset(AddToManagedResources_FunctionAddress, "InResource");
		AddToManagedResources_InResource_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToManagedResources_FunctionAddress, "InResource", Classes.FObjectProperty);
		AddToManagedResources_IsValid = AddToManagedResources_FunctionAddress != IntPtr.Zero && AddToManagedResources_InResource_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGComponent:AddToManagedResources", AddToManagedResources_IsValid);
	}
}
