using System;

public static class DBConfig
{
    public static string dbServer = "localhost";
    public static string dbUser = "root";
    public static string dbName = "fintrack_db";
    public static string dbPass = "";

    public static string ConnStr => $"server={dbServer};user={dbUser};database={dbName};password={dbPass};";
}
