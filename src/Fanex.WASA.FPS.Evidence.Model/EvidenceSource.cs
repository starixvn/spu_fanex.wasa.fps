namespace Fanex.WASA.FPS.Evidence.Model
{
    public enum EvidenceSource : byte
    {
        /// <summary>
        /// Unknown evidence source.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Evidence infected from web environment.
        /// </summary>
        Web = 1,

        /// <summary>
        /// Evidence infected from windows service environment.
        /// </summary>
        Win = 2
    }
}
