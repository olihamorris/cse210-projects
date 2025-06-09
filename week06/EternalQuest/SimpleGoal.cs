public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
        }
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} ({Description})";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsComplete}";
    }

    public override void Deserialize(string data)
    {
        string[] parts = data.Split('|');
        Name = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
        IsComplete = bool.Parse(parts[4]);
    }
}