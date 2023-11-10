using projet.Debugging;

namespace projet
{
    public class projetConsts
    {
        public const string LocalizationSourceName = "projet";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d81c6b4b0d764e9baa518f2d969516b1";
    }
}
