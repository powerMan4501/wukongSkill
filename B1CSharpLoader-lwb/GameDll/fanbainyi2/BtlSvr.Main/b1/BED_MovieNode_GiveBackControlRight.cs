using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("交还操作")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight")]
internal class BED_MovieNode_GiveBackControlRight : BED_MovieNode
{
	private static bool CameraBlendOutTime_IsValid;

	private static int CameraBlendOutTime_Offset;

	private static bool CameraBlendOutFunction_IsValid;

	private static int CameraBlendOutFunction_Offset;

	private static FFieldAddress CameraBlendOutFunction_PropertyAddress;

	private static bool CameraBlendOutFuncExp_IsValid;

	private static int CameraBlendOutFuncExp_Offset;

	[DisplayName("淡出时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutTime")]
	public float CameraBlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("淡出函数")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFunction")]
	public EViewTargetBlendFunction CameraBlendOutFunction
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, CameraBlendOutFunction_Offset), 0, CameraBlendOutFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, CameraBlendOutFunction_Offset), 0, CameraBlendOutFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("淡出系数")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFuncExp")]
	public float CameraBlendOutFuncExp
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFuncExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendOutFuncExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight:CameraBlendOutFuncExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendOutFuncExp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		CameraBlendOutTime = 2f;
		CameraBlendOutFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		CameraBlendOutFuncExp = 1.5f;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.GiveBackControlRight;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_GiveBackControlRight
		{
			CameraBlendOutTime = CameraBlendOutTime,
			CameraBlendOutFunc = (int)CameraBlendOutFunction,
			CameraBlendOutExp = CameraBlendOutFuncExp
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_GiveBackControlRight");
		CameraBlendOutTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendOutTime");
		CameraBlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendOutTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CameraBlendOutFunction_PropertyAddress, unrealStruct, "CameraBlendOutFunction");
		CameraBlendOutFunction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendOutFunction");
		CameraBlendOutFunction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendOutFunction", Classes.FEnumProperty);
		CameraBlendOutFuncExp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendOutFuncExp");
		CameraBlendOutFuncExp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendOutFuncExp", Classes.FFloatProperty);
	}

	static BED_MovieNode_GiveBackControlRight()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_GiveBackControlRight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_GiveBackControlRight));
	}
}
