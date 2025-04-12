using System;

class Program 
{
    static TacticalPosition GK;
    static TacticalPosition DL, DCL, DC, DCR, DR;
    static TacticalPosition DML, DMCL, DMC, DMCR, DMR;
    static TacticalPosition ML, MCL, MC, MCR, MR;
    static TacticalPosition AML, AMCL, AMC, AMCR, AMR;
    static TacticalPosition STCL, STC, STCR;
    
    public static void Main(string[] args) 
    {
        PersonalInstruction instruction = new PersonalInstruction();
        var onOppositionHasBall = instruction.OnOppositionHasBall;
        var onTeamHasBall = instruction.OnTeamHasBall;
        var onPlayerHasBall = instruction.OnPlayerHasBall;
        
        Console.WriteLine("HoldUpBall: " + onPlayerHasBall.HoldUpBall);
        
        onPlayerHasBall.SetRequiredDefault<HoldUpBall>(HoldUpBall.Yes);
        Console.WriteLine("HoldUpBall: " + onPlayerHasBall.HoldUpBall);
        
        onPlayerHasBall.Set<HoldUpBall>(HoldUpBall.No);
        Console.WriteLine("HoldUpBall: " + onPlayerHasBall.HoldUpBall);

        Console.WriteLine("/n/n/n/n/");
        
        // Console.WriteLine("FlankMovement: " + onPlayerHasBall.FlankMovement);
        // Console.WriteLine("ShootingRate: " + onPlayerHasBall.ShootingRate);
        // Console.WriteLine("DribblingRate: " + onPlayerHasBall.DribblingRate);
        // Console.WriteLine("CrossingRate: " + onPlayerHasBall.CrossingRate);
        // Console.WriteLine("PassingStyle: " + onPlayerHasBall.PassingStyle);
        // Console.WriteLine("RiskyPassing: " + onPlayerHasBall.RiskyPassing);

        // Other();
    }

    public static void Other()
    {
        GK = TacticalPositionManager.GK;
        DL = TacticalPositionManager.DL;
        DCL = TacticalPositionManager.DCL;
        DC = TacticalPositionManager.DC;
        DCR = TacticalPositionManager.DCR;
        DR = TacticalPositionManager.DR;
        DML = TacticalPositionManager.DML;
        DMCL = TacticalPositionManager.DMCL;
        DMC = TacticalPositionManager.DMC;
        DMCR = TacticalPositionManager.DMCR;
        DMR = TacticalPositionManager.DMR;
        ML = TacticalPositionManager.ML;
        MCL = TacticalPositionManager.MCL;
        MC = TacticalPositionManager.MC;
        MCR = TacticalPositionManager.MCR;
        MR = TacticalPositionManager.MR;
        AML = TacticalPositionManager.AML;
        AMCL = TacticalPositionManager.AMCL;
        AMC = TacticalPositionManager.AMC;
        AMCR = TacticalPositionManager.AMCR;
        AMR = TacticalPositionManager.AMR;
        STCL = TacticalPositionManager.STCL;
        STC = TacticalPositionManager.STC;
        STCR = TacticalPositionManager.STCR;

        TacticalPosition[] allPositions = new TacticalPosition[] {
            GK,
            DL, DCL, DC, DCR, DR,
            DML, DMCL, DMC, DMCR, DMR,
            ML, MCL, MC, MCR, MR,
            AML, AMCL, AMC, AMCR, AMR,
            STCL, STC, STCR
        };

        foreach (TacticalPosition position in allPositions)
        {
            Console.WriteLine($"Position: {position.Position}, Group: {position.PositionGroup}");
        
            foreach (TacticalRole role in position.AvailableRoles)
            {
                Console.WriteLine($"  Role Name: {role.RoleName}");
                
                foreach (TacticalDutyOption duty in role.AvailableDuties)
                {
                    Console.WriteLine($"    Duty: {duty}");
                }
            }
        }
    }
}
