public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public void SetIsComleted(bool status)
    {
        _isCompleted = status;
    }

    public override void DisplayGoal()
    {
        if (_isCompleted)
        {
            Console.Write("[X]");
        }
        else
        {
            Console.Write("[ ]");
        }

        Console.WriteLine($" {GetName()} ({GetDescription()})");
    }

    public override string GetStringRepresentation()
    {
        return string.Format("SimpleGoal:{0},{1},{2},{3}", GetName(), GetDescription(), GetPoints(), _isCompleted);
    }

    public override void CreateGoal(string goalInfo)
    {
        List<string> infoList = goalInfo.Split(",").ToList();
        SetName(infoList[0]);
        SetDescription(infoList[1]);
        SetPoints(int.Parse(infoList[2]));
        SetIsComleted(bool.Parse(infoList[3]));
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        return GetPoints();
    }
}