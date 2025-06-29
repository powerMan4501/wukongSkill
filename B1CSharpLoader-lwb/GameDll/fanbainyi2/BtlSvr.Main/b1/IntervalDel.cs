namespace b1;

public delegate TResult IntervalDel<T1, T2, T3, T4, T5, TResult>(out T1 AccumulatedDeltaTime, out T2 DifferenceTime1, out T3 DifferenceTime2, out T4 DifferenceTime3, out T5 DifferenceTime4);
