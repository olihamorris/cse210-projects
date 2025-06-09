public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} ({Description})";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public override void Deserialize(string data)
    {
        string[] parts = data.Split('|');
        Name = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
    }
}