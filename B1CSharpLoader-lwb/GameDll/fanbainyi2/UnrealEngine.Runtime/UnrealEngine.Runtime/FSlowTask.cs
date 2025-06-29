using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FSlowTask : IDisposable
{
	public IntPtr Address { get; internal set; }

	public string DefaultMessage
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSlowTask.Get_DefaultMessageStr(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FSlowTask.Set_DefaultMessageStr(Address, ref fStringUnsafe.Array);
		}
	}

	public string FrameMessage
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSlowTask.Get_FrameMessageStr(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FSlowTask.Set_FrameMessageStr(Address, ref fStringUnsafe.Array);
		}
	}

	public float TotalAmountOfWork
	{
		get
		{
			return Native_FSlowTask.Get_TotalAmountOfWork(Address);
		}
		set
		{
			Native_FSlowTask.Set_TotalAmountOfWork(Address, value);
		}
	}

	public float CompletedWork
	{
		get
		{
			return Native_FSlowTask.Get_CompletedWork(Address);
		}
		set
		{
			Native_FSlowTask.Set_CompletedWork(Address, value);
		}
	}

	public float CurrentFrameScope
	{
		get
		{
			return Native_FSlowTask.Get_CurrentFrameScope(Address);
		}
		set
		{
			Native_FSlowTask.Set_CurrentFrameScope(Address, value);
		}
	}

	public ESlowTaskVisibility Visibility
	{
		get
		{
			return (ESlowTaskVisibility)Native_FSlowTask.Get_Visibility(Address);
		}
		set
		{
			Native_FSlowTask.Set_Visibility(Address, (int)value);
		}
	}

	public double StartTime
	{
		get
		{
			return Native_FSlowTask.Get_StartTime(Address);
		}
		set
		{
			Native_FSlowTask.Set_StartTime(Address, value);
		}
	}

	public float? OpenDialogThreshold
	{
		get
		{
			csbool hasValue;
			float value = Native_FSlowTask.Get_OpenDialogThreshold(Address, out hasValue);
			if (!hasValue)
			{
				return null;
			}
			return value;
		}
		set
		{
			Native_FSlowTask.Set_OpenDialogThreshold(Address, (!value.HasValue) ? 0f : value.Value, value.HasValue);
		}
	}

	internal FSlowTask()
	{
	}

	public FSlowTask(float amountOfWork, string defaultMessage = null, bool enabled = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(defaultMessage);
		Address = Native_FSlowTask.New(amountOfWork, ref fStringUnsafe.Array, enabled);
	}

	public void Dispose()
	{
		Destroy();
		Native_FSlowTask.Delete(Address);
	}

	public void Initialize()
	{
		Native_FSlowTask.Initialize(Address);
	}

	public void Destroy()
	{
		Native_FSlowTask.Destroy(Address);
	}

	public void MakeDialogDelayed(float threshold, bool showCancelButton = false, bool allowInPIE = false)
	{
		Native_FSlowTask.MakeDialogDelayed(Address, threshold, showCancelButton, allowInPIE);
	}

	public void MakeDialog(bool showCancelButton = false, bool allowInPIE = false)
	{
		Native_FSlowTask.MakeDialog(Address, showCancelButton, allowInPIE);
	}

	public void EnterProgressFrame(float expectedWorkThisFrame = 1f, string text = null)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(text);
		Native_FSlowTask.EnterProgressFrame(Address, expectedWorkThisFrame, ref fStringUnsafe.Array);
	}

	public string GetCurrentMessage()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FSlowTask.GetCurrentMessage(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool ShouldCancel()
	{
		return Native_FSlowTask.ShouldCancel(Address);
	}
}
