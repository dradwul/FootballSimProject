class Team
{
    private string teamname;
    private int attack, defense, coaching;

    public Team(string teamname, int attack, int defense, int coaching)
    {
        this.teamname = teamname;
        this.attack = attack;
        this.defense = defense;
        this.coaching = coaching;
    }
    public string TeamName { get { return teamname; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int Coaching { get { return coaching; } }
}