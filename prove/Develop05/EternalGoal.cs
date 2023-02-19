public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return string.Format("EternalGoal:{0},{1},{2}", GetName(), GetDescription(), GetPoints());
    }

    public override void CreateGoal(string goalInfo)
    {
        List<string> infoList = goalInfo.Split(",").ToList();
        SetName(infoList[0]);
        SetDescription(infoList[1]);
        SetPoints(int.Parse(infoList[2]));
    }
}