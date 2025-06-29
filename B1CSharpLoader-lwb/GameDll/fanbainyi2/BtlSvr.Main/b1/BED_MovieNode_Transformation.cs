using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("变身")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Transformation")]
internal class BED_MovieNode_Transformation : BED_MovieNode
{
	private static bool ResID_IsValid;

	private static int ResID_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[Category("Transformation")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Transformation:ResID")]
	protected int ResID
	{
		get
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Transformation:ResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Transformation:ResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ResID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Player");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_Transformation:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"触发主角变身为ResID : {ResID}的角色");
		return stringBuilder.ToString();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Transformation;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_Transformation
		{
			ResId = ResID
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_Transformation:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_Transformation bED_MovieNode_Transformation = GCHelper.Find<b1.BED_MovieNode_Transformation>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_Transformation.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Transformation");
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_Transformation:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_Transformation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Transformation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Transformation));
	}
}
