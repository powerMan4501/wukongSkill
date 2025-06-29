using System;
using System.Collections.Generic;
using b1;
using b1.Plugins.JavascriptEditor;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool")]
public class DisoLib_EditorSGDTool : ABGUPlacedEditorUtilityBase
{
	private static bool BoneNameList_IsValid;

	private static int BoneNameList_Offset;

	private static FFieldAddress BoneNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneNameList_Marshaler;

	private static bool CurBoneName_IsValid;

	private static int CurBoneName_Offset;

	private static bool SGDActor_IsValid;

	private static int SGDActor_Offset;

	private static bool AutoCompilingSaveAfterClean_IsValid;

	private static int AutoCompilingSaveAfterClean_Offset;

	private static FFieldAddress AutoCompilingSaveAfterClean_PropertyAddress;

	private static bool DelectObjectsArray_IsValid;

	private static int DelectObjectsArray_Offset;

	private static FFieldAddress DelectObjectsArray_PropertyAddress;

	private TArrayReadWriteMarshaler<UStaticMesh> DelectObjectsArray_Marshaler;

	private static bool RetainObjectsArray_IsValid;

	private static int RetainObjectsArray_Offset;

	private static FFieldAddress RetainObjectsArray_PropertyAddress;

	private TArrayReadWriteMarshaler<UStaticMesh> RetainObjectsArray_Marshaler;

	private static bool AddTagToBoneChildComp_IsValid;

	private static int AddTagToBoneChildComp_Offset;

	private static bool CollisionPresetName_IsValid;

	private static int CollisionPresetName_Offset;

	private static FFieldAddress CollisionPresetName_PropertyAddress;

	private static bool Override_CollisionEnable_IsValid;

	private static int Override_CollisionEnable_Offset;

	private static FFieldAddress Override_CollisionEnable_PropertyAddress;

	private static bool CollisionEnable_IsValid;

	private static int CollisionEnable_Offset;

	private static FFieldAddress CollisionEnable_PropertyAddress;

	private static bool Override_CollisionObjectType_IsValid;

	private static int Override_CollisionObjectType_Offset;

	private static FFieldAddress Override_CollisionObjectType_PropertyAddress;

	private static bool CollisionObjectType_IsValid;

	private static int CollisionObjectType_Offset;

	private static FFieldAddress CollisionObjectType_PropertyAddress;

	private static bool CreateBoneComp_IsValid;

	private static IntPtr CreateBoneComp_FunctionAddress;

	private static int CreateBoneComp_ParamsSize;

	private static bool CreateSubMeshComp_IsValid;

	private static IntPtr CreateSubMeshComp_FunctionAddress;

	private static int CreateSubMeshComp_ParamsSize;

	private static bool CleanAllSubMeshComp_IsValid;

	private static IntPtr CleanAllSubMeshComp_FunctionAddress;

	private static int CleanAllSubMeshComp_ParamsSize;

	private static bool AddTagToBoneChildComps_IsValid;

	private static IntPtr AddTagToBoneChildComps_FunctionAddress;

	private static int AddTagToBoneChildComps_ParamsSize;

	private static bool CleanOneBoneSubMeshComp_IsValid;

	private static IntPtr CleanOneBoneSubMeshComp_FunctionAddress;

	private static int CleanOneBoneSubMeshComp_ParamsSize;

	private static bool CreateOneBoneSubMeshComp_IsValid;

	private static IntPtr CreateOneBoneSubMeshComp_FunctionAddress;

	private static int CreateOneBoneSubMeshComp_ParamsSize;

	private static bool CreateLevelActorFromUnit_IsValid;

	private static IntPtr CreateLevelActorFromUnit_FunctionAddress;

	private static int CreateLevelActorFromUnit_ParamsSize;

	private static bool ToggleSubMeshCompVisable_IsValid;

	private static IntPtr ToggleSubMeshCompVisable_FunctionAddress;

	private static int ToggleSubMeshCompVisable_ParamsSize;

