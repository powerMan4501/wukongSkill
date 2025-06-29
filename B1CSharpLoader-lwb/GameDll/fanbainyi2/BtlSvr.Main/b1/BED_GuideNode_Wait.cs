using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Wait")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_GuideNode_Wait")]
public class BED_GuideNode_Wait : BED_GuideNode_Base
{
	private static bool WaitSecond_IsValid;

	private static int WaitSecond_Offset;

	private static bool WaitSecondFloat_IsValid;

	private static int WaitSecondFloat_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("等待时间（秒）(已废除)")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("新手指引")]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecond")]
	public int WaitSecond
	{
		get
		{
			CheckDestroyed();
			if (!WaitSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecond");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WaitSecond_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecond");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WaitSecond_Offset), value);
			}
		}
	}

	[Category("新手指引")]
	[BlueprintReadWrite]
	[DisplayName("等待时间（秒）")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecondFloat")]
	public float WaitSecondFloat
	{
		get
		{
			CheckDestroyed();
			if (!WaitSecondFloat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecondFloat");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaitSecondFloat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitSecondFloat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Wait:WaitSecondFloat");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaitSecondFloat_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "新手指引";
		base.NodeStyle = ECalliopeNodeStyle.Transit;
		base.SupportsContextPins = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.GuideNode.Wait;
	}

	[USharpPath("/Script/b1-Managed.BED_GuideNode_Wait:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"等待时间：{WaitSecondFloat}";
	}

	public override byte[] GetCustomData()
	{
		return new GuideCustom_Wait
		{
			WaitSecond = WaitSecond,
			WaitSecondFloat = WaitSecondFloat
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_GuideNode_Wait:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_GuideNode_Wait bED_GuideNode_Wait = GCHelper.Find<BED_GuideNode_Wait>(obj);
		string nodeDescriptionInCS_Implementation = bED_GuideNode_Wait.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_GuideNode_Wait");
		WaitSecond_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitSecond");
		WaitSecond_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitSecond", Classes.FIntProperty);
		WaitSecondFloat_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitSecondFloat");
		WaitSecondFloat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitSecondFloat", Classes.FFloatProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_GuideNode_Wait:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_GuideNode_Wait()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_GuideNode_Wait)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_GuideNode_Wait));
	}
}
