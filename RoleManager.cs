using System.Collections.Generic;

public static class RoleManager
{
    private static List<TacticalRole> _allAvailableRoles;

    static RoleManager()
    {
        InitializeAllAvailableRoles();
    }

    private static void InitializeAllAvailableRoles()
    {
        _allAvailableRoles = new List<TacticalRole>
        {
            // GK
            new Goalkeeper(),
            new SweeperKeeper(),
            
            // Def
            new BallPlayingDefender(),

            // Mid
            new HalfBack(),
            new BoxToBoxMidfielder(),
            
            // Flank
            new FullBack(),
            new WingBack(),
            new Winger(),

            // CenterAttack
            new AttackingMidfielder(),
            
            new Poacher(),
            new FalseNine()
        };
    }

    public static List<TacticalRole> GetAllAvailableRoles()
    {
        return _allAvailableRoles;
    }
}
