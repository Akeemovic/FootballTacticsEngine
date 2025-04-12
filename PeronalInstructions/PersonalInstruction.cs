public class PersonalInstruction
{
    public OnOppositionHasBall OnOppositionHasBall { get;  private set; }
    public OnTeamHasBall OnTeamHasBall { get; private set; }
    public OnPlayerHasBall OnPlayerHasBall { get; private set; }

    // Default constructor
    public PersonalInstruction()
    {
        OnOppositionHasBall = new OnOppositionHasBall();
        OnTeamHasBall = new OnTeamHasBall();
        OnPlayerHasBall = new OnPlayerHasBall();
    }
}