	private static bool LogBoneChildCompsCPDData_IsValid;

	private static IntPtr LogBoneChildCompsCPDData_FunctionAddress;

	private static int LogBoneChildCompsCPDData_ParamsSize;

	private static bool ToggleBoneChildCompsHidenInGame_IsValid;

	private static IntPtr ToggleBoneChildCompsHidenInGame_FunctionAddress;

	private static int ToggleBoneChildCompsHidenInGame_ParamsSize;

	private static bool SetBoneChildCompsCollisionSetting_IsValid;

	private static IntPtr SetBoneChildCompsCollisionSetting_FunctionAddress;

	private static int SetBoneChildCompsCollisionSetting_ParamsSize;

	private static bool CleanOneBoneSubMeshCompByDelectObjectsArray_IsValid;

	private static IntPtr CleanOneBoneSubMeshCompByDelectObjectsArray_FunctionAddress;

	private static int CleanOneBoneSubMeshCompByDelectObjectsArray_ParamsSize;

	private static bool CleanOneBoneSubMeshCompByRetainObjectsArray_IsValid;

	private static IntPtr CleanOneBoneSubMeshCompByRetainObjectsArray_FunctionAddress;

	private static int CleanOneBoneSubMeshCompByRetainObjectsArray_ParamsSize;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:BoneNameList")]
	public TArrayReadWrite<FName> BoneNameList
	{
		get
		{
			CheckDestroyed();
			if (!BoneNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:BoneNameList");
				return null;
			}
			if (BoneNameList_Marshaler == null)
			{
				BoneNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneNameList_Marshaler.FromNative(IntPtr.Add(base.Address, BoneNameList_Offset));
		}
	}

	[BlueprintReadWrite]
	[Tooltip("蓝图内可以被挂模型的骨骼点Comp需要添加相应骨骼名字的tag，这个参数填哪个tag就表示当前操作哪个骨骼点")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CurBoneName")]
	public FName CurBoneName
	{
		get
		{
			CheckDestroyed();
			if (!CurBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CurBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CurBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurBoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:SGDActor")]
	public AActor SGDActor
	{
		get
		{
			CheckDestroyed();
			if (!SGDActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:SGDActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SGDActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SGDActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:SGDActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SGDActor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:AutoCompilingSaveAfterClean")]
	public bool AutoCompilingSaveAfterClean
	{
		get
		{
			CheckDestroyed();
			if (!AutoCompilingSaveAfterClean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:AutoCompilingSaveAfterClean");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoCompilingSaveAfterClean_Offset), 0, AutoCompilingSaveAfterClean_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoCompilingSaveAfterClean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:AutoCompilingSaveAfterClean");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoCompilingSaveAfterClean_Offset), 0, AutoCompilingSaveAfterClean_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:DelectObjectsArray")]
	public TArrayReadWrite<UStaticMesh> DelectObjectsArray
	{
		get
		{
			CheckDestroyed();
			if (!DelectObjectsArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:DelectObjectsArray");
				return null;
			}
			if (DelectObjectsArray_Marshaler == null)
			{
				DelectObjectsArray_Marshaler = new TArrayReadWriteMarshaler<UStaticMesh>(1, DelectObjectsArray_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative);
			}
			return DelectObjectsArray_Marshaler.FromNative(IntPtr.Add(base.Address, DelectObjectsArray_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:RetainObjectsArray")]
	public TArrayReadWrite<UStaticMesh> RetainObjectsArray
	{
		get
		{
			CheckDestroyed();
			if (!RetainObjectsArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:RetainObjectsArray");
				return null;
			}
			if (RetainObjectsArray_Marshaler == null)
			{
				RetainObjectsArray_Marshaler = new TArrayReadWriteMarshaler<UStaticMesh>(1, RetainObjectsArray_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative);
			}
			return RetainObjectsArray_Marshaler.FromNative(IntPtr.Add(base.Address, RetainObjectsArray_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("SetChildComps|Tag")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComp")]
	public FName AddTagToBoneChildComp
	{
		get
		{
			CheckDestroyed();
			if (!AddTagToBoneChildComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComp");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AddTagToBoneChildComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddTagToBoneChildComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComp");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AddTagToBoneChildComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SetChildComps|Collision")]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionPresetName")]
	public DispLibCollisionProfileNames CollisionPresetName
	{
		get
		{
			CheckDestroyed();
			if (!CollisionPresetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionPresetName");
				return DispLibCollisionProfileNames.NoCollision;
			}
			return EnumMarshaler<DispLibCollisionProfileNames>.FromNative(IntPtr.Add(base.Address, CollisionPresetName_Offset), 0, CollisionPresetName_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionPresetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionPresetName");
			}
			else
			{
				EnumMarshaler<DispLibCollisionProfileNames>.ToNative(IntPtr.Add(base.Address, CollisionPresetName_Offset), 0, CollisionPresetName_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SetChildComps|Collision")]
	[UMeta(MDProp.InlineEditConditionToggle)]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionEnable")]
	public bool Override_CollisionEnable
	{
		get
		{
			CheckDestroyed();
			if (!Override_CollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Override_CollisionEnable_Offset), 0, Override_CollisionEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Override_CollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Override_CollisionEnable_Offset), 0, Override_CollisionEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "Override_CollisionEnable")]
	[Category("SetChildComps|Collision")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionEnable")]
	public ECollisionEnabled CollisionEnable
	{
		get
		{
			CheckDestroyed();
			if (!CollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionEnable");
				return ECollisionEnabled.NoCollision;
			}
			return EnumMarshaler<ECollisionEnabled>.FromNative(IntPtr.Add(base.Address, CollisionEnable_Offset), 0, CollisionEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionEnable");
			}
			else
			{
				EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(base.Address, CollisionEnable_Offset), 0, CollisionEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("SetChildComps|Collision")]
	[UMeta(MDProp.InlineEditConditionToggle)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionObjectType")]
	public bool Override_CollisionObjectType
	{
		get
		{
			CheckDestroyed();
			if (!Override_CollisionObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionObjectType");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Override_CollisionObjectType_Offset), 0, Override_CollisionObjectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Override_CollisionObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:Override_CollisionObjectType");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Override_CollisionObjectType_Offset), 0, Override_CollisionObjectType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SetChildComps|Collision")]
	[UMeta(MDProp.EditCondition, "Override_CollisionObjectType")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionObjectType")]
	public ECollisionChannel CollisionObjectType
	{
		get
		{
			CheckDestroyed();
			if (!CollisionObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionObjectType");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, CollisionObjectType_Offset), 0, CollisionObjectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DisoLib_EditorSGDTool:CollisionObjectType");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, CollisionObjectType_Offset), 0, CollisionObjectType_PropertyAddress.Address, value);
			}
		}
	}

	private bool SavePackage()
	{
		UBlueprint blueprintFromClass = UBlueprint.GetBlueprintFromClass(SGDActor.GetClass());
		UJavascriptEditorLibrary.CompileBlueprint(blueprintFromClass);
		List<UPackage> OutFailedPackages;
		return UGSFuncLibForEditor.CheckoutAndSavePackage(new List<UPackage> { blueprintFromClass.GetOutermost() }, bCheckDirty: false, bPromptToSave: false, out OutFailedPackages);
	}

	private Dictionary<FName, USceneComponent> GetActorAllBoneComps(AActor Actor)
	{
		Dictionary<FName, USceneComponent> dictionary = new Dictionary<FName, USceneComponent>();
		foreach (UActorComponent item in Actor.GetComponentsByClass(UClass.GetClass<USceneComponent>()))
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent.ComponentTags.Count != 0 && uSceneComponent.GetName().Contains("Bone_"))
			{
				dictionary.Add(uSceneComponent.ComponentTags[0], uSceneComponent);
			}
		}
		return dictionary;
	}

	private bool ValidCheck(out UBlueprint SGD_BP, out USceneComponent BoneComp)
	{
		SGD_BP = null;
		BoneComp = null;
		if (SGDActor.IsNullOrDestroyed())
		{
			return false;
		}
		SGD_BP = UBlueprint.GetBlueprintFromClass(SGDActor.GetClass());
		if (SGD_BP == null)
		{
			return false;
		}
		GetActorAllBoneComps(SGDActor).TryGetValue(CurBoneName, out BoneComp);
		if (BoneComp == null)
		{
			return false;
		}
		return true;
	}

	private List<USceneComponent> GetCurBoneChildComponentTemplateList()
	{
		List<USceneComponent> list = new List<USceneComponent>();
		if (SGDActor.IsNullOrDestroyed())
		{
			return list;
		}
		UBlueprint blueprintFromClass = UBlueprint.GetBlueprintFromClass(SGDActor.GetClass());
		if (!GetActorAllBoneComps(SGDActor).TryGetValue(CurBoneName, out var _))
		{
			return list;
		}
		foreach (UActorComponent item in UGSFuncLibForEditor.GetAllComponentTemplateInBlueprint(blueprintFromClass))
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (!(uSceneComponent == null))
			{
				list.Add(uSceneComponent);
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComps")]
	public void AddTagToBoneChildComps()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:SetBoneChildCompsCollisionSetting")]
	public void SetBoneChildCompsCollisionSetting()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:LogBoneChildCompsCPDData")]
	public void LogBoneChildCompsCPDData()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleBoneChildCompsHidenInGame")]
	public void ToggleBoneChildCompsHidenInGame()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByDelectObjectsArray")]
	public void CleanOneBoneSubMeshCompByDelectObjectsArray()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByRetainObjectsArray")]
	public void CleanOneBoneSubMeshCompByRetainObjectsArray()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshComp")]
	public void CleanOneBoneSubMeshComp()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateLevelActorFromUnit")]
	public void CreateLevelActorFromUnit()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateOneBoneSubMeshComp")]
	public void CreateOneBoneSubMeshComp()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleSubMeshCompVisable")]
	public void ToggleSubMeshCompVisable()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateBoneComp")]
	public void CreateBoneComp()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanAllSubMeshComp")]
	public void CleanAllSubMeshComp()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateSubMeshComp")]
	public void CreateSubMeshComp()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateBoneComp")]
	private static void CreateBoneComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CreateBoneComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateSubMeshComp")]
	private static void CreateSubMeshComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CreateSubMeshComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanAllSubMeshComp")]
	private static void CleanAllSubMeshComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CleanAllSubMeshComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComps")]
	private static void AddTagToBoneChildComps__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.AddTagToBoneChildComps();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshComp")]
	private static void CleanOneBoneSubMeshComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CleanOneBoneSubMeshComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateOneBoneSubMeshComp")]
	private static void CreateOneBoneSubMeshComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CreateOneBoneSubMeshComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateLevelActorFromUnit")]
	private static void CreateLevelActorFromUnit__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CreateLevelActorFromUnit();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleSubMeshCompVisable")]
	private static void ToggleSubMeshCompVisable__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.ToggleSubMeshCompVisable();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:LogBoneChildCompsCPDData")]
	private static void LogBoneChildCompsCPDData__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.LogBoneChildCompsCPDData();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleBoneChildCompsHidenInGame")]
	private static void ToggleBoneChildCompsHidenInGame__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.ToggleBoneChildCompsHidenInGame();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:SetBoneChildCompsCollisionSetting")]
	private static void SetBoneChildCompsCollisionSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.SetBoneChildCompsCollisionSetting();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByDelectObjectsArray")]
	private static void CleanOneBoneSubMeshCompByDelectObjectsArray__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CleanOneBoneSubMeshCompByDelectObjectsArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByRetainObjectsArray")]
	private static void CleanOneBoneSubMeshCompByRetainObjectsArray__Invoker(IntPtr buffer, IntPtr obj)
	{
		DisoLib_EditorSGDTool disoLib_EditorSGDTool = GCHelper.Find<DisoLib_EditorSGDTool>(obj);
		disoLib_EditorSGDTool.CleanOneBoneSubMeshCompByRetainObjectsArray();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DisoLib_EditorSGDTool");
		NativeReflection.GetPropertyRef(ref BoneNameList_PropertyAddress, intPtr, "BoneNameList");
		BoneNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneNameList");
		BoneNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneNameList", Classes.FArrayProperty);
		CurBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurBoneName");
		CurBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurBoneName", Classes.FNameProperty);
		SGDActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SGDActor");
		SGDActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SGDActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AutoCompilingSaveAfterClean_PropertyAddress, intPtr, "AutoCompilingSaveAfterClean");
		AutoCompilingSaveAfterClean_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoCompilingSaveAfterClean");
		AutoCompilingSaveAfterClean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoCompilingSaveAfterClean", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DelectObjectsArray_PropertyAddress, intPtr, "DelectObjectsArray");
		DelectObjectsArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelectObjectsArray");
		DelectObjectsArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelectObjectsArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RetainObjectsArray_PropertyAddress, intPtr, "RetainObjectsArray");
		RetainObjectsArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "RetainObjectsArray");
		RetainObjectsArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RetainObjectsArray", Classes.FArrayProperty);
		AddTagToBoneChildComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddTagToBoneChildComp");
		AddTagToBoneChildComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddTagToBoneChildComp", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref CollisionPresetName_PropertyAddress, intPtr, "CollisionPresetName");
		CollisionPresetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionPresetName");
		CollisionPresetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionPresetName", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Override_CollisionEnable_PropertyAddress, intPtr, "Override_CollisionEnable");
		Override_CollisionEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Override_CollisionEnable");
		Override_CollisionEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Override_CollisionEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CollisionEnable_PropertyAddress, intPtr, "CollisionEnable");
		CollisionEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionEnable");
		CollisionEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionEnable", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Override_CollisionObjectType_PropertyAddress, intPtr, "Override_CollisionObjectType");
		Override_CollisionObjectType_Offset = NativeReflection.GetPropertyOffset(intPtr, "Override_CollisionObjectType");
		Override_CollisionObjectType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Override_CollisionObjectType", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CollisionObjectType_PropertyAddress, intPtr, "CollisionObjectType");
		CollisionObjectType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionObjectType");
		CollisionObjectType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionObjectType", Classes.FEnumProperty);
		CreateBoneComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateBoneComp");
		CreateBoneComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBoneComp_FunctionAddress);
		CreateBoneComp_IsValid = CreateBoneComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateBoneComp", CreateBoneComp_IsValid);
		CreateSubMeshComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateSubMeshComp");
		CreateSubMeshComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSubMeshComp_FunctionAddress);
		CreateSubMeshComp_IsValid = CreateSubMeshComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateSubMeshComp", CreateSubMeshComp_IsValid);
		CleanAllSubMeshComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanAllSubMeshComp");
		CleanAllSubMeshComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAllSubMeshComp_FunctionAddress);
		CleanAllSubMeshComp_IsValid = CleanAllSubMeshComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanAllSubMeshComp", CleanAllSubMeshComp_IsValid);
		AddTagToBoneChildComps_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTagToBoneChildComps");
		AddTagToBoneChildComps_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTagToBoneChildComps_FunctionAddress);
		AddTagToBoneChildComps_IsValid = AddTagToBoneChildComps_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:AddTagToBoneChildComps", AddTagToBoneChildComps_IsValid);
		CleanOneBoneSubMeshComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanOneBoneSubMeshComp");
		CleanOneBoneSubMeshComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanOneBoneSubMeshComp_FunctionAddress);
		CleanOneBoneSubMeshComp_IsValid = CleanOneBoneSubMeshComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshComp", CleanOneBoneSubMeshComp_IsValid);
		CreateOneBoneSubMeshComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateOneBoneSubMeshComp");
		CreateOneBoneSubMeshComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateOneBoneSubMeshComp_FunctionAddress);
		CreateOneBoneSubMeshComp_IsValid = CreateOneBoneSubMeshComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateOneBoneSubMeshComp", CreateOneBoneSubMeshComp_IsValid);
		CreateLevelActorFromUnit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateLevelActorFromUnit");
		CreateLevelActorFromUnit_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLevelActorFromUnit_FunctionAddress);
		CreateLevelActorFromUnit_IsValid = CreateLevelActorFromUnit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CreateLevelActorFromUnit", CreateLevelActorFromUnit_IsValid);
		ToggleSubMeshCompVisable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleSubMeshCompVisable");
		ToggleSubMeshCompVisable_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleSubMeshCompVisable_FunctionAddress);
		ToggleSubMeshCompVisable_IsValid = ToggleSubMeshCompVisable_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleSubMeshCompVisable", ToggleSubMeshCompVisable_IsValid);
		LogBoneChildCompsCPDData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogBoneChildCompsCPDData");
		LogBoneChildCompsCPDData_ParamsSize = NativeReflection.GetFunctionParamsSize(LogBoneChildCompsCPDData_FunctionAddress);
		LogBoneChildCompsCPDData_IsValid = LogBoneChildCompsCPDData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:LogBoneChildCompsCPDData", LogBoneChildCompsCPDData_IsValid);
		ToggleBoneChildCompsHidenInGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleBoneChildCompsHidenInGame");
		ToggleBoneChildCompsHidenInGame_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleBoneChildCompsHidenInGame_FunctionAddress);
		ToggleBoneChildCompsHidenInGame_IsValid = ToggleBoneChildCompsHidenInGame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:ToggleBoneChildCompsHidenInGame", ToggleBoneChildCompsHidenInGame_IsValid);
		SetBoneChildCompsCollisionSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoneChildCompsCollisionSetting");
		SetBoneChildCompsCollisionSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneChildCompsCollisionSetting_FunctionAddress);
		SetBoneChildCompsCollisionSetting_IsValid = SetBoneChildCompsCollisionSetting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:SetBoneChildCompsCollisionSetting", SetBoneChildCompsCollisionSetting_IsValid);
		CleanOneBoneSubMeshCompByDelectObjectsArray_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanOneBoneSubMeshCompByDelectObjectsArray");
		CleanOneBoneSubMeshCompByDelectObjectsArray_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanOneBoneSubMeshCompByDelectObjectsArray_FunctionAddress);
		CleanOneBoneSubMeshCompByDelectObjectsArray_IsValid = CleanOneBoneSubMeshCompByDelectObjectsArray_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByDelectObjectsArray", CleanOneBoneSubMeshCompByDelectObjectsArray_IsValid);
		CleanOneBoneSubMeshCompByRetainObjectsArray_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanOneBoneSubMeshCompByRetainObjectsArray");
		CleanOneBoneSubMeshCompByRetainObjectsArray_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanOneBoneSubMeshCompByRetainObjectsArray_FunctionAddress);
		CleanOneBoneSubMeshCompByRetainObjectsArray_IsValid = CleanOneBoneSubMeshCompByRetainObjectsArray_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DisoLib_EditorSGDTool:CleanOneBoneSubMeshCompByRetainObjectsArray", CleanOneBoneSubMeshCompByRetainObjectsArray_IsValid);
	}

	static DisoLib_EditorSGDTool()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DisoLib_EditorSGDTool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DisoLib_EditorSGDTool));
	}
}
