using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[CollapseCategories(true)]
[UClass]
[USharpPath("/Script/b1-Managed.BGUPerformerControlConfigComp")]
public class BGUPerformerControlConfigComp : UActorEditCompBase
{
	private static bool Phases_IsValid;

	private static int Phases_Offset;

	private static FFieldAddress Phases_PropertyAddress;

	private TArrayReadWriteMarshaler<UPerformerPhase> Phases_Marshaler;

	private static bool Params_IsValid;

	private static int Params_Offset;

	private static FFieldAddress Params_PropertyAddress;

	private TArrayReadWriteMarshaler<UPerformerParamBase> Params_Marshaler;

	private static bool GetPossibleParamsCS_IsValid;

	private static IntPtr GetPossibleParamsCS_FunctionAddress;

	private static int GetPossibleParamsCS_ParamsSize;

	private static bool GetPossibleParamsCS_ParentPropertyName_IsValid;

	private static int GetPossibleParamsCS_ParentPropertyName_Offset;

	private static FFieldAddress GetPossibleParamsCS_ParentPropertyName_PropertyAddress;

	private static bool GetPossibleParamsCS_PropertyName_IsValid;

	private static int GetPossibleParamsCS_PropertyName_Offset;

	private static FFieldAddress GetPossibleParamsCS_PropertyName_PropertyAddress;

	private static bool GetPossibleParamsCS_OutParamArray_IsValid;

	private static int GetPossibleParamsCS_OutParamArray_Offset;

	private static FFieldAddress GetPossibleParamsCS_OutParamArray_PropertyAddress;

	private static bool GetParamDisplayNameCS_IsValid;

	private static IntPtr GetParamDisplayNameCS_FunctionAddress;

	private static int GetParamDisplayNameCS_ParamsSize;

	private static bool GetParamDisplayNameCS_PropertyName_IsValid;

	private static int GetParamDisplayNameCS_PropertyName_Offset;

	private static FFieldAddress GetParamDisplayNameCS_PropertyName_PropertyAddress;

	private static bool GetParamDisplayNameCS_ConfigGuid_IsValid;

	private static int GetParamDisplayNameCS_ConfigGuid_Offset;

	private static FFieldAddress GetParamDisplayNameCS_ConfigGuid_PropertyAddress;

	private static bool GetParamDisplayNameCS_ReturnValue_IsValid;

	private static int GetParamDisplayNameCS_ReturnValue_Offset;

	private static FFieldAddress GetParamDisplayNameCS_ReturnValue_PropertyAddress;

