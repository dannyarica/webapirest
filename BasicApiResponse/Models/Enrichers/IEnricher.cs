namespace BasicApiResponse.Models.Enrichers
{
    public interface IEnricher<I,O>
    {
        O Enrich(I model);
    }
}