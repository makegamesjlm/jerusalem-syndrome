using UnityEngine;
public class PlayerLevelManager
{
    private int playerLevel;
    private int playerExperience;
    private int levelScale;

    private GameObject playerLevelUIText;
    private GameObject playerExperienceUIText;

    /**
     * param - levelScale - calculate level by simple division of total experience by levelScale. 
     */
    public PlayerLevelManager(int levelScale)
    {
        this.playerLevel = 1;
        this.playerExperience = 0;
        this.levelScale = levelScale;
        this.playerLevelUIText = GameObject.Find("LevelText");
        this.playerExperienceUIText = GameObject.Find("ExperienceText");
        //Set text of initial player level/exp.
        this.playerLevelUIText.GetComponent<UnityEngine.UI.Text>().text = "Level: " + this.getLevel();
        this.playerExperienceUIText.GetComponent<UnityEngine.UI.Text>().text = "Exp: " + this.getExperience();
    }
    public void addExperience(int experience)
    {
        this.playerExperience += experience;
        this.playerLevel = this.levelScale / experience;
        this.playerLevelUIText.GetComponent<UnityEngine.UI.Text>().text = "Level: " + this.getLevel();
        this.playerExperienceUIText.GetComponent<UnityEngine.UI.Text>().text = "Exp: " + this.getExperience();
    }

    public int getExperience()
    {
        return this.playerExperience;
    }
    public int getLevel()
    {
        return this.playerLevel;
    }
}