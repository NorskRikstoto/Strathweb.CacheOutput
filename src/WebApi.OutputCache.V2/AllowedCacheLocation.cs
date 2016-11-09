namespace WebApi.OutputCache.V2
{
    public enum AllowedCacheLocation
    {
        // Not specified
        Undefined,

        // Response can be cached by browser but not by intermediary cache
        Private, 

        // Response can be cached by browser and intermediary cache
        Public
    }
}