namespace M1.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entity, object key)
            : base($"Entity {entity} ({key}) not found.") { }
    }
}
