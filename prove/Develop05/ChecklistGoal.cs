public class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _timesToComplete;
    private int _timesDone;

    public CheckListGoal(string name, string description, int points, int bonusPoints, int timesToComplete) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;
        _timesDone = 0;
    }

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public void SetTimesToComplete(int timesToComplete)
    {
        _timesToComplete = timesToComplete;
    }

    public void SetTimesDone(int timesDone)
    {
        _timesDone = timesDone;
    }
    public override void DisplayGoal()
    {
        if (_timesDone < _timesToComplete)
        {
            Console.Write("[ ]");
        }
        else
        {
            Console.Write("[X]");
        }
        Console.WriteLine($" {GetName()} ({GetDescription()}) -- Currently completed: {_timesDone}/{_timesToComplete}");
    }

    public override string GetStringRepresentation()
    {
        return string.Format("ChecklistGoal:{0},{1},{2},{3},{4},{5}", GetName(), GetDescription(), GetPoints(), _bonusPoints, _timesToComplete, _timesDone);
    }

    public override void CreateGoal(string goalInfo)
    {
        List<string> infoList = goalInfo.Split(",").ToList();
        SetName(infoList[0]);
        SetDescription(infoList[1]);
        SetPoints(int.Parse(infoList[2]));
        SetBonusPoints(int.Parse(infoList[3]));
        SetTimesToComplete(int.Parse(infoList[4]));
        SetTimesDone(int.Parse(infoList[5]));
    }

    public override int RecordEvent()
    {
        _timesDone++;
        if (_timesDone == _timesToComplete)
        {
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }
}