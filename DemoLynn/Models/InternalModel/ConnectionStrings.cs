namespace DemoLynn.Models.InternalModel
{
    public class ConnectionStrings
    {
        public string MessagesBroker { get; set; }
        public ConnectionStrings() { }

        public static IConfigurationSection Provider
        {
            get;
            set;
        }
    }
}
