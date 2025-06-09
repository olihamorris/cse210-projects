public class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;
    private int Bonus;

    public ChecklistGoal()
    {
        IsComplete = false;
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                IsComplete = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} ({Description}) -- Completed {CurrentCount}/{TargetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{CurrentCount}|{Bonus}|{IsComplete}";
    }

    public override void Deserialize(string data)
    {
        string[] parts = data.Split('|');
        Name = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
        TargetCount = int.Parse(parts[4]);
        CurrentCount = int.Parse(parts[5]);
        Bonus = int.Parse(parts[6]);
        IsComplete = bool.Parse(parts[7]);
    }
}