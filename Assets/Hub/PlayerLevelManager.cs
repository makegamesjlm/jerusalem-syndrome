public class PlayerLevelManager
{
    private int playerLevel;
    private int playerExperience;
    private int levelScale;
    /**
     * param - levelScale - calculate level by simple division of total experience by levelScale. 
     */
    public PlayerLevelManager(int levelScale)
    {
        this.playerLevel = 1;
        this.playerExperience = 0;
        this.levelScale = levelScale;
    }
    public void addExperience(int experience)
    {
        this.playerExperience += experience;
        this.playerLevel = this.levelScale / experience;
    }

    public int getExperience() {
        return this.playerExperience;
    }
    public int getLevel() {
        return this.playerLevel;

    }
}