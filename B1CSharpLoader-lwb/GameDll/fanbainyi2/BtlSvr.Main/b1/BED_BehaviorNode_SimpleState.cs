using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("SimpleState")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_SimpleState")]
internal class BED_BehaviorNode_SimpleState : b1.BED_BehaviorNode_Action
{
	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool bAdd_IsValid;

	private static int bAdd_Offset;

	private static FFieldAddress bAdd_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_SimpleState:SimpleState")]
	public EBGUSimpleState SimpleState
	{
		get
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_SimpleState:SimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_SimpleState:SimpleState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("添加or移除")]
	[Tooltip("勾选是添加，不勾是移除")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_SimpleState:bAdd")]
	public bool bAdd
	{
		get
		{
			CheckDestroyed();
			if (!bAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_SimpleState:bAdd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAdd_Offset), 0, bAdd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_SimpleState:bAdd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAdd_Offset), 0, bAdd_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bAdd = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.SimpleState;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_SimpleState
		{
			SimpleState = (int)SimpleState,
			IsAdd = bAdd
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_SimpleState:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (bAdd)
		{
			stringBuilder.Append("添加SimpleState : ");
		}
		else
		{
			stringBuilder.Append("移除SimpleState : ");
		}
		stringBuilder.Append(SimpleState);
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_SimpleState:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_SimpleState bED_BehaviorNode_SimpleState = GCHelper.Find<b1.BED_BehaviorNode_SimpleState>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_SimpleState.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_SimpleState");
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bAdd_PropertyAddress, intPtr, "bAdd");
		bAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAdd");
		bAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAdd", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_SimpleState:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_SimpleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_SimpleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_SimpleState));
	}
}
