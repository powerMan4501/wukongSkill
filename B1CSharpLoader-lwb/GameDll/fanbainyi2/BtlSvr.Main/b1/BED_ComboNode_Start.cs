using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[UClass]
[DisplayName("Start")]
[USharpPath("/Script/b1-Managed.BED_ComboNode_Start")]
public class BED_ComboNode_Start : BED_ComboNode
{
	private readonly FName DefaultPinName = B1GlobalFNames.Default;

	private static bool ComboConditions_IsValid;

	private static int ComboConditions_Offset;

	private static FFieldAddress ComboConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FComboCondition> ComboConditions_Marshaler;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Condition")]
	[USharpPath("/Script/b1-Managed.BED_ComboNode_Start:ComboConditions")]
	public TArrayReadWrite<FComboCondition> ComboConditions
	{
		get
		{
			CheckDestroyed();
			if (!ComboConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ComboNode_Start:ComboConditions");
				return null;
			}
			if (ComboConditions_Marshaler == null)
			{
				ComboConditions_Marshaler = new TArrayReadWriteMarshaler<FComboCondition>(1, ComboConditions_PropertyAddress, CachedMarshalingDelegates<FComboCondition, FComboCondition>.FromNative, CachedMarshalingDelegates<FComboCondition, FComboCondition>.ToNative);
			}
			return ComboConditions_Marshaler.FromNative(IntPtr.Add(base.Address, ComboConditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Route";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.SupportsContextPins = true;
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ComboNode.Start;
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_Start:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName> { DefaultPinName };
		for (int i = 0; i < ComboConditions.Count; i++)
		{
			FComboCondition fComboCondition = ComboConditions[i];
			if (string.IsNullOrEmpty(fComboCondition.ConditionIdentity))
			{
				list.Add(new FName(i.ToString()));
			}
			else
			{
				list.Add(new FName(fComboCondition.ConditionIdentity));
			}
		}
		return list;
	}

	public override byte[] GetCustomData()
	{
		ComboCustom_Start comboCustom_Start = new ComboCustom_Start();
		foreach (FComboCondition comboCondition in ComboConditions)
		{
			CalliopeCustom_ComboCondition calliopeCustom_ComboCondition = new CalliopeCustom_ComboCondition
			{
				ConditionType = (int)comboCondition.ConditionType,
				UnitState = (int)comboCondition.UnitState,
				SimpleState = (int)comboCondition.SimpleState,
				AttrFloatType = (int)comboCondition.AttrFloatType,
				CompareOperation = (int)comboCondition.CompareOperation,
				CompareValue = comboCondition.CompareValue,
				BuffId = comboCondition.BuffId,
				TalentId = comboCondition.TalentId,
				ComparePotentialEnergyOperation = (int)comboCondition.ComparePotentialEnergyOperation,
				PotentialEnergyLevel = comboCondition.PotentialEnergyLevel,
				CompareChargeOperation = (int)comboCondition.CompareChargeOperation,
				ChargeLevel = comboCondition.ChargeLevel,
				CompareCeilingHeightOperation = (int)comboCondition.CompareCeilingHeightOperation,
				CeilingHeight = comboCondition.CeilingHeight,
				StanceType = (int)comboCondition.StanceType,
				ConditionIdentity = comboCondition.ConditionIdentity,
				MoveMode = (int)comboCondition.MoveMode
			};
			foreach (int skillID in comboCondition.SkillIDList)
			{
				calliopeCustom_ComboCondition.SkillIdList.Add(skillID);
			}
			comboCustom_Start.ComboConditions.Add(calliopeCustom_ComboCondition);
		}
		return comboCustom_Start.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_Start:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("ComboConditions"))
		{
			ExecuteOnReconstructionRequested();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_Start:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_Start bED_ComboNode_Start = GCHelper.Find<BED_ComboNode_Start>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ComboNode_Start.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_Start:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_Start bED_ComboNode_Start = GCHelper.Find<BED_ComboNode_Start>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ComboNode_Start.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_Start");
		NativeReflection.GetPropertyRef(ref ComboConditions_PropertyAddress, intPtr, "ComboConditions");
		ComboConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboConditions");
		ComboConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboConditions", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_Start:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_Start:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ComboNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ComboNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ComboNode_Start));
	}
}
