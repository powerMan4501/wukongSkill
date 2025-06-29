using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools")]
public class DispLib_EditorTreeLODTools : ABGUPlacedEditorUtilityBase
{
	private static bool CacaheActorName_IsValid;

	private static int CacaheActorName_Offset;

	private static bool CustomMeshAssetsPath_IsValid;

	private static int CustomMeshAssetsPath_Offset;

	private static bool EnableSimBlock_IsValid;

	private static int EnableSimBlock_Offset;

	private static FFieldAddress EnableSimBlock_PropertyAddress;

	private static bool LogLevelTreeInfo_IsValid;

	private static IntPtr LogLevelTreeInfo_FunctionAddress;

	private static int LogLevelTreeInfo_ParamsSize;

	private static bool ConverToInstanceActor_IsValid;

	private static IntPtr ConverToInstanceActor_FunctionAddress;

	private static int ConverToInstanceActor_ParamsSize;

	private static bool ToggleAllTreeActorHide_IsValid;

	private static IntPtr ToggleAllTreeActorHide_FunctionAddress;

	private static int ToggleAllTreeActorHide_ParamsSize;

	private static bool SetAllTreeActorVisibility_IsValid;

	private static IntPtr SetAllTreeActorVisibility_FunctionAddress;

	private static int SetAllTreeActorVisibility_ParamsSize;

	private static bool SetAllTreeActorVisibility_Visibility_IsValid;

	private static int SetAllTreeActorVisibility_Visibility_Offset;

	private static FFieldAddress SetAllTreeActorVisibility_Visibility_PropertyAddress;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool RepleaceCustomMeshAssetToImposter_IsValid;

	private static IntPtr RepleaceCustomMeshAssetToImposter_FunctionAddress;

	private static int RepleaceCustomMeshAssetToImposter_ParamsSize;

	private static bool RepleaceCustomMeshAssetToReduceMesh_IsValid;

	private static IntPtr RepleaceCustomMeshAssetToReduceMesh_FunctionAddress;

	private static int RepleaceCustomMeshAssetToReduceMesh_ParamsSize;

	private static bool RepleaceOriginMeshAssetToCustomMeshAsset_IsValid;

	private static IntPtr RepleaceOriginMeshAssetToCustomMeshAsset_FunctionAddress;

