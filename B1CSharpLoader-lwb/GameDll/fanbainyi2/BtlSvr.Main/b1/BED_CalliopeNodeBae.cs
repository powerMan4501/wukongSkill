using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae")]
public class BED_CalliopeNodeBae : UCalliopeNode, ISmartActorGuidObj, IInterface, ICheckNodeQueryable
{
	private static bool GetActorGuid_IsValid;

	private static IntPtr GetActorGuid_FunctionAddress;

	private static int GetActorGuid_ParamsSize;

	private static bool GetActorGuid_InActor_IsValid;

	private static int GetActorGuid_InActor_Offset;

	private static bool GetActorGuid_OutActorGuid_IsValid;

	private static int GetActorGuid_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuid_OutActorGuid_PropertyAddress;

	private static bool GetActorGuid_ReturnValue_IsValid;

	private static int GetActorGuid_ReturnValue_Offset;

	private static FFieldAddress GetActorGuid_ReturnValue_PropertyAddress;

	private IntPtr GetActorGuid_InstanceFunctionAddressInstance;

	private static bool CanManageStates_IsValid;

	private static IntPtr CanManageStates_FunctionAddress;

	private static int CanManageStates_ParamsSize;

	private static bool CanManageStates_ReturnValue_IsValid;

	private static int CanManageStates_ReturnValue_Offset;

	private static FFieldAddress CanManageStates_ReturnValue_PropertyAddress;

	private IntPtr CanManageStates_InstanceFunctionAddressInstance;

	private static bool GetActorGuidOptions_IsValid;

	private static IntPtr GetActorGuidOptions_FunctionAddress;

	private static int GetActorGuidOptions_ParamsSize;

	private static bool GetActorGuidOptions_PropertyName_IsValid;

	private static int GetActorGuidOptions_PropertyName_Offset;

	private static FFieldAddress GetActorGuidOptions_PropertyName_PropertyAddress;

	private static bool GetActorGuidOptions_OutOptions_IsValid;

	private static int GetActorGuidOptions_OutOptions_Offset;

	private static FFieldAddress GetActorGuidOptions_OutOptions_PropertyAddress;

	private static bool GetActorGuidOptions_ReturnValue_IsValid;

	private static int GetActorGuidOptions_ReturnValue_Offset;

	private IntPtr GetActorGuidOptions_InstanceFunctionAddressInstance;

	private static bool GetGuid_IsValid;

	private static IntPtr GetGuid_FunctionAddress;

	private static int GetGuid_ParamsSize;

	private static bool GetGuid_ReturnValue_IsValid;

	private static int GetGuid_ReturnValue_Offset;

	private static FFieldAddress GetGuid_ReturnValue_PropertyAddress;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool IsBranchGraphNode_IsValid;

	private static IntPtr IsBranchGraphNode_FunctionAddress;

	private static int IsBranchGraphNode_ParamsSize;

	private static bool IsBranchGraphNode_ReturnValue_IsValid;

	private static int IsBranchGraphNode_ReturnValue_Offset;

	private static FFieldAddress IsBranchGraphNode_ReturnValue_PropertyAddress;

	private static bool GetBranchGraphToEditInCS_IsValid;

	private static IntPtr GetBranchGraphToEditInCS_FunctionAddress;

	private static int GetBranchGraphToEditInCS_ParamsSize;

	private static bool GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid;

	private static int GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset;

	private static FFieldAddress GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress;

	private static bool GetBranchGraphToEditInCS_ReturnValue_IsValid;

	private static int GetBranchGraphToEditInCS_ReturnValue_Offset;

	private static FFieldAddress GetBranchGraphToEditInCS_ReturnValue_PropertyAddress;

	protected void SetNumberedInputPins(int FirstNumber = 0, int LastNumber = -1)
	{
		base.InputPins.Clear();
		for (int i = FirstNumber; i <= LastNumber; i++)
		{
			base.InputPins.Add(new FCalliopePin
			{
				PinName = new FName(i.ToString())
			});
		}
	}

