using System;
using UnrealEngine.Engine;

namespace b1;

internal class BGU_Timeline
{
	public delegate void Del_Void();

	public delegate void Del_Void_Float(float InTime);

	public Del_Void_Float TimelineInterpFunc = delegate
	{
	};

	public Del_Void TimelineFinishedFunc = delegate
	{
	};

	private bool bLooping;

	private bool bPlaying;

	private float Length;

	private float PlayRate = 1f;

	private float Position;

	public BGU_Timeline(float PlayRate = 1f, bool bLooping = false)
	{
		this.PlayRate = PlayRate;
		this.bLooping = bLooping;
	}

	public void Play()
	{
		bPlaying = true;
	}

	public void PlayFromStart()
	{
		SetPlaybackPosition(0f, bFireEvents: false);
		Play();
	}

	public void Stop()
	{
		bPlaying = false;
	}

	public bool IsPlaying()
	{
		return bPlaying;
	}

	public void SetPlaybackPosition(float NewPosition, bool bFireEvents)
	{
		_ = Position;
		Position = NewPosition;
		TimelineInterpFunc(Position);
	}

	public float GetPlaybackPosition()
	{
		return Position;
	}

	public void SetLooping(bool bNewLooping)
	{
		bLooping = bNewLooping;
	}

	public bool IsLooping()
	{
		return bLooping;
	}

	public void SetPlayRate(float NewRate)
	{
		PlayRate = NewRate;
	}

	public float GetPlayRate()
	{
		return PlayRate;
	}

	public void SetTimelineLength(float NewLength)
	{
		Length = NewLength;
		if (Position > NewLength)
		{
			SetPlaybackPosition(NewLength - 1E-08f, bFireEvents: false);
		}
	}

	public void SetTimelineLength(UCurveFloat Curve)
	{
		if (!(Curve == null))
		{
			Curve.GetTimeRange(out var _, out var MaxTime);
			SetTimelineLength(MaxTime);
		}
	}

	public void SetTimelineFinishedFunc(Del_Void NewTimelineFinishedFunc)
	{
		TimelineFinishedFunc = (Del_Void)Delegate.Combine(TimelineFinishedFunc, NewTimelineFinishedFunc);
	}

	public void TickTimeline(float DeltaTime)
	{
		if (Length == 0f)
		{
			return;
		}
		bool flag = false;
		if (bPlaying)
		{
			float length = Length;
			float num = DeltaTime * PlayRate;
			float num2 = Position + num;
			if (num > 0f)
			{
				if (num2 > length)
				{
					if (bLooping)
					{
						SetPlaybackPosition(length, bFireEvents: true);
						SetPlaybackPosition(0f, bFireEvents: false);
						if (length > 0f)
						{
							while (num2 > length)
							{
								num2 -= length;
							}
						}
						else
						{
							num2 = 0f;
						}
					}
					else
					{
						num2 = length;
						Stop();
						flag = true;
					}
				}
			}
			else if (num2 < 0f)
			{
				if (bLooping)
				{
					SetPlaybackPosition(0f, bFireEvents: true);
					SetPlaybackPosition(length, bFireEvents: false);
					if (length > 0f)
					{
						for (; num2 < 0f; num2 += length)
						{
						}
					}
					else
					{
						num2 = 0f;
					}
				}
				else
				{
					num2 = 0f;
					Stop();
					flag = true;
				}
			}
			SetPlaybackPosition(num2, bFireEvents: true);
		}
		if (flag)
		{
			TimelineFinishedFunc();
		}
	}
}