	private static int RepleaceOriginMeshAssetToCustomMeshAsset_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:CacaheActorName")]
	public FName CacaheActorName
	{
		get
		{
			CheckDestroyed();
			if (!CacaheActorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:CacaheActorName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CacaheActorName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacaheActorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:CacaheActorName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CacaheActorName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:CustomMeshAssetsPath")]
	public FName CustomMeshAssetsPath
	{
		get
		{
			CheckDestroyed();
			if (!CustomMeshAssetsPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:CustomMeshAssetsPath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CustomMeshAssetsPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomMeshAssetsPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:CustomMeshAssetsPath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CustomMeshAssetsPath_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:EnableSimBlock")]
	public bool EnableSimBlock
	{
		get
		{
			CheckDestroyed();
			if (!EnableSimBlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:EnableSimBlock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSimBlock_Offset), 0, EnableSimBlock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSimBlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeLODTools:EnableSimBlock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSimBlock_Offset), 0, EnableSimBlock_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:ToggleAllTreeActorHide")]
	public void ToggleAllTreeActorHide()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:SetAllTreeActorVisibility")]
	public void SetAllTreeActorVisibility(bool Visibility)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:LogLevelTreeInfo")]
	public void LogLevelTreeInfo()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceOriginMeshAssetToCustomMeshAsset")]
	public void RepleaceOriginMeshAssetToCustomMeshAsset()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToImposter")]
	public void RepleaceCustomMeshAssetToImposter()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToReduceMesh")]
	public void RepleaceCustomMeshAssetToReduceMesh()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:ConverToInstanceActor")]
	public void ConverToInstanceActor()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeLODTools:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:LogLevelTreeInfo")]
	private static void LogLevelTreeInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.LogLevelTreeInfo();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:ConverToInstanceActor")]
	private static void ConverToInstanceActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.ConverToInstanceActor();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:ToggleAllTreeActorHide")]
	private static void ToggleAllTreeActorHide__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.ToggleAllTreeActorHide();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:SetAllTreeActorVisibility")]
	private static void SetAllTreeActorVisibility__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		bool allTreeActorVisibility = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetAllTreeActorVisibility_Visibility_Offset), 0, SetAllTreeActorVisibility_Visibility_PropertyAddress.Address);
		dispLib_EditorTreeLODTools.SetAllTreeActorVisibility(allTreeActorVisibility);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		dispLib_EditorTreeLODTools.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToImposter")]
	private static void RepleaceCustomMeshAssetToImposter__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.RepleaceCustomMeshAssetToImposter();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToReduceMesh")]
	private static void RepleaceCustomMeshAssetToReduceMesh__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.RepleaceCustomMeshAssetToReduceMesh();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceOriginMeshAssetToCustomMeshAsset")]
	private static void RepleaceOriginMeshAssetToCustomMeshAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeLODTools dispLib_EditorTreeLODTools = GCHelper.Find<DispLib_EditorTreeLODTools>(obj);
		dispLib_EditorTreeLODTools.RepleaceOriginMeshAssetToCustomMeshAsset();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorTreeLODTools");
		CacaheActorName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CacaheActorName");
		CacaheActorName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CacaheActorName", Classes.FNameProperty);
		CustomMeshAssetsPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomMeshAssetsPath");
		CustomMeshAssetsPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomMeshAssetsPath", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref EnableSimBlock_PropertyAddress, intPtr, "EnableSimBlock");
		EnableSimBlock_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSimBlock");
		EnableSimBlock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSimBlock", Classes.FBoolProperty);
		LogLevelTreeInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogLevelTreeInfo");
		LogLevelTreeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(LogLevelTreeInfo_FunctionAddress);
		LogLevelTreeInfo_IsValid = LogLevelTreeInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:LogLevelTreeInfo", LogLevelTreeInfo_IsValid);
		ConverToInstanceActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConverToInstanceActor");
		ConverToInstanceActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ConverToInstanceActor_FunctionAddress);
		ConverToInstanceActor_IsValid = ConverToInstanceActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:ConverToInstanceActor", ConverToInstanceActor_IsValid);
		ToggleAllTreeActorHide_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleAllTreeActorHide");
		ToggleAllTreeActorHide_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleAllTreeActorHide_FunctionAddress);
		ToggleAllTreeActorHide_IsValid = ToggleAllTreeActorHide_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:ToggleAllTreeActorHide", ToggleAllTreeActorHide_IsValid);
		SetAllTreeActorVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllTreeActorVisibility");
		SetAllTreeActorVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllTreeActorVisibility_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetAllTreeActorVisibility_Visibility_PropertyAddress, SetAllTreeActorVisibility_FunctionAddress, "Visibility");
		SetAllTreeActorVisibility_Visibility_Offset = NativeReflection.GetPropertyOffset(SetAllTreeActorVisibility_FunctionAddress, "Visibility");
		SetAllTreeActorVisibility_Visibility_IsValid = NativeReflection.ValidatePropertyClass(SetAllTreeActorVisibility_FunctionAddress, "Visibility", Classes.FBoolProperty);
		SetAllTreeActorVisibility_IsValid = SetAllTreeActorVisibility_FunctionAddress != IntPtr.Zero && SetAllTreeActorVisibility_Visibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:SetAllTreeActorVisibility", SetAllTreeActorVisibility_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:ReceiveTick", ReceiveTick_IsValid);
		RepleaceCustomMeshAssetToImposter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RepleaceCustomMeshAssetToImposter");
		RepleaceCustomMeshAssetToImposter_ParamsSize = NativeReflection.GetFunctionParamsSize(RepleaceCustomMeshAssetToImposter_FunctionAddress);
		RepleaceCustomMeshAssetToImposter_IsValid = RepleaceCustomMeshAssetToImposter_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToImposter", RepleaceCustomMeshAssetToImposter_IsValid);
		RepleaceCustomMeshAssetToReduceMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RepleaceCustomMeshAssetToReduceMesh");
		RepleaceCustomMeshAssetToReduceMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(RepleaceCustomMeshAssetToReduceMesh_FunctionAddress);
		RepleaceCustomMeshAssetToReduceMesh_IsValid = RepleaceCustomMeshAssetToReduceMesh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceCustomMeshAssetToReduceMesh", RepleaceCustomMeshAssetToReduceMesh_IsValid);
		RepleaceOriginMeshAssetToCustomMeshAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RepleaceOriginMeshAssetToCustomMeshAsset");
		RepleaceOriginMeshAssetToCustomMeshAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(RepleaceOriginMeshAssetToCustomMeshAsset_FunctionAddress);
		RepleaceOriginMeshAssetToCustomMeshAsset_IsValid = RepleaceOriginMeshAssetToCustomMeshAsset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeLODTools:RepleaceOriginMeshAssetToCustomMeshAsset", RepleaceOriginMeshAssetToCustomMeshAsset_IsValid);
	}

	static DispLib_EditorTreeLODTools()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorTreeLODTools)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorTreeLODTools));
	}
}