	[UProperty(PropFlags.Instanced)]
	[BlueprintReadWrite]
	[DisplayName("表演阶段列表")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPerformerControlConfigComp:Phases")]
	public TArrayReadWrite<UPerformerPhase> Phases
	{
		get
		{
			CheckDestroyed();
			if (!Phases_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerControlConfigComp:Phases");
				return null;
			}
			if (Phases_Marshaler == null)
			{
				Phases_Marshaler = new TArrayReadWriteMarshaler<UPerformerPhase>(1, Phases_PropertyAddress, CachedMarshalingDelegates<UPerformerPhase, UObjectMarshaler<UPerformerPhase>>.FromNative, CachedMarshalingDelegates<UPerformerPhase, UObjectMarshaler<UPerformerPhase>>.ToNative);
			}
			return Phases_Marshaler.FromNative(IntPtr.Add(base.Address, Phases_Offset));
		}
	}

	[DisplayName("参数列表")]
	[BlueprintReadWrite]
	[UProperty(PropFlags.Instanced)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPerformerControlConfigComp:Params")]
	public TArrayReadWrite<UPerformerParamBase> Params
	{
		get
		{
			CheckDestroyed();
			if (!Params_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerControlConfigComp:Params");
				return null;
			}
			if (Params_Marshaler == null)
			{
				Params_Marshaler = new TArrayReadWriteMarshaler<UPerformerParamBase>(1, Params_PropertyAddress, CachedMarshalingDelegates<UPerformerParamBase, UObjectMarshaler<UPerformerParamBase>>.FromNative, CachedMarshalingDelegates<UPerformerParamBase, UObjectMarshaler<UPerformerParamBase>>.ToNative);
			}
			return Params_Marshaler.FromNative(IntPtr.Add(base.Address, Params_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_PerformerControlData bUC_PerformerControlData = RequireWritableData<BUC_PerformerControlData>();
		bUC_PerformerControlData.Phases.Clear();
		foreach (UPerformerPhase phase in Phases)
		{
			if (phase != null)
			{
				bUC_PerformerControlData.Phases.Add(phase);
			}
		}
		bUC_PerformerControlData.Params.Clear();
		foreach (UPerformerParamBase item in Params)
		{
			if (item != null)
			{
				bUC_PerformerControlData.Params.Add(item);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerControlConfigComp:GetParamDisplayNameCS")]
	protected override string GetParamDisplayNameCS_Implementation(string PropertyName, FCalliopeGuid ConfigGuid)
	{
		Guid guid = GameplayTagExtension.ConvertToGuid(ConfigGuid);
		foreach (UPerformerParamBase item in Params)
		{
			if (!(item == null) && GameplayTagExtension.ConvertToGuid(item.ConfigGuid) == guid)
			{
				return item.GetDisplayName();
			}
		}
		return "";
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerControlConfigComp:GetPossibleParamsCS")]
	protected override void GetPossibleParamsCS_Implementation(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		OutParamArray = new List<FCalliopeGuid>();
		if (PropertyName.Contains("Overlap"))
		{
			foreach (UPerformerParamBase item in Params)
			{
				if (!(item == null) && item.ParamType == EPerformerParamType.Overlap)
				{
					OutParamArray.Add(item.ConfigGuid);
				}
			}
			return;
		}
		if (!PropertyName.Contains("Performer"))
		{
			return;
		}
		foreach (UPerformerParamBase item2 in Params)
		{
			if (!(item2 == null) && item2.ParamType == EPerformerParamType.Performer)
			{
				OutParamArray.Add(item2.ConfigGuid);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerControlConfigComp:GetPossibleParamsCS")]
	private static void GetPossibleParamsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerControlConfigComp bGUPerformerControlConfigComp = GCHelper.Find<BGUPerformerControlConfigComp>(obj);
		string parentPropertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_ParentPropertyName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_PropertyName_Offset));
		TArrayCopyMarshaler<FCalliopeGuid> tArrayCopyMarshaler = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative);
		List<FCalliopeGuid> OutParamArray = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_OutParamArray_Offset));
		bGUPerformerControlConfigComp.GetPossibleParamsCS_Implementation(parentPropertyName, propertyName, out OutParamArray);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetPossibleParamsCS_OutParamArray_Offset), OutParamArray);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerControlConfigComp:GetParamDisplayNameCS")]
	private static void GetParamDisplayNameCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerControlConfigComp bGUPerformerControlConfigComp = GCHelper.Find<BGUPerformerControlConfigComp>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetParamDisplayNameCS_PropertyName_Offset));
		FCalliopeGuid configGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, GetParamDisplayNameCS_ConfigGuid_Offset));
		string paramDisplayNameCS_Implementation = bGUPerformerControlConfigComp.GetParamDisplayNameCS_Implementation(propertyName, configGuid);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetParamDisplayNameCS_ReturnValue_Offset), paramDisplayNameCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPerformerControlConfigComp");
		NativeReflection.GetPropertyRef(ref Phases_PropertyAddress, intPtr, "Phases");
		Phases_Offset = NativeReflection.GetPropertyOffset(intPtr, "Phases");
		Phases_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Phases", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Params_PropertyAddress, intPtr, "Params");
		Params_Offset = NativeReflection.GetPropertyOffset(intPtr, "Params");
		Params_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Params", Classes.FArrayProperty);
		GetPossibleParamsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPossibleParamsCS");
		GetPossibleParamsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossibleParamsCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_ParentPropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_PropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_OutParamArray_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "OutParamArray", Classes.FArrayProperty);
		GetPossibleParamsCS_IsValid = GetPossibleParamsCS_FunctionAddress != IntPtr.Zero && GetPossibleParamsCS_ParentPropertyName_IsValid && GetPossibleParamsCS_PropertyName_IsValid && GetPossibleParamsCS_OutParamArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerControlConfigComp:GetPossibleParamsCS", GetPossibleParamsCS_IsValid);
		GetParamDisplayNameCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParamDisplayNameCS");
		GetParamDisplayNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamDisplayNameCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_PropertyName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_ConfigGuid_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ConfigGuid");
		GetParamDisplayNameCS_ConfigGuid_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ConfigGuid");
		GetParamDisplayNameCS_ConfigGuid_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ConfigGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_ReturnValue_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetParamDisplayNameCS_IsValid = GetParamDisplayNameCS_FunctionAddress != IntPtr.Zero && GetParamDisplayNameCS_PropertyName_IsValid && GetParamDisplayNameCS_ConfigGuid_IsValid && GetParamDisplayNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerControlConfigComp:GetParamDisplayNameCS", GetParamDisplayNameCS_IsValid);
	}

	static BGUPerformerControlConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPerformerControlConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPerformerControlConfigComp));
	}
}
