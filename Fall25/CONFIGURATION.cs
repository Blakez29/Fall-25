namespace Fall25;

public class CONFIGURATION
{
    public static void BIND(IConfiguration configuration, string[] args)
    {
        configuration.Bind(instance);    
    }

    public static string INPUT_DATA_FILE_PATH => instance.INPUT_DATA_DIRECTORY;

    private static configuration instance { get; set; } = new configuration();

    private class configuration
    {
        public string INPUT_DATA_DIRECTORY { get; set; }
    }
}
