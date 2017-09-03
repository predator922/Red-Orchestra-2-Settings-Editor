
public class config
{
    private string setting;
    private string value;
    public config(string setting, string value){
        this.setting = setting;
        this.value = value;
    }
    public string Setting
    {
        get
        {
            return setting;
        }
        set
        {
            setting = value;
        }
    }
    public string Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
        }
    }

}