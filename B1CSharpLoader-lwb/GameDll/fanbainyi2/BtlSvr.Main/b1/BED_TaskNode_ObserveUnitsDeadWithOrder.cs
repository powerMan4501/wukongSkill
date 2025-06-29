using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Tooltip("死亡信息读档/重置后清空，请务必确保是同一场战斗的死亡顺序，如父子鼠战斗")]
[NotBlueprintable]
[DisplayName("观察多单位死亡（有序）(重置清空记录)")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder")]
public class BED_TaskNode_ObserveUnitsDeadWithOrder : BED_TaskNode
{
	private static bool UnitList_IsValid;

	private static int UnitList_Offset;

	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Observe Unit Guid")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:UnitList")]
	public FGsSmartParamArray UnitList
	{
		get
		{
			CheckDestroyed();
			if (!UnitList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:UnitList");
				return default(FGsSmartParamArray);
			}
			return FGsSmartParamArray.FromNative(IntPtr.Add(base.Address, UnitList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:UnitList");
			}
			else
			{
				FGsSmartParamArray.ToNative(IntPtr.Add(base.Address, UnitList_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Observe");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enable
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disable
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
	}

	private void RefreshOutputPins()
	{
		if (base.OutputPins.Count == OutputPinCount())
		{
			return;
		}
		base.OutputPins.Clear();
		foreach (IEnumerable<int> item in Permutations(Enumerable.Range(0, UnitList.ConfigGuides.Count).ToList()))
		{
			string text = "";
			for (int i = 0; i < item.Count(); i++)
			{
				text += ((i == item.Count() - 1) ? $"{item.ElementAt(i)}" : $"{item.ElementAt(i)}->");
			}
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = new FName(text)
			});
		}
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		ExecuteOnReconstructionRequested();
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		RefreshOutputPins();
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (MemberName == "UnitList")
		{
			RefreshOutputPins();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = "";
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return text;
		}
		for (int i = 0; i < UnitList.ConfigGuides.Count; i++)
		{
			assetInCS.GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitList.ConfigGuides[i]), "UnitList", out var OutDisplayName);
			text += $"[{i}]:\r\n {OutDisplayName}\r\n";
		}
		return text;
	}

	public override byte[] GetCustomData()
	{
		TaskCustom_ObserveUnitsDeadWithOrder taskCustom_ObserveUnitsDeadWithOrder = new TaskCustom_ObserveUnitsDeadWithOrder();
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		foreach (Guid configGuide in UnitList.ConfigGuides)
		{
			assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide), out var OutActorGuid);
			taskCustom_ObserveUnitsDeadWithOrder.ObserveActorGuid.Add(OutActorGuid);
		}
		return taskCustom_ObserveUnitsDeadWithOrder.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.ObserveUnitsDeadWithOrder;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		return true;
	}

	public int OutputPinCount()
	{
		if (UnitList.ConfigGuides.Count == 0)
		{
			return 3;
		}
		int num = 1;
		for (int i = 1; i <= UnitList.ConfigGuides.Count; i++)
		{
			num *= i;
		}
		return num + 3;
	}

	private IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> source)
	{
		int c = source.Count();
		if (c == 1)
		{
			yield return source;
			yield break;
		}
		for (int i = 0; i < c; i++)
		{
			foreach (IEnumerable<T> item in Permutations(source.Take(i).Concat(source.Skip(i + 1))))
			{
				yield return source.Skip(i).Take(1).Concat(item);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveUnitsDeadWithOrder bED_TaskNode_ObserveUnitsDeadWithOrder = GCHelper.Find<BED_TaskNode_ObserveUnitsDeadWithOrder>(obj);
		bED_TaskNode_ObserveUnitsDeadWithOrder.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveUnitsDeadWithOrder bED_TaskNode_ObserveUnitsDeadWithOrder = GCHelper.Find<BED_TaskNode_ObserveUnitsDeadWithOrder>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_TaskNode_ObserveUnitsDeadWithOrder.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveUnitsDeadWithOrder bED_TaskNode_ObserveUnitsDeadWithOrder = GCHelper.Find<BED_TaskNode_ObserveUnitsDeadWithOrder>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_ObserveUnitsDeadWithOrder.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder");
		UnitList_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitList");
		UnitList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitList", Classes.FStructProperty);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveUnitsDeadWithOrder:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_ObserveUnitsDeadWithOrder()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_ObserveUnitsDeadWithOrder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_ObserveUnitsDeadWithOrder));
	}
}
