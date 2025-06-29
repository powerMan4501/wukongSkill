using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[UClass]
[DisplayName("检测所有阵营单位")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce")]
internal class BED_BehaviorNode_DetectForce : BED_BehaviorNode_Condition
{
	private static bool ForceType_IsValid;

	private static int ForceType_Offset;

	private static FFieldAddress ForceType_PropertyAddress;

	private static bool bDetectUnit_IsValid;

	private static int bDetectUnit_Offset;

	private static FFieldAddress bDetectUnit_PropertyAddress;

	private static bool bDetectBullet_IsValid;

	private static int bDetectBullet_Offset;

	private static FFieldAddress bDetectBullet_PropertyAddress;

	private static bool bDetectMagicField_IsValid;

	private static int bDetectMagicField_Offset;

	private static FFieldAddress bDetectMagicField_PropertyAddress;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FDetectCondition> Conditions_Marshaler;

	private static bool SuccessCount_IsValid;

	private static int SuccessCount_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("阵营类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:ForceType")]
	public EDetectedForceType ForceType
	{
		get
		{
			CheckDestroyed();
			if (!ForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:ForceType");
				return EDetectedForceType.Friend;
			}
			return EnumMarshaler<EDetectedForceType>.FromNative(IntPtr.Add(base.Address, ForceType_Offset), 0, ForceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:ForceType");
			}
			else
			{
				EnumMarshaler<EDetectedForceType>.ToNative(IntPtr.Add(base.Address, ForceType_Offset), 0, ForceType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否检测角色")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectUnit")]
	public bool bDetectUnit
	{
		get
		{
			CheckDestroyed();
			if (!bDetectUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDetectUnit_Offset), 0, bDetectUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDetectUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDetectUnit_Offset), 0, bDetectUnit_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("是否检测子弹")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectBullet")]
	public bool bDetectBullet
	{
		get
		{
			CheckDestroyed();
			if (!bDetectBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectBullet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDetectBullet_Offset), 0, bDetectBullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDetectBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectBullet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDetectBullet_Offset), 0, bDetectBullet_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否检测法术场")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectMagicField")]
	public bool bDetectMagicField
	{
		get
		{
			CheckDestroyed();
			if (!bDetectMagicField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectMagicField");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDetectMagicField_Offset), 0, bDetectMagicField_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDetectMagicField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:bDetectMagicField");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDetectMagicField_Offset), 0, bDetectMagicField_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("检测条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:Conditions")]
	public TArrayReadWrite<FDetectCondition> Conditions
	{
		get
		{
			CheckDestroyed();
			if (!Conditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:Conditions");
				return null;
			}
			if (Conditions_Marshaler == null)
			{
				Conditions_Marshaler = new TArrayReadWriteMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative);
			}
			return Conditions_Marshaler.FromNative(IntPtr.Add(base.Address, Conditions_Offset));
		}
	}

	[DisplayName("满足条件单位数量阈值")]
	[UProperty]
	[Tooltip("大于0时，代表最少要满足的数量\n小于0时，代表最多可以满足的数量\n0代表条件持续满足")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:SuccessCount")]
	public int SuccessCount
	{
		get
		{
			CheckDestroyed();
			if (!SuccessCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:SuccessCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectForce:SuccessCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessCount_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bDetectUnit = true;
		bDetectBullet = true;
		bDetectMagicField = true;
		SuccessCount = 1;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.DetectForce;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectForce:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (ForceType)
		{
		case EDetectedForceType.Friend:
			stringBuilder.Append("阵营 : 友方  ");
			break;
		case EDetectedForceType.Enemy:
			stringBuilder.Append("阵营 : 敌方  ");
			break;
		case EDetectedForceType.Other:
			stringBuilder.Append("阵营 : 其他  ");
			break;
		}
		if (bDetectUnit)
		{
			stringBuilder.Append(" 角色 |");
		}
		if (bDetectBullet)
		{
			stringBuilder.Append(" 子弹 |");
		}
		if (bDetectMagicField)
		{
			stringBuilder.Append(" 法术场 |");
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendLine($"条件数量：{Conditions.Count}  ");
		if (base.bReverseCondition)
		{
			stringBuilder.Append("失败条件：");
		}
		else
		{
			stringBuilder.Append("成功条件：");
		}
		if (SuccessCount == 0)
		{
			stringBuilder.Append("总是");
		}
		else if (SuccessCount > 0)
		{
			stringBuilder.Append($"满足所有条件的单位数量 >= {SuccessCount}");
		}
		else
		{
			stringBuilder.Append($"满足所有条件的单位数量 <= {-SuccessCount}");
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_DetectForce behaviorCustom_DetectForce = new BehaviorCustom_DetectForce();
		behaviorCustom_DetectForce.IsReverseCondition = base.bReverseCondition;
		behaviorCustom_DetectForce.ConditionCoolDownTimeMs = base.ConditionCoolDownTimeMs;
		behaviorCustom_DetectForce.ForceType = (int)ForceType;
		behaviorCustom_DetectForce.DetectFilter = (int)(0u | (bDetectUnit ? 1u : 0u) | (uint)(bDetectBullet ? 2 : 0)) | (bDetectMagicField ? 4 : 0);
		foreach (FDetectCondition condition in Conditions)
		{
			behaviorCustom_DetectForce.Conditions.Add(condition.GetSerializableObject());
		}
		behaviorCustom_DetectForce.SuccessCount = SuccessCount;
		return behaviorCustom_DetectForce.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_DetectForce:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_DetectForce bED_BehaviorNode_DetectForce = GCHelper.Find<b1.BED_BehaviorNode_DetectForce>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_DetectForce.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_DetectForce");
		NativeReflection.GetPropertyRef(ref ForceType_PropertyAddress, intPtr, "ForceType");
		ForceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceType");
		ForceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bDetectUnit_PropertyAddress, intPtr, "bDetectUnit");
		bDetectUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDetectUnit");
		bDetectUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDetectUnit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDetectBullet_PropertyAddress, intPtr, "bDetectBullet");
		bDetectBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDetectBullet");
		bDetectBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDetectBullet", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDetectMagicField_PropertyAddress, intPtr, "bDetectMagicField");
		bDetectMagicField_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDetectMagicField");
		bDetectMagicField_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDetectMagicField", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		SuccessCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessCount");
		SuccessCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessCount", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_DetectForce:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_DetectForce()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_DetectForce)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_DetectForce));
	}
}
