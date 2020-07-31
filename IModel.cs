namespace EzyContracts
{
    /// <summary>
    /// Identifies a model (belonging to the domain of an application but can be used in external operations) <para />
    /// This model must implement a mapping method to an ICoreEntity
    /// </summary>
    public interface IModel
    {

        T ToCoreEntity<T>() where T : ICoreEntity;
    }
}