namespace katalog_3d_respository.setting
{
    public class MsSqlSetting
    {
        public string? Host { get; init; }
        public int Port { get; init; }
        public string? DatabaseName { get; init; }
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string ConnectionString => $"Server={Host},{Port};Database={DatabaseName};User Id={Username};Password={Password};";
    }
}