	protected void SetNumberedOutputPins(int FirstNumber = 0, int LastNumber = -1)
	{
		base.OutputPins.Clear();
		for (int i = FirstNumber; i <= LastNumber; i++)
		{
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = new FName(i.ToString())
			});
		}
	}

	protected void SetNodeCategory(string InCategory)
	{
		base.Category = InCategory;
	}

	protected void SetNodeStyle(ECalliopeNodeStyle InNodeStyle)
	{
		base.NodeStyle = InNodeStyle;
	}

	protected void AddInputPin(string InPinName, string InPinTooltip = "")
	{
		FCalliopePin item = new FCalliopePin
		{
			PinName = new FName(InPinName)
		};
		if (!string.IsNullOrEmpty(InPinTooltip))
		{
			item.PinToolTip = InPinTooltip;
		}
		base.InputPins.Add(item);
	}

	protected void AddOutputPin(string InPinName, string InPinTooltip = "")
	{
		FCalliopePin item = new FCalliopePin
		{
			PinName = new FName(InPinName)
		};
		if (!string.IsNullOrEmpty(InPinTooltip))
		{
			item.PinToolTip = InPinTooltip;
		}
		base.OutputPins.Add(item);
	}

	public virtual byte[] GetCustomData()
	{
		return new byte[1];
	}

	public virtual bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		return true;
	}

	public virtual uint GetCustomDataVersion()
	{
		return 0u;
	}

	public int GetInputPinIndex(FName PinName)
	{
		for (int i = 0; i < base.InputPins.Count; i++)
		{
			if (base.InputPins[i].PinName.Equals(PinName))
			{
				return i;
			}
		}
		return -1;
	}

	public int GetOutputPinIndex(FName PinName)
	{
		for (int i = 0; i < base.OutputPins.Count; i++)
		{
			if (base.OutputPins[i].PinName.Equals(PinName))
			{
				return i;
			}
		}
		return -1;
	}

	public virtual string GetNodeName()
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:GetGuid")]
	protected override FCalliopeGuid GetGuid_Implementation()
	{
		return GameplayTagExtension.ConvertToCalliopeGuid(base.NodeGuid);
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:GetBranchGraphToEditInCS")]
	protected override bool GetBranchGraphToEditInCS_Implementation(out string OutBranchGraphIdentifier)
	{
		OutBranchGraphIdentifier = "";
		return false;
	}

	public virtual bool TryGetExtraBranchGraphNames(out List<FName> OutBranchGraphNames)
	{
		OutBranchGraphNames = null;
		return false;
	}

	public virtual bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		return true;
	}

	public virtual bool GetPreloadAssets(ref List<FSoftObjectPath> PreloadAssets)
	{
		return true;
	}

	public BED_CalliopeAssetBase GetAssetInCS()
	{
		return GetCalliopeAsset() as BED_CalliopeAssetBase;
	}

	public virtual int GetActorGuidOptions_Implementation(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		return GetAssetInCS().GetActorGuidOptions(PropertyName, out OutOptions);
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuidOptions")]
	public unsafe int GetActorGuidOptions(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		CheckDestroyed();
		if (!GetActorGuidOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuidOptions");
			OutOptions = null;
			return 0;
		}
		if (GetActorGuidOptions_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			GetActorGuidOptions_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuidOptions");
		}
		byte* value = stackalloc byte[(int)(uint)GetActorGuidOptions_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GetActorGuidOptions_ParamsSize);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorGuidOptions_PropertyName_Offset), PropertyName);
		TArrayCopyMarshaler<FActorGuidOption> tArrayCopyMarshaler = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative);
		NativeReflection.InvokeFunction(base.Address, GetActorGuidOptions_InstanceFunctionAddressInstance, intPtr, GetActorGuidOptions_ParamsSize);
		int result = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_PropertyName_PropertyAddress.Address, intPtr);
		OutOptions = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_OutOptions_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_OutOptions_PropertyAddress.Address, intPtr);
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuid")]
	public unsafe bool GetActorGuid(AActor InActor, out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuid");
			OutActorGuid = null;
			return false;
		}
		if (GetActorGuid_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			GetActorGuid_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuid");
		}
		byte* value = stackalloc byte[(int)(uint)GetActorGuid_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GetActorGuid_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorGuid_InActor_Offset), InActor);
		NativeReflection.InvokeFunction(base.Address, GetActorGuid_InstanceFunctionAddressInstance, intPtr, GetActorGuid_ParamsSize);
		bool result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_OutActorGuid_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:CanManageStates")]
	public unsafe bool CanManageStates()
	{
		CheckDestroyed();
		if (!CanManageStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeNodeBae:CanManageStates");
			return false;
		}
		if (CanManageStates_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CanManageStates_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CanManageStates");
		}
		byte* value = stackalloc byte[(int)(uint)CanManageStates_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CanManageStates_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, CanManageStates_InstanceFunctionAddressInstance, intPtr, CanManageStates_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address);
	}

	public virtual bool CanManageStates_Implementation()
	{
		return false;
	}

	public virtual bool GetActorGuid_Implementation(AActor InActor, out string OutActorGuid)
	{
		OutActorGuid = BGU_DataUtil.GetActorGuid(InActor, bFindFromComponent: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	public string ConvertGUID_UnitCollection(Guid ConfigGuid)
	{
		string result = "";
		foreach (FGsManagedUnit item in GetCalliopeAsset().CalliopeParameters.UnitCollection)
		{
			if (item.ConfigGuid == ConfigGuid)
			{
				result = item.ActorGuid;
				break;
			}
		}
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:IsBranchGraphNode")]
	protected override bool IsBranchGraphNode_Implementation()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeNodeBae:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuid")]
	private static void GetActorGuid__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		AActor inActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetActorGuid_InActor_Offset));
		string OutActorGuid;
		bool actorGuid_Implementation = bED_CalliopeNodeBae.GetActorGuid_Implementation(inActor, out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address, actorGuid_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuid_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:CanManageStates")]
	private static void CanManageStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		bool value = bED_CalliopeNodeBae.CanManageStates_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuidOptions")]
	private static void GetActorGuidOptions__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_PropertyName_Offset));
		TArrayCopyMarshaler<FActorGuidOption> tArrayCopyMarshaler = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative);
		List<FActorGuidOption> OutOptions = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset));
		int actorGuidOptions_Implementation = bED_CalliopeNodeBae.GetActorGuidOptions_Implementation(propertyName, out OutOptions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_ReturnValue_Offset), actorGuidOptions_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset), OutOptions);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:GetGuid")]
	private static void GetGuid__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		FCalliopeGuid guid_Implementation = bED_CalliopeNodeBae.GetGuid_Implementation();
		FCalliopeGuid.ToNative(IntPtr.Add(buffer, GetGuid_ReturnValue_Offset), guid_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_CalliopeNodeBae.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:IsBranchGraphNode")]
	private static void IsBranchGraphNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		bool value = bED_CalliopeNodeBae.IsBranchGraphNode_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsBranchGraphNode_ReturnValue_Offset), 0, IsBranchGraphNode_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeNodeBae:GetBranchGraphToEditInCS")]
	private static void GetBranchGraphToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeNodeBae bED_CalliopeNodeBae = GCHelper.Find<BED_CalliopeNodeBae>(obj);
		string OutBranchGraphIdentifier;
		bool branchGraphToEditInCS_Implementation = bED_CalliopeNodeBae.GetBranchGraphToEditInCS_Implementation(out OutBranchGraphIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetBranchGraphToEditInCS_ReturnValue_Offset), 0, GetBranchGraphToEditInCS_ReturnValue_PropertyAddress.Address, branchGraphToEditInCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset), OutBranchGraphIdentifier);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_CalliopeNodeBae");
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		GetActorGuid_InActor_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "InActor");
		GetActorGuid_InActor_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_InActor_IsValid && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuid", GetActorGuid_IsValid);
		CanManageStates_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanManageStates");
		CanManageStates_ParamsSize = NativeReflection.GetFunctionParamsSize(CanManageStates_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanManageStates_ReturnValue_PropertyAddress, CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanManageStates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanManageStates_IsValid = CanManageStates_FunctionAddress != IntPtr.Zero && CanManageStates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:CanManageStates", CanManageStates_IsValid);
		GetActorGuidOptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuidOptions");
		GetActorGuidOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidOptions_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_PropertyName_PropertyAddress, GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_OutOptions_PropertyAddress, GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "OutOptions", Classes.FArrayProperty);
		GetActorGuidOptions_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "ReturnValue");
		GetActorGuidOptions_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActorGuidOptions_IsValid = GetActorGuidOptions_FunctionAddress != IntPtr.Zero && GetActorGuidOptions_PropertyName_IsValid && GetActorGuidOptions_OutOptions_IsValid && GetActorGuidOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:GetActorGuidOptions", GetActorGuidOptions_IsValid);
		GetGuid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGuid");
		GetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGuid_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetGuid_ReturnValue_PropertyAddress, GetGuid_FunctionAddress, "ReturnValue");
		GetGuid_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetGuid_FunctionAddress, "ReturnValue");
		GetGuid_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetGuid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGuid_IsValid = GetGuid_FunctionAddress != IntPtr.Zero && GetGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:GetGuid", GetGuid_IsValid);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:IsSupportViewType", IsSupportViewType_IsValid);
		IsBranchGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsBranchGraphNode");
		IsBranchGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBranchGraphNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsBranchGraphNode_ReturnValue_PropertyAddress, IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsBranchGraphNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBranchGraphNode_IsValid = IsBranchGraphNode_FunctionAddress != IntPtr.Zero && IsBranchGraphNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:IsBranchGraphNode", IsBranchGraphNode_IsValid);
		GetBranchGraphToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBranchGraphToEditInCS");
		GetBranchGraphToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBranchGraphToEditInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset = NativeReflection.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid = NativeReflection.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetBranchGraphToEditInCS_ReturnValue_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBranchGraphToEditInCS_IsValid = GetBranchGraphToEditInCS_FunctionAddress != IntPtr.Zero && GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid && GetBranchGraphToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeNodeBae:GetBranchGraphToEditInCS", GetBranchGraphToEditInCS_IsValid);
	}

	static BED_CalliopeNodeBae()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_CalliopeNodeBae)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_CalliopeNodeBae));
	}
}
