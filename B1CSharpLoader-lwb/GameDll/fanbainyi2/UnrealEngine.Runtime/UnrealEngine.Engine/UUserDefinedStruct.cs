using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UMetaPath("/Script/Engine.UserDefinedStruct", "CoreUObject", UnrealModuleType.Engine)]
public class UUserDefinedStruct : UScriptStruct
{
	public EUserDefinedStructureStatus Status
	{
		get
		{
			if (Native_UUserDefinedStruct.Get_Status == null)
			{
				return EUserDefinedStructureStatus.UpToDate;
			}
			return Native_UUserDefinedStruct.Get_Status(base.Address);
		}
		set
		{
			if (Native_UUserDefinedStruct.Set_Status != null)
			{
				Native_UUserDefinedStruct.Set_Status(base.Address, value);
			}
		}
	}

	public string ErrorMessage
	{
		get
		{
			if (Native_UUserDefinedStruct.Get_ErrorMessage == null)
			{
				return null;
			}
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_UUserDefinedStruct.Get_ErrorMessage(base.Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			if (Native_UUserDefinedStruct.Set_ErrorMessage == null)
			{
				return;
			}
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_UUserDefinedStruct.Set_ErrorMessage(base.Address, ref fStringUnsafe.Array);
		}
	}

	public UObject EditorData
	{
		get
		{
			if (Native_UUserDefinedStruct.Get_EditorData == null)
			{
				return null;
			}
			return GCHelper.Find<UObject>(Native_UUserDefinedStruct.Get_EditorData(base.Address));
		}
		set
		{
			if (Native_UUserDefinedStruct.Set_EditorData != null)
			{
				Native_UUserDefinedStruct.Set_EditorData(base.Address, (value == null) ? IntPtr.Zero : value.Address);
			}
		}
	}

	public Guid Guid
	{
		get
		{
			Native_UUserDefinedStruct.Get_Guid(base.Address, out var guid);
			return guid;
		}
		set
		{
			Native_UUserDefinedStruct.Set_Guid(base.Address, ref value);
		}
	}
}
