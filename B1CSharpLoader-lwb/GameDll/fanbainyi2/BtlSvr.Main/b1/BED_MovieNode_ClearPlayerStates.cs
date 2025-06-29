using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("主角：清除某些状态")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_ClearPlayerStates")]
internal class BED_MovieNode_ClearPlayerStates : BED_MovieNode
{
	private static bool bStopJump_IsValid;

	private static int bStopJump_Offset;

	private static FFieldAddress bStopJump_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("停止跳跃")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ClearPlayerStates:bStopJump")]
	public bool bStopJump
	{
		get
		{
			CheckDestroyed();
			if (!bStopJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ClearPlayerStates:bStopJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopJump_Offset), 0, bStopJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ClearPlayerStates:bStopJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopJump_Offset), 0, bStopJump_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bStopJump = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.ClearPlayerStates;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_ClearPlayerStates
		{
			IsStopJump = bStopJump
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_ClearPlayerStates");
		NativeReflection.GetPropertyRef(ref bStopJump_PropertyAddress, unrealStruct, "bStopJump");
		bStopJump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStopJump");
		bStopJump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStopJump", Classes.FBoolProperty);
	}

	static BED_MovieNode_ClearPlayerStates()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_ClearPlayerStates)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_ClearPlayerStates));
	}
}
